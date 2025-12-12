using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OrgAuthSettings
	/// </summary>
	[DataContract]
	public partial class OrgAuthSettings : IEquatable<OrgAuthSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OrgAuthSettings" /> class.
		/// </summary>
		/// <param name="MultifactorAuthenticationRequired">Indicates whether multi-factor authentication is required..</param>
		/// <param name="DomainAllowlistEnabled">Indicates whether the domain allowlist is enabled..</param>
		/// <param name="DomainAllowlist">The list of domains that will be allowed to embed Genesys Cloud applications..</param>
		/// <param name="IpAddressAllowlist">The list of IP addresses that will be allowed to authenticate with Genesys Cloud..</param>
		/// <param name="PasswordRequirements">The password requirements for the organization..</param>
		/// <param name="InactivityTimeoutExclusions">The list of exempt apis from inactivity timeout..</param>
		public OrgAuthSettings(bool? MultifactorAuthenticationRequired = null, bool? DomainAllowlistEnabled = null, List<string> DomainAllowlist = null, List<string> IpAddressAllowlist = null, PasswordRequirements PasswordRequirements = null, List<string> InactivityTimeoutExclusions = null)
		{
			this.MultifactorAuthenticationRequired = MultifactorAuthenticationRequired;
			this.DomainAllowlistEnabled = DomainAllowlistEnabled;
			this.DomainAllowlist = DomainAllowlist;
			this.IpAddressAllowlist = IpAddressAllowlist;
			this.PasswordRequirements = PasswordRequirements;
			this.InactivityTimeoutExclusions = InactivityTimeoutExclusions;

		}



		/// <summary>
		/// Indicates whether multi-factor authentication is required.
		/// </summary>
		/// <value>Indicates whether multi-factor authentication is required.</value>
		[DataMember(Name = "multifactorAuthenticationRequired", EmitDefaultValue = false)]
		public bool? MultifactorAuthenticationRequired { get; set; }



		/// <summary>
		/// Indicates whether the domain allowlist is enabled.
		/// </summary>
		/// <value>Indicates whether the domain allowlist is enabled.</value>
		[DataMember(Name = "domainAllowlistEnabled", EmitDefaultValue = false)]
		public bool? DomainAllowlistEnabled { get; set; }



		/// <summary>
		/// The list of domains that will be allowed to embed Genesys Cloud applications.
		/// </summary>
		/// <value>The list of domains that will be allowed to embed Genesys Cloud applications.</value>
		[DataMember(Name = "domainAllowlist", EmitDefaultValue = false)]
		public List<string> DomainAllowlist { get; set; }



		/// <summary>
		/// The list of IP addresses that will be allowed to authenticate with Genesys Cloud.
		/// </summary>
		/// <value>The list of IP addresses that will be allowed to authenticate with Genesys Cloud.</value>
		[DataMember(Name = "ipAddressAllowlist", EmitDefaultValue = false)]
		public List<string> IpAddressAllowlist { get; set; }



		/// <summary>
		/// The password requirements for the organization.
		/// </summary>
		/// <value>The password requirements for the organization.</value>
		[DataMember(Name = "passwordRequirements", EmitDefaultValue = false)]
		public PasswordRequirements PasswordRequirements { get; set; }



		/// <summary>
		/// The list of exempt apis from inactivity timeout.
		/// </summary>
		/// <value>The list of exempt apis from inactivity timeout.</value>
		[DataMember(Name = "inactivityTimeoutExclusions", EmitDefaultValue = false)]
		public List<string> InactivityTimeoutExclusions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OrgAuthSettings {\n");

			sb.Append("  MultifactorAuthenticationRequired: ").Append(MultifactorAuthenticationRequired).Append("\n");
			sb.Append("  DomainAllowlistEnabled: ").Append(DomainAllowlistEnabled).Append("\n");
			sb.Append("  DomainAllowlist: ").Append(DomainAllowlist).Append("\n");
			sb.Append("  IpAddressAllowlist: ").Append(IpAddressAllowlist).Append("\n");
			sb.Append("  PasswordRequirements: ").Append(PasswordRequirements).Append("\n");
			sb.Append("  InactivityTimeoutExclusions: ").Append(InactivityTimeoutExclusions).Append("\n");
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
			return this.Equals(obj as OrgAuthSettings);
		}

		/// <summary>
		/// Returns true if OrgAuthSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of OrgAuthSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OrgAuthSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MultifactorAuthenticationRequired == other.MultifactorAuthenticationRequired ||
					this.MultifactorAuthenticationRequired != null &&
					this.MultifactorAuthenticationRequired.Equals(other.MultifactorAuthenticationRequired)
				) &&
				(
					this.DomainAllowlistEnabled == other.DomainAllowlistEnabled ||
					this.DomainAllowlistEnabled != null &&
					this.DomainAllowlistEnabled.Equals(other.DomainAllowlistEnabled)
				) &&
				(
					this.DomainAllowlist == other.DomainAllowlist ||
					this.DomainAllowlist != null &&
					this.DomainAllowlist.SequenceEqual(other.DomainAllowlist)
				) &&
				(
					this.IpAddressAllowlist == other.IpAddressAllowlist ||
					this.IpAddressAllowlist != null &&
					this.IpAddressAllowlist.SequenceEqual(other.IpAddressAllowlist)
				) &&
				(
					this.PasswordRequirements == other.PasswordRequirements ||
					this.PasswordRequirements != null &&
					this.PasswordRequirements.Equals(other.PasswordRequirements)
				) &&
				(
					this.InactivityTimeoutExclusions == other.InactivityTimeoutExclusions ||
					this.InactivityTimeoutExclusions != null &&
					this.InactivityTimeoutExclusions.SequenceEqual(other.InactivityTimeoutExclusions)
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
				if (this.MultifactorAuthenticationRequired != null)
					hash = hash * 59 + this.MultifactorAuthenticationRequired.GetHashCode();

				if (this.DomainAllowlistEnabled != null)
					hash = hash * 59 + this.DomainAllowlistEnabled.GetHashCode();

				if (this.DomainAllowlist != null)
					hash = hash * 59 + this.DomainAllowlist.GetHashCode();

				if (this.IpAddressAllowlist != null)
					hash = hash * 59 + this.IpAddressAllowlist.GetHashCode();

				if (this.PasswordRequirements != null)
					hash = hash * 59 + this.PasswordRequirements.GetHashCode();

				if (this.InactivityTimeoutExclusions != null)
					hash = hash * 59 + this.InactivityTimeoutExclusions.GetHashCode();

				return hash;
			}
		}
	}

}
