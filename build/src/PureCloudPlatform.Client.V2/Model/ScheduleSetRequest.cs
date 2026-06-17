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
    /// ScheduleSetRequest
    /// </summary>
    [DataContract]
    public partial class ScheduleSetRequest :  IEquatable<ScheduleSetRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleSetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleSetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleSetRequest" /> class.
        /// </summary>
        /// <param name="ScheduleSetId">The ID of the schedule set (required).</param>
        /// <param name="OverrideAgentCount">The overridden agent count for the schedule set.</param>
        public ScheduleSetRequest(string ScheduleSetId = null, int? OverrideAgentCount = null)
        {
            this.ScheduleSetId = ScheduleSetId;
            this.OverrideAgentCount = OverrideAgentCount;
            
        }
        


        /// <summary>
        /// The ID of the schedule set
        /// </summary>
        /// <value>The ID of the schedule set</value>
        [DataMember(Name="scheduleSetId", EmitDefaultValue=false)]
        public string ScheduleSetId { get; set; }



        /// <summary>
        /// The overridden agent count for the schedule set
        /// </summary>
        /// <value>The overridden agent count for the schedule set</value>
        [DataMember(Name="overrideAgentCount", EmitDefaultValue=false)]
        public int? OverrideAgentCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleSetRequest {\n");

            sb.Append("  ScheduleSetId: ").Append(ScheduleSetId).Append("\n");
            sb.Append("  OverrideAgentCount: ").Append(OverrideAgentCount).Append("\n");
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
            return this.Equals(obj as ScheduleSetRequest);
        }

        /// <summary>
        /// Returns true if ScheduleSetRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleSetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleSetRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ScheduleSetId == other.ScheduleSetId ||
                    this.ScheduleSetId != null &&
                    this.ScheduleSetId.Equals(other.ScheduleSetId)
                ) &&
                (
                    this.OverrideAgentCount == other.OverrideAgentCount ||
                    this.OverrideAgentCount != null &&
                    this.OverrideAgentCount.Equals(other.OverrideAgentCount)
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
                if (this.ScheduleSetId != null)
                    hash = hash * 59 + this.ScheduleSetId.GetHashCode();

                if (this.OverrideAgentCount != null)
                    hash = hash * 59 + this.OverrideAgentCount.GetHashCode();

                return hash;
            }
        }
    }

}
