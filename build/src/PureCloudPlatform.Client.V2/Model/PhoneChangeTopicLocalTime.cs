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
    /// PhoneChangeTopicLocalTime
    /// </summary>
    [DataContract]
    public partial class PhoneChangeTopicLocalTime :  IEquatable<PhoneChangeTopicLocalTime>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneChangeTopicLocalTime" /> class.
        /// </summary>
        /// <param name="Hour">Hour.</param>
        /// <param name="Minute">Minute.</param>
        /// <param name="Second">Second.</param>
        /// <param name="Nano">Nano.</param>
        public PhoneChangeTopicLocalTime(int? Hour = null, int? Minute = null, int? Second = null, int? Nano = null)
        {
            this.Hour = Hour;
            this.Minute = Minute;
            this.Second = Second;
            this.Nano = Nano;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Hour
        /// </summary>
        [DataMember(Name="hour", EmitDefaultValue=false)]
        public int? Hour { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Minute
        /// </summary>
        [DataMember(Name="minute", EmitDefaultValue=false)]
        public int? Minute { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Second
        /// </summary>
        [DataMember(Name="second", EmitDefaultValue=false)]
        public int? Second { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Nano
        /// </summary>
        [DataMember(Name="nano", EmitDefaultValue=false)]
        public int? Nano { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneChangeTopicLocalTime {\n");
            
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  Minute: ").Append(Minute).Append("\n");
            sb.Append("  Second: ").Append(Second).Append("\n");
            sb.Append("  Nano: ").Append(Nano).Append("\n");
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
            return this.Equals(obj as PhoneChangeTopicLocalTime);
        }

        /// <summary>
        /// Returns true if PhoneChangeTopicLocalTime instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneChangeTopicLocalTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneChangeTopicLocalTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Hour == other.Hour ||
                    this.Hour != null &&
                    this.Hour.Equals(other.Hour)
                ) &&
                (
                    this.Minute == other.Minute ||
                    this.Minute != null &&
                    this.Minute.Equals(other.Minute)
                ) &&
                (
                    this.Second == other.Second ||
                    this.Second != null &&
                    this.Second.Equals(other.Second)
                ) &&
                (
                    this.Nano == other.Nano ||
                    this.Nano != null &&
                    this.Nano.Equals(other.Nano)
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
                
                if (this.Hour != null)
                    hash = hash * 59 + this.Hour.GetHashCode();
                
                if (this.Minute != null)
                    hash = hash * 59 + this.Minute.GetHashCode();
                
                if (this.Second != null)
                    hash = hash * 59 + this.Second.GetHashCode();
                
                if (this.Nano != null)
                    hash = hash * 59 + this.Nano.GetHashCode();
                
                return hash;
            }
        }
    }

}
