using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstateWebApi.WebApp.Data.Local;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
using System.Linq;
using System.Security.Claims;

namespace RealEstateWebApi.WebApp.Controllers;

[Authorize]
public class CustomerController : BaseController
{

    private readonly ApiRequestService _requestService;
    private readonly WebAppLocalDbContext _dbContext;
    private readonly IConfiguration _configuration;
    public CustomerController(ApiRequestService requestService, WebAppLocalDbContext dbContext, IConfiguration configuration)
    {
        _requestService = requestService;
        _dbContext = dbContext;
        _configuration = configuration;
    }

    public async Task<IActionResult> Index(Pagination pagination,CustomerFilter filter)
    {
        pagination.PageSize = 20;
        QueryBuilder queries = new QueryBuilder
        {
            { "PageIndex", pagination.PageIndex.ToString() },
            { "PageSize", pagination.PageSize.ToString() }
        };

        foreach (var item in filter.GetType().GetProperties())
        {
            if (item.GetValue(filter) != null)
            {
                queries.Add(item.Name, item.GetValue(filter).ToString());
            }
        }


        var obj = await _requestService.Get<DataResult<IEnumerable<CustomerDto>>>("customer",queries.ToString());
        decimal page = Convert.ToDecimal(obj.TotalDataCount) / Convert.ToDecimal(pagination.PageSize);

        QueryBuilder paginationQuery = new QueryBuilder(queries.SkipWhile((KeyValuePair<string, string> arg) => arg.Key == "PageIndex"));

        ViewData.Add("totalPage",Math.Ceiling(page));
        ViewData.Add("page",pagination.PageIndex);
        ViewData.Add("filterquery", paginationQuery.ToString());
        if (obj.Success == true)
        {
            await SelectItemInitilazeAddPage();
            await SelectItemUserNameList();
            await SelectItemEntryTypes();
            return View(obj.Data);
        }

        DangerAlert(obj.Message);
        return View();
    }


    [HttpGet("customer/ilansiz")]
    public async Task<IActionResult> Ilansiz()
    {
        uint loginUserId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);

        var obj = await _requestService.Get<DataResult<IEnumerable<CustomerDto>>>("customer/status","?AssignedUserId="+loginUserId,"&StatusKey=GIRME");

        if (obj.Success == true)
        {
            return View(obj.Data);
        }

        DangerAlert(obj.Message);
        return View();
    }

    [HttpGet("customer/takip")]
    public async Task<IActionResult> Takip()
    {
        uint loginUserId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);

        var obj = await _requestService.Get<DataResult<IEnumerable<CustomerDto>>>("customer/status", "?AssignedUserId=" + loginUserId, "&StatusKey=TAKIP");

        if (obj.Success == true)
        {
            return View(obj.Data);
        }

        DangerAlert(obj.Message);
        return View();
    }

    [HttpGet("customer/ilandakiler")]
    public async Task<IActionResult> Ilandakiler()
    {
        uint loginUserId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);

        var obj = await _requestService.Get<DataResult<IEnumerable<CustomerDto>>>("customer/status", "?AssignedUserId=" + loginUserId, "&StatusKey=YETKI");
        var objy = await _requestService.Get<DataResult<IEnumerable<CustomerDto>>>("customer/status", "?AssignedUserId=" + loginUserId, "&StatusKey=YETKISIZ");

        var list = new List<CustomerDto>();
        list.AddRange(obj.Data);
        list.AddRange(objy.Data);
        
        if (obj.Success == true)
        {
            return View(list);
        }

        DangerAlert(obj.Message);
        return View();
    }


    [HttpGet("/customer/add")]
    public async Task<IActionResult> Add()
    {
        await SelectItemInitilazeAddPage();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(Customer customer)
    {
        uint loginUserId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);
        customer.RegisterUserId = loginUserId;

        var rtnObj = await _requestService.Post<Result>("customer", customer);

        if (rtnObj.Success == true)
        {
            SuccessAlert(rtnObj.Message);
            return RedirectToAction("Index");
        }

        DangerAlert(rtnObj.Message);
        return RedirectToAction("Add");
    }

    [HttpGet("customer/ownedproperties")]
    public async Task<IActionResult> OwnedProperties(Pagination pagination, OwnedPropertiesFilter filter)
    {
        pagination.PageSize = 20;
        QueryBuilder queries = new QueryBuilder
        {
            { "PageIndex", pagination.PageIndex.ToString() },
            { "PageSize", pagination.PageSize.ToString() }
        };

        foreach (var item in filter.GetType().GetProperties())
        {
            if (item.GetValue(filter) != null)
            {
                queries.Add(item.Name, item.GetValue(filter).ToString());
            }
        }

        DataResult<IEnumerable<CustomerOwnedPropertyDto>> customerOwnedProperties = await _requestService.Get<DataResult<IEnumerable<CustomerOwnedPropertyDto>>>("CustomerOwnedProperty", queries.ToString());
        ViewData.Add("host", _configuration.GetSection("PhotoHost").Value);
        decimal page = Convert.ToDecimal(customerOwnedProperties.TotalDataCount) / Convert.ToDecimal(pagination.PageSize);

        QueryBuilder paginationQuery = new QueryBuilder(queries.SkipWhile((KeyValuePair<string, string> arg) => arg.Key == "PageIndex"));


        ViewData.Add("totalPage",Math.Ceiling(page));
        ViewData.Add("page",pagination.PageIndex);
        ViewData.Add("filterquery", paginationQuery.ToString());

        await SelectItemInitilazeDetailPage();
        return View(customerOwnedProperties.Data);
    }


    [HttpGet("/customer/{customerId}")]
    public async Task<IActionResult> Detail([FromRoute] uint customerId)
    {
        DataResult<CustomerDto> customerDto = await _requestService.Get<DataResult<CustomerDto>>("customer", "/dto/" + customerId);

        if (customerDto.Data.IsActive == false && HttpContext.User.Claims.First(e => e.Type == ClaimTypes.Role).Value != "Admin")
        {
            InfoAlert("Müşteri aktif olmadığı için görüntülenemez.");
            return RedirectToAction("Index");
        }

        DataResult<IEnumerable<EntryDto>> entries = await _requestService.Get<DataResult<IEnumerable<EntryDto>>>("entry", "?CustomerId=" + customerId);

        DataResult<Customer> customer = await _requestService.Get<DataResult<Customer>>("customer", "/" + customerId);
        DataResult<IEnumerable<CustomerOwnedPropertyDto>> ownedProperties = await _requestService.Get<DataResult<IEnumerable<CustomerOwnedPropertyDto>>>("CustomerOwnedProperty", "/" + customerId);
        DataResult<IEnumerable<CustomerSearchPropertyDto>> searchProperties = await _requestService.Get<DataResult<IEnumerable<CustomerSearchPropertyDto>>>("CustomerSearchProperty", "/" + customerId);

        ViewData.Add("host", _configuration.GetSection("PhotoHost").Value);

        await SelectItemInitilazeDetailPage();

        return View(Tuple.Create(customerDto.Data, entries.Data, searchProperties.Data, ownedProperties.Data, customer.Data));


    }

    

    [HttpPost]
    public async Task<IActionResult> EntryAdd(Entry entry)
    {
        entry.UserId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);

        var rtnObj = await _requestService.Post<Result>("entry", entry);

        if (entry.ReminderDate != null)
        {
            Reminder reminder = new Reminder()
            {
                UserId = entry.UserId,
                EntryId = uint.Parse(rtnObj.Message.Split(" ")[0]),
                CustomerId = entry.CustomerId,
                ReminderDate = (DateTime)entry.ReminderDate,
                Description = entry.Content,
            };

            var rmdrOj = await _requestService.Post<Result>("reminder", reminder);
            InfoAlert(rmdrOj.Message);

        }



        if (rtnObj.Success)
        {
            SuccessAlert("Kayıt eklendi");
            return Redirect("/customer/" + entry.CustomerId);
        }
        DangerAlert(rtnObj.Message);
        return Redirect("/customer/" + entry.CustomerId);
    }

    [HttpPost]
    public async Task<IActionResult> OwnedPropertyAdd(CustomerOwnedProperty shortProperty)
    {
        var rtnObj = await _requestService.Post<Result>("customerOwnedProperty", shortProperty);
        if (rtnObj.Success)
        {
            SuccessAlert("Kayıt eklendi");
            return Redirect("/customer/" + shortProperty.CustomerId);
        }
        DangerAlert(rtnObj.Message);
        return Redirect("/customer/" + shortProperty.CustomerId);
    }

    [HttpPost]
    public async Task<IActionResult> SearchPropertyAdd(CustomerSearchProperty shortProperty)
    {
        var rtnObj = await _requestService.Post<Result>("customerSearchProperty", shortProperty);
        if (rtnObj.Success)
        {
            SuccessAlert("Kayıt eklendi");
            return Redirect("/customer/" + shortProperty.CustomerId);
        }
        DangerAlert(rtnObj.Message);
        return Redirect("/customer/" + shortProperty.CustomerId);
    }

    [Route("/customer/remindercheck")]
    public async Task<IActionResult> ReminderCheck(uint reminderId)
    {
        var rtnObj = await _requestService.Delete<Result>("Reminder", new { Id = reminderId });
        if (rtnObj.Success == true)
        {
            SuccessAlert("Hatırlatma silindi");
            return Redirect(Request.Headers["Referer"].ToString());
        }

        DangerAlert(rtnObj.Message);
        return Redirect(Request.Headers["Referer"].ToString());
    }




    async Task SelectItemInitilazeAddPage()
    {
        if (!_dbContext.Cities.Any())
        {
            await GetCities();
        }

        IEnumerable<SelectListItem> selectCities = _dbContext.Cities.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Name
        });

        ViewData.Add("Cities", selectCities);
    }

    async Task SelectItemInitilazeDetailPage()
    {
        if (!_dbContext.Cities.Any())
        {
            await GetCities();
        }

        var entryTypes = await _requestService.Get<DataResult<IEnumerable<EntryType>>>("entryType");
        var propertyTypes = await _requestService.Get<DataResult<IEnumerable<TitleModel>>>("propertyType");
        var propertyStatuses = await _requestService.Get<DataResult<IEnumerable<TitleModel>>>("propertyStatus");
        var usernamelist = await _requestService.Get<DataResult<IEnumerable<User>>>("user/namelist");



        IEnumerable<SelectListItem> selectCities = _dbContext.Cities.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Name
        });

        IEnumerable<SelectListItem> selectEntryTypes = entryTypes.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Title
        });

        IEnumerable<SelectListItem> selectPropertTypes = propertyTypes.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Title
        });
        IEnumerable<SelectListItem> selectPropertyStatuses = propertyStatuses.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Title
        });

        IEnumerable<SelectListItem> selectUsernamelist = usernamelist.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = $"{x.FirstName} {x.LastName}"
        });

        ViewData.Add("Cities", selectCities);
        ViewData.Add("EntryTypes", selectEntryTypes);
        ViewData.Add("PropertyTypes", selectPropertTypes);
        ViewData.Add("PropertyStatuses", selectPropertyStatuses);
        ViewData.Add("UserNameList", selectUsernamelist);

    }
    
    
    async Task SelectItemUserNameList()
    {
        var usernamelist = await _requestService.Get<DataResult<IEnumerable<User>>>("user/namelist");
        IEnumerable<SelectListItem> selectUsernamelist = usernamelist.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = $"{x.FirstName} {x.LastName}"
        });
        
        ViewData.Add("UserNameList", selectUsernamelist);
    }
    
    async Task SelectItemEntryTypes()
    {
        IEnumerable<SelectListItem> selectEntryTypes = Enumerable.Empty<SelectListItem>();
        selectEntryTypes = selectEntryTypes.Append(new SelectListItem()
        {
            Value = "YENI",
            Text = "Yeni"
        }).Append(new SelectListItem()
        {
            Value = "TAKIP",
            Text = "Potansiyel Takip"
        }).Append(new SelectListItem()
        {
            Value = "GIRME",
            Text = "İlansız Çalış"
        }).Append(new SelectListItem()
        {
            Value = "YETKI",
            Text = "Yetkili İlan"
        }).Append(new SelectListItem()
        {
            Value = "YETKISIZ",
            Text = "Yetkisiz İlan"
        });
        ViewData.Add("StatusKey", selectEntryTypes);
    }

    [HttpGet("/customer/SelectItemEntrySubType")]
    public async Task<IActionResult> SelectItemEntrySubType(uint id)
    {
        var entrySubTypes = await _requestService.Get<DataResult<IEnumerable<EntrySubType>>>("entrySubType", "?EntryTypeId=", id.ToString());
        IEnumerable<SelectListItem> selectEntrySubTypes = entrySubTypes.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Title
        });

        return Json(selectEntrySubTypes);
    }

    [HttpGet("/customer/SelectItemDistrict")]
    public async Task<IActionResult> SelectItemDistrict([FromQuery] uint cityId)
    {
        int key = _dbContext.Cities.First(x => x.Id == cityId).Key;

        await GetDistricts(key);


        IEnumerable<SelectListItem> selectDistricts = _dbContext.Districts.Where(x => x.CityKey == key).Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Name
        });
        return Json(selectDistricts);
    }

    [HttpGet("/customer/SelectItemNeighborhood")]
    public async Task<IActionResult> SelectItemNeighborhood([FromQuery] uint districtId)
    {
        int key = _dbContext.Districts.First(e => e.Id == districtId).Key;
        await GetNeighborhoods(key);


        IEnumerable<SelectListItem> selectMahalle = _dbContext.Neighborhoods.Where(x => x.DistrictKey == key).Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Name
        });

        return Json(selectMahalle);

    }
    [HttpGet("/customer/SelectItemStreet")]
    public async Task<IActionResult> SelectItemStreet([FromQuery] uint neighborhoodId)
    {
        int key = _dbContext.Neighborhoods.First(e => e.Id == neighborhoodId).Key;

        var result = await _requestService.Get<DataResult<IEnumerable<Neighborhood>>>("LocationSupport/Street", "?NeighborhoodKey=", key.ToString());

        IEnumerable<SelectListItem> selectCadde = result.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Name
        });

        return Json(selectCadde);

    }

    private async Task GetCities()
    {
        var result = await _requestService.Get<DataResult<IEnumerable<City>>>("LocationSupport/City");
        foreach (var item in result.Data)
        {
            if (_dbContext.Cities.Contains(item))
                continue;
            _dbContext.Cities.Add(item);
        }
        _dbContext.SaveChanges();
    }

    private async Task GetDistricts(int cityKey)
    {
        var result = await _requestService.Get<DataResult<IEnumerable<District>>>("LocationSupport/District", "?CityKey=", cityKey.ToString());
        foreach (var item in result.Data)
        {
            if (_dbContext.Districts.Contains(item))
                continue;
            _dbContext.Districts.Add(item);
        }
        _dbContext.SaveChanges();
    }

    private async Task GetNeighborhoods(int districtKey)
    {
        var result = await _requestService.Get<DataResult<IEnumerable<Neighborhood>>>("LocationSupport/Neighborhood", "?DistrictKey=", districtKey.ToString());
        foreach (var item in result.Data)
        {
            if (_dbContext.Neighborhoods.Contains(item))
                continue;
            _dbContext.Neighborhoods.Add(item);
        }
        _dbContext.SaveChanges();
    }
    
    


}