using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;

namespace RealEstateWebApi.WebApp.ViewComponents;

public class _DistrictSelectItemViewComponent : ViewComponent
{
    private readonly ApiRequestService _requestService;

    public _DistrictSelectItemViewComponent(ApiRequestService requestService)
    {
        _requestService = requestService;
    }

    public async Task<IViewComponentResult> InvokeAsync(int cityKey = -1 , int districtId=-1)
    {
        var result = await _requestService.Get<DataResult<IEnumerable<District>>>("LocationSupport/District","?CityKey=", cityKey.ToString());

        IEnumerable<SelectListItem> selectDistricts = result.Data.Select(x => new SelectListItem
        {
            Value = x.Id.ToString(),
            Text = x.Name,
            Selected = x.Id == districtId
        });

        ViewData.Add("selectDistricts", selectDistricts);

        return View();

    }
}
