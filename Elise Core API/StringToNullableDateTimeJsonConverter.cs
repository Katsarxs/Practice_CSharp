using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elise_Core_API
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that sets a <see cref="DateOnly"/> property based on its existence on the Json string
    /// </summary>
    public class StringToNullableDateTimeJsonConverter : JsonConverter<DateTime?>
    {
        #region Constants

        public const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffZ";

        #endregion

        #region Public Methods

        /// <summary>
        /// Reads the JSON representation of the <paramref name="reader"/> value into <see cref="bool"/>
        /// </summary>
        /// <param name="reader">The reader</param>
        /// <param name="objectType">The object type</param>
        /// <param name="existingValue">The existing value</param>
        /// <param name="hasExistingValue">True is the existing value has a value</param>
        /// <param name="serializer">The serializer</param>
        /// <returns></returns>

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // Get the reader value
            var readerValue = serializer.Deserialize<string>(reader);

            if (readerValue == null)
                return null;
            else
                return DateTime.ParseExact(readerValue, DateTimeFormat, null);
        }

        /// <summary>
        /// Writes the JSON representation of the <paramref name="value"/>
        /// </summary>
        /// <param name="writer">The writer</param>
        /// <param name="value">The value to write</param>
        /// <param name="serializer">The serializer</param>
        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            if (value == null)
                writer.WriteNull();
            else
                writer.WriteValue(value.Value.ToString(DateTimeFormat));
        }

        #endregion
    }

    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that sets a <see cref="DateOnly"/> property based on its existence on the Json string
    /// </summary>
    public class StringToDateTimeJsonConverter : JsonConverter<DateTime?>
    {
        #region Constants

        public const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffffff";

        #endregion

        #region Public Methods

        /// <summary>
        /// Reads the JSON representation of the <paramref name="reader"/> value into <see cref="bool"/>
        /// </summary>
        /// <param name="reader">The reader</param>
        /// <param name="objectType">The object type</param>
        /// <param name="existingValue">The existing value</param>
        /// <param name="hasExistingValue">True is the existing value has a value</param>
        /// <param name="serializer">The serializer</param>
        /// <returns></returns>

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // Get the reader value
            var readerValue = serializer.Deserialize<string>(reader);

            if (readerValue == null)
                return null;
            else
                return DateTime.ParseExact(readerValue, DateTimeFormat, null);
        }

        /// <summary>
        /// Writes the JSON representation of the <paramref name="value"/>
        /// </summary>
        /// <param name="writer">The writer</param>
        /// <param name="value">The value to write</param>
        /// <param name="serializer">The serializer</param>
        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            if (value == null)
                writer.WriteNull();
            else
                writer.WriteValue(value.Value.ToString(DateTimeFormat));
        }

        #endregion
    }
}
