using CBI.Domain.Entities.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBI.Domain.Entities.Models
{
    public class CoinInfo : BaseEntity
    {
        public string Name { get; set; }

        public string Symbol { get; set; }

        public bool IsUsed { get; set; }
    }
}
