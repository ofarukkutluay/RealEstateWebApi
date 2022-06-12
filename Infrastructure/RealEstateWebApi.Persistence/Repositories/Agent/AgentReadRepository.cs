using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class AgentReadRepository : ReadRepository<Agent, RealEstateWebApiDbContext>, IAgentReadRepository
    {
        public AgentReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
