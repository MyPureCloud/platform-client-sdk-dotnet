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
    /// Override the value of a single interval in a forecast
    /// </summary>
    [DataContract]
    public partial class WfmForecastModificationIntervalOffsetValue :  IEquatable<WfmForecastModificationIntervalOffsetValue>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmForecastModificationIntervalOffsetValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmForecastModificationIntervalOffsetValue() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmForecastModificationIntervalOffsetValue" /> class.
        /// </summary>
        /// <param name="IntervalIndex">The number of 15 minute intervals past referenceStartDate to which to apply this modification (required).</param>
        /// <param name="Value">The value to set for the given interval (required).</param>
        public WfmForecastModificationIntervalOffsetValue(int? IntervalIndex = null, double? Value = null)
        {
            this.IntervalIndex = IntervalIndex;
            this.Value = Value;
            
        }
        
        
        
        /// <summary>
        /// The number of 15 minute intervals past referenceStartDate to which to apply this modification
        /// </summary>
        /// <value>The number of 15 minute intervals past referenceStartDate to which to apply this modification</value>
        [DataMember(Name="intervalIndex", EmitDefaultValue=false)]
        public int? IntervalIndex { get; set; }
        
        
        
        /// <summary>
        /// The value to set for the given interval
        /// </summary>
        /// <value>The value to set for the given interval</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmForecastModificationIntervalOffsetValue {\n");
            
            sb.Append("  IntervalIndex: ").Append(IntervalIndex).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as WfmForecastModificationIntervalOffsetValue);
        }

        /// <summary>
        /// Returns true if WfmForecastModificationIntervalOffsetValue instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmForecastModificationIntervalOffsetValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmForecastModificationIntervalOffsetValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IntervalIndex == other.IntervalIndex ||
                    this.IntervalIndex != null &&
                    this.IntervalIndex.Equals(other.IntervalIndex)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                
                if (this.IntervalIndex != null)
                    hash = hash * 59 + this.IntervalIndex.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                return hash;
            }
        }
    }

}
