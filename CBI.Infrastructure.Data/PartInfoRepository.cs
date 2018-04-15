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
using CBI.Domain.Entities.Models;

namespace CBI.Infrastructure.Data
{
    public class PartInfoRepository : GenericRepository<PartInfo>, IPartInfoRepository
    {
        public PartInfoRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
