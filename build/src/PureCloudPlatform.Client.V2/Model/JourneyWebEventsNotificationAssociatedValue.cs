using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyWebEventsNotificationAssociatedValue
	/// </summary>
	[DataContract]
	public partial class JourneyWebEventsNotificationAssociatedValue : IEquatable<JourneyWebEventsNotificationAssociatedValue>
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
			/// Enum Number for "Number"
			/// </summary>
			[EnumMember(Value = "Number")]
			Number,

			/// <summary>
			/// Enum Integer for "Integer"
			/// </summary>
			[EnumMember(Value = "Integer")]
			Integer
		}
		/// <summary>
		/// Gets or Sets DataType
		/// </summary>
		[DataMember(Name = "dataType", EmitDefaultValue = false)]
		public DataTypeEnum? DataType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyWebEventsNotificationAssociatedValue" /> class.
		/// </summary>
		/// <param name="DataType">DataType.</param>
		/// <param name="Value">Value.</param>
		public JourneyWebEventsNotificationAssociatedValue(DataTypeEnum? DataType = null, double? Value = null)
		{
			this.DataType = DataType;
			this.Value = Value;

		}





		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public double? Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyWebEventsNotificationAssociatedValue {\n");

			sb.Append("  DataType: ").Append(DataType).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as JourneyWebEventsNotificationAssociatedValue);
		}

		/// <summary>
		/// Returns true if JourneyWebEventsNotificationAssociatedValue instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyWebEventsNotificationAssociatedValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyWebEventsNotificationAssociatedValue other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DataType == other.DataType ||
					this.DataType != null &&
					this.DataType.Equals(other.DataType)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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
				if (this.DataType != null)
					hash = hash * 59 + this.DataType.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
