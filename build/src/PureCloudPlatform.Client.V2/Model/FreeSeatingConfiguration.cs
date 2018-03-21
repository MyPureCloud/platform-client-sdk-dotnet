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
    /// FreeSeatingConfiguration
    /// </summary>
    [DataContract]
    public partial class FreeSeatingConfiguration :  IEquatable<FreeSeatingConfiguration>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FreeSeatingConfiguration" /> class.
        /// </summary>
        
        
        /// <param name="Enabled">Whether or not free-seating is enabled for the organization.</param>
        
        
        
        /// <param name="TtlMinutes">The amount of time in minutes until an offline user is disassociated from their station.</param>
        
        
        public FreeSeatingConfiguration(bool? Enabled = null, int? TtlMinutes = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Enabled = Enabled;
            
            
            
            
            
            
            
            
this.TtlMinutes = TtlMinutes;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Whether or not free-seating is enabled for the organization
        /// </summary>
        /// <value>Whether or not free-seating is enabled for the organization</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// The amount of time in minutes until an offline user is disassociated from their station
        /// </summary>
        /// <value>The amount of time in minutes until an offline user is disassociated from their station</value>
        [DataMember(Name="ttlMinutes", EmitDefaultValue=false)]
        public int? TtlMinutes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeSeatingConfiguration {\n");
            
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            
            sb.Append("  TtlMinutes: ").Append(TtlMinutes).Append("\n");
            
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
            return this.Equals(obj as FreeSeatingConfiguration);
        }

        /// <summary>
        /// Returns true if FreeSeatingConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of FreeSeatingConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FreeSeatingConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.TtlMinutes == other.TtlMinutes ||
                    this.TtlMinutes != null &&
                    this.TtlMinutes.Equals(other.TtlMinutes)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.TtlMinutes != null)
                    hash = hash * 59 + this.TtlMinutes.GetHashCode();
                
                return hash;
            }
        }
    }

}
