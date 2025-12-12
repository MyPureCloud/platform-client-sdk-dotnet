using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CampaignRuleCondition
	/// </summary>
	[DataContract]
	public partial class CampaignRuleCondition : IEquatable<CampaignRuleCondition>
	{
		/// <summary>
		/// The type of condition to evaluate.
		/// </summary>
		/// <value>The type of condition to evaluate.</value>
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
		/// The type of condition to evaluate.
		/// </summary>
		/// <value>The type of condition to evaluate.</value>
		[DataMember(Name = "conditionType", EmitDefaultValue = false)]
		public ConditionTypeEnum? ConditionType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CampaignRuleCondition" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CampaignRuleCondition() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CampaignRuleCondition" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Parameters">The parameters for the CampaignRuleCondition. (required).</param>
		/// <param name="ConditionType">The type of condition to evaluate. (required).</param>
		public CampaignRuleCondition(string Id = null, CampaignRuleParameters Parameters = null, ConditionTypeEnum? ConditionType = null)
		{
			this.Id = Id;
			this.Parameters = Parameters;
			this.ConditionType = ConditionType;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The parameters for the CampaignRuleCondition.
		/// </summary>
		/// <value>The parameters for the CampaignRuleCondition.</value>
		[DataMember(Name = "parameters", EmitDefaultValue = false)]
		public CampaignRuleParameters Parameters { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CampaignRuleCondition {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
			return this.Equals(obj as CampaignRuleCondition);
		}

		/// <summary>
		/// Returns true if CampaignRuleCondition instances are equal
		/// </summary>
		/// <param name="other">Instance of CampaignRuleCondition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CampaignRuleCondition other)
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
					this.Parameters.Equals(other.Parameters)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Parameters != null)
					hash = hash * 59 + this.Parameters.GetHashCode();

				if (this.ConditionType != null)
					hash = hash * 59 + this.ConditionType.GetHashCode();

				return hash;
			}
		}
	}

}
