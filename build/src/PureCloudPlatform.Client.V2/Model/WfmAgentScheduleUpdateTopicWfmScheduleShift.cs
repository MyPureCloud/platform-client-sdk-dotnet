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
    /// WfmAgentScheduleUpdateTopicWfmScheduleShift
    /// </summary>
    [DataContract]
    public partial class WfmAgentScheduleUpdateTopicWfmScheduleShift :  IEquatable<WfmAgentScheduleUpdateTopicWfmScheduleShift>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAgentScheduleUpdateTopicWfmScheduleShift" /> class.
        /// </summary>
        /// <param name="WeekDate">WeekDate.</param>
        /// <param name="WeekScheduleId">WeekScheduleId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="LengthInMinutes">LengthInMinutes.</param>
        /// <param name="Activities">Activities.</param>
        public WfmAgentScheduleUpdateTopicWfmScheduleShift(string WeekDate = null, string WeekScheduleId = null, string Id = null, DateTime? StartDate = null, int? LengthInMinutes = null, List<WfmAgentScheduleUpdateTopicWfmScheduleActivity> Activities = null)
        {
            this.WeekDate = WeekDate;
            this.WeekScheduleId = WeekScheduleId;
            this.Id = Id;
            this.StartDate = StartDate;
            this.LengthInMinutes = LengthInMinutes;
            this.Activities = Activities;
            
        }
        


        /// <summary>
        /// Gets or Sets WeekDate
        /// </summary>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public string WeekDate { get; set; }



        /// <summary>
        /// Gets or Sets WeekScheduleId
        /// </summary>
        [DataMember(Name="weekScheduleId", EmitDefaultValue=false)]
        public string WeekScheduleId { get; set; }



        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// Gets or Sets LengthInMinutes
        /// </summary>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }



        /// <summary>
        /// Gets or Sets Activities
        /// </summary>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<WfmAgentScheduleUpdateTopicWfmScheduleActivity> Activities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmAgentScheduleUpdateTopicWfmScheduleShift {\n");

            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  WeekScheduleId: ").Append(WeekScheduleId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
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
            return this.Equals(obj as WfmAgentScheduleUpdateTopicWfmScheduleShift);
        }

        /// <summary>
        /// Returns true if WfmAgentScheduleUpdateTopicWfmScheduleShift instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmAgentScheduleUpdateTopicWfmScheduleShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmAgentScheduleUpdateTopicWfmScheduleShift other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.WeekScheduleId == other.WeekScheduleId ||
                    this.WeekScheduleId != null &&
                    this.WeekScheduleId.Equals(other.WeekScheduleId)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
                ) &&
                (
                    this.Activities == other.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(other.Activities)
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
                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                if (this.WeekScheduleId != null)
                    hash = hash * 59 + this.WeekScheduleId.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();

                return hash;
            }
        }
    }

}
