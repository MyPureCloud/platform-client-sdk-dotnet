using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Defines a link between an External Identifier and Authority pair to a Entity Type and Entity Identifier pair. Represents the two way, one to one mapping of an External Authority or System of Record&#39;s identifier to a PureCloud entity. e.g. (ExternalId&#x3D;&#39;05001&#39;,Authority&#x3D;&#39;XyzCRM&#39;) to (entityType&#x3D;user,entityId&#x3D;&#39;8eb03b33-3acb-4bc1-a244-50b9b9f19495&#39;)
	/// </summary>
	[DataContract]
	public partial class UserExternalIdentifier : IEquatable<UserExternalIdentifier>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UserExternalIdentifier" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UserExternalIdentifier() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserExternalIdentifier" /> class.
		/// </summary>
		/// <param name="AuthorityName">Authority or System of Record which owns the External Identifier (required).</param>
		/// <param name="ExternalKey">External Key (required).</param>
		public UserExternalIdentifier(string AuthorityName = null, string ExternalKey = null)
		{
			this.AuthorityName = AuthorityName;
			this.ExternalKey = ExternalKey;

		}



		/// <summary>
		/// Authority or System of Record which owns the External Identifier
		/// </summary>
		/// <value>Authority or System of Record which owns the External Identifier</value>
		[DataMember(Name = "authorityName", EmitDefaultValue = false)]
		public string AuthorityName { get; set; }



		/// <summary>
		/// External Key
		/// </summary>
		/// <value>External Key</value>
		[DataMember(Name = "externalKey", EmitDefaultValue = false)]
		public string ExternalKey { get; set; }



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
			sb.Append("class UserExternalIdentifier {\n");

			sb.Append("  AuthorityName: ").Append(AuthorityName).Append("\n");
			sb.Append("  ExternalKey: ").Append(ExternalKey).Append("\n");
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
			return this.Equals(obj as UserExternalIdentifier);
		}

		/// <summary>
		/// Returns true if UserExternalIdentifier instances are equal
		/// </summary>
		/// <param name="other">Instance of UserExternalIdentifier to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserExternalIdentifier other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AuthorityName == other.AuthorityName ||
					this.AuthorityName != null &&
					this.AuthorityName.Equals(other.AuthorityName)
				) &&
				(
					this.ExternalKey == other.ExternalKey ||
					this.ExternalKey != null &&
					this.ExternalKey.Equals(other.ExternalKey)
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
				if (this.AuthorityName != null)
					hash = hash * 59 + this.AuthorityName.GetHashCode();

				if (this.ExternalKey != null)
					hash = hash * 59 + this.ExternalKey.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
