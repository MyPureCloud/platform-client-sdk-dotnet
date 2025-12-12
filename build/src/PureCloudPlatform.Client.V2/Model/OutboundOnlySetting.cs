using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OutboundOnlySetting
	/// </summary>
	[DataContract]
	public partial class OutboundOnlySetting : IEquatable<OutboundOnlySetting>
	{
		/// <summary>
		/// Status for the Outbound Direction
		/// </summary>
		/// <value>Status for the Outbound Direction</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OutboundEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Enabled for "Enabled"
			/// </summary>
			[EnumMember(Value = "Enabled")]
			Enabled,

			/// <summary>
			/// Enum Disabled for "Disabled"
			/// </summary>
			[EnumMember(Value = "Disabled")]
			Disabled
		}
		/// <summary>
		/// Status for the Outbound Direction
		/// </summary>
		/// <value>Status for the Outbound Direction</value>
		[DataMember(Name = "outbound", EmitDefaultValue = false)]
		public OutboundEnum? Outbound { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="OutboundOnlySetting" /> class.
		/// </summary>
		/// <param name="Outbound">Status for the Outbound Direction.</param>
		public OutboundOnlySetting(OutboundEnum? Outbound = null)
		{
			this.Outbound = Outbound;

		}




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutboundOnlySetting {\n");

			sb.Append("  Outbound: ").Append(Outbound).Append("\n");
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
			return this.Equals(obj as OutboundOnlySetting);
		}

		/// <summary>
		/// Returns true if OutboundOnlySetting instances are equal
		/// </summary>
		/// <param name="other">Instance of OutboundOnlySetting to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutboundOnlySetting other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Outbound == other.Outbound ||
					this.Outbound != null &&
					this.Outbound.Equals(other.Outbound)
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
				if (this.Outbound != null)
					hash = hash * 59 + this.Outbound.GetHashCode();

				return hash;
			}
		}
	}

}
