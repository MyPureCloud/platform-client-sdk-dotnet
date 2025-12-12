using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LearningCoverArtThumbnail
	/// </summary>
	[DataContract]
	public partial class LearningCoverArtThumbnail : IEquatable<LearningCoverArtThumbnail>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningCoverArtThumbnail" /> class.
		/// </summary>
		/// <param name="Resolution">Resolution of thumbnail.</param>
		/// <param name="Url">The URL for the thumbnail.</param>
		public LearningCoverArtThumbnail(string Resolution = null, string Url = null)
		{
			this.Resolution = Resolution;
			this.Url = Url;

		}



		/// <summary>
		/// Resolution of thumbnail
		/// </summary>
		/// <value>Resolution of thumbnail</value>
		[DataMember(Name = "resolution", EmitDefaultValue = false)]
		public string Resolution { get; set; }



		/// <summary>
		/// The URL for the thumbnail
		/// </summary>
		/// <value>The URL for the thumbnail</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningCoverArtThumbnail {\n");

			sb.Append("  Resolution: ").Append(Resolution).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
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
			return this.Equals(obj as LearningCoverArtThumbnail);
		}

		/// <summary>
		/// Returns true if LearningCoverArtThumbnail instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningCoverArtThumbnail to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningCoverArtThumbnail other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Resolution == other.Resolution ||
					this.Resolution != null &&
					this.Resolution.Equals(other.Resolution)
				) &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
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
				if (this.Resolution != null)
					hash = hash * 59 + this.Resolution.GetHashCode();

				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				return hash;
			}
		}
	}

}
