using CBI.Domain.Entities.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBI.Domain.Entities.Models
{
    public class CapitalInfo : BaseEntity
    {
        public string CoinInfoId { get; set; }

        public decimal MarketCapUsd { get; set; }

        public DateTime Date { get; set; }

        //public string PriceUsd { get; set; }

        //public string PriceBtc { get; set; }

        //public string VolumeUsd24H { get; set; }

        //public string AvailableSupply { get; set; }

        //public string TotalSupply { get; set; }

        //public string PercentChange_1H { get; set; }

        //public string PercentChange24H { get; set; }

        //public string PercentChange_7D { get; set; }
    }
}
