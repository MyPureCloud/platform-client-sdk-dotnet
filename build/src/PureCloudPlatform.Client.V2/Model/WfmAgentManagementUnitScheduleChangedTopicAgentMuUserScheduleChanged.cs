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
    /// WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged
    /// </summary>
    [DataContract]
    public partial class WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged :  IEquatable<WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged" /> class.
        /// </summary>
        /// <param name="AgentId">AgentId.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        public WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged(string AgentId = null, DateTime? StartDate = null, DateTime? EndDate = null)
        {
            this.AgentId = AgentId;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            
        }
        


        /// <summary>
        /// Gets or Sets AgentId
        /// </summary>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged {\n");

            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(obj as WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged);
        }

        /// <summary>
        /// Returns true if WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
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
                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                return hash;
            }
        }
    }

}
