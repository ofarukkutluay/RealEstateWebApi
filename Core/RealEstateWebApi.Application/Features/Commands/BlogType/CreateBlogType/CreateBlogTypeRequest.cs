using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.BlogType.CreateBlogType
{
    public class CreateBlogTypeRequest : IRequest<CreateBlogTypeResponse>
    {
        public uint ClientId { get; set; }
        public string Title { get; set; }
    }
}
