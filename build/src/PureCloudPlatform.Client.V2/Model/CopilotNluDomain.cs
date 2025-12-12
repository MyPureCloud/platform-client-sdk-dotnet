using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CopilotNluDomain
	/// </summary>
	[DataContract]
	public partial class CopilotNluDomain : IEquatable<CopilotNluDomain>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CopilotNluDomain" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CopilotNluDomain() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CopilotNluDomain" /> class.
		/// </summary>
		/// <param name="Id">Id of the NLU domain. (required).</param>
		/// <param name="UseLatestVersion">Use the latest version of the NLU domain. If false, version is required. (required).</param>
		/// <param name="Version">NLU domain version..</param>
		public CopilotNluDomain(string Id = null, bool? UseLatestVersion = null, CopilotNluDomainVersion Version = null)
		{
			this.Id = Id;
			this.UseLatestVersion = UseLatestVersion;
			this.Version = Version;

		}



		/// <summary>
		/// Id of the NLU domain.
		/// </summary>
		/// <value>Id of the NLU domain.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Use the latest version of the NLU domain. If false, version is required.
		/// </summary>
		/// <value>Use the latest version of the NLU domain. If false, version is required.</value>
		[DataMember(Name = "useLatestVersion", EmitDefaultValue = false)]
		public bool? UseLatestVersion { get; set; }



		/// <summary>
		/// NLU domain version.
		/// </summary>
		/// <value>NLU domain version.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public CopilotNluDomainVersion Version { get; set; }



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
			sb.Append("class CopilotNluDomain {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  UseLatestVersion: ").Append(UseLatestVersion).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
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
			return this.Equals(obj as CopilotNluDomain);
		}

		/// <summary>
		/// Returns true if CopilotNluDomain instances are equal
		/// </summary>
		/// <param name="other">Instance of CopilotNluDomain to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CopilotNluDomain other)
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
					this.UseLatestVersion == other.UseLatestVersion ||
					this.UseLatestVersion != null &&
					this.UseLatestVersion.Equals(other.UseLatestVersion)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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

				if (this.UseLatestVersion != null)
					hash = hash * 59 + this.UseLatestVersion.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
