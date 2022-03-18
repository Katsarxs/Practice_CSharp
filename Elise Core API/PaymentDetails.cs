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

        //paymentDate
    }
}
