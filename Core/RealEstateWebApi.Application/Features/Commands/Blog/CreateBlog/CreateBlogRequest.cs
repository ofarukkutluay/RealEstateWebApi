using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Blog.CreateBlog
{
    public class CreateBlogRequest : IRequest<CreateBlogResponse>
    {
        public uint ClientId { get; set; }
        public uint CompanyId { get; set; }
        public uint AgentId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public uint BlogTypeId { get; set; }
    }
}
