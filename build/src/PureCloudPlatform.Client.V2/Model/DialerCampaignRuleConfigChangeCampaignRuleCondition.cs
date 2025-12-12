using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerCampaignRuleConfigChangeCampaignRuleCondition
	/// </summary>
	[DataContract]
	public partial class DialerCampaignRuleConfigChangeCampaignRuleCondition : IEquatable<DialerCampaignRuleConfigChangeCampaignRuleCondition>
	{
		/// <summary>
		/// The type of this condition
		/// </summary>
		/// <value>The type of this condition</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ConditionTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Campaignprogress for "campaignProgress"
			/// </summary>
			[EnumMember(Value = "campaignProgress")]
			Campaignprogress,

			/// <summary>
			/// Enum Campaignagents for "campaignAgents"
			/// </summary>
			[EnumMember(Value = "campaignAgents")]
			Campaignagents
		}
		/// <summary>
		/// The type of this condition
		/// </summary>
		/// <value>The type of this condition</value>
		[DataMember(Name = "conditionType", EmitDefaultValue = false)]
		public ConditionTypeEnum? ConditionType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerCampaignRuleConfigChangeCampaignRuleCondition" /> class.
		/// </summary>
		/// <param name="Id">The globally unique identifier for the condition.</param>
		/// <param name="Parameters">The parameters to match this condition.</param>
		/// <param name="ConditionType">The type of this condition.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerCampaignRuleConfigChangeCampaignRuleCondition(string Id = null, Dictionary<string, string> Parameters = null, ConditionTypeEnum? ConditionType = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.Id = Id;
			this.Parameters = Parameters;
			this.ConditionType = ConditionType;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}



		/// <summary>
		/// The globally unique identifier for the condition
		/// </summary>
		/// <value>The globally unique identifier for the condition</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The parameters to match this condition
		/// </summary>
		/// <value>The parameters to match this condition</value>
		[DataMember(Name = "parameters", EmitDefaultValue = false)]
		public Dictionary<string, string> Parameters { get; set; }





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
			sb.Append("class DialerCampaignRuleConfigChangeCampaignRuleCondition {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Parameters: ").Append(Parameters).Append("\n");
			sb.Append("  ConditionType: ").Append(ConditionType).Append("\n");
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
			return this.Equals(obj as DialerCampaignRuleConfigChangeCampaignRuleCondition);
		}

		/// <summary>
		/// Returns true if DialerCampaignRuleConfigChangeCampaignRuleCondition instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerCampaignRuleConfigChangeCampaignRuleCondition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerCampaignRuleConfigChangeCampaignRuleCondition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Parameters == other.Parameters ||
					this.Parameters != null &&
					this.Parameters.SequenceEqual(other.Parameters)
				) &&
				(
					this.ConditionType == other.ConditionType ||
					this.ConditionType != null &&
					this.ConditionType.Equals(other.ConditionType)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Parameters != null)
					hash = hash * 59 + this.Parameters.GetHashCode();

				if (this.ConditionType != null)
					hash = hash * 59 + this.ConditionType.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
