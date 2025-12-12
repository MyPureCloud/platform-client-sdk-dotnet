using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PerformancePredictionResponse
	/// </summary>
	[DataContract]
	public partial class PerformancePredictionResponse : IEquatable<PerformancePredictionResponse>
	{
		/// <summary>
		/// The state of the performance prediction
		/// </summary>
		/// <value>The state of the performance prediction</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Processing for "Processing"
			/// </summary>
			[EnumMember(Value = "Processing")]
			Processing,

			/// <summary>
			/// Enum Complete for "Complete"
			/// </summary>
			[EnumMember(Value = "Complete")]
			Complete,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// The state of the performance prediction
		/// </summary>
		/// <value>The state of the performance prediction</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PerformancePredictionResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected PerformancePredictionResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="PerformancePredictionResponse" /> class.
		/// </summary>
		/// <param name="WeekDate">The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="ScheduleId">The ID of the schedule this performance prediction is associated with (required).</param>
		/// <param name="DownloadUrl">The url to GET the results of the performance prediction. This field is populated only if query state is &#39;Complete&#39;.</param>
		/// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
		/// <param name="State">The state of the performance prediction (required).</param>
		public PerformancePredictionResponse(String WeekDate = null, string ScheduleId = null, string DownloadUrl = null, PerformancePredictionOutputs DownloadResult = null, StateEnum? State = null)
		{
			this.WeekDate = WeekDate;
			this.ScheduleId = ScheduleId;
			this.DownloadUrl = DownloadUrl;
			this.DownloadResult = DownloadResult;
			this.State = State;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "weekDate", EmitDefaultValue = false)]
		public String WeekDate { get; set; }



		/// <summary>
		/// The ID of the schedule this performance prediction is associated with
		/// </summary>
		/// <value>The ID of the schedule this performance prediction is associated with</value>
		[DataMember(Name = "scheduleId", EmitDefaultValue = false)]
		public string ScheduleId { get; set; }



		/// <summary>
		/// The url to GET the results of the performance prediction. This field is populated only if query state is &#39;Complete&#39;
		/// </summary>
		/// <value>The url to GET the results of the performance prediction. This field is populated only if query state is &#39;Complete&#39;</value>
		[DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
		public string DownloadUrl { get; set; }



		/// <summary>
		/// Result will always come via downloadUrls; however the schema is included for documentation
		/// </summary>
		/// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
		[DataMember(Name = "downloadResult", EmitDefaultValue = false)]
		public PerformancePredictionOutputs DownloadResult { get; set; }





		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PerformancePredictionResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
			sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
			sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
			sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as PerformancePredictionResponse);
		}

		/// <summary>
		/// Returns true if PerformancePredictionResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of PerformancePredictionResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PerformancePredictionResponse other)
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
					this.WeekDate == other.WeekDate ||
					this.WeekDate != null &&
					this.WeekDate.Equals(other.WeekDate)
				) &&
				(
					this.ScheduleId == other.ScheduleId ||
					this.ScheduleId != null &&
					this.ScheduleId.Equals(other.ScheduleId)
				) &&
				(
					this.DownloadUrl == other.DownloadUrl ||
					this.DownloadUrl != null &&
					this.DownloadUrl.Equals(other.DownloadUrl)
				) &&
				(
					this.DownloadResult == other.DownloadResult ||
					this.DownloadResult != null &&
					this.DownloadResult.Equals(other.DownloadResult)
				) &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.WeekDate != null)
					hash = hash * 59 + this.WeekDate.GetHashCode();

				if (this.ScheduleId != null)
					hash = hash * 59 + this.ScheduleId.GetHashCode();

				if (this.DownloadUrl != null)
					hash = hash * 59 + this.DownloadUrl.GetHashCode();

				if (this.DownloadResult != null)
					hash = hash * 59 + this.DownloadResult.GetHashCode();

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
