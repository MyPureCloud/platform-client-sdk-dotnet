using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactListingRequest
	/// </summary>
	[DataContract]
	public partial class ContactListingRequest : IEquatable<ContactListingRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactListingRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContactListingRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactListingRequest" /> class.
		/// </summary>
		/// <param name="ContactListFilterId">Contact List Filter ID..</param>
		/// <param name="Criteria">Criteria to filter the contacts by..</param>
		/// <param name="PageNumber">Page number. (required).</param>
		/// <param name="PageSize">Page size. The max that will be returned is 100. (required).</param>
		/// <param name="ContactSorts">The order in which to sort contacts..</param>
		public ContactListingRequest(string ContactListFilterId = null, ContactBulkSearchCriteria Criteria = null, int? PageNumber = null, int? PageSize = null, List<ContactSort> ContactSorts = null)
		{
			this.ContactListFilterId = ContactListFilterId;
			this.Criteria = Criteria;
			this.PageNumber = PageNumber;
			this.PageSize = PageSize;
			this.ContactSorts = ContactSorts;

		}



		/// <summary>
		/// Contact List Filter ID.
		/// </summary>
		/// <value>Contact List Filter ID.</value>
		[DataMember(Name = "contactListFilterId", EmitDefaultValue = false)]
		public string ContactListFilterId { get; set; }



		/// <summary>
		/// Criteria to filter the contacts by.
		/// </summary>
		/// <value>Criteria to filter the contacts by.</value>
		[DataMember(Name = "criteria", EmitDefaultValue = false)]
		public ContactBulkSearchCriteria Criteria { get; set; }



		/// <summary>
		/// Page number.
		/// </summary>
		/// <value>Page number.</value>
		[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
		public int? PageNumber { get; set; }



		/// <summary>
		/// Page size. The max that will be returned is 100.
		/// </summary>
		/// <value>Page size. The max that will be returned is 100.</value>
		[DataMember(Name = "pageSize", EmitDefaultValue = false)]
		public int? PageSize { get; set; }



		/// <summary>
		/// The order in which to sort contacts.
		/// </summary>
		/// <value>The order in which to sort contacts.</value>
		[DataMember(Name = "contactSorts", EmitDefaultValue = false)]
		public List<ContactSort> ContactSorts { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContactListingRequest {\n");

			sb.Append("  ContactListFilterId: ").Append(ContactListFilterId).Append("\n");
			sb.Append("  Criteria: ").Append(Criteria).Append("\n");
			sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
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
			return this.Equals(obj as ContactListingRequest);
		}

		/// <summary>
		/// Returns true if ContactListingRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactListingRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactListingRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ContactListFilterId == other.ContactListFilterId ||
					this.ContactListFilterId != null &&
					this.ContactListFilterId.Equals(other.ContactListFilterId)
				) &&
				(
					this.Criteria == other.Criteria ||
					this.Criteria != null &&
					this.Criteria.Equals(other.Criteria)
				) &&
				(
					this.PageNumber == other.PageNumber ||
					this.PageNumber != null &&
					this.PageNumber.Equals(other.PageNumber)
				) &&
				(
					this.PageSize == other.PageSize ||
					this.PageSize != null &&
					this.PageSize.Equals(other.PageSize)
				) &&
				(
					this.ContactSorts == other.ContactSorts ||
					this.ContactSorts != null &&
					this.ContactSorts.SequenceEqual(other.ContactSorts)
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
				if (this.ContactListFilterId != null)
					hash = hash * 59 + this.ContactListFilterId.GetHashCode();

				if (this.Criteria != null)
					hash = hash * 59 + this.Criteria.GetHashCode();

				if (this.PageNumber != null)
					hash = hash * 59 + this.PageNumber.GetHashCode();

				if (this.PageSize != null)
					hash = hash * 59 + this.PageSize.GetHashCode();

				if (this.ContactSorts != null)
					hash = hash * 59 + this.ContactSorts.GetHashCode();

				return hash;
			}
		}
	}

}
