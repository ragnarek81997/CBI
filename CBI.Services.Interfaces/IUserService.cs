using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBI.Domain.Entities.Infrastructure;
using CBI.Domain.Entities.Struct;
using CBI.Domain.Entities.ViewModels;

namespace CBI.Services.Interfaces
{
    public interface IUserService
    {
        Task<ServiceResult<ApplicationUser>> GetApplicationUser(string userId);

        Task<ServiceResult<ShortUser>> GetShortUser(string userId);
    }
}
