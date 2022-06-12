using RealEstateWebApi.Application.DTOs.TokenOperation;
using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.LoginUser
{
    public class LoginUserResponse : DataResult<AccessToken>
    {
    }
}
