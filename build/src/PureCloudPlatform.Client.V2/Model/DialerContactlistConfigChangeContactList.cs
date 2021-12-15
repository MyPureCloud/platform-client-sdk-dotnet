using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// DialerContactlistConfigChangeContactList
    /// </summary>
    [DataContract]
    public partial class DialerContactlistConfigChangeContactList :  IEquatable<DialerContactlistConfigChangeContactList>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerContactlistConfigChangeContactList" /> class.
        /// </summary>
        /// <param name="ColumnNames">the contact column names.</param>
        /// <param name="PhoneColumns">the columns containing phone numbers.</param>
        /// <param name="EmailColumns">the columns containing email addresses.</param>
        /// <param name="ImportStatus">ImportStatus.</param>
        /// <param name="PreviewModeColumnName">the name of the column that holds the indicators for contacts that are to be dialed in preview mode only.</param>
        /// <param name="PreviewModeAcceptedValues">list of user-defined values indicating the contact is to be dialed in preview mode only.</param>
        /// <param name="Size">the number of contacts in the contact list.</param>
        /// <param name="AttemptLimits">AttemptLimits.</param>
        /// <param name="AutomaticTimeZoneMapping">whether or not automatic time zone mapping is enabled on the list.</param>
        /// <param name="ZipCodeColumnName">zip code column from the contact list to be used optionally with automatic time zone mapping.</param>
        /// <param name="Division">A UriReference for a resource.</param>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The UI-visible name of the object.</param>
        /// <param name="DateCreated">Creation time of the entity.</param>
        /// <param name="DateModified">Last modified time of the entity.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        public DialerContactlistConfigChangeContactList(List<string> ColumnNames = null, List<DialerContactlistConfigChangeContactPhoneNumberColumn> PhoneColumns = null, List<DialerContactlistConfigChangeEmailColumn> EmailColumns = null, DialerContactlistConfigChangeImportStatus ImportStatus = null, string PreviewModeColumnName = null, List<string> PreviewModeAcceptedValues = null, int? Size = null, DialerContactlistConfigChangeUriReference AttemptLimits = null, bool? AutomaticTimeZoneMapping = null, string ZipCodeColumnName = null, DialerContactlistConfigChangeUriReference Division = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null)
        {
            this.ColumnNames = ColumnNames;
            this.PhoneColumns = PhoneColumns;
            this.EmailColumns = EmailColumns;
            this.ImportStatus = ImportStatus;
            this.PreviewModeColumnName = PreviewModeColumnName;
            this.PreviewModeAcceptedValues = PreviewModeAcceptedValues;
            this.Size = Size;
            this.AttemptLimits = AttemptLimits;
            this.AutomaticTimeZoneMapping = AutomaticTimeZoneMapping;
            this.ZipCodeColumnName = ZipCodeColumnName;
            this.Division = Division;
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            
        }
        
        
        
        /// <summary>
        /// the contact column names
        /// </summary>
        /// <value>the contact column names</value>
        [DataMember(Name="columnNames", EmitDefaultValue=false)]
        public List<string> ColumnNames { get; set; }
        
        
        
        /// <summary>
        /// the columns containing phone numbers
        /// </summary>
        /// <value>the columns containing phone numbers</value>
        [DataMember(Name="phoneColumns", EmitDefaultValue=false)]
        public List<DialerContactlistConfigChangeContactPhoneNumberColumn> PhoneColumns { get; set; }
        
        
        
        /// <summary>
        /// the columns containing email addresses
        /// </summary>
        /// <value>the columns containing email addresses</value>
        [DataMember(Name="emailColumns", EmitDefaultValue=false)]
        public List<DialerContactlistConfigChangeEmailColumn> EmailColumns { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ImportStatus
        /// </summary>
        [DataMember(Name="importStatus", EmitDefaultValue=false)]
        public DialerContactlistConfigChangeImportStatus ImportStatus { get; set; }
        
        
        
        /// <summary>
        /// the name of the column that holds the indicators for contacts that are to be dialed in preview mode only
        /// </summary>
        /// <value>the name of the column that holds the indicators for contacts that are to be dialed in preview mode only</value>
        [DataMember(Name="previewModeColumnName", EmitDefaultValue=false)]
        public string PreviewModeColumnName { get; set; }
        
        
        
        /// <summary>
        /// list of user-defined values indicating the contact is to be dialed in preview mode only
        /// </summary>
        /// <value>list of user-defined values indicating the contact is to be dialed in preview mode only</value>
        [DataMember(Name="previewModeAcceptedValues", EmitDefaultValue=false)]
        public List<string> PreviewModeAcceptedValues { get; set; }
        
        
        
        /// <summary>
        /// the number of contacts in the contact list
        /// </summary>
        /// <value>the number of contacts in the contact list</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AttemptLimits
        /// </summary>
        [DataMember(Name="attemptLimits", EmitDefaultValue=false)]
        public DialerContactlistConfigChangeUriReference AttemptLimits { get; set; }
        
        
        
        /// <summary>
        /// whether or not automatic time zone mapping is enabled on the list
        /// </summary>
        /// <value>whether or not automatic time zone mapping is enabled on the list</value>
        [DataMember(Name="automaticTimeZoneMapping", EmitDefaultValue=false)]
        public bool? AutomaticTimeZoneMapping { get; set; }
        
        
        
        /// <summary>
        /// zip code column from the contact list to be used optionally with automatic time zone mapping
        /// </summary>
        /// <value>zip code column from the contact list to be used optionally with automatic time zone mapping</value>
        [DataMember(Name="zipCodeColumnName", EmitDefaultValue=false)]
        public string ZipCodeColumnName { get; set; }
        
        
        
        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public DialerContactlistConfigChangeUriReference Division { get; set; }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The UI-visible name of the object
        /// </summary>
        /// <value>The UI-visible name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Creation time of the entity
        /// </summary>
        /// <value>Creation time of the entity</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Last modified time of the entity
        /// </summary>
        /// <value>Last modified time of the entity</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerContactlistConfigChangeContactList {\n");
            
            sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
            sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
            sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
            sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  PreviewModeColumnName: ").Append(PreviewModeColumnName).Append("\n");
            sb.Append("  PreviewModeAcceptedValues: ").Append(PreviewModeAcceptedValues).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  AttemptLimits: ").Append(AttemptLimits).Append("\n");
            sb.Append("  AutomaticTimeZoneMapping: ").Append(AutomaticTimeZoneMapping).Append("\n");
            sb.Append("  ZipCodeColumnName: ").Append(ZipCodeColumnName).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as DialerContactlistConfigChangeContactList);
        }

        /// <summary>
        /// Returns true if DialerContactlistConfigChangeContactList instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerContactlistConfigChangeContactList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerContactlistConfigChangeContactList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
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
                
                if (this.ColumnNames != null)
                    hash = hash * 59 + this.ColumnNames.GetHashCode();
                
                if (this.PhoneColumns != null)
                    hash = hash * 59 + this.PhoneColumns.GetHashCode();
                
                if (this.EmailColumns != null)
                    hash = hash * 59 + this.EmailColumns.GetHashCode();
                
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
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
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
                
                return hash;
            }
        }
    }

}
