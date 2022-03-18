using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class ContractOrderDetails
    {
        /// <summary>
        /// Start Date
        /// </summary>

        [JsonProperty("startDate")]
        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End Date
        /// </summary>

        [JsonProperty("endDate")]
        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        public DateTime? EndDatetDate { get; set; }

        /// <summary>
        /// Contract Type Code
        /// </summary>

        [JsonProperty("contractTypeCode")]
        public string? ContractTypeCode { get; set; }

        /// <summary>
        /// Name
        /// </summary>

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Code
        /// </summary>

        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Date
        /// </summary>

        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// web Post Number
        /// </summary>

        [JsonProperty("webPostNumber")]
        public string? WebPostNumber { get; set; }

        /// <summary>
        /// Budget Registration Code
        /// </summary>

        [JsonProperty("budgetRegistrationCode")]
        public string? BudgetRegistrationCode { get; set; }

        /// <summary>
        /// Budget Commitment Code
        /// </summary>

        [JsonProperty("budgetCommitmentCode")]
        public string? BudgetCommitmentCode { get; set; }

        /// <summary>
        /// Order Numbers
        /// </summary>

        [JsonProperty("orderNumbers")]
        public IEnumerable<string>? OrderNumbers { get; set; }

        /// <summary>
        /// MIS Code
        /// </summary>

        [JsonProperty("misCode")]
        public string? MisCode { get; set; }

        /// <summary>
        /// Co Funding Project Code
        /// </summary>

        [JsonProperty("coFundingProjectCode")]
        public string? CoFundingProjectCode { get; set; }

        /// <summary>
        /// CoFunding Project Year
        /// </summary>

        [JsonProperty("coFundingProjectYear")]
        public string? CoFundingProjectYear { get; set; }

        /// <summary>
        /// CoFunding Project Deep Code
        /// </summary>

        [JsonProperty("coFundingProjectDeedCode")]
        public string? CoFundingProjectDeedCode { get; set; }

    }
}
