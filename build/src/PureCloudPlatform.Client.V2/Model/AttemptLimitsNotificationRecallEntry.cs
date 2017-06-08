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
    /// AttemptLimitsNotificationRecallEntry
    /// </summary>
    [DataContract]
    public partial class AttemptLimitsNotificationRecallEntry :  IEquatable<AttemptLimitsNotificationRecallEntry>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttemptLimitsNotificationRecallEntry" /> class.
        /// </summary>
        
        
        /// <param name="NbrAttempts">NbrAttempts.</param>
        
        
        
        /// <param name="MinutesBetweenAttempts">MinutesBetweenAttempts.</param>
        
        
        
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        
        
        public AttemptLimitsNotificationRecallEntry(int? NbrAttempts = null, int? MinutesBetweenAttempts = null, Object AdditionalProperties = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.NbrAttempts = NbrAttempts;
            
            
            
            
            
            
            
            
this.MinutesBetweenAttempts = MinutesBetweenAttempts;
            
            
            
            
            
            
            
            
this.AdditionalProperties = AdditionalProperties;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets NbrAttempts
        /// </summary>
        [DataMember(Name="nbrAttempts", EmitDefaultValue=false)]
        public int? NbrAttempts { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MinutesBetweenAttempts
        /// </summary>
        [DataMember(Name="minutesBetweenAttempts", EmitDefaultValue=false)]
        public int? MinutesBetweenAttempts { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttemptLimitsNotificationRecallEntry {\n");
            
            sb.Append("  NbrAttempts: ").Append(NbrAttempts).Append("\n");
            
            sb.Append("  MinutesBetweenAttempts: ").Append(MinutesBetweenAttempts).Append("\n");
            
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            
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
            return this.Equals(obj as AttemptLimitsNotificationRecallEntry);
        }

        /// <summary>
        /// Returns true if AttemptLimitsNotificationRecallEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of AttemptLimitsNotificationRecallEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttemptLimitsNotificationRecallEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.NbrAttempts == other.NbrAttempts ||
                    this.NbrAttempts != null &&
                    this.NbrAttempts.Equals(other.NbrAttempts)
                ) &&
                (
                    this.MinutesBetweenAttempts == other.MinutesBetweenAttempts ||
                    this.MinutesBetweenAttempts != null &&
                    this.MinutesBetweenAttempts.Equals(other.MinutesBetweenAttempts)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this.NbrAttempts != null)
                    hash = hash * 59 + this.NbrAttempts.GetHashCode();
                
                if (this.MinutesBetweenAttempts != null)
                    hash = hash * 59 + this.MinutesBetweenAttempts.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
