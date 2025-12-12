using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Defines an external media that has been ingested and cached by Genesys Cloud for conversation messaging
	/// </summary>
	[DataContract]
	public partial class CachedMediaItem : IEquatable<CachedMediaItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CachedMediaItem" /> class.
		/// </summary>
		public CachedMediaItem()
		{

		}



		/// <summary>
		/// The unique identifier for the cached media.
		/// </summary>
		/// <value>The unique identifier for the cached media.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The URL that represents the external media that has been cached
		/// </summary>
		/// <value>The URL that represents the external media that has been cached</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; private set; }



		/// <summary>
		/// A URL to fetch the cached media
		/// </summary>
		/// <value>A URL to fetch the cached media</value>
		[DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
		public string DownloadUrl { get; private set; }



		/// <summary>
		/// The media type for the URL
		/// </summary>
		/// <value>The media type for the URL</value>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public string MediaType { get; private set; }



		/// <summary>
		/// The content length of the media represented by the URL, in bytes.
		/// </summary>
		/// <value>The content length of the media represented by the URL, in bytes.</value>
		[DataMember(Name = "contentLengthBytes", EmitDefaultValue = false)]
		public int? ContentLengthBytes { get; private set; }



		/// <summary>
		/// The date the cached item was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the cached item was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// The date the cached item expires and will be removed from the cache. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the cached item expires and will be removed from the cache. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateExpires", EmitDefaultValue = false)]
		public DateTime? DateExpires { get; private set; }



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
			sb.Append("class CachedMediaItem {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  ContentLengthBytes: ").Append(ContentLengthBytes).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
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
			return this.Equals(obj as CachedMediaItem);
		}

		/// <summary>
		/// Returns true if CachedMediaItem instances are equal
		/// </summary>
		/// <param name="other">Instance of CachedMediaItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CachedMediaItem other)
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
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
				) &&
				(
					this.DownloadUrl == other.DownloadUrl ||
					this.DownloadUrl != null &&
					this.DownloadUrl.Equals(other.DownloadUrl)
				) &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.ContentLengthBytes == other.ContentLengthBytes ||
					this.ContentLengthBytes != null &&
					this.ContentLengthBytes.Equals(other.ContentLengthBytes)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateExpires == other.DateExpires ||
					this.DateExpires != null &&
					this.DateExpires.Equals(other.DateExpires)
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

				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				if (this.DownloadUrl != null)
					hash = hash * 59 + this.DownloadUrl.GetHashCode();

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.ContentLengthBytes != null)
					hash = hash * 59 + this.ContentLengthBytes.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateExpires != null)
					hash = hash * 59 + this.DateExpires.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
