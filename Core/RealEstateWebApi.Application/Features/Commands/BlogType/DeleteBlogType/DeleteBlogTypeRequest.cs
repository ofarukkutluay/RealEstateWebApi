using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.BlogType.DeleteBlogType
{
    public class DeleteBlogTypeRequest : IRequest<DeleteBlogTypeResponse>
    {
        public uint Id { get; set; }
    }
}
