using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class StringStringValueTuple
    {
        /// <summary>
        /// Item1
        /// </summary>

        [JsonProperty("item1")]
        public string? Item1 { get; set; }

        /// <summary>
        /// Item1
        /// </summary>

        [JsonProperty("item2")]
        public string? Item2 { get; set; }

    }



}