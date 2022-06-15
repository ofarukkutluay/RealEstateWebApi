using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Blog.GetAllBlogByClientId
{
    public class GetAllBlogByClientIdRequest : IRequest<GetAllBlogByClientIdResponse>
    {
        public uint ClientId { get; set; }
    }
}
