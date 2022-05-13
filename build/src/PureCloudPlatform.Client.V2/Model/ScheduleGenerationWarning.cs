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
    /// Schedule generation warning
    /// </summary>
    [DataContract]
    public partial class ScheduleGenerationWarning :  IEquatable<ScheduleGenerationWarning>
    {
        /// <summary>
        /// Gets or Sets UnableToScheduleRequiredDays
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UnableToScheduleRequiredDaysEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sunday for "Sunday"
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday,
            
            /// <summary>
            /// Enum Monday for "Monday"
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday,
            
            /// <summary>
            /// Enum Tuesday for "Tuesday"
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday,
            
            /// <summary>
            /// Enum Wednesday for "Wednesday"
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday,
            
            /// <summary>
            /// Enum Thursday for "Thursday"
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday,
            
            /// <summary>
            /// Enum Friday for "Friday"
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday,
            
            /// <summary>
            /// Enum Saturday for "Saturday"
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday
        }
        /// <summary>
        /// Gets or Sets NoNeedDays
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NoNeedDaysEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sunday for "Sunday"
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday,
            
            /// <summary>
            /// Enum Monday for "Monday"
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday,
            
            /// <summary>
            /// Enum Tuesday for "Tuesday"
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday,
            
            /// <summary>
            /// Enum Wednesday for "Wednesday"
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday,
            
            /// <summary>
            /// Enum Thursday for "Thursday"
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday,
            
            /// <summary>
            /// Enum Friday for "Friday"
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday,
            
            /// <summary>
            /// Enum Saturday for "Saturday"
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleGenerationWarning" /> class.
        /// </summary>
        /// <param name="UserId">ID of the user in the warning.</param>
        /// <param name="UserNotLicensed">Whether the user does not have the appropriate license to be scheduled.</param>
        /// <param name="UnableToMeetMaxDays">Whether the number of scheduled days exceeded the maximum days to schedule defined in the agent work plan.</param>
        /// <param name="UnableToScheduleRequiredDays">Days indicated as required to work in agent work plan where no viable shift was found to schedule.</param>
        /// <param name="UnableToMeetMinPaidForTheWeek">Whether the schedule did not meet the minimum paid time for the week defined in the agent work plan.</param>
        /// <param name="UnableToMeetMaxPaidForTheWeek">Whether the schedule exceeded the maximum paid time for the week defined in the agent work plan.</param>
        /// <param name="NoNeedDays">Days agent was scheduled but there was no need to meet. The scheduled days have no effect on service levels.</param>
        /// <param name="ShiftsTooCloseTogether">Whether the schedule did not meet the minimum time between shifts defined in the agent work plan.</param>
        public ScheduleGenerationWarning(string UserId = null, bool? UserNotLicensed = null, bool? UnableToMeetMaxDays = null, List<UnableToScheduleRequiredDaysEnum> UnableToScheduleRequiredDays = null, bool? UnableToMeetMinPaidForTheWeek = null, bool? UnableToMeetMaxPaidForTheWeek = null, List<NoNeedDaysEnum> NoNeedDays = null, bool? ShiftsTooCloseTogether = null)
        {
            this.UserId = UserId;
            this.UserNotLicensed = UserNotLicensed;
            this.UnableToMeetMaxDays = UnableToMeetMaxDays;
            this.UnableToScheduleRequiredDays = UnableToScheduleRequiredDays;
            this.UnableToMeetMinPaidForTheWeek = UnableToMeetMinPaidForTheWeek;
            this.UnableToMeetMaxPaidForTheWeek = UnableToMeetMaxPaidForTheWeek;
            this.NoNeedDays = NoNeedDays;
            this.ShiftsTooCloseTogether = ShiftsTooCloseTogether;
            
        }
        


        /// <summary>
        /// ID of the user in the warning
        /// </summary>
        /// <value>ID of the user in the warning</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Whether the user does not have the appropriate license to be scheduled
        /// </summary>
        /// <value>Whether the user does not have the appropriate license to be scheduled</value>
        [DataMember(Name="userNotLicensed", EmitDefaultValue=false)]
        public bool? UserNotLicensed { get; set; }



        /// <summary>
        /// Whether the number of scheduled days exceeded the maximum days to schedule defined in the agent work plan
        /// </summary>
        /// <value>Whether the number of scheduled days exceeded the maximum days to schedule defined in the agent work plan</value>
        [DataMember(Name="unableToMeetMaxDays", EmitDefaultValue=false)]
        public bool? UnableToMeetMaxDays { get; set; }



        /// <summary>
        /// Days indicated as required to work in agent work plan where no viable shift was found to schedule
        /// </summary>
        /// <value>Days indicated as required to work in agent work plan where no viable shift was found to schedule</value>
        [DataMember(Name="unableToScheduleRequiredDays", EmitDefaultValue=false)]
        public List<UnableToScheduleRequiredDaysEnum> UnableToScheduleRequiredDays { get; set; }



        /// <summary>
        /// Whether the schedule did not meet the minimum paid time for the week defined in the agent work plan
        /// </summary>
        /// <value>Whether the schedule did not meet the minimum paid time for the week defined in the agent work plan</value>
        [DataMember(Name="unableToMeetMinPaidForTheWeek", EmitDefaultValue=false)]
        public bool? UnableToMeetMinPaidForTheWeek { get; set; }



        /// <summary>
        /// Whether the schedule exceeded the maximum paid time for the week defined in the agent work plan
        /// </summary>
        /// <value>Whether the schedule exceeded the maximum paid time for the week defined in the agent work plan</value>
        [DataMember(Name="unableToMeetMaxPaidForTheWeek", EmitDefaultValue=false)]
        public bool? UnableToMeetMaxPaidForTheWeek { get; set; }



        /// <summary>
        /// Days agent was scheduled but there was no need to meet. The scheduled days have no effect on service levels
        /// </summary>
        /// <value>Days agent was scheduled but there was no need to meet. The scheduled days have no effect on service levels</value>
        [DataMember(Name="noNeedDays", EmitDefaultValue=false)]
        public List<NoNeedDaysEnum> NoNeedDays { get; set; }



        /// <summary>
        /// Whether the schedule did not meet the minimum time between shifts defined in the agent work plan
        /// </summary>
        /// <value>Whether the schedule did not meet the minimum time between shifts defined in the agent work plan</value>
        [DataMember(Name="shiftsTooCloseTogether", EmitDefaultValue=false)]
        public bool? ShiftsTooCloseTogether { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleGenerationWarning {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserNotLicensed: ").Append(UserNotLicensed).Append("\n");
            sb.Append("  UnableToMeetMaxDays: ").Append(UnableToMeetMaxDays).Append("\n");
            sb.Append("  UnableToScheduleRequiredDays: ").Append(UnableToScheduleRequiredDays).Append("\n");
            sb.Append("  UnableToMeetMinPaidForTheWeek: ").Append(UnableToMeetMinPaidForTheWeek).Append("\n");
            sb.Append("  UnableToMeetMaxPaidForTheWeek: ").Append(UnableToMeetMaxPaidForTheWeek).Append("\n");
            sb.Append("  NoNeedDays: ").Append(NoNeedDays).Append("\n");
            sb.Append("  ShiftsTooCloseTogether: ").Append(ShiftsTooCloseTogether).Append("\n");
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
            return this.Equals(obj as ScheduleGenerationWarning);
        }

        /// <summary>
        /// Returns true if ScheduleGenerationWarning instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleGenerationWarning to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleGenerationWarning other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.UserNotLicensed == other.UserNotLicensed ||
                    this.UserNotLicensed != null &&
                    this.UserNotLicensed.Equals(other.UserNotLicensed)
                ) &&
                (
                    this.UnableToMeetMaxDays == other.UnableToMeetMaxDays ||
                    this.UnableToMeetMaxDays != null &&
                    this.UnableToMeetMaxDays.Equals(other.UnableToMeetMaxDays)
                ) &&
                (
                    this.UnableToScheduleRequiredDays == other.UnableToScheduleRequiredDays ||
                    this.UnableToScheduleRequiredDays != null &&
                    this.UnableToScheduleRequiredDays.SequenceEqual(other.UnableToScheduleRequiredDays)
                ) &&
                (
                    this.UnableToMeetMinPaidForTheWeek == other.UnableToMeetMinPaidForTheWeek ||
                    this.UnableToMeetMinPaidForTheWeek != null &&
                    this.UnableToMeetMinPaidForTheWeek.Equals(other.UnableToMeetMinPaidForTheWeek)
                ) &&
                (
                    this.UnableToMeetMaxPaidForTheWeek == other.UnableToMeetMaxPaidForTheWeek ||
                    this.UnableToMeetMaxPaidForTheWeek != null &&
                    this.UnableToMeetMaxPaidForTheWeek.Equals(other.UnableToMeetMaxPaidForTheWeek)
                ) &&
                (
                    this.NoNeedDays == other.NoNeedDays ||
                    this.NoNeedDays != null &&
                    this.NoNeedDays.SequenceEqual(other.NoNeedDays)
                ) &&
                (
                    this.ShiftsTooCloseTogether == other.ShiftsTooCloseTogether ||
                    this.ShiftsTooCloseTogether != null &&
                    this.ShiftsTooCloseTogether.Equals(other.ShiftsTooCloseTogether)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.UserNotLicensed != null)
                    hash = hash * 59 + this.UserNotLicensed.GetHashCode();

                if (this.UnableToMeetMaxDays != null)
                    hash = hash * 59 + this.UnableToMeetMaxDays.GetHashCode();

                if (this.UnableToScheduleRequiredDays != null)
                    hash = hash * 59 + this.UnableToScheduleRequiredDays.GetHashCode();

                if (this.UnableToMeetMinPaidForTheWeek != null)
                    hash = hash * 59 + this.UnableToMeetMinPaidForTheWeek.GetHashCode();

                if (this.UnableToMeetMaxPaidForTheWeek != null)
                    hash = hash * 59 + this.UnableToMeetMaxPaidForTheWeek.GetHashCode();

                if (this.NoNeedDays != null)
                    hash = hash * 59 + this.NoNeedDays.GetHashCode();

                if (this.ShiftsTooCloseTogether != null)
                    hash = hash * 59 + this.ShiftsTooCloseTogether.GetHashCode();

                return hash;
            }
        }
    }

}
