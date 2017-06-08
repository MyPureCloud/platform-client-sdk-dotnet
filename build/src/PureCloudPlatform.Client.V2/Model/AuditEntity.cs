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
    /// AuditEntity
    /// </summary>
    [DataContract]
    public partial class AuditEntity :  IEquatable<AuditEntity>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditEntity() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEntity" /> class.
        /// </summary>
        
        
        /// <param name="Type">The type of the entity the action of this AuditEntity targeted. (required).</param>
        
        
        
        /// <param name="Id">The id of the entity the action of this AuditEntity targeted..</param>
        
        
        
        /// <param name="Name">The name of the entity the action of this AuditEntity targeted..</param>
        
        
        
        /// <param name="SelfUri">The selfUri for this entity..</param>
        
        
        public AuditEntity(string Type = null, string Id = null, string Name = null, string SelfUri = null)
        {
            
            
            
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for AuditEntity and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.SelfUri = SelfUri;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The type of the entity the action of this AuditEntity targeted.
        /// </summary>
        /// <value>The type of the entity the action of this AuditEntity targeted.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        /// <summary>
        /// The id of the entity the action of this AuditEntity targeted.
        /// </summary>
        /// <value>The id of the entity the action of this AuditEntity targeted.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The name of the entity the action of this AuditEntity targeted.
        /// </summary>
        /// <value>The name of the entity the action of this AuditEntity targeted.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The selfUri for this entity.
        /// </summary>
        /// <value>The selfUri for this entity.</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditEntity {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as AuditEntity);
        }

        /// <summary>
        /// Returns true if AuditEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
