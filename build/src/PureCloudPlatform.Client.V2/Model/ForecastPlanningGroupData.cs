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
    /// ForecastPlanningGroupData
    /// </summary>
    [DataContract]
    public partial class ForecastPlanningGroupData :  IEquatable<ForecastPlanningGroupData>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastPlanningGroupData" /> class.
        /// </summary>
        /// <param name="PlanningGroupId">The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration.</param>
        /// <param name="OfferedPerInterval">Forecast offered counts per interval for this week of the forecast.</param>
        /// <param name="AverageHandleTimeSecondsPerInterval">Forecast average handle time per interval in seconds.</param>
        public ForecastPlanningGroupData(string PlanningGroupId = null, List<double?> OfferedPerInterval = null, List<double?> AverageHandleTimeSecondsPerInterval = null)
        {
            this.PlanningGroupId = PlanningGroupId;
            this.OfferedPerInterval = OfferedPerInterval;
            this.AverageHandleTimeSecondsPerInterval = AverageHandleTimeSecondsPerInterval;
            
        }
        
        
        
        /// <summary>
        /// The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration
        /// </summary>
        /// <value>The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration</value>
        [DataMember(Name="planningGroupId", EmitDefaultValue=false)]
        public string PlanningGroupId { get; set; }
        
        
        
        /// <summary>
        /// Forecast offered counts per interval for this week of the forecast
        /// </summary>
        /// <value>Forecast offered counts per interval for this week of the forecast</value>
        [DataMember(Name="offeredPerInterval", EmitDefaultValue=false)]
        public List<double?> OfferedPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Forecast average handle time per interval in seconds
        /// </summary>
        /// <value>Forecast average handle time per interval in seconds</value>
        [DataMember(Name="averageHandleTimeSecondsPerInterval", EmitDefaultValue=false)]
        public List<double?> AverageHandleTimeSecondsPerInterval { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastPlanningGroupData {\n");
            
            sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
            sb.Append("  OfferedPerInterval: ").Append(OfferedPerInterval).Append("\n");
            sb.Append("  AverageHandleTimeSecondsPerInterval: ").Append(AverageHandleTimeSecondsPerInterval).Append("\n");
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
            return this.Equals(obj as ForecastPlanningGroupData);
        }

        /// <summary>
        /// Returns true if ForecastPlanningGroupData instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastPlanningGroupData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastPlanningGroupData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PlanningGroupId == other.PlanningGroupId ||
                    this.PlanningGroupId != null &&
                    this.PlanningGroupId.Equals(other.PlanningGroupId)
                ) &&
                (
                    this.OfferedPerInterval == other.OfferedPerInterval ||
                    this.OfferedPerInterval != null &&
                    this.OfferedPerInterval.SequenceEqual(other.OfferedPerInterval)
                ) &&
                (
                    this.AverageHandleTimeSecondsPerInterval == other.AverageHandleTimeSecondsPerInterval ||
                    this.AverageHandleTimeSecondsPerInterval != null &&
                    this.AverageHandleTimeSecondsPerInterval.SequenceEqual(other.AverageHandleTimeSecondsPerInterval)
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
                
                if (this.PlanningGroupId != null)
                    hash = hash * 59 + this.PlanningGroupId.GetHashCode();
                
                if (this.OfferedPerInterval != null)
                    hash = hash * 59 + this.OfferedPerInterval.GetHashCode();
                
                if (this.AverageHandleTimeSecondsPerInterval != null)
                    hash = hash * 59 + this.AverageHandleTimeSecondsPerInterval.GetHashCode();
                
                return hash;
            }
        }
    }

}
