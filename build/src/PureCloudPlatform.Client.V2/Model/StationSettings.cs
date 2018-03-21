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
    /// Organization settings for stations
    /// </summary>
    [DataContract]
    public partial class StationSettings :  IEquatable<StationSettings>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StationSettings" /> class.
        /// </summary>
        
        
        /// <param name="FreeSeatingConfiguration">Configuration options for free-seating.</param>
        
        
        public StationSettings(FreeSeatingConfiguration FreeSeatingConfiguration = null)
        {
            
            
            
            
            
            
            
            
            
            
this.FreeSeatingConfiguration = FreeSeatingConfiguration;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Configuration options for free-seating
        /// </summary>
        /// <value>Configuration options for free-seating</value>
        [DataMember(Name="freeSeatingConfiguration", EmitDefaultValue=false)]
        public FreeSeatingConfiguration FreeSeatingConfiguration { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StationSettings {\n");
            
            sb.Append("  FreeSeatingConfiguration: ").Append(FreeSeatingConfiguration).Append("\n");
            
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
            return this.Equals(obj as StationSettings);
        }

        /// <summary>
        /// Returns true if StationSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of StationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StationSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FreeSeatingConfiguration == other.FreeSeatingConfiguration ||
                    this.FreeSeatingConfiguration != null &&
                    this.FreeSeatingConfiguration.Equals(other.FreeSeatingConfiguration)
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
                
                if (this.FreeSeatingConfiguration != null)
                    hash = hash * 59 + this.FreeSeatingConfiguration.GetHashCode();
                
                return hash;
            }
        }
    }

}
