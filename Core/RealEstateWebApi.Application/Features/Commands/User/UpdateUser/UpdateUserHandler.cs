using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.User.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;

        public UpdateUserHandler(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
        }

        public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.User user = await _userReadRepository.GetByIdAsync(request.Id);
            if (user is null)
                return new UpdateUserResponse()
                {
                    Message = "Kullanıcı bulunamadı",
                    Success = false
                };

            user.FirstName = String.IsNullOrEmpty(request.FirstName) ? user.FirstName : request.FirstName;
            user.LastName = String.IsNullOrEmpty(request.LastName) ? user.LastName : request.LastName;

            var searchCitizenNumberUser = request.CitizenNumber <= 0 ? null : await _userReadRepository.GetSingleAsync(e => e.CitizenNumber == request.CitizenNumber);
            if (searchCitizenNumberUser != null)
                return new UpdateUserResponse()
                {
                    Message = "Girdiğiniz kimlik numarasına kullanıcı vardır.",
                    Success = false,
                };

            user.CitizenNumber = request.CitizenNumber <= 0 ? user.CitizenNumber : request.CitizenNumber;

            var searchPhoneNumberUser = await _userReadRepository.GetSingleAsync(e => e.PhoneNumber == request.PhoneNumber);
            if (searchPhoneNumberUser != null)
                return new UpdateUserResponse()
                {
                    Message = "Girdiğiniz sabit numaraya kullanıcı vardır.",
                    Success = false,
                };
            user.PhoneNumber = String.IsNullOrEmpty(request.PhoneNumber) ? user.PhoneNumber : request.PhoneNumber;

            //user.MobileNumber = String.IsNullOrEmpty(request.MobileNumber) ? user.MobileNumber : request.MobileNumber;

            user.BirthDate = request.BirthDate == default ? user.BirthDate : request.BirthDate;

            var searchEmailUser = await _userReadRepository.GetSingleAsync(e => e.Email == request.Email);
            if (searchEmailUser != null)
                return new UpdateUserResponse()
                {
                    Message = "Girdiğiniz mail adresine kullanıcı vardır.",
                    Success = false,
                };

            user.Email = String.IsNullOrEmpty(request.Email) ? user.Email : request.Email;

            var result = await _userWriteRepository.SaveAsync();
            if (result < 0)
                return new UpdateUserResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateUserResponse()
            {
                Message = "Kullanıcı güncelledi",
                Success = true
            };
        }
    }
}
