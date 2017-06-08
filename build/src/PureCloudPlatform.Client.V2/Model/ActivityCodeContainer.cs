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
    /// Container for a map of ActivityCodeId to ActivityCode
    /// </summary>
    [DataContract]
    public partial class ActivityCodeContainer :  IEquatable<ActivityCodeContainer>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCodeContainer" /> class.
        /// </summary>
        
        
        /// <param name="ActivityCodes">Map of activity code id to activity code.</param>
        
        
        public ActivityCodeContainer(Dictionary<string, ActivityCode> ActivityCodes = null)
        {
            
            
            
            
            
            
            
            
            
            
this.ActivityCodes = ActivityCodes;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Map of activity code id to activity code
        /// </summary>
        /// <value>Map of activity code id to activity code</value>
        [DataMember(Name="activityCodes", EmitDefaultValue=false)]
        public Dictionary<string, ActivityCode> ActivityCodes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityCodeContainer {\n");
            
            sb.Append("  ActivityCodes: ").Append(ActivityCodes).Append("\n");
            
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
            return this.Equals(obj as ActivityCodeContainer);
        }

        /// <summary>
        /// Returns true if ActivityCodeContainer instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityCodeContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityCodeContainer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActivityCodes == other.ActivityCodes ||
                    this.ActivityCodes != null &&
                    this.ActivityCodes.SequenceEqual(other.ActivityCodes)
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
                
                if (this.ActivityCodes != null)
                    hash = hash * 59 + this.ActivityCodes.GetHashCode();
                
                return hash;
            }
        }
    }

}
