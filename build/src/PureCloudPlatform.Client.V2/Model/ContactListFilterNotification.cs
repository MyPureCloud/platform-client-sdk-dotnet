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
    /// ContactListFilterNotification
    /// </summary>
    [DataContract]
    public partial class ContactListFilterNotification :  IEquatable<ContactListFilterNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets FilterType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FilterTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum And for "AND"
            /// </summary>
            [EnumMember(Value = "AND")]
            And,
            
            /// <summary>
            /// Enum Or for "OR"
            /// </summary>
            [EnumMember(Value = "OR")]
            Or
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets FilterType
        /// </summary>
        [DataMember(Name="filterType", EmitDefaultValue=false)]
        public FilterTypeEnum? FilterType { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListFilterNotification" /> class.
        /// </summary>
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="DateCreated">DateCreated.</param>
        
        
        
        /// <param name="DateModified">DateModified.</param>
        
        
        
        /// <param name="Version">Version.</param>
        
        
        
        /// <param name="ContactList">ContactList.</param>
        
        
        
        /// <param name="ContactListColumns">ContactListColumns.</param>
        
        
        
        /// <param name="Clauses">Clauses.</param>
        
        
        
        /// <param name="FilterType">FilterType.</param>
        
        
        
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        
        
        public ContactListFilterNotification(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, DocumentDataV2NotificationCreatedBy ContactList = null, List<string> ContactListColumns = null, List<ContactListFilterNotificationClauses> Clauses = null, FilterTypeEnum? FilterType = null, Object AdditionalProperties = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.DateCreated = DateCreated;
            
            
            
            
            
            
            
            
this.DateModified = DateModified;
            
            
            
            
            
            
            
            
this.Version = Version;
            
            
            
            
            
            
            
            
this.ContactList = ContactList;
            
            
            
            
            
            
            
            
this.ContactListColumns = ContactListColumns;
            
            
            
            
            
            
            
            
this.Clauses = Clauses;
            
            
            
            
            
            
            
            
this.FilterType = FilterType;
            
            
            
            
            
            
            
            
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
        /// Gets or Sets ContactList
        /// </summary>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public DocumentDataV2NotificationCreatedBy ContactList { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContactListColumns
        /// </summary>
        [DataMember(Name="contactListColumns", EmitDefaultValue=false)]
        public List<string> ContactListColumns { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Clauses
        /// </summary>
        [DataMember(Name="clauses", EmitDefaultValue=false)]
        public List<ContactListFilterNotificationClauses> Clauses { get; set; }
        
        
        
        
        
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
            sb.Append("class ContactListFilterNotification {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            
            sb.Append("  Version: ").Append(Version).Append("\n");
            
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            
            sb.Append("  ContactListColumns: ").Append(ContactListColumns).Append("\n");
            
            sb.Append("  Clauses: ").Append(Clauses).Append("\n");
            
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            
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
            return this.Equals(obj as ContactListFilterNotification);
        }

        /// <summary>
        /// Returns true if ContactListFilterNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListFilterNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListFilterNotification other)
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
                    this.ContactList == other.ContactList ||
                    this.ContactList != null &&
                    this.ContactList.Equals(other.ContactList)
                ) &&
                (
                    this.ContactListColumns == other.ContactListColumns ||
                    this.ContactListColumns != null &&
                    this.ContactListColumns.SequenceEqual(other.ContactListColumns)
                ) &&
                (
                    this.Clauses == other.Clauses ||
                    this.Clauses != null &&
                    this.Clauses.SequenceEqual(other.Clauses)
                ) &&
                (
                    this.FilterType == other.FilterType ||
                    this.FilterType != null &&
                    this.FilterType.Equals(other.FilterType)
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
                
                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();
                
                if (this.ContactListColumns != null)
                    hash = hash * 59 + this.ContactListColumns.GetHashCode();
                
                if (this.Clauses != null)
                    hash = hash * 59 + this.Clauses.GetHashCode();
                
                if (this.FilterType != null)
                    hash = hash * 59 + this.FilterType.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
