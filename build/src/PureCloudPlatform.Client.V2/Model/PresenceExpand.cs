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
    /// PresenceExpand
    /// </summary>
    [DataContract]
    public partial class PresenceExpand :  IEquatable<PresenceExpand>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceExpand" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Presences">An array of user presences.</param>
        /// <param name="OutOfOffices">An array of out of office statuses.</param>
        public PresenceExpand(string Name = null, List<UserPresence> Presences = null, List<OutOfOffice> OutOfOffices = null)
        {
            this.Name = Name;
            this.Presences = Presences;
            this.OutOfOffices = OutOfOffices;
            
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
        /// An array of user presences
        /// </summary>
        /// <value>An array of user presences</value>
        [DataMember(Name="presences", EmitDefaultValue=false)]
        public List<UserPresence> Presences { get; set; }
        
        
        
        /// <summary>
        /// An array of out of office statuses
        /// </summary>
        /// <value>An array of out of office statuses</value>
        [DataMember(Name="outOfOffices", EmitDefaultValue=false)]
        public List<OutOfOffice> OutOfOffices { get; set; }
        
        
        
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
            sb.Append("class PresenceExpand {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Presences: ").Append(Presences).Append("\n");
            sb.Append("  OutOfOffices: ").Append(OutOfOffices).Append("\n");
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
            return this.Equals(obj as PresenceExpand);
        }

        /// <summary>
        /// Returns true if PresenceExpand instances are equal
        /// </summary>
        /// <param name="other">Instance of PresenceExpand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenceExpand other)
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
                    this.Presences == other.Presences ||
                    this.Presences != null &&
                    this.Presences.SequenceEqual(other.Presences)
                ) &&
                (
                    this.OutOfOffices == other.OutOfOffices ||
                    this.OutOfOffices != null &&
                    this.OutOfOffices.SequenceEqual(other.OutOfOffices)
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
                
                if (this.Presences != null)
                    hash = hash * 59 + this.Presences.GetHashCode();
                
                if (this.OutOfOffices != null)
                    hash = hash * 59 + this.OutOfOffices.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
