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
    /// ScheduleBidScheduledShift
    /// </summary>
    [DataContract]
    public partial class ScheduleBidScheduledShift :  IEquatable<ScheduleBidScheduledShift>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidScheduledShift" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleBidScheduledShift() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidScheduledShift" /> class.
        /// </summary>
        /// <param name="WorkPlanShiftId">The ID of the work plan shift that was used in schedule generation.</param>
        /// <param name="WorkPlanId">The ID of the work plan from which the shift comes.</param>
        /// <param name="StartDate">The start date of the scheduled shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="LengthMinutes">The length of the shift in minutes (required).</param>
        /// <param name="Activities">The activities associated with this shift (required).</param>
        public ScheduleBidScheduledShift(string WorkPlanShiftId = null, string WorkPlanId = null, DateTime? StartDate = null, int? LengthMinutes = null, List<ScheduleBidScheduledActivity> Activities = null)
        {
            this.WorkPlanShiftId = WorkPlanShiftId;
            this.WorkPlanId = WorkPlanId;
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.Activities = Activities;
            
        }
        


        /// <summary>
        /// The ID of the work plan shift that was used in schedule generation
        /// </summary>
        /// <value>The ID of the work plan shift that was used in schedule generation</value>
        [DataMember(Name="workPlanShiftId", EmitDefaultValue=false)]
        public string WorkPlanShiftId { get; set; }



        /// <summary>
        /// The ID of the work plan from which the shift comes
        /// </summary>
        /// <value>The ID of the work plan from which the shift comes</value>
        [DataMember(Name="workPlanId", EmitDefaultValue=false)]
        public string WorkPlanId { get; set; }



        /// <summary>
        /// The start date of the scheduled shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start date of the scheduled shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The length of the shift in minutes
        /// </summary>
        /// <value>The length of the shift in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// The activities associated with this shift
        /// </summary>
        /// <value>The activities associated with this shift</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<ScheduleBidScheduledActivity> Activities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleBidScheduledShift {\n");

            sb.Append("  WorkPlanShiftId: ").Append(WorkPlanShiftId).Append("\n");
            sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
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
            return this.Equals(obj as ScheduleBidScheduledShift);
        }

        /// <summary>
        /// Returns true if ScheduleBidScheduledShift instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleBidScheduledShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleBidScheduledShift other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WorkPlanShiftId == other.WorkPlanShiftId ||
                    this.WorkPlanShiftId != null &&
                    this.WorkPlanShiftId.Equals(other.WorkPlanShiftId)
                ) &&
                (
                    this.WorkPlanId == other.WorkPlanId ||
                    this.WorkPlanId != null &&
                    this.WorkPlanId.Equals(other.WorkPlanId)
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
                if (this.WorkPlanShiftId != null)
                    hash = hash * 59 + this.WorkPlanShiftId.GetHashCode();

                if (this.WorkPlanId != null)
                    hash = hash * 59 + this.WorkPlanId.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();

                return hash;
            }
        }
    }

}
