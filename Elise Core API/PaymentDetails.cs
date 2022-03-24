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

        [JsonProperty("expenses")]
        public decimal? Expenses { get; set; }

        [JsonProperty("localCurrencyExpenses")]
        public decimal? LocalCurrencyExpenses { get; set; }

        [JsonProperty("exchangeCurrencyExpenses")]
        public decimal? ExchangeCurrencyExpenses { get; set; }

        [JsonProperty("exchangeCurrencyValue")]
        public decimal? ExchangeCurrencyValue { get; set; }

        [JsonProperty("securityAmount")]
        public decimal? SecurityAmount { get; set; }

        [JsonProperty("totalAmountDescription")]
        public string? TotalAmountDescription { get; set; }

        [JsonProperty("future1")]
        public string? Future1 { get; set; }

        [JsonProperty("future2")]
        public string? Future2 { get; set; }

        [JsonProperty("future3")]
        public decimal? Future3 { get; set; }

        [JsonProperty("future4")]
        public decimal? Future4 { get; set; }

    }
}
