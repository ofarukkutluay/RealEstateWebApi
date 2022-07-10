using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Front.DeleteFront
{
    public class DeleteFrontRequest : IRequest<DeleteFrontResponse>
    {
        public uint Id { get; set; }
    }
}
