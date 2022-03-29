using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class GetCurrentPackage
    {
        /// <summary>
        /// The Package's Name
        /// </summary>

        [JsonProperty("packageName")]
        public string? PackageName { get; set; }

        /// <summary>
        /// Valid From
        /// </summary>
        
        [JsonProperty("validFrom")]
        [JsonConverter(typeof(StringToNullableDateTimeJsonConverter))]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Valid To
        /// </summary>

        [JsonProperty("validTo")]
        [JsonConverter(typeof(StringToNullableDateTimeJsonConverter))]
        public DateTime? ValidTo { get; set; }

        /// <summary>
        /// The Package's Initial Value
        /// </summary>

        [JsonProperty("initialValue")]
        public decimal InitialValue { get; set; }

        /// <summary>
        /// The Package's Remaining Value
        /// </summary>

        [JsonProperty("remainingValue")]
        public decimal RemainingValue { get; set; }

        /// <summary>
        /// The Package's Consumed Percentage
        /// </summary>

        [JsonProperty("consumedPercentage")]
        public decimal ConsumedPercentage { get; set; }


    }
}