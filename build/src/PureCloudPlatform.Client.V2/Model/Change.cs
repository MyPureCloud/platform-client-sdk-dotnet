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
    /// Change
    /// </summary>
    [DataContract]
    public partial class Change :  IEquatable<Change>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Change" /> class.
        /// </summary>
        
        
        /// <param name="Entity">Entity.</param>
        
        
        
        /// <param name="Property">The property that was changed.</param>
        
        
        
        /// <param name="OldValues">The old values which were modified and/or removed by this action..</param>
        
        
        
        /// <param name="NewValues">The new values which were modified and/or added by this action..</param>
        
        
        public Change(AuditEntity Entity = null, string Property = null, List<string> OldValues = null, List<string> NewValues = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Entity = Entity;
            
            
            
            
            
            
            
            
this.Property = Property;
            
            
            
            
            
            
            
            
this.OldValues = OldValues;
            
            
            
            
            
            
            
            
this.NewValues = NewValues;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public AuditEntity Entity { get; set; }
        
        
        
        /// <summary>
        /// The property that was changed
        /// </summary>
        /// <value>The property that was changed</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
        
        
        
        /// <summary>
        /// The old values which were modified and/or removed by this action.
        /// </summary>
        /// <value>The old values which were modified and/or removed by this action.</value>
        [DataMember(Name="oldValues", EmitDefaultValue=false)]
        public List<string> OldValues { get; set; }
        
        
        
        /// <summary>
        /// The new values which were modified and/or added by this action.
        /// </summary>
        /// <value>The new values which were modified and/or added by this action.</value>
        [DataMember(Name="newValues", EmitDefaultValue=false)]
        public List<string> NewValues { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Change {\n");
            
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            
            sb.Append("  Property: ").Append(Property).Append("\n");
            
            sb.Append("  OldValues: ").Append(OldValues).Append("\n");
            
            sb.Append("  NewValues: ").Append(NewValues).Append("\n");
            
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
            return this.Equals(obj as Change);
        }

        /// <summary>
        /// Returns true if Change instances are equal
        /// </summary>
        /// <param name="other">Instance of Change to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Change other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) &&
                (
                    this.OldValues == other.OldValues ||
                    this.OldValues != null &&
                    this.OldValues.SequenceEqual(other.OldValues)
                ) &&
                (
                    this.NewValues == other.NewValues ||
                    this.NewValues != null &&
                    this.NewValues.SequenceEqual(other.NewValues)
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
                
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                
                if (this.OldValues != null)
                    hash = hash * 59 + this.OldValues.GetHashCode();
                
                if (this.NewValues != null)
                    hash = hash * 59 + this.NewValues.GetHashCode();
                
                return hash;
            }
        }
    }

}
