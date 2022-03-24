using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class AdditionalDetails
    {
        /// <summary>
        /// Location email
        /// </summary>

        [JsonProperty("locationEmail")]
        public string? LocationEmail { get; set; }

        [JsonProperty("approver")]
        public string? Approver { get; set; }

        /// <summary>
        /// Approver Emails
        /// </summary>

        [JsonProperty("approverEmails")]
        public IEnumerable<string>? ApproverEmails { get; set; }

        /// <summary>
        /// Attention
        /// </summary>

        [JsonProperty("attention")]
        public string? Attention { get; set; }

        /// <summary>
        /// Approver Logical Operator
        /// </summary>

        [JsonProperty("approvalLogicalOperator")]
        public string? ApprovalLogicalOperator { get; set; }

        /// <summary>
        /// Issuing Officer
        /// </summary>

        [JsonProperty("issuingOfficer")]
        public string? IssuingOfficer { get; set; }

        /// <summary>
        /// Principal Functionality
        /// </summary>

        [JsonProperty("principalFunctionality")]
        public string? PrincipalFunctionality { get; set; }

        /// <summary>
        /// EInvoice Document Type
        /// </summary>

        [JsonProperty("eInvoiceDocumentType")]
        public string? EInvoiceDocumentType { get; set; }

        /// <summary>
        /// Notification Delay
        /// </summary>

        [JsonProperty("notificationDelay")]
        public string? NotificationDelay { get; set; }

        /// <summary>
        /// Greneral Porpuse Tags
        /// </summary>

        [JsonProperty("generalPurposeTags")]
        public IEnumerable<string>? GeneralPurposeTags { get; set; }

        /// <summary>
        /// Accounting Department Emails
        /// </summary>

        [JsonProperty("accountingDepartmentEmails")]
        public IEnumerable<string>? AccountingDepartmentEmails { get; set; }

        /// <summary>
        /// Readonly Access Emails
        /// </summary>

        [JsonProperty("readOnlyAccessEmails")]
        public IEnumerable<string>? ReadOnlyAccessEmails { get; set; }

        /// <summary>
        /// Third Party Emails
        /// </summary>

        [JsonProperty("thirdPartyEmails")]
        public IEnumerable<string>? ThirdPartyEmails { get; set; }

        [JsonProperty("aseds")]
        public string? Aseds { get; set; }

        /// <summary>
        /// Extra Structured Content
        /// </summary>

        [JsonProperty("extraStructuredContent")]
        public string? ExtraStructuredContent { get; set; }

        /// <summary>
        /// Notification Transmission Method
        /// </summary>

        [JsonProperty("transmissionMethod")]
        public string? TransmissionMethod { get; set; }

        /// <summary>
        /// User
        /// </summary>

        [JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Documents Tags
        /// </summary>

        [JsonProperty("documentTags")]
        public IEnumerable<string>? DocumentTags { get; set; }

        /// <summary>
        /// Postal Code
        /// </summary>

        [JsonProperty("zipCodeForPostOffice")]
        public bool? ZipCodeForPostOffice { get; set; }

        /// <summary>
        /// Send Notification in Pdf Format
        /// </summary>

        [JsonProperty("sendAsPdf")]
        public string? SendAsPdf { get; set; }

        [JsonProperty("avoidEmailGrouping")]
        public bool AvoidEmailGrouping { get; set; }

        /// <summary>
        /// Emails accounts to receive Pdf Format
        /// </summary>

        [JsonProperty("pdfNotificationEmails")]
        public IEnumerable<string>? PDFNotificationEmails { get; set; }

        [JsonProperty("documentTemplate")]
        public string? DocumentTemplate { get; set; }

        /// <summary>
        /// QrCode PPM
        /// </summary>

        [JsonProperty("qrCodePPM")]
        public int? QRCodePPM { get; set; }

        [JsonProperty("callback")]
        public bool? Callback { get; set; }

        /// <summary>
        /// Approval Document Id
        /// </summary>

        [JsonProperty("approvalDocumentId")]
        public string? ApprovalDocumentId { get; set; }
    }
}
