using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.User.GetAllUser
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserRequest, GetAllUserResponse>
    {
        private readonly IUserReadRepository _userReadRepository;
        private ILocalDbContext _context;

        public GetAllUserHandler(IUserReadRepository userReadRepository, ILocalDbContext context)
        {
            _userReadRepository = userReadRepository;
            _context = context;
        }

        public async Task<GetAllUserResponse> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            if(request.TempPass != _context.TemporaryPass.First().Content)
                return await Task.FromResult(new GetAllUserResponse()
                {
                    Message = "Şifre hatalı",
                    Success = false
                });

            IEnumerable<Domain.Entities.Identity.User> users = _userReadRepository.GetAll();
            return await Task.FromResult(new GetAllUserResponse()
            {
                Message = "Tüm Data getirldi",
                Success = true,
                Data = users
            });
        }
    }
}
