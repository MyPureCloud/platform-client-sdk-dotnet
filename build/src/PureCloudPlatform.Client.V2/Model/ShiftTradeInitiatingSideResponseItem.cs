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
    /// ShiftTradeInitiatingSideResponseItem
    /// </summary>
    [DataContract]
    public partial class ShiftTradeInitiatingSideResponseItem :  IEquatable<ShiftTradeInitiatingSideResponseItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeInitiatingSideResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShiftTradeInitiatingSideResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeInitiatingSideResponseItem" /> class.
        /// </summary>
        /// <param name="User">The user who initiated this trade (required).</param>
        /// <param name="ManagementUnit">The management unit of the user who initiated this trade (required).</param>
        /// <param name="Schedule">Associated schedule information for the initiating user (required).</param>
        /// <param name="Shift">The shift offered for trade by the initiating user (required).</param>
        public ShiftTradeInitiatingSideResponseItem(UserReference User = null, ManagementUnitReference ManagementUnit = null, ScheduleReferenceWithBusinessUnit Schedule = null, ShiftTradeShiftResponseItem Shift = null)
        {
            this.User = User;
            this.ManagementUnit = ManagementUnit;
            this.Schedule = Schedule;
            this.Shift = Shift;
            
        }
        


        /// <summary>
        /// The user who initiated this trade
        /// </summary>
        /// <value>The user who initiated this trade</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The management unit of the user who initiated this trade
        /// </summary>
        /// <value>The management unit of the user who initiated this trade</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// Associated schedule information for the initiating user
        /// </summary>
        /// <value>Associated schedule information for the initiating user</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public ScheduleReferenceWithBusinessUnit Schedule { get; set; }



        /// <summary>
        /// The shift offered for trade by the initiating user
        /// </summary>
        /// <value>The shift offered for trade by the initiating user</value>
        [DataMember(Name="shift", EmitDefaultValue=false)]
        public ShiftTradeShiftResponseItem Shift { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeInitiatingSideResponseItem {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Shift: ").Append(Shift).Append("\n");
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
            return this.Equals(obj as ShiftTradeInitiatingSideResponseItem);
        }

        /// <summary>
        /// Returns true if ShiftTradeInitiatingSideResponseItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeInitiatingSideResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeInitiatingSideResponseItem other)
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

                return hash;
            }
        }
    }

}
