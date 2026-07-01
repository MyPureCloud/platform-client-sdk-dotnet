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
    /// ForecastInputPlanningGroupData
    /// </summary>
    [DataContract]
    public partial class ForecastInputPlanningGroupData :  IEquatable<ForecastInputPlanningGroupData>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastInputPlanningGroupData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForecastInputPlanningGroupData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastInputPlanningGroupData" /> class.
        /// </summary>
        /// <param name="PlanningGroupId">The ID of the planning group for which this data applies (required).</param>
        /// <param name="CapacityPlanForecastMetrics">The capacity plan forecast metrics for this planning group (required).</param>
        public ForecastInputPlanningGroupData(string PlanningGroupId = null, CapacityPlanForecastMetrics CapacityPlanForecastMetrics = null)
        {
            this.PlanningGroupId = PlanningGroupId;
            this.CapacityPlanForecastMetrics = CapacityPlanForecastMetrics;
            
        }
        


        /// <summary>
        /// The ID of the planning group for which this data applies
        /// </summary>
        /// <value>The ID of the planning group for which this data applies</value>
        [DataMember(Name="planningGroupId", EmitDefaultValue=false)]
        public string PlanningGroupId { get; set; }



        /// <summary>
        /// The capacity plan forecast metrics for this planning group
        /// </summary>
        /// <value>The capacity plan forecast metrics for this planning group</value>
        [DataMember(Name="capacityPlanForecastMetrics", EmitDefaultValue=false)]
        public CapacityPlanForecastMetrics CapacityPlanForecastMetrics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastInputPlanningGroupData {\n");

            sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
            sb.Append("  CapacityPlanForecastMetrics: ").Append(CapacityPlanForecastMetrics).Append("\n");
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
            return this.Equals(obj as ForecastInputPlanningGroupData);
        }

        /// <summary>
        /// Returns true if ForecastInputPlanningGroupData instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastInputPlanningGroupData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastInputPlanningGroupData other)
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
                    this.CapacityPlanForecastMetrics == other.CapacityPlanForecastMetrics ||
                    this.CapacityPlanForecastMetrics != null &&
                    this.CapacityPlanForecastMetrics.Equals(other.CapacityPlanForecastMetrics)
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

                if (this.CapacityPlanForecastMetrics != null)
                    hash = hash * 59 + this.CapacityPlanForecastMetrics.GetHashCode();

                return hash;
            }
        }
    }

}
