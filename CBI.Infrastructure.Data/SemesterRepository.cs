using CBI.Domain.Interfaces.Infrastructure;
using CBI.Domain.Entities.Infrastructure;
using CBI.Domain.Entities.Models;
using CBI.Domain.Interfaces;

namespace CBI.Infrastructure.Data
{
    public class SemesterRepository : GenericRepository<Semester>, ISemesterRepository
    {
        public SemesterRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
