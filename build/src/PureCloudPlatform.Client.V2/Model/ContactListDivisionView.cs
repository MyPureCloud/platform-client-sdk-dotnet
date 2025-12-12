using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactListDivisionView
	/// </summary>
	[DataContract]
	public partial class ContactListDivisionView : IEquatable<ContactListDivisionView>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactListDivisionView" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContactListDivisionView() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactListDivisionView" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Division">The division to which this entity belongs..</param>
		/// <param name="ColumnNames">The names of the contact data columns. (required).</param>
		/// <param name="PhoneColumns">Indicates which columns are phone numbers..</param>
		/// <param name="EmailColumns">Indicates which columns are email addresses..</param>
		/// <param name="WhatsAppColumns">Indicates which columns are whatsApp contacts..</param>
		public ContactListDivisionView(string Name = null, Division Division = null, List<string> ColumnNames = null, List<ContactPhoneNumberColumn> PhoneColumns = null, List<EmailColumn> EmailColumns = null, List<WhatsAppColumn> WhatsAppColumns = null)
		{
			this.Name = Name;
			this.Division = Division;
			this.ColumnNames = ColumnNames;
			this.PhoneColumns = PhoneColumns;
			this.EmailColumns = EmailColumns;
			this.WhatsAppColumns = WhatsAppColumns;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The division to which this entity belongs.
		/// </summary>
		/// <value>The division to which this entity belongs.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public Division Division { get; set; }



		/// <summary>
		/// The names of the contact data columns.
		/// </summary>
		/// <value>The names of the contact data columns.</value>
		[DataMember(Name = "columnNames", EmitDefaultValue = false)]
		public List<string> ColumnNames { get; set; }



		/// <summary>
		/// Indicates which columns are phone numbers.
		/// </summary>
		/// <value>Indicates which columns are phone numbers.</value>
		[DataMember(Name = "phoneColumns", EmitDefaultValue = false)]
		public List<ContactPhoneNumberColumn> PhoneColumns { get; set; }



		/// <summary>
		/// Indicates which columns are email addresses.
		/// </summary>
		/// <value>Indicates which columns are email addresses.</value>
		[DataMember(Name = "emailColumns", EmitDefaultValue = false)]
		public List<EmailColumn> EmailColumns { get; set; }



		/// <summary>
		/// Indicates which columns are whatsApp contacts.
		/// </summary>
		/// <value>Indicates which columns are whatsApp contacts.</value>
		[DataMember(Name = "whatsAppColumns", EmitDefaultValue = false)]
		public List<WhatsAppColumn> WhatsAppColumns { get; set; }



		/// <summary>
		/// The status of the import process.
		/// </summary>
		/// <value>The status of the import process.</value>
		[DataMember(Name = "importStatus", EmitDefaultValue = false)]
		public ImportStatus ImportStatus { get; private set; }



		/// <summary>
		/// The number of contacts in the ContactList.
		/// </summary>
		/// <value>The number of contacts in the ContactList.</value>
		[DataMember(Name = "size", EmitDefaultValue = false)]
		public long? Size { get; private set; }



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
			sb.Append("class ContactListDivisionView {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
			sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
			sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
			sb.Append("  WhatsAppColumns: ").Append(WhatsAppColumns).Append("\n");
			sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
			sb.Append("  Size: ").Append(Size).Append("\n");
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
			return this.Equals(obj as ContactListDivisionView);
		}

		/// <summary>
		/// Returns true if ContactListDivisionView instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactListDivisionView to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactListDivisionView other)
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
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.ColumnNames == other.ColumnNames ||
					this.ColumnNames != null &&
					this.ColumnNames.SequenceEqual(other.ColumnNames)
				) &&
				(
					this.PhoneColumns == other.PhoneColumns ||
					this.PhoneColumns != null &&
					this.PhoneColumns.SequenceEqual(other.PhoneColumns)
				) &&
				(
					this.EmailColumns == other.EmailColumns ||
					this.EmailColumns != null &&
					this.EmailColumns.SequenceEqual(other.EmailColumns)
				) &&
				(
					this.WhatsAppColumns == other.WhatsAppColumns ||
					this.WhatsAppColumns != null &&
					this.WhatsAppColumns.SequenceEqual(other.WhatsAppColumns)
				) &&
				(
					this.ImportStatus == other.ImportStatus ||
					this.ImportStatus != null &&
					this.ImportStatus.Equals(other.ImportStatus)
				) &&
				(
					this.Size == other.Size ||
					this.Size != null &&
					this.Size.Equals(other.Size)
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

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.ColumnNames != null)
					hash = hash * 59 + this.ColumnNames.GetHashCode();

				if (this.PhoneColumns != null)
					hash = hash * 59 + this.PhoneColumns.GetHashCode();

				if (this.EmailColumns != null)
					hash = hash * 59 + this.EmailColumns.GetHashCode();

				if (this.WhatsAppColumns != null)
					hash = hash * 59 + this.WhatsAppColumns.GetHashCode();

				if (this.ImportStatus != null)
					hash = hash * 59 + this.ImportStatus.GetHashCode();

				if (this.Size != null)
					hash = hash * 59 + this.Size.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
