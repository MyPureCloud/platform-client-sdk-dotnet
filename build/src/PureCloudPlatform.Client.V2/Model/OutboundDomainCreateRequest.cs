using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OutboundDomainCreateRequest
	/// </summary>
	[DataContract]
	public partial class OutboundDomainCreateRequest : IEquatable<OutboundDomainCreateRequest>
	{
		/// <summary>
		/// Sender Type
		/// </summary>
		/// <value>Sender Type</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SenderTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Emaildomain for "EmailDomain"
			/// </summary>
			[EnumMember(Value = "EmailDomain")]
			Emaildomain,

			/// <summary>
			/// Enum Mockemaildomain for "MockEmailDomain"
			/// </summary>
			[EnumMember(Value = "MockEmailDomain")]
			Mockemaildomain,

			/// <summary>
			/// Enum Emailsmtpdomain for "EmailSmtpDomain"
			/// </summary>
			[EnumMember(Value = "EmailSmtpDomain")]
			Emailsmtpdomain
		}
		/// <summary>
		/// Sender Type
		/// </summary>
		/// <value>Sender Type</value>
		[DataMember(Name = "senderType", EmitDefaultValue = false)]
		public SenderTypeEnum? SenderType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="OutboundDomainCreateRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OutboundDomainCreateRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OutboundDomainCreateRequest" /> class.
		/// </summary>
		/// <param name="Id">Unique Id of the domain such as: example.com (required).</param>
		/// <param name="SenderType">Sender Type.</param>
		/// <param name="EmailSetting">The email settings to associate with this domain..</param>
		/// <param name="Name">The domain such as: example.com (required).</param>
		public OutboundDomainCreateRequest(string Id = null, SenderTypeEnum? SenderType = null, EmailSettingReference EmailSetting = null, string Name = null)
		{
			this.Id = Id;
			this.SenderType = SenderType;
			this.EmailSetting = EmailSetting;
			this.Name = Name;

		}



		/// <summary>
		/// Unique Id of the domain such as: example.com
		/// </summary>
		/// <value>Unique Id of the domain such as: example.com</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }





		/// <summary>
		/// The email settings to associate with this domain.
		/// </summary>
		/// <value>The email settings to associate with this domain.</value>
		[DataMember(Name = "emailSetting", EmitDefaultValue = false)]
		public EmailSettingReference EmailSetting { get; set; }



		/// <summary>
		/// The domain such as: example.com
		/// </summary>
		/// <value>The domain such as: example.com</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutboundDomainCreateRequest {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  SenderType: ").Append(SenderType).Append("\n");
			sb.Append("  EmailSetting: ").Append(EmailSetting).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
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
			return this.Equals(obj as OutboundDomainCreateRequest);
		}

		/// <summary>
		/// Returns true if OutboundDomainCreateRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of OutboundDomainCreateRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutboundDomainCreateRequest other)
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
					this.SenderType == other.SenderType ||
					this.SenderType != null &&
					this.SenderType.Equals(other.SenderType)
				) &&
				(
					this.EmailSetting == other.EmailSetting ||
					this.EmailSetting != null &&
					this.EmailSetting.Equals(other.EmailSetting)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
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

				if (this.SenderType != null)
					hash = hash * 59 + this.SenderType.GetHashCode();

				if (this.EmailSetting != null)
					hash = hash * 59 + this.EmailSetting.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				return hash;
			}
		}
	}

}
