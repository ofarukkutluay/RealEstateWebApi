using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllCity;
using RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllDistrictByCitykey;
using RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllNeighborhoodByDistrictKey;
using RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllStreetByNeighborhoodKey;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationSupportController : Controller
    {
        private readonly IMediator _mediator;

        public LocationSupportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("City")]
        public async Task<IActionResult> GetAllCity()
        {
            GetAllCityResponse response = await _mediator.Send(new GetAllCityRequest());
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("District")]
        public async Task<IActionResult> GetAllDistrictByCityKey([FromQuery] GetAllDistrictByCityKeyRequest request)
        {
            GetAllDistrictByCityKeyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("Neighborhood")]
        public async Task<IActionResult> GetAllNeighborhoodByDistrictKey([FromQuery] GetAllNeighborhoodByDistrictKeyRequest request)
        {
            GetAllNeighborhoodByDistrictKeyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("Street")]
        public async Task<IActionResult> GetAllStreetByNeighborhoodKey([FromQuery] GetAllStreetByNeighborhoodKeyRequest request)
        {
            GetAllStreetByNeighborhoodKeyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
