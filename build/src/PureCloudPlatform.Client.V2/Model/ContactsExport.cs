using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactsExport
	/// </summary>
	[DataContract]
	public partial class ContactsExport : IEquatable<ContactsExport>
	{
		/// <summary>
		/// The status of the request
		/// </summary>
		/// <value>The status of the request</value>
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
			/// Enum Running for "RUNNING"
			/// </summary>
			[EnumMember(Value = "RUNNING")]
			Running,

			/// <summary>
			/// Enum Succeeded for "SUCCEEDED"
			/// </summary>
			[EnumMember(Value = "SUCCEEDED")]
			Succeeded,

			/// <summary>
			/// Enum Failed for "FAILED"
			/// </summary>
			[EnumMember(Value = "FAILED")]
			Failed
		}
		/// <summary>
		/// The status of the request
		/// </summary>
		/// <value>The status of the request</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactsExport" /> class.
		/// </summary>
		/// <param name="DivisionIds">Division IDs of entities.</param>
		/// <param name="QueryConditions">Query conditions to apply on export.</param>
		public ContactsExport(List<string> DivisionIds = null, ContactsExportQueryConditions QueryConditions = null)
		{
			this.DivisionIds = DivisionIds;
			this.QueryConditions = QueryConditions;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Division IDs of entities
		/// </summary>
		/// <value>Division IDs of entities</value>
		[DataMember(Name = "divisionIds", EmitDefaultValue = false)]
		public List<string> DivisionIds { get; set; }



		/// <summary>
		/// Query conditions to apply on export
		/// </summary>
		/// <value>Query conditions to apply on export</value>
		[DataMember(Name = "queryConditions", EmitDefaultValue = false)]
		public ContactsExportQueryConditions QueryConditions { get; set; }



		/// <summary>
		/// The user that created this request
		/// </summary>
		/// <value>The user that created this request</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public DomainEntityRef CreatedBy { get; private set; }



		/// <summary>
		/// When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }





		/// <summary>
		/// The location where the results of the request can be retrieved
		/// </summary>
		/// <value>The location where the results of the request can be retrieved</value>
		[DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
		public string DownloadUrl { get; private set; }



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
			sb.Append("class ContactsExport {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
			sb.Append("  QueryConditions: ").Append(QueryConditions).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
			return this.Equals(obj as ContactsExport);
		}

		/// <summary>
		/// Returns true if ContactsExport instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactsExport to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactsExport other)
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
					this.DivisionIds == other.DivisionIds ||
					this.DivisionIds != null &&
					this.DivisionIds.SequenceEqual(other.DivisionIds)
				) &&
				(
					this.QueryConditions == other.QueryConditions ||
					this.QueryConditions != null &&
					this.QueryConditions.Equals(other.QueryConditions)
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
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.DownloadUrl == other.DownloadUrl ||
					this.DownloadUrl != null &&
					this.DownloadUrl.Equals(other.DownloadUrl)
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

				if (this.DivisionIds != null)
					hash = hash * 59 + this.DivisionIds.GetHashCode();

				if (this.QueryConditions != null)
					hash = hash * 59 + this.QueryConditions.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.DownloadUrl != null)
					hash = hash * 59 + this.DownloadUrl.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
