using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elise_Core_API
{
    /// <summary>
    /// IAPR currenty supports only 0,2,3,6 Determines the type of the line. Lines with rectype other than NORMAL, do not receive classifications.
    /// </summary>

    public enum IAPRSignPolicyEnum
    {
        /// <summary>
        /// Selfsign IAPR timeouts
        /// </summary>
        
        Default,

        /// <summary>
        /// Selfsign timeouts and validation errors
        /// </summary>

        Loose,

        /// <summary>
        /// Don't selfsign anything. If none provided, STRICT is selected
        /// </summary>

        Strict
    }

    public class IAPRSignPolicyEnumToStringJsonConverter : JsonConverter<IAPRSignPolicyEnum>
    {
        public override IAPRSignPolicyEnum ReadJson(JsonReader reader, Type objectType, IAPRSignPolicyEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            if (value == "DEFAULT")
                return IAPRSignPolicyEnum.Default;

            if (value == "LOOSE")
                return IAPRSignPolicyEnum.Loose;

            if (value == "STRICT")
                return IAPRSignPolicyEnum.Strict;

            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, IAPRSignPolicyEnum value, JsonSerializer serializer)
        {

            if (value == IAPRSignPolicyEnum.Default)
                writer.WriteValue("ALLOWANCE");

            if (value == IAPRSignPolicyEnum.Loose)
                writer.WriteValue("CHARGE");

            if (value == IAPRSignPolicyEnum.Strict)
                writer.WriteValue("STRICT");

            throw new NotImplementedException();
        }
    }
}
