using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.EntryType.DeleteEntryType
{
    public class DeleteEntryTypeRequest : IRequest<DeleteEntryTypeResponse>
    {
        public uint Id { get; set; }
    }
}
