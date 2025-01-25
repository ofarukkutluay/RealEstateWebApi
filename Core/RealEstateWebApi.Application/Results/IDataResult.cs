using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Results
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; }
        public int TotalDataCount { get;}
    }
}
