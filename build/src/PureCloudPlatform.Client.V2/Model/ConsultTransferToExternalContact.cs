using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConsultTransferToExternalContact
	/// </summary>
	[DataContract]
	public partial class ConsultTransferToExternalContact : IEquatable<ConsultTransferToExternalContact>
	{
		/// <summary>
		/// Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION
		/// </summary>
		/// <value>Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SpeakToEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Destination for "DESTINATION"
			/// </summary>
			[EnumMember(Value = "DESTINATION")]
			Destination,

			/// <summary>
			/// Enum Object for "OBJECT"
			/// </summary>
			[EnumMember(Value = "OBJECT")]
			Object,

			/// <summary>
			/// Enum Both for "BOTH"
			/// </summary>
			[EnumMember(Value = "BOTH")]
			Both,

			/// <summary>
			/// Enum Conference for "CONFERENCE"
			/// </summary>
			[EnumMember(Value = "CONFERENCE")]
			Conference
		}
		/// <summary>
		/// The external contact phone type.
		/// </summary>
		/// <value>The external contact phone type.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum PhoneTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Workphone for "WorkPhone"
			/// </summary>
			[EnumMember(Value = "WorkPhone")]
			Workphone,

			/// <summary>
			/// Enum Cellphone for "CellPhone"
			/// </summary>
			[EnumMember(Value = "CellPhone")]
			Cellphone,

			/// <summary>
			/// Enum Homephone for "HomePhone"
			/// </summary>
			[EnumMember(Value = "HomePhone")]
			Homephone,

			/// <summary>
			/// Enum Otherphone for "OtherPhone"
			/// </summary>
			[EnumMember(Value = "OtherPhone")]
			Otherphone
		}
		/// <summary>
		/// Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION
		/// </summary>
		/// <value>Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION</value>
		[DataMember(Name = "speakTo", EmitDefaultValue = false)]
		public SpeakToEnum? SpeakTo { get; set; }
		/// <summary>
		/// The external contact phone type.
		/// </summary>
		/// <value>The external contact phone type.</value>
		[DataMember(Name = "phoneType", EmitDefaultValue = false)]
		public PhoneTypeEnum? PhoneType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConsultTransferToExternalContact" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConsultTransferToExternalContact() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConsultTransferToExternalContact" /> class.
		/// </summary>
		/// <param name="SpeakTo">Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION (required).</param>
		/// <param name="ConsultingUserId">The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID.</param>
		/// <param name="ContactId">The external contact id. (required).</param>
		/// <param name="PhoneType">The external contact phone type. (required).</param>
		public ConsultTransferToExternalContact(SpeakToEnum? SpeakTo = null, string ConsultingUserId = null, string ContactId = null, PhoneTypeEnum? PhoneType = null)
		{
			this.SpeakTo = SpeakTo;
			this.ConsultingUserId = ConsultingUserId;
			this.ContactId = ContactId;
			this.PhoneType = PhoneType;

		}





		/// <summary>
		/// The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID
		/// </summary>
		/// <value>The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID</value>
		[DataMember(Name = "consultingUserId", EmitDefaultValue = false)]
		public string ConsultingUserId { get; set; }



		/// <summary>
		/// The external contact id.
		/// </summary>
		/// <value>The external contact id.</value>
		[DataMember(Name = "contactId", EmitDefaultValue = false)]
		public string ContactId { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConsultTransferToExternalContact {\n");

			sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
			sb.Append("  ConsultingUserId: ").Append(ConsultingUserId).Append("\n");
			sb.Append("  ContactId: ").Append(ContactId).Append("\n");
			sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
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
			return this.Equals(obj as ConsultTransferToExternalContact);
		}

		/// <summary>
		/// Returns true if ConsultTransferToExternalContact instances are equal
		/// </summary>
		/// <param name="other">Instance of ConsultTransferToExternalContact to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConsultTransferToExternalContact other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SpeakTo == other.SpeakTo ||
					this.SpeakTo != null &&
					this.SpeakTo.Equals(other.SpeakTo)
				) &&
				(
					this.ConsultingUserId == other.ConsultingUserId ||
					this.ConsultingUserId != null &&
					this.ConsultingUserId.Equals(other.ConsultingUserId)
				) &&
				(
					this.ContactId == other.ContactId ||
					this.ContactId != null &&
					this.ContactId.Equals(other.ContactId)
				) &&
				(
					this.PhoneType == other.PhoneType ||
					this.PhoneType != null &&
					this.PhoneType.Equals(other.PhoneType)
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
				if (this.SpeakTo != null)
					hash = hash * 59 + this.SpeakTo.GetHashCode();

				if (this.ConsultingUserId != null)
					hash = hash * 59 + this.ConsultingUserId.GetHashCode();

				if (this.ContactId != null)
					hash = hash * 59 + this.ContactId.GetHashCode();

				if (this.PhoneType != null)
					hash = hash * 59 + this.PhoneType.GetHashCode();

				return hash;
			}
		}
	}

}
