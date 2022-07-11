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
    /// UserScheduleShift
    /// </summary>
    [DataContract]
    public partial class UserScheduleShift :  IEquatable<UserScheduleShift>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserScheduleShift" /> class.
        /// </summary>
        /// <param name="Id">ID of the schedule shift. This is only for the case of updating and deleting an existing shift.</param>
        /// <param name="Activities">List of activities in this shift.</param>
        /// <param name="Delete">If marked true for updating this schedule shift, it will be deleted.</param>
        /// <param name="ManuallyEdited">Whether the shift was set as manually edited.</param>
        public UserScheduleShift(string Id = null, List<UserScheduleActivity> Activities = null, bool? Delete = null, bool? ManuallyEdited = null)
        {
            this.Id = Id;
            this.Activities = Activities;
            this.Delete = Delete;
            this.ManuallyEdited = ManuallyEdited;
            
        }
        


        /// <summary>
        /// The schedule to which this shift belongs
        /// </summary>
        /// <value>The schedule to which this shift belongs</value>
        [DataMember(Name="weekSchedule", EmitDefaultValue=false)]
        public WeekScheduleReference WeekSchedule { get; private set; }



        /// <summary>
        /// ID of the schedule shift. This is only for the case of updating and deleting an existing shift
        /// </summary>
        /// <value>ID of the schedule shift. This is only for the case of updating and deleting an existing shift</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Start time in UTC for this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Start time in UTC for this shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; private set; }



        /// <summary>
        /// Length of this shift in minutes
        /// </summary>
        /// <value>Length of this shift in minutes</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; private set; }



        /// <summary>
        /// List of activities in this shift
        /// </summary>
        /// <value>List of activities in this shift</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<UserScheduleActivity> Activities { get; set; }



        /// <summary>
        /// If marked true for updating this schedule shift, it will be deleted
        /// </summary>
        /// <value>If marked true for updating this schedule shift, it will be deleted</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }



        /// <summary>
        /// Whether the shift was set as manually edited
        /// </summary>
        /// <value>Whether the shift was set as manually edited</value>
        [DataMember(Name="manuallyEdited", EmitDefaultValue=false)]
        public bool? ManuallyEdited { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserScheduleShift {\n");

            sb.Append("  WeekSchedule: ").Append(WeekSchedule).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  ManuallyEdited: ").Append(ManuallyEdited).Append("\n");
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
            return this.Equals(obj as UserScheduleShift);
        }

        /// <summary>
        /// Returns true if UserScheduleShift instances are equal
        /// </summary>
        /// <param name="other">Instance of UserScheduleShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserScheduleShift other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekSchedule == other.WeekSchedule ||
                    this.WeekSchedule != null &&
                    this.WeekSchedule.Equals(other.WeekSchedule)
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
                ) &&
                (
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
                ) &&
                (
                    this.ManuallyEdited == other.ManuallyEdited ||
                    this.ManuallyEdited != null &&
                    this.ManuallyEdited.Equals(other.ManuallyEdited)
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
                if (this.WeekSchedule != null)
                    hash = hash * 59 + this.WeekSchedule.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();

                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();

                if (this.ManuallyEdited != null)
                    hash = hash * 59 + this.ManuallyEdited.GetHashCode();

                return hash;
            }
        }
    }

}
