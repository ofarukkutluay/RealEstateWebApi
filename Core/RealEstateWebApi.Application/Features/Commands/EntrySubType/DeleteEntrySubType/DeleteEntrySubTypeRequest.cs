using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.EntrySubType.DeleteEntrySubType
{
    public class DeleteEntrySubTypeRequest : IRequest<DeleteEntrySubTypeResponse>
    {
        public uint Id { get; set; }
    }
}
