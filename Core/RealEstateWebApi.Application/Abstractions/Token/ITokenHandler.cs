using RealEstateWebApi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        TAccessToken CreateToken<TAccessToken> (User user, IEnumerable<OperationClaim> operationClaims) where TAccessToken: IAccessToken,new();
        string GenerateRefreshToken();
    }
}
