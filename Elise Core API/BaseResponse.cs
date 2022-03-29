using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class BaseResponse
    {
        /// <summary>
        /// Flag indicating the status of the request
        /// </summary>

        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Message describing the status of the request
        /// </summary>

        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}
