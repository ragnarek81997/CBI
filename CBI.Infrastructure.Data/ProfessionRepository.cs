using CBI.Domain.Interfaces.Infrastructure;
using CBI.Domain.Entities.Infrastructure;
using CBI.Domain.Entities.Models;
using CBI.Domain.Interfaces;

namespace CBI.Infrastructure.Data
{
    public class ProfessionRepository : GenericRepository<Profession>, IProfessionRepository
    {
        public ProfessionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
