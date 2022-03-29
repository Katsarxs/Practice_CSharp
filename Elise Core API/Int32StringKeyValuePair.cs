using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class Int32StringKeyValuePair
    {
       [JsonProperty("key")]
       public int Key { get; set; }

       [JsonProperty("value")]
       public string? Value { get; set; }
    }
}
