using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactList
	/// </summary>
	[DataContract]
	public partial class ContactList : IEquatable<ContactList>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactList" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContactList() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactList" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
		/// <param name="Division">The division this entity belongs to..</param>
		/// <param name="ColumnNames">The names of the contact data columns. (required).</param>
		/// <param name="PhoneColumns">Indicates which columns are phone numbers..</param>
		/// <param name="EmailColumns">Indicates which columns are email addresses.</param>
		/// <param name="WhatsAppColumns">Indicates which columns are whatsApp contacts.</param>
		/// <param name="PreviewModeColumnName">A column to check if a contact should always be dialed in preview mode..</param>
		/// <param name="PreviewModeAcceptedValues">The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode..</param>
		/// <param name="AttemptLimits">AttemptLimits for this ContactList..</param>
		/// <param name="AutomaticTimeZoneMapping">Indicates if automatic time zone mapping is to be used for this ContactList..</param>
		/// <param name="ZipCodeColumnName">The name of contact list column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true..</param>
		/// <param name="ColumnDataTypeSpecifications">The settings of the columns selected for dynamic queueing.</param>
		/// <param name="TrimWhitespace">Whether to trim white space when importing a contactlist csv file, default value &#x3D; true.</param>
		public ContactList(string Name = null, int? Version = null, DomainEntityRef Division = null, List<string> ColumnNames = null, List<ContactPhoneNumberColumn> PhoneColumns = null, List<EmailColumn> EmailColumns = null, List<WhatsAppColumn> WhatsAppColumns = null, string PreviewModeColumnName = null, List<string> PreviewModeAcceptedValues = null, DomainEntityRef AttemptLimits = null, bool? AutomaticTimeZoneMapping = null, string ZipCodeColumnName = null, List<ColumnDataTypeSpecification> ColumnDataTypeSpecifications = null, bool? TrimWhitespace = null)
		{
			this.Name = Name;
			this.Version = Version;
			this.Division = Division;
			this.ColumnNames = ColumnNames;
			this.PhoneColumns = PhoneColumns;
			this.EmailColumns = EmailColumns;
			this.WhatsAppColumns = WhatsAppColumns;
			this.PreviewModeColumnName = PreviewModeColumnName;
			this.PreviewModeAcceptedValues = PreviewModeAcceptedValues;
			this.AttemptLimits = AttemptLimits;
			this.AutomaticTimeZoneMapping = AutomaticTimeZoneMapping;
			this.ZipCodeColumnName = ZipCodeColumnName;
			this.ColumnDataTypeSpecifications = ColumnDataTypeSpecifications;
			this.TrimWhitespace = TrimWhitespace;

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
		/// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// Required for updates, must match the version number of the most recent update
		/// </summary>
		/// <value>Required for updates, must match the version number of the most recent update</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; set; }



		/// <summary>
		/// The division this entity belongs to.
		/// </summary>
		/// <value>The division this entity belongs to.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public DomainEntityRef Division { get; set; }



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
		/// Indicates which columns are email addresses
		/// </summary>
		/// <value>Indicates which columns are email addresses</value>
		[DataMember(Name = "emailColumns", EmitDefaultValue = false)]
		public List<EmailColumn> EmailColumns { get; set; }



		/// <summary>
		/// Indicates which columns are whatsApp contacts
		/// </summary>
		/// <value>Indicates which columns are whatsApp contacts</value>
		[DataMember(Name = "whatsAppColumns", EmitDefaultValue = false)]
		public List<WhatsAppColumn> WhatsAppColumns { get; set; }



		/// <summary>
		/// The status of the import process.
		/// </summary>
		/// <value>The status of the import process.</value>
		[DataMember(Name = "importStatus", EmitDefaultValue = false)]
		public ImportStatus ImportStatus { get; private set; }



		/// <summary>
		/// A column to check if a contact should always be dialed in preview mode.
		/// </summary>
		/// <value>A column to check if a contact should always be dialed in preview mode.</value>
		[DataMember(Name = "previewModeColumnName", EmitDefaultValue = false)]
		public string PreviewModeColumnName { get; set; }



		/// <summary>
		/// The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode.
		/// </summary>
		/// <value>The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode.</value>
		[DataMember(Name = "previewModeAcceptedValues", EmitDefaultValue = false)]
		public List<string> PreviewModeAcceptedValues { get; set; }



		/// <summary>
		/// The number of contacts in the ContactList.
		/// </summary>
		/// <value>The number of contacts in the ContactList.</value>
		[DataMember(Name = "size", EmitDefaultValue = false)]
		public long? Size { get; private set; }



		/// <summary>
		/// AttemptLimits for this ContactList.
		/// </summary>
		/// <value>AttemptLimits for this ContactList.</value>
		[DataMember(Name = "attemptLimits", EmitDefaultValue = false)]
		public DomainEntityRef AttemptLimits { get; set; }



		/// <summary>
		/// Indicates if automatic time zone mapping is to be used for this ContactList.
		/// </summary>
		/// <value>Indicates if automatic time zone mapping is to be used for this ContactList.</value>
		[DataMember(Name = "automaticTimeZoneMapping", EmitDefaultValue = false)]
		public bool? AutomaticTimeZoneMapping { get; set; }



		/// <summary>
		/// The name of contact list column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true.
		/// </summary>
		/// <value>The name of contact list column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true.</value>
		[DataMember(Name = "zipCodeColumnName", EmitDefaultValue = false)]
		public string ZipCodeColumnName { get; set; }



		/// <summary>
		/// The settings of the columns selected for dynamic queueing
		/// </summary>
		/// <value>The settings of the columns selected for dynamic queueing</value>
		[DataMember(Name = "columnDataTypeSpecifications", EmitDefaultValue = false)]
		public List<ColumnDataTypeSpecification> ColumnDataTypeSpecifications { get; set; }



		/// <summary>
		/// Whether to trim white space when importing a contactlist csv file, default value &#x3D; true
		/// </summary>
		/// <value>Whether to trim white space when importing a contactlist csv file, default value &#x3D; true</value>
		[DataMember(Name = "trimWhitespace", EmitDefaultValue = false)]
		public bool? TrimWhitespace { get; set; }



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
			sb.Append("class ContactList {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
			sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
			sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
			sb.Append("  WhatsAppColumns: ").Append(WhatsAppColumns).Append("\n");
			sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
			sb.Append("  PreviewModeColumnName: ").Append(PreviewModeColumnName).Append("\n");
			sb.Append("  PreviewModeAcceptedValues: ").Append(PreviewModeAcceptedValues).Append("\n");
			sb.Append("  Size: ").Append(Size).Append("\n");
			sb.Append("  AttemptLimits: ").Append(AttemptLimits).Append("\n");
			sb.Append("  AutomaticTimeZoneMapping: ").Append(AutomaticTimeZoneMapping).Append("\n");
			sb.Append("  ZipCodeColumnName: ").Append(ZipCodeColumnName).Append("\n");
			sb.Append("  ColumnDataTypeSpecifications: ").Append(ColumnDataTypeSpecifications).Append("\n");
			sb.Append("  TrimWhitespace: ").Append(TrimWhitespace).Append("\n");
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
			return this.Equals(obj as ContactList);
		}

		/// <summary>
		/// Returns true if ContactList instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactList to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactList other)
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
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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
					this.PreviewModeColumnName == other.PreviewModeColumnName ||
					this.PreviewModeColumnName != null &&
					this.PreviewModeColumnName.Equals(other.PreviewModeColumnName)
				) &&
				(
					this.PreviewModeAcceptedValues == other.PreviewModeAcceptedValues ||
					this.PreviewModeAcceptedValues != null &&
					this.PreviewModeAcceptedValues.SequenceEqual(other.PreviewModeAcceptedValues)
				) &&
				(
					this.Size == other.Size ||
					this.Size != null &&
					this.Size.Equals(other.Size)
				) &&
				(
					this.AttemptLimits == other.AttemptLimits ||
					this.AttemptLimits != null &&
					this.AttemptLimits.Equals(other.AttemptLimits)
				) &&
				(
					this.AutomaticTimeZoneMapping == other.AutomaticTimeZoneMapping ||
					this.AutomaticTimeZoneMapping != null &&
					this.AutomaticTimeZoneMapping.Equals(other.AutomaticTimeZoneMapping)
				) &&
				(
					this.ZipCodeColumnName == other.ZipCodeColumnName ||
					this.ZipCodeColumnName != null &&
					this.ZipCodeColumnName.Equals(other.ZipCodeColumnName)
				) &&
				(
					this.ColumnDataTypeSpecifications == other.ColumnDataTypeSpecifications ||
					this.ColumnDataTypeSpecifications != null &&
					this.ColumnDataTypeSpecifications.SequenceEqual(other.ColumnDataTypeSpecifications)
				) &&
				(
					this.TrimWhitespace == other.TrimWhitespace ||
					this.TrimWhitespace != null &&
					this.TrimWhitespace.Equals(other.TrimWhitespace)
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

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

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

				if (this.PreviewModeColumnName != null)
					hash = hash * 59 + this.PreviewModeColumnName.GetHashCode();

				if (this.PreviewModeAcceptedValues != null)
					hash = hash * 59 + this.PreviewModeAcceptedValues.GetHashCode();

				if (this.Size != null)
					hash = hash * 59 + this.Size.GetHashCode();

				if (this.AttemptLimits != null)
					hash = hash * 59 + this.AttemptLimits.GetHashCode();

				if (this.AutomaticTimeZoneMapping != null)
					hash = hash * 59 + this.AutomaticTimeZoneMapping.GetHashCode();

				if (this.ZipCodeColumnName != null)
					hash = hash * 59 + this.ZipCodeColumnName.GetHashCode();

				if (this.ColumnDataTypeSpecifications != null)
					hash = hash * 59 + this.ColumnDataTypeSpecifications.GetHashCode();

				if (this.TrimWhitespace != null)
					hash = hash * 59 + this.TrimWhitespace.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
