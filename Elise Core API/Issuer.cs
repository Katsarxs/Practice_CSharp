using Newtonsoft.Json;

namespace Elise_Core_API
{
    public partial class Issuer
    {
        /// <summary>
        /// Registered Company Name
        /// </summary>

        [JsonProperty("registeredName")]
        public string? RegisteredName { get; set; }

        /// <summary>
        /// Brand's Name for multiple brands under the same VAT
        /// </summary>

        [JsonProperty("brandName")]
        public string? BrandName { get; set; }

        /// <summary>
        /// Contact Person
        /// </summary>

        [JsonProperty("contactPerson")]
        public string? ContactPerson { get; set; }

        /// <summary>
        /// Registration Number
        /// </summary>

        [JsonProperty("registrationNumber")]
        public string? RegistrationNumber { get; set; }

        /// <summary>
        /// Envelope Number
        /// </summary>

        [JsonProperty("envelopeNumber")]
        public string? EnvelopeNumber { get; set; }

        /// <summary>
        /// Code used in YSM registry
        /// </summary>

        [JsonProperty("ysn")]
        public string? Ysn { get; set; }

        /// <summary>
        /// Vat starting with country code
        /// </summary>

        [JsonProperty("vat")]
        public string? Vat { get; set; }

        /// <summary>
        /// Paid Up Shared Capital
        /// </summary>

        [JsonProperty("paidUpSharedCapital")]
        public string? PaidUpSharedCapital { get; set; }

        /// <summary>
        /// Shared Capital Subscribed
        /// </summary>

        [JsonProperty("sharedCapitalSubscribed")]
        public string? SharedCapitalSubscribed { get; set; }

        /// <summary>
        /// Tax Office
        /// </summary>

        [JsonProperty("taxOffice")]
        public string? TaxOffice { get; set; }

        /// <summary>
        /// Tax Office Code
        /// </summary>

        [JsonProperty("taxOfficeCode")]
        public string? TaxOfficeCode { get; set; }

        /// <summary>
        /// List of Activities of company
        /// </summary>

        [JsonProperty("activities")]
        IEnumerable<string>? Activities { get; set; }

        /// <summary>
        /// General Commercial Registry Number
        /// </summary>

        [JsonProperty("generalCommercialRegistryNumber")]
        public string? GeneralCommercialRegistryNumber { get; set; }

        /// <summary>
        /// Phones List
        /// </summary>

        [JsonProperty("phones")]
        IEnumerable<string>? Phones { get; set; }

        /// <summary>
        /// Faxes List
        /// </summary>

        [JsonProperty("faxes")]
        IEnumerable<string>? Faxes { get; set; }

        /// <summary>
        /// Emails List
        /// </summary>

        [JsonProperty("emails")]
        IEnumerable<string>? Emails { get; set; }

        /// <summary>
        /// Company Url
        /// </summary>

        [JsonProperty("url")]
        public Uri? Url { get; set; }

        /// <summary>
        /// Branch
        /// </summary>

        [JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Branch Code
        /// </summary>

        [JsonProperty("branchCode")]
        public string? branchCode { get; set; }

        /// <summary>
        /// Branch Id
        /// </summary>

        [JsonProperty("branchId")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Pos Id
        /// </summary>

        [JsonProperty("posId")]
        public string? PosId { get; set; }





        //branchAddress



    }
}