using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class Detail
    {
        /// <summary>
        /// Line Number
        /// </summary>

        [JsonProperty("lineNo")]
        public int? LineNo { get; set; }

        [JsonProperty("classificationLineNo")]
        public int? ClassificationLineNo { get; set; }

        /// <summary>
        /// Date
        /// </summary>

        [JsonProperty("date")]
        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Product Code
        /// </summary>

        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Buyer Code
        /// </summary>

        [JsonProperty("buyerCode")]
        public string? BuyerCode { get; set; }

        /// <summary>
        /// CPV Code
        /// </summary>

        [JsonProperty("cpvCode")]
        public string? CPVCode { get; set; }

        /// <summary>
        /// Item Codification
        /// </summary>

        [JsonProperty("itemCodification")]
        public string? ItemCodification { get; set; }

        /// <summary>
        /// Category Id
        /// </summary>

        [JsonProperty("categoryId")]
        public string? CategoryId { get; set; }

        /// <summary>
        /// Product's Country Code
        /// </summary>

        [JsonProperty("countryCode")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Tariff Code Id
        /// </summary>

        [JsonProperty("tariffCodeID")]
        public string? TariffCodeID { get; set; }

        /// <summary>
        /// Product Order Id
        /// </summary>

        [JsonProperty("orderID")]
        public string? OrderID { get; set; }

        /// <summary>
        /// Product Transport Id
        /// </summary>

        [JsonProperty("transportId")]
        public string? TransportId { get; set; }

        /// <summary>
        /// Lot Life Circle
        /// </summary>

        [JsonProperty("lotLifeCircle")]
        public string? LotLifeCircle { get; set; }

        /// <summary>
        /// Delivery Id
        /// </summary>

        [JsonProperty("deliveryId")]
        public string? DeliveryId { get; set; }

        /// <summary>
        /// Product's or Services Descriptions
        /// </summary>

        [JsonProperty("descriptions")]
        public IEnumerable<string>? Descriptions { get; set; }

        /// <summary>
        /// Product's Special Features
        /// </summary>

        [JsonProperty("specialFeatures")]
        public IEnumerable<string>? SpecialFeatures { get; set; }

        /// <summary>
        /// Starting Date
        /// </summary>

        [JsonProperty("startingDate")]
        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        public DateTime? StartingDate { get; set; }

        /// <summary>
        /// Expiration Date
        /// </summary>

        [JsonProperty("expirationDate")]
        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Product's Measurement Unit
        /// </summary>

        [JsonProperty("measurementUnit")]
        public string? MeasurementUnit { get; set; }

        /// <summary>
        /// Product's measurement unit (IARP)
        /// </summary>

        [JsonProperty("measurementUnitCode")]
        public string? MeasurementUnitCode { get; set;}

        /// <summary>
        /// Product's measurement unit (EN16931)
        /// </summary>

        [JsonProperty("measurementUnitCodeEN")]
        public string? MeasurementUnitCodeEN { get; set; }

        /// <summary>
        /// Cost Price
        /// </summary>

        [JsonProperty("costPrice")]
        public string? CostPrice { get; set; }

        /// <summary>
        /// Quantity Previous Balance(the value before last change)
        /// </summary>

        [JsonProperty("quantityPreviousBalance")]
        public string? QuantityPreviousBalance { get; set; }

        /// <summary>
        /// Quantity Received
        /// </summary>

        [JsonProperty("quantityReceived")]
        public decimal? QuantityReceived { get; set; }

        /// <summary>
        /// Quantity sold for measurable products
        /// </summary>

        [JsonProperty("quantitySold")]
        public decimal? QuantitySold { get; set; }

        /// <summary>
        /// Quantity new balance
        /// </summary>

        [JsonProperty("quantityNewBalance")]
        public string? QuantityNewBalance { get; set; }

        /// <summary>
        /// Product Quantity
        /// </summary>

        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Quantity Measurement UnitId
        /// </summary>

        [JsonProperty("quantityMeasurementUnitId")]
        public string? QuantityMeasurementUnitId { get; set; }

        /// <summary>
        /// Measurement Unit2
        /// </summary>

        [JsonProperty("measurementUnit2")]
        public string? MeasurementUnit2 { get; set; }

        /// <summary>
        /// Optional Secondary Quantity2 property
        /// </summary>

        [JsonProperty("quantity2")]
        public decimal? Quantity2 { get; set; }

        /// <summary>
        /// Net weight without packaging
        /// </summary>

        [JsonProperty("netWeight")]
        public decimal? NetWeight { get; set; }

        /// <summary>
        /// Gross weight with packaging weight included
        /// </summary>

        [JsonProperty("grossWeight")]
        public decimal? GrossWeight { get; set; }

        /// <summary>
        /// Volume of package
        /// </summary>

        [JsonProperty("volume")]
        public decimal? Volume { get; set; }

        /// <summary>
        /// Total Allowances or Charges
        /// </summary>

        [JsonProperty("allowancesCharges")]
        public AllowanceCharge? AllowancesCharges { get; set; }

        /// <summary>
        /// Internal Product or Service Id
        /// </summary>

        [JsonProperty("internalId")]
        public string? InternalId { get; set; }

        /// <summary>
        /// Total Surcharge Amount
        /// </summary>

        [JsonProperty("totalSurchargeAmount")]
        public decimal? TotalSurchargeAmount { get; set; }

        /// <summary>
        /// Total Special Taxes
        /// </summary>

        [JsonProperty("totalSpecialTaxes")]
        public decimal? TotalSpecialTaxes { get; set; }

        /// <summary>
        /// Total Cost
        /// </summary>

        [JsonProperty("totalCost")]
        public decimal? TotalCost { get; set; }

        /// <summary>
        /// Total Net Value Before Discount
        /// </summary>

        [JsonProperty("totalNetValueBeforeTotalDiscount")]
        public decimal? TotalNetValueBeforeTotalDiscount { get; set; }

        /// <summary>
        /// Line Apportioned Discount Value
        /// </summary>

        [JsonProperty("lineApportionedDiscountValue")]
        public decimal? LineApportionedDiscountValue { get; set; }

        /// <summary>
        /// Currency
        /// </summary>

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Rate
        /// </summary>

        [JsonProperty("rate")]
        public decimal? Rate { get; set; }

        /// <summary>
        /// Foreign Currency Value
        /// </summary>

        [JsonProperty("foreignCurrencyValue")]
        public decimal? ForeignCurrencyValue { get; set; }

        /// <summary>
        /// Remarks
        /// </summary>

        [JsonProperty("remarks")]
        public string? Remarks { get; set; }

        /// <summary>
        /// Reason
        /// </summary>

        [JsonProperty("reason")]
        public string? Reason { get; set; }

        [JsonProperty("detailRecipient")]
        public Party? DetailRecipient { get; set; }

        /// <summary>
        /// Project
        /// </summary>

        [JsonProperty("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Lot Number
        /// </summary>

        [JsonProperty("lotNumber")]
        public string? LotNumber { get; set; }

        /// <summary>
        /// List of Serial Numbers
        /// </summary>

        [JsonProperty("serialNumbers")]
        public IEnumerable<string>? SerialNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonProperty("relativeDocuments")]
        public IEnumerable<string>? RelativeDocuments { get; set; }

        /// <summary>
        /// Unit price before any allowances, charges or taxes
        /// </summary>

        [JsonProperty("catalogUnitPrice")]
        public decimal? CatalogUnitPrice { get; set; }

        /// <summary>
        /// The taxable unit price. Unit price after all discounts/charges are applied.
        /// </summary>

        [JsonProperty("unitPrice")]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Total net amount before any allowances, charges or taxes
        /// </summary>

        [JsonProperty("catalogNetTotal")]
        public decimal? CatalogNetTotal { get; set; }

        /// <summary>
        /// Total gross amount before any allowances, charges or taxes
        /// </summary>

        [JsonProperty("catalogTotal")]
        public decimal? CatalogTotal { get; set; }

        /// <summary>
        /// Total amount after inline discount-charges
        /// </summary>

        [JsonProperty("netTotalAfterInlineALCs")]
        public decimal? NetTotalAfterInlineALCs { get; set; }

        /// <summary>
        /// The taxable net total in Euro. Calculated after all discounts/charges are applied.
        /// </summary>

        [JsonProperty("netTotal")]
        public decimal? NetTotal { get; set; }

        /// <summary>
        /// The taxable net total in Accounting Currency. Calculated after all discounts/charges are applied.
        /// </summary>

        [JsonProperty("netTotalAC")]
        public decimal? NetTotalAC { get; set; }

        /// <summary>
        /// Final gross amount in Euro, after all allowances, charges and taxes
        /// </summary>

        [JsonProperty("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Final amount in Accounting Currency, after all allowances, charges and taxes
        /// </summary>

        [JsonProperty("totalAC")]
        public decimal? TotalAC { get; set; }

        /// <summary>
        /// Total of all allowances applied
        /// </summary>

        [JsonProperty("allowancesTotal")]
        public decimal? AllowancesTotal { get; set; }

        /// <summary>
        /// Total of all allowances applied in Accounting Currency
        /// </summary>

        [JsonProperty("allowancesTotalAC")]
        public decimal? AllowancesTotalAC { get; set; }

        /// <summary>
        /// Total of all charges applied
        /// </summary>

        [JsonProperty("chargesTotal")]
        public decimal? ChargesTotal { get; set; }

        /// <summary>
        /// Total of all charges applied in Accounting Currency
        /// </summary>

        [JsonProperty("chargesTotalAC")]
        public decimal? ChargesTotalAC { get; set; }

        /// <summary>
        /// Total of all vat applied
        /// </summary>

        [JsonProperty("vatTotal")]
        public decimal? VatTotal { get; set; }

        /// <summary>
        /// Total of all vat applied in Accounting Currency
        /// </summary>

        [JsonProperty("vatTotalAC")]
        public decimal? VatTotalAC { get; set; }

        /// <summary>
        /// Exchange Currency Value
        /// </summary>

        [JsonProperty("exchangeCurrencyValue")]
        public decimal? ExchangeCurrencyValue { get; set; }

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
        /// Reasoning
        /// </summary>

        [JsonProperty("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Beneficiary Account
        /// </summary>

        [JsonProperty("beneficiaryAccount")]
        public string? BeneficiaryAccount { get; set; }

        /// <summary>
        /// Beneficiary
        /// </summary>

        [JsonProperty("beneficiary")]
        public string? Beneficiary { get; set; }

        /// <summary>
        /// Exchange
        /// </summary>

        [JsonProperty("exchange")]
        public string? Exchange { get; set; }

        /// <summary>
        /// Cash
        /// </summary>

        [JsonProperty("chrimatikaDiathesima")]
        public string? ChrimatikaDiathesima { get; set; }

        /// <summary>
        /// Securities Amount
        /// </summary>

        [JsonProperty("securitiesAmount")]
        public decimal? SecuritiesAmount { get; set; }

        /// <summary>
        /// Registration Number
        /// </summary>

        [JsonProperty("registrationNumber")]
        public int? RegistrationNumber { get; set; }

        /// <summary>
        /// Securities Bank
        /// </summary>

        [JsonProperty("securitiesBank")]
        public string? SecuritiesBank { get; set; }

        /// <summary>
        /// Due Date
        /// </summary>

        [JsonProperty("dueDate")]
        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Local Currency Exchange Rate
        /// </summary>

        [JsonProperty("localCurrencyExchangeRate")]
        public decimal? LocalCurrencyExchangeRate { get; set; }

        /// <summary>
        /// Securities Field
        /// </summary>

        [JsonProperty("securitiesField")]
        public string? SecuritiesField { get; set; }

        /// <summary>
        /// Sponsor Code
        /// </summary>

        [JsonProperty("sponsorCode")]
        public string? SponsorCode { get; set; }

        /// <summary>
        /// Sponsor Name
        /// </summary>

        [JsonProperty("sponsorName")]
        public string? SponsorName { get; set; }

        /// <summary>
        /// Issuer Name
        /// </summary>

        [JsonProperty("issuerName")]
        public string? IssuerName { get; set; }

        /// <summary>
        /// Issuer Code
        /// </summary>

        [JsonProperty("issuerCode")]
        public string? IssuerCode { get; set; }

        /// <summary>
        /// Invoice Detail Type
        /// </summary>

        [JsonProperty("invoiceDetailType")]
        public string? InvoiceDetailType { get; set; }

        /// <summary>
        /// Invoice Detail Type Code
        /// </summary>

        [JsonProperty("invoiceDetailTypeCode")]
        public int? InvoiceDetailTypeCode { get; set; }

        /// <summary>
        /// Vat Excemption Category
        /// </summary>

        [JsonProperty("vatExcemptionCategory")]
        public string? VatExcemptionCategory { get; set; }

        /// <summary>
        /// Vat Excemption Category Code
        /// </summary>

        [JsonProperty("vatExemptionCategoryCode")]
        public int? VatExemptionCategoryCode { get; set; }

        [JsonProperty("shipType")]
        public ShipType? ShipType { get; set; }

        /// <summary>
        /// Discount Option
        /// </summary>

        [JsonProperty("discountOption")]
        public bool? DiscountOption { get; set; }

        /// <summary>
        /// Vat Category
        /// </summary>

        [JsonProperty("vatCategory")]
        public string? VatCategory { get; set; }

        /// <summary>
        /// Vat Category Code
        /// </summary>

        [JsonProperty("vatCategoryCode")]
        public int? VatCategoryCode { get; set; }

        /// <summary>
        /// With Held Amount
        /// </summary>

        [JsonProperty("withheldAmount")]
        public decimal? WithheldAmount { get; set; }

        /// <summary>
        /// Withheld Amount in Accounting Currency
        /// </summary>

        [JsonProperty("withheldAmountAC")]
        public decimal? WithHeldAmountAC { get; set; }

        /// <summary>
        /// With Held Percent Category
        /// </summary>

        [JsonProperty("withheldPercentCategory")]
        public string? WithHeldPercentCategory { get; set; }

        /// <summary>
        /// With Held Percentage Category Code
        /// </summary>

        [JsonProperty("withheldPercentCategoryCode")]
        public int? WithHeldPercentCategoryCode { get; set; }

        /// <summary>
        /// Stamp Duty Amount
        /// </summary>

        [JsonProperty("stampDutyAmount")]
        public decimal? StampDutyAmount { get; set; }

        /// <summary>
        /// Stamp Duty Amount in Accounting Currency
        /// </summary>

        [JsonProperty("stampDutyAmountAC")]
        public decimal? StampDutyAmountAC { get;set; }

        /// <summary>
        /// Stamp Duty Percent Category
        /// </summary>

        [JsonProperty("stampDutyPercentCategory")]
        public string? StampDutyPercentCategory { get; set; }

        /// <summary>
        /// Stamp Duty Percent Category Code
        /// </summary>

        [JsonProperty("stampDutyPercentCategoryCode")]
        public int? StampDutyPercentCategoryCode { get; set; }

        /// <summary>
        /// Total fees amount
        /// </summary>

        [JsonProperty("feesAmount")]
        public decimal? FeesAmount { get; set; }

        /// <summary>
        /// Total fees amount in accounting currency
        /// </summary>

        [JsonProperty("feesAmountAC")]
        public decimal? FeesAmountAC { get; set; }

        /// <summary>
        /// Fees Percentage Category
        /// </summary>

        [JsonProperty("feesPercentCategory")]
        public string? FeesPercentCategory { get; set; }

        /// <summary>
        /// Fees Percent Category Code
        /// </summary>

        [JsonProperty("feesPercentCategoryCode")]
        public int? FeesPercentCategoryCode { get; set; }

        /// <summary>
        /// Other Taxes Percent Category
        /// </summary>

        [JsonProperty("otherTaxesPercentCategory")]
        public string? OtherTaxesPercentCategory { get; set; }

        /// <summary>
        /// Other Taxes Percent Category Code
        /// </summary>

        [JsonProperty("otherTaxesPercentCategoryCode")]
        public int? OtherTaxesPercentCategoryCode { get; set; }

        /// <summary>
        /// Other Taxes Amount
        /// </summary>

        [JsonProperty("otherTaxesAmount")]
        public decimal? OtherTaxesAmount { get; set; }

        /// <summary>
        /// Other Taxes Amount in Accounting Currency
        /// </summary>

        [JsonProperty("otherTaxesAmountAC")]
        public decimal? OtherTaxesAmountAC { get; set; }

        /// <summary>
        /// Deductions Amount
        /// </summary>

        [JsonProperty("deductionsAmount")]
        public decimal? DeductionsAmount { get; set; }

        /// <summary>
        /// Deductions Amount in Accounting Currency
        /// </summary>

        [JsonProperty("deductionsAmountAC")]
        public decimal? DeductionsAmountAC { get; set; }

        /// <summary>
        /// Informative lines are used for display purposes only and are not calculated
        /// </summary>

        [JsonProperty("isInformative")]
        public bool ISInformative { get; set; }

        [JsonProperty("isHidden")]
        public bool ISHidden { get; set; }

        /// <summary>
        /// Record Type
        /// </summary>

        [JsonProperty("recordType")]
        public string? RecordType { get; set; }

        [JsonProperty("recordTypeCode")]
        public RecordTypeEnum recordTypeCode { get; set; }

        [JsonProperty("incomeClassification")]
        public Classification IncomeClassification { get; set; }

        [JsonProperty("expensesClassification")]
        public Classification ExpensesClassification { get; set; }

        [JsonProperty("vatClassification")]
        public Classification VatClassification { get; set; }

        /// <summary>
        /// Fuel code used by IAPR for fuel invoices.
        /// </summary>

        [JsonProperty("fuelCode")]
        public int? FuelCode { get; set; }

        /// <summary>
        /// Specific weight for fuel invoicse
        /// </summary>

        [JsonProperty("specificWeight")]
        public decimal? SpecificWeight { get; set; }

        /// <summary>
        /// Detail Tags
        /// </summary>

        [JsonProperty("tags")]
        public IEnumerable<string>? Tags { get; set; }

        /// <summary>
        /// For fuel invoices
        /// </summary>

        [JsonProperty("compartments")]
        public string? Compartments { get; set; }

        /// <summary>
        /// Tank, Container name
        /// </summary>

        [JsonProperty("containerName")]
        public string? ContainerName { get; set; }

        /// <summary>
        /// Conversion factor
        /// </summary>

        [JsonProperty("conversionFactor")]
        public decimal? ConversionFactor { get; set; }

        /// <summary>
        /// Density
        /// </summary>

        [JsonProperty("density")]
        public decimal? Density { get; set; }

        /// <summary>
        /// Temperature
        /// </summary>

        [JsonProperty("temperature")]
        public decimal? Temperature { get; set; }


    }
}
