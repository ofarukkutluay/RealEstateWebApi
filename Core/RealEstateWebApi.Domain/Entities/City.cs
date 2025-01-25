using RealEstateWebApi.Domain.Entities.Common;


namespace RealEstateWebApi.Domain.Entities
{
    public class City : IEntity
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int Key { get; set; }
    }
}
