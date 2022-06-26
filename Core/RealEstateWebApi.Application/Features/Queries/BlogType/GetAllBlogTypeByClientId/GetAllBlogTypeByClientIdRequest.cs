using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.BlogType.GetAllBlogTypeByClientId
{
    public class GetAllBlogTypeByClientIdRequest : IRequest<GetAllBlogTypeByClientIdResponse>
    {
        public uint ClientId { get; set; }
    }
}
