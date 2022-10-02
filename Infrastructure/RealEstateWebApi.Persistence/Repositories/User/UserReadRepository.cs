

using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.Identity;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class UserReadRepository : ReadRepository<User, RealEstateWebApiDbContext>, IUserReadRepository
    {
        public UserReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }

        public IEnumerable<OperationClaim> GetClaims(User user)
        {
            var result = from operationClaim in _context.OperationClaims
                         join userOperationClaim in _context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaim
                         {
                             Id = operationClaim.Id,
                             Name = operationClaim.Name,
                             Alias = operationClaim.Alias,
                             CreatedDate = operationClaim.CreatedDate,
                             UpdatedDate = operationClaim.UpdatedDate,
                             IsActive = operationClaim.IsActive
                         };
            return result;
        }

        public UserDto GetUserDtoById(uint id)
        {
            var result = from user in _context.Users
                         where user.Id == id
                         select new UserDto()
                         {
                             Id = user.Id,
                             BirthDate = user.BirthDate,
                             CitizenNumber = user.CitizenNumber,
                             CreatedDate = user.CreatedDate,
                             Email = user.Email,
                             FirstName = user.FirstName,
                             LastName = user.LastName,
                             IsActive = user.IsActive,
                             MobileNumber = user.MobileNumber,
                             PhoneNumber = user.PhoneNumber,
                             UpdatedDate = user.UpdatedDate,
                             ProfileImgFilePath = _context.Files.FirstOrDefault(x => x.Id == user.ProfileImgFileId).FullPath
                             
                         };
            return result.FirstOrDefault();
        }
    }
}
