using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ImportTemplate
	/// </summary>
	[DataContract]
	public partial class ImportTemplate : IEquatable<ImportTemplate>
	{
		/// <summary>
		/// The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required.
		/// </summary>
		/// <value>The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ListNameFormatEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Listnameprefix for "ListNamePrefix"
			/// </summary>
			[EnumMember(Value = "ListNamePrefix")]
			Listnameprefix,

			/// <summary>
			/// Enum Listnameprefixmonthdayyear for "ListNamePrefixMonthDayYear"
			/// </summary>
			[EnumMember(Value = "ListNamePrefixMonthDayYear")]
			Listnameprefixmonthdayyear,

			/// <summary>
			/// Enum Listnameprefixmonthdayyearhourminutesecond for "ListNamePrefixMonthDayYearHourMinuteSecond"
			/// </summary>
			[EnumMember(Value = "ListNamePrefixMonthDayYearHourMinuteSecond")]
			Listnameprefixmonthdayyearhourminutesecond,

			/// <summary>
			/// Enum Listnameprefixpart for "ListNamePrefixPart"
			/// </summary>
			[EnumMember(Value = "ListNamePrefixPart")]
			Listnameprefixpart,

			/// <summary>
			/// Enum Listnameprefixmonthdayyearpart for "ListNamePrefixMonthDayYearPart"
			/// </summary>
			[EnumMember(Value = "ListNamePrefixMonthDayYearPart")]
			Listnameprefixmonthdayyearpart,

			/// <summary>
			/// Enum Listnameprefixmonthdayyearhourminutesecondpart for "ListNamePrefixMonthDayYearHourMinuteSecondPart"
			/// </summary>
			[EnumMember(Value = "ListNamePrefixMonthDayYearHourMinuteSecondPart")]
			Listnameprefixmonthdayyearhourminutesecondpart,

			/// <summary>
			/// Enum Custom for "Custom"
			/// </summary>
			[EnumMember(Value = "Custom")]
			Custom
		}
		/// <summary>
		/// The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required.
		/// </summary>
		/// <value>The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required.</value>
		[DataMember(Name = "listNameFormat", EmitDefaultValue = false)]
		public ListNameFormatEnum? ListNameFormat { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ImportTemplate" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ImportTemplate() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ImportTemplate" /> class.
		/// </summary>
		/// <param name="Name">The name of the import template..</param>
		/// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
		/// <param name="ContactListTemplate">ContactListTemplate for this ImportTemplate. (required).</param>
		/// <param name="ContactListFilter">ContactListFilter for this ImportTemplate..</param>
		/// <param name="UseSplittingCriteria">Whether or not to use splitting criteria. Default is false..</param>
		/// <param name="SplittingInformation">How to split contact records, required if useSplittingCriteria is true..</param>
		/// <param name="ListNameFormat">The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required..</param>
		/// <param name="CustomListNameFormatValue">Custom value for the list name format, at least %N is required. Any character other than the specified tokens will be used as is. Available tokens: %N: ListNamePrefix; %P: Part number; %F: Filter name; %C: Column value; YYYY: year; MM: month; DD: day; hh: hour; mm: minute; ss: second..</param>
		public ImportTemplate(string Name = null, int? Version = null, DomainEntityRef ContactListTemplate = null, DomainEntityRef ContactListFilter = null, bool? UseSplittingCriteria = null, SplittingInformation SplittingInformation = null, ListNameFormatEnum? ListNameFormat = null, string CustomListNameFormatValue = null)
		{
			this.Name = Name;
			this.Version = Version;
			this.ContactListTemplate = ContactListTemplate;
			this.ContactListFilter = ContactListFilter;
			this.UseSplittingCriteria = UseSplittingCriteria;
			this.SplittingInformation = SplittingInformation;
			this.ListNameFormat = ListNameFormat;
			this.CustomListNameFormatValue = CustomListNameFormatValue;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the import template.
		/// </summary>
		/// <value>The name of the import template.</value>
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
		/// ContactListTemplate for this ImportTemplate.
		/// </summary>
		/// <value>ContactListTemplate for this ImportTemplate.</value>
		[DataMember(Name = "contactListTemplate", EmitDefaultValue = false)]
		public DomainEntityRef ContactListTemplate { get; set; }



		/// <summary>
		/// ContactListFilter for this ImportTemplate.
		/// </summary>
		/// <value>ContactListFilter for this ImportTemplate.</value>
		[DataMember(Name = "contactListFilter", EmitDefaultValue = false)]
		public DomainEntityRef ContactListFilter { get; set; }



		/// <summary>
		/// Whether or not to use splitting criteria. Default is false.
		/// </summary>
		/// <value>Whether or not to use splitting criteria. Default is false.</value>
		[DataMember(Name = "useSplittingCriteria", EmitDefaultValue = false)]
		public bool? UseSplittingCriteria { get; set; }



		/// <summary>
		/// How to split contact records, required if useSplittingCriteria is true.
		/// </summary>
		/// <value>How to split contact records, required if useSplittingCriteria is true.</value>
		[DataMember(Name = "splittingInformation", EmitDefaultValue = false)]
		public SplittingInformation SplittingInformation { get; set; }





		/// <summary>
		/// Custom value for the list name format, at least %N is required. Any character other than the specified tokens will be used as is. Available tokens: %N: ListNamePrefix; %P: Part number; %F: Filter name; %C: Column value; YYYY: year; MM: month; DD: day; hh: hour; mm: minute; ss: second.
		/// </summary>
		/// <value>Custom value for the list name format, at least %N is required. Any character other than the specified tokens will be used as is. Available tokens: %N: ListNamePrefix; %P: Part number; %F: Filter name; %C: Column value; YYYY: year; MM: month; DD: day; hh: hour; mm: minute; ss: second.</value>
		[DataMember(Name = "customListNameFormatValue", EmitDefaultValue = false)]
		public string CustomListNameFormatValue { get; set; }



		/// <summary>
		/// The status of the import process.
		/// </summary>
		/// <value>The status of the import process.</value>
		[DataMember(Name = "importStatus", EmitDefaultValue = false)]
		public ImportStatus ImportStatus { get; private set; }



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
			sb.Append("class ImportTemplate {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  ContactListTemplate: ").Append(ContactListTemplate).Append("\n");
			sb.Append("  ContactListFilter: ").Append(ContactListFilter).Append("\n");
			sb.Append("  UseSplittingCriteria: ").Append(UseSplittingCriteria).Append("\n");
			sb.Append("  SplittingInformation: ").Append(SplittingInformation).Append("\n");
			sb.Append("  ListNameFormat: ").Append(ListNameFormat).Append("\n");
			sb.Append("  CustomListNameFormatValue: ").Append(CustomListNameFormatValue).Append("\n");
			sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
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
			return this.Equals(obj as ImportTemplate);
		}

		/// <summary>
		/// Returns true if ImportTemplate instances are equal
		/// </summary>
		/// <param name="other">Instance of ImportTemplate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ImportTemplate other)
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
					this.ContactListTemplate == other.ContactListTemplate ||
					this.ContactListTemplate != null &&
					this.ContactListTemplate.Equals(other.ContactListTemplate)
				) &&
				(
					this.ContactListFilter == other.ContactListFilter ||
					this.ContactListFilter != null &&
					this.ContactListFilter.Equals(other.ContactListFilter)
				) &&
				(
					this.UseSplittingCriteria == other.UseSplittingCriteria ||
					this.UseSplittingCriteria != null &&
					this.UseSplittingCriteria.Equals(other.UseSplittingCriteria)
				) &&
				(
					this.SplittingInformation == other.SplittingInformation ||
					this.SplittingInformation != null &&
					this.SplittingInformation.Equals(other.SplittingInformation)
				) &&
				(
					this.ListNameFormat == other.ListNameFormat ||
					this.ListNameFormat != null &&
					this.ListNameFormat.Equals(other.ListNameFormat)
				) &&
				(
					this.CustomListNameFormatValue == other.CustomListNameFormatValue ||
					this.CustomListNameFormatValue != null &&
					this.CustomListNameFormatValue.Equals(other.CustomListNameFormatValue)
				) &&
				(
					this.ImportStatus == other.ImportStatus ||
					this.ImportStatus != null &&
					this.ImportStatus.Equals(other.ImportStatus)
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

				if (this.ContactListTemplate != null)
					hash = hash * 59 + this.ContactListTemplate.GetHashCode();

				if (this.ContactListFilter != null)
					hash = hash * 59 + this.ContactListFilter.GetHashCode();

				if (this.UseSplittingCriteria != null)
					hash = hash * 59 + this.UseSplittingCriteria.GetHashCode();

				if (this.SplittingInformation != null)
					hash = hash * 59 + this.SplittingInformation.GetHashCode();

				if (this.ListNameFormat != null)
					hash = hash * 59 + this.ListNameFormat.GetHashCode();

				if (this.CustomListNameFormatValue != null)
					hash = hash * 59 + this.CustomListNameFormatValue.GetHashCode();

				if (this.ImportStatus != null)
					hash = hash * 59 + this.ImportStatus.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
