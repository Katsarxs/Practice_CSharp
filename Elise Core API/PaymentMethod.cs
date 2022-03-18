using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class PaymentMethod
    {
        /// <summary>
        /// Payment Method Id
        /// </summary>

        [JsonProperty("paymentMethodId")]
        public string? PaymentMethodId { get; set; }

        /// <summary>
        /// Payment Meyhod Type
        /// </summary>

        [JsonProperty("paymentMethodType")]
        public string? PaymentMethodType { get; set; }

        /// <summary>
        /// Payment Method Type Code
        /// </summary>

        [JsonProperty("paymentMethodTypeCode")]
        public int? PaymentMethodTypeCode { get; set; }

        /// <summary>
        /// Amount
        /// </summary>

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Remarks
        /// </summary>

        [JsonProperty("remarks")]
        public string? Remarks { get; set; }

    }
}
