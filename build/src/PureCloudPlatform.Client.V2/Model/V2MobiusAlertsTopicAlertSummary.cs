using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2MobiusAlertsTopicAlertSummary
	/// </summary>
	[DataContract]
	public partial class V2MobiusAlertsTopicAlertSummary : IEquatable<V2MobiusAlertsTopicAlertSummary>
	{
		/// <summary>
		/// Gets or Sets MetricType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MetricTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Interval for "Interval"
			/// </summary>
			[EnumMember(Value = "Interval")]
			Interval,

			/// <summary>
			/// Enum Instance for "Instance"
			/// </summary>
			[EnumMember(Value = "Instance")]
			Instance,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// Gets or Sets MetricType
		/// </summary>
		[DataMember(Name = "metricType", EmitDefaultValue = false)]
		public MetricTypeEnum? MetricType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="V2MobiusAlertsTopicAlertSummary" /> class.
		/// </summary>
		/// <param name="Entities">Entities.</param>
		/// <param name="Conversation">Conversation.</param>
		/// <param name="MetricType">MetricType.</param>
		/// <param name="IsTeamMemberRuleSummary">IsTeamMemberRuleSummary.</param>
		/// <param name="TeamMemberRuleSummary">TeamMemberRuleSummary.</param>
		public V2MobiusAlertsTopicAlertSummary(List<V2MobiusAlertsTopicAlertSummaryEntity> Entities = null, V2MobiusAlertsTopicAddressableEntityRef Conversation = null, MetricTypeEnum? MetricType = null, bool? IsTeamMemberRuleSummary = null, bool? TeamMemberRuleSummary = null)
		{
			this.Entities = Entities;
			this.Conversation = Conversation;
			this.MetricType = MetricType;
			this.IsTeamMemberRuleSummary = IsTeamMemberRuleSummary;
			this.TeamMemberRuleSummary = TeamMemberRuleSummary;

		}



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<V2MobiusAlertsTopicAlertSummaryEntity> Entities { get; set; }



		/// <summary>
		/// Gets or Sets Conversation
		/// </summary>
		[DataMember(Name = "conversation", EmitDefaultValue = false)]
		public V2MobiusAlertsTopicAddressableEntityRef Conversation { get; set; }





		/// <summary>
		/// Gets or Sets IsTeamMemberRuleSummary
		/// </summary>
		[DataMember(Name = "isTeamMemberRuleSummary", EmitDefaultValue = false)]
		public bool? IsTeamMemberRuleSummary { get; set; }



		/// <summary>
		/// Gets or Sets TeamMemberRuleSummary
		/// </summary>
		[DataMember(Name = "teamMemberRuleSummary", EmitDefaultValue = false)]
		public bool? TeamMemberRuleSummary { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2MobiusAlertsTopicAlertSummary {\n");

			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  Conversation: ").Append(Conversation).Append("\n");
			sb.Append("  MetricType: ").Append(MetricType).Append("\n");
			sb.Append("  IsTeamMemberRuleSummary: ").Append(IsTeamMemberRuleSummary).Append("\n");
			sb.Append("  TeamMemberRuleSummary: ").Append(TeamMemberRuleSummary).Append("\n");
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
			return this.Equals(obj as V2MobiusAlertsTopicAlertSummary);
		}

		/// <summary>
		/// Returns true if V2MobiusAlertsTopicAlertSummary instances are equal
		/// </summary>
		/// <param name="other">Instance of V2MobiusAlertsTopicAlertSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2MobiusAlertsTopicAlertSummary other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
				) &&
				(
					this.Conversation == other.Conversation ||
					this.Conversation != null &&
					this.Conversation.Equals(other.Conversation)
				) &&
				(
					this.MetricType == other.MetricType ||
					this.MetricType != null &&
					this.MetricType.Equals(other.MetricType)
				) &&
				(
					this.IsTeamMemberRuleSummary == other.IsTeamMemberRuleSummary ||
					this.IsTeamMemberRuleSummary != null &&
					this.IsTeamMemberRuleSummary.Equals(other.IsTeamMemberRuleSummary)
				) &&
				(
					this.TeamMemberRuleSummary == other.TeamMemberRuleSummary ||
					this.TeamMemberRuleSummary != null &&
					this.TeamMemberRuleSummary.Equals(other.TeamMemberRuleSummary)
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
				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.Conversation != null)
					hash = hash * 59 + this.Conversation.GetHashCode();

				if (this.MetricType != null)
					hash = hash * 59 + this.MetricType.GetHashCode();

				if (this.IsTeamMemberRuleSummary != null)
					hash = hash * 59 + this.IsTeamMemberRuleSummary.GetHashCode();

				if (this.TeamMemberRuleSummary != null)
					hash = hash * 59 + this.TeamMemberRuleSummary.GetHashCode();

				return hash;
			}
		}
	}

}
