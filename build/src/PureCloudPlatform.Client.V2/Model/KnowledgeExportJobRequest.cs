using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeExportJobRequest
	/// </summary>
	[DataContract]
	public partial class KnowledgeExportJobRequest : IEquatable<KnowledgeExportJobRequest>
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
		/// Initializes a new instance of the <see cref="KnowledgeExportJobRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected KnowledgeExportJobRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeExportJobRequest" /> class.
		/// </summary>
		/// <param name="ExportFilter">What to export. (required).</param>
		/// <param name="FileType">File type of the document (required).</param>
		/// <param name="SourceId">Knowledge integration source id..</param>
		/// <param name="JsonFileVersion">Requested version of the exported json file. Available versions are 2 and 3, default is 2.</param>
		public KnowledgeExportJobRequest(KnowledgeExportJobFilter ExportFilter = null, FileTypeEnum? FileType = null, string SourceId = null, int? JsonFileVersion = null)
		{
			this.ExportFilter = ExportFilter;
			this.FileType = FileType;
			this.SourceId = SourceId;
			this.JsonFileVersion = JsonFileVersion;

		}



		/// <summary>
		/// What to export.
		/// </summary>
		/// <value>What to export.</value>
		[DataMember(Name = "exportFilter", EmitDefaultValue = false)]
		public KnowledgeExportJobFilter ExportFilter { get; set; }





		/// <summary>
		/// Knowledge integration source id.
		/// </summary>
		/// <value>Knowledge integration source id.</value>
		[DataMember(Name = "sourceId", EmitDefaultValue = false)]
		public string SourceId { get; set; }



		/// <summary>
		/// Requested version of the exported json file. Available versions are 2 and 3, default is 2
		/// </summary>
		/// <value>Requested version of the exported json file. Available versions are 2 and 3, default is 2</value>
		[DataMember(Name = "jsonFileVersion", EmitDefaultValue = false)]
		public int? JsonFileVersion { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeExportJobRequest {\n");

			sb.Append("  ExportFilter: ").Append(ExportFilter).Append("\n");
			sb.Append("  FileType: ").Append(FileType).Append("\n");
			sb.Append("  SourceId: ").Append(SourceId).Append("\n");
			sb.Append("  JsonFileVersion: ").Append(JsonFileVersion).Append("\n");
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
			return this.Equals(obj as KnowledgeExportJobRequest);
		}

		/// <summary>
		/// Returns true if KnowledgeExportJobRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeExportJobRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeExportJobRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ExportFilter == other.ExportFilter ||
					this.ExportFilter != null &&
					this.ExportFilter.Equals(other.ExportFilter)
				) &&
				(
					this.FileType == other.FileType ||
					this.FileType != null &&
					this.FileType.Equals(other.FileType)
				) &&
				(
					this.SourceId == other.SourceId ||
					this.SourceId != null &&
					this.SourceId.Equals(other.SourceId)
				) &&
				(
					this.JsonFileVersion == other.JsonFileVersion ||
					this.JsonFileVersion != null &&
					this.JsonFileVersion.Equals(other.JsonFileVersion)
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
				if (this.ExportFilter != null)
					hash = hash * 59 + this.ExportFilter.GetHashCode();

				if (this.FileType != null)
					hash = hash * 59 + this.FileType.GetHashCode();

				if (this.SourceId != null)
					hash = hash * 59 + this.SourceId.GetHashCode();

				if (this.JsonFileVersion != null)
					hash = hash * 59 + this.JsonFileVersion.GetHashCode();

				return hash;
			}
		}
	}

}
