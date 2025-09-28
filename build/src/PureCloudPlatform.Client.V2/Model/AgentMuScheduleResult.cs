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
    /// AgentMuScheduleResult
    /// </summary>
    [DataContract]
    public partial class AgentMuScheduleResult :  IEquatable<AgentMuScheduleResult>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMuScheduleResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentMuScheduleResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMuScheduleResult" /> class.
        /// </summary>
        /// <param name="ReferenceStartDate">The reference start date to use when calculating offsets for shifts and activities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="AgentSchedules">The list of agent schedules for the management unit (required).</param>
        public AgentMuScheduleResult(DateTime? ReferenceStartDate = null, List<AgentMuScheduleItem> AgentSchedules = null)
        {
            this.ReferenceStartDate = ReferenceStartDate;
            this.AgentSchedules = AgentSchedules;
            
        }
        


        /// <summary>
        /// The reference start date to use when calculating offsets for shifts and activities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The reference start date to use when calculating offsets for shifts and activities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="referenceStartDate", EmitDefaultValue=false)]
        public DateTime? ReferenceStartDate { get; set; }



        /// <summary>
        /// The list of agent schedules for the management unit
        /// </summary>
        /// <value>The list of agent schedules for the management unit</value>
        [DataMember(Name="agentSchedules", EmitDefaultValue=false)]
        public List<AgentMuScheduleItem> AgentSchedules { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentMuScheduleResult {\n");

            sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
            sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
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
            return this.Equals(obj as AgentMuScheduleResult);
        }

        /// <summary>
        /// Returns true if AgentMuScheduleResult instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentMuScheduleResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentMuScheduleResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ReferenceStartDate == other.ReferenceStartDate ||
                    this.ReferenceStartDate != null &&
                    this.ReferenceStartDate.Equals(other.ReferenceStartDate)
                ) &&
                (
                    this.AgentSchedules == other.AgentSchedules ||
                    this.AgentSchedules != null &&
                    this.AgentSchedules.SequenceEqual(other.AgentSchedules)
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
                if (this.ReferenceStartDate != null)
                    hash = hash * 59 + this.ReferenceStartDate.GetHashCode();

                if (this.AgentSchedules != null)
                    hash = hash * 59 + this.AgentSchedules.GetHashCode();

                return hash;
            }
        }
    }

}
