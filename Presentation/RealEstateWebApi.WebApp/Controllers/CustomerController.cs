using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.JsonWebTokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;

namespace RealEstateWebApi.WebApp.Controllers;

public class CustomerController : BaseController
{

    private readonly ApiRequestService _requestService;

    public CustomerController(ApiRequestService requestService)
    {
        _requestService = requestService;
    }

    public async Task<IActionResult> Index()
    {
        var obj = await _requestService.Get<DataResult<IEnumerable<Customer>>>("customer");

        if (obj.Success == true)
        {
            SuccessAlert(obj.Message);
            return View(obj.Data);
        }

        DangerAlert(obj.Message);
        return View();
    }

    [HttpGet("/customer/add")]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(Customer customer)
    {
        uint loginUserId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);
        customer.AssignedUserId = loginUserId;

        var rtnObj = await _requestService.Post<Result>("customer", customer);

        if (rtnObj.Success == true)
        {
            SuccessAlert(rtnObj.Message);
            return RedirectToAction("Add");
        }

        DangerAlert(rtnObj.Message);
        return RedirectToAction("Add");
    }

    [HttpGet("/customer/{customerId}")]
    public async Task<IActionResult> Detail([FromRoute] uint customerId)
    {
        var entries = await _requestService.Get<DataResult<IEnumerable<Entry>>>("entry", "?CustomerId=" + customerId);
        var customer = await _requestService.Get<DataResult<Customer>>("customer", "/" + customerId);

        await SelectItemInitilaze();

        return View(Tuple.Create(customer.Data, entries.Data));


    }

    [HttpPost]
    public async Task<IActionResult> EntryAdd(Entry entry)
    {
        entry.UserId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);
        var rtnObj = await _requestService.Post<Result>("entry",entry);
        if (rtnObj.Success)
        {
            SuccessAlert(rtnObj.Message);
            return Redirect("/customer/" + entry.CustomerId);
        }
        DangerAlert(rtnObj.Message);
        return Redirect("/customer/" + entry.CustomerId);
    }

    async Task SelectItemInitilaze()
    {
        var entryTypes = await _requestService.Get<DataResult<IEnumerable<EntryType>>>("entryType");
        
        IEnumerable<SelectListItem> selectEntryTypes = entryTypes.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Title
        });
        
        ViewData.Add("EntryTypes", selectEntryTypes);
    
    }

    [HttpGet("/customer/SelectItemEntrySubType")]
    public async Task<IActionResult> SelectItemEntrySubType(uint id){
        var entrySubTypes = await _requestService.Get<DataResult<IEnumerable<EntrySubType>>>("entrySubType", "?EntryTypeId=", id.ToString());
        IEnumerable<SelectListItem> selectEntrySubTypes = entrySubTypes.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Title
        });
        return Json(selectEntrySubTypes);
    }


}