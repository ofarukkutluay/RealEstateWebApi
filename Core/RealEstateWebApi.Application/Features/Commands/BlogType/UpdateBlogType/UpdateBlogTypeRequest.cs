using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.BlogType.UpdateBlogType
{
    public class UpdateBlogTypeRequest : IRequest<UpdateBlogTypeResponse>
    {
        public uint Id { get; set; }
        public uint ClientId { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
