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
    /// AlternativeShiftAgentScheduledShift
    /// </summary>
    [DataContract]
    public partial class AlternativeShiftAgentScheduledShift :  IEquatable<AlternativeShiftAgentScheduledShift>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeShiftAgentScheduledShift" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlternativeShiftAgentScheduledShift() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeShiftAgentScheduledShift" /> class.
        /// </summary>
        /// <param name="DayIndex">The number of days since start of schedule (required).</param>
        /// <param name="ReferenceKey">A key generated for an offer to help facilitate alternative shift trading (required).</param>
        /// <param name="StartDate">The start date of this shift in ISO-8601 format (required).</param>
        /// <param name="LengthMinutes">The length of this shift in minutes (required).</param>
        /// <param name="Activities">A list of activities in this shift (required).</param>
        public AlternativeShiftAgentScheduledShift(int? DayIndex = null, string ReferenceKey = null, DateTime? StartDate = null, int? LengthMinutes = null, List<BuAgentScheduleActivity> Activities = null)
        {
            this.DayIndex = DayIndex;
            this.ReferenceKey = ReferenceKey;
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.Activities = Activities;
            
        }
        


        /// <summary>
        /// The number of days since start of schedule
        /// </summary>
        /// <value>The number of days since start of schedule</value>
        [DataMember(Name="dayIndex", EmitDefaultValue=false)]
        public int? DayIndex { get; set; }



        /// <summary>
        /// A key generated for an offer to help facilitate alternative shift trading
        /// </summary>
        /// <value>A key generated for an offer to help facilitate alternative shift trading</value>
        [DataMember(Name="referenceKey", EmitDefaultValue=false)]
        public string ReferenceKey { get; set; }



        /// <summary>
        /// The start date of this shift in ISO-8601 format
        /// </summary>
        /// <value>The start date of this shift in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The length of this shift in minutes
        /// </summary>
        /// <value>The length of this shift in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// A list of activities in this shift
        /// </summary>
        /// <value>A list of activities in this shift</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<BuAgentScheduleActivity> Activities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlternativeShiftAgentScheduledShift {\n");

            sb.Append("  DayIndex: ").Append(DayIndex).Append("\n");
            sb.Append("  ReferenceKey: ").Append(ReferenceKey).Append("\n");
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
            return this.Equals(obj as AlternativeShiftAgentScheduledShift);
        }

        /// <summary>
        /// Returns true if AlternativeShiftAgentScheduledShift instances are equal
        /// </summary>
        /// <param name="other">Instance of AlternativeShiftAgentScheduledShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlternativeShiftAgentScheduledShift other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DayIndex == other.DayIndex ||
                    this.DayIndex != null &&
                    this.DayIndex.Equals(other.DayIndex)
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
                if (this.DayIndex != null)
                    hash = hash * 59 + this.DayIndex.GetHashCode();

                if (this.ReferenceKey != null)
                    hash = hash * 59 + this.ReferenceKey.GetHashCode();

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
