using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SmsPhoneNumberImport
	/// </summary>
	[DataContract]
	public partial class SmsPhoneNumberImport : IEquatable<SmsPhoneNumberImport>
	{
		/// <summary>
		/// Type of the phone number provisioned.
		/// </summary>
		/// <value>Type of the phone number provisioned.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum PhoneNumberTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Local for "local"
			/// </summary>
			[EnumMember(Value = "local")]
			Local,

			/// <summary>
			/// Enum Mobile for "mobile"
			/// </summary>
			[EnumMember(Value = "mobile")]
			Mobile,

			/// <summary>
			/// Enum Tollfree for "tollfree"
			/// </summary>
			[EnumMember(Value = "tollfree")]
			Tollfree,

			/// <summary>
			/// Enum Shortcode for "shortcode"
			/// </summary>
			[EnumMember(Value = "shortcode")]
			Shortcode
		}
		/// <summary>
		/// Type of the phone number provisioned.
		/// </summary>
		/// <value>Type of the phone number provisioned.</value>
		[DataMember(Name = "phoneNumberType", EmitDefaultValue = false)]
		public PhoneNumberTypeEnum? PhoneNumberType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SmsPhoneNumberImport" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SmsPhoneNumberImport() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SmsPhoneNumberImport" /> class.
		/// </summary>
		/// <param name="PhoneNumber">A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234 (required).</param>
		/// <param name="PhoneNumberType">Type of the phone number provisioned. (required).</param>
		/// <param name="CountryCode">The ISO 3166-1 alpha-2 country code of the country this phone number is associated with. (required).</param>
		/// <param name="IntegrationId">The id of the Genesys Cloud integration this phone number belongs to. (required).</param>
		/// <param name="Compliance">Compliance configuration for short codes, including help, stop and opt in..</param>
		/// <param name="SupportedContent">Defines the media SupportedContent profile configured for an MMS capable phone number..</param>
		public SmsPhoneNumberImport(string PhoneNumber = null, PhoneNumberTypeEnum? PhoneNumberType = null, string CountryCode = null, string IntegrationId = null, Compliance Compliance = null, SupportedContentReference SupportedContent = null)
		{
			this.PhoneNumber = PhoneNumber;
			this.PhoneNumberType = PhoneNumberType;
			this.CountryCode = CountryCode;
			this.IntegrationId = IntegrationId;
			this.Compliance = Compliance;
			this.SupportedContent = SupportedContent;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234
		/// </summary>
		/// <value>A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234</value>
		[DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
		public string PhoneNumber { get; set; }





		/// <summary>
		/// The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.
		/// </summary>
		/// <value>The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.</value>
		[DataMember(Name = "countryCode", EmitDefaultValue = false)]
		public string CountryCode { get; set; }



		/// <summary>
		/// The id of the Genesys Cloud integration this phone number belongs to.
		/// </summary>
		/// <value>The id of the Genesys Cloud integration this phone number belongs to.</value>
		[DataMember(Name = "integrationId", EmitDefaultValue = false)]
		public string IntegrationId { get; set; }



		/// <summary>
		/// Compliance configuration for short codes, including help, stop and opt in.
		/// </summary>
		/// <value>Compliance configuration for short codes, including help, stop and opt in.</value>
		[DataMember(Name = "compliance", EmitDefaultValue = false)]
		public Compliance Compliance { get; set; }



		/// <summary>
		/// Defines the media SupportedContent profile configured for an MMS capable phone number.
		/// </summary>
		/// <value>Defines the media SupportedContent profile configured for an MMS capable phone number.</value>
		[DataMember(Name = "supportedContent", EmitDefaultValue = false)]
		public SupportedContentReference SupportedContent { get; set; }



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
			sb.Append("class SmsPhoneNumberImport {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
			sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
			sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
			sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
			sb.Append("  Compliance: ").Append(Compliance).Append("\n");
			sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
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
			return this.Equals(obj as SmsPhoneNumberImport);
		}

		/// <summary>
		/// Returns true if SmsPhoneNumberImport instances are equal
		/// </summary>
		/// <param name="other">Instance of SmsPhoneNumberImport to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SmsPhoneNumberImport other)
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
					this.PhoneNumber == other.PhoneNumber ||
					this.PhoneNumber != null &&
					this.PhoneNumber.Equals(other.PhoneNumber)
				) &&
				(
					this.PhoneNumberType == other.PhoneNumberType ||
					this.PhoneNumberType != null &&
					this.PhoneNumberType.Equals(other.PhoneNumberType)
				) &&
				(
					this.CountryCode == other.CountryCode ||
					this.CountryCode != null &&
					this.CountryCode.Equals(other.CountryCode)
				) &&
				(
					this.IntegrationId == other.IntegrationId ||
					this.IntegrationId != null &&
					this.IntegrationId.Equals(other.IntegrationId)
				) &&
				(
					this.Compliance == other.Compliance ||
					this.Compliance != null &&
					this.Compliance.Equals(other.Compliance)
				) &&
				(
					this.SupportedContent == other.SupportedContent ||
					this.SupportedContent != null &&
					this.SupportedContent.Equals(other.SupportedContent)
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

				if (this.PhoneNumber != null)
					hash = hash * 59 + this.PhoneNumber.GetHashCode();

				if (this.PhoneNumberType != null)
					hash = hash * 59 + this.PhoneNumberType.GetHashCode();

				if (this.CountryCode != null)
					hash = hash * 59 + this.CountryCode.GetHashCode();

				if (this.IntegrationId != null)
					hash = hash * 59 + this.IntegrationId.GetHashCode();

				if (this.Compliance != null)
					hash = hash * 59 + this.Compliance.GetHashCode();

				if (this.SupportedContent != null)
					hash = hash * 59 + this.SupportedContent.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
