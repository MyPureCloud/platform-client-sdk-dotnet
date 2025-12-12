using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactsBulkOperationJob
	/// </summary>
	[DataContract]
	public partial class ContactsBulkOperationJob : IEquatable<ContactsBulkOperationJob>
	{
		/// <summary>
		/// The job state.
		/// </summary>
		/// <value>The job state.</value>
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
			/// Enum Inprogress for "InProgress"
			/// </summary>
			[EnumMember(Value = "InProgress")]
			Inprogress,

			/// <summary>
			/// Enum Complete for "Complete"
			/// </summary>
			[EnumMember(Value = "Complete")]
			Complete,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed
		}
		/// <summary>
		/// The job type.
		/// </summary>
		/// <value>The job type.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Bulkdelete for "BulkDelete"
			/// </summary>
			[EnumMember(Value = "BulkDelete")]
			Bulkdelete,

			/// <summary>
			/// Enum Bulkedit for "BulkEdit"
			/// </summary>
			[EnumMember(Value = "BulkEdit")]
			Bulkedit
		}
		/// <summary>
		/// The job state.
		/// </summary>
		/// <value>The job state.</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; private set; }
		/// <summary>
		/// The job type.
		/// </summary>
		/// <value>The job type.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactsBulkOperationJob" /> class.
		/// </summary>
		public ContactsBulkOperationJob()
		{

		}



		/// <summary>
		/// The globally unique job identifier.
		/// </summary>
		/// <value>The globally unique job identifier.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }







		/// <summary>
		/// Total records that will be impacted by the bulk operation.
		/// </summary>
		/// <value>Total records that will be impacted by the bulk operation.</value>
		[DataMember(Name = "totalRecords", EmitDefaultValue = false)]
		public long? TotalRecords { get; private set; }



		/// <summary>
		/// Amount of records that have been impacted by the bulk operation.
		/// </summary>
		/// <value>Amount of records that have been impacted by the bulk operation.</value>
		[DataMember(Name = "completedRecords", EmitDefaultValue = false)]
		public long? CompletedRecords { get; private set; }



		/// <summary>
		/// Percentage of records that have been impacted by the bulk operation.
		/// </summary>
		/// <value>Percentage of records that have been impacted by the bulk operation.</value>
		[DataMember(Name = "percentComplete", EmitDefaultValue = false)]
		public int? PercentComplete { get; private set; }



		/// <summary>
		/// Information on failure reason.
		/// </summary>
		/// <value>Information on failure reason.</value>
		[DataMember(Name = "failureReason", EmitDefaultValue = false)]
		public ErrorInfo FailureReason { get; private set; }



		/// <summary>
		/// URI to download the original backup contacts.
		/// </summary>
		/// <value>URI to download the original backup contacts.</value>
		[DataMember(Name = "downloadURI", EmitDefaultValue = false)]
		public string DownloadURI { get; private set; }



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
			sb.Append("class ContactsBulkOperationJob {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
			sb.Append("  CompletedRecords: ").Append(CompletedRecords).Append("\n");
			sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
			sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
			sb.Append("  DownloadURI: ").Append(DownloadURI).Append("\n");
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
			return this.Equals(obj as ContactsBulkOperationJob);
		}

		/// <summary>
		/// Returns true if ContactsBulkOperationJob instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactsBulkOperationJob to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactsBulkOperationJob other)
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.TotalRecords == other.TotalRecords ||
					this.TotalRecords != null &&
					this.TotalRecords.Equals(other.TotalRecords)
				) &&
				(
					this.CompletedRecords == other.CompletedRecords ||
					this.CompletedRecords != null &&
					this.CompletedRecords.Equals(other.CompletedRecords)
				) &&
				(
					this.PercentComplete == other.PercentComplete ||
					this.PercentComplete != null &&
					this.PercentComplete.Equals(other.PercentComplete)
				) &&
				(
					this.FailureReason == other.FailureReason ||
					this.FailureReason != null &&
					this.FailureReason.Equals(other.FailureReason)
				) &&
				(
					this.DownloadURI == other.DownloadURI ||
					this.DownloadURI != null &&
					this.DownloadURI.Equals(other.DownloadURI)
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

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.TotalRecords != null)
					hash = hash * 59 + this.TotalRecords.GetHashCode();

				if (this.CompletedRecords != null)
					hash = hash * 59 + this.CompletedRecords.GetHashCode();

				if (this.PercentComplete != null)
					hash = hash * 59 + this.PercentComplete.GetHashCode();

				if (this.FailureReason != null)
					hash = hash * 59 + this.FailureReason.GetHashCode();

				if (this.DownloadURI != null)
					hash = hash * 59 + this.DownloadURI.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
