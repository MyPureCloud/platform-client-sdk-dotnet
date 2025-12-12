using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Details for an mTLS certificate
	/// </summary>
	[DataContract]
	public partial class ActionCertificate : IEquatable<ActionCertificate>
	{
		/// <summary>
		/// The Signing Authority for the certificate
		/// </summary>
		/// <value>The Signing Authority for the certificate</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SigningAuthorityEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Digicert for "DigiCert"
			/// </summary>
			[EnumMember(Value = "DigiCert")]
			Digicert,

			/// <summary>
			/// Enum Genesys for "Genesys"
			/// </summary>
			[EnumMember(Value = "Genesys")]
			Genesys
		}
		/// <summary>
		/// The certificate status
		/// </summary>
		/// <value>The certificate status</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Current for "Current"
			/// </summary>
			[EnumMember(Value = "Current")]
			Current,

			/// <summary>
			/// Enum Upcoming for "Upcoming"
			/// </summary>
			[EnumMember(Value = "Upcoming")]
			Upcoming
		}
		/// <summary>
		/// The certificate type
		/// </summary>
		/// <value>The certificate type</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Client for "Client"
			/// </summary>
			[EnumMember(Value = "Client")]
			Client
		}
		/// <summary>
		/// The Signing Authority for the certificate
		/// </summary>
		/// <value>The Signing Authority for the certificate</value>
		[DataMember(Name = "signingAuthority", EmitDefaultValue = false)]
		public SigningAuthorityEnum? SigningAuthority { get; set; }
		/// <summary>
		/// The certificate status
		/// </summary>
		/// <value>The certificate status</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// The certificate type
		/// </summary>
		/// <value>The certificate type</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ActionCertificate" /> class.
		/// </summary>
		/// <param name="SigningAuthority">The Signing Authority for the certificate.</param>
		/// <param name="Certificate">The certificate string.</param>
		/// <param name="Status">The certificate status.</param>
		/// <param name="Type">The certificate type.</param>
		public ActionCertificate(SigningAuthorityEnum? SigningAuthority = null, string Certificate = null, StatusEnum? Status = null, TypeEnum? Type = null)
		{
			this.SigningAuthority = SigningAuthority;
			this.Certificate = Certificate;
			this.Status = Status;
			this.Type = Type;

		}





		/// <summary>
		/// The certificate string
		/// </summary>
		/// <value>The certificate string</value>
		[DataMember(Name = "certificate", EmitDefaultValue = false)]
		public string Certificate { get; set; }






		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ActionCertificate {\n");

			sb.Append("  SigningAuthority: ").Append(SigningAuthority).Append("\n");
			sb.Append("  Certificate: ").Append(Certificate).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
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
			return this.Equals(obj as ActionCertificate);
		}

		/// <summary>
		/// Returns true if ActionCertificate instances are equal
		/// </summary>
		/// <param name="other">Instance of ActionCertificate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ActionCertificate other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SigningAuthority == other.SigningAuthority ||
					this.SigningAuthority != null &&
					this.SigningAuthority.Equals(other.SigningAuthority)
				) &&
				(
					this.Certificate == other.Certificate ||
					this.Certificate != null &&
					this.Certificate.Equals(other.Certificate)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
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
				if (this.SigningAuthority != null)
					hash = hash * 59 + this.SigningAuthority.GetHashCode();

				if (this.Certificate != null)
					hash = hash * 59 + this.Certificate.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				return hash;
			}
		}
	}

}
