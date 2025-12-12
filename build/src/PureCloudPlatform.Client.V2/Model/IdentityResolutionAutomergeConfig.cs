using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// IdentityResolutionAutomergeConfig
	/// </summary>
	[DataContract]
	public partial class IdentityResolutionAutomergeConfig : IEquatable<IdentityResolutionAutomergeConfig>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="IdentityResolutionAutomergeConfig" /> class.
		/// </summary>
		/// <param name="AuthenticatedWebMessaging">Whether automerging is enabled for Authenticated Webmessaging conversations in this channel..</param>
		public IdentityResolutionAutomergeConfig(bool? AuthenticatedWebMessaging = null)
		{
			this.AuthenticatedWebMessaging = AuthenticatedWebMessaging;

		}



		/// <summary>
		/// Whether automerging is enabled for Authenticated Webmessaging conversations in this channel.
		/// </summary>
		/// <value>Whether automerging is enabled for Authenticated Webmessaging conversations in this channel.</value>
		[DataMember(Name = "authenticatedWebMessaging", EmitDefaultValue = false)]
		public bool? AuthenticatedWebMessaging { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class IdentityResolutionAutomergeConfig {\n");

			sb.Append("  AuthenticatedWebMessaging: ").Append(AuthenticatedWebMessaging).Append("\n");
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
			return this.Equals(obj as IdentityResolutionAutomergeConfig);
		}

		/// <summary>
		/// Returns true if IdentityResolutionAutomergeConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of IdentityResolutionAutomergeConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IdentityResolutionAutomergeConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AuthenticatedWebMessaging == other.AuthenticatedWebMessaging ||
					this.AuthenticatedWebMessaging != null &&
					this.AuthenticatedWebMessaging.Equals(other.AuthenticatedWebMessaging)
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
				if (this.AuthenticatedWebMessaging != null)
					hash = hash * 59 + this.AuthenticatedWebMessaging.GetHashCode();

				return hash;
			}
		}
	}

}
