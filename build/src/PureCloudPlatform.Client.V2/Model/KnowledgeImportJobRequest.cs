using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeImportJobRequest
	/// </summary>
	[DataContract]
	public partial class KnowledgeImportJobRequest : IEquatable<KnowledgeImportJobRequest>
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
		/// File type of the document
		/// </summary>
		/// <value>File type of the document</value>
		[DataMember(Name = "fileType", EmitDefaultValue = false)]
		public FileTypeEnum? FileType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeImportJobRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected KnowledgeImportJobRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeImportJobRequest" /> class.
		/// </summary>
		/// <param name="UploadKey">Upload key (required).</param>
		/// <param name="FileType">File type of the document (required).</param>
		/// <param name="Settings">Additional optional settings.</param>
		/// <param name="SkipConfirmationStep">If enabled pre-validation step will be skipped..</param>
		public KnowledgeImportJobRequest(string UploadKey = null, FileTypeEnum? FileType = null, KnowledgeImportJobSettings Settings = null, bool? SkipConfirmationStep = null)
		{
			this.UploadKey = UploadKey;
			this.FileType = FileType;
			this.Settings = Settings;
			this.SkipConfirmationStep = SkipConfirmationStep;

		}



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
		/// If enabled pre-validation step will be skipped.
		/// </summary>
		/// <value>If enabled pre-validation step will be skipped.</value>
		[DataMember(Name = "skipConfirmationStep", EmitDefaultValue = false)]
		public bool? SkipConfirmationStep { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeImportJobRequest {\n");

			sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
			sb.Append("  FileType: ").Append(FileType).Append("\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("  SkipConfirmationStep: ").Append(SkipConfirmationStep).Append("\n");
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
			return this.Equals(obj as KnowledgeImportJobRequest);
		}

		/// <summary>
		/// Returns true if KnowledgeImportJobRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeImportJobRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeImportJobRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
					this.SkipConfirmationStep == other.SkipConfirmationStep ||
					this.SkipConfirmationStep != null &&
					this.SkipConfirmationStep.Equals(other.SkipConfirmationStep)
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
				if (this.UploadKey != null)
					hash = hash * 59 + this.UploadKey.GetHashCode();

				if (this.FileType != null)
					hash = hash * 59 + this.FileType.GetHashCode();

				if (this.Settings != null)
					hash = hash * 59 + this.Settings.GetHashCode();

				if (this.SkipConfirmationStep != null)
					hash = hash * 59 + this.SkipConfirmationStep.GetHashCode();

				return hash;
			}
		}
	}

}
