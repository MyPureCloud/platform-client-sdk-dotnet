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
    /// Represents a single activity in a user&#39;s shift
    /// </summary>
    [DataContract]
    public partial class UserScheduleActivity :  IEquatable<UserScheduleActivity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserScheduleActivity" /> class.
        /// </summary>
        /// <param name="ActivityCodeId">The id for the activity code.  Look up a map of activity codes with the activities route.</param>
        /// <param name="StartDate">Start time in UTC for this activity, in ISO-8601 format.</param>
        /// <param name="LengthInMinutes">Length in minutes for this activity.</param>
        /// <param name="Description">Description for this activity.</param>
        /// <param name="CountsAsPaidTime">Whether this activity is paid.</param>
        /// <param name="IsDstFallback">Whether this activity spans a DST fallback.</param>
        /// <param name="TimeOffRequestId">Time off request id of this activity.</param>
        public UserScheduleActivity(string ActivityCodeId = null, DateTime? StartDate = null, int? LengthInMinutes = null, string Description = null, bool? CountsAsPaidTime = null, bool? IsDstFallback = null, string TimeOffRequestId = null)
        {
            this.ActivityCodeId = ActivityCodeId;
            this.StartDate = StartDate;
            this.LengthInMinutes = LengthInMinutes;
            this.Description = Description;
            this.CountsAsPaidTime = CountsAsPaidTime;
            this.IsDstFallback = IsDstFallback;
            this.TimeOffRequestId = TimeOffRequestId;
            
        }
        


        /// <summary>
        /// The id for the activity code.  Look up a map of activity codes with the activities route
        /// </summary>
        /// <value>The id for the activity code.  Look up a map of activity codes with the activities route</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Start time in UTC for this activity, in ISO-8601 format
        /// </summary>
        /// <value>Start time in UTC for this activity, in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// Length in minutes for this activity
        /// </summary>
        /// <value>Length in minutes for this activity</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }



        /// <summary>
        /// Description for this activity
        /// </summary>
        /// <value>Description for this activity</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Whether this activity is paid
        /// </summary>
        /// <value>Whether this activity is paid</value>
        [DataMember(Name="countsAsPaidTime", EmitDefaultValue=false)]
        public bool? CountsAsPaidTime { get; set; }



        /// <summary>
        /// Whether this activity spans a DST fallback
        /// </summary>
        /// <value>Whether this activity spans a DST fallback</value>
        [DataMember(Name="isDstFallback", EmitDefaultValue=false)]
        public bool? IsDstFallback { get; set; }



        /// <summary>
        /// Time off request id of this activity
        /// </summary>
        /// <value>Time off request id of this activity</value>
        [DataMember(Name="timeOffRequestId", EmitDefaultValue=false)]
        public string TimeOffRequestId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserScheduleActivity {\n");

            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
            sb.Append("  IsDstFallback: ").Append(IsDstFallback).Append("\n");
            sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
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
            return this.Equals(obj as UserScheduleActivity);
        }

        /// <summary>
        /// Returns true if UserScheduleActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of UserScheduleActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserScheduleActivity other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.CountsAsPaidTime == other.CountsAsPaidTime ||
                    this.CountsAsPaidTime != null &&
                    this.CountsAsPaidTime.Equals(other.CountsAsPaidTime)
                ) &&
                (
                    this.IsDstFallback == other.IsDstFallback ||
                    this.IsDstFallback != null &&
                    this.IsDstFallback.Equals(other.IsDstFallback)
                ) &&
                (
                    this.TimeOffRequestId == other.TimeOffRequestId ||
                    this.TimeOffRequestId != null &&
                    this.TimeOffRequestId.Equals(other.TimeOffRequestId)
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

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.CountsAsPaidTime != null)
                    hash = hash * 59 + this.CountsAsPaidTime.GetHashCode();

                if (this.IsDstFallback != null)
                    hash = hash * 59 + this.IsDstFallback.GetHashCode();

                if (this.TimeOffRequestId != null)
                    hash = hash * 59 + this.TimeOffRequestId.GetHashCode();

                return hash;
            }
        }
    }

}
