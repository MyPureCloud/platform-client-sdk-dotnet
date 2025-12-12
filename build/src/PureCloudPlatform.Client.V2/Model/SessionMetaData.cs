using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SessionMetaData
	/// </summary>
	[DataContract]
	public partial class SessionMetaData : IEquatable<SessionMetaData>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SessionMetaData" /> class.
		/// </summary>
		/// <param name="DownloadUrl">URL to fetch the meta data information. This field is populated only if session state is Complete.</param>
		/// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
		public SessionMetaData(string DownloadUrl = null, SessionMetaDataResult DownloadResult = null)
		{
			this.DownloadUrl = DownloadUrl;
			this.DownloadResult = DownloadResult;

		}



		/// <summary>
		/// URL to fetch the meta data information. This field is populated only if session state is Complete
		/// </summary>
		/// <value>URL to fetch the meta data information. This field is populated only if session state is Complete</value>
		[DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
		public string DownloadUrl { get; set; }



		/// <summary>
		/// Result will always come via downloadUrls; however the schema is included for documentation
		/// </summary>
		/// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
		[DataMember(Name = "downloadResult", EmitDefaultValue = false)]
		public SessionMetaDataResult DownloadResult { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SessionMetaData {\n");

			sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
			sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
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
			return this.Equals(obj as SessionMetaData);
		}

		/// <summary>
		/// Returns true if SessionMetaData instances are equal
		/// </summary>
		/// <param name="other">Instance of SessionMetaData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SessionMetaData other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DownloadUrl == other.DownloadUrl ||
					this.DownloadUrl != null &&
					this.DownloadUrl.Equals(other.DownloadUrl)
				) &&
				(
					this.DownloadResult == other.DownloadResult ||
					this.DownloadResult != null &&
					this.DownloadResult.Equals(other.DownloadResult)
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
				if (this.DownloadUrl != null)
					hash = hash * 59 + this.DownloadUrl.GetHashCode();

				if (this.DownloadResult != null)
					hash = hash * 59 + this.DownloadResult.GetHashCode();

				return hash;
			}
		}
	}

}
