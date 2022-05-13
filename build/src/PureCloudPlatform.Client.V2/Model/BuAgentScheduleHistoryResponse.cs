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
    /// BuAgentScheduleHistoryResponse
    /// </summary>
    [DataContract]
    public partial class BuAgentScheduleHistoryResponse :  IEquatable<BuAgentScheduleHistoryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAgentScheduleHistoryResponse" /> class.
        /// </summary>
        /// <param name="PriorPublishedSchedules">The list of previously published schedules.</param>
        /// <param name="BasePublishedSchedule">The originally published agent schedules.</param>
        /// <param name="DroppedChanges">The changes dropped from the schedule history. This will happen if the schedule history is too large.</param>
        /// <param name="Changes">The list of changes for the schedule history.</param>
        public BuAgentScheduleHistoryResponse(List<BuScheduleReference> PriorPublishedSchedules = null, BuAgentScheduleHistoryChange BasePublishedSchedule = null, List<BuAgentScheduleHistoryDroppedChange> DroppedChanges = null, List<BuAgentScheduleHistoryChange> Changes = null)
        {
            this.PriorPublishedSchedules = PriorPublishedSchedules;
            this.BasePublishedSchedule = BasePublishedSchedule;
            this.DroppedChanges = DroppedChanges;
            this.Changes = Changes;
            
        }
        


        /// <summary>
        /// The list of previously published schedules
        /// </summary>
        /// <value>The list of previously published schedules</value>
        [DataMember(Name="priorPublishedSchedules", EmitDefaultValue=false)]
        public List<BuScheduleReference> PriorPublishedSchedules { get; set; }



        /// <summary>
        /// The originally published agent schedules
        /// </summary>
        /// <value>The originally published agent schedules</value>
        [DataMember(Name="basePublishedSchedule", EmitDefaultValue=false)]
        public BuAgentScheduleHistoryChange BasePublishedSchedule { get; set; }



        /// <summary>
        /// The changes dropped from the schedule history. This will happen if the schedule history is too large
        /// </summary>
        /// <value>The changes dropped from the schedule history. This will happen if the schedule history is too large</value>
        [DataMember(Name="droppedChanges", EmitDefaultValue=false)]
        public List<BuAgentScheduleHistoryDroppedChange> DroppedChanges { get; set; }



        /// <summary>
        /// The list of changes for the schedule history
        /// </summary>
        /// <value>The list of changes for the schedule history</value>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public List<BuAgentScheduleHistoryChange> Changes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuAgentScheduleHistoryResponse {\n");

            sb.Append("  PriorPublishedSchedules: ").Append(PriorPublishedSchedules).Append("\n");
            sb.Append("  BasePublishedSchedule: ").Append(BasePublishedSchedule).Append("\n");
            sb.Append("  DroppedChanges: ").Append(DroppedChanges).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
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
            return this.Equals(obj as BuAgentScheduleHistoryResponse);
        }

        /// <summary>
        /// Returns true if BuAgentScheduleHistoryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAgentScheduleHistoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAgentScheduleHistoryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PriorPublishedSchedules == other.PriorPublishedSchedules ||
                    this.PriorPublishedSchedules != null &&
                    this.PriorPublishedSchedules.SequenceEqual(other.PriorPublishedSchedules)
                ) &&
                (
                    this.BasePublishedSchedule == other.BasePublishedSchedule ||
                    this.BasePublishedSchedule != null &&
                    this.BasePublishedSchedule.Equals(other.BasePublishedSchedule)
                ) &&
                (
                    this.DroppedChanges == other.DroppedChanges ||
                    this.DroppedChanges != null &&
                    this.DroppedChanges.SequenceEqual(other.DroppedChanges)
                ) &&
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
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
                if (this.PriorPublishedSchedules != null)
                    hash = hash * 59 + this.PriorPublishedSchedules.GetHashCode();

                if (this.BasePublishedSchedule != null)
                    hash = hash * 59 + this.BasePublishedSchedule.GetHashCode();

                if (this.DroppedChanges != null)
                    hash = hash * 59 + this.DroppedChanges.GetHashCode();

                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();

                return hash;
            }
        }
    }

}
