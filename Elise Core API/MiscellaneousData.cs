using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class MiscellaneousData
    {
        /// <summary>
        /// First otpional property of additional information
        /// </summary>

        [JsonProperty("moreInformation1")]
        public string? MoreInformation1 { get; set; }

        /// <summary>
        /// Second otpional property of additional information
        /// </summary>

        [JsonProperty("moreInformation2")]
        public string? MoreInformation2 { get; set; }

        /// <summary>
        /// Third otpional property of additional information
        /// </summary>

        [JsonProperty("moreInformation3")]
        public string? MoreInformation3 { get; set; }

        /// <summary>
        /// Comments1(optional comment property)
        /// </summary>

        [JsonProperty("comments1")]
        public string? Comments1 { get; set; }

        /// <summary>
        /// Comments2(optional comment property)
        /// </summary>

        [JsonProperty("comments2")]
        public string? Comments2 { get; set; }

        /// <summary>
        /// Option Accompanying Text property
        /// </summary>

        [JsonProperty("accompanyingText")]
        public string? AccompanyingText { get; set; }

        /// <summary>
        /// Purchased Order Number
        /// </summary>

        [JsonProperty("purchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Purchase Date
        /// </summary>

        [JsonProperty("purchaseDate")]
        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        public DateTime? PurchaseDate { get; set; }

        /// <summary>
        /// Internal QRCode
        /// </summary>

        [JsonProperty("qrCode")]
        public string? QRCode { get; set; }

        /// <summary>
        /// Internal Bar Code
        /// </summary>

        [JsonProperty("gtin")]
        public string? GTIN { get; set; }



    }
}
