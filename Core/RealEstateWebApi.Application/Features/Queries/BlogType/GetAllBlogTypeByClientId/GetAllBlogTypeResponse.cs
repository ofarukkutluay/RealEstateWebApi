using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.BlogType.GetAllBlogType
{
    public class GetAllBlogTypeResponse : DataResult<IEnumerable<Domain.Entities.BlogType>>
    {
    }
}
