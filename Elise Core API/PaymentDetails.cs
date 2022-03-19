using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class PaymentDetails
    {
        /// <summary>
        /// Total Pieces
        /// </summary>

        [JsonProperty("totalPieces")]
        public int? TotalPieces { get; set; }

        /// <summary>
        /// Previous Payable Balance
        /// </summary>

        [JsonProperty("previousBalance")]
        public decimal? PreviousBalance { get; set; }

        /// <summary>
        /// New Balance(Included Previous Balance usually)
        /// </summary>

        [JsonProperty("newBalance")]
        public decimal? NewBalance { get; set; }

        /// <summary>
        /// Prepayment Amount
        /// </summary>

        [JsonProperty("prepaymentAmount")]
        public decimal? PrepaymentAmount { get; set; }

        /// <summary>
        /// Rounding Amount
        /// </summary>

        [JsonProperty("roundingAmount")]
        public decimal? RoundingAmount { get; set; }

        /// <summary>
        /// Electronic Payment Code
        /// </summary>

        [JsonProperty("electronicPaymentCode")]
        public string? ElectronicPaymentCode { get; set; }

        [JsonProperty("paymentMethods")]
        public PaymentMethod PaymentMethods { get; set; }

        /// <summary>
        /// Payment Date
        /// </summary>

        [JsonProperty("paymentDate")]
        [JsonConverter(typeof(StringToNullableDateTimeJsonConverter))]
        public DateTime? PaymentDate { get; set;}

        /// <summary>
        /// Payment Reference Id
        /// </summary>

        [JsonProperty("paymentReferenceID")]
        public string? PaymentReferenceID { get; set; }

        /// <summary>
        /// Paying Company Vat Number
        /// </summary>

        [JsonProperty("payingCompanyVATNumber")]
        public string? PayingCompanyVATNumber { get; set; }

        /// <summary>
        /// Other Payment Details
        /// </summary>

        [JsonProperty("otherPaymentDetails")]
        public string? OtherPaymentDetails { get; set; }

        [JsonProperty("counterpartCurrency")]
        public string? CounterpartCurrency { get; set; }

        /// <summary>
        /// Exchange Currency Rate
        /// </summary>

        [JsonProperty("exchangeCurrencyRate")]
        public decimal? ExchangeCurrencyRate { get; set; }

        /// <summary>
        /// Counter Part Currency Rate
        /// </summary>

        [JsonProperty("counterpartCurrencyRate")]
        public decimal? CounterpartCurrencyRate { get; set; }

        /// <summary>
        /// Local Currency Value
        /// </summary>

        [JsonProperty("localCurrencyValue")]
        public decimal? LocalCurrencyValue { get; set; }

        /// <summary>
        /// Counter Part Currency Value
        /// </summary>

        [JsonProperty("counterpartCurrencyValue")]
        public decimal? CounterpartCurrencyValue { get; set; }

        /// <summary>
        /// Exchange Currency
        /// </summary>

        [JsonProperty("exchangeCurrency")]
        public string? ExchangeCurrency { get; set; }

        /// <summary>
        /// Counter Part New Balance
        /// </summary>

        [JsonProperty("counterpartNewBalance")]
        public decimal? CounterpartNewBalance { get; set; }

    }
}
