﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.PropertyType.CreatePropertyType;
using RealEstateWebApi.Application.Features.Commands.PropertyType.DeletePropertyType;
using RealEstateWebApi.Application.Features.Commands.PropertyType.UpdatePropertyType;
using RealEstateWebApi.Application.Features.Queries.PropertyType.GetAllPropertyType;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyTypeController : Controller
    {
        private readonly IMediator _mediator;

        public PropertyTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreatePropertyType(CreatePropertyTypeRequest request)
        {
            CreatePropertyTypeResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdatePropertyType(UpdatePropertyTypeRequest request)
        {
            UpdatePropertyTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePropertyType(DeletePropertyTypeRequest request)
        {
            DeletePropertyTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPropertyType([FromQuery] GetAllPropertyTypeRequest request)
        {
            GetAllPropertyTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
