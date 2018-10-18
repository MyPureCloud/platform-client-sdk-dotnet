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
    /// ContactListNotification
    /// </summary>
    [DataContract]
    public partial class ContactListNotification :  IEquatable<ContactListNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Version">Version.</param>
        /// <param name="ColumnNames">ColumnNames.</param>
        /// <param name="PhoneColumns">PhoneColumns.</param>
        /// <param name="ImportStatus">ImportStatus.</param>
        /// <param name="PreviewModeColumnName">PreviewModeColumnName.</param>
        /// <param name="PreviewModeAcceptedValues">PreviewModeAcceptedValues.</param>
        /// <param name="Size">Size.</param>
        /// <param name="AttemptLimits">AttemptLimits.</param>
        /// <param name="AutomaticTimeZoneMapping">AutomaticTimeZoneMapping.</param>
        /// <param name="ZipCodeColumnName">ZipCodeColumnName.</param>
        /// <param name="Division">Division.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public ContactListNotification(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, List<string> ColumnNames = null, List<ContactListNotificationPhoneColumns> PhoneColumns = null, ContactListNotificationImportStatus ImportStatus = null, string PreviewModeColumnName = null, List<string> PreviewModeAcceptedValues = null, int? Size = null, DocumentDataV2NotificationCreatedBy AttemptLimits = null, bool? AutomaticTimeZoneMapping = null, string ZipCodeColumnName = null, ContactListNotificationUriReference Division = null, Object AdditionalProperties = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.ColumnNames = ColumnNames;
            this.PhoneColumns = PhoneColumns;
            this.ImportStatus = ImportStatus;
            this.PreviewModeColumnName = PreviewModeColumnName;
            this.PreviewModeAcceptedValues = PreviewModeAcceptedValues;
            this.Size = Size;
            this.AttemptLimits = AttemptLimits;
            this.AutomaticTimeZoneMapping = AutomaticTimeZoneMapping;
            this.ZipCodeColumnName = ZipCodeColumnName;
            this.Division = Division;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ColumnNames
        /// </summary>
        [DataMember(Name="columnNames", EmitDefaultValue=false)]
        public List<string> ColumnNames { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PhoneColumns
        /// </summary>
        [DataMember(Name="phoneColumns", EmitDefaultValue=false)]
        public List<ContactListNotificationPhoneColumns> PhoneColumns { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ImportStatus
        /// </summary>
        [DataMember(Name="importStatus", EmitDefaultValue=false)]
        public ContactListNotificationImportStatus ImportStatus { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PreviewModeColumnName
        /// </summary>
        [DataMember(Name="previewModeColumnName", EmitDefaultValue=false)]
        public string PreviewModeColumnName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PreviewModeAcceptedValues
        /// </summary>
        [DataMember(Name="previewModeAcceptedValues", EmitDefaultValue=false)]
        public List<string> PreviewModeAcceptedValues { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AttemptLimits
        /// </summary>
        [DataMember(Name="attemptLimits", EmitDefaultValue=false)]
        public DocumentDataV2NotificationCreatedBy AttemptLimits { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AutomaticTimeZoneMapping
        /// </summary>
        [DataMember(Name="automaticTimeZoneMapping", EmitDefaultValue=false)]
        public bool? AutomaticTimeZoneMapping { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ZipCodeColumnName
        /// </summary>
        [DataMember(Name="zipCodeColumnName", EmitDefaultValue=false)]
        public string ZipCodeColumnName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public ContactListNotificationUriReference Division { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListNotification {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
            sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
            sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  PreviewModeColumnName: ").Append(PreviewModeColumnName).Append("\n");
            sb.Append("  PreviewModeAcceptedValues: ").Append(PreviewModeAcceptedValues).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  AttemptLimits: ").Append(AttemptLimits).Append("\n");
            sb.Append("  AutomaticTimeZoneMapping: ").Append(AutomaticTimeZoneMapping).Append("\n");
            sb.Append("  ZipCodeColumnName: ").Append(ZipCodeColumnName).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ContactListNotification);
        }

        /// <summary>
        /// Returns true if ContactListNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListNotification other)
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
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this.ColumnNames != null)
                    hash = hash * 59 + this.ColumnNames.GetHashCode();
                
                if (this.PhoneColumns != null)
                    hash = hash * 59 + this.PhoneColumns.GetHashCode();
                
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
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
