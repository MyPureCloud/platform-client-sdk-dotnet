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
    /// AgentAssignedScheduleSetList
    /// </summary>
    [DataContract]
    public partial class AgentAssignedScheduleSetList :  IEquatable<AgentAssignedScheduleSetList>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAssignedScheduleSetList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentAssignedScheduleSetList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAssignedScheduleSetList" /> class.
        /// </summary>
        /// <param name="AgentAssignedShiftSets">The shift sets, along with the assigned agents (required).</param>
        public AgentAssignedScheduleSetList(List<AgentAssignedShiftSet> AgentAssignedShiftSets = null)
        {
            this.AgentAssignedShiftSets = AgentAssignedShiftSets;
            
        }
        


        /// <summary>
        /// The shift sets, along with the assigned agents
        /// </summary>
        /// <value>The shift sets, along with the assigned agents</value>
        [DataMember(Name="agentAssignedShiftSets", EmitDefaultValue=false)]
        public List<AgentAssignedShiftSet> AgentAssignedShiftSets { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentAssignedScheduleSetList {\n");

            sb.Append("  AgentAssignedShiftSets: ").Append(AgentAssignedShiftSets).Append("\n");
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
            return this.Equals(obj as AgentAssignedScheduleSetList);
        }

        /// <summary>
        /// Returns true if AgentAssignedScheduleSetList instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentAssignedScheduleSetList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentAssignedScheduleSetList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentAssignedShiftSets == other.AgentAssignedShiftSets ||
                    this.AgentAssignedShiftSets != null &&
                    this.AgentAssignedShiftSets.SequenceEqual(other.AgentAssignedShiftSets)
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
                if (this.AgentAssignedShiftSets != null)
                    hash = hash * 59 + this.AgentAssignedShiftSets.GetHashCode();

                return hash;
            }
        }
    }

}
