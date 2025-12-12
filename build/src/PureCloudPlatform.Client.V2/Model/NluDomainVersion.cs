using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// NluDomainVersion
	/// </summary>
	[DataContract]
	public partial class NluDomainVersion : IEquatable<NluDomainVersion>
	{
		/// <summary>
		/// The training status of the NLU domain version.
		/// </summary>
		/// <value>The training status of the NLU domain version.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TrainingStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Untrained for "Untrained"
			/// </summary>
			[EnumMember(Value = "Untrained")]
			Untrained,

			/// <summary>
			/// Enum Training for "Training"
			/// </summary>
			[EnumMember(Value = "Training")]
			Training,

			/// <summary>
			/// Enum Trained for "Trained"
			/// </summary>
			[EnumMember(Value = "Trained")]
			Trained,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// The evaluation status of the NLU domain version.
		/// </summary>
		/// <value>The evaluation status of the NLU domain version.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EvaluationStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unevaluated for "Unevaluated"
			/// </summary>
			[EnumMember(Value = "Unevaluated")]
			Unevaluated,

			/// <summary>
			/// Enum Evaluating for "Evaluating"
			/// </summary>
			[EnumMember(Value = "Evaluating")]
			Evaluating,

			/// <summary>
			/// Enum Evaluated for "Evaluated"
			/// </summary>
			[EnumMember(Value = "Evaluated")]
			Evaluated,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// The training status of the NLU domain version.
		/// </summary>
		/// <value>The training status of the NLU domain version.</value>
		[DataMember(Name = "trainingStatus", EmitDefaultValue = false)]
		public TrainingStatusEnum? TrainingStatus { get; private set; }
		/// <summary>
		/// The evaluation status of the NLU domain version.
		/// </summary>
		/// <value>The evaluation status of the NLU domain version.</value>
		[DataMember(Name = "evaluationStatus", EmitDefaultValue = false)]
		public EvaluationStatusEnum? EvaluationStatus { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="NluDomainVersion" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected NluDomainVersion() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="NluDomainVersion" /> class.
		/// </summary>
		/// <param name="Description">The description of the NLU domain version..</param>
		/// <param name="Language">The language that the NLU domain version supports. (required).</param>
		/// <param name="Intents">The intents defined for this NLU domain version..</param>
		/// <param name="EntityTypes">The entity types defined for this NLU domain version..</param>
		/// <param name="Entities">The entities defined for this NLU domain version.This field is mutually exclusive with entityTypeBindings.</param>
		public NluDomainVersion(string Description = null, string Language = null, List<IntentDefinition> Intents = null, List<NamedEntityTypeDefinition> EntityTypes = null, List<NamedEntityDefinition> Entities = null)
		{
			this.Description = Description;
			this.Language = Language;
			this.Intents = Intents;
			this.EntityTypes = EntityTypes;
			this.Entities = Entities;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The NLU domain of the version.
		/// </summary>
		/// <value>The NLU domain of the version.</value>
		[DataMember(Name = "domain", EmitDefaultValue = false)]
		public NluDomain Domain { get; private set; }



		/// <summary>
		/// The description of the NLU domain version.
		/// </summary>
		/// <value>The description of the NLU domain version.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The language that the NLU domain version supports.
		/// </summary>
		/// <value>The language that the NLU domain version supports.</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; set; }



		/// <summary>
		/// Whether this NLU domain version has been published.
		/// </summary>
		/// <value>Whether this NLU domain version has been published.</value>
		[DataMember(Name = "published", EmitDefaultValue = false)]
		public bool? Published { get; private set; }



		/// <summary>
		/// The date when the NLU domain version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date when the NLU domain version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// The date when the NLU domain version was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date when the NLU domain version was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// The date when the NLU domain version was trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date when the NLU domain version was trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateTrained", EmitDefaultValue = false)]
		public DateTime? DateTrained { get; private set; }



		/// <summary>
		/// The date when the NLU domain version was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date when the NLU domain version was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "datePublished", EmitDefaultValue = false)]
		public DateTime? DatePublished { get; private set; }







		/// <summary>
		/// The intents defined for this NLU domain version.
		/// </summary>
		/// <value>The intents defined for this NLU domain version.</value>
		[DataMember(Name = "intents", EmitDefaultValue = false)]
		public List<IntentDefinition> Intents { get; set; }



		/// <summary>
		/// The entity types defined for this NLU domain version.
		/// </summary>
		/// <value>The entity types defined for this NLU domain version.</value>
		[DataMember(Name = "entityTypes", EmitDefaultValue = false)]
		public List<NamedEntityTypeDefinition> EntityTypes { get; set; }



		/// <summary>
		/// The entities defined for this NLU domain version.This field is mutually exclusive with entityTypeBindings
		/// </summary>
		/// <value>The entities defined for this NLU domain version.This field is mutually exclusive with entityTypeBindings</value>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<NamedEntityDefinition> Entities { get; set; }



		/// <summary>
		/// Map of language code to NLU domain version UUID for multilingual domains.
		/// </summary>
		/// <value>Map of language code to NLU domain version UUID for multilingual domains.</value>
		[DataMember(Name = "languageVersions", EmitDefaultValue = false)]
		public Dictionary<string, string> LanguageVersions { get; private set; }



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
			sb.Append("class NluDomainVersion {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Domain: ").Append(Domain).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  Published: ").Append(Published).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  DateTrained: ").Append(DateTrained).Append("\n");
			sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
			sb.Append("  TrainingStatus: ").Append(TrainingStatus).Append("\n");
			sb.Append("  EvaluationStatus: ").Append(EvaluationStatus).Append("\n");
			sb.Append("  Intents: ").Append(Intents).Append("\n");
			sb.Append("  EntityTypes: ").Append(EntityTypes).Append("\n");
			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  LanguageVersions: ").Append(LanguageVersions).Append("\n");
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
			return this.Equals(obj as NluDomainVersion);
		}

		/// <summary>
		/// Returns true if NluDomainVersion instances are equal
		/// </summary>
		/// <param name="other">Instance of NluDomainVersion to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NluDomainVersion other)
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
					this.Domain == other.Domain ||
					this.Domain != null &&
					this.Domain.Equals(other.Domain)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.Published == other.Published ||
					this.Published != null &&
					this.Published.Equals(other.Published)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.DateTrained == other.DateTrained ||
					this.DateTrained != null &&
					this.DateTrained.Equals(other.DateTrained)
				) &&
				(
					this.DatePublished == other.DatePublished ||
					this.DatePublished != null &&
					this.DatePublished.Equals(other.DatePublished)
				) &&
				(
					this.TrainingStatus == other.TrainingStatus ||
					this.TrainingStatus != null &&
					this.TrainingStatus.Equals(other.TrainingStatus)
				) &&
				(
					this.EvaluationStatus == other.EvaluationStatus ||
					this.EvaluationStatus != null &&
					this.EvaluationStatus.Equals(other.EvaluationStatus)
				) &&
				(
					this.Intents == other.Intents ||
					this.Intents != null &&
					this.Intents.SequenceEqual(other.Intents)
				) &&
				(
					this.EntityTypes == other.EntityTypes ||
					this.EntityTypes != null &&
					this.EntityTypes.SequenceEqual(other.EntityTypes)
				) &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
				) &&
				(
					this.LanguageVersions == other.LanguageVersions ||
					this.LanguageVersions != null &&
					this.LanguageVersions.SequenceEqual(other.LanguageVersions)
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

				if (this.Domain != null)
					hash = hash * 59 + this.Domain.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.Published != null)
					hash = hash * 59 + this.Published.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.DateTrained != null)
					hash = hash * 59 + this.DateTrained.GetHashCode();

				if (this.DatePublished != null)
					hash = hash * 59 + this.DatePublished.GetHashCode();

				if (this.TrainingStatus != null)
					hash = hash * 59 + this.TrainingStatus.GetHashCode();

				if (this.EvaluationStatus != null)
					hash = hash * 59 + this.EvaluationStatus.GetHashCode();

				if (this.Intents != null)
					hash = hash * 59 + this.Intents.GetHashCode();

				if (this.EntityTypes != null)
					hash = hash * 59 + this.EntityTypes.GetHashCode();

				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.LanguageVersions != null)
					hash = hash * 59 + this.LanguageVersions.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
