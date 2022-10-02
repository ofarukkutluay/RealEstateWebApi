using RealEstateWebApi.Application.Features.Commands.Customer.CreateCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RealEstateWebApi.Infrastructure.Operations
{
    public static class PhoneNumberOperation
    {
        public static string TrMobilePhoneCheckAndReplace(string value)
        {

            value = value.Trim().Replace(" ", "");
            Regex regexMobilePhone = new Regex(@"^([5]{1})([0-9]{9})$");
            if (!regexMobilePhone.IsMatch(value))
                return null;      
            return value;
        }
    }
}
