using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UploadUrlRequestBody
	/// </summary>
	[DataContract]
	public partial class UploadUrlRequestBody : IEquatable<UploadUrlRequestBody>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UploadUrlRequestBody" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UploadUrlRequestBody() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UploadUrlRequestBody" /> class.
		/// </summary>
		/// <param name="ContentLengthBytes">The expected content length (in bytes) of the gzip-encoded data that will be PUT to the returned signed URL (required).</param>
		public UploadUrlRequestBody(long? ContentLengthBytes = null)
		{
			this.ContentLengthBytes = ContentLengthBytes;

		}



		/// <summary>
		/// The expected content length (in bytes) of the gzip-encoded data that will be PUT to the returned signed URL
		/// </summary>
		/// <value>The expected content length (in bytes) of the gzip-encoded data that will be PUT to the returned signed URL</value>
		[DataMember(Name = "contentLengthBytes", EmitDefaultValue = false)]
		public long? ContentLengthBytes { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UploadUrlRequestBody {\n");

			sb.Append("  ContentLengthBytes: ").Append(ContentLengthBytes).Append("\n");
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
			return this.Equals(obj as UploadUrlRequestBody);
		}

		/// <summary>
		/// Returns true if UploadUrlRequestBody instances are equal
		/// </summary>
		/// <param name="other">Instance of UploadUrlRequestBody to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UploadUrlRequestBody other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ContentLengthBytes == other.ContentLengthBytes ||
					this.ContentLengthBytes != null &&
					this.ContentLengthBytes.Equals(other.ContentLengthBytes)
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
				if (this.ContentLengthBytes != null)
					hash = hash * 59 + this.ContentLengthBytes.GetHashCode();

				return hash;
			}
		}
	}

}
