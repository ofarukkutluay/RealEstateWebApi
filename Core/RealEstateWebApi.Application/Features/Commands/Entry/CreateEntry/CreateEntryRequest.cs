using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Entry.CreateEntry
{
    public class CreateEntryRequest : IRequest<CreateEntryResponse>
    {
        public uint CustomerId { get; set; }
        public string Content { get; set; }
        public uint EntryTypeId { get; set; }
        public uint EntrySubTypeId { get; set; }
        public string? EntrySubTitle { get; set; }
        public uint UserId { get; set; }
    }
}
