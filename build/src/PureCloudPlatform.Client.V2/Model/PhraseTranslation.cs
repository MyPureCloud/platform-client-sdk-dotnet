using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PhraseTranslation
	/// </summary>
	[DataContract]
	public partial class PhraseTranslation : IEquatable<PhraseTranslation>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="PhraseTranslation" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected PhraseTranslation() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="PhraseTranslation" /> class.
		/// </summary>
		/// <param name="StartTimeMs">Epoch start time of the phrase (required).</param>
		/// <param name="ParticipantPurpose">Purpose of the participant associated with the phrase (required).</param>
		/// <param name="TranslatedText">Translation of the phrase (required).</param>
		public PhraseTranslation(long? StartTimeMs = null, string ParticipantPurpose = null, string TranslatedText = null)
		{
			this.StartTimeMs = StartTimeMs;
			this.ParticipantPurpose = ParticipantPurpose;
			this.TranslatedText = TranslatedText;

		}



		/// <summary>
		/// Epoch start time of the phrase
		/// </summary>
		/// <value>Epoch start time of the phrase</value>
		[DataMember(Name = "startTimeMs", EmitDefaultValue = false)]
		public long? StartTimeMs { get; set; }



		/// <summary>
		/// Purpose of the participant associated with the phrase
		/// </summary>
		/// <value>Purpose of the participant associated with the phrase</value>
		[DataMember(Name = "participantPurpose", EmitDefaultValue = false)]
		public string ParticipantPurpose { get; set; }



		/// <summary>
		/// Translation of the phrase
		/// </summary>
		/// <value>Translation of the phrase</value>
		[DataMember(Name = "translatedText", EmitDefaultValue = false)]
		public string TranslatedText { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PhraseTranslation {\n");

			sb.Append("  StartTimeMs: ").Append(StartTimeMs).Append("\n");
			sb.Append("  ParticipantPurpose: ").Append(ParticipantPurpose).Append("\n");
			sb.Append("  TranslatedText: ").Append(TranslatedText).Append("\n");
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
			return this.Equals(obj as PhraseTranslation);
		}

		/// <summary>
		/// Returns true if PhraseTranslation instances are equal
		/// </summary>
		/// <param name="other">Instance of PhraseTranslation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PhraseTranslation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StartTimeMs == other.StartTimeMs ||
					this.StartTimeMs != null &&
					this.StartTimeMs.Equals(other.StartTimeMs)
				) &&
				(
					this.ParticipantPurpose == other.ParticipantPurpose ||
					this.ParticipantPurpose != null &&
					this.ParticipantPurpose.Equals(other.ParticipantPurpose)
				) &&
				(
					this.TranslatedText == other.TranslatedText ||
					this.TranslatedText != null &&
					this.TranslatedText.Equals(other.TranslatedText)
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
				if (this.StartTimeMs != null)
					hash = hash * 59 + this.StartTimeMs.GetHashCode();

				if (this.ParticipantPurpose != null)
					hash = hash * 59 + this.ParticipantPurpose.GetHashCode();

				if (this.TranslatedText != null)
					hash = hash * 59 + this.TranslatedText.GetHashCode();

				return hash;
			}
		}
	}

}
