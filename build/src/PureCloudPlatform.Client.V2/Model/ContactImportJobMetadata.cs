using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactImportJobMetadata
	/// </summary>
	[DataContract]
	public partial class ContactImportJobMetadata : IEquatable<ContactImportJobMetadata>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactImportJobMetadata" /> class.
		/// </summary>
		/// <param name="FileName">FileName.</param>
		/// <param name="DryRunFailedCount">DryRunFailedCount.</param>
		/// <param name="DryRunSuccessCount">DryRunSuccessCount.</param>
		/// <param name="DryRunReportDownloadUrl">DryRunReportDownloadUrl.</param>
		/// <param name="ImportFailedCount">ImportFailedCount.</param>
		/// <param name="ImportSuccessCount">ImportSuccessCount.</param>
		/// <param name="ImportReportDownloadUrl">ImportReportDownloadUrl.</param>
		public ContactImportJobMetadata(string FileName = null, int? DryRunFailedCount = null, int? DryRunSuccessCount = null, string DryRunReportDownloadUrl = null, int? ImportFailedCount = null, int? ImportSuccessCount = null, string ImportReportDownloadUrl = null)
		{
			this.FileName = FileName;
			this.DryRunFailedCount = DryRunFailedCount;
			this.DryRunSuccessCount = DryRunSuccessCount;
			this.DryRunReportDownloadUrl = DryRunReportDownloadUrl;
			this.ImportFailedCount = ImportFailedCount;
			this.ImportSuccessCount = ImportSuccessCount;
			this.ImportReportDownloadUrl = ImportReportDownloadUrl;

		}



		/// <summary>
		/// Gets or Sets FileName
		/// </summary>
		[DataMember(Name = "fileName", EmitDefaultValue = false)]
		public string FileName { get; set; }



		/// <summary>
		/// Gets or Sets DryRunFailedCount
		/// </summary>
		[DataMember(Name = "dryRunFailedCount", EmitDefaultValue = false)]
		public int? DryRunFailedCount { get; set; }



		/// <summary>
		/// Gets or Sets DryRunSuccessCount
		/// </summary>
		[DataMember(Name = "dryRunSuccessCount", EmitDefaultValue = false)]
		public int? DryRunSuccessCount { get; set; }



		/// <summary>
		/// Gets or Sets DryRunReportDownloadUrl
		/// </summary>
		[DataMember(Name = "dryRunReportDownloadUrl", EmitDefaultValue = false)]
		public string DryRunReportDownloadUrl { get; set; }



		/// <summary>
		/// Gets or Sets ImportFailedCount
		/// </summary>
		[DataMember(Name = "importFailedCount", EmitDefaultValue = false)]
		public int? ImportFailedCount { get; set; }



		/// <summary>
		/// Gets or Sets ImportSuccessCount
		/// </summary>
		[DataMember(Name = "importSuccessCount", EmitDefaultValue = false)]
		public int? ImportSuccessCount { get; set; }



		/// <summary>
		/// Gets or Sets ImportReportDownloadUrl
		/// </summary>
		[DataMember(Name = "importReportDownloadUrl", EmitDefaultValue = false)]
		public string ImportReportDownloadUrl { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContactImportJobMetadata {\n");

			sb.Append("  FileName: ").Append(FileName).Append("\n");
			sb.Append("  DryRunFailedCount: ").Append(DryRunFailedCount).Append("\n");
			sb.Append("  DryRunSuccessCount: ").Append(DryRunSuccessCount).Append("\n");
			sb.Append("  DryRunReportDownloadUrl: ").Append(DryRunReportDownloadUrl).Append("\n");
			sb.Append("  ImportFailedCount: ").Append(ImportFailedCount).Append("\n");
			sb.Append("  ImportSuccessCount: ").Append(ImportSuccessCount).Append("\n");
			sb.Append("  ImportReportDownloadUrl: ").Append(ImportReportDownloadUrl).Append("\n");
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
			return this.Equals(obj as ContactImportJobMetadata);
		}

		/// <summary>
		/// Returns true if ContactImportJobMetadata instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactImportJobMetadata to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactImportJobMetadata other)
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
					this.DryRunFailedCount == other.DryRunFailedCount ||
					this.DryRunFailedCount != null &&
					this.DryRunFailedCount.Equals(other.DryRunFailedCount)
				) &&
				(
					this.DryRunSuccessCount == other.DryRunSuccessCount ||
					this.DryRunSuccessCount != null &&
					this.DryRunSuccessCount.Equals(other.DryRunSuccessCount)
				) &&
				(
					this.DryRunReportDownloadUrl == other.DryRunReportDownloadUrl ||
					this.DryRunReportDownloadUrl != null &&
					this.DryRunReportDownloadUrl.Equals(other.DryRunReportDownloadUrl)
				) &&
				(
					this.ImportFailedCount == other.ImportFailedCount ||
					this.ImportFailedCount != null &&
					this.ImportFailedCount.Equals(other.ImportFailedCount)
				) &&
				(
					this.ImportSuccessCount == other.ImportSuccessCount ||
					this.ImportSuccessCount != null &&
					this.ImportSuccessCount.Equals(other.ImportSuccessCount)
				) &&
				(
					this.ImportReportDownloadUrl == other.ImportReportDownloadUrl ||
					this.ImportReportDownloadUrl != null &&
					this.ImportReportDownloadUrl.Equals(other.ImportReportDownloadUrl)
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

				if (this.DryRunFailedCount != null)
					hash = hash * 59 + this.DryRunFailedCount.GetHashCode();

				if (this.DryRunSuccessCount != null)
					hash = hash * 59 + this.DryRunSuccessCount.GetHashCode();

				if (this.DryRunReportDownloadUrl != null)
					hash = hash * 59 + this.DryRunReportDownloadUrl.GetHashCode();

				if (this.ImportFailedCount != null)
					hash = hash * 59 + this.ImportFailedCount.GetHashCode();

				if (this.ImportSuccessCount != null)
					hash = hash * 59 + this.ImportSuccessCount.GetHashCode();

				if (this.ImportReportDownloadUrl != null)
					hash = hash * 59 + this.ImportReportDownloadUrl.GetHashCode();

				return hash;
			}
		}
	}

}
