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
    /// WfmBuScheduleTopicBuScheduleGenerationResultSummary
    /// </summary>
    [DataContract]
    public partial class WfmBuScheduleTopicBuScheduleGenerationResultSummary :  IEquatable<WfmBuScheduleTopicBuScheduleGenerationResultSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuScheduleTopicBuScheduleGenerationResultSummary" /> class.
        /// </summary>
        /// <param name="Failed">Failed.</param>
        /// <param name="RunId">RunId.</param>
        /// <param name="MessageCount">MessageCount.</param>
        /// <param name="MessageSeverityCounts">MessageSeverityCounts.</param>
        public WfmBuScheduleTopicBuScheduleGenerationResultSummary(bool? Failed = null, string RunId = null, int? MessageCount = null, List<WfmBuScheduleTopicSchedulerMessageSeverityCount> MessageSeverityCounts = null)
        {
            this.Failed = Failed;
            this.RunId = RunId;
            this.MessageCount = MessageCount;
            this.MessageSeverityCounts = MessageSeverityCounts;
            
        }
        


        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public bool? Failed { get; set; }



        /// <summary>
        /// Gets or Sets RunId
        /// </summary>
        [DataMember(Name="runId", EmitDefaultValue=false)]
        public string RunId { get; set; }



        /// <summary>
        /// Gets or Sets MessageCount
        /// </summary>
        [DataMember(Name="messageCount", EmitDefaultValue=false)]
        public int? MessageCount { get; set; }



        /// <summary>
        /// Gets or Sets MessageSeverityCounts
        /// </summary>
        [DataMember(Name="messageSeverityCounts", EmitDefaultValue=false)]
        public List<WfmBuScheduleTopicSchedulerMessageSeverityCount> MessageSeverityCounts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuScheduleTopicBuScheduleGenerationResultSummary {\n");

            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
            sb.Append("  MessageSeverityCounts: ").Append(MessageSeverityCounts).Append("\n");
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
            return this.Equals(obj as WfmBuScheduleTopicBuScheduleGenerationResultSummary);
        }

        /// <summary>
        /// Returns true if WfmBuScheduleTopicBuScheduleGenerationResultSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuScheduleTopicBuScheduleGenerationResultSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuScheduleTopicBuScheduleGenerationResultSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Failed == other.Failed ||
                    this.Failed != null &&
                    this.Failed.Equals(other.Failed)
                ) &&
                (
                    this.RunId == other.RunId ||
                    this.RunId != null &&
                    this.RunId.Equals(other.RunId)
                ) &&
                (
                    this.MessageCount == other.MessageCount ||
                    this.MessageCount != null &&
                    this.MessageCount.Equals(other.MessageCount)
                ) &&
                (
                    this.MessageSeverityCounts == other.MessageSeverityCounts ||
                    this.MessageSeverityCounts != null &&
                    this.MessageSeverityCounts.SequenceEqual(other.MessageSeverityCounts)
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
                if (this.Failed != null)
                    hash = hash * 59 + this.Failed.GetHashCode();

                if (this.RunId != null)
                    hash = hash * 59 + this.RunId.GetHashCode();

                if (this.MessageCount != null)
                    hash = hash * 59 + this.MessageCount.GetHashCode();

                if (this.MessageSeverityCounts != null)
                    hash = hash * 59 + this.MessageSeverityCounts.GetHashCode();

                return hash;
            }
        }
    }

}
