using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SupportedLanguagesInfoDefinition
	/// </summary>
	[DataContract]
	public partial class SupportedLanguagesInfoDefinition : IEquatable<SupportedLanguagesInfoDefinition>
	{
		/// <summary>
		/// The language release status
		/// </summary>
		/// <value>The language release status</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum EarlyPreview for "EARLY_PREVIEW"
			/// </summary>
			[EnumMember(Value = "EARLY_PREVIEW")]
			EarlyPreview,

			/// <summary>
			/// Enum Preview for "PREVIEW"
			/// </summary>
			[EnumMember(Value = "PREVIEW")]
			Preview,

			/// <summary>
			/// Enum Ga for "GA"
			/// </summary>
			[EnumMember(Value = "GA")]
			Ga
		}
		/// <summary>
		/// The language release status
		/// </summary>
		/// <value>The language release status</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="SupportedLanguagesInfoDefinition" /> class.
		/// </summary>
		/// <param name="Language">The given supported Language.</param>
		/// <param name="IntentClassification">The boolean status of if intent classification is supported in this language.</param>
		/// <param name="Status">The language release status.</param>
		/// <param name="SupportedEntityTypes">The supported entity types for this language.</param>
		/// <param name="SupportedEntityTypeConfiguration">The configuration for the supported entity types.</param>
		public SupportedLanguagesInfoDefinition(string Language = null, bool? IntentClassification = null, StatusEnum? Status = null, List<string> SupportedEntityTypes = null, SupportedEntityTypeStatus SupportedEntityTypeConfiguration = null)
		{
			this.Language = Language;
			this.IntentClassification = IntentClassification;
			this.Status = Status;
			this.SupportedEntityTypes = SupportedEntityTypes;
			this.SupportedEntityTypeConfiguration = SupportedEntityTypeConfiguration;

		}



		/// <summary>
		/// The given supported Language
		/// </summary>
		/// <value>The given supported Language</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; set; }



		/// <summary>
		/// The boolean status of if intent classification is supported in this language
		/// </summary>
		/// <value>The boolean status of if intent classification is supported in this language</value>
		[DataMember(Name = "intentClassification", EmitDefaultValue = false)]
		public bool? IntentClassification { get; set; }





		/// <summary>
		/// The supported entity types for this language
		/// </summary>
		/// <value>The supported entity types for this language</value>
		[DataMember(Name = "supportedEntityTypes", EmitDefaultValue = false)]
		public List<string> SupportedEntityTypes { get; set; }



		/// <summary>
		/// The configuration for the supported entity types
		/// </summary>
		/// <value>The configuration for the supported entity types</value>
		[DataMember(Name = "supportedEntityTypeConfiguration", EmitDefaultValue = false)]
		public SupportedEntityTypeStatus SupportedEntityTypeConfiguration { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SupportedLanguagesInfoDefinition {\n");

			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  IntentClassification: ").Append(IntentClassification).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  SupportedEntityTypes: ").Append(SupportedEntityTypes).Append("\n");
			sb.Append("  SupportedEntityTypeConfiguration: ").Append(SupportedEntityTypeConfiguration).Append("\n");
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
			return this.Equals(obj as SupportedLanguagesInfoDefinition);
		}

		/// <summary>
		/// Returns true if SupportedLanguagesInfoDefinition instances are equal
		/// </summary>
		/// <param name="other">Instance of SupportedLanguagesInfoDefinition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SupportedLanguagesInfoDefinition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.IntentClassification == other.IntentClassification ||
					this.IntentClassification != null &&
					this.IntentClassification.Equals(other.IntentClassification)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.SupportedEntityTypes == other.SupportedEntityTypes ||
					this.SupportedEntityTypes != null &&
					this.SupportedEntityTypes.SequenceEqual(other.SupportedEntityTypes)
				) &&
				(
					this.SupportedEntityTypeConfiguration == other.SupportedEntityTypeConfiguration ||
					this.SupportedEntityTypeConfiguration != null &&
					this.SupportedEntityTypeConfiguration.Equals(other.SupportedEntityTypeConfiguration)
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

				if (this.IntentClassification != null)
					hash = hash * 59 + this.IntentClassification.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.SupportedEntityTypes != null)
					hash = hash * 59 + this.SupportedEntityTypes.GetHashCode();

				if (this.SupportedEntityTypeConfiguration != null)
					hash = hash * 59 + this.SupportedEntityTypeConfiguration.GetHashCode();

				return hash;
			}
		}
	}

}
