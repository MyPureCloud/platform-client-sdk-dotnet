using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Information about the recipient the message is sent to or received from.
	/// </summary>
	[DataContract]
	public partial class OpenSocialMediaRecipient : IEquatable<OpenSocialMediaRecipient>
	{
		/// <summary>
		/// The recipient ID type. This is used to indicate the format used for the ID.
		/// </summary>
		/// <value>The recipient ID type. This is used to indicate the format used for the ID.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum IdTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Email for "Email"
			/// </summary>
			[EnumMember(Value = "Email")]
			Email,

			/// <summary>
			/// Enum Phone for "Phone"
			/// </summary>
			[EnumMember(Value = "Phone")]
			Phone,

			/// <summary>
			/// Enum Opaque for "Opaque"
			/// </summary>
			[EnumMember(Value = "Opaque")]
			Opaque,

			/// <summary>
			/// Enum Topic for "Topic"
			/// </summary>
			[EnumMember(Value = "Topic")]
			Topic
		}
		/// <summary>
		/// The recipient ID type. This is used to indicate the format used for the ID.
		/// </summary>
		/// <value>The recipient ID type. This is used to indicate the format used for the ID.</value>
		[DataMember(Name = "idType", EmitDefaultValue = false)]
		public IdTypeEnum? IdType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="OpenSocialMediaRecipient" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OpenSocialMediaRecipient() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OpenSocialMediaRecipient" /> class.
		/// </summary>
		/// <param name="Id">The recipient ID specific to the provider. (required).</param>
		/// <param name="IdType">The recipient ID type. This is used to indicate the format used for the ID..</param>
		/// <param name="FirstName">First name of the recipient..</param>
		/// <param name="LastName">Last name of the recipient..</param>
		/// <param name="Nickname">Nickname or display name of the recipient..</param>
		/// <param name="Image">URL of an image that represents the recipient..</param>
		/// <param name="AdditionalIds">List of recipient additional identifiers.</param>
		public OpenSocialMediaRecipient(string Id = null, IdTypeEnum? IdType = null, string FirstName = null, string LastName = null, string Nickname = null, string Image = null, List<OpenSocialMediaRecipientAdditionalIdentifier> AdditionalIds = null)
		{
			this.Id = Id;
			this.IdType = IdType;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Nickname = Nickname;
			this.Image = Image;
			this.AdditionalIds = AdditionalIds;

		}



		/// <summary>
		/// The recipient ID specific to the provider.
		/// </summary>
		/// <value>The recipient ID specific to the provider.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }





		/// <summary>
		/// First name of the recipient.
		/// </summary>
		/// <value>First name of the recipient.</value>
		[DataMember(Name = "firstName", EmitDefaultValue = false)]
		public string FirstName { get; set; }



		/// <summary>
		/// Last name of the recipient.
		/// </summary>
		/// <value>Last name of the recipient.</value>
		[DataMember(Name = "lastName", EmitDefaultValue = false)]
		public string LastName { get; set; }



		/// <summary>
		/// Nickname or display name of the recipient.
		/// </summary>
		/// <value>Nickname or display name of the recipient.</value>
		[DataMember(Name = "nickname", EmitDefaultValue = false)]
		public string Nickname { get; set; }



		/// <summary>
		/// URL of an image that represents the recipient.
		/// </summary>
		/// <value>URL of an image that represents the recipient.</value>
		[DataMember(Name = "image", EmitDefaultValue = false)]
		public string Image { get; set; }



		/// <summary>
		/// List of recipient additional identifiers
		/// </summary>
		/// <value>List of recipient additional identifiers</value>
		[DataMember(Name = "additionalIds", EmitDefaultValue = false)]
		public List<OpenSocialMediaRecipientAdditionalIdentifier> AdditionalIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OpenSocialMediaRecipient {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IdType: ").Append(IdType).Append("\n");
			sb.Append("  FirstName: ").Append(FirstName).Append("\n");
			sb.Append("  LastName: ").Append(LastName).Append("\n");
			sb.Append("  Nickname: ").Append(Nickname).Append("\n");
			sb.Append("  Image: ").Append(Image).Append("\n");
			sb.Append("  AdditionalIds: ").Append(AdditionalIds).Append("\n");
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
			return this.Equals(obj as OpenSocialMediaRecipient);
		}

		/// <summary>
		/// Returns true if OpenSocialMediaRecipient instances are equal
		/// </summary>
		/// <param name="other">Instance of OpenSocialMediaRecipient to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OpenSocialMediaRecipient other)
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
					this.IdType == other.IdType ||
					this.IdType != null &&
					this.IdType.Equals(other.IdType)
				) &&
				(
					this.FirstName == other.FirstName ||
					this.FirstName != null &&
					this.FirstName.Equals(other.FirstName)
				) &&
				(
					this.LastName == other.LastName ||
					this.LastName != null &&
					this.LastName.Equals(other.LastName)
				) &&
				(
					this.Nickname == other.Nickname ||
					this.Nickname != null &&
					this.Nickname.Equals(other.Nickname)
				) &&
				(
					this.Image == other.Image ||
					this.Image != null &&
					this.Image.Equals(other.Image)
				) &&
				(
					this.AdditionalIds == other.AdditionalIds ||
					this.AdditionalIds != null &&
					this.AdditionalIds.SequenceEqual(other.AdditionalIds)
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

				if (this.IdType != null)
					hash = hash * 59 + this.IdType.GetHashCode();

				if (this.FirstName != null)
					hash = hash * 59 + this.FirstName.GetHashCode();

				if (this.LastName != null)
					hash = hash * 59 + this.LastName.GetHashCode();

				if (this.Nickname != null)
					hash = hash * 59 + this.Nickname.GetHashCode();

				if (this.Image != null)
					hash = hash * 59 + this.Image.GetHashCode();

				if (this.AdditionalIds != null)
					hash = hash * 59 + this.AdditionalIds.GetHashCode();

				return hash;
			}
		}
	}

}
