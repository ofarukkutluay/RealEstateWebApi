using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Blog.UploadBlogPageImgFile
{
    public class UploadBlogPageImgFileRequest : IRequest<UploadBlogPageImgFileResponse>
    {
        public uint BlogId { get; set; }
        public IFormFile BlogPageImgFile { get; set; }
    }
}
