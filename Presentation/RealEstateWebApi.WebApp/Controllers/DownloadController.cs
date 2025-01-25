using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;

namespace RealEstateWebApi.WebApp.Controllers;

public class DownloadController : Controller
{
    private ApiRequestService _apiRequestService;
    private readonly IConfiguration _configuration;

    public DownloadController(ApiRequestService apiRequestService, IConfiguration configuration)
    {
        _apiRequestService = apiRequestService;
        _configuration = configuration;
    }

    public async Task<IActionResult> DownloadFiles(string outerPropertyListingId)
    {
        var response = await _apiRequestService.Get<DataResult<byte[]>>("PropertyListingPhoto/download","?OuterPropertyListingId="+outerPropertyListingId);
        if (response.Success)
            return File(response.Data,"application/zip",outerPropertyListingId+"_all_photo.zip");
        return BadRequest(response.Message);
    }

}
