using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.EntryType.CreateEntryType
{
    public class CreateEntryTypeRequest : IRequest<CreateEntryTypeResponse>
    {
        public string Title { get; set; }
    }
}
