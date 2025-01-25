using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.HeatingType.DeleteHeatingType
{
    public class DeleteHeatingTypeRequest : IRequest<DeleteHeatingTypeResponse>
    {
        public uint Id { get; set; }
    }
}
