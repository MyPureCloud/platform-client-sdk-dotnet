using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerCampaignScheduleConfigChangeAlteration
	/// </summary>
	[DataContract]
	public partial class DialerCampaignScheduleConfigChangeAlteration : IEquatable<DialerCampaignScheduleConfigChangeAlteration>
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Exclusion for "Exclusion"
			/// </summary>
			[EnumMember(Value = "Exclusion")]
			Exclusion,

			/// <summary>
			/// Enum Inclusion for "Inclusion"
			/// </summary>
			[EnumMember(Value = "Inclusion")]
			Inclusion
		}
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerCampaignScheduleConfigChangeAlteration" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Start">the end date of an alteration range as an ISO-8601 string.</param>
		/// <param name="End">the end date of an alteration range as an ISO-8601 string.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerCampaignScheduleConfigChangeAlteration(TypeEnum? Type = null, string Start = null, string End = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.Type = Type;
			this.Start = Start;
			this.End = End;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}





		/// <summary>
		/// the end date of an alteration range as an ISO-8601 string
		/// </summary>
		/// <value>the end date of an alteration range as an ISO-8601 string</value>
		[DataMember(Name = "start", EmitDefaultValue = false)]
		public string Start { get; set; }



		/// <summary>
		/// the end date of an alteration range as an ISO-8601 string
		/// </summary>
		/// <value>the end date of an alteration range as an ISO-8601 string</value>
		[DataMember(Name = "end", EmitDefaultValue = false)]
		public string End { get; set; }



		/// <summary>
		/// Gets or Sets AdditionalProperties
		/// </summary>
		[DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> AdditionalProperties { get; set; }



		/// <summary>
		/// Gets or Sets GetAdditionalProperties
		/// </summary>
		[DataMember(Name = "getAdditionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> GetAdditionalProperties { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialerCampaignScheduleConfigChangeAlteration {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Start: ").Append(Start).Append("\n");
			sb.Append("  End: ").Append(End).Append("\n");
			sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
			sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
			return this.Equals(obj as DialerCampaignScheduleConfigChangeAlteration);
		}

		/// <summary>
		/// Returns true if DialerCampaignScheduleConfigChangeAlteration instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerCampaignScheduleConfigChangeAlteration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerCampaignScheduleConfigChangeAlteration other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Start == other.Start ||
					this.Start != null &&
					this.Start.Equals(other.Start)
				) &&
				(
					this.End == other.End ||
					this.End != null &&
					this.End.Equals(other.End)
				) &&
				(
					this.AdditionalProperties == other.AdditionalProperties ||
					this.AdditionalProperties != null &&
					this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
				) &&
				(
					this.GetAdditionalProperties == other.GetAdditionalProperties ||
					this.GetAdditionalProperties != null &&
					this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Start != null)
					hash = hash * 59 + this.Start.GetHashCode();

				if (this.End != null)
					hash = hash * 59 + this.End.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
