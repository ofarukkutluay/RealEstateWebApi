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
        public static string TrMobilePhoneReplace(string value)
        {
            value = value.Trim().Replace(" ", "");
            Regex regexMobilePhone = new Regex(@"^[0-9]*$");
            if (regexMobilePhone.IsMatch(value) && value.Length <= 12)
            {
                value = !value.StartsWith("90") || !value.StartsWith("0") ? value.Insert(0, "90") : value;
                value = value.StartsWith("0") ? value.Insert(0, "9") : value;
            }
            return value;
        }
    }
}
