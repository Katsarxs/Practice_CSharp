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

        /// <summary>
        /// Document Type
        /// </summary>

        [JsonProperty("documentType")]
        public string? DocumentType { get; set; }

        /// <summary>
        /// Document Type Code
        /// </summary>

        [JsonProperty("documentTypeCode")]
        public string? DocumentTypeCode { get; set; }

        /// <summary>
        /// Copy Type Name Purpose
        /// </summary>

        [JsonProperty("copyTypeNamePurpose")]
        public string? CopyTypeNamePurpose { get; set; }

        /// <summary>
        /// Invoice Series
        /// </summary>

        [JsonProperty("series")]
        public string? Series { get; set; }

        /// <summary>
        /// Invoice Number
        /// </summary>

        [JsonProperty("number")]
        public string? Number { get; set; }

        /// <summary>
        /// Issuer Formated Invoice Series Number
        /// </summary>

        [JsonProperty("issuerFormatedInvoiceSeriesNumber")]
        public string? IssuerFormatedInvoiceSeriesNumber { get; set; }

        /// <summary>
        /// Date Issued of Invoice
        /// </summary>

        [JsonProperty("dateIssued")]
        public DateTime DateIssued { get; set; }

        /// <summary>
        /// List of Relative Documents
        /// </summary>

        [JsonProperty("relativeDocuments")]
        IEnumerable<string>? RelativeDocuments { get; set; }

        /// <summary>
        /// Correlated Invoices - AADE field
        /// </summary>

        [JsonProperty("correlatedInvoices")]
        IEnumerable<Int64>? CorrelatedInvoices { get; set; }

        /// <summary>
        /// Recipient Role
        /// </summary>

        [JsonProperty("recipientRole")]
        public string? RecipientRole { get; set; }

        /// <summary>
        /// Reference Code
        /// </summary>

        [JsonProperty("referenceCode")]
        public string? ReferenceCode { get; set; }

        /// <summary>
        /// Order Code
        /// </summary>

        [JsonProperty("orderCode")]
        public string? OrderCode { get; set; }

        /// <summary>
        /// Lot Number
        /// </summary>

        [JsonProperty("lotNumber")]
        public string? LotNumber { get; set; }

        /// <summary>
        /// Vat Currency Code when different from invoice
        /// </summary>

        [JsonProperty("vatCurrencyCode")]
        public string? VatCurrencyCode { get; set; }

        /// <summary>
        /// Vat Point Date
        /// </summary>

        [JsonProperty("vatPointDate")]
        public DateTime VatPointDate { get; set; }

        /// <summary>
        /// Order Confirmation Number
        /// </summary>

        [JsonProperty("orderConfirmationNumber")]
        public string? OrderConfirmationNumber { get; set; }

        /// <summary>
        /// Receiving Advice Number
        /// </summary>

        [JsonProperty("receivingAdviceNumber")]
        public string? ReceivingAdviceNumber { get; set; }

        /// <summary>
        /// Dispatch Advice
        /// </summary>

        [JsonProperty("dispatchAdvice")]
        public string? DispatchAdvice { get; set; }

        public class Issuer
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

            public class Address
            {

            }





        }

    }
}