using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactImportSettings
	/// </summary>
	[DataContract]
	public partial class ContactImportSettings : IEquatable<ContactImportSettings>
	{
		/// <summary>
		/// Gets or Sets MatchingCriteria
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MatchingCriteriaEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Email for "Email"
			/// </summary>
			[EnumMember(Value = "Email")]
			Email,

			/// <summary>
			/// Enum Phone for "Phone"
			/// </summary>
			[EnumMember(Value = "Phone")]
			Phone
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactImportSettings" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContactImportSettings() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactImportSettings" /> class.
		/// </summary>
		/// <param name="Name">Display name for the settings (required).</param>
		/// <param name="MatchingCriteria">Which fields you want to identity resolution based on. (e.g.: Email, Phone). It can be empty, populated only one of them or it can be both for now. The order of the items is important for identity resolution.</param>
		/// <param name="MergeContacts">Decides what happens when a record already found in the system. Action will be Upsert or Merge (required).</param>
		/// <param name="ExternalSourceId">Define the corresponding source system by the customer, the customer can have different externalId source, they can collect this id from contact service (required).</param>
		/// <param name="ImportFields">Decides which field we need to send towards contact service (required).</param>
		public ContactImportSettings(string Name = null, List<MatchingCriteriaEnum> MatchingCriteria = null, bool? MergeContacts = null, string ExternalSourceId = null, List<ContactImportField> ImportFields = null)
		{
			this.Name = Name;
			this.MatchingCriteria = MatchingCriteria;
			this.MergeContacts = MergeContacts;
			this.ExternalSourceId = ExternalSourceId;
			this.ImportFields = ImportFields;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Display name for the settings
		/// </summary>
		/// <value>Display name for the settings</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Which fields you want to identity resolution based on. (e.g.: Email, Phone). It can be empty, populated only one of them or it can be both for now. The order of the items is important for identity resolution
		/// </summary>
		/// <value>Which fields you want to identity resolution based on. (e.g.: Email, Phone). It can be empty, populated only one of them or it can be both for now. The order of the items is important for identity resolution</value>
		[DataMember(Name = "matchingCriteria", EmitDefaultValue = false)]
		public List<MatchingCriteriaEnum> MatchingCriteria { get; set; }



		/// <summary>
		/// Decides what happens when a record already found in the system. Action will be Upsert or Merge
		/// </summary>
		/// <value>Decides what happens when a record already found in the system. Action will be Upsert or Merge</value>
		[DataMember(Name = "mergeContacts", EmitDefaultValue = false)]
		public bool? MergeContacts { get; set; }



		/// <summary>
		/// Define the corresponding source system by the customer, the customer can have different externalId source, they can collect this id from contact service
		/// </summary>
		/// <value>Define the corresponding source system by the customer, the customer can have different externalId source, they can collect this id from contact service</value>
		[DataMember(Name = "externalSourceId", EmitDefaultValue = false)]
		public string ExternalSourceId { get; set; }



		/// <summary>
		/// Decides which field we need to send towards contact service
		/// </summary>
		/// <value>Decides which field we need to send towards contact service</value>
		[DataMember(Name = "importFields", EmitDefaultValue = false)]
		public List<ContactImportField> ImportFields { get; set; }



		/// <summary>
		/// Creation date for the settings. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Creation date for the settings. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



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
			sb.Append("class ContactImportSettings {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  MatchingCriteria: ").Append(MatchingCriteria).Append("\n");
			sb.Append("  MergeContacts: ").Append(MergeContacts).Append("\n");
			sb.Append("  ExternalSourceId: ").Append(ExternalSourceId).Append("\n");
			sb.Append("  ImportFields: ").Append(ImportFields).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
			return this.Equals(obj as ContactImportSettings);
		}

		/// <summary>
		/// Returns true if ContactImportSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactImportSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactImportSettings other)
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
					this.MatchingCriteria == other.MatchingCriteria ||
					this.MatchingCriteria != null &&
					this.MatchingCriteria.SequenceEqual(other.MatchingCriteria)
				) &&
				(
					this.MergeContacts == other.MergeContacts ||
					this.MergeContacts != null &&
					this.MergeContacts.Equals(other.MergeContacts)
				) &&
				(
					this.ExternalSourceId == other.ExternalSourceId ||
					this.ExternalSourceId != null &&
					this.ExternalSourceId.Equals(other.ExternalSourceId)
				) &&
				(
					this.ImportFields == other.ImportFields ||
					this.ImportFields != null &&
					this.ImportFields.SequenceEqual(other.ImportFields)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
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

				if (this.MatchingCriteria != null)
					hash = hash * 59 + this.MatchingCriteria.GetHashCode();

				if (this.MergeContacts != null)
					hash = hash * 59 + this.MergeContacts.GetHashCode();

				if (this.ExternalSourceId != null)
					hash = hash * 59 + this.ExternalSourceId.GetHashCode();

				if (this.ImportFields != null)
					hash = hash * 59 + this.ImportFields.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
