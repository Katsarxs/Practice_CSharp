using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class SignatureResponse
    {
        /// <summary>
        /// Signature used to verify the integrity of the data.
        /// </summary>

        [JsonProperty("integritySignature")]
        public string? IntegritySignature { get; set; }

        /// <summary>
        /// Path to the public view of the document
        /// </summary>

        [JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Unique Identifier provided by IAPR
        /// </summary>

        [JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// ransaction Identifier provided by IAPR
        /// </summary>

        [JsonProperty("mark")]
        public long? Mark { get; set; }

        /// <summary>
        /// Hash that verifies that the document is valid
        /// </summary>

        [JsonProperty("authenticationCode")]
        public string? AuthenticationCode { get; set; }

        /// <summary>
        /// XML response of IAPR, used in 201
        /// </summary>

        [JsonProperty("myDataResponse")]
        public string? MYDataResponse { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(DocumentStatusEnumToStringJsonConverter))]
        public DocumentStatusEnum Status { get; set; }

        /// <summary>
        /// Series of the document, used in 409
        /// </summary>

        [JsonProperty("series")]
        public string? Series { get; set; }

        /// <summary>
        /// Number of the document, used in 409
        /// </summary>

        [JsonProperty("number")]
        public string? Number { get; set; }

        /// <summary>
        /// Document's date issued, used in 409
        /// </summary>

        [JsonProperty("dateIssued")]
        [JsonConverter(typeof(StringToNullableDateTimeDIFJsonConverter))]
        public DateTime? DateIssued { get; set; }

        /// <summary>
        /// Public URL of the invoice. Added on 20210705
        /// </summary>

        [JsonProperty("domain")]
        public Uri? Domain { get; set; }

        /// <summary>
        /// QR code image as base64 string. Optionally returned.
        /// </summary>

        [JsonProperty("qrCodeString")]
        public Uri? QRCodeString { get; set; }

        /// <summary>
        /// Flag indicating the status of the request
        /// </summary>

        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Message describing the status of the request
        /// </summary>

        [JsonProperty("message")]
        public string? Message { get; set; }

    }
}
