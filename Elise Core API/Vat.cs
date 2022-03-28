using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class Vat
    {
        /// <summary>
        /// Vat Percentage
        /// </summary>

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Vat Percentage
        /// </summary>

        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Vat Amount
        /// </summary>

        [JsonProperty("vatAmount")]
        public decimal? VatAmount { get; set; }

        /// <summary>
        /// Vat Amount in Accounting Currency
        /// </summary>

        [JsonProperty("vatAmountAC")]
        public decimal? VatAmountAC { get; set; }

        /// <summary>
        /// Underlying Value
        /// </summary>

        [JsonProperty("underlyingValue")]
        public decimal? UnderlyingValue { get; set; }

        /// <summary>
        /// Underlying Value in Accounting Currency
        /// </summary>

        [JsonProperty("underlyingValueAC")]
        public decimal? UnderlyingValueAC { get; set; }

        /// <summary>
        /// Vat Excemption
        /// </summary>

        [JsonProperty("vatExemption")]
        public string? VatExemption { get; set; }

        /// <summary>
        /// Vat Excemption Code based on IAPR specs (1-27)
        /// </summary>

        [JsonProperty("vatExemptionCode")]
        public int? VatExemptionCode { get; set; }

        /// <summary>
        /// Amount before any discounts are applied
        /// </summary>

        [JsonProperty("initialAmount")]
        public decimal? InitialAmount { get; set; }

        /// <summary>
        /// Amount in Accounting Currency before any discounts are applied
        /// </summary>

        [JsonProperty("initialAmountAC")]
        public decimal? InitialAmountAC { get; set; }

        /// <summary>
        /// Discount amount applied to VAT percentage
        /// </summary>

        [JsonProperty("discountAmount")]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// Discount in Accounting Currency amount applied to VAT percentage
        /// </summary>

        [JsonProperty("discountAmountAC")]
        public decimal? DiscountAmountAC { get; set; }

        /// <summary>
        /// Sum of Underlying Value and Vat Amount
        /// </summary>

        [JsonProperty("grossAmount")]
        public decimal? GrossAmount { get; set; }

        /// <summary>
        /// Sum of Underlying Value and Vat Amount in Accounting Currency
        /// </summary>

        [JsonProperty("grossAmountAC")]
        public decimal? GrossAmountAC { get; set; }

    }
}
