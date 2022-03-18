using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class DeliveryDetails
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("remarks")]
        public string? Remarks { get; set; }

        /// <summary>
        /// Place of Delivery Phones
        /// </summary>

        [JsonProperty("phones")]
        public IEnumerable<string>? Phones { get; set; }

        /// <summary>
        /// Place of Delivery Faxes
        /// </summary>

        [JsonProperty("faxes")]
        public IEnumerable<string>? Faxes { get; set; }

        /// <summary>
        /// Place of Delivery Emails
        /// </summary>

        [JsonProperty("emails")]
        public IEnumerable<string>? Emails { get; set; }

    }
}
