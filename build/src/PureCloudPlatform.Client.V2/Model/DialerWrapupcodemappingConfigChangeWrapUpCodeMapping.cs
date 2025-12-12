using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerWrapupcodemappingConfigChangeWrapUpCodeMapping
	/// </summary>
	[DataContract]
	public partial class DialerWrapupcodemappingConfigChangeWrapUpCodeMapping : IEquatable<DialerWrapupcodemappingConfigChangeWrapUpCodeMapping>
	{
		/// <summary>
		/// Gets or Sets DefaultSet
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DefaultSetEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum ContactUncallable for "CONTACT_UNCALLABLE"
			/// </summary>
			[EnumMember(Value = "CONTACT_UNCALLABLE")]
			ContactUncallable,

			/// <summary>
			/// Enum NumberUncallable for "NUMBER_UNCALLABLE"
			/// </summary>
			[EnumMember(Value = "NUMBER_UNCALLABLE")]
			NumberUncallable,

			/// <summary>
			/// Enum RightPartyContact for "RIGHT_PARTY_CONTACT"
			/// </summary>
			[EnumMember(Value = "RIGHT_PARTY_CONTACT")]
			RightPartyContact
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerWrapupcodemappingConfigChangeWrapUpCodeMapping" /> class.
		/// </summary>
		/// <param name="Id">The globally unique identifier for the object..</param>
		/// <param name="Name">The UI-visible name of the object.</param>
		/// <param name="DateCreated">Creation time of the entity.</param>
		/// <param name="DateModified">Last modified time of the entity.</param>
		/// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
		/// <param name="DefaultSet">DefaultSet.</param>
		/// <param name="Mapping">Mapping.</param>
		public DialerWrapupcodemappingConfigChangeWrapUpCodeMapping(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null, List<DefaultSetEnum> DefaultSet = null, Dictionary<string, List<string>> Mapping = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.Version = Version;
			this.DefaultSet = DefaultSet;
			this.Mapping = Mapping;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The UI-visible name of the object
		/// </summary>
		/// <value>The UI-visible name of the object</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Creation time of the entity
		/// </summary>
		/// <value>Creation time of the entity</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Last modified time of the entity
		/// </summary>
		/// <value>Last modified time of the entity</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// Required for updates, must match the version number of the most recent update
		/// </summary>
		/// <value>Required for updates, must match the version number of the most recent update</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public long? Version { get; set; }



		/// <summary>
		/// Gets or Sets DefaultSet
		/// </summary>
		[DataMember(Name = "defaultSet", EmitDefaultValue = false)]
		public List<DefaultSetEnum> DefaultSet { get; set; }



		/// <summary>
		/// Gets or Sets Mapping
		/// </summary>
		[DataMember(Name = "mapping", EmitDefaultValue = false)]
		public Dictionary<string, List<string>> Mapping { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialerWrapupcodemappingConfigChangeWrapUpCodeMapping {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  DefaultSet: ").Append(DefaultSet).Append("\n");
			sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
			return this.Equals(obj as DialerWrapupcodemappingConfigChangeWrapUpCodeMapping);
		}

		/// <summary>
		/// Returns true if DialerWrapupcodemappingConfigChangeWrapUpCodeMapping instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerWrapupcodemappingConfigChangeWrapUpCodeMapping to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerWrapupcodemappingConfigChangeWrapUpCodeMapping other)
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
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.DefaultSet == other.DefaultSet ||
					this.DefaultSet != null &&
					this.DefaultSet.SequenceEqual(other.DefaultSet)
				) &&
				(
					this.Mapping == other.Mapping ||
					this.Mapping != null &&
					this.Mapping.SequenceEqual(other.Mapping)
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

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.DefaultSet != null)
					hash = hash * 59 + this.DefaultSet.GetHashCode();

				if (this.Mapping != null)
					hash = hash * 59 + this.Mapping.GetHashCode();

				return hash;
			}
		}
	}

}
