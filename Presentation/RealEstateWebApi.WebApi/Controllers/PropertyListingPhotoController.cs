using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Queries.PropertyListingPhoto.GetPropertyListingPhotoByOuterPropertyListingId;


namespace RealEstateWebApi.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PropertyListingPhotoController : Controller
{
    private readonly IMediator _mediator;

    public PropertyListingPhotoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetPropertyListingPhotoByOutterPropertyListingId(GetAllPropertyListingPhotoByOuterPropertyListingIdRequest request)
    {
        GetAllPropertyListingPhotoByOuterPropertyListingIdResponse response = await _mediator.Send(request);
        if (response.Success)
            return Ok(response);
        return BadRequest(response);
    }

}
