using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class Address
    {

        /// <summary>
        /// Country's Name
        /// </summary>

        [JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Country's ISO Code
        /// </summary>

        [JsonProperty("countryCode")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Municipality's Name
        /// </summary>

        [JsonProperty("municipality")]
        public string? Municipality { get; set; }

        /// <summary>
        /// Municipality's Code
        /// </summary>

        [JsonProperty("municipalityCode")]
        public string? MunicipalityCode { get; set; }

        /// <summary>
        /// Region's Name
        /// </summary>

        [JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Region's Code
        /// </summary>

        [JsonProperty("regionCode")]
        public string? RegionCode { get; set; }

        /// <summary>
        /// City's Name
        /// </summary>

        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// City's Code
        /// </summary>

        [JsonProperty("cityCode")]
        public string? CityCode { get; set; }

        /// <summary>
        /// Street's Name
        /// </summary>

        [JsonProperty("street")]
        public string? Street { get; set; }

        /// <summary>
        /// Street's Number
        /// </summary>

        [JsonProperty("number")]
        public string? StreetNumber { get; set; }

        /// <summary>
        /// Postal
        /// </summary>

        [JsonProperty("postal")]
        public string? Postal { get; set; }

        [JsonProperty("geographicalCoordinates")]
        public StringStringValueTuple GeographicalCoordinates { get; set; }

        /// <summary>
        /// GLN
        /// </summary>

        [JsonProperty("gln")]
        public string? Gln { get; set; }

    }
}