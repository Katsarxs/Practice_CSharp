using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class DocumentSynopsis
    {
        [JsonProperty("internalId")]
        public string? InternalId { get; set; }

        [JsonProperty("series")]
        public string? Series { get; set; }

        [JsonProperty("number")]
        public string? Number { get; set; }

        [JsonProperty("totalVatAmount")]
        public decimal? TotalVatAmount { get; set; }

        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }
    }
}
