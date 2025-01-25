using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.DeedStatus.DeleteDeedStatus
{
    public class DeleteDeedStatusRequest : IRequest<DeleteDeedStatusResponse>
    {
        public uint Id { get; set; }
    }
}
