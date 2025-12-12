using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyAppEventsNotificationCustomEventAttribute
	/// </summary>
	[DataContract]
	public partial class JourneyAppEventsNotificationCustomEventAttribute : IEquatable<JourneyAppEventsNotificationCustomEventAttribute>
	{
		/// <summary>
		/// Gets or Sets DataType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DataTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum String for "STRING"
			/// </summary>
			[EnumMember(Value = "STRING")]
			String,

			/// <summary>
			/// Enum Boolean for "BOOLEAN"
			/// </summary>
			[EnumMember(Value = "BOOLEAN")]
			Boolean,

			/// <summary>
			/// Enum Number for "NUMBER"
			/// </summary>
			[EnumMember(Value = "NUMBER")]
			Number
		}
		/// <summary>
		/// Gets or Sets DataType
		/// </summary>
		[DataMember(Name = "dataType", EmitDefaultValue = false)]
		public DataTypeEnum? DataType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyAppEventsNotificationCustomEventAttribute" /> class.
		/// </summary>
		/// <param name="Value">Value.</param>
		/// <param name="DataType">DataType.</param>
		public JourneyAppEventsNotificationCustomEventAttribute(string Value = null, DataTypeEnum? DataType = null)
		{
			this.Value = Value;
			this.DataType = DataType;

		}



		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyAppEventsNotificationCustomEventAttribute {\n");

			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("  DataType: ").Append(DataType).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings
			{
				MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
				Formatting = Formatting.Indented
			});
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return this.Equals(obj as JourneyAppEventsNotificationCustomEventAttribute);
		}

		/// <summary>
		/// Returns true if JourneyAppEventsNotificationCustomEventAttribute instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyAppEventsNotificationCustomEventAttribute to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyAppEventsNotificationCustomEventAttribute other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
				) &&
				(
					this.DataType == other.DataType ||
					this.DataType != null &&
					this.DataType.Equals(other.DataType)
				);
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			// credit: http://stackoverflow.com/a/263416/677735
			unchecked // Overflow is fine, just wrap
			{
				int hash = 41;
				// Suitable nullity checks etc, of course :)
				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				if (this.DataType != null)
					hash = hash * 59 + this.DataType.GetHashCode();

				return hash;
			}
		}
	}

}
