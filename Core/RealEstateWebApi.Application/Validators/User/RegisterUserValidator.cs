using FluentValidation;
using RealEstateWebApi.Application.Features.Commands.User.RegisterUser;


namespace RealEstateWebApi.Application.Validators.User
{
    public class RegisterUserValidator : AbstractValidator<RegisterUserRequest>
    {
        public RegisterUserValidator()
        {
            RuleFor(e=>e.Email).NotEmpty().EmailAddress();
            RuleFor(e => e.MobileNumber).NotEmpty().Matches(@"^([5]{1})([0-9]{9})$").MaximumLength(10);
        }
    }
}
