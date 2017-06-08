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
    /// AuditUser
    /// </summary>
    [DataContract]
    public partial class AuditUser :  IEquatable<AuditUser>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditUser() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditUser" /> class.
        /// </summary>
        
        
        /// <param name="Id">The ID (UUID) of the user who initiated the action of this AuditMessage. (required).</param>
        
        
        
        /// <param name="Name">The full username of the user who initiated the action of this AuditMessage..</param>
        
        
        
        /// <param name="Display">The display name of the user who initiated the action of this AuditMessage..</param>
        
        
        public AuditUser(string Id = null, string Name = null, string Display = null)
        {
            
            
            
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for AuditUser and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.Display = Display;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The ID (UUID) of the user who initiated the action of this AuditMessage.
        /// </summary>
        /// <value>The ID (UUID) of the user who initiated the action of this AuditMessage.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The full username of the user who initiated the action of this AuditMessage.
        /// </summary>
        /// <value>The full username of the user who initiated the action of this AuditMessage.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The display name of the user who initiated the action of this AuditMessage.
        /// </summary>
        /// <value>The display name of the user who initiated the action of this AuditMessage.</value>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditUser {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Display: ").Append(Display).Append("\n");
            
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
            return this.Equals(obj as AuditUser);
        }

        /// <summary>
        /// Returns true if AuditUser instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditUser other)
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
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.Equals(other.Display)
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
                
                if (this.Display != null)
                    hash = hash * 59 + this.Display.GetHashCode();
                
                return hash;
            }
        }
    }

}
