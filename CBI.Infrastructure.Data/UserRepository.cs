using CBI.Domain.Interfaces;
using CBI.Domain.Interfaces.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBI.Domain.Entities.Infrastructure;
using CBI.Domain.Entities.ViewModels;
using Microsoft.AspNet.Identity;
using CBI.Domain.Entities.Enums;

namespace CBI.Infrastructure.Data
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public async Task<DatabaseOneResult<ApplicationUser>> Get(string id)
        {
            return await base.FindOneAsync( _ => _.Id == id);
        }
    }
}
