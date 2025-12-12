using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Warning
	/// </summary>
	[DataContract]
	public partial class Warning : IEquatable<Warning>
	{
		/// <summary>
		/// The range type for the warning configuration.
		/// </summary>
		/// <value>The range type for the warning configuration.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum RangeTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Over for "OVER"
			/// </summary>
			[EnumMember(Value = "OVER")]
			Over,

			/// <summary>
			/// Enum Under for "UNDER"
			/// </summary>
			[EnumMember(Value = "UNDER")]
			Under,

			/// <summary>
			/// Enum Between for "BETWEEN"
			/// </summary>
			[EnumMember(Value = "BETWEEN")]
			Between
		}
		/// <summary>
		/// The range type for the warning configuration.
		/// </summary>
		/// <value>The range type for the warning configuration.</value>
		[DataMember(Name = "rangeType", EmitDefaultValue = false)]
		public RangeTypeEnum? RangeType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="Warning" /> class.
		/// </summary>
		/// <param name="Value">The value for the warning configuration..</param>
		/// <param name="RangeType">The range type for the warning configuration..</param>
		/// <param name="Color">The color for the warning configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red)..</param>
		public Warning(int? Value = null, RangeTypeEnum? RangeType = null, string Color = null)
		{
			this.Value = Value;
			this.RangeType = RangeType;
			this.Color = Color;

		}



		/// <summary>
		/// The value for the warning configuration.
		/// </summary>
		/// <value>The value for the warning configuration.</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public int? Value { get; set; }





		/// <summary>
		/// The color for the warning configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red).
		/// </summary>
		/// <value>The color for the warning configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red).</value>
		[DataMember(Name = "color", EmitDefaultValue = false)]
		public string Color { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Warning {\n");

			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("  RangeType: ").Append(RangeType).Append("\n");
			sb.Append("  Color: ").Append(Color).Append("\n");
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
			return this.Equals(obj as Warning);
		}

		/// <summary>
		/// Returns true if Warning instances are equal
		/// </summary>
		/// <param name="other">Instance of Warning to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Warning other)
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
					this.RangeType == other.RangeType ||
					this.RangeType != null &&
					this.RangeType.Equals(other.RangeType)
				) &&
				(
					this.Color == other.Color ||
					this.Color != null &&
					this.Color.Equals(other.Color)
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

				if (this.RangeType != null)
					hash = hash * 59 + this.RangeType.GetHashCode();

				if (this.Color != null)
					hash = hash * 59 + this.Color.GetHashCode();

				return hash;
			}
		}
	}

}
