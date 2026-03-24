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
    /// PlanningGroupMinimumsRequest
    /// </summary>
    [DataContract]
    public partial class PlanningGroupMinimumsRequest :  IEquatable<PlanningGroupMinimumsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanningGroupMinimumsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlanningGroupMinimumsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanningGroupMinimumsRequest" /> class.
        /// </summary>
        /// <param name="PlanningGroupId">The ID of the planning group to which the day of week minimum staff values apply (required).</param>
        /// <param name="DayOfWeekMinimums">The list of day of week minimum staff values for this planning group (required).</param>
        public PlanningGroupMinimumsRequest(string PlanningGroupId = null, List<DayOfWeekMinimums> DayOfWeekMinimums = null)
        {
            this.PlanningGroupId = PlanningGroupId;
            this.DayOfWeekMinimums = DayOfWeekMinimums;
            
        }
        


        /// <summary>
        /// The ID of the planning group to which the day of week minimum staff values apply
        /// </summary>
        /// <value>The ID of the planning group to which the day of week minimum staff values apply</value>
        [DataMember(Name="planningGroupId", EmitDefaultValue=false)]
        public string PlanningGroupId { get; set; }



        /// <summary>
        /// The list of day of week minimum staff values for this planning group
        /// </summary>
        /// <value>The list of day of week minimum staff values for this planning group</value>
        [DataMember(Name="dayOfWeekMinimums", EmitDefaultValue=false)]
        public List<DayOfWeekMinimums> DayOfWeekMinimums { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanningGroupMinimumsRequest {\n");

            sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
            sb.Append("  DayOfWeekMinimums: ").Append(DayOfWeekMinimums).Append("\n");
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
            return this.Equals(obj as PlanningGroupMinimumsRequest);
        }

        /// <summary>
        /// Returns true if PlanningGroupMinimumsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanningGroupMinimumsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanningGroupMinimumsRequest other)
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
                    this.DayOfWeekMinimums == other.DayOfWeekMinimums ||
                    this.DayOfWeekMinimums != null &&
                    this.DayOfWeekMinimums.SequenceEqual(other.DayOfWeekMinimums)
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

                if (this.DayOfWeekMinimums != null)
                    hash = hash * 59 + this.DayOfWeekMinimums.GetHashCode();

                return hash;
            }
        }
    }

}
