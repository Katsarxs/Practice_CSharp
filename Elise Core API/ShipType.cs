using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class ShipType
    {
        /// <summary>
        /// Application Id
        /// </summary>

        [JsonProperty("applicationId")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// Application Date
        /// </summary>

        [JsonProperty("applicationDate")]
        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        public DateTime? ApplicationDate { get; set; }

        /// <summary>
        /// Doy
        /// </summary>

        [JsonProperty("doy")]
        public string? Doy { get; set; }

        /// <summary>
        /// Ship Id
        /// </summary>

        [JsonProperty("shipId")]
        public string? ShipId { get; set; }

        [JsonProperty("hasValues")]
        public readonly bool HasValues;



    }
}
