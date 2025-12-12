using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FileSpecificationTemplate
	/// </summary>
	[DataContract]
	public partial class FileSpecificationTemplate : IEquatable<FileSpecificationTemplate>
	{
		/// <summary>
		/// File format
		/// </summary>
		/// <value>File format</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FormatEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Fixedlength for "FixedLength"
			/// </summary>
			[EnumMember(Value = "FixedLength")]
			Fixedlength,

			/// <summary>
			/// Enum Delimited for "Delimited"
			/// </summary>
			[EnumMember(Value = "Delimited")]
			Delimited
		}
		/// <summary>
		/// Kind of delimiter
		/// </summary>
		/// <value>Kind of delimiter</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DelimiterEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Comma for "Comma"
			/// </summary>
			[EnumMember(Value = "Comma")]
			Comma,

			/// <summary>
			/// Enum Pipe for "Pipe"
			/// </summary>
			[EnumMember(Value = "Pipe")]
			Pipe,

			/// <summary>
			/// Enum Colon for "Colon"
			/// </summary>
			[EnumMember(Value = "Colon")]
			Colon,

			/// <summary>
			/// Enum Tab for "Tab"
			/// </summary>
			[EnumMember(Value = "Tab")]
			Tab,

			/// <summary>
			/// Enum Semicolon for "Semicolon"
			/// </summary>
			[EnumMember(Value = "Semicolon")]
			Semicolon,

			/// <summary>
			/// Enum Custom for "Custom"
			/// </summary>
			[EnumMember(Value = "Custom")]
			Custom
		}
		/// <summary>
		/// File format
		/// </summary>
		/// <value>File format</value>
		[DataMember(Name = "format", EmitDefaultValue = false)]
		public FormatEnum? Format { get; set; }
		/// <summary>
		/// Kind of delimiter
		/// </summary>
		/// <value>Kind of delimiter</value>
		[DataMember(Name = "delimiter", EmitDefaultValue = false)]
		public DelimiterEnum? Delimiter { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="FileSpecificationTemplate" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected FileSpecificationTemplate() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="FileSpecificationTemplate" /> class.
		/// </summary>
		/// <param name="Name">The name of the File Specification template. (required).</param>
		/// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
		/// <param name="Description">Description of the file specification template.</param>
		/// <param name="Format">File format (required).</param>
		/// <param name="NumberOfHeadingLinesSkipped">Number of heading lines to be skipped.</param>
		/// <param name="NumberOfTrailingLinesSkipped">Number of trailing lines to be skipped.</param>
		/// <param name="Header">If true indicates that delimited file has a header row, which can provide column names.</param>
		/// <param name="Delimiter">Kind of delimiter.</param>
		/// <param name="DelimiterValue">Delimiter character, used only when delimiter&#x3D;\&quot;Custom\&quot;.</param>
		/// <param name="ColumnInformation">Columns specification.</param>
		/// <param name="PreprocessingRules">Preprocessing rules.</param>
		public FileSpecificationTemplate(string Name = null, int? Version = null, string Description = null, FormatEnum? Format = null, int? NumberOfHeadingLinesSkipped = null, int? NumberOfTrailingLinesSkipped = null, bool? Header = null, DelimiterEnum? Delimiter = null, string DelimiterValue = null, List<Column> ColumnInformation = null, List<PreprocessingRule> PreprocessingRules = null)
		{
			this.Name = Name;
			this.Version = Version;
			this.Description = Description;
			this.Format = Format;
			this.NumberOfHeadingLinesSkipped = NumberOfHeadingLinesSkipped;
			this.NumberOfTrailingLinesSkipped = NumberOfTrailingLinesSkipped;
			this.Header = Header;
			this.Delimiter = Delimiter;
			this.DelimiterValue = DelimiterValue;
			this.ColumnInformation = ColumnInformation;
			this.PreprocessingRules = PreprocessingRules;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the File Specification template.
		/// </summary>
		/// <value>The name of the File Specification template.</value>
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
		/// Description of the file specification template
		/// </summary>
		/// <value>Description of the file specification template</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }





		/// <summary>
		/// Number of heading lines to be skipped
		/// </summary>
		/// <value>Number of heading lines to be skipped</value>
		[DataMember(Name = "numberOfHeadingLinesSkipped", EmitDefaultValue = false)]
		public int? NumberOfHeadingLinesSkipped { get; set; }



		/// <summary>
		/// Number of trailing lines to be skipped
		/// </summary>
		/// <value>Number of trailing lines to be skipped</value>
		[DataMember(Name = "numberOfTrailingLinesSkipped", EmitDefaultValue = false)]
		public int? NumberOfTrailingLinesSkipped { get; set; }



		/// <summary>
		/// If true indicates that delimited file has a header row, which can provide column names
		/// </summary>
		/// <value>If true indicates that delimited file has a header row, which can provide column names</value>
		[DataMember(Name = "header", EmitDefaultValue = false)]
		public bool? Header { get; set; }





		/// <summary>
		/// Delimiter character, used only when delimiter&#x3D;\&quot;Custom\&quot;
		/// </summary>
		/// <value>Delimiter character, used only when delimiter&#x3D;\&quot;Custom\&quot;</value>
		[DataMember(Name = "delimiterValue", EmitDefaultValue = false)]
		public string DelimiterValue { get; set; }



		/// <summary>
		/// Columns specification
		/// </summary>
		/// <value>Columns specification</value>
		[DataMember(Name = "columnInformation", EmitDefaultValue = false)]
		public List<Column> ColumnInformation { get; set; }



		/// <summary>
		/// Preprocessing rules
		/// </summary>
		/// <value>Preprocessing rules</value>
		[DataMember(Name = "preprocessingRules", EmitDefaultValue = false)]
		public List<PreprocessingRule> PreprocessingRules { get; set; }



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
			sb.Append("class FileSpecificationTemplate {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Format: ").Append(Format).Append("\n");
			sb.Append("  NumberOfHeadingLinesSkipped: ").Append(NumberOfHeadingLinesSkipped).Append("\n");
			sb.Append("  NumberOfTrailingLinesSkipped: ").Append(NumberOfTrailingLinesSkipped).Append("\n");
			sb.Append("  Header: ").Append(Header).Append("\n");
			sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
			sb.Append("  DelimiterValue: ").Append(DelimiterValue).Append("\n");
			sb.Append("  ColumnInformation: ").Append(ColumnInformation).Append("\n");
			sb.Append("  PreprocessingRules: ").Append(PreprocessingRules).Append("\n");
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
			return this.Equals(obj as FileSpecificationTemplate);
		}

		/// <summary>
		/// Returns true if FileSpecificationTemplate instances are equal
		/// </summary>
		/// <param name="other">Instance of FileSpecificationTemplate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FileSpecificationTemplate other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Format == other.Format ||
					this.Format != null &&
					this.Format.Equals(other.Format)
				) &&
				(
					this.NumberOfHeadingLinesSkipped == other.NumberOfHeadingLinesSkipped ||
					this.NumberOfHeadingLinesSkipped != null &&
					this.NumberOfHeadingLinesSkipped.Equals(other.NumberOfHeadingLinesSkipped)
				) &&
				(
					this.NumberOfTrailingLinesSkipped == other.NumberOfTrailingLinesSkipped ||
					this.NumberOfTrailingLinesSkipped != null &&
					this.NumberOfTrailingLinesSkipped.Equals(other.NumberOfTrailingLinesSkipped)
				) &&
				(
					this.Header == other.Header ||
					this.Header != null &&
					this.Header.Equals(other.Header)
				) &&
				(
					this.Delimiter == other.Delimiter ||
					this.Delimiter != null &&
					this.Delimiter.Equals(other.Delimiter)
				) &&
				(
					this.DelimiterValue == other.DelimiterValue ||
					this.DelimiterValue != null &&
					this.DelimiterValue.Equals(other.DelimiterValue)
				) &&
				(
					this.ColumnInformation == other.ColumnInformation ||
					this.ColumnInformation != null &&
					this.ColumnInformation.SequenceEqual(other.ColumnInformation)
				) &&
				(
					this.PreprocessingRules == other.PreprocessingRules ||
					this.PreprocessingRules != null &&
					this.PreprocessingRules.SequenceEqual(other.PreprocessingRules)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Format != null)
					hash = hash * 59 + this.Format.GetHashCode();

				if (this.NumberOfHeadingLinesSkipped != null)
					hash = hash * 59 + this.NumberOfHeadingLinesSkipped.GetHashCode();

				if (this.NumberOfTrailingLinesSkipped != null)
					hash = hash * 59 + this.NumberOfTrailingLinesSkipped.GetHashCode();

				if (this.Header != null)
					hash = hash * 59 + this.Header.GetHashCode();

				if (this.Delimiter != null)
					hash = hash * 59 + this.Delimiter.GetHashCode();

				if (this.DelimiterValue != null)
					hash = hash * 59 + this.DelimiterValue.GetHashCode();

				if (this.ColumnInformation != null)
					hash = hash * 59 + this.ColumnInformation.GetHashCode();

				if (this.PreprocessingRules != null)
					hash = hash * 59 + this.PreprocessingRules.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
