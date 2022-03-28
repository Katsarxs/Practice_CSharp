using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elise_Core_API
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
        [JsonConverter(typeof(StringToNullableDateTimeJsonConverter))]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Valid To
        /// </summary>

        [JsonProperty("validTo")]
        [JsonConverter(typeof(StringToNullableDateTimeJsonConverter))]
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

        /// <summary>
        /// Determines when the provider self-signs the document.
        /// </summary>

        [JsonProperty("iaprSignPolicy")]
        [JsonConverter(typeof(IAPRSignPolicyEnumToStringJsonConverter))]
        public IAPRSignPolicyEnum IAPRSignPolicy { get; set; }

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
        public IEnumerable<string>? RelativeDocuments { get; set; }

        /// <summary>
        /// Correlated Invoices - AADE field
        /// </summary>

        [JsonProperty("correlatedInvoices")]
        public IEnumerable<long>? CorrelatedInvoices { get; set; }

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

        [JsonProperty("issuer")]
        public Party Issuer { get; set; }

        [JsonProperty("counterParty")]
        public Party CounterParty { get; set; }

        [JsonProperty("recipient")]
        public Party Recipient { get; set; }

        [JsonProperty("billingContractor")]
        public Party BillingContractor { get; set; }

        [JsonProperty("originator")]
        public Party Originator { get; set; }

        [JsonProperty("sender")]
        public Party Sender { get; set; }

        [JsonProperty("allowancesCharges")]
        public IEnumerable<AllowanceCharge>? AllowancesCharges { get; set; }

        [JsonProperty("banks")]
        public IEnumerable<Bank>? Banks { get; set; }

        [JsonProperty("contractOrderDetails")]
        public ContractOrderDetails ContractOrderDetails { get; set; }

        [JsonProperty("paymentDetails")]
        public PaymentDetails PaymentDetails { get; set; }

        [JsonProperty("additionalDetails")]
        public AdditionalDetails AdditionalDetails { get; set; }
        
        [JsonProperty("details")]
        public IEnumerable<Detail>? Detail { get; set; }

    }
}