using System;
using System.Globalization;
using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Client
{
    public class Iso8601DateTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(DateTime)) || (objectType == typeof(DateTime?));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var date = (DateTime?)value;
            if (!date.HasValue)
                writer.WriteNull();
            else
            {
                var dateString = date.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.FFFK", CultureInfo.InvariantCulture);
                writer.WriteValue(dateString);
            }
        }

        public override bool CanRead => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
