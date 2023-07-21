using System;
namespace RealEstateWebApi.WebApp.Models.Common
{
	public class ApiTokenOption
	{
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}

