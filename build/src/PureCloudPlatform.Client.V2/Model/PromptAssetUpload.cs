using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PromptAssetUpload
	/// </summary>
	[DataContract]
	public partial class PromptAssetUpload : IEquatable<PromptAssetUpload>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PromptAssetUpload" /> class.
		/// </summary>
		public PromptAssetUpload()
		{

		}



		/// <summary>
		/// Pre-signed URL to PUT the file to
		/// </summary>
		/// <value>Pre-signed URL to PUT the file to</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; private set; }



		/// <summary>
		/// Required headers when uploading a file through PUT request to the URL
		/// </summary>
		/// <value>Required headers when uploading a file through PUT request to the URL</value>
		[DataMember(Name = "headers", EmitDefaultValue = false)]
		public Dictionary<string, string> Headers { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PromptAssetUpload {\n");

			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Headers: ").Append(Headers).Append("\n");
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
			return this.Equals(obj as PromptAssetUpload);
		}

		/// <summary>
		/// Returns true if PromptAssetUpload instances are equal
		/// </summary>
		/// <param name="other">Instance of PromptAssetUpload to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PromptAssetUpload other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
				) &&
				(
					this.Headers == other.Headers ||
					this.Headers != null &&
					this.Headers.SequenceEqual(other.Headers)
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
				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				if (this.Headers != null)
					hash = hash * 59 + this.Headers.GetHashCode();

				return hash;
			}
		}
	}

}
