using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.UploadProfilePhotoUser
{
    public class UploadProfilePhotoUserRequest : IRequest<UploadProfilePhotoUserResponse>
    {
        public uint UserId { get; set; }
        public IFormFile ProfilePhoto { get; set; }
    }
}
