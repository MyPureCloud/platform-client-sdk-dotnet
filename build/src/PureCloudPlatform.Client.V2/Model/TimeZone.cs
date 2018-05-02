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
    /// TimeZone
    /// </summary>
    [DataContract]
    public partial class TimeZone :  IEquatable<TimeZone>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeZone" /> class.
        /// </summary>
        
        
        /// <param name="Dstsavings">Dstsavings.</param>
        
        
        
        /// <param name="RawOffset">RawOffset.</param>
        
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="DisplayName">DisplayName.</param>
        
        
        public TimeZone(int? Dstsavings = null, int? RawOffset = null, string Id = null, string DisplayName = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Dstsavings = Dstsavings;
            
            
            
            
            
            
            
            
this.RawOffset = RawOffset;
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.DisplayName = DisplayName;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Dstsavings
        /// </summary>
        [DataMember(Name="dstsavings", EmitDefaultValue=false)]
        public int? Dstsavings { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RawOffset
        /// </summary>
        [DataMember(Name="rawOffset", EmitDefaultValue=false)]
        public int? RawOffset { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeZone {\n");
            
            sb.Append("  Dstsavings: ").Append(Dstsavings).Append("\n");
            
            sb.Append("  RawOffset: ").Append(RawOffset).Append("\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            
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
            return this.Equals(obj as TimeZone);
        }

        /// <summary>
        /// Returns true if TimeZone instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeZone other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Dstsavings == other.Dstsavings ||
                    this.Dstsavings != null &&
                    this.Dstsavings.Equals(other.Dstsavings)
                ) &&
                (
                    this.RawOffset == other.RawOffset ||
                    this.RawOffset != null &&
                    this.RawOffset.Equals(other.RawOffset)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
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
                
                if (this.Dstsavings != null)
                    hash = hash * 59 + this.Dstsavings.GetHashCode();
                
                if (this.RawOffset != null)
                    hash = hash * 59 + this.RawOffset.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                return hash;
            }
        }
    }

}
