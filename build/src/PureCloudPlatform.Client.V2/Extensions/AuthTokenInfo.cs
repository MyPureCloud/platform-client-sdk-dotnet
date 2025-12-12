using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Extensions
{
	/// <summary>
	/// Contains information about the access token from the authorization code OAuth flow
	/// </summary>
	[DataContract]
	public partial class AuthTokenInfo : IEquatable<AuthTokenInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthTokenInfo" /> class.
		/// </summary>
		public AuthTokenInfo()
		{

		}

		///<Summary>
		/// Access Token
		///</Summary>
		[DataMember(Name = "access_token", EmitDefaultValue = false)]
		public string AccessToken { get; set; }

		///<Summary>
		/// Refresh Token
		///</Summary>
		[DataMember(Name = "refresh_token", EmitDefaultValue = false)]
		public string RefreshToken { get; set; }

		///<Summary>
		/// Token Type
		///</Summary>
		[DataMember(Name = "token_type", EmitDefaultValue = false)]
		public string TokenType { get; set; }

		///<Summary>
		/// Token Expires In
		///</Summary>
		[DataMember(Name = "expires_in", EmitDefaultValue = false)]
		public int? ExpiresIn { get; set; }

		///<Summary>
		/// Error
		///</Summary>
		[DataMember(Name = "error", EmitDefaultValue = false)]
		public string Error { get; set; }



		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AuthTokenInfo {\n");
			sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
			sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
			sb.Append("  TokenType: ").Append(TokenType).Append("\n");
			sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
			sb.Append("  Error: ").Append(Error).Append("\n");

			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return this.Equals(obj as AuthTokenInfo);
		}

		/// <summary>
		/// Returns true if AuthTokenInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of AuthTokenInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AuthTokenInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return
				(
					this.AccessToken == other.AccessToken ||
					this.AccessToken != null &&
					this.AccessToken.Equals(other.AccessToken)
				) &&
				(
					this.RefreshToken == other.RefreshToken ||
					this.RefreshToken != null &&
					this.RefreshToken.Equals(other.RefreshToken)
				) &&
				(
					this.TokenType == other.TokenType ||
					this.TokenType != null &&
					this.TokenType.Equals(other.TokenType)
				) &&
				(
					this.ExpiresIn == other.ExpiresIn ||
					this.ExpiresIn != null &&
					this.ExpiresIn.Equals(other.ExpiresIn)
				) &&
				(
					this.Error == other.Error ||
					this.Error != null &&
					this.Error.Equals(other.Error)
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

				if (this.AccessToken != null)
					hash = hash * 59 + this.AccessToken.GetHashCode();

				if (this.RefreshToken != null)
					hash = hash * 59 + this.RefreshToken.GetHashCode();

				if (this.TokenType != null)
					hash = hash * 59 + this.TokenType.GetHashCode();

				if (this.ExpiresIn != null)
					hash = hash * 59 + this.ExpiresIn.GetHashCode();

				if (this.Error != null)
					hash = hash * 59 + this.Error.GetHashCode();

				return hash;
			}
		}
	}
}
