using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public enum DocumentStatusEnum
    {
        UNKNOWn,
        SUBMITTEd,
        PENDINg,
        INVALId,
        SELFSIGNEd,
        CANCELEd,
        NOBLOb
    }

    public class DocumentStatusEnumToStringJsonConverter : JsonConverter<DocumentStatusEnum>
    {
        public override DocumentStatusEnum ReadJson(JsonReader reader, Type objectType, DocumentStatusEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            if (value == "UNKNOWN")
                return DocumentStatusEnum.UNKNOWn;

            if (value == "SUBMITTED")
                return DocumentStatusEnum.SUBMITTEd;

            if (value == "PENDING")
                return DocumentStatusEnum.PENDINg;

            if (value == "INVALID")
                return DocumentStatusEnum.INVALId;

            if (value == "SELFSIGNED")
                return DocumentStatusEnum.SELFSIGNEd;

            if (value == "CANCELED")
                return DocumentStatusEnum.CANCELEd;

            if (value == "NOBLOB ")
                return DocumentStatusEnum.NOBLOb;

            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, DocumentStatusEnum value, JsonSerializer serializer)
        {
            if (value == DocumentStatusEnum.UNKNOWn)
                writer.WriteValue("UNKNOWN");

            if (value == DocumentStatusEnum.SUBMITTEd)
                writer.WriteValue("SUBMITTED");

            if (value == DocumentStatusEnum.PENDINg)
                writer.WriteValue("PENDING");

            if (value == DocumentStatusEnum.INVALId)
                writer.WriteValue("INVALID");

            if (value == DocumentStatusEnum.SELFSIGNEd)
                writer.WriteValue("SELFSIGNED");

            if (value == DocumentStatusEnum.CANCELEd)
                writer.WriteValue("CANCELED");

            if (value == DocumentStatusEnum.NOBLOb)
                writer.WriteValue("NOBLOB");


            throw new NotImplementedException();
        }
    }
}
