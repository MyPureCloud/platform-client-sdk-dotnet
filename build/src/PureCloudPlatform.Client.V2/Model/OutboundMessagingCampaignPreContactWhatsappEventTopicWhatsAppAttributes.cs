using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes
	/// </summary>
	[DataContract]
	public partial class OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes : IEquatable<OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes" /> class.
		/// </summary>
		/// <param name="ContactPhoneNumber">ContactPhoneNumber.</param>
		/// <param name="ContactWhatsAppColumnName">ContactWhatsAppColumnName.</param>
		/// <param name="WhatsAppIntegrationId">WhatsAppIntegrationId.</param>
		public OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes(string ContactPhoneNumber = null, string ContactWhatsAppColumnName = null, string WhatsAppIntegrationId = null)
		{
			this.ContactPhoneNumber = ContactPhoneNumber;
			this.ContactWhatsAppColumnName = ContactWhatsAppColumnName;
			this.WhatsAppIntegrationId = WhatsAppIntegrationId;

		}



		/// <summary>
		/// Gets or Sets ContactPhoneNumber
		/// </summary>
		[DataMember(Name = "contactPhoneNumber", EmitDefaultValue = false)]
		public string ContactPhoneNumber { get; set; }



		/// <summary>
		/// Gets or Sets ContactWhatsAppColumnName
		/// </summary>
		[DataMember(Name = "contactWhatsAppColumnName", EmitDefaultValue = false)]
		public string ContactWhatsAppColumnName { get; set; }



		/// <summary>
		/// Gets or Sets WhatsAppIntegrationId
		/// </summary>
		[DataMember(Name = "whatsAppIntegrationId", EmitDefaultValue = false)]
		public string WhatsAppIntegrationId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes {\n");

			sb.Append("  ContactPhoneNumber: ").Append(ContactPhoneNumber).Append("\n");
			sb.Append("  ContactWhatsAppColumnName: ").Append(ContactWhatsAppColumnName).Append("\n");
			sb.Append("  WhatsAppIntegrationId: ").Append(WhatsAppIntegrationId).Append("\n");
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
			return this.Equals(obj as OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes);
		}

		/// <summary>
		/// Returns true if OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes instances are equal
		/// </summary>
		/// <param name="other">Instance of OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutboundMessagingCampaignPreContactWhatsappEventTopicWhatsAppAttributes other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ContactPhoneNumber == other.ContactPhoneNumber ||
					this.ContactPhoneNumber != null &&
					this.ContactPhoneNumber.Equals(other.ContactPhoneNumber)
				) &&
				(
					this.ContactWhatsAppColumnName == other.ContactWhatsAppColumnName ||
					this.ContactWhatsAppColumnName != null &&
					this.ContactWhatsAppColumnName.Equals(other.ContactWhatsAppColumnName)
				) &&
				(
					this.WhatsAppIntegrationId == other.WhatsAppIntegrationId ||
					this.WhatsAppIntegrationId != null &&
					this.WhatsAppIntegrationId.Equals(other.WhatsAppIntegrationId)
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
				if (this.ContactPhoneNumber != null)
					hash = hash * 59 + this.ContactPhoneNumber.GetHashCode();

				if (this.ContactWhatsAppColumnName != null)
					hash = hash * 59 + this.ContactWhatsAppColumnName.GetHashCode();

				if (this.WhatsAppIntegrationId != null)
					hash = hash * 59 + this.WhatsAppIntegrationId.GetHashCode();

				return hash;
			}
		}
	}

}
