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
        public IEnumerable<string>? Activities { get; set; }

        /// <summary>
        /// General Commercial Registry Number
        /// </summary>

        [JsonProperty("generalCommercialRegistryNumber")]
        public string? GeneralCommercialRegistryNumber { get; set; }

        /// <summary>
        /// Phones List
        /// </summary>

        [JsonProperty("phones")]
        public IEnumerable<string>? Phones { get; set; }

        /// <summary>
        /// Faxes List
        /// </summary>

        [JsonProperty("faxes")]
        public IEnumerable<string>? Faxes { get; set; }

        /// <summary>
        /// Emails List
        /// </summary>

        [JsonProperty("emails")]
        public IEnumerable<string>? Emails { get; set; }

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

        /// <summary>
        /// Phones List of Branch
        /// </summary>
        
        [JsonProperty("branchPhones")]
        public IEnumerable<string>? BranchPhones { get; set; }

        /// <summary>
        /// Faxes List of Branch
        /// </summary>

        [JsonProperty("branchFaxes")]
        public IEnumerable<string>? BranchFaxes { get; set; }

        /// <summary>
        /// Tax Regime
        /// </summary>

        [JsonProperty("taxRegime")]
        public string? TaxRegime { get; set; }

        /// <summary>
        /// Category
        /// </summary>

        [JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Type
        /// </summary>

        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Code
        /// </summary>

        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// External Code
        /// </summary>

        [JsonProperty("externalCode")]
        public string? ExternalCode { get; set; }

        /// <summary>
        /// Other Info
        /// </summary>

        [JsonProperty("otherInfo")]
        public string? OtherInfo { get; set; }

        /// <summary>
        /// Identity Type
        /// </summary>

        [JsonProperty("identityType")]
        public string? IdentityType { get; set; }

        /// <summary>
        /// Identity Identifier
        /// </summary>

        [JsonProperty("identityIdentifier")]
        public string? IdentityIdentifier { get; set; }

        /// <summary>
        /// Tax Representative Name
        /// </summary>

        [JsonProperty("taxRepresentativeName")]
        public string? TaxRepresentativeName { get; set; }

        /// <summary>
        /// Tax Representative Vat
        /// </summary>

        [JsonProperty("taxRepresentativeVat")]
        public string? TaxRepresentativeVat { get; set; }

        /// <summary>
        /// Tax Representative Country
        /// </summary>

        [JsonProperty("taxRepresentativeCountry")]
        public string? TaxRepresentativeCountry { get; set; }

        /// <summary>
        /// Tax Representative Country Code
        /// </summary>

        [JsonProperty("taxRepresentativeCountryCode")]
        public string? TaxRepresentativeCountryCode { get; set; }

        /// <summary>
        /// Counter Party Vat Exemption Note
        /// </summary>

        [JsonProperty("vatExemptionNote")]
        public string? vatExemptionNote { get; set; }

        /// <summary>
        /// Fuel distributor code for fuel invoices
        /// </summary>

        [JsonProperty("fuelDistributorCode")]
        public string? FuelDistributorCode { get; set; }

        //taxRepresentativeCountryCode
        //vatExemptionNote
        //fuelDistributorCode
    }
}