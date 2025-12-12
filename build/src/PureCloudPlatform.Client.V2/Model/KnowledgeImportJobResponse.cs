using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeImportJobResponse
	/// </summary>
	[DataContract]
	public partial class KnowledgeImportJobResponse : IEquatable<KnowledgeImportJobResponse>
	{
		/// <summary>
		/// File type of the document
		/// </summary>
		/// <value>File type of the document</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FileTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Json for "Json"
			/// </summary>
			[EnumMember(Value = "Json")]
			Json,

			/// <summary>
			/// Enum Csv for "Csv"
			/// </summary>
			[EnumMember(Value = "Csv")]
			Csv,

			/// <summary>
			/// Enum Xlsx for "Xlsx"
			/// </summary>
			[EnumMember(Value = "Xlsx")]
			Xlsx
		}
		/// <summary>
		/// Status of the import job
		/// </summary>
		/// <value>Status of the import job</value>
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
			/// Enum Validationinprogress for "ValidationInProgress"
			/// </summary>
			[EnumMember(Value = "ValidationInProgress")]
			Validationinprogress,

			/// <summary>
			/// Enum Validationcompleted for "ValidationCompleted"
			/// </summary>
			[EnumMember(Value = "ValidationCompleted")]
			Validationcompleted,

			/// <summary>
			/// Enum Validationfailed for "ValidationFailed"
			/// </summary>
			[EnumMember(Value = "ValidationFailed")]
			Validationfailed,

			/// <summary>
			/// Enum Started for "Started"
			/// </summary>
			[EnumMember(Value = "Started")]
			Started,

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
			/// Enum Partialcompleted for "PartialCompleted"
			/// </summary>
			[EnumMember(Value = "PartialCompleted")]
			Partialcompleted,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed,

			/// <summary>
			/// Enum Abortrequested for "AbortRequested"
			/// </summary>
			[EnumMember(Value = "AbortRequested")]
			Abortrequested,

			/// <summary>
			/// Enum Aborted for "Aborted"
			/// </summary>
			[EnumMember(Value = "Aborted")]
			Aborted
		}
		/// <summary>
		/// File type of the document
		/// </summary>
		/// <value>File type of the document</value>
		[DataMember(Name = "fileType", EmitDefaultValue = false)]
		public FileTypeEnum? FileType { get; set; }
		/// <summary>
		/// Status of the import job
		/// </summary>
		/// <value>Status of the import job</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeImportJobResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected KnowledgeImportJobResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeImportJobResponse" /> class.
		/// </summary>
		/// <param name="DownloadURL">The URL of the location at which the caller can download the imported file..</param>
		/// <param name="FailedEntitiesURL">The URL of the location at which the caller can download the entities in json format that failed during the import..</param>
		/// <param name="UploadKey">Upload key (required).</param>
		/// <param name="FileType">File type of the document (required).</param>
		/// <param name="Settings">Additional optional settings.</param>
		/// <param name="SkipConfirmationStep">If enabled pre-validation step will be skipped..</param>
		public KnowledgeImportJobResponse(string DownloadURL = null, string FailedEntitiesURL = null, string UploadKey = null, FileTypeEnum? FileType = null, KnowledgeImportJobSettings Settings = null, bool? SkipConfirmationStep = null)
		{
			this.DownloadURL = DownloadURL;
			this.FailedEntitiesURL = FailedEntitiesURL;
			this.UploadKey = UploadKey;
			this.FileType = FileType;
			this.Settings = Settings;
			this.SkipConfirmationStep = SkipConfirmationStep;

		}



		/// <summary>
		/// Id of the import job
		/// </summary>
		/// <value>Id of the import job</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The URL of the location at which the caller can download the imported file.
		/// </summary>
		/// <value>The URL of the location at which the caller can download the imported file.</value>
		[DataMember(Name = "downloadURL", EmitDefaultValue = false)]
		public string DownloadURL { get; set; }



		/// <summary>
		/// The URL of the location at which the caller can download the entities in json format that failed during the import.
		/// </summary>
		/// <value>The URL of the location at which the caller can download the entities in json format that failed during the import.</value>
		[DataMember(Name = "failedEntitiesURL", EmitDefaultValue = false)]
		public string FailedEntitiesURL { get; set; }



		/// <summary>
		/// Upload key
		/// </summary>
		/// <value>Upload key</value>
		[DataMember(Name = "uploadKey", EmitDefaultValue = false)]
		public string UploadKey { get; set; }





		/// <summary>
		/// Additional optional settings
		/// </summary>
		/// <value>Additional optional settings</value>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public KnowledgeImportJobSettings Settings { get; set; }





		/// <summary>
		/// Report of the import job
		/// </summary>
		/// <value>Report of the import job</value>
		[DataMember(Name = "report", EmitDefaultValue = false)]
		public KnowledgeImportJobReport Report { get; private set; }



		/// <summary>
		/// Knowledge base which document import does belong to
		/// </summary>
		/// <value>Knowledge base which document import does belong to</value>
		[DataMember(Name = "knowledgeBase", EmitDefaultValue = false)]
		public KnowledgeBase KnowledgeBase { get; private set; }



		/// <summary>
		/// The user who created the operation
		/// </summary>
		/// <value>The user who created the operation</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public UserReference CreatedBy { get; private set; }



		/// <summary>
		/// Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// If enabled pre-validation step will be skipped.
		/// </summary>
		/// <value>If enabled pre-validation step will be skipped.</value>
		[DataMember(Name = "skipConfirmationStep", EmitDefaultValue = false)]
		public bool? SkipConfirmationStep { get; set; }



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
			sb.Append("class KnowledgeImportJobResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DownloadURL: ").Append(DownloadURL).Append("\n");
			sb.Append("  FailedEntitiesURL: ").Append(FailedEntitiesURL).Append("\n");
			sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
			sb.Append("  FileType: ").Append(FileType).Append("\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Report: ").Append(Report).Append("\n");
			sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  SkipConfirmationStep: ").Append(SkipConfirmationStep).Append("\n");
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
			return this.Equals(obj as KnowledgeImportJobResponse);
		}

		/// <summary>
		/// Returns true if KnowledgeImportJobResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeImportJobResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeImportJobResponse other)
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
					this.DownloadURL == other.DownloadURL ||
					this.DownloadURL != null &&
					this.DownloadURL.Equals(other.DownloadURL)
				) &&
				(
					this.FailedEntitiesURL == other.FailedEntitiesURL ||
					this.FailedEntitiesURL != null &&
					this.FailedEntitiesURL.Equals(other.FailedEntitiesURL)
				) &&
				(
					this.UploadKey == other.UploadKey ||
					this.UploadKey != null &&
					this.UploadKey.Equals(other.UploadKey)
				) &&
				(
					this.FileType == other.FileType ||
					this.FileType != null &&
					this.FileType.Equals(other.FileType)
				) &&
				(
					this.Settings == other.Settings ||
					this.Settings != null &&
					this.Settings.Equals(other.Settings)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Report == other.Report ||
					this.Report != null &&
					this.Report.Equals(other.Report)
				) &&
				(
					this.KnowledgeBase == other.KnowledgeBase ||
					this.KnowledgeBase != null &&
					this.KnowledgeBase.Equals(other.KnowledgeBase)
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
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.SkipConfirmationStep == other.SkipConfirmationStep ||
					this.SkipConfirmationStep != null &&
					this.SkipConfirmationStep.Equals(other.SkipConfirmationStep)
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

				if (this.DownloadURL != null)
					hash = hash * 59 + this.DownloadURL.GetHashCode();

				if (this.FailedEntitiesURL != null)
					hash = hash * 59 + this.FailedEntitiesURL.GetHashCode();

				if (this.UploadKey != null)
					hash = hash * 59 + this.UploadKey.GetHashCode();

				if (this.FileType != null)
					hash = hash * 59 + this.FileType.GetHashCode();

				if (this.Settings != null)
					hash = hash * 59 + this.Settings.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Report != null)
					hash = hash * 59 + this.Report.GetHashCode();

				if (this.KnowledgeBase != null)
					hash = hash * 59 + this.KnowledgeBase.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.SkipConfirmationStep != null)
					hash = hash * 59 + this.SkipConfirmationStep.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
