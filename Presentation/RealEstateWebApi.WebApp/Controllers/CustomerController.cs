using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstateWebApi.WebApp.Data.Local;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
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

    public async Task<IActionResult> Index()
    {
        var obj = await _requestService.Get<DataResult<IEnumerable<CustomerDto>>>("customer");

        if (obj.Success == true)
        {
            return View(obj.Data);
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


    async Task SelectItemInitilazeAddPage()
    {
        if (!_dbContext.Cities.Any())
        {
            var result = await _requestService.Get<DataResult<IEnumerable<City>>>("LocationSupport/City");
            _dbContext.Cities.AddRange(result.Data);
            _dbContext.SaveChanges();
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
            var result = await _requestService.Get<DataResult<IEnumerable<City>>>("LocationSupport/City");
            _dbContext.Cities.AddRange(result.Data);
            _dbContext.SaveChanges();
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
        if (_dbContext.Districts.Any())
        {
            _dbContext.Districts.RemoveRange(_dbContext.Districts);
            _dbContext.SaveChanges();
        }

        var result = await _requestService.Get<DataResult<IEnumerable<District>>>("LocationSupport/District", "?CityKey=", key.ToString());
        _dbContext.Districts.AddRange(result.Data);
        _dbContext.SaveChanges();
        IEnumerable<SelectListItem> selectDistricts = _dbContext.Districts.Select(x => new SelectListItem
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
        if (_dbContext.Neighborhoods.Any())
        {
            _dbContext.Neighborhoods.RemoveRange(_dbContext.Neighborhoods);
            _dbContext.SaveChanges();
        }

        var result = await _requestService.Get<DataResult<IEnumerable<Neighborhood>>>("LocationSupport/Neighborhood", "?DistrictKey=", key.ToString());
        _dbContext.Neighborhoods.AddRange(result.Data);
        _dbContext.SaveChanges();
        IEnumerable<SelectListItem> selectMahalle = _dbContext.Neighborhoods.Select(x => new SelectListItem
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


}