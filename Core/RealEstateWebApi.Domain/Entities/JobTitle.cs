using RealEstateWebApi.Domain.Entities.Common;

namespace RealEstateWebApi.Domain.Entities
{
    public class JobTitle : BaseEntity
    {
        public uint CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
