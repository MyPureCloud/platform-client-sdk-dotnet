using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TimeOffSettingsResponse
	/// </summary>
	[DataContract]
	public partial class TimeOffSettingsResponse : IEquatable<TimeOffSettingsResponse>
	{
		/// <summary>
		/// The type of the submission range
		/// </summary>
		/// <value>The type of the submission range</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SubmissionRangeTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Relative for "Relative"
			/// </summary>
			[EnumMember(Value = "Relative")]
			Relative,

			/// <summary>
			/// Enum Fixedend for "FixedEnd"
			/// </summary>
			[EnumMember(Value = "FixedEnd")]
			Fixedend
		}
		/// <summary>
		/// The type of the submission range
		/// </summary>
		/// <value>The type of the submission range</value>
		[DataMember(Name = "submissionRangeType", EmitDefaultValue = false)]
		public SubmissionRangeTypeEnum? SubmissionRangeType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="TimeOffSettingsResponse" /> class.
		/// </summary>
		/// <param name="SubmissionRangeEnforced">Whether to enforce a submission range for agent time off requests.</param>
		/// <param name="SubmissionRangeType">The type of the submission range.</param>
		/// <param name="SubmissionEarliestDaysFromNow">The earliest number of days from now for which an agent can submit a time off request.  Use negative numbers to indicate days in the past.</param>
		/// <param name="SubmissionLatestDaysFromNow">The latest number of days from now for which an agent can submit a time off request.</param>
		/// <param name="SubmissionLatestDate">The latest date for the time off request submission interpreted in the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		public TimeOffSettingsResponse(bool? SubmissionRangeEnforced = null, SubmissionRangeTypeEnum? SubmissionRangeType = null, int? SubmissionEarliestDaysFromNow = null, int? SubmissionLatestDaysFromNow = null, String SubmissionLatestDate = null)
		{
			this.SubmissionRangeEnforced = SubmissionRangeEnforced;
			this.SubmissionRangeType = SubmissionRangeType;
			this.SubmissionEarliestDaysFromNow = SubmissionEarliestDaysFromNow;
			this.SubmissionLatestDaysFromNow = SubmissionLatestDaysFromNow;
			this.SubmissionLatestDate = SubmissionLatestDate;

		}



		/// <summary>
		/// Whether to enforce a submission range for agent time off requests
		/// </summary>
		/// <value>Whether to enforce a submission range for agent time off requests</value>
		[DataMember(Name = "submissionRangeEnforced", EmitDefaultValue = false)]
		public bool? SubmissionRangeEnforced { get; set; }





		/// <summary>
		/// The earliest number of days from now for which an agent can submit a time off request.  Use negative numbers to indicate days in the past
		/// </summary>
		/// <value>The earliest number of days from now for which an agent can submit a time off request.  Use negative numbers to indicate days in the past</value>
		[DataMember(Name = "submissionEarliestDaysFromNow", EmitDefaultValue = false)]
		public int? SubmissionEarliestDaysFromNow { get; set; }



		/// <summary>
		/// The latest number of days from now for which an agent can submit a time off request
		/// </summary>
		/// <value>The latest number of days from now for which an agent can submit a time off request</value>
		[DataMember(Name = "submissionLatestDaysFromNow", EmitDefaultValue = false)]
		public int? SubmissionLatestDaysFromNow { get; set; }



		/// <summary>
		/// The latest date for the time off request submission interpreted in the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The latest date for the time off request submission interpreted in the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "submissionLatestDate", EmitDefaultValue = false)]
		public String SubmissionLatestDate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TimeOffSettingsResponse {\n");

			sb.Append("  SubmissionRangeEnforced: ").Append(SubmissionRangeEnforced).Append("\n");
			sb.Append("  SubmissionRangeType: ").Append(SubmissionRangeType).Append("\n");
			sb.Append("  SubmissionEarliestDaysFromNow: ").Append(SubmissionEarliestDaysFromNow).Append("\n");
			sb.Append("  SubmissionLatestDaysFromNow: ").Append(SubmissionLatestDaysFromNow).Append("\n");
			sb.Append("  SubmissionLatestDate: ").Append(SubmissionLatestDate).Append("\n");
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
			return this.Equals(obj as TimeOffSettingsResponse);
		}

		/// <summary>
		/// Returns true if TimeOffSettingsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of TimeOffSettingsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TimeOffSettingsResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SubmissionRangeEnforced == other.SubmissionRangeEnforced ||
					this.SubmissionRangeEnforced != null &&
					this.SubmissionRangeEnforced.Equals(other.SubmissionRangeEnforced)
				) &&
				(
					this.SubmissionRangeType == other.SubmissionRangeType ||
					this.SubmissionRangeType != null &&
					this.SubmissionRangeType.Equals(other.SubmissionRangeType)
				) &&
				(
					this.SubmissionEarliestDaysFromNow == other.SubmissionEarliestDaysFromNow ||
					this.SubmissionEarliestDaysFromNow != null &&
					this.SubmissionEarliestDaysFromNow.Equals(other.SubmissionEarliestDaysFromNow)
				) &&
				(
					this.SubmissionLatestDaysFromNow == other.SubmissionLatestDaysFromNow ||
					this.SubmissionLatestDaysFromNow != null &&
					this.SubmissionLatestDaysFromNow.Equals(other.SubmissionLatestDaysFromNow)
				) &&
				(
					this.SubmissionLatestDate == other.SubmissionLatestDate ||
					this.SubmissionLatestDate != null &&
					this.SubmissionLatestDate.Equals(other.SubmissionLatestDate)
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
				if (this.SubmissionRangeEnforced != null)
					hash = hash * 59 + this.SubmissionRangeEnforced.GetHashCode();

				if (this.SubmissionRangeType != null)
					hash = hash * 59 + this.SubmissionRangeType.GetHashCode();

				if (this.SubmissionEarliestDaysFromNow != null)
					hash = hash * 59 + this.SubmissionEarliestDaysFromNow.GetHashCode();

				if (this.SubmissionLatestDaysFromNow != null)
					hash = hash * 59 + this.SubmissionLatestDaysFromNow.GetHashCode();

				if (this.SubmissionLatestDate != null)
					hash = hash * 59 + this.SubmissionLatestDate.GetHashCode();

				return hash;
			}
		}
	}

}
