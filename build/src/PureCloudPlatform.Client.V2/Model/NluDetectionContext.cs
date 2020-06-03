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
    /// NluDetectionContext
    /// </summary>
    [DataContract]
    public partial class NluDetectionContext :  IEquatable<NluDetectionContext>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluDetectionContext" /> class.
        /// </summary>
        /// <param name="Intent">Restrict detection to this intent..</param>
        /// <param name="Entity">Use this entity to restrict detection..</param>
        public NluDetectionContext(ContextIntent Intent = null, ContextEntity Entity = null)
        {
            this.Intent = Intent;
            this.Entity = Entity;
            
        }
        
        
        
        /// <summary>
        /// Restrict detection to this intent.
        /// </summary>
        /// <value>Restrict detection to this intent.</value>
        [DataMember(Name="intent", EmitDefaultValue=false)]
        public ContextIntent Intent { get; set; }
        
        
        
        /// <summary>
        /// Use this entity to restrict detection.
        /// </summary>
        /// <value>Use this entity to restrict detection.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public ContextEntity Entity { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NluDetectionContext {\n");
            
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
            return this.Equals(obj as NluDetectionContext);
        }

        /// <summary>
        /// Returns true if NluDetectionContext instances are equal
        /// </summary>
        /// <param name="other">Instance of NluDetectionContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluDetectionContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Intent == other.Intent ||
                    this.Intent != null &&
                    this.Intent.Equals(other.Intent)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
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
                
                if (this.Intent != null)
                    hash = hash * 59 + this.Intent.GetHashCode();
                
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                
                return hash;
            }
        }
    }

}
