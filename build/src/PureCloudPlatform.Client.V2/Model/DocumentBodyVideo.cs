using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentBodyVideo
	/// </summary>
	[DataContract]
	public partial class DocumentBodyVideo : IEquatable<DocumentBodyVideo>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentBodyVideo" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DocumentBodyVideo() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentBodyVideo" /> class.
		/// </summary>
		/// <param name="Url">The URL for the video. (required).</param>
		/// <param name="Properties">The properties for the video..</param>
		public DocumentBodyVideo(string Url = null, DocumentBodyVideoProperties Properties = null)
		{
			this.Url = Url;
			this.Properties = Properties;

		}



		/// <summary>
		/// The URL for the video.
		/// </summary>
		/// <value>The URL for the video.</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }



		/// <summary>
		/// The properties for the video.
		/// </summary>
		/// <value>The properties for the video.</value>
		[DataMember(Name = "properties", EmitDefaultValue = false)]
		public DocumentBodyVideoProperties Properties { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentBodyVideo {\n");

			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Properties: ").Append(Properties).Append("\n");
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
			return this.Equals(obj as DocumentBodyVideo);
		}

		/// <summary>
		/// Returns true if DocumentBodyVideo instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentBodyVideo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentBodyVideo other)
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
					this.Properties == other.Properties ||
					this.Properties != null &&
					this.Properties.Equals(other.Properties)
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

				if (this.Properties != null)
					hash = hash * 59 + this.Properties.GetHashCode();

				return hash;
			}
		}
	}

}
