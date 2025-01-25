using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.JobTitle.UpdateJobTitle
{
    public class UpdateJobTitleRequest : IRequest<UpdateJobTitleResponse>
    {
        public uint Id { get; set; }
        public uint? CompanyId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
