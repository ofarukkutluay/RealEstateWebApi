using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.BlogType.GetAllBlogTypeByClientId
{
    public class GetAllBlogTypeByClientIdResponse : DataResult<IEnumerable<Domain.Entities.BlogType>>
    {
    }
}
