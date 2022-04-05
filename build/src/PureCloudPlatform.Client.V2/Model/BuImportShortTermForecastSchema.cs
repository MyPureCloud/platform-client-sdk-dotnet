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
    /// BuImportShortTermForecastSchema
    /// </summary>
    [DataContract]
    public partial class BuImportShortTermForecastSchema :  IEquatable<BuImportShortTermForecastSchema>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuImportShortTermForecastSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuImportShortTermForecastSchema() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuImportShortTermForecastSchema" /> class.
        /// </summary>
        /// <param name="Description">The description for the forecast (required).</param>
        /// <param name="WeekCount">The number of weeks covered by the forecast (required).</param>
        /// <param name="PlanningGroups">The short term planning group data (required).</param>
        /// <param name="LongTermPlanningGroups">The long term planning group data.</param>
        /// <param name="CanUseForScheduling">Whether this forecast can be used for scheduling.</param>
        public BuImportShortTermForecastSchema(string Description = null, int? WeekCount = null, List<ForecastPlanningGroupData> PlanningGroups = null, List<LongTermForecastPlanningGroupData> LongTermPlanningGroups = null, bool? CanUseForScheduling = null)
        {
            this.Description = Description;
            this.WeekCount = WeekCount;
            this.PlanningGroups = PlanningGroups;
            this.LongTermPlanningGroups = LongTermPlanningGroups;
            this.CanUseForScheduling = CanUseForScheduling;
            
        }
        
        
        
        /// <summary>
        /// The description for the forecast
        /// </summary>
        /// <value>The description for the forecast</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The number of weeks covered by the forecast
        /// </summary>
        /// <value>The number of weeks covered by the forecast</value>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }
        
        
        
        /// <summary>
        /// The short term planning group data
        /// </summary>
        /// <value>The short term planning group data</value>
        [DataMember(Name="planningGroups", EmitDefaultValue=false)]
        public List<ForecastPlanningGroupData> PlanningGroups { get; set; }
        
        
        
        /// <summary>
        /// The long term planning group data
        /// </summary>
        /// <value>The long term planning group data</value>
        [DataMember(Name="longTermPlanningGroups", EmitDefaultValue=false)]
        public List<LongTermForecastPlanningGroupData> LongTermPlanningGroups { get; set; }
        
        
        
        /// <summary>
        /// Whether this forecast can be used for scheduling
        /// </summary>
        /// <value>Whether this forecast can be used for scheduling</value>
        [DataMember(Name="canUseForScheduling", EmitDefaultValue=false)]
        public bool? CanUseForScheduling { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuImportShortTermForecastSchema {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
            sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
            sb.Append("  LongTermPlanningGroups: ").Append(LongTermPlanningGroups).Append("\n");
            sb.Append("  CanUseForScheduling: ").Append(CanUseForScheduling).Append("\n");
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
            return this.Equals(obj as BuImportShortTermForecastSchema);
        }

        /// <summary>
        /// Returns true if BuImportShortTermForecastSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of BuImportShortTermForecastSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuImportShortTermForecastSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.WeekCount == other.WeekCount ||
                    this.WeekCount != null &&
                    this.WeekCount.Equals(other.WeekCount)
                ) &&
                (
                    this.PlanningGroups == other.PlanningGroups ||
                    this.PlanningGroups != null &&
                    this.PlanningGroups.SequenceEqual(other.PlanningGroups)
                ) &&
                (
                    this.LongTermPlanningGroups == other.LongTermPlanningGroups ||
                    this.LongTermPlanningGroups != null &&
                    this.LongTermPlanningGroups.SequenceEqual(other.LongTermPlanningGroups)
                ) &&
                (
                    this.CanUseForScheduling == other.CanUseForScheduling ||
                    this.CanUseForScheduling != null &&
                    this.CanUseForScheduling.Equals(other.CanUseForScheduling)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();
                
                if (this.PlanningGroups != null)
                    hash = hash * 59 + this.PlanningGroups.GetHashCode();
                
                if (this.LongTermPlanningGroups != null)
                    hash = hash * 59 + this.LongTermPlanningGroups.GetHashCode();
                
                if (this.CanUseForScheduling != null)
                    hash = hash * 59 + this.CanUseForScheduling.GetHashCode();
                
                return hash;
            }
        }
    }

}
