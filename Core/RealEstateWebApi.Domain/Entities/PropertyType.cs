
using RealEstateWebApi.Domain.Entities.Common;


namespace RealEstateWebApi.Domain.Entities
{
    public class PropertyType : BaseEntity
    {
        public string Title { get; set; }
        public uint PropertyStatusId { get; set; }
    }
}
