using System.Globalization;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Client
{
	///<Summary>
	/// Extends JSON Converter Class for Iso8601DateTime
	///</Summary>
	public class Iso8601DateTimeConverter : JsonConverter
	{
		///<Summary>
		/// Determines if objectType can be converted.
		///</Summary>
		public override bool CanConvert(Type objectType)
		{
			return (objectType == typeof(DateTime)) || (objectType == typeof(DateTime?));
		}

		///<Summary>
		/// Writes Iso8601DateTime value to JSON
		///</Summary>
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

		///<Summary>
		/// CanRead: Not implemented.
		///</Summary>
		public override bool CanRead => false;

		///<Summary>
		/// ReadJson: Not implemented.
		///</Summary>
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}
