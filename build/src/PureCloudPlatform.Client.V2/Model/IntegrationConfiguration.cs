using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Configuration for an Integration
	/// </summary>
	[DataContract]
	public partial class IntegrationConfiguration : IEquatable<IntegrationConfiguration>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="IntegrationConfiguration" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected IntegrationConfiguration() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="IntegrationConfiguration" /> class.
		/// </summary>
		/// <param name="Name">The name of the integration, used to distinguish this integration from others of the same type. (required).</param>
		/// <param name="Version">Version number required for updates. (required).</param>
		/// <param name="Properties">Key-value configuration settings described by the schema in the propertiesSchemaUri field. (required).</param>
		/// <param name="Advanced">Advanced configuration described by the schema in the advancedSchemaUri field. (required).</param>
		/// <param name="Notes">Notes about the integration. (required).</param>
		/// <param name="Credentials">Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type (required).</param>
		public IntegrationConfiguration(string Name = null, int? Version = null, Object Properties = null, Object Advanced = null, string Notes = null, Dictionary<string, CredentialInfo> Credentials = null)
		{
			this.Name = Name;
			this.Version = Version;
			this.Properties = Properties;
			this.Advanced = Advanced;
			this.Notes = Notes;
			this.Credentials = Credentials;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the integration, used to distinguish this integration from others of the same type.
		/// </summary>
		/// <value>The name of the integration, used to distinguish this integration from others of the same type.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Version number required for updates.
		/// </summary>
		/// <value>Version number required for updates.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; set; }



		/// <summary>
		/// Key-value configuration settings described by the schema in the propertiesSchemaUri field.
		/// </summary>
		/// <value>Key-value configuration settings described by the schema in the propertiesSchemaUri field.</value>
		[DataMember(Name = "properties", EmitDefaultValue = false)]
		public Object Properties { get; set; }



		/// <summary>
		/// Advanced configuration described by the schema in the advancedSchemaUri field.
		/// </summary>
		/// <value>Advanced configuration described by the schema in the advancedSchemaUri field.</value>
		[DataMember(Name = "advanced", EmitDefaultValue = false)]
		public Object Advanced { get; set; }



		/// <summary>
		/// Notes about the integration.
		/// </summary>
		/// <value>Notes about the integration.</value>
		[DataMember(Name = "notes", EmitDefaultValue = false)]
		public string Notes { get; set; }



		/// <summary>
		/// Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type
		/// </summary>
		/// <value>Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type</value>
		[DataMember(Name = "credentials", EmitDefaultValue = false)]
		public Dictionary<string, CredentialInfo> Credentials { get; set; }



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
			sb.Append("class IntegrationConfiguration {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  Properties: ").Append(Properties).Append("\n");
			sb.Append("  Advanced: ").Append(Advanced).Append("\n");
			sb.Append("  Notes: ").Append(Notes).Append("\n");
			sb.Append("  Credentials: ").Append(Credentials).Append("\n");
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
			return this.Equals(obj as IntegrationConfiguration);
		}

		/// <summary>
		/// Returns true if IntegrationConfiguration instances are equal
		/// </summary>
		/// <param name="other">Instance of IntegrationConfiguration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IntegrationConfiguration other)
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
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.Properties == other.Properties ||
					this.Properties != null &&
					this.Properties.Equals(other.Properties)
				) &&
				(
					this.Advanced == other.Advanced ||
					this.Advanced != null &&
					this.Advanced.Equals(other.Advanced)
				) &&
				(
					this.Notes == other.Notes ||
					this.Notes != null &&
					this.Notes.Equals(other.Notes)
				) &&
				(
					this.Credentials == other.Credentials ||
					this.Credentials != null &&
					this.Credentials.SequenceEqual(other.Credentials)
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

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.Properties != null)
					hash = hash * 59 + this.Properties.GetHashCode();

				if (this.Advanced != null)
					hash = hash * 59 + this.Advanced.GetHashCode();

				if (this.Notes != null)
					hash = hash * 59 + this.Notes.GetHashCode();

				if (this.Credentials != null)
					hash = hash * 59 + this.Credentials.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
