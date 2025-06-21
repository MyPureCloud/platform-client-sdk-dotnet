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
    /// AgentQueueTimeRequest
    /// </summary>
    [DataContract]
    public partial class AgentQueueTimeRequest :  IEquatable<AgentQueueTimeRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentQueueTimeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentQueueTimeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentQueueTimeRequest" /> class.
        /// </summary>
        /// <param name="AgentId">ID of the agent (required).</param>
        /// <param name="StartOffsetMinutes">List of offsets in minutes from calculationStartDate (required).</param>
        /// <param name="OnQueueLengthMinutesPerInterval">List of on-queue time lengths in minutes per interval of elements in startOffsetMinutes (required).</param>
        /// <param name="OnQueueActivityCodeIds">List of on-queue activity code ids.</param>
        public AgentQueueTimeRequest(string AgentId = null, List<int?> StartOffsetMinutes = null, List<int?> OnQueueLengthMinutesPerInterval = null, List<string> OnQueueActivityCodeIds = null)
        {
            this.AgentId = AgentId;
            this.StartOffsetMinutes = StartOffsetMinutes;
            this.OnQueueLengthMinutesPerInterval = OnQueueLengthMinutesPerInterval;
            this.OnQueueActivityCodeIds = OnQueueActivityCodeIds;
            
        }
        


        /// <summary>
        /// ID of the agent
        /// </summary>
        /// <value>ID of the agent</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// List of offsets in minutes from calculationStartDate
        /// </summary>
        /// <value>List of offsets in minutes from calculationStartDate</value>
        [DataMember(Name="startOffsetMinutes", EmitDefaultValue=false)]
        public List<int?> StartOffsetMinutes { get; set; }



        /// <summary>
        /// List of on-queue time lengths in minutes per interval of elements in startOffsetMinutes
        /// </summary>
        /// <value>List of on-queue time lengths in minutes per interval of elements in startOffsetMinutes</value>
        [DataMember(Name="onQueueLengthMinutesPerInterval", EmitDefaultValue=false)]
        public List<int?> OnQueueLengthMinutesPerInterval { get; set; }



        /// <summary>
        /// List of on-queue activity code ids
        /// </summary>
        /// <value>List of on-queue activity code ids</value>
        [DataMember(Name="onQueueActivityCodeIds", EmitDefaultValue=false)]
        public List<string> OnQueueActivityCodeIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentQueueTimeRequest {\n");

            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  StartOffsetMinutes: ").Append(StartOffsetMinutes).Append("\n");
            sb.Append("  OnQueueLengthMinutesPerInterval: ").Append(OnQueueLengthMinutesPerInterval).Append("\n");
            sb.Append("  OnQueueActivityCodeIds: ").Append(OnQueueActivityCodeIds).Append("\n");
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
            return this.Equals(obj as AgentQueueTimeRequest);
        }

        /// <summary>
        /// Returns true if AgentQueueTimeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentQueueTimeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentQueueTimeRequest other)
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
                    this.StartOffsetMinutes == other.StartOffsetMinutes ||
                    this.StartOffsetMinutes != null &&
                    this.StartOffsetMinutes.SequenceEqual(other.StartOffsetMinutes)
                ) &&
                (
                    this.OnQueueLengthMinutesPerInterval == other.OnQueueLengthMinutesPerInterval ||
                    this.OnQueueLengthMinutesPerInterval != null &&
                    this.OnQueueLengthMinutesPerInterval.SequenceEqual(other.OnQueueLengthMinutesPerInterval)
                ) &&
                (
                    this.OnQueueActivityCodeIds == other.OnQueueActivityCodeIds ||
                    this.OnQueueActivityCodeIds != null &&
                    this.OnQueueActivityCodeIds.SequenceEqual(other.OnQueueActivityCodeIds)
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

                if (this.StartOffsetMinutes != null)
                    hash = hash * 59 + this.StartOffsetMinutes.GetHashCode();

                if (this.OnQueueLengthMinutesPerInterval != null)
                    hash = hash * 59 + this.OnQueueLengthMinutesPerInterval.GetHashCode();

                if (this.OnQueueActivityCodeIds != null)
                    hash = hash * 59 + this.OnQueueActivityCodeIds.GetHashCode();

                return hash;
            }
        }
    }

}
