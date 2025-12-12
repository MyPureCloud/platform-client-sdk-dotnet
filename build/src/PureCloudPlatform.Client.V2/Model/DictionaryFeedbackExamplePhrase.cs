using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DictionaryFeedbackExamplePhrase
	/// </summary>
	[DataContract]
	public partial class DictionaryFeedbackExamplePhrase : IEquatable<DictionaryFeedbackExamplePhrase>
	{
		/// <summary>
		/// The source of the given Example Phrase
		/// </summary>
		/// <value>The source of the given Example Phrase</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SourceEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Manual for "Manual"
			/// </summary>
			[EnumMember(Value = "Manual")]
			Manual
		}
		/// <summary>
		/// The source of the given Example Phrase
		/// </summary>
		/// <value>The source of the given Example Phrase</value>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public SourceEnum? Source { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DictionaryFeedbackExamplePhrase" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DictionaryFeedbackExamplePhrase() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DictionaryFeedbackExamplePhrase" /> class.
		/// </summary>
		/// <param name="Phrase">The Example Phrase text. At least 3 words and up to 20 words (required).</param>
		/// <param name="Source">The source of the given Example Phrase.</param>
		public DictionaryFeedbackExamplePhrase(string Phrase = null, SourceEnum? Source = null)
		{
			this.Phrase = Phrase;
			this.Source = Source;

		}



		/// <summary>
		/// The Example Phrase text. At least 3 words and up to 20 words
		/// </summary>
		/// <value>The Example Phrase text. At least 3 words and up to 20 words</value>
		[DataMember(Name = "phrase", EmitDefaultValue = false)]
		public string Phrase { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DictionaryFeedbackExamplePhrase {\n");

			sb.Append("  Phrase: ").Append(Phrase).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
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
			return this.Equals(obj as DictionaryFeedbackExamplePhrase);
		}

		/// <summary>
		/// Returns true if DictionaryFeedbackExamplePhrase instances are equal
		/// </summary>
		/// <param name="other">Instance of DictionaryFeedbackExamplePhrase to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DictionaryFeedbackExamplePhrase other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Phrase == other.Phrase ||
					this.Phrase != null &&
					this.Phrase.Equals(other.Phrase)
				) &&
				(
					this.Source == other.Source ||
					this.Source != null &&
					this.Source.Equals(other.Source)
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
				if (this.Phrase != null)
					hash = hash * 59 + this.Phrase.GetHashCode();

				if (this.Source != null)
					hash = hash * 59 + this.Source.GetHashCode();

				return hash;
			}
		}
	}

}
