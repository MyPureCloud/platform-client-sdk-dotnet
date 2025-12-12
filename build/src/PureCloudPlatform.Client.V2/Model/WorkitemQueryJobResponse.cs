using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemQueryJobResponse
	/// </summary>
	[DataContract]
	public partial class WorkitemQueryJobResponse : IEquatable<WorkitemQueryJobResponse>
	{
		/// <summary>
		/// The state of the query job
		/// </summary>
		/// <value>The state of the query job</value>
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
			/// Enum Queued for "Queued"
			/// </summary>
			[EnumMember(Value = "Queued")]
			Queued,

			/// <summary>
			/// Enum Running for "Running"
			/// </summary>
			[EnumMember(Value = "Running")]
			Running,

			/// <summary>
			/// Enum Succeeded for "Succeeded"
			/// </summary>
			[EnumMember(Value = "Succeeded")]
			Succeeded,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed
		}
		/// <summary>
		/// The state of the query job
		/// </summary>
		/// <value>The state of the query job</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemQueryJobResponse" /> class.
		/// </summary>
		/// <param name="State">The state of the query job.</param>
		/// <param name="DateStarted">The date the job was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateFinished">The date the job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Error">The error associated with the query job, if the state is Failed.</param>
		public WorkitemQueryJobResponse(StateEnum? State = null, DateTime? DateStarted = null, DateTime? DateFinished = null, WorkitemQueryJobError Error = null)
		{
			this.State = State;
			this.DateStarted = DateStarted;
			this.DateFinished = DateFinished;
			this.Error = Error;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }





		/// <summary>
		/// The date the job was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the job was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateStarted", EmitDefaultValue = false)]
		public DateTime? DateStarted { get; set; }



		/// <summary>
		/// The date the job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateFinished", EmitDefaultValue = false)]
		public DateTime? DateFinished { get; set; }



		/// <summary>
		/// The error associated with the query job, if the state is Failed
		/// </summary>
		/// <value>The error associated with the query job, if the state is Failed</value>
		[DataMember(Name = "error", EmitDefaultValue = false)]
		public WorkitemQueryJobError Error { get; set; }



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
			sb.Append("class WorkitemQueryJobResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
			sb.Append("  DateFinished: ").Append(DateFinished).Append("\n");
			sb.Append("  Error: ").Append(Error).Append("\n");
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
			return this.Equals(obj as WorkitemQueryJobResponse);
		}

		/// <summary>
		/// Returns true if WorkitemQueryJobResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemQueryJobResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemQueryJobResponse other)
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
					this.DateStarted == other.DateStarted ||
					this.DateStarted != null &&
					this.DateStarted.Equals(other.DateStarted)
				) &&
				(
					this.DateFinished == other.DateFinished ||
					this.DateFinished != null &&
					this.DateFinished.Equals(other.DateFinished)
				) &&
				(
					this.Error == other.Error ||
					this.Error != null &&
					this.Error.Equals(other.Error)
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

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.DateStarted != null)
					hash = hash * 59 + this.DateStarted.GetHashCode();

				if (this.DateFinished != null)
					hash = hash * 59 + this.DateFinished.GetHashCode();

				if (this.Error != null)
					hash = hash * 59 + this.Error.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
