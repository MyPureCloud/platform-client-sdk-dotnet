using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EmailConfig
	/// </summary>
	[DataContract]
	public partial class EmailConfig : IEquatable<EmailConfig>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="EmailConfig" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected EmailConfig() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="EmailConfig" /> class.
		/// </summary>
		/// <param name="EmailColumns">The contact list columns specifying the email address(es) of the contact. (required).</param>
		/// <param name="ContentTemplate">The content template used to formulate the email to send to the contact..</param>
		/// <param name="FromAddress">The email address that will be used as the sender of the email. (required).</param>
		/// <param name="ReplyToAddress">The email address from which any reply will be sent..</param>
		public EmailConfig(List<string> EmailColumns = null, DomainEntityRef ContentTemplate = null, FromEmailAddress FromAddress = null, ReplyToEmailAddress ReplyToAddress = null)
		{
			this.EmailColumns = EmailColumns;
			this.ContentTemplate = ContentTemplate;
			this.FromAddress = FromAddress;
			this.ReplyToAddress = ReplyToAddress;

		}



		/// <summary>
		/// The contact list columns specifying the email address(es) of the contact.
		/// </summary>
		/// <value>The contact list columns specifying the email address(es) of the contact.</value>
		[DataMember(Name = "emailColumns", EmitDefaultValue = false)]
		public List<string> EmailColumns { get; set; }



		/// <summary>
		/// The content template used to formulate the email to send to the contact.
		/// </summary>
		/// <value>The content template used to formulate the email to send to the contact.</value>
		[DataMember(Name = "contentTemplate", EmitDefaultValue = false)]
		public DomainEntityRef ContentTemplate { get; set; }



		/// <summary>
		/// The email address that will be used as the sender of the email.
		/// </summary>
		/// <value>The email address that will be used as the sender of the email.</value>
		[DataMember(Name = "fromAddress", EmitDefaultValue = false)]
		public FromEmailAddress FromAddress { get; set; }



		/// <summary>
		/// The email address from which any reply will be sent.
		/// </summary>
		/// <value>The email address from which any reply will be sent.</value>
		[DataMember(Name = "replyToAddress", EmitDefaultValue = false)]
		public ReplyToEmailAddress ReplyToAddress { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EmailConfig {\n");

			sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
			sb.Append("  ContentTemplate: ").Append(ContentTemplate).Append("\n");
			sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
			sb.Append("  ReplyToAddress: ").Append(ReplyToAddress).Append("\n");
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
			return this.Equals(obj as EmailConfig);
		}

		/// <summary>
		/// Returns true if EmailConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of EmailConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EmailConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EmailColumns == other.EmailColumns ||
					this.EmailColumns != null &&
					this.EmailColumns.SequenceEqual(other.EmailColumns)
				) &&
				(
					this.ContentTemplate == other.ContentTemplate ||
					this.ContentTemplate != null &&
					this.ContentTemplate.Equals(other.ContentTemplate)
				) &&
				(
					this.FromAddress == other.FromAddress ||
					this.FromAddress != null &&
					this.FromAddress.Equals(other.FromAddress)
				) &&
				(
					this.ReplyToAddress == other.ReplyToAddress ||
					this.ReplyToAddress != null &&
					this.ReplyToAddress.Equals(other.ReplyToAddress)
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
				if (this.EmailColumns != null)
					hash = hash * 59 + this.EmailColumns.GetHashCode();

				if (this.ContentTemplate != null)
					hash = hash * 59 + this.ContentTemplate.GetHashCode();

				if (this.FromAddress != null)
					hash = hash * 59 + this.FromAddress.GetHashCode();

				if (this.ReplyToAddress != null)
					hash = hash * 59 + this.ReplyToAddress.GetHashCode();

				return hash;
			}
		}
	}

}
