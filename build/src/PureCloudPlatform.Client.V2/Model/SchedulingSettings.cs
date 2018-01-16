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
    /// Scheduling Settings
    /// </summary>
    [DataContract]
    public partial class SchedulingSettings :  IEquatable<SchedulingSettings>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingSettings" /> class.
        /// </summary>
        
        
        /// <param name="MaxOccupancyPercentForDeferredWork">Max occupancy percent for deferred work.</param>
        
        
        
        /// <param name="DefaultShrinkagePercent">Default shrinkage percent for scheduling.</param>
        
        
        
        /// <param name="ShrinkageOverrides">Shrinkage overrides for scheduling.</param>
        
        
        public SchedulingSettings(int? MaxOccupancyPercentForDeferredWork = null, double? DefaultShrinkagePercent = null, ShrinkageOverrides ShrinkageOverrides = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.MaxOccupancyPercentForDeferredWork = MaxOccupancyPercentForDeferredWork;
            
            
            
            
            
            
            
            
this.DefaultShrinkagePercent = DefaultShrinkagePercent;
            
            
            
            
            
            
            
            
this.ShrinkageOverrides = ShrinkageOverrides;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Max occupancy percent for deferred work
        /// </summary>
        /// <value>Max occupancy percent for deferred work</value>
        [DataMember(Name="maxOccupancyPercentForDeferredWork", EmitDefaultValue=false)]
        public int? MaxOccupancyPercentForDeferredWork { get; set; }
        
        
        
        /// <summary>
        /// Default shrinkage percent for scheduling
        /// </summary>
        /// <value>Default shrinkage percent for scheduling</value>
        [DataMember(Name="defaultShrinkagePercent", EmitDefaultValue=false)]
        public double? DefaultShrinkagePercent { get; set; }
        
        
        
        /// <summary>
        /// Shrinkage overrides for scheduling
        /// </summary>
        /// <value>Shrinkage overrides for scheduling</value>
        [DataMember(Name="shrinkageOverrides", EmitDefaultValue=false)]
        public ShrinkageOverrides ShrinkageOverrides { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulingSettings {\n");
            
            sb.Append("  MaxOccupancyPercentForDeferredWork: ").Append(MaxOccupancyPercentForDeferredWork).Append("\n");
            
            sb.Append("  DefaultShrinkagePercent: ").Append(DefaultShrinkagePercent).Append("\n");
            
            sb.Append("  ShrinkageOverrides: ").Append(ShrinkageOverrides).Append("\n");
            
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
            return this.Equals(obj as SchedulingSettings);
        }

        /// <summary>
        /// Returns true if SchedulingSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of SchedulingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MaxOccupancyPercentForDeferredWork == other.MaxOccupancyPercentForDeferredWork ||
                    this.MaxOccupancyPercentForDeferredWork != null &&
                    this.MaxOccupancyPercentForDeferredWork.Equals(other.MaxOccupancyPercentForDeferredWork)
                ) &&
                (
                    this.DefaultShrinkagePercent == other.DefaultShrinkagePercent ||
                    this.DefaultShrinkagePercent != null &&
                    this.DefaultShrinkagePercent.Equals(other.DefaultShrinkagePercent)
                ) &&
                (
                    this.ShrinkageOverrides == other.ShrinkageOverrides ||
                    this.ShrinkageOverrides != null &&
                    this.ShrinkageOverrides.Equals(other.ShrinkageOverrides)
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
                
                if (this.MaxOccupancyPercentForDeferredWork != null)
                    hash = hash * 59 + this.MaxOccupancyPercentForDeferredWork.GetHashCode();
                
                if (this.DefaultShrinkagePercent != null)
                    hash = hash * 59 + this.DefaultShrinkagePercent.GetHashCode();
                
                if (this.ShrinkageOverrides != null)
                    hash = hash * 59 + this.ShrinkageOverrides.GetHashCode();
                
                return hash;
            }
        }
    }

}
