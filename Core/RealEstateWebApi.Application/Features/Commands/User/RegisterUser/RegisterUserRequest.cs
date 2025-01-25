using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.RegisterUser
{
    public class RegisterUserRequest : IRequest<RegisterUserResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public string Password { get; set; }

    }
}
