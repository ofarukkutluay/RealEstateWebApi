using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.PropertyCategory.DeletePropertyCategory
{
    public class DeletePropertyCategoryRequest : IRequest<DeletePropertyCategoryResponse>
    {
        public uint Id { get; set; }
    }
}
