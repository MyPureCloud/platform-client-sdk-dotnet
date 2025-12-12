using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactCallbackRequest
	/// </summary>
	[DataContract]
	public partial class ContactCallbackRequest : IEquatable<ContactCallbackRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactCallbackRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContactCallbackRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactCallbackRequest" /> class.
		/// </summary>
		/// <param name="CampaignId">Campaign identifier (required).</param>
		/// <param name="ContactListId">Contact list identifier (required).</param>
		/// <param name="ContactId">Contact identifier (required).</param>
		/// <param name="PhoneColumn">Name of the phone column containing the number to be called (required).</param>
		/// <param name="Schedule">The scheduled time for the callback as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ\&quot;, example &#x3D; \&quot;2016-01-02T16:59:59\&quot; (required).</param>
		public ContactCallbackRequest(string CampaignId = null, string ContactListId = null, string ContactId = null, string PhoneColumn = null, string Schedule = null)
		{
			this.CampaignId = CampaignId;
			this.ContactListId = ContactListId;
			this.ContactId = ContactId;
			this.PhoneColumn = PhoneColumn;
			this.Schedule = Schedule;

		}



		/// <summary>
		/// Campaign identifier
		/// </summary>
		/// <value>Campaign identifier</value>
		[DataMember(Name = "campaignId", EmitDefaultValue = false)]
		public string CampaignId { get; set; }



		/// <summary>
		/// Contact list identifier
		/// </summary>
		/// <value>Contact list identifier</value>
		[DataMember(Name = "contactListId", EmitDefaultValue = false)]
		public string ContactListId { get; set; }



		/// <summary>
		/// Contact identifier
		/// </summary>
		/// <value>Contact identifier</value>
		[DataMember(Name = "contactId", EmitDefaultValue = false)]
		public string ContactId { get; set; }



		/// <summary>
		/// Name of the phone column containing the number to be called
		/// </summary>
		/// <value>Name of the phone column containing the number to be called</value>
		[DataMember(Name = "phoneColumn", EmitDefaultValue = false)]
		public string PhoneColumn { get; set; }



		/// <summary>
		/// The scheduled time for the callback as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ\&quot;, example &#x3D; \&quot;2016-01-02T16:59:59\&quot;
		/// </summary>
		/// <value>The scheduled time for the callback as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ\&quot;, example &#x3D; \&quot;2016-01-02T16:59:59\&quot;</value>
		[DataMember(Name = "schedule", EmitDefaultValue = false)]
		public string Schedule { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContactCallbackRequest {\n");

			sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
			sb.Append("  ContactListId: ").Append(ContactListId).Append("\n");
			sb.Append("  ContactId: ").Append(ContactId).Append("\n");
			sb.Append("  PhoneColumn: ").Append(PhoneColumn).Append("\n");
			sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
			return this.Equals(obj as ContactCallbackRequest);
		}

		/// <summary>
		/// Returns true if ContactCallbackRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactCallbackRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactCallbackRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.CampaignId == other.CampaignId ||
					this.CampaignId != null &&
					this.CampaignId.Equals(other.CampaignId)
				) &&
				(
					this.ContactListId == other.ContactListId ||
					this.ContactListId != null &&
					this.ContactListId.Equals(other.ContactListId)
				) &&
				(
					this.ContactId == other.ContactId ||
					this.ContactId != null &&
					this.ContactId.Equals(other.ContactId)
				) &&
				(
					this.PhoneColumn == other.PhoneColumn ||
					this.PhoneColumn != null &&
					this.PhoneColumn.Equals(other.PhoneColumn)
				) &&
				(
					this.Schedule == other.Schedule ||
					this.Schedule != null &&
					this.Schedule.Equals(other.Schedule)
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
				if (this.CampaignId != null)
					hash = hash * 59 + this.CampaignId.GetHashCode();

				if (this.ContactListId != null)
					hash = hash * 59 + this.ContactListId.GetHashCode();

				if (this.ContactId != null)
					hash = hash * 59 + this.ContactId.GetHashCode();

				if (this.PhoneColumn != null)
					hash = hash * 59 + this.PhoneColumn.GetHashCode();

				if (this.Schedule != null)
					hash = hash * 59 + this.Schedule.GetHashCode();

				return hash;
			}
		}
	}

}
