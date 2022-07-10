using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.JobTitle.DeleteJobTitle
{
    public class DeleteJobTitleRequest : IRequest<DeleteJobTitleResponse>
    {
        public uint JobTitleId { get; set; }
    }
}
