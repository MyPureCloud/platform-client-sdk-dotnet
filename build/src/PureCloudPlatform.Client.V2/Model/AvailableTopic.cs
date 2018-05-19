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
    /// AvailableTopic
    /// </summary>
    [DataContract]
    public partial class AvailableTopic :  IEquatable<AvailableTopic>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableTopic" /> class.
        /// </summary>
        
        
        /// <param name="Description">Description.</param>
        
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="RequiresPermissions">RequiresPermissions.</param>
        
        
        
        /// <param name="Schema">Schema.</param>
        
        
        public AvailableTopic(string Description = null, string Id = null, List<string> RequiresPermissions = null, Dictionary<string, Object> Schema = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Description = Description;
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.RequiresPermissions = RequiresPermissions;
            
            
            
            
            
            
            
            
this.Schema = Schema;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RequiresPermissions
        /// </summary>
        [DataMember(Name="requiresPermissions", EmitDefaultValue=false)]
        public List<string> RequiresPermissions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public Dictionary<string, Object> Schema { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableTopic {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  RequiresPermissions: ").Append(RequiresPermissions).Append("\n");
            
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            
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
            return this.Equals(obj as AvailableTopic);
        }

        /// <summary>
        /// Returns true if AvailableTopic instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableTopic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableTopic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.RequiresPermissions == other.RequiresPermissions ||
                    this.RequiresPermissions != null &&
                    this.RequiresPermissions.SequenceEqual(other.RequiresPermissions)
                ) &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.SequenceEqual(other.Schema)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.RequiresPermissions != null)
                    hash = hash * 59 + this.RequiresPermissions.GetHashCode();
                
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                
                return hash;
            }
        }
    }

}
