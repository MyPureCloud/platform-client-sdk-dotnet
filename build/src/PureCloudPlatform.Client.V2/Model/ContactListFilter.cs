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
    /// ContactListFilter
    /// </summary>
    [DataContract]
    public partial class ContactListFilter :  IEquatable<ContactListFilter>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The filter type tells the api how to compare between clauses
        /// </summary>
        /// <value>The filter type tells the api how to compare between clauses</value>
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
        /// The filter type tells the api how to compare between clauses
        /// </summary>
        /// <value>The filter type tells the api how to compare between clauses</value>
        [DataMember(Name="filterType", EmitDefaultValue=false)]
        public FilterTypeEnum? FilterType { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactListFilter() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListFilter" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        
        
        
        
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        
        
        
        /// <param name="ContactList">The contact list the filter is based on (required).</param>
        
        
        
        /// <param name="Clauses">Clauses.</param>
        
        
        
        /// <param name="FilterType">The filter type tells the api how to compare between clauses.</param>
        
        
        
        
        public ContactListFilter(string Name = null, int? Version = null, UriReference ContactList = null, List<ContactListFilterClause> Clauses = null, FilterTypeEnum? FilterType = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // to ensure "ContactList" is required (not null)
            if (ContactList == null)
            {
                throw new InvalidDataException("ContactList is a required property for ContactListFilter and cannot be null");
            }
            else
            {
                this.ContactList = ContactList;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
            
            
            
            
this.Version = Version;
            
            
            
            
            
            
            
            
            
            
            
            
this.Clauses = Clauses;
            
            
            
            
            
            
            
            
this.FilterType = FilterType;
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// The contact list the filter is based on
        /// </summary>
        /// <value>The contact list the filter is based on</value>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public UriReference ContactList { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Clauses
        /// </summary>
        [DataMember(Name="clauses", EmitDefaultValue=false)]
        public List<ContactListFilterClause> Clauses { get; set; }
        
        
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListFilter {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            
            sb.Append("  Version: ").Append(Version).Append("\n");
            
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            
            sb.Append("  Clauses: ").Append(Clauses).Append("\n");
            
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            
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
            return this.Equals(obj as ContactListFilter);
        }

        /// <summary>
        /// Returns true if ContactListFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListFilter other)
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
                
                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();
                
                if (this.Clauses != null)
                    hash = hash * 59 + this.Clauses.GetHashCode();
                
                if (this.FilterType != null)
                    hash = hash * 59 + this.FilterType.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
