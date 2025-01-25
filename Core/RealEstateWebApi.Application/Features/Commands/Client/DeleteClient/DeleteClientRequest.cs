using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Client.DeleteClient
{
    public class DeleteClientRequest : IRequest<DeleteClientResponse>
    {
        public uint Id { get; set; }
    }
}
