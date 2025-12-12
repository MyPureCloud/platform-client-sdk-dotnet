using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// User input data used in a bot flow turn.
	/// </summary>
	[DataContract]
	public partial class TextBotUserInputAlternative : IEquatable<TextBotUserInputAlternative>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TextBotUserInputAlternative" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TextBotUserInputAlternative() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TextBotUserInputAlternative" /> class.
		/// </summary>
		/// <param name="Transcript">The user input transcript. (required).</param>
		public TextBotUserInputAlternative(TextBotTranscript Transcript = null)
		{
			this.Transcript = Transcript;

		}



		/// <summary>
		/// The user input transcript.
		/// </summary>
		/// <value>The user input transcript.</value>
		[DataMember(Name = "transcript", EmitDefaultValue = false)]
		public TextBotTranscript Transcript { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TextBotUserInputAlternative {\n");

			sb.Append("  Transcript: ").Append(Transcript).Append("\n");
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
			return this.Equals(obj as TextBotUserInputAlternative);
		}

		/// <summary>
		/// Returns true if TextBotUserInputAlternative instances are equal
		/// </summary>
		/// <param name="other">Instance of TextBotUserInputAlternative to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TextBotUserInputAlternative other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Transcript == other.Transcript ||
					this.Transcript != null &&
					this.Transcript.Equals(other.Transcript)
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
				if (this.Transcript != null)
					hash = hash * 59 + this.Transcript.GetHashCode();

				return hash;
			}
		}
	}

}
