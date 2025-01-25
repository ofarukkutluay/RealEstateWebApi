using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.UsingStatus.DeleteUsingStatus
{
    public class DeleteUsingStatusRequest : IRequest<DeleteUsingStatusResponse>
    {
        public uint Id { get; set; }
    }
}
