using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactImportJobResponse
	/// </summary>
	[DataContract]
	public partial class ContactImportJobResponse : IEquatable<ContactImportJobResponse>
	{
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Created for "Created"
			/// </summary>
			[EnumMember(Value = "Created")]
			Created,

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
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed,

			/// <summary>
			/// Enum Cancelled for "Cancelled"
			/// </summary>
			[EnumMember(Value = "Cancelled")]
			Cancelled
		}
		/// <summary>
		/// Detailed description for the Job execution state
		/// </summary>
		/// <value>Detailed description for the Job execution state</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ExecutionStepEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Validating for "Validating"
			/// </summary>
			[EnumMember(Value = "Validating")]
			Validating,

			/// <summary>
			/// Enum Validated for "Validated"
			/// </summary>
			[EnumMember(Value = "Validated")]
			Validated,

			/// <summary>
			/// Enum Importing for "Importing"
			/// </summary>
			[EnumMember(Value = "Importing")]
			Importing
		}
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Detailed description for the Job execution state
		/// </summary>
		/// <value>Detailed description for the Job execution state</value>
		[DataMember(Name = "executionStep", EmitDefaultValue = false)]
		public ExecutionStepEnum? ExecutionStep { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactImportJobResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContactImportJobResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactImportJobResponse" /> class.
		/// </summary>
		/// <param name="Status">Status.</param>
		/// <param name="StatusDetails">Detailed description for JobStatus..</param>
		/// <param name="ExecutionStep">Detailed description for the Job execution state.</param>
		/// <param name="Metadata">Metadata for the job.</param>
		/// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Division">Division for the job.</param>
		/// <param name="Settings">Settings (required).</param>
		public ContactImportJobResponse(StatusEnum? Status = null, string StatusDetails = null, ExecutionStepEnum? ExecutionStep = null, ContactImportJobMetadata Metadata = null, DateTime? DateCreated = null, StarrableDivision Division = null, AddressableEntityRef Settings = null)
		{
			this.Status = Status;
			this.StatusDetails = StatusDetails;
			this.ExecutionStep = ExecutionStep;
			this.Metadata = Metadata;
			this.DateCreated = DateCreated;
			this.Division = Division;
			this.Settings = Settings;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }





		/// <summary>
		/// Detailed description for JobStatus.
		/// </summary>
		/// <value>Detailed description for JobStatus.</value>
		[DataMember(Name = "statusDetails", EmitDefaultValue = false)]
		public string StatusDetails { get; set; }





		/// <summary>
		/// Metadata for the job
		/// </summary>
		/// <value>Metadata for the job</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public ContactImportJobMetadata Metadata { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Division for the job
		/// </summary>
		/// <value>Division for the job</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public StarrableDivision Division { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }



		/// <summary>
		/// Settings
		/// </summary>
		/// <value>Settings</value>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public AddressableEntityRef Settings { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContactImportJobResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  StatusDetails: ").Append(StatusDetails).Append("\n");
			sb.Append("  ExecutionStep: ").Append(ExecutionStep).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
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
			return this.Equals(obj as ContactImportJobResponse);
		}

		/// <summary>
		/// Returns true if ContactImportJobResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactImportJobResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactImportJobResponse other)
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
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.StatusDetails == other.StatusDetails ||
					this.StatusDetails != null &&
					this.StatusDetails.Equals(other.StatusDetails)
				) &&
				(
					this.ExecutionStep == other.ExecutionStep ||
					this.ExecutionStep != null &&
					this.ExecutionStep.Equals(other.ExecutionStep)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.Equals(other.Metadata)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
				) &&
				(
					this.Settings == other.Settings ||
					this.Settings != null &&
					this.Settings.Equals(other.Settings)
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

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.StatusDetails != null)
					hash = hash * 59 + this.StatusDetails.GetHashCode();

				if (this.ExecutionStep != null)
					hash = hash * 59 + this.ExecutionStep.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				if (this.Settings != null)
					hash = hash * 59 + this.Settings.GetHashCode();

				return hash;
			}
		}
	}

}
