using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// HistoricalImportStatusJobResponse
	/// </summary>
	[DataContract]
	public partial class HistoricalImportStatusJobResponse : IEquatable<HistoricalImportStatusJobResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HistoricalImportStatusJobResponse" /> class.
		/// </summary>
		/// <param name="ImportStatusResult">The historical import status result of the import job.</param>
		public HistoricalImportStatusJobResponse(HistoricalImportStatus ImportStatusResult = null)
		{
			this.ImportStatusResult = ImportStatusResult;

		}



		/// <summary>
		/// The job id for the import request
		/// </summary>
		/// <value>The job id for the import request</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The historical import status result of the import job
		/// </summary>
		/// <value>The historical import status result of the import job</value>
		[DataMember(Name = "importStatusResult", EmitDefaultValue = false)]
		public HistoricalImportStatus ImportStatusResult { get; set; }



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
			sb.Append("class HistoricalImportStatusJobResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  ImportStatusResult: ").Append(ImportStatusResult).Append("\n");
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
			return this.Equals(obj as HistoricalImportStatusJobResponse);
		}

		/// <summary>
		/// Returns true if HistoricalImportStatusJobResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of HistoricalImportStatusJobResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(HistoricalImportStatusJobResponse other)
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
					this.ImportStatusResult == other.ImportStatusResult ||
					this.ImportStatusResult != null &&
					this.ImportStatusResult.Equals(other.ImportStatusResult)
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

				if (this.ImportStatusResult != null)
					hash = hash * 59 + this.ImportStatusResult.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
