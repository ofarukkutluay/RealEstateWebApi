
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class MessageWriteRepository : WriteRepository<Message, RealEstateWebApiDbContext>,IMessageWriteRepository
    {
        public MessageWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
