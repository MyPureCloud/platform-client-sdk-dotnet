using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// NluDetectionInput
	/// </summary>
	[DataContract]
	public partial class NluDetectionInput : IEquatable<NluDetectionInput>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="NluDetectionInput" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected NluDetectionInput() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="NluDetectionInput" /> class.
		/// </summary>
		/// <param name="Text">The text to perform NLU detection on. (required).</param>
		/// <param name="Language">Language of the version for multilingual detection, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;.</param>
		public NluDetectionInput(string Text = null, string Language = null)
		{
			this.Text = Text;
			this.Language = Language;

		}



		/// <summary>
		/// The text to perform NLU detection on.
		/// </summary>
		/// <value>The text to perform NLU detection on.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }



		/// <summary>
		/// Language of the version for multilingual detection, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;
		/// </summary>
		/// <value>Language of the version for multilingual detection, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NluDetectionInput {\n");

			sb.Append("  Text: ").Append(Text).Append("\n");
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
			return this.Equals(obj as NluDetectionInput);
		}

		/// <summary>
		/// Returns true if NluDetectionInput instances are equal
		/// </summary>
		/// <param name="other">Instance of NluDetectionInput to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NluDetectionInput other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
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
				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				return hash;
			}
		}
	}

}
