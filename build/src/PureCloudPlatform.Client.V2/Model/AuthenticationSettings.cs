using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Settings for authenticated webdeployments.
	/// </summary>
	[DataContract]
	public partial class AuthenticationSettings : IEquatable<AuthenticationSettings>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationSettings" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AuthenticationSettings() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationSettings" /> class.
		/// </summary>
		/// <param name="Enabled">Indicate if these auth is required for this deployment. If, for example, this flag is set to true then webmessaging sessions can not send messages unless the end-user is authenticated. (required).</param>
		/// <param name="IntegrationId">The integration identifier which contains the auth settings required on the deployment. (required).</param>
		/// <param name="AllowSessionUpgrade">Allow end-users to upgrade an anonymous session to authenticated conversation..</param>
		public AuthenticationSettings(bool? Enabled = null, string IntegrationId = null, bool? AllowSessionUpgrade = null)
		{
			this.Enabled = Enabled;
			this.IntegrationId = IntegrationId;
			this.AllowSessionUpgrade = AllowSessionUpgrade;

		}



		/// <summary>
		/// Indicate if these auth is required for this deployment. If, for example, this flag is set to true then webmessaging sessions can not send messages unless the end-user is authenticated.
		/// </summary>
		/// <value>Indicate if these auth is required for this deployment. If, for example, this flag is set to true then webmessaging sessions can not send messages unless the end-user is authenticated.</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }



		/// <summary>
		/// The integration identifier which contains the auth settings required on the deployment.
		/// </summary>
		/// <value>The integration identifier which contains the auth settings required on the deployment.</value>
		[DataMember(Name = "integrationId", EmitDefaultValue = false)]
		public string IntegrationId { get; set; }



		/// <summary>
		/// Allow end-users to upgrade an anonymous session to authenticated conversation.
		/// </summary>
		/// <value>Allow end-users to upgrade an anonymous session to authenticated conversation.</value>
		[DataMember(Name = "allowSessionUpgrade", EmitDefaultValue = false)]
		public bool? AllowSessionUpgrade { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AuthenticationSettings {\n");

			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
			sb.Append("  AllowSessionUpgrade: ").Append(AllowSessionUpgrade).Append("\n");
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
			return this.Equals(obj as AuthenticationSettings);
		}

		/// <summary>
		/// Returns true if AuthenticationSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of AuthenticationSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AuthenticationSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
				) &&
				(
					this.IntegrationId == other.IntegrationId ||
					this.IntegrationId != null &&
					this.IntegrationId.Equals(other.IntegrationId)
				) &&
				(
					this.AllowSessionUpgrade == other.AllowSessionUpgrade ||
					this.AllowSessionUpgrade != null &&
					this.AllowSessionUpgrade.Equals(other.AllowSessionUpgrade)
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
				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				if (this.IntegrationId != null)
					hash = hash * 59 + this.IntegrationId.GetHashCode();

				if (this.AllowSessionUpgrade != null)
					hash = hash * 59 + this.AllowSessionUpgrade.GetHashCode();

				return hash;
			}
		}
	}

}
