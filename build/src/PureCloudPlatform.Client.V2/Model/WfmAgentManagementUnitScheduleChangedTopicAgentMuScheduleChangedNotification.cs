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
    /// WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification
    /// </summary>
    [DataContract]
    public partial class WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification :  IEquatable<WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification" /> class.
        /// </summary>
        /// <param name="Agents">Agents.</param>
        /// <param name="VisibilityRange">VisibilityRange.</param>
        public WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification(List<WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged> Agents = null, WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleVisibilityRange VisibilityRange = null)
        {
            this.Agents = Agents;
            this.VisibilityRange = VisibilityRange;
            
        }
        


        /// <summary>
        /// Gets or Sets Agents
        /// </summary>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<WfmAgentManagementUnitScheduleChangedTopicAgentMuUserScheduleChanged> Agents { get; set; }



        /// <summary>
        /// Gets or Sets VisibilityRange
        /// </summary>
        [DataMember(Name="visibilityRange", EmitDefaultValue=false)]
        public WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleVisibilityRange VisibilityRange { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification {\n");

            sb.Append("  Agents: ").Append(Agents).Append("\n");
            sb.Append("  VisibilityRange: ").Append(VisibilityRange).Append("\n");
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
            return this.Equals(obj as WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification);
        }

        /// <summary>
        /// Returns true if WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmAgentManagementUnitScheduleChangedTopicAgentMuScheduleChangedNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Agents == other.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(other.Agents)
                ) &&
                (
                    this.VisibilityRange == other.VisibilityRange ||
                    this.VisibilityRange != null &&
                    this.VisibilityRange.Equals(other.VisibilityRange)
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
                if (this.Agents != null)
                    hash = hash * 59 + this.Agents.GetHashCode();

                if (this.VisibilityRange != null)
                    hash = hash * 59 + this.VisibilityRange.GetHashCode();

                return hash;
            }
        }
    }

}
