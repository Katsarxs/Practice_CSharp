using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class Bank
    {
        /// <summary>
        /// BicCode of Bank
        /// </summary>

        [JsonProperty("bicCode")]
        public string? BicCode { get; set; }

        /// <summary>
        /// Name of Bank
        /// </summary>

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Vatin Id
        /// </summary>

        [JsonProperty("vatinid")]
        public string? VatinId { get; set; }

        /// <summary>
        /// Bank Vat
        /// </summary>

        [JsonProperty("vat")]
        public string? Vat { get; set; }

        /// <summary>
        /// Vatin
        /// </summary>

        [JsonProperty("vatin")]
        public string? Vatin { get; sey; }

        /// <summary>
        /// Branch Code
        /// </summary>

        [JsonProperty("branchCode")]
        public string? BranchCode { get; set; }

        /// <summary>
        /// Branch Address
        /// </summary>

        [JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Interanl Bank Account Number
        /// </summary>

        [JsonProperty("account")]
        public string? Account { get; set; }

        /// <summary>
        /// Account IBAN
        /// </summary>

        [JsonProperty("iban")]
        public string? IBAN { get; set; }

        /// <summary>
        /// Contact Details(Owner Name,Phone,Address etc.)
        /// </summary>

        [JsonProperty("contactDetails")]
        public string? ContactDetails { get; set; }

    }
}

