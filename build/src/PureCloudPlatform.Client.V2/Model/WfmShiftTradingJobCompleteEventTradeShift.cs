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
    /// WfmShiftTradingJobCompleteEventTradeShift
    /// </summary>
    [DataContract]
    public partial class WfmShiftTradingJobCompleteEventTradeShift :  IEquatable<WfmShiftTradingJobCompleteEventTradeShift>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShiftTradingJobCompleteEventTradeShift" /> class.
        /// </summary>
        /// <param name="ScheduleId">ScheduleId.</param>
        /// <param name="ScheduleStartDate">ScheduleStartDate.</param>
        /// <param name="ManagementUnitId">ManagementUnitId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="WeekDate">WeekDate.</param>
        public WfmShiftTradingJobCompleteEventTradeShift(string ScheduleId = null, string ScheduleStartDate = null, string ManagementUnitId = null, string Id = null, string StartDate = null, string EndDate = null, string WeekDate = null)
        {
            this.ScheduleId = ScheduleId;
            this.ScheduleStartDate = ScheduleStartDate;
            this.ManagementUnitId = ManagementUnitId;
            this.Id = Id;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.WeekDate = WeekDate;
            
        }
        


        /// <summary>
        /// Gets or Sets ScheduleId
        /// </summary>
        [DataMember(Name="scheduleId", EmitDefaultValue=false)]
        public string ScheduleId { get; set; }



        /// <summary>
        /// Gets or Sets ScheduleStartDate
        /// </summary>
        [DataMember(Name="scheduleStartDate", EmitDefaultValue=false)]
        public string ScheduleStartDate { get; set; }



        /// <summary>
        /// Gets or Sets ManagementUnitId
        /// </summary>
        [DataMember(Name="managementUnitId", EmitDefaultValue=false)]
        public string ManagementUnitId { get; set; }



        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }



        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public string EndDate { get; set; }



        /// <summary>
        /// Gets or Sets WeekDate
        /// </summary>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public string WeekDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShiftTradingJobCompleteEventTradeShift {\n");

            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  ScheduleStartDate: ").Append(ScheduleStartDate).Append("\n");
            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
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
            return this.Equals(obj as WfmShiftTradingJobCompleteEventTradeShift);
        }

        /// <summary>
        /// Returns true if WfmShiftTradingJobCompleteEventTradeShift instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShiftTradingJobCompleteEventTradeShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShiftTradingJobCompleteEventTradeShift other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ScheduleId == other.ScheduleId ||
                    this.ScheduleId != null &&
                    this.ScheduleId.Equals(other.ScheduleId)
                ) &&
                (
                    this.ScheduleStartDate == other.ScheduleStartDate ||
                    this.ScheduleStartDate != null &&
                    this.ScheduleStartDate.Equals(other.ScheduleStartDate)
                ) &&
                (
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
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
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
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
                if (this.ScheduleId != null)
                    hash = hash * 59 + this.ScheduleId.GetHashCode();

                if (this.ScheduleStartDate != null)
                    hash = hash * 59 + this.ScheduleStartDate.GetHashCode();

                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                return hash;
            }
        }
    }

}
