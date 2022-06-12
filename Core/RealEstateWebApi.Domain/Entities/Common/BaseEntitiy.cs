using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities.Common
{
    public class BaseEntity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }
        public DateTime CreatedDate { get; set; }
        virtual public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
