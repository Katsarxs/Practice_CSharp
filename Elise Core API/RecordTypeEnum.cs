using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Elise_Core_API
{
    public enum RecordTypeEnum
    {
        /// <summary>
        /// Usual detail line
        /// </summary>

        Normal,

        /// <summary>
        /// Line contains information about withheld taxes
        /// </summary>

        Withheld,

        /// <summary>
        /// Line contains information about fees
        /// </summary>

        Fee,

        /// <summary>
        /// Line contains information about other taxes
        /// </summary>

        Othertax,

        /// <summary>
        /// Line contains information about stamp duties
        /// </summary>

        Stampduty,

        /// <summary>
        /// Line contains information about deductions
        /// </summary>

        Deduction,

        /// <summary>
        /// Line contains information about giftcards
        /// </summary>

        Giftcard
    }

    public class RecordTypeEnumToStringJsonConverter : JsonConverter<RecordTypeEnum>
    {
        public override RecordTypeEnum ReadJson(JsonReader reader, Type objectType, RecordTypeEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            if (value == "NORMAL")
                return RecordTypeEnum.Normal;

            if (value == "WITHHELD")
                return RecordTypeEnum.Withheld;

            if (value == "FEE")
                return RecordTypeEnum.Fee;

            if (value == "OTHERTAX")
                return RecordTypeEnum.Othertax;

            if (value == "STAMPDUTY")
                return RecordTypeEnum.Stampduty;

            if (value == "DEDUCTION")
                return RecordTypeEnum.Deduction;

            if (value == "GIFTCARD")
                return RecordTypeEnum.Giftcard;

            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, RecordTypeEnum value, JsonSerializer serializer)
        {
            if (value == RecordTypeEnum.Normal)
                writer.WriteValue("NORMAL");

            if (value == RecordTypeEnum.Withheld)
                writer.WriteValue("WITHHELD");

            if (value == RecordTypeEnum.Fee)
                writer.WriteValue("FEE");

            if (value == RecordTypeEnum.Othertax)
                writer.WriteValue("OTHERTAX");

            if (value == RecordTypeEnum.Stampduty)
                writer.WriteValue("STAMPDUTY");

            if (value == RecordTypeEnum.Deduction)
                writer.WriteValue("DEDUCTION");

            if (value == RecordTypeEnum.Giftcard)
                writer.WriteValue("GIFTCARD ");

            throw new NotImplementedException();
        }
    }
}
