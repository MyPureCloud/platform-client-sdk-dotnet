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
    /// CapacityPlanForecastPlanningGroup
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastPlanningGroup :  IEquatable<CapacityPlanForecastPlanningGroup>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastPlanningGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastPlanningGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastPlanningGroup" /> class.
        /// </summary>
        /// <param name="PlanningGroupId">The ID of the planning group to which the forecast applies (required).</param>
        /// <param name="Actual">Absolute forecast values for offered counts and average handle time for this planning group. Exactly one of actual or distribution must be provided.</param>
        /// <param name="Distribution">Hourly forecast distribution values for offered volume and average handle time for this planning group. Exactly one of actual or distribution must be provided.</param>
        public CapacityPlanForecastPlanningGroup(string PlanningGroupId = null, CapacityPlanForecastActualValues Actual = null, CapacityPlanForecastDistributionValues Distribution = null)
        {
            this.PlanningGroupId = PlanningGroupId;
            this.Actual = Actual;
            this.Distribution = Distribution;
            
        }
        


        /// <summary>
        /// The ID of the planning group to which the forecast applies
        /// </summary>
        /// <value>The ID of the planning group to which the forecast applies</value>
        [DataMember(Name="planningGroupId", EmitDefaultValue=false)]
        public string PlanningGroupId { get; set; }



        /// <summary>
        /// Absolute forecast values for offered counts and average handle time for this planning group. Exactly one of actual or distribution must be provided
        /// </summary>
        /// <value>Absolute forecast values for offered counts and average handle time for this planning group. Exactly one of actual or distribution must be provided</value>
        [DataMember(Name="actual", EmitDefaultValue=false)]
        public CapacityPlanForecastActualValues Actual { get; set; }



        /// <summary>
        /// Hourly forecast distribution values for offered volume and average handle time for this planning group. Exactly one of actual or distribution must be provided
        /// </summary>
        /// <value>Hourly forecast distribution values for offered volume and average handle time for this planning group. Exactly one of actual or distribution must be provided</value>
        [DataMember(Name="distribution", EmitDefaultValue=false)]
        public CapacityPlanForecastDistributionValues Distribution { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastPlanningGroup {\n");

            sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
            sb.Append("  Actual: ").Append(Actual).Append("\n");
            sb.Append("  Distribution: ").Append(Distribution).Append("\n");
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
            return this.Equals(obj as CapacityPlanForecastPlanningGroup);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastPlanningGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastPlanningGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastPlanningGroup other)
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
                    this.Actual == other.Actual ||
                    this.Actual != null &&
                    this.Actual.Equals(other.Actual)
                ) &&
                (
                    this.Distribution == other.Distribution ||
                    this.Distribution != null &&
                    this.Distribution.Equals(other.Distribution)
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

                if (this.Actual != null)
                    hash = hash * 59 + this.Actual.GetHashCode();

                if (this.Distribution != null)
                    hash = hash * 59 + this.Distribution.GetHashCode();

                return hash;
            }
        }
    }

}
