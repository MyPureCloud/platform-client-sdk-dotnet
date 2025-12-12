using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactImportJobStatusUpdateRequest
	/// </summary>
	[DataContract]
	public partial class ContactImportJobStatusUpdateRequest : IEquatable<ContactImportJobStatusUpdateRequest>
	{
		/// <summary>
		/// Workflow status
		/// </summary>
		/// <value>Workflow status</value>
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
			/// Enum Continue for "Continue"
			/// </summary>
			[EnumMember(Value = "Continue")]
			Continue,

			/// <summary>
			/// Enum Cancel for "Cancel"
			/// </summary>
			[EnumMember(Value = "Cancel")]
			Cancel,

			/// <summary>
			/// Enum Retry for "Retry"
			/// </summary>
			[EnumMember(Value = "Retry")]
			Retry
		}
		/// <summary>
		/// Workflow status
		/// </summary>
		/// <value>Workflow status</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactImportJobStatusUpdateRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContactImportJobStatusUpdateRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactImportJobStatusUpdateRequest" /> class.
		/// </summary>
		/// <param name="JobId">Job Id (required).</param>
		/// <param name="Status">Workflow status (required).</param>
		public ContactImportJobStatusUpdateRequest(string JobId = null, StatusEnum? Status = null)
		{
			this.JobId = JobId;
			this.Status = Status;

		}



		/// <summary>
		/// Job Id
		/// </summary>
		/// <value>Job Id</value>
		[DataMember(Name = "jobId", EmitDefaultValue = false)]
		public string JobId { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContactImportJobStatusUpdateRequest {\n");

			sb.Append("  JobId: ").Append(JobId).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
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
			return this.Equals(obj as ContactImportJobStatusUpdateRequest);
		}

		/// <summary>
		/// Returns true if ContactImportJobStatusUpdateRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactImportJobStatusUpdateRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactImportJobStatusUpdateRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.JobId == other.JobId ||
					this.JobId != null &&
					this.JobId.Equals(other.JobId)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
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
				if (this.JobId != null)
					hash = hash * 59 + this.JobId.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				return hash;
			}
		}
	}

}
