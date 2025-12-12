using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserTokensTopicTokenNotification
	/// </summary>
	[DataContract]
	public partial class UserTokensTopicTokenNotification : IEquatable<UserTokensTopicTokenNotification>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserTokensTopicTokenNotification" /> class.
		/// </summary>
		/// <param name="User">User.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="DateCreated">DateCreated.</param>
		/// <param name="TokenExpirationDate">TokenExpirationDate.</param>
		/// <param name="SessionId">SessionId.</param>
		/// <param name="ClientId">ClientId.</param>
		/// <param name="TokenHash">TokenHash.</param>
		public UserTokensTopicTokenNotification(UserTokensTopicUriReference User = null, string IpAddress = null, string DateCreated = null, string TokenExpirationDate = null, string SessionId = null, string ClientId = null, string TokenHash = null)
		{
			this.User = User;
			this.IpAddress = IpAddress;
			this.DateCreated = DateCreated;
			this.TokenExpirationDate = TokenExpirationDate;
			this.SessionId = SessionId;
			this.ClientId = ClientId;
			this.TokenHash = TokenHash;

		}



		/// <summary>
		/// Gets or Sets User
		/// </summary>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public UserTokensTopicUriReference User { get; set; }



		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public string IpAddress { get; set; }



		/// <summary>
		/// Gets or Sets DateCreated
		/// </summary>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public string DateCreated { get; set; }



		/// <summary>
		/// Gets or Sets TokenExpirationDate
		/// </summary>
		[DataMember(Name = "tokenExpirationDate", EmitDefaultValue = false)]
		public string TokenExpirationDate { get; set; }



		/// <summary>
		/// Gets or Sets SessionId
		/// </summary>
		[DataMember(Name = "sessionId", EmitDefaultValue = false)]
		public string SessionId { get; set; }



		/// <summary>
		/// Gets or Sets ClientId
		/// </summary>
		[DataMember(Name = "clientId", EmitDefaultValue = false)]
		public string ClientId { get; set; }



		/// <summary>
		/// Gets or Sets TokenHash
		/// </summary>
		[DataMember(Name = "tokenHash", EmitDefaultValue = false)]
		public string TokenHash { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserTokensTopicTokenNotification {\n");

			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  TokenExpirationDate: ").Append(TokenExpirationDate).Append("\n");
			sb.Append("  SessionId: ").Append(SessionId).Append("\n");
			sb.Append("  ClientId: ").Append(ClientId).Append("\n");
			sb.Append("  TokenHash: ").Append(TokenHash).Append("\n");
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
			return this.Equals(obj as UserTokensTopicTokenNotification);
		}

		/// <summary>
		/// Returns true if UserTokensTopicTokenNotification instances are equal
		/// </summary>
		/// <param name="other">Instance of UserTokensTopicTokenNotification to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserTokensTopicTokenNotification other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
				) &&
				(
					this.IpAddress == other.IpAddress ||
					this.IpAddress != null &&
					this.IpAddress.Equals(other.IpAddress)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.TokenExpirationDate == other.TokenExpirationDate ||
					this.TokenExpirationDate != null &&
					this.TokenExpirationDate.Equals(other.TokenExpirationDate)
				) &&
				(
					this.SessionId == other.SessionId ||
					this.SessionId != null &&
					this.SessionId.Equals(other.SessionId)
				) &&
				(
					this.ClientId == other.ClientId ||
					this.ClientId != null &&
					this.ClientId.Equals(other.ClientId)
				) &&
				(
					this.TokenHash == other.TokenHash ||
					this.TokenHash != null &&
					this.TokenHash.Equals(other.TokenHash)
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
				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				if (this.IpAddress != null)
					hash = hash * 59 + this.IpAddress.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.TokenExpirationDate != null)
					hash = hash * 59 + this.TokenExpirationDate.GetHashCode();

				if (this.SessionId != null)
					hash = hash * 59 + this.SessionId.GetHashCode();

				if (this.ClientId != null)
					hash = hash * 59 + this.ClientId.GetHashCode();

				if (this.TokenHash != null)
					hash = hash * 59 + this.TokenHash.GetHashCode();

				return hash;
			}
		}
	}

}
