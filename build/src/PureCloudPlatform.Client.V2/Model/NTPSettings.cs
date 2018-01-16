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
    /// NTPSettings
    /// </summary>
    [DataContract]
    public partial class NTPSettings :  IEquatable<NTPSettings>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NTPSettings" /> class.
        /// </summary>
        
        
        /// <param name="Servers">List of NTP servers, in priority order.</param>
        
        
        public NTPSettings(List<string> Servers = null)
        {
            
            
            
            
            
            
            
            
            
            
this.Servers = Servers;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// List of NTP servers, in priority order
        /// </summary>
        /// <value>List of NTP servers, in priority order</value>
        [DataMember(Name="servers", EmitDefaultValue=false)]
        public List<string> Servers { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NTPSettings {\n");
            
            sb.Append("  Servers: ").Append(Servers).Append("\n");
            
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
            return this.Equals(obj as NTPSettings);
        }

        /// <summary>
        /// Returns true if NTPSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of NTPSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NTPSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Servers == other.Servers ||
                    this.Servers != null &&
                    this.Servers.SequenceEqual(other.Servers)
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
                
                if (this.Servers != null)
                    hash = hash * 59 + this.Servers.GetHashCode();
                
                return hash;
            }
        }
    }

}
