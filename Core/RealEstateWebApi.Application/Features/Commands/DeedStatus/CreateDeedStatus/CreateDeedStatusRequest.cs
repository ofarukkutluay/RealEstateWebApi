using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.DeedStatus.CreateDeedStatus
{
    public class CreateDeedStatusRequest : IRequest<CreateDeedStatusResponse>
    {
        public string Title { get; set; }
    }
}
