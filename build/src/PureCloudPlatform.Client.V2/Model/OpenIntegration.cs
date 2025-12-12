using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OpenIntegration
	/// </summary>
	[DataContract]
	public partial class OpenIntegration : IEquatable<OpenIntegration>
	{
		/// <summary>
		/// Status of asynchronous create operation
		/// </summary>
		/// <value>Status of asynchronous create operation</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum CreateStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Initiated for "Initiated"
			/// </summary>
			[EnumMember(Value = "Initiated")]
			Initiated,

			/// <summary>
			/// Enum Completed for "Completed"
			/// </summary>
			[EnumMember(Value = "Completed")]
			Completed,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// Status of asynchronous create operation
		/// </summary>
		/// <value>Status of asynchronous create operation</value>
		[DataMember(Name = "createStatus", EmitDefaultValue = false)]
		public CreateStatusEnum? CreateStatus { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="OpenIntegration" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OpenIntegration() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OpenIntegration" /> class.
		/// </summary>
		/// <param name="Name">The name of the Open messaging integration. (required).</param>
		/// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
		/// <param name="MessagingSetting">MessagingSetting.</param>
		/// <param name="OutboundNotificationWebhookUrl">The outbound notification webhook URL for the Open messaging integration. (required).</param>
		/// <param name="OutboundNotificationWebhookSignatureSecretToken">The outbound notification webhook signature secret token. (required).</param>
		/// <param name="WebhookHeaders">The user specified headers for the Open messaging integration..</param>
		/// <param name="Status">The status of the Open Integration.</param>
		/// <param name="DateCreated">Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateModified">Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="CreatedBy">User reference that created this Integration.</param>
		/// <param name="ModifiedBy">User reference that last modified this Integration.</param>
		public OpenIntegration(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingReference MessagingSetting = null, string OutboundNotificationWebhookUrl = null, string OutboundNotificationWebhookSignatureSecretToken = null, Dictionary<string, string> WebhookHeaders = null, string Status = null, DateTime? DateCreated = null, DateTime? DateModified = null, DomainEntityRef CreatedBy = null, DomainEntityRef ModifiedBy = null)
		{
			this.Name = Name;
			this.SupportedContent = SupportedContent;
			this.MessagingSetting = MessagingSetting;
			this.OutboundNotificationWebhookUrl = OutboundNotificationWebhookUrl;
			this.OutboundNotificationWebhookSignatureSecretToken = OutboundNotificationWebhookSignatureSecretToken;
			this.WebhookHeaders = WebhookHeaders;
			this.Status = Status;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.CreatedBy = CreatedBy;
			this.ModifiedBy = ModifiedBy;

		}



		/// <summary>
		/// A unique Integration Id.
		/// </summary>
		/// <value>A unique Integration Id.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the Open messaging integration.
		/// </summary>
		/// <value>The name of the Open messaging integration.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Defines the SupportedContent profile configured for an integration
		/// </summary>
		/// <value>Defines the SupportedContent profile configured for an integration</value>
		[DataMember(Name = "supportedContent", EmitDefaultValue = false)]
		public SupportedContentReference SupportedContent { get; set; }



		/// <summary>
		/// Gets or Sets MessagingSetting
		/// </summary>
		[DataMember(Name = "messagingSetting", EmitDefaultValue = false)]
		public MessagingSettingReference MessagingSetting { get; set; }



		/// <summary>
		/// The outbound notification webhook URL for the Open messaging integration.
		/// </summary>
		/// <value>The outbound notification webhook URL for the Open messaging integration.</value>
		[DataMember(Name = "outboundNotificationWebhookUrl", EmitDefaultValue = false)]
		public string OutboundNotificationWebhookUrl { get; set; }



		/// <summary>
		/// The outbound notification webhook signature secret token.
		/// </summary>
		/// <value>The outbound notification webhook signature secret token.</value>
		[DataMember(Name = "outboundNotificationWebhookSignatureSecretToken", EmitDefaultValue = false)]
		public string OutboundNotificationWebhookSignatureSecretToken { get; set; }



		/// <summary>
		/// The user specified headers for the Open messaging integration.
		/// </summary>
		/// <value>The user specified headers for the Open messaging integration.</value>
		[DataMember(Name = "webhookHeaders", EmitDefaultValue = false)]
		public Dictionary<string, string> WebhookHeaders { get; set; }



		/// <summary>
		/// The status of the Open Integration
		/// </summary>
		/// <value>The status of the Open Integration</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string Status { get; set; }



		/// <summary>
		/// The recipient associated to the Open messaging Integration. This recipient is used to associate a flow to an integration
		/// </summary>
		/// <value>The recipient associated to the Open messaging Integration. This recipient is used to associate a flow to an integration</value>
		[DataMember(Name = "recipient", EmitDefaultValue = false)]
		public DomainEntityRef Recipient { get; private set; }



		/// <summary>
		/// Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// User reference that created this Integration
		/// </summary>
		/// <value>User reference that created this Integration</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public DomainEntityRef CreatedBy { get; set; }



		/// <summary>
		/// User reference that last modified this Integration
		/// </summary>
		/// <value>User reference that last modified this Integration</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public DomainEntityRef ModifiedBy { get; set; }





		/// <summary>
		/// Error information returned, if createStatus is set to Error
		/// </summary>
		/// <value>Error information returned, if createStatus is set to Error</value>
		[DataMember(Name = "createError", EmitDefaultValue = false)]
		public ErrorBody CreateError { get; private set; }



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
			sb.Append("class OpenIntegration {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
			sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
			sb.Append("  OutboundNotificationWebhookUrl: ").Append(OutboundNotificationWebhookUrl).Append("\n");
			sb.Append("  OutboundNotificationWebhookSignatureSecretToken: ").Append(OutboundNotificationWebhookSignatureSecretToken).Append("\n");
			sb.Append("  WebhookHeaders: ").Append(WebhookHeaders).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Recipient: ").Append(Recipient).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  CreateStatus: ").Append(CreateStatus).Append("\n");
			sb.Append("  CreateError: ").Append(CreateError).Append("\n");
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
			return this.Equals(obj as OpenIntegration);
		}

		/// <summary>
		/// Returns true if OpenIntegration instances are equal
		/// </summary>
		/// <param name="other">Instance of OpenIntegration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OpenIntegration other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.SupportedContent == other.SupportedContent ||
					this.SupportedContent != null &&
					this.SupportedContent.Equals(other.SupportedContent)
				) &&
				(
					this.MessagingSetting == other.MessagingSetting ||
					this.MessagingSetting != null &&
					this.MessagingSetting.Equals(other.MessagingSetting)
				) &&
				(
					this.OutboundNotificationWebhookUrl == other.OutboundNotificationWebhookUrl ||
					this.OutboundNotificationWebhookUrl != null &&
					this.OutboundNotificationWebhookUrl.Equals(other.OutboundNotificationWebhookUrl)
				) &&
				(
					this.OutboundNotificationWebhookSignatureSecretToken == other.OutboundNotificationWebhookSignatureSecretToken ||
					this.OutboundNotificationWebhookSignatureSecretToken != null &&
					this.OutboundNotificationWebhookSignatureSecretToken.Equals(other.OutboundNotificationWebhookSignatureSecretToken)
				) &&
				(
					this.WebhookHeaders == other.WebhookHeaders ||
					this.WebhookHeaders != null &&
					this.WebhookHeaders.SequenceEqual(other.WebhookHeaders)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Recipient == other.Recipient ||
					this.Recipient != null &&
					this.Recipient.Equals(other.Recipient)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.CreateStatus == other.CreateStatus ||
					this.CreateStatus != null &&
					this.CreateStatus.Equals(other.CreateStatus)
				) &&
				(
					this.CreateError == other.CreateError ||
					this.CreateError != null &&
					this.CreateError.Equals(other.CreateError)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.SupportedContent != null)
					hash = hash * 59 + this.SupportedContent.GetHashCode();

				if (this.MessagingSetting != null)
					hash = hash * 59 + this.MessagingSetting.GetHashCode();

				if (this.OutboundNotificationWebhookUrl != null)
					hash = hash * 59 + this.OutboundNotificationWebhookUrl.GetHashCode();

				if (this.OutboundNotificationWebhookSignatureSecretToken != null)
					hash = hash * 59 + this.OutboundNotificationWebhookSignatureSecretToken.GetHashCode();

				if (this.WebhookHeaders != null)
					hash = hash * 59 + this.WebhookHeaders.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Recipient != null)
					hash = hash * 59 + this.Recipient.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.CreateStatus != null)
					hash = hash * 59 + this.CreateStatus.GetHashCode();

				if (this.CreateError != null)
					hash = hash * 59 + this.CreateError.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
