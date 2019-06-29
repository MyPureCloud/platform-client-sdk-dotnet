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
    /// Service goal average speed of answer configuration
    /// </summary>
    [DataContract]
    public partial class WfmAverageSpeedOfAnswer :  IEquatable<WfmAverageSpeedOfAnswer>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAverageSpeedOfAnswer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmAverageSpeedOfAnswer() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAverageSpeedOfAnswer" /> class.
        /// </summary>
        /// <param name="Include">Whether to include average speed of answer (ASA) in the associated configuration (required).</param>
        /// <param name="Seconds">The target average speed of answer (ASA) in seconds. Required if include == true.</param>
        public WfmAverageSpeedOfAnswer(bool? Include = null, int? Seconds = null)
        {
            this.Include = Include;
            this.Seconds = Seconds;
            
        }
        
        
        
        /// <summary>
        /// Whether to include average speed of answer (ASA) in the associated configuration
        /// </summary>
        /// <value>Whether to include average speed of answer (ASA) in the associated configuration</value>
        [DataMember(Name="include", EmitDefaultValue=false)]
        public bool? Include { get; set; }
        
        
        
        /// <summary>
        /// The target average speed of answer (ASA) in seconds. Required if include == true
        /// </summary>
        /// <value>The target average speed of answer (ASA) in seconds. Required if include == true</value>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public int? Seconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmAverageSpeedOfAnswer {\n");
            
            sb.Append("  Include: ").Append(Include).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
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
            return this.Equals(obj as WfmAverageSpeedOfAnswer);
        }

        /// <summary>
        /// Returns true if WfmAverageSpeedOfAnswer instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmAverageSpeedOfAnswer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmAverageSpeedOfAnswer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Include == other.Include ||
                    this.Include != null &&
                    this.Include.Equals(other.Include)
                ) &&
                (
                    this.Seconds == other.Seconds ||
                    this.Seconds != null &&
                    this.Seconds.Equals(other.Seconds)
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
                
                if (this.Include != null)
                    hash = hash * 59 + this.Include.GetHashCode();
                
                if (this.Seconds != null)
                    hash = hash * 59 + this.Seconds.GetHashCode();
                
                return hash;
            }
        }
    }

}
