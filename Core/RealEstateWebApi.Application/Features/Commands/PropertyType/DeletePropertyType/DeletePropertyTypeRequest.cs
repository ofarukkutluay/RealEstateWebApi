using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.PropertyType.DeletePropertyType
{
    public class DeletePropertyTypeRequest : IRequest<DeletePropertyTypeResponse>
    {
        public uint Id { get; set; }
    }
}
