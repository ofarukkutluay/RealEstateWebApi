using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.PropertyStatus.DeletePropertyStatus
{
    public class DeletePropertyStatusRequest : IRequest<DeletePropertyStatusResponse>
    {
        public uint Id { get; set; }
    }
}
