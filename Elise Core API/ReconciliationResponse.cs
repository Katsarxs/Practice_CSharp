using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class ReconciliationResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("documents")]
        public DocumentSynopsis? Documents { get; set; }

    }
}
