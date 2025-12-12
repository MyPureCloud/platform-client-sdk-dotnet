using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TtsEngineEntity
	/// </summary>
	[DataContract]
	public partial class TtsEngineEntity : IEquatable<TtsEngineEntity>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TtsEngineEntity" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TtsEngineEntity() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TtsEngineEntity" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Languages">The set of languages the TTS engine supports (required).</param>
		/// <param name="OutputFormats">The set of output formats the TTS engine can produce (required).</param>
		/// <param name="Voices">The set of voices the TTS engine supports.</param>
		/// <param name="IsDefault">The TTS engine is the global default engine.</param>
		/// <param name="IsSecure">The TTS engine can be used in a secure call flow.</param>
		public TtsEngineEntity(string Name = null, List<string> Languages = null, List<string> OutputFormats = null, List<TtsVoiceEntity> Voices = null, bool? IsDefault = null, bool? IsSecure = null)
		{
			this.Name = Name;
			this.Languages = Languages;
			this.OutputFormats = OutputFormats;
			this.Voices = Voices;
			this.IsDefault = IsDefault;
			this.IsSecure = IsSecure;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The set of languages the TTS engine supports
		/// </summary>
		/// <value>The set of languages the TTS engine supports</value>
		[DataMember(Name = "languages", EmitDefaultValue = false)]
		public List<string> Languages { get; set; }



		/// <summary>
		/// The set of output formats the TTS engine can produce
		/// </summary>
		/// <value>The set of output formats the TTS engine can produce</value>
		[DataMember(Name = "outputFormats", EmitDefaultValue = false)]
		public List<string> OutputFormats { get; set; }



		/// <summary>
		/// The set of voices the TTS engine supports
		/// </summary>
		/// <value>The set of voices the TTS engine supports</value>
		[DataMember(Name = "voices", EmitDefaultValue = false)]
		public List<TtsVoiceEntity> Voices { get; set; }



		/// <summary>
		/// The TTS engine is the global default engine
		/// </summary>
		/// <value>The TTS engine is the global default engine</value>
		[DataMember(Name = "isDefault", EmitDefaultValue = false)]
		public bool? IsDefault { get; set; }



		/// <summary>
		/// The TTS engine can be used in a secure call flow
		/// </summary>
		/// <value>The TTS engine can be used in a secure call flow</value>
		[DataMember(Name = "isSecure", EmitDefaultValue = false)]
		public bool? IsSecure { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TtsEngineEntity {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Languages: ").Append(Languages).Append("\n");
			sb.Append("  OutputFormats: ").Append(OutputFormats).Append("\n");
			sb.Append("  Voices: ").Append(Voices).Append("\n");
			sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
			sb.Append("  IsSecure: ").Append(IsSecure).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as TtsEngineEntity);
		}

		/// <summary>
		/// Returns true if TtsEngineEntity instances are equal
		/// </summary>
		/// <param name="other">Instance of TtsEngineEntity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TtsEngineEntity other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Languages == other.Languages ||
					this.Languages != null &&
					this.Languages.SequenceEqual(other.Languages)
				) &&
				(
					this.OutputFormats == other.OutputFormats ||
					this.OutputFormats != null &&
					this.OutputFormats.SequenceEqual(other.OutputFormats)
				) &&
				(
					this.Voices == other.Voices ||
					this.Voices != null &&
					this.Voices.SequenceEqual(other.Voices)
				) &&
				(
					this.IsDefault == other.IsDefault ||
					this.IsDefault != null &&
					this.IsDefault.Equals(other.IsDefault)
				) &&
				(
					this.IsSecure == other.IsSecure ||
					this.IsSecure != null &&
					this.IsSecure.Equals(other.IsSecure)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Languages != null)
					hash = hash * 59 + this.Languages.GetHashCode();

				if (this.OutputFormats != null)
					hash = hash * 59 + this.OutputFormats.GetHashCode();

				if (this.Voices != null)
					hash = hash * 59 + this.Voices.GetHashCode();

				if (this.IsDefault != null)
					hash = hash * 59 + this.IsDefault.GetHashCode();

				if (this.IsSecure != null)
					hash = hash * 59 + this.IsSecure.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
