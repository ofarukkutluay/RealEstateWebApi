using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Queries.OuterPropertyListing.GetAllOuterPropertyListing;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OuterPropertyListingController : Controller
    {
        private readonly IMediator _mediator;

        public OuterPropertyListingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> GetAllOuterPropertyListing()
        {
            GetAllOuterPropertyListingResponse response = await _mediator.Send(new GetAllOuterPropertyListingRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

    }
}
