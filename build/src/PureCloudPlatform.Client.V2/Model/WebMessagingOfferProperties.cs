using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WebMessagingOfferProperties
	/// </summary>
	[DataContract]
	public partial class WebMessagingOfferProperties : IEquatable<WebMessagingOfferProperties>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WebMessagingOfferProperties" /> class.
		/// </summary>
		/// <param name="OfferText">Text value to be used when inviting a visitor to engage with a web messaging offer..</param>
		public WebMessagingOfferProperties(string OfferText = null)
		{
			this.OfferText = OfferText;

		}



		/// <summary>
		/// Text value to be used when inviting a visitor to engage with a web messaging offer.
		/// </summary>
		/// <value>Text value to be used when inviting a visitor to engage with a web messaging offer.</value>
		[DataMember(Name = "offerText", EmitDefaultValue = false)]
		public string OfferText { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebMessagingOfferProperties {\n");

			sb.Append("  OfferText: ").Append(OfferText).Append("\n");
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
			return this.Equals(obj as WebMessagingOfferProperties);
		}

		/// <summary>
		/// Returns true if WebMessagingOfferProperties instances are equal
		/// </summary>
		/// <param name="other">Instance of WebMessagingOfferProperties to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebMessagingOfferProperties other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.OfferText == other.OfferText ||
					this.OfferText != null &&
					this.OfferText.Equals(other.OfferText)
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
				if (this.OfferText != null)
					hash = hash * 59 + this.OfferText.GetHashCode();

				return hash;
			}
		}
	}

}
