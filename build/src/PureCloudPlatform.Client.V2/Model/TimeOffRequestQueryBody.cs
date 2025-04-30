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
    /// TimeOffRequestQueryBody
    /// </summary>
    [DataContract]
    public partial class TimeOffRequestQueryBody :  IEquatable<TimeOffRequestQueryBody>
    {
        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending
        }
        /// <summary>
        /// Gets or Sets Substatuses
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SubstatusesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Advancetimeelapsed for "AdvanceTimeElapsed"
            /// </summary>
            [EnumMember(Value = "AdvanceTimeElapsed")]
            Advancetimeelapsed,
            
            /// <summary>
            /// Enum Autoapproved for "AutoApproved"
            /// </summary>
            [EnumMember(Value = "AutoApproved")]
            Autoapproved,
            
            /// <summary>
            /// Enum Blockeddate for "BlockedDate"
            /// </summary>
            [EnumMember(Value = "BlockedDate")]
            Blockeddate,
            
            /// <summary>
            /// Enum Insufficientbalance for "InsufficientBalance"
            /// </summary>
            [EnumMember(Value = "InsufficientBalance")]
            Insufficientbalance,
            
            /// <summary>
            /// Enum Invaliddailyduration for "InvalidDailyDuration"
            /// </summary>
            [EnumMember(Value = "InvalidDailyDuration")]
            Invaliddailyduration,
            
            /// <summary>
            /// Enum Manualapproval for "ManualApproval"
            /// </summary>
            [EnumMember(Value = "ManualApproval")]
            Manualapproval,
            
            /// <summary>
            /// Enum Outsideshift for "OutsideShift"
            /// </summary>
            [EnumMember(Value = "OutsideShift")]
            Outsideshift,
            
            /// <summary>
            /// Enum Overlapsrestrictedactivitycode for "OverlapsRestrictedActivityCode"
            /// </summary>
            [EnumMember(Value = "OverlapsRestrictedActivityCode")]
            Overlapsrestrictedactivitycode,
            
            /// <summary>
            /// Enum Removedfromwaitlist for "RemovedFromWaitlist"
            /// </summary>
            [EnumMember(Value = "RemovedFromWaitlist")]
            Removedfromwaitlist,
            
            /// <summary>
            /// Enum Reviewdate for "ReviewDate"
            /// </summary>
            [EnumMember(Value = "ReviewDate")]
            Reviewdate,
            
            /// <summary>
            /// Enum Waitlisted for "Waitlisted"
            /// </summary>
            [EnumMember(Value = "Waitlisted")]
            Waitlisted
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestQueryBody" /> class.
        /// </summary>
        /// <param name="Ids">The set of ids to filter time off requests.</param>
        /// <param name="UserIds">The set of user ids to filter time off requests.</param>
        /// <param name="Statuses">The set of statuses to filter time off requests.</param>
        /// <param name="Substatuses">The set of substatuses to filter time off requests.</param>
        /// <param name="DateRange">The inclusive range of dates to filter time off requests.</param>
        public TimeOffRequestQueryBody(List<string> Ids = null, List<string> UserIds = null, List<StatusesEnum> Statuses = null, List<SubstatusesEnum> Substatuses = null, DateRange DateRange = null)
        {
            this.Ids = Ids;
            this.UserIds = UserIds;
            this.Statuses = Statuses;
            this.Substatuses = Substatuses;
            this.DateRange = DateRange;
            
        }
        


        /// <summary>
        /// The set of ids to filter time off requests
        /// </summary>
        /// <value>The set of ids to filter time off requests</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }



        /// <summary>
        /// The set of user ids to filter time off requests
        /// </summary>
        /// <value>The set of user ids to filter time off requests</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }



        /// <summary>
        /// The set of statuses to filter time off requests
        /// </summary>
        /// <value>The set of statuses to filter time off requests</value>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<StatusesEnum> Statuses { get; set; }



        /// <summary>
        /// The set of substatuses to filter time off requests
        /// </summary>
        /// <value>The set of substatuses to filter time off requests</value>
        [DataMember(Name="substatuses", EmitDefaultValue=false)]
        public List<SubstatusesEnum> Substatuses { get; set; }



        /// <summary>
        /// The inclusive range of dates to filter time off requests
        /// </summary>
        /// <value>The inclusive range of dates to filter time off requests</value>
        [DataMember(Name="dateRange", EmitDefaultValue=false)]
        public DateRange DateRange { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeOffRequestQueryBody {\n");

            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  Substatuses: ").Append(Substatuses).Append("\n");
            sb.Append("  DateRange: ").Append(DateRange).Append("\n");
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
            return this.Equals(obj as TimeOffRequestQueryBody);
        }

        /// <summary>
        /// Returns true if TimeOffRequestQueryBody instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeOffRequestQueryBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffRequestQueryBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
                ) &&
                (
                    this.Statuses == other.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(other.Statuses)
                ) &&
                (
                    this.Substatuses == other.Substatuses ||
                    this.Substatuses != null &&
                    this.Substatuses.SequenceEqual(other.Substatuses)
                ) &&
                (
                    this.DateRange == other.DateRange ||
                    this.DateRange != null &&
                    this.DateRange.Equals(other.DateRange)
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
                if (this.Ids != null)
                    hash = hash * 59 + this.Ids.GetHashCode();

                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();

                if (this.Statuses != null)
                    hash = hash * 59 + this.Statuses.GetHashCode();

                if (this.Substatuses != null)
                    hash = hash * 59 + this.Substatuses.GetHashCode();

                if (this.DateRange != null)
                    hash = hash * 59 + this.DateRange.GetHashCode();

                return hash;
            }
        }
    }

}
