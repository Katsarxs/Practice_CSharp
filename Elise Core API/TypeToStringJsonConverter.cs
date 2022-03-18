using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public enum AllowanceChargeTypeEnum
    {
        Allowance,
        Charge
    }

    public class TypeToStringJsonConverter : JsonConverter<AllowanceChargeTypeEnum>
    {
        public override AllowanceChargeTypeEnum ReadJson(JsonReader reader, Type objectType, AllowanceChargeTypeEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            if (value == "ALLOWANCE")
                return AllowanceChargeTypeEnum.Allowance;

            if (value == "CHARGE")
                return AllowanceChargeTypeEnum.Charge;

            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, AllowanceChargeTypeEnum value, JsonSerializer serializer)
        {

            if (value == AllowanceChargeTypeEnum.Allowance)
                writer.WriteValue("ALLOWANCE");

            if (value == AllowanceChargeTypeEnum.Charge)
                writer.WriteValue("CHARGE");

            throw new NotImplementedException();
        }
    }
}