using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class BadRequestResponse
    {
        /// <summary>
        /// XML response of IAPR
        /// </summary>

        [JsonProperty("myDataResponse")]
        public string? MYDataResponse { get; set; }

        /// <summary>
        /// Summary of error messages provided by IAPR
        /// </summary>

        [JsonProperty("myDataErrors")]
        public IEnumerable<Int32StringKeyValuePair>? MYDataErrors { get; set; }

        /// <summary>
        /// Errors found in synopsis provided by the client.
        /// </summary>

        [JsonProperty("errors")]
        public IEnumerable<string>? Errors { get; set; }

        /// <summary>
        /// Message describing the type of the error.
        /// </summary>

        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// XML response of IAPR
        /// </summary>

        [JsonProperty("signatureData")]
        public string? SignatureData { get; set; }

        /// <summary>
        /// XML sent to IAPR
        /// </summary>

        [JsonProperty("myDataRequest")]
        public string? MYDataRequest { get; set; }

        /// <summary>
        /// Flag indicating the status of the request
        /// </summary>

        [JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Message describing the status of the request
        /// </summary>

        [JsonProperty("message")]
        public string? Message { get; set; }


    }
}
