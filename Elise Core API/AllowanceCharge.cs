using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Elise_Core_API
{
    public class AllowanceCharge
    {
        
        [JsonProperty("type")]
        [JsonConverter(typeof(TypeToStringJsonConverter))]
        public AllowanceChargeTypeEnum Type { get; set; }

        /// <summary>
        /// Allowances or Charges Description
        /// </summary>

        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Code
        /// </summary>

        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Level
        /// </summary>

        [JsonProperty("level")]
        public int? Level { get; set; }

        /// <summary>
        /// Percentage
        /// </summary>

        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Amount of Allowances or Charges
        /// </summary>

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Amount of Allowances or Charges in Accounting Currency
        /// </summary>

        [JsonProperty("amountAC")]
        public decimal? AmountAC { get; set; }

        /// <summary>
        /// Gross Amount of Allowances or Charges
        /// </summary>

        [JsonProperty("grossAmount")]
        public decimal? GrossAmount { get; set; }

        /// <summary>
        /// Gross Amount of Allowances or Charges in Accounting Currency
        /// </summary>

        [JsonProperty("grossAmountAC")]
        public decimal? GrossAmountAC { get; set; }

        /// <summary>
        /// The Total Value of Allowances and Charges
        /// </summary>

        [JsonProperty("underlyingValue")]
        public decimal? UnderlyingValue { get; set; }

        /// <summary>
        /// The Total Value of Allowances and Charges in Accounting Currency
        /// </summary>

        [JsonProperty("underlyingValueAC")]
        public decimal? UnderlyingValueAC { get; set; }

        /// <summary>
        /// Vat Percentage
        /// </summary>

        [JsonProperty("vatPercentage")]
        public decimal? VatPercentage { get; set; }

        /// <summary>
        /// VAT Amount
        /// </summary>

        [JsonProperty("vatAmount")]
        public decimal? VatAmount { get; set; }

        /// <summary>
        /// VAT Amount in Accounting Currency
        /// </summary>

        [JsonProperty("vatAmountAC")]
        public decimal? VatAmountAC { get; set; }

    }
}
