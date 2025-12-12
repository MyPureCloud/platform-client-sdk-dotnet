using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OutcomeAttributionJobStateResponse
	/// </summary>
	[DataContract]
	public partial class OutcomeAttributionJobStateResponse : IEquatable<OutcomeAttributionJobStateResponse>
	{
		/// <summary>
		/// State of job.
		/// </summary>
		/// <value>State of job.</value>
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
			/// Enum Running for "Running"
			/// </summary>
			[EnumMember(Value = "Running")]
			Running,

			/// <summary>
			/// Enum Completed for "Completed"
			/// </summary>
			[EnumMember(Value = "Completed")]
			Completed,

			/// <summary>
			/// Enum Completedwitherrors for "CompletedWithErrors"
			/// </summary>
			[EnumMember(Value = "CompletedWithErrors")]
			Completedwitherrors,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed
		}
		/// <summary>
		/// State of job.
		/// </summary>
		/// <value>State of job.</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="OutcomeAttributionJobStateResponse" /> class.
		/// </summary>
		/// <param name="State">State of job..</param>
		/// <param name="ResultsUri">URI where the query results can be retrieved.  Populated when job has reached a terminal state, i.e. no longer Running..</param>
		/// <param name="PercentFailedThreshold">Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100..</param>
		/// <param name="CreatedDate">Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public OutcomeAttributionJobStateResponse(StateEnum? State = null, string ResultsUri = null, int? PercentFailedThreshold = null, DateTime? CreatedDate = null)
		{
			this.State = State;
			this.ResultsUri = ResultsUri;
			this.PercentFailedThreshold = PercentFailedThreshold;
			this.CreatedDate = CreatedDate;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }





		/// <summary>
		/// URI where the query results can be retrieved.  Populated when job has reached a terminal state, i.e. no longer Running.
		/// </summary>
		/// <value>URI where the query results can be retrieved.  Populated when job has reached a terminal state, i.e. no longer Running.</value>
		[DataMember(Name = "resultsUri", EmitDefaultValue = false)]
		public string ResultsUri { get; set; }



		/// <summary>
		/// Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.
		/// </summary>
		/// <value>Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.</value>
		[DataMember(Name = "percentFailedThreshold", EmitDefaultValue = false)]
		public int? PercentFailedThreshold { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }



		/// <summary>
		/// Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTime? CreatedDate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutcomeAttributionJobStateResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  ResultsUri: ").Append(ResultsUri).Append("\n");
			sb.Append("  PercentFailedThreshold: ").Append(PercentFailedThreshold).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
			return this.Equals(obj as OutcomeAttributionJobStateResponse);
		}

		/// <summary>
		/// Returns true if OutcomeAttributionJobStateResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of OutcomeAttributionJobStateResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutcomeAttributionJobStateResponse other)
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
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.ResultsUri == other.ResultsUri ||
					this.ResultsUri != null &&
					this.ResultsUri.Equals(other.ResultsUri)
				) &&
				(
					this.PercentFailedThreshold == other.PercentFailedThreshold ||
					this.PercentFailedThreshold != null &&
					this.PercentFailedThreshold.Equals(other.PercentFailedThreshold)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
				) &&
				(
					this.CreatedDate == other.CreatedDate ||
					this.CreatedDate != null &&
					this.CreatedDate.Equals(other.CreatedDate)
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

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.ResultsUri != null)
					hash = hash * 59 + this.ResultsUri.GetHashCode();

				if (this.PercentFailedThreshold != null)
					hash = hash * 59 + this.PercentFailedThreshold.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				if (this.CreatedDate != null)
					hash = hash * 59 + this.CreatedDate.GetHashCode();

				return hash;
			}
		}
	}

}
