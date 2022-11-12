using Microsoft.AspNetCore.Http;
using RealEstateWebApi.Application.Abstractions.Security;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.LocalDb;
using System.Security.Claims;

namespace RealEstateWebApi.Infrastructure.Services.Security
{
    public class TemporaryPassService : ITemporaryPassService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILocalDbContext _localDbContext;

        public TemporaryPassService(IHttpContextAccessor httpContextAccessor, ILocalDbContext localDbContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _localDbContext = localDbContext;
        }

        public bool Check(string tempPass)
        {
            TemporaryPass temporaryPass = _localDbContext.TemporaryPass.SingleOrDefault(x => x.Content == tempPass);
            if (temporaryPass == null)
                return false;

            uint loginUserId = uint.Parse(_httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(e => ClaimTypes.NameIdentifier == e.Type)?.Value ?? "0");
            if (temporaryPass.LoginUserId != loginUserId)
                return false;
            return true;
        }

        public string Generate()
        {
            uint loginUserId = uint.Parse(_httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(e => ClaimTypes.NameIdentifier == e.Type)?.Value ?? "0");
            var guid = Guid.NewGuid().ToString();
            if (loginUserId > 0)
            {
                if (_localDbContext.TemporaryPass.Any(x => x.LoginUserId == loginUserId))
                {
                    _localDbContext.TemporaryPass.RemoveRange(_localDbContext.TemporaryPass.Where(x => x.LoginUserId == loginUserId));
                    _localDbContext.SaveChanges();
                }

                _localDbContext.TemporaryPass.Add(new TemporaryPass() { LoginUserId = loginUserId, Content = guid });
                _localDbContext.SaveChanges();

            }
            return guid;
        }
    }
}
