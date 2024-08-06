using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;

namespace RealEstateWebApi.WebApp.ViewComponents;

public class _CustomerStatusKeySelectItemViewComponent : ViewComponent
{
    private readonly ApiRequestService _requestService;

    public _CustomerStatusKeySelectItemViewComponent(ApiRequestService requestService)
    {
        _requestService = requestService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var result = await _requestService.Get<DataResult<IEnumerable<string>>>("customer/statuskeys");

        IEnumerable<SelectListItem> selectStatusKey = result.Data.Select(x => new SelectListItem
        {
            Value = x,
            Text = x
        });

        ViewData.Add("selectStatusKey", selectStatusKey);

        return View();

    }
}
