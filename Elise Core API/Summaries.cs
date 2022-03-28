using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class Summaries
    {
        /// <summary>
        /// Total Catalog Net Amount
        /// </summary>

        [JsonProperty("totalCatalogNetAmount")]
        public decimal? TotalCatalogNetAmount { get; set; }

        /// <summary>
        /// Total Catalog Net Amount in Accounting Currency
        /// </summary>

        [JsonProperty("totalCatalogNetAmountAC")]
        public decimal? TotalCatalogNetAmountAC { get; set; }

        /// <summary>
        /// Total Net Amount
        /// </summary>

        [JsonProperty("totalNetAmount")]
        public decimal? TotalNetAmount { get; set; }

        /// <summary>
        /// Total Net Amount in Accounting Currency
        /// </summary>

        [JsonProperty("totalNetAmountAC")]
        public decimal? TotalNetAmountAC { get; set; }

        /// <summary>
        /// Net Amount after line discounts have been taken into consideration. Additional invoice level discounts are not included.
        /// </summary>

        [JsonProperty("totalNetAmountAfterLineDiscounts")]
        public decimal? TotalNetAmountAfterLineDiscounts { get; set; }

        /// <summary>
        /// Net Amount in Accounting Currency after line discounts have been taken into consideration. Additional invoice level discounts are not included.
        /// </summary>

        [JsonProperty("totalNetAmountAfterLineDiscountsAC")]
        public decimal? TotalNetAmountAfterLineDiscountsAC { get; set; }

        /// <summary>
        /// Total Vat Amount
        /// </summary>

        [JsonProperty("totalVATAmount")]
        public decimal? TotalVATAmount { get; set; }

        /// <summary>
        /// Total Vat Amount in Accounting Currency
        /// </summary>

        [JsonProperty("totalVATAmountAC")]
        public decimal? TotalVATAmountAC { get; set; }

        /// <summary>
        /// Total With Held Amount
        /// </summary>

        [JsonProperty("totalWithheldAmount")]
        public decimal? TotalWithheldAmount { get; set; }

        /// <summary>
        /// Total With Held Amount in Accounting Currency
        /// </summary>

        [JsonProperty("totalWithheldAmountAC")]
        public decimal? TotalWithheldAmountAC { get; set; }

        /// <summary>
        /// Total Fees Amount
        /// </summary>

        [JsonProperty("totalFeesAmount")]
        public decimal? TotalFeesAmount { get; set; }


        /// <summary>
        /// Total Fees Amount in Accounting Currency
        /// </summary>

        [JsonProperty("totalFeesAmountAC")]
        public decimal? TotalFeesAmountAC { get; set; }

        /// <summary>
        /// Total Stamp Duty Amount
        /// </summary>

        [JsonProperty("totalStampDutyAmount")]
        public decimal? TotalStampDutyAmount { get; set; }

        /// <summary>
        /// Total Stamp Duty Amount in Accounting Currency
        /// </summary>

        [JsonProperty("totalStampDutyAmountAC")]
        public decimal? TotalStampDutyAmountAC { get; set; }

        /// <summary>
        /// Total Other Taxes Amount
        /// </summary>

        [JsonProperty("totalOtherTaxesAmount")]
        public decimal? TotalOtherTaxesAmount { get; set; }

        /// <summary>
        /// Total Other Taxes Amount in Accounting Currency
        /// </summary>

        [JsonProperty("totalOtherTaxesAmountAC")]
        public decimal? TotalOtherTaxesAmountAC { get; set; }

        /// <summary>
        /// Total Deductions Amount
        /// </summary>

        [JsonProperty("totalDeductionsAmount")]
        public decimal? TotalDeductionsAmount { get; set; }

        /// <summary>
        /// Total Deductions Amount in Accounting Currency
        /// </summary>

        [JsonProperty("totalDeductionsAmountAC")]
        public decimal? totalDeductionsAmountAC { get; set; }

        /// <summary>
        /// Total Gross Value, sum of Details Totals
        /// </summary>

        [JsonProperty("totalGrossValue")]
        public decimal? TotalGrossValue { get; set; }

        /// <summary>
        /// Total Gross Value in Accounting Currency, sum of Details Totals
        /// </summary>

        [JsonProperty("totalGrossValueAC")]
        public decimal? TotalGrossValueAC { get; set; }

        /// <summary>
        /// Total Allowances, sum of Details AllowancesTotals
        /// </summary>

        [JsonProperty("totalAllowances")]
        public decimal? TotalAllowances { get; set; }

        /// <summary>
        /// Total Allowances in Accounting Currency, sum of Details AllowancesTotals
        /// </summary>

        [JsonProperty("totalAllowancesAC")]
        public decimal? TotalAllowancesAC { get; set; }

        /// <summary>
        /// Total Allowances Without Lines
        /// </summary>

        [JsonProperty("totalAllowancesWithoutLines")]
        public decimal? TotalAllowancesWithoutLines { get; set; }

        /// <summary>
        /// Total Allowances in Accounting Currency Without Lines
        /// </summary>

        [JsonProperty("totalAllowancesWithoutLinesAC")]
        public decimal? TotalAllowancesWithoutLinesAC { get; set; }

        /// <summary>
        /// Total Charges
        /// </summary>

        [JsonProperty("totalCharges")]
        public decimal? TotalCharges { get; set; }

        /// <summary>
        /// Total Charges in Accounting Currency
        /// </summary>

        [JsonProperty("totalChargesAC")]
        public decimal? TotalChargesAC { get; set; }

        /// <summary>
        /// Total amount of Special Charges
        /// </summary>

        [JsonProperty("totalSpecialCharges")]
        public decimal? TotalSpecialCharges { get; set; }

        /// <summary>
        /// Total amount of Special Charges in Accounting Currency
        /// </summary>

        [JsonProperty("totalSpecialChargesAC")]
        public decimal? TotalSpecialChargesAC { get; set; }

        /// <summary>
        /// Total Payable Amount
        /// </summary>

        [JsonProperty("totalPayableAmount")]
        public decimal? TotalPayableAmount { get; set; }

        /// <summary>
        /// Total Payable Amount in Accounting Currency
        /// </summary>

        [JsonProperty("totalPayableAmountAC")]
        public decimal? TotalPayableAmountAC { get; set; }

        [JsonProperty("incomeClassifications")]
        public IEnumerable<Classification>? IncomeClassifications { get; set; }

        [JsonProperty("expensesClassifications")]
        public IEnumerable<Classification>? ExpensesClassifications { get; set; }

    }
}
