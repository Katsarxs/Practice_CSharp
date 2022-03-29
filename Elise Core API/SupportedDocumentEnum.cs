using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public enum SupportedDocumentEnum
    {
        Unknown,
        Invoice,
        Order,
        Deliverynote,
        Offer,
        Intinvoice,
        Approvaldoc,
        Elb2g,
        Invoicedoc,
        Erpinvoice
    }

    public class SupportedDocumentEnumToStringJsonConverter : JsonConverter<SupportedDocumentEnum>
    {
        public override SupportedDocumentEnum ReadJson(JsonReader reader, Type objectType, SupportedDocumentEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            if (value == "UNKNOWN")
                return SupportedDocumentEnum.Unknown;

            if (value == "INVOICE")
                return SupportedDocumentEnum.Invoice;

            if (value == "ORDER")
                return SupportedDocumentEnum.Order;

            if (value == "DELIVERYNOTE")
                return SupportedDocumentEnum.Deliverynote;

            if (value == "OFFER")
                return SupportedDocumentEnum.Offer;

            if (value == "INTINVOICE")
                return SupportedDocumentEnum.Intinvoice;

            if (value == "APPROVALDOC")
                return SupportedDocumentEnum.Approvaldoc;

            if (value == "ELB2G")
                return SupportedDocumentEnum.Elb2g;

            if (value == "INVOICEDOC")
                return SupportedDocumentEnum.Invoicedoc;

            if (value == "ERPINVOICE ")
                return SupportedDocumentEnum.Erpinvoice;

            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, SupportedDocumentEnum value, JsonSerializer serializer)
        {
            if (value == SupportedDocumentEnum.Unknown)
                writer.WriteValue("UNKNOWN");

            if (value == SupportedDocumentEnum.Invoice)
                writer.WriteValue("INVOICE");

            if (value == SupportedDocumentEnum.Order)
                writer.WriteValue("ORDER");

            if (value == SupportedDocumentEnum.Deliverynote)
                writer.WriteValue("DELIVERYNOTE");

            if (value == SupportedDocumentEnum.Offer)
                writer.WriteValue("OFFER");

            if (value == SupportedDocumentEnum.Intinvoice)
                writer.WriteValue("INTINVOICE");

            if (value == SupportedDocumentEnum.Approvaldoc)
                writer.WriteValue("APPROVALDOC");

            if (value == SupportedDocumentEnum.Elb2g)
                writer.WriteValue("ELB2G");

            if (value == SupportedDocumentEnum.Invoicedoc)
                writer.WriteValue("INVOICEDOC");

            if (value == SupportedDocumentEnum.Erpinvoice)
                writer.WriteValue("ERPINVOICE ");

            throw new NotImplementedException();
        }
    }
}
