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
    /// AllocationResultsTemplate
    /// </summary>
    [DataContract]
    public partial class AllocationResultsTemplate :  IEquatable<AllocationResultsTemplate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationResultsTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AllocationResultsTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationResultsTemplate" /> class.
        /// </summary>
        /// <param name="PlanningGroupId">The ID of the associated planning group (required).</param>
        /// <param name="AssignedAgentsPerInterval">Assigned agent allocation per interval used to generate the performance prediction (required).</param>
        /// <param name="HeadcountMultiplierPerInterval">Headcount multiplier per interval used to generate the performance prediction (required).</param>
        public AllocationResultsTemplate(string PlanningGroupId = null, List<double?> AssignedAgentsPerInterval = null, List<double?> HeadcountMultiplierPerInterval = null)
        {
            this.PlanningGroupId = PlanningGroupId;
            this.AssignedAgentsPerInterval = AssignedAgentsPerInterval;
            this.HeadcountMultiplierPerInterval = HeadcountMultiplierPerInterval;
            
        }
        


        /// <summary>
        /// The ID of the associated planning group
        /// </summary>
        /// <value>The ID of the associated planning group</value>
        [DataMember(Name="planningGroupId", EmitDefaultValue=false)]
        public string PlanningGroupId { get; set; }



        /// <summary>
        /// Assigned agent allocation per interval used to generate the performance prediction
        /// </summary>
        /// <value>Assigned agent allocation per interval used to generate the performance prediction</value>
        [DataMember(Name="assignedAgentsPerInterval", EmitDefaultValue=false)]
        public List<double?> AssignedAgentsPerInterval { get; set; }



        /// <summary>
        /// Headcount multiplier per interval used to generate the performance prediction
        /// </summary>
        /// <value>Headcount multiplier per interval used to generate the performance prediction</value>
        [DataMember(Name="headcountMultiplierPerInterval", EmitDefaultValue=false)]
        public List<double?> HeadcountMultiplierPerInterval { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllocationResultsTemplate {\n");

            sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
            sb.Append("  AssignedAgentsPerInterval: ").Append(AssignedAgentsPerInterval).Append("\n");
            sb.Append("  HeadcountMultiplierPerInterval: ").Append(HeadcountMultiplierPerInterval).Append("\n");
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
            return this.Equals(obj as AllocationResultsTemplate);
        }

        /// <summary>
        /// Returns true if AllocationResultsTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of AllocationResultsTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllocationResultsTemplate other)
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
                    this.AssignedAgentsPerInterval == other.AssignedAgentsPerInterval ||
                    this.AssignedAgentsPerInterval != null &&
                    this.AssignedAgentsPerInterval.SequenceEqual(other.AssignedAgentsPerInterval)
                ) &&
                (
                    this.HeadcountMultiplierPerInterval == other.HeadcountMultiplierPerInterval ||
                    this.HeadcountMultiplierPerInterval != null &&
                    this.HeadcountMultiplierPerInterval.SequenceEqual(other.HeadcountMultiplierPerInterval)
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

                if (this.AssignedAgentsPerInterval != null)
                    hash = hash * 59 + this.AssignedAgentsPerInterval.GetHashCode();

                if (this.HeadcountMultiplierPerInterval != null)
                    hash = hash * 59 + this.HeadcountMultiplierPerInterval.GetHashCode();

                return hash;
            }
        }
    }

}
