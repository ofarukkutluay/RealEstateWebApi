using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Blog.UpdateBlog
{
    public class UpdateBlogRequest : IRequest<UpdateBlogResponse>
    {
        public uint BlogId { get; set; }
        public uint ClientId { get; set; }
        public uint CompanyId { get; set; }
        public uint AgentId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public uint BlogTypeId { get; set; }
        public bool IsActive { get; set; }
    }
}
