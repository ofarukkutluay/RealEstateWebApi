using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Blog.GetAllBlogByClientId
{
    public class GetAllBlogByClientIdResponse : DataResult<IEnumerable<Domain.Entities.Blog>>
    {
    }
}
