using CBI.Domain.Interfaces.Infrastructure;
using CBI.Domain.Entities.Infrastructure;
using CBI.Domain.Entities.Models;
using CBI.Domain.Interfaces;

namespace CBI.Infrastructure.Data
{
    public class AnswerRepository : GenericRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
