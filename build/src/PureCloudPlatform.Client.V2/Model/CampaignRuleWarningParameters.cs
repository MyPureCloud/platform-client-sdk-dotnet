using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CampaignRuleWarningParameters
	/// </summary>
	[DataContract]
	public partial class CampaignRuleWarningParameters : IEquatable<CampaignRuleWarningParameters>
	{
		/// <summary>
		/// Type of action
		/// </summary>
		/// <value>Type of action</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActionTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Turnoncampaign for "turnOnCampaign"
			/// </summary>
			[EnumMember(Value = "turnOnCampaign")]
			Turnoncampaign,

			/// <summary>
			/// Enum Turnoffcampaign for "turnOffCampaign"
			/// </summary>
			[EnumMember(Value = "turnOffCampaign")]
			Turnoffcampaign,

			/// <summary>
			/// Enum Turnonsequence for "turnOnSequence"
			/// </summary>
			[EnumMember(Value = "turnOnSequence")]
			Turnonsequence,

			/// <summary>
			/// Enum Turnoffsequence for "turnOffSequence"
			/// </summary>
			[EnumMember(Value = "turnOffSequence")]
			Turnoffsequence,

			/// <summary>
			/// Enum Setcampaignpriority for "setCampaignPriority"
			/// </summary>
			[EnumMember(Value = "setCampaignPriority")]
			Setcampaignpriority,

			/// <summary>
			/// Enum Recyclecampaign for "recycleCampaign"
			/// </summary>
			[EnumMember(Value = "recycleCampaign")]
			Recyclecampaign,

			/// <summary>
			/// Enum Setcampaigndialingmode for "setCampaignDialingMode"
			/// </summary>
			[EnumMember(Value = "setCampaignDialingMode")]
			Setcampaigndialingmode,

			/// <summary>
			/// Enum Setcampaignabandonrate for "setCampaignAbandonRate"
			/// </summary>
			[EnumMember(Value = "setCampaignAbandonRate")]
			Setcampaignabandonrate,

			/// <summary>
			/// Enum Setcampaignnumberoflines for "setCampaignNumberOfLines"
			/// </summary>
			[EnumMember(Value = "setCampaignNumberOfLines")]
			Setcampaignnumberoflines,

			/// <summary>
			/// Enum Setcampaignweight for "setCampaignWeight"
			/// </summary>
			[EnumMember(Value = "setCampaignWeight")]
			Setcampaignweight,

			/// <summary>
			/// Enum Setcampaignmaxcallsperagent for "setCampaignMaxCallsPerAgent"
			/// </summary>
			[EnumMember(Value = "setCampaignMaxCallsPerAgent")]
			Setcampaignmaxcallsperagent,

			/// <summary>
			/// Enum Setcampaignmessagesperminute for "setCampaignMessagesPerMinute"
			/// </summary>
			[EnumMember(Value = "setCampaignMessagesPerMinute")]
			Setcampaignmessagesperminute,

			/// <summary>
			/// Enum Changecampaignqueue for "changeCampaignQueue"
			/// </summary>
			[EnumMember(Value = "changeCampaignQueue")]
			Changecampaignqueue,

			/// <summary>
			/// Enum Changecampaigntemplate for "changeCampaignTemplate"
			/// </summary>
			[EnumMember(Value = "changeCampaignTemplate")]
			Changecampaigntemplate
		}
		/// <summary>
		/// Type of condition
		/// </summary>
		/// <value>Type of condition</value>
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
			Campaignagents,

			/// <summary>
			/// Enum Campaignrecordsattempted for "campaignRecordsAttempted"
			/// </summary>
			[EnumMember(Value = "campaignRecordsAttempted")]
			Campaignrecordsattempted,

			/// <summary>
			/// Enum Campaigncontactsmessaged for "campaignContactsMessaged"
			/// </summary>
			[EnumMember(Value = "campaignContactsMessaged")]
			Campaigncontactsmessaged,

			/// <summary>
			/// Enum Campaignbusinesssuccess for "campaignBusinessSuccess"
			/// </summary>
			[EnumMember(Value = "campaignBusinessSuccess")]
			Campaignbusinesssuccess,

			/// <summary>
			/// Enum Campaignbusinessfailure for "campaignBusinessFailure"
			/// </summary>
			[EnumMember(Value = "campaignBusinessFailure")]
			Campaignbusinessfailure,

			/// <summary>
			/// Enum Campaignbusinessneutral for "campaignBusinessNeutral"
			/// </summary>
			[EnumMember(Value = "campaignBusinessNeutral")]
			Campaignbusinessneutral,

			/// <summary>
			/// Enum Campaignvalidattempts for "campaignValidAttempts"
			/// </summary>
			[EnumMember(Value = "campaignValidAttempts")]
			Campaignvalidattempts,

			/// <summary>
			/// Enum Campaignrightpartycontacts for "campaignRightPartyContacts"
			/// </summary>
			[EnumMember(Value = "campaignRightPartyContacts")]
			Campaignrightpartycontacts,

			/// <summary>
			/// Enum Timeofday for "timeOfDay"
			/// </summary>
			[EnumMember(Value = "timeOfDay")]
			Timeofday,

			/// <summary>
			/// Enum Dayofweek for "dayOfWeek"
			/// </summary>
			[EnumMember(Value = "dayOfWeek")]
			Dayofweek,

			/// <summary>
			/// Enum Dayofmonth for "dayOfMonth"
			/// </summary>
			[EnumMember(Value = "dayOfMonth")]
			Dayofmonth,

			/// <summary>
			/// Enum Weekdayofmonth for "weekDayOfMonth"
			/// </summary>
			[EnumMember(Value = "weekDayOfMonth")]
			Weekdayofmonth,

			/// <summary>
			/// Enum Specificdate for "specificDate"
			/// </summary>
			[EnumMember(Value = "specificDate")]
			Specificdate,

			/// <summary>
			/// Enum Campaignruntime for "campaignRunTime"
			/// </summary>
			[EnumMember(Value = "campaignRunTime")]
			Campaignruntime,

			/// <summary>
			/// Enum Campaignwaittime for "campaignWaitTime"
			/// </summary>
			[EnumMember(Value = "campaignWaitTime")]
			Campaignwaittime
		}
		/// <summary>
		/// Type of action
		/// </summary>
		/// <value>Type of action</value>
		[DataMember(Name = "actionType", EmitDefaultValue = false)]
		public ActionTypeEnum? ActionType { get; set; }
		/// <summary>
		/// Type of condition
		/// </summary>
		/// <value>Type of condition</value>
		[DataMember(Name = "conditionType", EmitDefaultValue = false)]
		public ConditionTypeEnum? ConditionType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CampaignRuleWarningParameters" /> class.
		/// </summary>
		/// <param name="ActionId">ID of action.</param>
		/// <param name="ConditionId">ID of condition.</param>
		/// <param name="ActionType">Type of action.</param>
		/// <param name="ConditionType">Type of condition.</param>
		public CampaignRuleWarningParameters(string ActionId = null, string ConditionId = null, ActionTypeEnum? ActionType = null, ConditionTypeEnum? ConditionType = null)
		{
			this.ActionId = ActionId;
			this.ConditionId = ConditionId;
			this.ActionType = ActionType;
			this.ConditionType = ConditionType;

		}



		/// <summary>
		/// ID of action
		/// </summary>
		/// <value>ID of action</value>
		[DataMember(Name = "actionId", EmitDefaultValue = false)]
		public string ActionId { get; set; }



		/// <summary>
		/// ID of condition
		/// </summary>
		/// <value>ID of condition</value>
		[DataMember(Name = "conditionId", EmitDefaultValue = false)]
		public string ConditionId { get; set; }






		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CampaignRuleWarningParameters {\n");

			sb.Append("  ActionId: ").Append(ActionId).Append("\n");
			sb.Append("  ConditionId: ").Append(ConditionId).Append("\n");
			sb.Append("  ActionType: ").Append(ActionType).Append("\n");
			sb.Append("  ConditionType: ").Append(ConditionType).Append("\n");
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
			return this.Equals(obj as CampaignRuleWarningParameters);
		}

		/// <summary>
		/// Returns true if CampaignRuleWarningParameters instances are equal
		/// </summary>
		/// <param name="other">Instance of CampaignRuleWarningParameters to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CampaignRuleWarningParameters other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ActionId == other.ActionId ||
					this.ActionId != null &&
					this.ActionId.Equals(other.ActionId)
				) &&
				(
					this.ConditionId == other.ConditionId ||
					this.ConditionId != null &&
					this.ConditionId.Equals(other.ConditionId)
				) &&
				(
					this.ActionType == other.ActionType ||
					this.ActionType != null &&
					this.ActionType.Equals(other.ActionType)
				) &&
				(
					this.ConditionType == other.ConditionType ||
					this.ConditionType != null &&
					this.ConditionType.Equals(other.ConditionType)
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
				if (this.ActionId != null)
					hash = hash * 59 + this.ActionId.GetHashCode();

				if (this.ConditionId != null)
					hash = hash * 59 + this.ConditionId.GetHashCode();

				if (this.ActionType != null)
					hash = hash * 59 + this.ActionType.GetHashCode();

				if (this.ConditionType != null)
					hash = hash * 59 + this.ConditionType.GetHashCode();

				return hash;
			}
		}
	}

}
