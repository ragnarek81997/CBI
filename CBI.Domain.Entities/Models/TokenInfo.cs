using CBI.Domain.Entities.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBI.Domain.Entities.Models
{
    public class TokenInfo : BaseEntity
    {
        public decimal Token { get; set; }

        public DateTime Date { get; set; }
    }
}
