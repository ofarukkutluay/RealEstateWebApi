

using MediatR;
using System.ComponentModel.DataAnnotations;

namespace RealEstateWebApi.Application.Features.Commands.Customer.UpdateCustomer
{
    public class UpdateCustomerRequest : IRequest<UpdateCustomerResponse>
    {
        public uint Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }

        public string? MobileNumber2 { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PhoneNumber2 { get; set; }
        public string? Email { get; set; }
        public uint CityId { get; set; }
        public uint DistrictId { get; set; }
        public uint? NeighborhoodId { get; set; }

        public DateTime? BirthDay { get; set; }
        public long? CitizenNumber { get; set; }
        public uint RegisterUserId { get; set; }
        public uint AssignedUserId { get; set; }
        public string? StatusKey { get; set; }
        public bool IsActive { get; set; }
    }
}
