using RealEstateWebApi.WebApp.Data.Local;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
using Microsoft.EntityFrameworkCore;

namespace RealEstateWebApi.WebApp.Controllers;

[Authorize]
public class CustomerController : BaseController
{

    private readonly ApiRequestService _requestService;
    private readonly WebAppLocalDbContext _dbContext;
    public CustomerController(ApiRequestService requestService, WebAppLocalDbContext dbContext)
    {
        _requestService = requestService;
        _dbContext = dbContext;
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
        DataResult<IEnumerable<EntryDto>> entries = await _requestService.Get<DataResult<IEnumerable<EntryDto>>>("entry", "?CustomerId=" + customerId);
        DataResult<CustomerDto> customer = await _requestService.Get<DataResult<CustomerDto>>("customer", "/" + customerId);
        DataResult<IEnumerable<ShortPropertyDto>> ownedShortProperties = await _requestService.Get<DataResult<IEnumerable<ShortPropertyDto>>>("CustomerOwnedShortProperty", "/" + customerId);
        DataResult<IEnumerable<ShortPropertyDto>> searchShortProperties = await _requestService.Get<DataResult<IEnumerable<ShortPropertyDto>>>("CustomerSearchShortProperty", "/" + customerId);


        await SelectItemInitilazeDetailPage();

        return View(Tuple.Create(customer.Data, entries.Data,searchShortProperties.Data,ownedShortProperties.Data));


    }

    [HttpPost]
    public async Task<IActionResult> EntryAdd(Entry entry)
    {
        entry.UserId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);

        var rtnObj = await _requestService.Post<Result>("entry", entry);
        if (rtnObj.Success)
        {
            SuccessAlert("Kayıt eklendi");
            return Redirect("/customer/" + entry.CustomerId);
        }
        DangerAlert(rtnObj.Message);
        return Redirect("/customer/" + entry.CustomerId);
    }

    [HttpPost]
    public async Task<IActionResult> OwnedShortPropertyAdd(ShortProperty shortProperty)
    {
        var rtnObj = await _requestService.Post<Result>("customerOwnedShortProperty", shortProperty);
        if (rtnObj.Success)
        {
            SuccessAlert("Kayıt eklendi");
            return Redirect("/customer/" + shortProperty.CustomerId);
        }
        DangerAlert(rtnObj.Message);
        return Redirect("/customer/" + shortProperty.CustomerId);
    }

    [HttpPost]
    public async Task<IActionResult> SearchShortPropertyAdd(ShortProperty shortProperty)
    {
        var rtnObj = await _requestService.Post<Result>("customerSearchShortProperty", shortProperty);
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

        ViewData.Add("Cities", selectCities);
        ViewData.Add("EntryTypes", selectEntryTypes);
        ViewData.Add("PropertyTypes", selectPropertTypes);
        ViewData.Add("PropertyStatuses", selectPropertyStatuses);

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


}