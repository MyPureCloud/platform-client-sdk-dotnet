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
    /// BuAgentSchedulesQueryResponse
    /// </summary>
    [DataContract]
    public partial class BuAgentSchedulesQueryResponse :  IEquatable<BuAgentSchedulesQueryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAgentSchedulesQueryResponse" /> class.
        /// </summary>
        /// <param name="AgentSchedules">The requested agent schedules.</param>
        /// <param name="BusinessUnitTimeZone">The time zone configured for the business unit to which these schedules apply.</param>
        public BuAgentSchedulesQueryResponse(List<BuAgentScheduleQueryResponse> AgentSchedules = null, string BusinessUnitTimeZone = null)
        {
            this.AgentSchedules = AgentSchedules;
            this.BusinessUnitTimeZone = BusinessUnitTimeZone;
            
        }
        


        /// <summary>
        /// The requested agent schedules
        /// </summary>
        /// <value>The requested agent schedules</value>
        [DataMember(Name="agentSchedules", EmitDefaultValue=false)]
        public List<BuAgentScheduleQueryResponse> AgentSchedules { get; set; }



        /// <summary>
        /// The time zone configured for the business unit to which these schedules apply
        /// </summary>
        /// <value>The time zone configured for the business unit to which these schedules apply</value>
        [DataMember(Name="businessUnitTimeZone", EmitDefaultValue=false)]
        public string BusinessUnitTimeZone { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuAgentSchedulesQueryResponse {\n");

            sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
            sb.Append("  BusinessUnitTimeZone: ").Append(BusinessUnitTimeZone).Append("\n");
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
            return this.Equals(obj as BuAgentSchedulesQueryResponse);
        }

        /// <summary>
        /// Returns true if BuAgentSchedulesQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAgentSchedulesQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAgentSchedulesQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentSchedules == other.AgentSchedules ||
                    this.AgentSchedules != null &&
                    this.AgentSchedules.SequenceEqual(other.AgentSchedules)
                ) &&
                (
                    this.BusinessUnitTimeZone == other.BusinessUnitTimeZone ||
                    this.BusinessUnitTimeZone != null &&
                    this.BusinessUnitTimeZone.Equals(other.BusinessUnitTimeZone)
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
                if (this.AgentSchedules != null)
                    hash = hash * 59 + this.AgentSchedules.GetHashCode();

                if (this.BusinessUnitTimeZone != null)
                    hash = hash * 59 + this.BusinessUnitTimeZone.GetHashCode();

                return hash;
            }
        }
    }

}
