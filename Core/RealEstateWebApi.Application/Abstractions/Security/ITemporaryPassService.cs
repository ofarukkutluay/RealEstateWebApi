using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Abstractions.Security
{
    public interface ITemporaryPassService
    {
        public bool Check(string tempPass);
        public string Generate();
    }
}
