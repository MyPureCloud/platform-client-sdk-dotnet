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
    /// SelfScheduleOffersActivityMoveTemplate
    /// </summary>
    [DataContract]
    public partial class SelfScheduleOffersActivityMoveTemplate :  IEquatable<SelfScheduleOffersActivityMoveTemplate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleOffersActivityMoveTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelfScheduleOffersActivityMoveTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleOffersActivityMoveTemplate" /> class.
        /// </summary>
        /// <param name="Schedule">The schedule associated with the shift the agent wants to edit. (required).</param>
        /// <param name="ShiftId">The ID of the shift to which the self-schedule activity move is associated (required).</param>
        /// <param name="ReferenceKey">The unique identifier for the offered shift edit that was used for this shift edit (required).</param>
        /// <param name="StartDate">The start date/time for the shift in ISO-8601 format (required).</param>
        /// <param name="LengthMinutes">The duration of this shift in minutes (required).</param>
        /// <param name="ActivityCode">The activity related to this shift (required).</param>
        /// <param name="AlternateStartDates">The alternative start dates for this shift (required).</param>
        public SelfScheduleOffersActivityMoveTemplate(BuScheduleReference Schedule = null, string ShiftId = null, string ReferenceKey = null, DateTime? StartDate = null, int? LengthMinutes = null, ActivityCodeReference ActivityCode = null, List<DateTime?> AlternateStartDates = null)
        {
            this.Schedule = Schedule;
            this.ShiftId = ShiftId;
            this.ReferenceKey = ReferenceKey;
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.ActivityCode = ActivityCode;
            this.AlternateStartDates = AlternateStartDates;
            
        }
        


        /// <summary>
        /// The schedule associated with the shift the agent wants to edit.
        /// </summary>
        /// <value>The schedule associated with the shift the agent wants to edit.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public BuScheduleReference Schedule { get; set; }



        /// <summary>
        /// The ID of the shift to which the self-schedule activity move is associated
        /// </summary>
        /// <value>The ID of the shift to which the self-schedule activity move is associated</value>
        [DataMember(Name="shiftId", EmitDefaultValue=false)]
        public string ShiftId { get; set; }



        /// <summary>
        /// The unique identifier for the offered shift edit that was used for this shift edit
        /// </summary>
        /// <value>The unique identifier for the offered shift edit that was used for this shift edit</value>
        [DataMember(Name="referenceKey", EmitDefaultValue=false)]
        public string ReferenceKey { get; set; }



        /// <summary>
        /// The start date/time for the shift in ISO-8601 format
        /// </summary>
        /// <value>The start date/time for the shift in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The duration of this shift in minutes
        /// </summary>
        /// <value>The duration of this shift in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// The activity related to this shift
        /// </summary>
        /// <value>The activity related to this shift</value>
        [DataMember(Name="activityCode", EmitDefaultValue=false)]
        public ActivityCodeReference ActivityCode { get; set; }



        /// <summary>
        /// The alternative start dates for this shift
        /// </summary>
        /// <value>The alternative start dates for this shift</value>
        [DataMember(Name="alternateStartDates", EmitDefaultValue=false)]
        public List<DateTime?> AlternateStartDates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelfScheduleOffersActivityMoveTemplate {\n");

            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  ShiftId: ").Append(ShiftId).Append("\n");
            sb.Append("  ReferenceKey: ").Append(ReferenceKey).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
            sb.Append("  AlternateStartDates: ").Append(AlternateStartDates).Append("\n");
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
            return this.Equals(obj as SelfScheduleOffersActivityMoveTemplate);
        }

        /// <summary>
        /// Returns true if SelfScheduleOffersActivityMoveTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of SelfScheduleOffersActivityMoveTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelfScheduleOffersActivityMoveTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.ShiftId == other.ShiftId ||
                    this.ShiftId != null &&
                    this.ShiftId.Equals(other.ShiftId)
                ) &&
                (
                    this.ReferenceKey == other.ReferenceKey ||
                    this.ReferenceKey != null &&
                    this.ReferenceKey.Equals(other.ReferenceKey)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.ActivityCode == other.ActivityCode ||
                    this.ActivityCode != null &&
                    this.ActivityCode.Equals(other.ActivityCode)
                ) &&
                (
                    this.AlternateStartDates == other.AlternateStartDates ||
                    this.AlternateStartDates != null &&
                    this.AlternateStartDates.SequenceEqual(other.AlternateStartDates)
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
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.ShiftId != null)
                    hash = hash * 59 + this.ShiftId.GetHashCode();

                if (this.ReferenceKey != null)
                    hash = hash * 59 + this.ReferenceKey.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.ActivityCode != null)
                    hash = hash * 59 + this.ActivityCode.GetHashCode();

                if (this.AlternateStartDates != null)
                    hash = hash * 59 + this.AlternateStartDates.GetHashCode();

                return hash;
            }
        }
    }

}
