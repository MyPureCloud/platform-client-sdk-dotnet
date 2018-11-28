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
    /// DialerCallabletimesetConfigChangeTimeSlot
    /// </summary>
    [DataContract]
    public partial class DialerCallabletimesetConfigChangeTimeSlot :  IEquatable<DialerCallabletimesetConfigChangeTimeSlot>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCallabletimesetConfigChangeTimeSlot" /> class.
        /// </summary>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="StopTime">StopTime.</param>
        /// <param name="Day">Day.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public DialerCallabletimesetConfigChangeTimeSlot(string StartTime = null, string StopTime = null, int? Day = null, Object AdditionalProperties = null)
        {
            this.StartTime = StartTime;
            this.StopTime = StopTime;
            this.Day = Day;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets StopTime
        /// </summary>
        [DataMember(Name="stopTime", EmitDefaultValue=false)]
        public string StopTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public int? Day { get; set; }
        
        
        
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
            sb.Append("class DialerCallabletimesetConfigChangeTimeSlot {\n");
            
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StopTime: ").Append(StopTime).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
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
            return this.Equals(obj as DialerCallabletimesetConfigChangeTimeSlot);
        }

        /// <summary>
        /// Returns true if DialerCallabletimesetConfigChangeTimeSlot instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCallabletimesetConfigChangeTimeSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCallabletimesetConfigChangeTimeSlot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.StopTime == other.StopTime ||
                    this.StopTime != null &&
                    this.StopTime.Equals(other.StopTime)
                ) &&
                (
                    this.Day == other.Day ||
                    this.Day != null &&
                    this.Day.Equals(other.Day)
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
                
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                
                if (this.StopTime != null)
                    hash = hash * 59 + this.StopTime.GetHashCode();
                
                if (this.Day != null)
                    hash = hash * 59 + this.Day.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
