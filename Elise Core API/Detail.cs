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
    }
}
