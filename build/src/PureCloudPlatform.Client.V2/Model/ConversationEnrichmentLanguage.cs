using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Detected language of this message.
	/// </summary>
	[DataContract]
	public partial class ConversationEnrichmentLanguage : IEquatable<ConversationEnrichmentLanguage>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEnrichmentLanguage" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationEnrichmentLanguage() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEnrichmentLanguage" /> class.
		/// </summary>
		/// <param name="Language">The IETF detected language code of this message. (required).</param>
		public ConversationEnrichmentLanguage(string Language = null)
		{
			this.Language = Language;

		}



		/// <summary>
		/// The IETF detected language code of this message.
		/// </summary>
		/// <value>The IETF detected language code of this message.</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationEnrichmentLanguage {\n");

			sb.Append("  Language: ").Append(Language).Append("\n");
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
			return this.Equals(obj as ConversationEnrichmentLanguage);
		}

		/// <summary>
		/// Returns true if ConversationEnrichmentLanguage instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationEnrichmentLanguage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationEnrichmentLanguage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
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
				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				return hash;
			}
		}
	}

}
