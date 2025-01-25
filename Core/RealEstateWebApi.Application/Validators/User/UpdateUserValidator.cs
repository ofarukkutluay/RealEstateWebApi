using FluentValidation;
using RealEstateWebApi.Application.Features.Commands.User.UpdateUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Validators.User
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidator()
        {
            RuleFor(e => e.Email).NotEmpty().EmailAddress();
            RuleFor(e => e.PhoneNumber).Matches(@"^([1-9]{1})([0-9]{9})$").MaximumLength(10).WithMessage("Telefon numarası 10 haneli olmalıdır.");
            
            RuleFor(e => e.CitizenNumber).GreaterThanOrEqualTo(10000000000).WithMessage("Kimlik numarası 11 haneli olmalıdır.").LessThanOrEqualTo(99999999999).When(e=>e.CitizenNumber!=0).WithMessage("Kimlik numarası 11 haneli olmalıdır.");
        }
    }
}
