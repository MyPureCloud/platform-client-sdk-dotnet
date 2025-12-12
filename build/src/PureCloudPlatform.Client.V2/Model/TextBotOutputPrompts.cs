using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Prompt information related to a bot flow turn.
	/// </summary>
	[DataContract]
	public partial class TextBotOutputPrompts : IEquatable<TextBotOutputPrompts>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TextBotOutputPrompts" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TextBotOutputPrompts() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TextBotOutputPrompts" /> class.
		/// </summary>
		/// <param name="OutputLanguage">The ISO code of the output language for this prompt item. (required).</param>
		/// <param name="TextPrompts">Text output prompts, if any..</param>
		public TextBotOutputPrompts(string OutputLanguage = null, TextBotModeOutputPrompts TextPrompts = null)
		{
			this.OutputLanguage = OutputLanguage;
			this.TextPrompts = TextPrompts;

		}



		/// <summary>
		/// The ISO code of the output language for this prompt item.
		/// </summary>
		/// <value>The ISO code of the output language for this prompt item.</value>
		[DataMember(Name = "outputLanguage", EmitDefaultValue = false)]
		public string OutputLanguage { get; set; }



		/// <summary>
		/// Text output prompts, if any.
		/// </summary>
		/// <value>Text output prompts, if any.</value>
		[DataMember(Name = "textPrompts", EmitDefaultValue = false)]
		public TextBotModeOutputPrompts TextPrompts { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TextBotOutputPrompts {\n");

			sb.Append("  OutputLanguage: ").Append(OutputLanguage).Append("\n");
			sb.Append("  TextPrompts: ").Append(TextPrompts).Append("\n");
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
			return this.Equals(obj as TextBotOutputPrompts);
		}

		/// <summary>
		/// Returns true if TextBotOutputPrompts instances are equal
		/// </summary>
		/// <param name="other">Instance of TextBotOutputPrompts to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TextBotOutputPrompts other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.OutputLanguage == other.OutputLanguage ||
					this.OutputLanguage != null &&
					this.OutputLanguage.Equals(other.OutputLanguage)
				) &&
				(
					this.TextPrompts == other.TextPrompts ||
					this.TextPrompts != null &&
					this.TextPrompts.Equals(other.TextPrompts)
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
				if (this.OutputLanguage != null)
					hash = hash * 59 + this.OutputLanguage.GetHashCode();

				if (this.TextPrompts != null)
					hash = hash * 59 + this.TextPrompts.GetHashCode();

				return hash;
			}
		}
	}

}
