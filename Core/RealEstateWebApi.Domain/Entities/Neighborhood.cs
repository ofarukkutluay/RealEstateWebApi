using RealEstateWebApi.Domain.Entities.Common;


namespace RealEstateWebApi.Domain.Entities
{
    public class Neighborhood : IEntity
    {
        public uint Id { get; set; }
        public int DistrictKey { get; set; }
        public string Name { get; set; }
        public int Key { get; set; }
    }
}
