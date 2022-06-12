using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RealEstateWebApi.Application.Abstractions.Token;
using RealEstateWebApi.Application.DTOs.TokenOperation;
using RealEstateWebApi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Infrastructure.Services.Token
{
    public class JwtHandler : ITokenHandler
    {
        private readonly TokenOptions tokenOptions;
        private DateTime _accessTokenExpiration;
        public JwtHandler(IConfiguration configuration)
        {
            Configuration = configuration;
            tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }
        private IConfiguration Configuration { get; }

        public string DecodeToken(string input)
        {
            var handler = new JwtSecurityTokenHandler();
            if (input.StartsWith("Bearer "))
            {
                input = input.Substring("Bearer ".Length);
            }

            return handler.ReadJwtToken(input).ToString();
        }


        public TAccessToken CreateToken<TAccessToken>(User user,IEnumerable<OperationClaim> operationClaims) where TAccessToken : IAccessToken, new()
        {
            _accessTokenExpiration = DateTime.UtcNow.AddMinutes(tokenOptions.AccessTokenExpiration);
            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey));
            SigningCredentials credentials = new SigningCredentials(symmetricSecurityKey,SecurityAlgorithms.HmacSha512);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                issuer:tokenOptions.Issuer,
                audience : tokenOptions.Audience,
                expires : _accessTokenExpiration,
                notBefore : DateTime.UtcNow,
                claims : SetClaims(user,operationClaims),
                signingCredentials : credentials
                );

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            string token = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);


            return new TAccessToken()
            {
                Expiration = _accessTokenExpiration,
                RefreshToken = GenerateRefreshToken(),
                Token = token
            };
        }

        public string GenerateRefreshToken()
        {
            return Guid.NewGuid().ToString();
        }

        private IEnumerable<Claim> SetClaims(User user,IEnumerable<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));
            claims.Add(new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"));
            foreach (var item in operationClaims)
            {
                claims.Add(new Claim(ClaimTypes.Role, item.Name));
            }

            return claims;
        }
    }
}
