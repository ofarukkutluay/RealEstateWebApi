using MediatR;


namespace RealEstateWebApi.Application.Features.Queries.PropertyStatus.GetAllPropertyStatus
{
    public class GetAllPropertyStatusRequest : IRequest<GetAllPropertyStatusResponse>
    {
        public uint PropertyCategoryId { get; set; }
    }
}
