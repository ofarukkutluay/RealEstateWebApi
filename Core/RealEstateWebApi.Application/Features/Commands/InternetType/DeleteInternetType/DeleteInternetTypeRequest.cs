using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.InternetType.DeleteInternetType
{
    public class DeleteInternetTypeRequest : IRequest<DeleteInternetTypeResponse>
    {
        public uint Id { get; set; }
    }
}
