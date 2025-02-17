using MediatR;


namespace RealEstateWebApi.Application.Features.Queries.PropertyType.GetAllPropertyType
{
    public class GetAllPropertyTypeRequest : IRequest<GetAllPropertyTypeResponse>
    {
        public uint PropertyStatusId { get; set; }
    }
}
