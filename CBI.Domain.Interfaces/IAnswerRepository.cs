using CBI.Domain.Interfaces.Infrastructure;
using System.Threading.Tasks;
using CBI.Domain.Entities.Infrastructure;
using CBI.Domain.Entities.Models;

namespace CBI.Domain.Interfaces
{
    public interface IAnswerRepository : IRepository<Answer>
    {
    }
}
