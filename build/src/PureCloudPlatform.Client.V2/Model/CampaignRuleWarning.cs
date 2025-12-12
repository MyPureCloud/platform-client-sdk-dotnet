using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CampaignRuleWarning
	/// </summary>
	[DataContract]
	public partial class CampaignRuleWarning : IEquatable<CampaignRuleWarning>
	{
		/// <summary>
		/// Warning code for this warning.
		/// </summary>
		/// <value>Warning code for this warning.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum CodeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Conditionsnoentities for "ConditionsNoEntities"
			/// </summary>
			[EnumMember(Value = "ConditionsNoEntities")]
			Conditionsnoentities,

			/// <summary>
			/// Enum Conditionsnosequences for "ConditionsNoSequences"
			/// </summary>
			[EnumMember(Value = "ConditionsNoSequences")]
			Conditionsnosequences,

			/// <summary>
			/// Enum Conditionsnocampaigns for "ConditionsNoCampaigns"
			/// </summary>
			[EnumMember(Value = "ConditionsNoCampaigns")]
			Conditionsnocampaigns,

			/// <summary>
			/// Enum Conditionsnomessagingcampaigns for "ConditionsNoMessagingCampaigns"
			/// </summary>
			[EnumMember(Value = "ConditionsNoMessagingCampaigns")]
			Conditionsnomessagingcampaigns,

			/// <summary>
			/// Enum Actionnoentities for "ActionNoEntities"
			/// </summary>
			[EnumMember(Value = "ActionNoEntities")]
			Actionnoentities,

			/// <summary>
			/// Enum Actionnosequences for "ActionNoSequences"
			/// </summary>
			[EnumMember(Value = "ActionNoSequences")]
			Actionnosequences,

			/// <summary>
			/// Enum Actionnocampaigns for "ActionNoCampaigns"
			/// </summary>
			[EnumMember(Value = "ActionNoCampaigns")]
			Actionnocampaigns,

			/// <summary>
			/// Enum Actionnomessagingcampaigns for "ActionNoMessagingCampaigns"
			/// </summary>
			[EnumMember(Value = "ActionNoMessagingCampaigns")]
			Actionnomessagingcampaigns,

			/// <summary>
			/// Enum Noqueue for "NoQueue"
			/// </summary>
			[EnumMember(Value = "NoQueue")]
			Noqueue,

			/// <summary>
			/// Enum Nocontenttemplates for "NoContentTemplates"
			/// </summary>
			[EnumMember(Value = "NoContentTemplates")]
			Nocontenttemplates,

			/// <summary>
			/// Enum Nosmscontenttemplate for "NoSmsContentTemplate"
			/// </summary>
			[EnumMember(Value = "NoSmsContentTemplate")]
			Nosmscontenttemplate,

			/// <summary>
			/// Enum Noemailcontenttemplate for "NoEmailContentTemplate"
			/// </summary>
			[EnumMember(Value = "NoEmailContentTemplate")]
			Noemailcontenttemplate,

			/// <summary>
			/// Enum Conditionswaitingforlinesonlyprevieworexternal for "ConditionsWaitingForLinesOnlyPreviewOrExternal"
			/// </summary>
			[EnumMember(Value = "ConditionsWaitingForLinesOnlyPreviewOrExternal")]
			Conditionswaitingforlinesonlyprevieworexternal,

			/// <summary>
			/// Enum Conditionswaitingforagentsonlyagentless for "ConditionsWaitingForAgentsOnlyAgentless"
			/// </summary>
			[EnumMember(Value = "ConditionsWaitingForAgentsOnlyAgentless")]
			Conditionswaitingforagentsonlyagentless
		}
		/// <summary>
		/// Warning code for this warning.
		/// </summary>
		/// <value>Warning code for this warning.</value>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public CodeEnum? Code { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CampaignRuleWarning" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CampaignRuleWarning() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CampaignRuleWarning" /> class.
		/// </summary>
		/// <param name="Code">Warning code for this warning. (required).</param>
		/// <param name="Message">Warning message for this warning. (required).</param>
		/// <param name="Params">Additional warning information.</param>
		public CampaignRuleWarning(CodeEnum? Code = null, string Message = null, CampaignRuleWarningParameters Params = null)
		{
			this.Code = Code;
			this.Message = Message;
			this.Params = Params;

		}





		/// <summary>
		/// Warning message for this warning.
		/// </summary>
		/// <value>Warning message for this warning.</value>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; }



		/// <summary>
		/// Additional warning information
		/// </summary>
		/// <value>Additional warning information</value>
		[DataMember(Name = "params", EmitDefaultValue = false)]
		public CampaignRuleWarningParameters Params { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CampaignRuleWarning {\n");

			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("  Params: ").Append(Params).Append("\n");
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
			return this.Equals(obj as CampaignRuleWarning);
		}

		/// <summary>
		/// Returns true if CampaignRuleWarning instances are equal
		/// </summary>
		/// <param name="other">Instance of CampaignRuleWarning to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CampaignRuleWarning other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Code == other.Code ||
					this.Code != null &&
					this.Code.Equals(other.Code)
				) &&
				(
					this.Message == other.Message ||
					this.Message != null &&
					this.Message.Equals(other.Message)
				) &&
				(
					this.Params == other.Params ||
					this.Params != null &&
					this.Params.Equals(other.Params)
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
				if (this.Code != null)
					hash = hash * 59 + this.Code.GetHashCode();

				if (this.Message != null)
					hash = hash * 59 + this.Message.GetHashCode();

				if (this.Params != null)
					hash = hash * 59 + this.Params.GetHashCode();

				return hash;
			}
		}
	}

}
