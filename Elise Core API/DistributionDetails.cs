using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public class DistributionDetails
    {
        /// <summary>
        /// Internal Document Id. Identifier given by ERP system.
        /// </summary>

        [JsonProperty("internalDocumentId")]
        public string? InternalDocumentId { get; set; }

        /// <summary>
        /// Installation Id
        /// </summary>

        [JsonProperty("installationId")]
        public string? InstallationId { get; set; }

        /// <summary>
        /// The method of products delivery to the customer
        /// </summary>

        [JsonProperty("shippingMethod")]
        public string? ShippingMethod { get; set; }

        /// <summary>
        /// Shipping Method Code
        /// </summary>

        [JsonProperty("shippingMethodCode")]
        public string? ShippingMethodCode { get; set; }

        /// <summary>
        /// Move Purpose
        /// </summary>

        [JsonProperty("movePurpose")]
        public string? MovePurpose { get; set; }

        /// <summary>
        /// Total Quantity
        /// </summary>

        [JsonProperty("totalQuantity")]
        public decimal? TotalQuantity { get; set; }

        /// <summary>
        /// Valid Values are 1-8.
        /// </summary>

        [JsonProperty("movePurposeCode")]
        public int? MovePurposeCode { get; set; }

        /// <summary>
        /// Dispatch Date
        /// </summary>

        [JsonProperty("dispatchDate")]
        [JsonConverter(typeof(StringToDateTimeJsonConverter))]
        public DateTime? DispatchDate { get; set; }

        [JsonProperty("dispatchTime")]
        [JsonConverter(typeof(StringToNullableDateTimeJsonConverter))]
        public DateTime? DispatchTime { get; set; }

        /// <summary>
        /// Vechicle Number
        /// </summary>

        [JsonProperty("vehileNumber")]
        public string? VehileNumber { get; set; }

        [JsonProperty("delivery")]
        [JsonConverter(typeof(StringToNullableDateTimeJsonConverter))]
        public DateTime? Delivery { get; set; }

        /// <summary>
        /// Relative Dosuments Ids
        /// </summary>

        [JsonProperty("relativeDocuments")]
        public IEnumerable<string>? RelativeDocuments { get; set; }

        /// <summary>
        /// Τhe person who made the sale
        /// </summary>

        [JsonProperty("salesman")]
        public string? Salesman { get; set; }

        /// <summary>
        /// Loading Place
        /// </summary>

        [JsonProperty("billOfLading")]
        public string? BillOfLading { get; set; }

        /// <summary>
        /// House Bill
        /// </summary>

        [JsonProperty("houseBill")]
        public string? HouseBill { get; set; }

        [JsonProperty("ldm")]
        public decimal? Ldm { get; set; }

        /// <summary>
        /// Project
        /// </summary>

        [JsonProperty("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Delivery Date
        /// </summary>

        [JsonProperty("deliveryDate")]
        [JsonConverter(typeof(StringToNullableDateTimeJsonConverter))]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// Freight Volume
        /// </summary>

        [JsonProperty("freightVolume")]
        public decimal? FreightVolume { get; set; }

        /// <summary>
        /// Billed Freight Weight
        /// </summary>

        [JsonProperty("billedFreightWeight")]
        public decimal? BilledFreightWeight { get; set; }

        /// <summary>
        /// Gross Freight Weight
        /// </summary>

        [JsonProperty("grossFreightWeight")]
        public decimal? GrossFreightWeight { get; set; }

        /// <summary>
        /// Content
        /// </summary>

        [JsonProperty("content")]
        public string? Content { get; set; }

        [JsonProperty("deliveryOriginDetails")]
        public DeliveryDetails DeliveryOriginDetails { get; set; }

        [JsonProperty("deliveryDestinationDetails")]
        public DeliveryDetails DeliveryDestinationDetails { get; set; }

    }
}
