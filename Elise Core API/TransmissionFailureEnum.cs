using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    /// <summary>
    /// Determines Reason of the delay.
    /// </summary>

    public enum TransmissionFailureEnum
    {
        /// <summary>
        /// Online Transaction
        /// </summary>

        Live,

        /// <summary>
        /// Client Side Network Issues
        /// </summary>

        Client,

        /// <summary>
        /// IAPR service down
        /// </summary>

        Iapr
    }

    public class TransmissionFailureEnumToStringJsonConverter : JsonConverter<TransmissionFailureEnum>
    {
        public override TransmissionFailureEnum ReadJson(JsonReader reader, Type objectType, TransmissionFailureEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            if (value == "LIVE")
                return TransmissionFailureEnum.Live;

            if (value == "CLIENT")
                return TransmissionFailureEnum.Client;

            if (value == "IAPR")

                return TransmissionFailureEnum.Iapr;

            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, TransmissionFailureEnum value, JsonSerializer serializer)
        {
            if (value == TransmissionFailureEnum.Live)
                writer.WriteValue("LIVE");

            if (value == TransmissionFailureEnum.Client)
                writer.WriteValue("CLIENT");

            if (value == TransmissionFailureEnum.Iapr)
                writer.WriteValue("IAPR");

            throw new NotImplementedException();
        }
    }



}
