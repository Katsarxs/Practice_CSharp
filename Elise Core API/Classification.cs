using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class Classification
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Classification Type
        /// </summary>

        [JsonProperty("classificationType")]
        public string? ClassificationType { get; set; }

        /// <summary>
        /// Classification Type Code(earnings or expences)
        /// </summary>

        [JsonProperty("classificationTypeCode")]
        public string? ClassificationTypeCode { get; set; }

        /// <summary>
        /// Classification Category
        /// </summary>

        [JsonProperty("classificationCategory")]
        public string? ClassificationCategory { get; set; }

        /// <summary>
        /// Classification Categoty Code (expences or earning)
        /// </summary>

        [JsonProperty("classificationCategoryCode")]
        public string? ClassificationCategoryCode { get; set; }

        /// <summary>
        /// Classification Ammount in Euro
        /// </summary>

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

    }
}
