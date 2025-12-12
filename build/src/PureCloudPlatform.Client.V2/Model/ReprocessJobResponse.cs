using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ReprocessJobResponse
	/// </summary>
	[DataContract]
	public partial class ReprocessJobResponse : IEquatable<ReprocessJobResponse>
	{
		/// <summary>
		/// Gets or Sets MediaTypes
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MediaTypesEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Call for "Call"
			/// </summary>
			[EnumMember(Value = "Call")]
			Call,

			/// <summary>
			/// Enum Callback for "Callback"
			/// </summary>
			[EnumMember(Value = "Callback")]
			Callback,

			/// <summary>
			/// Enum Chat for "Chat"
			/// </summary>
			[EnumMember(Value = "Chat")]
			Chat,

			/// <summary>
			/// Enum Email for "Email"
			/// </summary>
			[EnumMember(Value = "Email")]
			Email,

			/// <summary>
			/// Enum Message for "Message"
			/// </summary>
			[EnumMember(Value = "Message")]
			Message
		}
		/// <summary>
		/// The status of the job.
		/// </summary>
		/// <value>The status of the job.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum JobStatusEnum
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
			/// Enum Inprogress for "InProgress"
			/// </summary>
			[EnumMember(Value = "InProgress")]
			Inprogress,

			/// <summary>
			/// Enum Completed for "Completed"
			/// </summary>
			[EnumMember(Value = "Completed")]
			Completed,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed
		}
		/// <summary>
		/// The status of the job.
		/// </summary>
		/// <value>The status of the job.</value>
		[DataMember(Name = "jobStatus", EmitDefaultValue = false)]
		public JobStatusEnum? JobStatus { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ReprocessJobResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ReprocessJobResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ReprocessJobResponse" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Description">The description of the job..</param>
		/// <param name="DateStart">The date from which the reprocessing should begin. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="DateEnd">The date at which the reprocessing should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="MediaTypes">Media types used to filter interactions. (required).</param>
		/// <param name="Programs">The mapped programs to be included in the job. (required).</param>
		/// <param name="Dialects">Language dialects used to filter interactions..</param>
		/// <param name="CreatedBy">The user who created the job. (required).</param>
		/// <param name="DateCreated">The date the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="JobStatus">The status of the job. (required).</param>
		/// <param name="QueueOrder">The position of the job in the queued jobs..</param>
		/// <param name="ProcessedInteractionsCount">The amount of interactions successfully reprocessed. (required).</param>
		/// <param name="FailedInteractionsCount">The amount of failed interactions. (required).</param>
		/// <param name="TotalInteractionsCount">The amount of interactions in the job..</param>
		public ReprocessJobResponse(string Name = null, string Description = null, DateTime? DateStart = null, DateTime? DateEnd = null, List<MediaTypesEnum> MediaTypes = null, List<string> Programs = null, List<string> Dialects = null, AddressableEntityRef CreatedBy = null, DateTime? DateCreated = null, JobStatusEnum? JobStatus = null, int? QueueOrder = null, int? ProcessedInteractionsCount = null, int? FailedInteractionsCount = null, int? TotalInteractionsCount = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.DateStart = DateStart;
			this.DateEnd = DateEnd;
			this.MediaTypes = MediaTypes;
			this.Programs = Programs;
			this.Dialects = Dialects;
			this.CreatedBy = CreatedBy;
			this.DateCreated = DateCreated;
			this.JobStatus = JobStatus;
			this.QueueOrder = QueueOrder;
			this.ProcessedInteractionsCount = ProcessedInteractionsCount;
			this.FailedInteractionsCount = FailedInteractionsCount;
			this.TotalInteractionsCount = TotalInteractionsCount;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The description of the job.
		/// </summary>
		/// <value>The description of the job.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The date from which the reprocessing should begin. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date from which the reprocessing should begin. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public DateTime? DateStart { get; set; }



		/// <summary>
		/// The date at which the reprocessing should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date at which the reprocessing should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateEnd", EmitDefaultValue = false)]
		public DateTime? DateEnd { get; set; }



		/// <summary>
		/// Media types used to filter interactions.
		/// </summary>
		/// <value>Media types used to filter interactions.</value>
		[DataMember(Name = "mediaTypes", EmitDefaultValue = false)]
		public List<MediaTypesEnum> MediaTypes { get; set; }



		/// <summary>
		/// The mapped programs to be included in the job.
		/// </summary>
		/// <value>The mapped programs to be included in the job.</value>
		[DataMember(Name = "programs", EmitDefaultValue = false)]
		public List<string> Programs { get; set; }



		/// <summary>
		/// Language dialects used to filter interactions.
		/// </summary>
		/// <value>Language dialects used to filter interactions.</value>
		[DataMember(Name = "dialects", EmitDefaultValue = false)]
		public List<string> Dialects { get; set; }



		/// <summary>
		/// The user who created the job.
		/// </summary>
		/// <value>The user who created the job.</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public AddressableEntityRef CreatedBy { get; set; }



		/// <summary>
		/// The date the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }





		/// <summary>
		/// The position of the job in the queued jobs.
		/// </summary>
		/// <value>The position of the job in the queued jobs.</value>
		[DataMember(Name = "queueOrder", EmitDefaultValue = false)]
		public int? QueueOrder { get; set; }



		/// <summary>
		/// The amount of interactions successfully reprocessed.
		/// </summary>
		/// <value>The amount of interactions successfully reprocessed.</value>
		[DataMember(Name = "processedInteractionsCount", EmitDefaultValue = false)]
		public int? ProcessedInteractionsCount { get; set; }



		/// <summary>
		/// The amount of failed interactions.
		/// </summary>
		/// <value>The amount of failed interactions.</value>
		[DataMember(Name = "failedInteractionsCount", EmitDefaultValue = false)]
		public int? FailedInteractionsCount { get; set; }



		/// <summary>
		/// The amount of interactions in the job.
		/// </summary>
		/// <value>The amount of interactions in the job.</value>
		[DataMember(Name = "totalInteractionsCount", EmitDefaultValue = false)]
		public int? TotalInteractionsCount { get; set; }



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
			sb.Append("class ReprocessJobResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
			sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
			sb.Append("  Programs: ").Append(Programs).Append("\n");
			sb.Append("  Dialects: ").Append(Dialects).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
			sb.Append("  QueueOrder: ").Append(QueueOrder).Append("\n");
			sb.Append("  ProcessedInteractionsCount: ").Append(ProcessedInteractionsCount).Append("\n");
			sb.Append("  FailedInteractionsCount: ").Append(FailedInteractionsCount).Append("\n");
			sb.Append("  TotalInteractionsCount: ").Append(TotalInteractionsCount).Append("\n");
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
			return this.Equals(obj as ReprocessJobResponse);
		}

		/// <summary>
		/// Returns true if ReprocessJobResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ReprocessJobResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ReprocessJobResponse other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.DateStart == other.DateStart ||
					this.DateStart != null &&
					this.DateStart.Equals(other.DateStart)
				) &&
				(
					this.DateEnd == other.DateEnd ||
					this.DateEnd != null &&
					this.DateEnd.Equals(other.DateEnd)
				) &&
				(
					this.MediaTypes == other.MediaTypes ||
					this.MediaTypes != null &&
					this.MediaTypes.SequenceEqual(other.MediaTypes)
				) &&
				(
					this.Programs == other.Programs ||
					this.Programs != null &&
					this.Programs.SequenceEqual(other.Programs)
				) &&
				(
					this.Dialects == other.Dialects ||
					this.Dialects != null &&
					this.Dialects.SequenceEqual(other.Dialects)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.JobStatus == other.JobStatus ||
					this.JobStatus != null &&
					this.JobStatus.Equals(other.JobStatus)
				) &&
				(
					this.QueueOrder == other.QueueOrder ||
					this.QueueOrder != null &&
					this.QueueOrder.Equals(other.QueueOrder)
				) &&
				(
					this.ProcessedInteractionsCount == other.ProcessedInteractionsCount ||
					this.ProcessedInteractionsCount != null &&
					this.ProcessedInteractionsCount.Equals(other.ProcessedInteractionsCount)
				) &&
				(
					this.FailedInteractionsCount == other.FailedInteractionsCount ||
					this.FailedInteractionsCount != null &&
					this.FailedInteractionsCount.Equals(other.FailedInteractionsCount)
				) &&
				(
					this.TotalInteractionsCount == other.TotalInteractionsCount ||
					this.TotalInteractionsCount != null &&
					this.TotalInteractionsCount.Equals(other.TotalInteractionsCount)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.DateEnd != null)
					hash = hash * 59 + this.DateEnd.GetHashCode();

				if (this.MediaTypes != null)
					hash = hash * 59 + this.MediaTypes.GetHashCode();

				if (this.Programs != null)
					hash = hash * 59 + this.Programs.GetHashCode();

				if (this.Dialects != null)
					hash = hash * 59 + this.Dialects.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.JobStatus != null)
					hash = hash * 59 + this.JobStatus.GetHashCode();

				if (this.QueueOrder != null)
					hash = hash * 59 + this.QueueOrder.GetHashCode();

				if (this.ProcessedInteractionsCount != null)
					hash = hash * 59 + this.ProcessedInteractionsCount.GetHashCode();

				if (this.FailedInteractionsCount != null)
					hash = hash * 59 + this.FailedInteractionsCount.GetHashCode();

				if (this.TotalInteractionsCount != null)
					hash = hash * 59 + this.TotalInteractionsCount.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
