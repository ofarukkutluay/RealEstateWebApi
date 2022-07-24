using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.ShortProperty.DeleteShortProperty
{
    public class DeleteShortPropertyRequest : IRequest<DeleteShortPropertyResponse>
    {
        public uint Id { get; set; }
    }
}
