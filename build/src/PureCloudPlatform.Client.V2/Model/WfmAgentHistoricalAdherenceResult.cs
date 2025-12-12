using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmAgentHistoricalAdherenceResult
	/// </summary>
	[DataContract]
	public partial class WfmAgentHistoricalAdherenceResult : IEquatable<WfmAgentHistoricalAdherenceResult>
	{
		/// <summary>
		/// The impact of the current adherence state for this user
		/// </summary>
		/// <value>The impact of the current adherence state for this user</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ImpactEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Positive for "Positive"
			/// </summary>
			[EnumMember(Value = "Positive")]
			Positive,

			/// <summary>
			/// Enum Negative for "Negative"
			/// </summary>
			[EnumMember(Value = "Negative")]
			Negative,

			/// <summary>
			/// Enum Neutral for "Neutral"
			/// </summary>
			[EnumMember(Value = "Neutral")]
			Neutral,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// The impact of the current adherence state for this user
		/// </summary>
		/// <value>The impact of the current adherence state for this user</value>
		[DataMember(Name = "impact", EmitDefaultValue = false)]
		public ImpactEnum? Impact { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="WfmAgentHistoricalAdherenceResult" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WfmAgentHistoricalAdherenceResult() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmAgentHistoricalAdherenceResult" /> class.
		/// </summary>
		/// <param name="User">The user who submitted the agent historical adherence query.</param>
		/// <param name="StartDate">Beginning of the date range that was queried, in ISO-8601 format (required).</param>
		/// <param name="EndDate">End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time (required).</param>
		/// <param name="CalculationsCompletedDate">Completed date of calculations that was queried, in ISO-8601 format. (required).</param>
		/// <param name="TargetAdherencePercentage">Target percentage for this user, in the scale of 0 - 100 (required).</param>
		/// <param name="AdherencePercentage">Adherence percentage for this user, in the scale of 0 - 100.</param>
		/// <param name="ConformancePercentage">Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period..</param>
		/// <param name="Impact">The impact of the current adherence state for this user (required).</param>
		/// <param name="ExceptionInfo">List of adherence exceptions for this user.</param>
		/// <param name="DayMetrics">Adherence and conformance metrics for days in query range (required).</param>
		/// <param name="Actuals">List of actual activity with offset for this user.</param>
		/// <param name="ScheduledActivities">List of scheduled activities for this user.</param>
		/// <param name="SecondaryPresenceLookupItems">List of secondary presence lookup ID to corresponding secondary presence ID item (required).</param>
		public WfmAgentHistoricalAdherenceResult(UserReference User = null, DateTime? StartDate = null, DateTime? EndDate = null, DateTime? CalculationsCompletedDate = null, double? TargetAdherencePercentage = null, double? AdherencePercentage = null, double? ConformancePercentage = null, ImpactEnum? Impact = null, List<HistoricalAdherenceExceptionInfo> ExceptionInfo = null, List<AgentAdherenceDayMetrics> DayMetrics = null, List<HistoricalAdherenceActuals> Actuals = null, List<AgentAdherenceScheduledActivity> ScheduledActivities = null, List<SecondaryPresenceLookupItem> SecondaryPresenceLookupItems = null)
		{
			this.User = User;
			this.StartDate = StartDate;
			this.EndDate = EndDate;
			this.CalculationsCompletedDate = CalculationsCompletedDate;
			this.TargetAdherencePercentage = TargetAdherencePercentage;
			this.AdherencePercentage = AdherencePercentage;
			this.ConformancePercentage = ConformancePercentage;
			this.Impact = Impact;
			this.ExceptionInfo = ExceptionInfo;
			this.DayMetrics = DayMetrics;
			this.Actuals = Actuals;
			this.ScheduledActivities = ScheduledActivities;
			this.SecondaryPresenceLookupItems = SecondaryPresenceLookupItems;

		}



		/// <summary>
		/// The user who submitted the agent historical adherence query
		/// </summary>
		/// <value>The user who submitted the agent historical adherence query</value>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public UserReference User { get; set; }



		/// <summary>
		/// Beginning of the date range that was queried, in ISO-8601 format
		/// </summary>
		/// <value>Beginning of the date range that was queried, in ISO-8601 format</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }



		/// <summary>
		/// End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time
		/// </summary>
		/// <value>End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time</value>
		[DataMember(Name = "endDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }



		/// <summary>
		/// Completed date of calculations that was queried, in ISO-8601 format.
		/// </summary>
		/// <value>Completed date of calculations that was queried, in ISO-8601 format.</value>
		[DataMember(Name = "calculationsCompletedDate", EmitDefaultValue = false)]
		public DateTime? CalculationsCompletedDate { get; set; }



		/// <summary>
		/// Target percentage for this user, in the scale of 0 - 100
		/// </summary>
		/// <value>Target percentage for this user, in the scale of 0 - 100</value>
		[DataMember(Name = "targetAdherencePercentage", EmitDefaultValue = false)]
		public double? TargetAdherencePercentage { get; set; }



		/// <summary>
		/// Adherence percentage for this user, in the scale of 0 - 100
		/// </summary>
		/// <value>Adherence percentage for this user, in the scale of 0 - 100</value>
		[DataMember(Name = "adherencePercentage", EmitDefaultValue = false)]
		public double? AdherencePercentage { get; set; }



		/// <summary>
		/// Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.
		/// </summary>
		/// <value>Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.</value>
		[DataMember(Name = "conformancePercentage", EmitDefaultValue = false)]
		public double? ConformancePercentage { get; set; }





		/// <summary>
		/// List of adherence exceptions for this user
		/// </summary>
		/// <value>List of adherence exceptions for this user</value>
		[DataMember(Name = "exceptionInfo", EmitDefaultValue = false)]
		public List<HistoricalAdherenceExceptionInfo> ExceptionInfo { get; set; }



		/// <summary>
		/// Adherence and conformance metrics for days in query range
		/// </summary>
		/// <value>Adherence and conformance metrics for days in query range</value>
		[DataMember(Name = "dayMetrics", EmitDefaultValue = false)]
		public List<AgentAdherenceDayMetrics> DayMetrics { get; set; }



		/// <summary>
		/// List of actual activity with offset for this user
		/// </summary>
		/// <value>List of actual activity with offset for this user</value>
		[DataMember(Name = "actuals", EmitDefaultValue = false)]
		public List<HistoricalAdherenceActuals> Actuals { get; set; }



		/// <summary>
		/// List of scheduled activities for this user
		/// </summary>
		/// <value>List of scheduled activities for this user</value>
		[DataMember(Name = "scheduledActivities", EmitDefaultValue = false)]
		public List<AgentAdherenceScheduledActivity> ScheduledActivities { get; set; }



		/// <summary>
		/// List of secondary presence lookup ID to corresponding secondary presence ID item
		/// </summary>
		/// <value>List of secondary presence lookup ID to corresponding secondary presence ID item</value>
		[DataMember(Name = "secondaryPresenceLookupItems", EmitDefaultValue = false)]
		public List<SecondaryPresenceLookupItem> SecondaryPresenceLookupItems { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmAgentHistoricalAdherenceResult {\n");

			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  EndDate: ").Append(EndDate).Append("\n");
			sb.Append("  CalculationsCompletedDate: ").Append(CalculationsCompletedDate).Append("\n");
			sb.Append("  TargetAdherencePercentage: ").Append(TargetAdherencePercentage).Append("\n");
			sb.Append("  AdherencePercentage: ").Append(AdherencePercentage).Append("\n");
			sb.Append("  ConformancePercentage: ").Append(ConformancePercentage).Append("\n");
			sb.Append("  Impact: ").Append(Impact).Append("\n");
			sb.Append("  ExceptionInfo: ").Append(ExceptionInfo).Append("\n");
			sb.Append("  DayMetrics: ").Append(DayMetrics).Append("\n");
			sb.Append("  Actuals: ").Append(Actuals).Append("\n");
			sb.Append("  ScheduledActivities: ").Append(ScheduledActivities).Append("\n");
			sb.Append("  SecondaryPresenceLookupItems: ").Append(SecondaryPresenceLookupItems).Append("\n");
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
			return this.Equals(obj as WfmAgentHistoricalAdherenceResult);
		}

		/// <summary>
		/// Returns true if WfmAgentHistoricalAdherenceResult instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmAgentHistoricalAdherenceResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmAgentHistoricalAdherenceResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
				) &&
				(
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
				) &&
				(
					this.EndDate == other.EndDate ||
					this.EndDate != null &&
					this.EndDate.Equals(other.EndDate)
				) &&
				(
					this.CalculationsCompletedDate == other.CalculationsCompletedDate ||
					this.CalculationsCompletedDate != null &&
					this.CalculationsCompletedDate.Equals(other.CalculationsCompletedDate)
				) &&
				(
					this.TargetAdherencePercentage == other.TargetAdherencePercentage ||
					this.TargetAdherencePercentage != null &&
					this.TargetAdherencePercentage.Equals(other.TargetAdherencePercentage)
				) &&
				(
					this.AdherencePercentage == other.AdherencePercentage ||
					this.AdherencePercentage != null &&
					this.AdherencePercentage.Equals(other.AdherencePercentage)
				) &&
				(
					this.ConformancePercentage == other.ConformancePercentage ||
					this.ConformancePercentage != null &&
					this.ConformancePercentage.Equals(other.ConformancePercentage)
				) &&
				(
					this.Impact == other.Impact ||
					this.Impact != null &&
					this.Impact.Equals(other.Impact)
				) &&
				(
					this.ExceptionInfo == other.ExceptionInfo ||
					this.ExceptionInfo != null &&
					this.ExceptionInfo.SequenceEqual(other.ExceptionInfo)
				) &&
				(
					this.DayMetrics == other.DayMetrics ||
					this.DayMetrics != null &&
					this.DayMetrics.SequenceEqual(other.DayMetrics)
				) &&
				(
					this.Actuals == other.Actuals ||
					this.Actuals != null &&
					this.Actuals.SequenceEqual(other.Actuals)
				) &&
				(
					this.ScheduledActivities == other.ScheduledActivities ||
					this.ScheduledActivities != null &&
					this.ScheduledActivities.SequenceEqual(other.ScheduledActivities)
				) &&
				(
					this.SecondaryPresenceLookupItems == other.SecondaryPresenceLookupItems ||
					this.SecondaryPresenceLookupItems != null &&
					this.SecondaryPresenceLookupItems.SequenceEqual(other.SecondaryPresenceLookupItems)
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
				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.EndDate != null)
					hash = hash * 59 + this.EndDate.GetHashCode();

				if (this.CalculationsCompletedDate != null)
					hash = hash * 59 + this.CalculationsCompletedDate.GetHashCode();

				if (this.TargetAdherencePercentage != null)
					hash = hash * 59 + this.TargetAdherencePercentage.GetHashCode();

				if (this.AdherencePercentage != null)
					hash = hash * 59 + this.AdherencePercentage.GetHashCode();

				if (this.ConformancePercentage != null)
					hash = hash * 59 + this.ConformancePercentage.GetHashCode();

				if (this.Impact != null)
					hash = hash * 59 + this.Impact.GetHashCode();

				if (this.ExceptionInfo != null)
					hash = hash * 59 + this.ExceptionInfo.GetHashCode();

				if (this.DayMetrics != null)
					hash = hash * 59 + this.DayMetrics.GetHashCode();

				if (this.Actuals != null)
					hash = hash * 59 + this.Actuals.GetHashCode();

				if (this.ScheduledActivities != null)
					hash = hash * 59 + this.ScheduledActivities.GetHashCode();

				if (this.SecondaryPresenceLookupItems != null)
					hash = hash * 59 + this.SecondaryPresenceLookupItems.GetHashCode();

				return hash;
			}
		}
	}

}
