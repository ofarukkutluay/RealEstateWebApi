
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class MessageReadRepository : ReadRepository<Message, RealEstateWebApiDbContext>, IMessageReadRepository
    {
        public MessageReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
