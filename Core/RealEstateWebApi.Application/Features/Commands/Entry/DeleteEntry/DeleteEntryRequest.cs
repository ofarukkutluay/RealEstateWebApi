using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Entry.DeleteEntry
{
    public class DeleteEntryRequest : IRequest<DeleteEntryResponse>
    {
        public uint Id { get; set; }
    }
}
