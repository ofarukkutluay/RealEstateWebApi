using MediatR;
using System.ComponentModel.DataAnnotations;


namespace RealEstateWebApi.Application.Features.Commands.User.UpdateUser
{
    public class UpdateUserRequest : IRequest<UpdateUserResponse>
    {
        public uint Id { get; set; }
        public long? CitizenNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        //public string MobileNumber { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
