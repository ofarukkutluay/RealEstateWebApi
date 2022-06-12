using RealEstateWebApi.Application.Abstractions.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.DTOs.TokenOperation
{
    public class AccessToken : IAccessToken
    {
        public DateTime Expiration { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
