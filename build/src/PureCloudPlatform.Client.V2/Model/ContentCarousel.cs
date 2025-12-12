using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Carousel content object.
	/// </summary>
	[DataContract]
	public partial class ContentCarousel : IEquatable<ContentCarousel>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ContentCarousel" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContentCarousel() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContentCarousel" /> class.
		/// </summary>
		/// <param name="Cards">An array of card objects. (required).</param>
		public ContentCarousel(List<ContentCard> Cards = null)
		{
			this.Cards = Cards;

		}



		/// <summary>
		/// An array of card objects.
		/// </summary>
		/// <value>An array of card objects.</value>
		[DataMember(Name = "cards", EmitDefaultValue = false)]
		public List<ContentCard> Cards { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContentCarousel {\n");

			sb.Append("  Cards: ").Append(Cards).Append("\n");
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
			return this.Equals(obj as ContentCarousel);
		}

		/// <summary>
		/// Returns true if ContentCarousel instances are equal
		/// </summary>
		/// <param name="other">Instance of ContentCarousel to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContentCarousel other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Cards == other.Cards ||
					this.Cards != null &&
					this.Cards.SequenceEqual(other.Cards)
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
				if (this.Cards != null)
					hash = hash * 59 + this.Cards.GetHashCode();

				return hash;
			}
		}
	}

}
