using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.User.GetAllUser
{
    public class GetAllUserResponse : DataResult<IEnumerable<Domain.Entities.Identity.User>>
    {
    }
}
