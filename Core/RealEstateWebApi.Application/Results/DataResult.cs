using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Results
{
    public class DataResult<T> : Result , IDataResult<T>
    {
        public T Data { get; set; }

    }
}
