using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// HistoricalImportStatus
	/// </summary>
	[DataContract]
	public partial class HistoricalImportStatus : IEquatable<HistoricalImportStatus>
	{
		/// <summary>
		/// Status of the historical import in the organization.
		/// </summary>
		/// <value>Status of the historical import in the organization.</value>
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
			/// Enum Initiated for "Initiated"
			/// </summary>
			[EnumMember(Value = "Initiated")]
			Initiated,

			/// <summary>
			/// Enum Inprogress for "InProgress"
			/// </summary>
			[EnumMember(Value = "InProgress")]
			Inprogress,

			/// <summary>
			/// Enum Pending for "Pending"
			/// </summary>
			[EnumMember(Value = "Pending")]
			Pending,

			/// <summary>
			/// Enum Success for "Success"
			/// </summary>
			[EnumMember(Value = "Success")]
			Success,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed,

			/// <summary>
			/// Enum Cancelled for "Cancelled"
			/// </summary>
			[EnumMember(Value = "Cancelled")]
			Cancelled,

			/// <summary>
			/// Enum Purged for "Purged"
			/// </summary>
			[EnumMember(Value = "Purged")]
			Purged,

			/// <summary>
			/// Enum Purgepending for "PurgePending"
			/// </summary>
			[EnumMember(Value = "PurgePending")]
			Purgepending
		}
		/// <summary>
		/// Whether this historical import is of type csv or json
		/// </summary>
		/// <value>Whether this historical import is of type csv or json</value>
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
			/// Enum Csv for "Csv"
			/// </summary>
			[EnumMember(Value = "Csv")]
			Csv,

			/// <summary>
			/// Enum Json for "Json"
			/// </summary>
			[EnumMember(Value = "Json")]
			Json
		}
		/// <summary>
		/// Status of the historical import in the organization.
		/// </summary>
		/// <value>Status of the historical import in the organization.</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; private set; }
		/// <summary>
		/// Whether this historical import is of type csv or json
		/// </summary>
		/// <value>Whether this historical import is of type csv or json</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="HistoricalImportStatus" /> class.
		/// </summary>
		public HistoricalImportStatus()
		{

		}



		/// <summary>
		/// Request id of the historical import in the organization
		/// </summary>
		/// <value>Request id of the historical import in the organization</value>
		[DataMember(Name = "requestId", EmitDefaultValue = false)]
		public string RequestId { get; private set; }



		/// <summary>
		/// The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateImportEnded", EmitDefaultValue = false)]
		public DateTime? DateImportEnded { get; private set; }



		/// <summary>
		/// The first day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The first day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateImportStarted", EmitDefaultValue = false)]
		public DateTime? DateImportStarted { get; private set; }





		/// <summary>
		/// Error occured if the status of the import is failed
		/// </summary>
		/// <value>Error occured if the status of the import is failed</value>
		[DataMember(Name = "error", EmitDefaultValue = false)]
		public string Error { get; private set; }



		/// <summary>
		/// Date in which the historical import is initiated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date in which the historical import is initiated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// Date in which the historical import is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date in which the historical import is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// Whether this historical import is active or not
		/// </summary>
		/// <value>Whether this historical import is active or not</value>
		[DataMember(Name = "active", EmitDefaultValue = false)]
		public bool? Active { get; private set; }





		/// <summary>
		/// Name of the file that you are importing.
		/// </summary>
		/// <value>Name of the file that you are importing.</value>
		[DataMember(Name = "fileName", EmitDefaultValue = false)]
		public string FileName { get; private set; }



		/// <summary>
		/// Size of the file that you are importing.
		/// </summary>
		/// <value>Size of the file that you are importing.</value>
		[DataMember(Name = "fileSize", EmitDefaultValue = false)]
		public long? FileSize { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class HistoricalImportStatus {\n");

			sb.Append("  RequestId: ").Append(RequestId).Append("\n");
			sb.Append("  DateImportEnded: ").Append(DateImportEnded).Append("\n");
			sb.Append("  DateImportStarted: ").Append(DateImportStarted).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Error: ").Append(Error).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Active: ").Append(Active).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  FileName: ").Append(FileName).Append("\n");
			sb.Append("  FileSize: ").Append(FileSize).Append("\n");
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
			return this.Equals(obj as HistoricalImportStatus);
		}

		/// <summary>
		/// Returns true if HistoricalImportStatus instances are equal
		/// </summary>
		/// <param name="other">Instance of HistoricalImportStatus to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(HistoricalImportStatus other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RequestId == other.RequestId ||
					this.RequestId != null &&
					this.RequestId.Equals(other.RequestId)
				) &&
				(
					this.DateImportEnded == other.DateImportEnded ||
					this.DateImportEnded != null &&
					this.DateImportEnded.Equals(other.DateImportEnded)
				) &&
				(
					this.DateImportStarted == other.DateImportStarted ||
					this.DateImportStarted != null &&
					this.DateImportStarted.Equals(other.DateImportStarted)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Error == other.Error ||
					this.Error != null &&
					this.Error.Equals(other.Error)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.Active == other.Active ||
					this.Active != null &&
					this.Active.Equals(other.Active)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.FileName == other.FileName ||
					this.FileName != null &&
					this.FileName.Equals(other.FileName)
				) &&
				(
					this.FileSize == other.FileSize ||
					this.FileSize != null &&
					this.FileSize.Equals(other.FileSize)
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
				if (this.RequestId != null)
					hash = hash * 59 + this.RequestId.GetHashCode();

				if (this.DateImportEnded != null)
					hash = hash * 59 + this.DateImportEnded.GetHashCode();

				if (this.DateImportStarted != null)
					hash = hash * 59 + this.DateImportStarted.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Error != null)
					hash = hash * 59 + this.Error.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.Active != null)
					hash = hash * 59 + this.Active.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.FileName != null)
					hash = hash * 59 + this.FileName.GetHashCode();

				if (this.FileSize != null)
					hash = hash * 59 + this.FileSize.GetHashCode();

				return hash;
			}
		}
	}

}
