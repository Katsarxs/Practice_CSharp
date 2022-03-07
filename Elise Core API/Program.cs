using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliseCoreAPI
{
    public class GetCurrentPackage
    {
        /// <summary>
        /// The Package's Name
        /// </summary>

        [JsonProperty("packageName")]
        public string? PackageName { get; set; }

        /// <summary>
        /// Valid From
        /// </summary>
        
        [JsonProperty("validFrom")]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Valid To
        /// </summary>

        [JsonProperty("validTo")]
        public DateTime? ValidTo { get; set; }

        /// <summary>
        /// The Package's Initial Value
        /// </summary>

        [JsonProperty("initialValue")]
        public decimal InitialValue { get; set; }

        /// <summary>
        /// The Package's Remaining Value
        /// </summary>

        [JsonProperty("remainingValue")]
        public decimal RemainingValue { get; set; }

        /// <summary>
        /// The Package's Consumed Percentage
        /// </summary>

        [JsonProperty("consumedPercentage")]
        public decimal ConsumedPercentage { get; set; }


    }

    public class Json
    {

        /// <summary>
        /// Public Salt-Invoice public salt
        /// </summary> 

        [JsonProperty("publicSalt")]
        public string? PublicSalt { get; set; }

        /// <summary>
        /// Public Signature - Invoice Public Signature
        /// </summary> 

        [JsonProperty("publicSignature")]
        public string? PublicSignature { get; set; }

        /// <summary>
        /// Private Signature-Invoice private signature
        /// </summary> 

        [JsonProperty("privateSignature")]
        public string? PrivateSignaturete { get; set; }

        /// <summary>
        /// Invoice MARK provided by AADE
        /// </summary>

        [JsonProperty("mark")]
        public Int64? Mark { get; set; }

        /// <summary>
        /// Uid-Invoice UID provided by AADE
        /// </summary>

        [JsonProperty("uid")]
        public string? Uid { get; set; }

        // iaprSignPolicy

        /// <summary>
        /// Unique Id
        /// </summary>

        [JsonProperty("uniqueId")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// Invoice Cancellation MARK provided by AADE, for cancelled invoices
        /// </summary>

        [JsonProperty("cancellationMark")]
        public Int64? CancellationMark { get; set; }

        /// <summary>
        /// Invoice Classification MARK, for invoices that were classified individually
        /// </summary>

        [JsonProperty("classificationMark")]
        public Int64? ClassificationMark { get; set; }

        /// <summary>
        /// Elise API version
        /// </summary>

        [JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Invoice Authentication Code
        /// </summary>

        [JsonProperty("authenticationCode")]
        public string? AuthenticationCode { get; set; }

        /// <summary>
        /// ISO Language
        /// </summary>

        [JsonProperty("languageCode")]
        public string? LanguageCode { get; set; }

        /*
        documentType
        documentTypeCode
        copyTypeNamePurpose
        series
        number
        issuerFormatedInvoiceSeriesNumber
        dateIssued
        relativeDocuments
        correlatedInvoices
        */

        /// <summary>
        /// Currency 
        /// </summary> 

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Currency Code 
        /// </summary> 

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// Type of Invoice 
        /// </summary> 

        [JsonProperty("invoiceType")]
        public string? InvoiceType { get; set; }

        /// <summary>
        /// Invoice Type AADE Code 
        /// </summary> 

        [JsonProperty("invoiceTypeCode")]
        public string? InvoiceTypeCode { get; set; }



    }
}