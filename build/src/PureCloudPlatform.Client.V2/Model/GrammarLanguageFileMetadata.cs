using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// GrammarLanguageFileMetadata
	/// </summary>
	[DataContract]
	public partial class GrammarLanguageFileMetadata : IEquatable<GrammarLanguageFileMetadata>
	{
		/// <summary>
		/// The extension of the file
		/// </summary>
		/// <value>The extension of the file</value>
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
			/// Enum Gram for "Gram"
			/// </summary>
			[EnumMember(Value = "Gram")]
			Gram,

			/// <summary>
			/// Enum Grxml for "Grxml"
			/// </summary>
			[EnumMember(Value = "Grxml")]
			Grxml
		}
		/// <summary>
		/// The extension of the file
		/// </summary>
		/// <value>The extension of the file</value>
		[DataMember(Name = "fileType", EmitDefaultValue = false)]
		public FileTypeEnum? FileType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="GrammarLanguageFileMetadata" /> class.
		/// </summary>
		/// <param name="FileName">The name of the file as defined by the user.</param>
		/// <param name="FileSizeBytes">The size of the file in bytes.</param>
		/// <param name="DateUploaded">The date the file was uploaded. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="FileType">The extension of the file.</param>
		public GrammarLanguageFileMetadata(string FileName = null, int? FileSizeBytes = null, DateTime? DateUploaded = null, FileTypeEnum? FileType = null)
		{
			this.FileName = FileName;
			this.FileSizeBytes = FileSizeBytes;
			this.DateUploaded = DateUploaded;
			this.FileType = FileType;

		}



		/// <summary>
		/// The name of the file as defined by the user
		/// </summary>
		/// <value>The name of the file as defined by the user</value>
		[DataMember(Name = "fileName", EmitDefaultValue = false)]
		public string FileName { get; set; }



		/// <summary>
		/// The size of the file in bytes
		/// </summary>
		/// <value>The size of the file in bytes</value>
		[DataMember(Name = "fileSizeBytes", EmitDefaultValue = false)]
		public int? FileSizeBytes { get; set; }



		/// <summary>
		/// The date the file was uploaded. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the file was uploaded. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateUploaded", EmitDefaultValue = false)]
		public DateTime? DateUploaded { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GrammarLanguageFileMetadata {\n");

			sb.Append("  FileName: ").Append(FileName).Append("\n");
			sb.Append("  FileSizeBytes: ").Append(FileSizeBytes).Append("\n");
			sb.Append("  DateUploaded: ").Append(DateUploaded).Append("\n");
			sb.Append("  FileType: ").Append(FileType).Append("\n");
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
			return this.Equals(obj as GrammarLanguageFileMetadata);
		}

		/// <summary>
		/// Returns true if GrammarLanguageFileMetadata instances are equal
		/// </summary>
		/// <param name="other">Instance of GrammarLanguageFileMetadata to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GrammarLanguageFileMetadata other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FileName == other.FileName ||
					this.FileName != null &&
					this.FileName.Equals(other.FileName)
				) &&
				(
					this.FileSizeBytes == other.FileSizeBytes ||
					this.FileSizeBytes != null &&
					this.FileSizeBytes.Equals(other.FileSizeBytes)
				) &&
				(
					this.DateUploaded == other.DateUploaded ||
					this.DateUploaded != null &&
					this.DateUploaded.Equals(other.DateUploaded)
				) &&
				(
					this.FileType == other.FileType ||
					this.FileType != null &&
					this.FileType.Equals(other.FileType)
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
				if (this.FileName != null)
					hash = hash * 59 + this.FileName.GetHashCode();

				if (this.FileSizeBytes != null)
					hash = hash * 59 + this.FileSizeBytes.GetHashCode();

				if (this.DateUploaded != null)
					hash = hash * 59 + this.DateUploaded.GetHashCode();

				if (this.FileType != null)
					hash = hash * 59 + this.FileType.GetHashCode();

				return hash;
			}
		}
	}

}
