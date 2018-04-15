using CBI.Domain.Interfaces.Infrastructure;
using System.Threading.Tasks;
using CBI.Domain.Entities.Infrastructure;
using CBI.Domain.Entities.ViewModels;
using CBI.Domain.Entities.Enums;

namespace CBI.Domain.Interfaces
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        Task<DatabaseOneResult<ApplicationUser>> Get(string id);
    }
}
