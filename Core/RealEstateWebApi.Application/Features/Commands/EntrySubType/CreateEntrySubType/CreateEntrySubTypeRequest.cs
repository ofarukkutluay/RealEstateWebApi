using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.EntrySubType.CreateEntrySubType
{
    public class CreateEntrySubTypeRequest : IRequest<CreateEntrySubTypeResponse>
    {
        public uint EntryTypeId { get; set; }
        public string Title { get; set; }
    }
}
