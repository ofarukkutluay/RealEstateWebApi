using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Abstractions.Token
{
    public interface IAccessToken
    {
        DateTime Expiration { get; set; }
        string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
