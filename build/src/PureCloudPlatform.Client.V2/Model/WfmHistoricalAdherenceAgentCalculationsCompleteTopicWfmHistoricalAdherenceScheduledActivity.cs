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
    /// WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity :  IEquatable<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity" /> class.
        /// </summary>
        /// <param name="ActivityCodeId">ActivityCodeId.</param>
        /// <param name="StartOffsetSeconds">StartOffsetSeconds.</param>
        /// <param name="EndOffsetSeconds">EndOffsetSeconds.</param>
        public WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity(string ActivityCodeId = null, long? StartOffsetSeconds = null, long? EndOffsetSeconds = null)
        {
            this.ActivityCodeId = ActivityCodeId;
            this.StartOffsetSeconds = StartOffsetSeconds;
            this.EndOffsetSeconds = EndOffsetSeconds;
            
        }
        


        /// <summary>
        /// Gets or Sets ActivityCodeId
        /// </summary>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Gets or Sets StartOffsetSeconds
        /// </summary>
        [DataMember(Name="startOffsetSeconds", EmitDefaultValue=false)]
        public long? StartOffsetSeconds { get; set; }



        /// <summary>
        /// Gets or Sets EndOffsetSeconds
        /// </summary>
        [DataMember(Name="endOffsetSeconds", EmitDefaultValue=false)]
        public long? EndOffsetSeconds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity {\n");

            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  StartOffsetSeconds: ").Append(StartOffsetSeconds).Append("\n");
            sb.Append("  EndOffsetSeconds: ").Append(EndOffsetSeconds).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.StartOffsetSeconds == other.StartOffsetSeconds ||
                    this.StartOffsetSeconds != null &&
                    this.StartOffsetSeconds.Equals(other.StartOffsetSeconds)
                ) &&
                (
                    this.EndOffsetSeconds == other.EndOffsetSeconds ||
                    this.EndOffsetSeconds != null &&
                    this.EndOffsetSeconds.Equals(other.EndOffsetSeconds)
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
                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.StartOffsetSeconds != null)
                    hash = hash * 59 + this.StartOffsetSeconds.GetHashCode();

                if (this.EndOffsetSeconds != null)
                    hash = hash * 59 + this.EndOffsetSeconds.GetHashCode();

                return hash;
            }
        }
    }

}
