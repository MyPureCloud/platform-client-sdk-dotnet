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
    /// DialerCallabletimesetConfigChangeCallableTime
    /// </summary>
    [DataContract]
    public partial class DialerCallabletimesetConfigChangeCallableTime :  IEquatable<DialerCallabletimesetConfigChangeCallableTime>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCallabletimesetConfigChangeCallableTime" /> class.
        /// </summary>
        /// <param name="TimeSlots">TimeSlots.</param>
        /// <param name="TimeZoneId">TimeZoneId.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public DialerCallabletimesetConfigChangeCallableTime(List<DialerCallabletimesetConfigChangeTimeSlot> TimeSlots = null, string TimeZoneId = null, Object AdditionalProperties = null)
        {
            this.TimeSlots = TimeSlots;
            this.TimeZoneId = TimeZoneId;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets TimeSlots
        /// </summary>
        [DataMember(Name="timeSlots", EmitDefaultValue=false)]
        public List<DialerCallabletimesetConfigChangeTimeSlot> TimeSlots { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TimeZoneId
        /// </summary>
        [DataMember(Name="timeZoneId", EmitDefaultValue=false)]
        public string TimeZoneId { get; set; }
        
        
        
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
            sb.Append("class DialerCallabletimesetConfigChangeCallableTime {\n");
            
            sb.Append("  TimeSlots: ").Append(TimeSlots).Append("\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
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
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DialerCallabletimesetConfigChangeCallableTime);
        }

        /// <summary>
        /// Returns true if DialerCallabletimesetConfigChangeCallableTime instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCallabletimesetConfigChangeCallableTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCallabletimesetConfigChangeCallableTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeSlots == other.TimeSlots ||
                    this.TimeSlots != null &&
                    this.TimeSlots.SequenceEqual(other.TimeSlots)
                ) &&
                (
                    this.TimeZoneId == other.TimeZoneId ||
                    this.TimeZoneId != null &&
                    this.TimeZoneId.Equals(other.TimeZoneId)
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
                
                if (this.TimeSlots != null)
                    hash = hash * 59 + this.TimeSlots.GetHashCode();
                
                if (this.TimeZoneId != null)
                    hash = hash * 59 + this.TimeZoneId.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
