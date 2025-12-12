using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CsvUploadPreviewResponse
	/// </summary>
	[DataContract]
	public partial class CsvUploadPreviewResponse : IEquatable<CsvUploadPreviewResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CsvUploadPreviewResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CsvUploadPreviewResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CsvUploadPreviewResponse" /> class.
		/// </summary>
		/// <param name="UploadId">Id for the upload (required).</param>
		/// <param name="Headers">List of headers in the CSV (required).</param>
		/// <param name="Entries">List of entries in the CSV (required).</param>
		public CsvUploadPreviewResponse(string UploadId = null, List<string> Headers = null, List<List<string>> Entries = null)
		{
			this.UploadId = UploadId;
			this.Headers = Headers;
			this.Entries = Entries;

		}



		/// <summary>
		/// Id for the upload
		/// </summary>
		/// <value>Id for the upload</value>
		[DataMember(Name = "uploadId", EmitDefaultValue = false)]
		public string UploadId { get; set; }



		/// <summary>
		/// List of headers in the CSV
		/// </summary>
		/// <value>List of headers in the CSV</value>
		[DataMember(Name = "headers", EmitDefaultValue = false)]
		public List<string> Headers { get; set; }



		/// <summary>
		/// List of entries in the CSV
		/// </summary>
		/// <value>List of entries in the CSV</value>
		[DataMember(Name = "entries", EmitDefaultValue = false)]
		public List<List<string>> Entries { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CsvUploadPreviewResponse {\n");

			sb.Append("  UploadId: ").Append(UploadId).Append("\n");
			sb.Append("  Headers: ").Append(Headers).Append("\n");
			sb.Append("  Entries: ").Append(Entries).Append("\n");
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
			return this.Equals(obj as CsvUploadPreviewResponse);
		}

		/// <summary>
		/// Returns true if CsvUploadPreviewResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of CsvUploadPreviewResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CsvUploadPreviewResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.UploadId == other.UploadId ||
					this.UploadId != null &&
					this.UploadId.Equals(other.UploadId)
				) &&
				(
					this.Headers == other.Headers ||
					this.Headers != null &&
					this.Headers.SequenceEqual(other.Headers)
				) &&
				(
					this.Entries == other.Entries ||
					this.Entries != null &&
					this.Entries.SequenceEqual(other.Entries)
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
				if (this.UploadId != null)
					hash = hash * 59 + this.UploadId.GetHashCode();

				if (this.Headers != null)
					hash = hash * 59 + this.Headers.GetHashCode();

				if (this.Entries != null)
					hash = hash * 59 + this.Entries.GetHashCode();

				return hash;
			}
		}
	}

}
