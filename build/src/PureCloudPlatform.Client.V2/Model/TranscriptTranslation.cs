using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TranscriptTranslation
	/// </summary>
	[DataContract]
	public partial class TranscriptTranslation : IEquatable<TranscriptTranslation>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TranscriptTranslation" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TranscriptTranslation() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TranscriptTranslation" /> class.
		/// </summary>
		/// <param name="Id">Transcript Id (required).</param>
		/// <param name="Phrases">List of translated phrases, if translation succeeded.</param>
		/// <param name="TranslateError">Translation error, if translation failed.</param>
		public TranscriptTranslation(string Id = null, List<PhraseTranslation> Phrases = null, string TranslateError = null)
		{
			this.Id = Id;
			this.Phrases = Phrases;
			this.TranslateError = TranslateError;

		}



		/// <summary>
		/// Transcript Id
		/// </summary>
		/// <value>Transcript Id</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// List of translated phrases, if translation succeeded
		/// </summary>
		/// <value>List of translated phrases, if translation succeeded</value>
		[DataMember(Name = "phrases", EmitDefaultValue = false)]
		public List<PhraseTranslation> Phrases { get; set; }



		/// <summary>
		/// Translation error, if translation failed
		/// </summary>
		/// <value>Translation error, if translation failed</value>
		[DataMember(Name = "translateError", EmitDefaultValue = false)]
		public string TranslateError { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TranscriptTranslation {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Phrases: ").Append(Phrases).Append("\n");
			sb.Append("  TranslateError: ").Append(TranslateError).Append("\n");
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
			return this.Equals(obj as TranscriptTranslation);
		}

		/// <summary>
		/// Returns true if TranscriptTranslation instances are equal
		/// </summary>
		/// <param name="other">Instance of TranscriptTranslation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TranscriptTranslation other)
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
					this.Phrases == other.Phrases ||
					this.Phrases != null &&
					this.Phrases.SequenceEqual(other.Phrases)
				) &&
				(
					this.TranslateError == other.TranslateError ||
					this.TranslateError != null &&
					this.TranslateError.Equals(other.TranslateError)
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

				if (this.Phrases != null)
					hash = hash * 59 + this.Phrases.GetHashCode();

				if (this.TranslateError != null)
					hash = hash * 59 + this.TranslateError.GetHashCode();

				return hash;
			}
		}
	}

}
