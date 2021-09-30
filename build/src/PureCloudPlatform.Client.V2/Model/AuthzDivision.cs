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
    /// AuthzDivision
    /// </summary>
    [DataContract]
    public partial class AuthzDivision :  IEquatable<AuthzDivision>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzDivision" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthzDivision() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzDivision" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">A helpful description for the division. (required).</param>
        public AuthzDivision(string Name = null, string Description = null)
        {
            this.Name = Name;
            this.Description = Description;
            
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
        /// A helpful description for the division.
        /// </summary>
        /// <value>A helpful description for the division.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// A flag indicating whether this division is the \&quot;Home\&quot; (default) division. Cannot be modified and any supplied value will be ignored on create or update.
        /// </summary>
        /// <value>A flag indicating whether this division is the \&quot;Home\&quot; (default) division. Cannot be modified and any supplied value will be ignored on create or update.</value>
        [DataMember(Name="homeDivision", EmitDefaultValue=false)]
        public bool? HomeDivision { get; private set; }
        
        
        
        /// <summary>
        /// A count of objects in this division, grouped by type.
        /// </summary>
        /// <value>A count of objects in this division, grouped by type.</value>
        [DataMember(Name="objectCounts", EmitDefaultValue=false)]
        public Dictionary<string, long?> ObjectCounts { get; private set; }
        
        
        
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
            sb.Append("class AuthzDivision {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HomeDivision: ").Append(HomeDivision).Append("\n");
            sb.Append("  ObjectCounts: ").Append(ObjectCounts).Append("\n");
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
            return this.Equals(obj as AuthzDivision);
        }

        /// <summary>
        /// Returns true if AuthzDivision instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthzDivision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthzDivision other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.HomeDivision == other.HomeDivision ||
                    this.HomeDivision != null &&
                    this.HomeDivision.Equals(other.HomeDivision)
                ) &&
                (
                    this.ObjectCounts == other.ObjectCounts ||
                    this.ObjectCounts != null &&
                    this.ObjectCounts.SequenceEqual(other.ObjectCounts)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.HomeDivision != null)
                    hash = hash * 59 + this.HomeDivision.GetHashCode();
                
                if (this.ObjectCounts != null)
                    hash = hash * 59 + this.ObjectCounts.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
