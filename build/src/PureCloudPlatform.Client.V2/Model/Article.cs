using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Article
	/// </summary>
	[DataContract]
	public partial class Article : IEquatable<Article>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Article" /> class.
		/// </summary>
		public Article()
		{

		}



		/// <summary>
		/// The article title.
		/// </summary>
		/// <value>The article title.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; private set; }



		/// <summary>
		/// The URI for the article.
		/// </summary>
		/// <value>The URI for the article.</value>
		[DataMember(Name = "uri", EmitDefaultValue = false)]
		public string Uri { get; private set; }



		/// <summary>
		/// This contains snippets of text from the article matching the query.
		/// </summary>
		/// <value>This contains snippets of text from the article matching the query.</value>
		[DataMember(Name = "snippets", EmitDefaultValue = false)]
		public List<string> Snippets { get; private set; }



		/// <summary>
		/// Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.
		/// </summary>
		/// <value>Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public float? Confidence { get; private set; }



		/// <summary>
		/// A map that contains custom metadata about the article answer.
		/// </summary>
		/// <value>A map that contains custom metadata about the article answer.</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public Dictionary<string, MetadataAttribute> Metadata { get; private set; }



		/// <summary>
		/// The version of the Article.
		/// </summary>
		/// <value>The version of the Article.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public AddressableEntityRef Version { get; private set; }



		/// <summary>
		/// Variations of the Article.
		/// </summary>
		/// <value>Variations of the Article.</value>
		[DataMember(Name = "variations", EmitDefaultValue = false)]
		public List<AddressableEntityRef> Variations { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Article {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Uri: ").Append(Uri).Append("\n");
			sb.Append("  Snippets: ").Append(Snippets).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  Variations: ").Append(Variations).Append("\n");
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
			return this.Equals(obj as Article);
		}

		/// <summary>
		/// Returns true if Article instances are equal
		/// </summary>
		/// <param name="other">Instance of Article to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Article other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Uri == other.Uri ||
					this.Uri != null &&
					this.Uri.Equals(other.Uri)
				) &&
				(
					this.Snippets == other.Snippets ||
					this.Snippets != null &&
					this.Snippets.SequenceEqual(other.Snippets)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.SequenceEqual(other.Metadata)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.Variations == other.Variations ||
					this.Variations != null &&
					this.Variations.SequenceEqual(other.Variations)
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
				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Uri != null)
					hash = hash * 59 + this.Uri.GetHashCode();

				if (this.Snippets != null)
					hash = hash * 59 + this.Snippets.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.Variations != null)
					hash = hash * 59 + this.Variations.GetHashCode();

				return hash;
			}
		}
	}

}
