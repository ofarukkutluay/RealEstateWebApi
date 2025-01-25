using FluentValidation;
using RealEstateWebApi.Application.Features.Commands.Customer.CreateCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Validators.Customer
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerValidator()
        {
            RuleFor(e => e.MobileNumber).NotEmpty().Matches(@"^([5]{1})([0-9]{9})$").MaximumLength(10);
            RuleFor(e => e.MobileNumber2).Matches(@"^([5]{1})([0-9]{9})$").MaximumLength(10);
            RuleFor(e => e.PhoneNumber).Matches(@"^([1-9]{1})([0-9]{9})$").MaximumLength(10);
            RuleFor(e => e.PhoneNumber2).Matches(@"^([1-9]{1})([0-9]{9})$").MaximumLength(10);
            RuleFor(e => e.Email).EmailAddress();
        }
    }
}
