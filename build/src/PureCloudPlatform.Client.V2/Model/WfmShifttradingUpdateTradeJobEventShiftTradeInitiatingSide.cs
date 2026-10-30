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
    /// WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide
    /// </summary>
    [DataContract]
    public partial class WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide :  IEquatable<WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="ManagementUnit">ManagementUnit.</param>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="Shift">Shift.</param>
        /// <param name="ReviewNote">ReviewNote.</param>
        public WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide(WfmShifttradingUpdateTradeJobEventUserReference User = null, WfmShifttradingUpdateTradeJobEventManagementUnit ManagementUnit = null, WfmShifttradingUpdateTradeJobEventBuScheduleReference Schedule = null, WfmShifttradingUpdateTradeJobEventShiftTradeShift Shift = null, string ReviewNote = null)
        {
            this.User = User;
            this.ManagementUnit = ManagementUnit;
            this.Schedule = Schedule;
            this.Shift = Shift;
            this.ReviewNote = ReviewNote;
            
        }
        


        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public WfmShifttradingUpdateTradeJobEventUserReference User { get; set; }



        /// <summary>
        /// Gets or Sets ManagementUnit
        /// </summary>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public WfmShifttradingUpdateTradeJobEventManagementUnit ManagementUnit { get; set; }



        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public WfmShifttradingUpdateTradeJobEventBuScheduleReference Schedule { get; set; }



        /// <summary>
        /// Gets or Sets Shift
        /// </summary>
        [DataMember(Name="shift", EmitDefaultValue=false)]
        public WfmShifttradingUpdateTradeJobEventShiftTradeShift Shift { get; set; }



        /// <summary>
        /// Gets or Sets ReviewNote
        /// </summary>
        [DataMember(Name="reviewNote", EmitDefaultValue=false)]
        public string ReviewNote { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Shift: ").Append(Shift).Append("\n");
            sb.Append("  ReviewNote: ").Append(ReviewNote).Append("\n");
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
            return this.Equals(obj as WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide);
        }

        /// <summary>
        /// Returns true if WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShifttradingUpdateTradeJobEventShiftTradeInitiatingSide other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.Shift == other.Shift ||
                    this.Shift != null &&
                    this.Shift.Equals(other.Shift)
                ) &&
                (
                    this.ReviewNote == other.ReviewNote ||
                    this.ReviewNote != null &&
                    this.ReviewNote.Equals(other.ReviewNote)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.Shift != null)
                    hash = hash * 59 + this.Shift.GetHashCode();

                if (this.ReviewNote != null)
                    hash = hash * 59 + this.ReviewNote.GetHashCode();

                return hash;
            }
        }
    }

}
