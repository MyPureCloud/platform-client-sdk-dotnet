using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// An outbound-messaging messaging campaign SMS Config
	/// </summary>
	[DataContract]
	public partial class OutboundMessagingWhatsappCampaignConfigChangeSmsConfig : IEquatable<OutboundMessagingWhatsappCampaignConfigChangeSmsConfig>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OutboundMessagingWhatsappCampaignConfigChangeSmsConfig" /> class.
		/// </summary>
		/// <param name="MessageColumn">The Contact List column specifying the message to send to the contact..</param>
		/// <param name="PhoneColumn">The Contact List column specifying the phone number to send a message to..</param>
		/// <param name="SenderSmsPhoneNumber">SenderSmsPhoneNumber.</param>
		/// <param name="ContentTemplate">ContentTemplate.</param>
		public OutboundMessagingWhatsappCampaignConfigChangeSmsConfig(string MessageColumn = null, string PhoneColumn = null, OutboundMessagingWhatsappCampaignConfigChangeSmsPhoneNumberRef SenderSmsPhoneNumber = null, OutboundMessagingWhatsappCampaignConfigChangeResponseRef ContentTemplate = null)
		{
			this.MessageColumn = MessageColumn;
			this.PhoneColumn = PhoneColumn;
			this.SenderSmsPhoneNumber = SenderSmsPhoneNumber;
			this.ContentTemplate = ContentTemplate;

		}



		/// <summary>
		/// The Contact List column specifying the message to send to the contact.
		/// </summary>
		/// <value>The Contact List column specifying the message to send to the contact.</value>
		[DataMember(Name = "messageColumn", EmitDefaultValue = false)]
		public string MessageColumn { get; set; }



		/// <summary>
		/// The Contact List column specifying the phone number to send a message to.
		/// </summary>
		/// <value>The Contact List column specifying the phone number to send a message to.</value>
		[DataMember(Name = "phoneColumn", EmitDefaultValue = false)]
		public string PhoneColumn { get; set; }



		/// <summary>
		/// Gets or Sets SenderSmsPhoneNumber
		/// </summary>
		[DataMember(Name = "senderSmsPhoneNumber", EmitDefaultValue = false)]
		public OutboundMessagingWhatsappCampaignConfigChangeSmsPhoneNumberRef SenderSmsPhoneNumber { get; set; }



		/// <summary>
		/// Gets or Sets ContentTemplate
		/// </summary>
		[DataMember(Name = "contentTemplate", EmitDefaultValue = false)]
		public OutboundMessagingWhatsappCampaignConfigChangeResponseRef ContentTemplate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutboundMessagingWhatsappCampaignConfigChangeSmsConfig {\n");

			sb.Append("  MessageColumn: ").Append(MessageColumn).Append("\n");
			sb.Append("  PhoneColumn: ").Append(PhoneColumn).Append("\n");
			sb.Append("  SenderSmsPhoneNumber: ").Append(SenderSmsPhoneNumber).Append("\n");
			sb.Append("  ContentTemplate: ").Append(ContentTemplate).Append("\n");
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
			return this.Equals(obj as OutboundMessagingWhatsappCampaignConfigChangeSmsConfig);
		}

		/// <summary>
		/// Returns true if OutboundMessagingWhatsappCampaignConfigChangeSmsConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of OutboundMessagingWhatsappCampaignConfigChangeSmsConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutboundMessagingWhatsappCampaignConfigChangeSmsConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MessageColumn == other.MessageColumn ||
					this.MessageColumn != null &&
					this.MessageColumn.Equals(other.MessageColumn)
				) &&
				(
					this.PhoneColumn == other.PhoneColumn ||
					this.PhoneColumn != null &&
					this.PhoneColumn.Equals(other.PhoneColumn)
				) &&
				(
					this.SenderSmsPhoneNumber == other.SenderSmsPhoneNumber ||
					this.SenderSmsPhoneNumber != null &&
					this.SenderSmsPhoneNumber.Equals(other.SenderSmsPhoneNumber)
				) &&
				(
					this.ContentTemplate == other.ContentTemplate ||
					this.ContentTemplate != null &&
					this.ContentTemplate.Equals(other.ContentTemplate)
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
				if (this.MessageColumn != null)
					hash = hash * 59 + this.MessageColumn.GetHashCode();

				if (this.PhoneColumn != null)
					hash = hash * 59 + this.PhoneColumn.GetHashCode();

				if (this.SenderSmsPhoneNumber != null)
					hash = hash * 59 + this.SenderSmsPhoneNumber.GetHashCode();

				if (this.ContentTemplate != null)
					hash = hash * 59 + this.ContentTemplate.GetHashCode();

				return hash;
			}
		}
	}

}
