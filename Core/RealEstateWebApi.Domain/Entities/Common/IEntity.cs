using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities.Common
{
    public interface IEntity<TId> 
    {
        public TId Id { get; set; }
    }

    public interface IEntity : IEntity<uint>
    {
        
    }
}
