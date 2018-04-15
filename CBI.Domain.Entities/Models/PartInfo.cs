using CBI.Domain.Entities.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBI.Domain.Entities.Models
{
    public class PartInfo : BaseEntity
    {
        public string CoinInfoId { get; set; }

        public decimal Part { get; set; }

        public DateTime Date { get; set; }
    }
}
