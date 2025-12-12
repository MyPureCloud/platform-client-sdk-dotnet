using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// An outbound-messaging messaging campaign WhatsApp Config
	/// </summary>
	[DataContract]
	public partial class OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig : IEquatable<OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig" /> class.
		/// </summary>
		/// <param name="WhatsAppColumns">The Contact List columns specifying the phone number to send a message to..</param>
		/// <param name="Integration">Integration.</param>
		/// <param name="ContentTemplate">A reference for a Response.</param>
		public OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig(List<string> WhatsAppColumns = null, OutboundMessagingMessagingCampaignConfigChangeIntegrationRef Integration = null, OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate = null)
		{
			this.WhatsAppColumns = WhatsAppColumns;
			this.Integration = Integration;
			this.ContentTemplate = ContentTemplate;

		}



		/// <summary>
		/// The Contact List columns specifying the phone number to send a message to.
		/// </summary>
		/// <value>The Contact List columns specifying the phone number to send a message to.</value>
		[DataMember(Name = "whatsAppColumns", EmitDefaultValue = false)]
		public List<string> WhatsAppColumns { get; set; }



		/// <summary>
		/// Gets or Sets Integration
		/// </summary>
		[DataMember(Name = "integration", EmitDefaultValue = false)]
		public OutboundMessagingMessagingCampaignConfigChangeIntegrationRef Integration { get; set; }



		/// <summary>
		/// A reference for a Response
		/// </summary>
		/// <value>A reference for a Response</value>
		[DataMember(Name = "contentTemplate", EmitDefaultValue = false)]
		public OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig {\n");

			sb.Append("  WhatsAppColumns: ").Append(WhatsAppColumns).Append("\n");
			sb.Append("  Integration: ").Append(Integration).Append("\n");
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
			return this.Equals(obj as OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig);
		}

		/// <summary>
		/// Returns true if OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.WhatsAppColumns == other.WhatsAppColumns ||
					this.WhatsAppColumns != null &&
					this.WhatsAppColumns.SequenceEqual(other.WhatsAppColumns)
				) &&
				(
					this.Integration == other.Integration ||
					this.Integration != null &&
					this.Integration.Equals(other.Integration)
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
				if (this.WhatsAppColumns != null)
					hash = hash * 59 + this.WhatsAppColumns.GetHashCode();

				if (this.Integration != null)
					hash = hash * 59 + this.Integration.GetHashCode();

				if (this.ContentTemplate != null)
					hash = hash * 59 + this.ContentTemplate.GetHashCode();

				return hash;
			}
		}
	}

}
