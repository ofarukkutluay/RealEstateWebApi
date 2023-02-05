using MediatR;
using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Extension.ChromeExtension
{
    public class ChromeExtensionRequest : IRequest<ChromeExtensionResponse>
    {
        public uint? CustomerId { get; set; }
        public string OuterHTML { get; set; }
        public string Url { get; set; }
    }
}
