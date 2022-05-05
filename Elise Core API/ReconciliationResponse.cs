using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    internal class ReconciliationResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("documents")]
        public IEnumerable<DocumentSynopsis>? Documents { get; set; }

        public IEnumerable<DocumentSynopsis>? GetInvoiceSummaryAsync()
        {
            var result = JsonConvert.DeserializeObject<ReconciliationResponse>("");


            return result.Documents;
        }
    }
}
