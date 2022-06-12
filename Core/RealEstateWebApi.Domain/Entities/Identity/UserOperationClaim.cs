using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities.Identity
{
    public class UserOperationClaim : BaseEntity
    {
        public uint UserId { get; set; }
        public uint OperationClaimId { get; set; }

    }
}
