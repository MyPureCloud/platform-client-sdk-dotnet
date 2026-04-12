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
    /// WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults
    /// </summary>
    [DataContract]
    public partial class WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults :  IEquatable<WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults" /> class.
        /// </summary>
        /// <param name="Interval">Interval.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Slot">Slot.</param>
        /// <param name="HasConflict">HasConflict.</param>
        public WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults(string Interval = null, StatusEnum? Status = null, WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResultsSlot Slot = null, bool? HasConflict = null)
        {
            this.Interval = Interval;
            this.Status = Status;
            this.Slot = Slot;
            this.HasConflict = HasConflict;
            
        }
        


        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }





        /// <summary>
        /// Gets or Sets Slot
        /// </summary>
        [DataMember(Name="slot", EmitDefaultValue=false)]
        public WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResultsSlot Slot { get; set; }



        /// <summary>
        /// Gets or Sets HasConflict
        /// </summary>
        [DataMember(Name="hasConflict", EmitDefaultValue=false)]
        public bool? HasConflict { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults {\n");

            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Slot: ").Append(Slot).Append("\n");
            sb.Append("  HasConflict: ").Append(HasConflict).Append("\n");
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
            return this.Equals(obj as WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults);
        }

        /// <summary>
        /// Returns true if WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults instances are equal
        /// </summary>
        /// <param name="other">Instance of WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Slot == other.Slot ||
                    this.Slot != null &&
                    this.Slot.Equals(other.Slot)
                ) &&
                (
                    this.HasConflict == other.HasConflict ||
                    this.HasConflict != null &&
                    this.HasConflict.Equals(other.HasConflict)
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
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Slot != null)
                    hash = hash * 59 + this.Slot.GetHashCode();

                if (this.HasConflict != null)
                    hash = hash * 59 + this.HasConflict.GetHashCode();

                return hash;
            }
        }
    }

}
