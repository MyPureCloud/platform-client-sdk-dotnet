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
    /// OrganizationPresence
    /// </summary>
    [DataContract]
    public partial class OrganizationPresence :  IEquatable<OrganizationPresence>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPresence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationPresence() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPresence" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="LanguageLabels">The label used for the system presence in each specified language (required).</param>
        
        
        
        /// <param name="SystemPresence">SystemPresence.</param>
        
        
        
        /// <param name="Deactivated">Deactivated.</param>
        
        
        
        /// <param name="Primary">Primary.</param>
        
        
        
        /// <param name="CreatedBy">CreatedBy.</param>
        
        
        
        /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="ModifiedBy">ModifiedBy.</param>
        
        
        
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        
        public OrganizationPresence(string Name = null, Dictionary<string, string> LanguageLabels = null, string SystemPresence = null, bool? Deactivated = null, bool? Primary = null, User CreatedBy = null, DateTime? CreatedDate = null, User ModifiedBy = null, DateTime? ModifiedDate = null)
        {
            
            
            
            
            
            
            
            
            
            // to ensure "LanguageLabels" is required (not null)
            if (LanguageLabels == null)
            {
                throw new InvalidDataException("LanguageLabels is a required property for OrganizationPresence and cannot be null");
            }
            else
            {
                this.LanguageLabels = LanguageLabels;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
            
            
            
            
this.SystemPresence = SystemPresence;
            
            
            
            
            
            
            
            
this.Deactivated = Deactivated;
            
            
            
            
            
            
            
            
this.Primary = Primary;
            
            
            
            
            
            
            
            
this.CreatedBy = CreatedBy;
            
            
            
            
            
            
            
            
this.CreatedDate = CreatedDate;
            
            
            
            
            
            
            
            
this.ModifiedBy = ModifiedBy;
            
            
            
            
            
            
            
            
this.ModifiedDate = ModifiedDate;
            
            
            
            
            
            
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
        /// The label used for the system presence in each specified language
        /// </summary>
        /// <value>The label used for the system presence in each specified language</value>
        [DataMember(Name="languageLabels", EmitDefaultValue=false)]
        public Dictionary<string, string> LanguageLabels { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SystemPresence
        /// </summary>
        [DataMember(Name="systemPresence", EmitDefaultValue=false)]
        public string SystemPresence { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Deactivated
        /// </summary>
        [DataMember(Name="deactivated", EmitDefaultValue=false)]
        public bool? Deactivated { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public User ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        
        
        
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
            sb.Append("class OrganizationPresence {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  LanguageLabels: ").Append(LanguageLabels).Append("\n");
            
            sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
            
            sb.Append("  Deactivated: ").Append(Deactivated).Append("\n");
            
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            
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
            return this.Equals(obj as OrganizationPresence);
        }

        /// <summary>
        /// Returns true if OrganizationPresence instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationPresence other)
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
                    this.LanguageLabels == other.LanguageLabels ||
                    this.LanguageLabels != null &&
                    this.LanguageLabels.SequenceEqual(other.LanguageLabels)
                ) &&
                (
                    this.SystemPresence == other.SystemPresence ||
                    this.SystemPresence != null &&
                    this.SystemPresence.Equals(other.SystemPresence)
                ) &&
                (
                    this.Deactivated == other.Deactivated ||
                    this.Deactivated != null &&
                    this.Deactivated.Equals(other.Deactivated)
                ) &&
                (
                    this.Primary == other.Primary ||
                    this.Primary != null &&
                    this.Primary.Equals(other.Primary)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                
                if (this.LanguageLabels != null)
                    hash = hash * 59 + this.LanguageLabels.GetHashCode();
                
                if (this.SystemPresence != null)
                    hash = hash * 59 + this.SystemPresence.GetHashCode();
                
                if (this.Deactivated != null)
                    hash = hash * 59 + this.Deactivated.GetHashCode();
                
                if (this.Primary != null)
                    hash = hash * 59 + this.Primary.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
