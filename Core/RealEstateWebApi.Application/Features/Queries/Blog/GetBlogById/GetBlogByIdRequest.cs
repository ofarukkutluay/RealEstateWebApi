using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Blog.GetBlogById
{
    public class GetBlogByIdRequest : IRequest<GetBlogByIdResponse>
    {
        public uint BlogId { get; set; }
    }
}
