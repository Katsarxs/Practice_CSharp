using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class Tax
    {
        /// <summary>
        /// Tax Type 
        /// </summary>

        [JsonProperty("taxType")]
        public string? TaxType { get; set; }

        /// <summary>
        /// Tax Type Code
        /// </summary>

        [JsonProperty("taxTypeCode")]
        public int? TaxTypeCode { get; set; }

        /// <summary>
        /// Tax Category
        /// </summary>

        [JsonProperty("taxCategory")]
        public string? TaxCategory { get; set; }

        /// <summary>
        /// Tax Category Code
        /// </summary>

        [JsonProperty("taxCategoryCode")]
        public int? TaxCategoryCode { get; set; }

        /// <summary>
        /// Tax Amount
        /// </summary>

        [JsonProperty("taxAmount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// Tax Amount in Accounting Currency
        /// </summary>

        [JsonProperty("taxAmountAC")]
        public decimal? TaxAmountAC { get; set; }

        /// <summary>
        /// Id
        /// </summary>

        [JsonProperty("id")]
        public int? Id { get; set; }

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
    }
}
