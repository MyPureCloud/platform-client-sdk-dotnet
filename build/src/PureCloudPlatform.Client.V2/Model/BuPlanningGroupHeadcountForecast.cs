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
    /// BuPlanningGroupHeadcountForecast
    /// </summary>
    [DataContract]
    public partial class BuPlanningGroupHeadcountForecast :  IEquatable<BuPlanningGroupHeadcountForecast>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuPlanningGroupHeadcountForecast" /> class.
        /// </summary>
        /// <param name="PlanningGroup">The planning group to which this portion of the headcount forecast applies.</param>
        /// <param name="RequiredPerInterval">Required headcount per interval, referenced against the reference start date.</param>
        /// <param name="RequiredWithoutShrinkagePerInterval">Required headcount per interval without accounting for shrinkage, referenced against the reference start date.</param>
        public BuPlanningGroupHeadcountForecast(PlanningGroupReference PlanningGroup = null, List<double?> RequiredPerInterval = null, List<double?> RequiredWithoutShrinkagePerInterval = null)
        {
            this.PlanningGroup = PlanningGroup;
            this.RequiredPerInterval = RequiredPerInterval;
            this.RequiredWithoutShrinkagePerInterval = RequiredWithoutShrinkagePerInterval;
            
        }
        
        
        
        /// <summary>
        /// The planning group to which this portion of the headcount forecast applies
        /// </summary>
        /// <value>The planning group to which this portion of the headcount forecast applies</value>
        [DataMember(Name="planningGroup", EmitDefaultValue=false)]
        public PlanningGroupReference PlanningGroup { get; set; }
        
        
        
        /// <summary>
        /// Required headcount per interval, referenced against the reference start date
        /// </summary>
        /// <value>Required headcount per interval, referenced against the reference start date</value>
        [DataMember(Name="requiredPerInterval", EmitDefaultValue=false)]
        public List<double?> RequiredPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Required headcount per interval without accounting for shrinkage, referenced against the reference start date
        /// </summary>
        /// <value>Required headcount per interval without accounting for shrinkage, referenced against the reference start date</value>
        [DataMember(Name="requiredWithoutShrinkagePerInterval", EmitDefaultValue=false)]
        public List<double?> RequiredWithoutShrinkagePerInterval { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuPlanningGroupHeadcountForecast {\n");
            
            sb.Append("  PlanningGroup: ").Append(PlanningGroup).Append("\n");
            sb.Append("  RequiredPerInterval: ").Append(RequiredPerInterval).Append("\n");
            sb.Append("  RequiredWithoutShrinkagePerInterval: ").Append(RequiredWithoutShrinkagePerInterval).Append("\n");
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
            return this.Equals(obj as BuPlanningGroupHeadcountForecast);
        }

        /// <summary>
        /// Returns true if BuPlanningGroupHeadcountForecast instances are equal
        /// </summary>
        /// <param name="other">Instance of BuPlanningGroupHeadcountForecast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuPlanningGroupHeadcountForecast other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PlanningGroup == other.PlanningGroup ||
                    this.PlanningGroup != null &&
                    this.PlanningGroup.Equals(other.PlanningGroup)
                ) &&
                (
                    this.RequiredPerInterval == other.RequiredPerInterval ||
                    this.RequiredPerInterval != null &&
                    this.RequiredPerInterval.SequenceEqual(other.RequiredPerInterval)
                ) &&
                (
                    this.RequiredWithoutShrinkagePerInterval == other.RequiredWithoutShrinkagePerInterval ||
                    this.RequiredWithoutShrinkagePerInterval != null &&
                    this.RequiredWithoutShrinkagePerInterval.SequenceEqual(other.RequiredWithoutShrinkagePerInterval)
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
                
                if (this.PlanningGroup != null)
                    hash = hash * 59 + this.PlanningGroup.GetHashCode();
                
                if (this.RequiredPerInterval != null)
                    hash = hash * 59 + this.RequiredPerInterval.GetHashCode();
                
                if (this.RequiredWithoutShrinkagePerInterval != null)
                    hash = hash * 59 + this.RequiredWithoutShrinkagePerInterval.GetHashCode();
                
                return hash;
            }
        }
    }

}
