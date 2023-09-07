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
    /// AdminTimeOffRequestPatch
    /// </summary>
    [DataContract]
    public partial class AdminTimeOffRequestPatch :  IEquatable<AdminTimeOffRequestPatch>
    {
        /// <summary>
        /// The status of this time off request
        /// </summary>
        /// <value>The status of this time off request</value>
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
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum Approved for "APPROVED"
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "DENIED"
            /// </summary>
            [EnumMember(Value = "DENIED")]
            Denied
        }
        /// <summary>
        /// The status of this time off request
        /// </summary>
        /// <value>The status of this time off request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTimeOffRequestPatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminTimeOffRequestPatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminTimeOffRequestPatch" /> class.
        /// </summary>
        /// <param name="Status">The status of this time off request.</param>
        /// <param name="ActivityCodeId">The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category.</param>
        /// <param name="Notes">Notes about the time off request.</param>
        /// <param name="FullDayManagementUnitDates">A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit's configured time zone..</param>
        /// <param name="PartialDayStartDateTimes">A set of start date-times in ISO-8601 format for partial day requests..</param>
        /// <param name="DailyDurationMinutes">The daily duration of this time off request in minutes.</param>
        /// <param name="DurationMinutes">Daily durations for each day of this time off request in minutes.</param>
        /// <param name="PayableMinutes">Payable minutes for each day of this time off request.</param>
        /// <param name="Metadata">Version metadata for the time off request (required).</param>
        public AdminTimeOffRequestPatch(StatusEnum? Status = null, string ActivityCodeId = null, string Notes = null, List<string> FullDayManagementUnitDates = null, List<DateTime?> PartialDayStartDateTimes = null, int? DailyDurationMinutes = null, List<int?> DurationMinutes = null, List<int?> PayableMinutes = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Status = Status;
            this.ActivityCodeId = ActivityCodeId;
            this.Notes = Notes;
            this.FullDayManagementUnitDates = FullDayManagementUnitDates;
            this.PartialDayStartDateTimes = PartialDayStartDateTimes;
            this.DailyDurationMinutes = DailyDurationMinutes;
            this.DurationMinutes = DurationMinutes;
            this.PayableMinutes = PayableMinutes;
            this.Metadata = Metadata;
            
        }
        




        /// <summary>
        /// The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category
        /// </summary>
        /// <value>The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Notes about the time off request
        /// </summary>
        /// <value>Notes about the time off request</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }



        /// <summary>
        /// A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit's configured time zone.
        /// </summary>
        /// <value>A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit's configured time zone.</value>
        [DataMember(Name="fullDayManagementUnitDates", EmitDefaultValue=false)]
        public List<string> FullDayManagementUnitDates { get; set; }



        /// <summary>
        /// A set of start date-times in ISO-8601 format for partial day requests.
        /// </summary>
        /// <value>A set of start date-times in ISO-8601 format for partial day requests.</value>
        [DataMember(Name="partialDayStartDateTimes", EmitDefaultValue=false)]
        public List<DateTime?> PartialDayStartDateTimes { get; set; }



        /// <summary>
        /// The daily duration of this time off request in minutes
        /// </summary>
        /// <value>The daily duration of this time off request in minutes</value>
        [DataMember(Name="dailyDurationMinutes", EmitDefaultValue=false)]
        public int? DailyDurationMinutes { get; set; }



        /// <summary>
        /// Daily durations for each day of this time off request in minutes
        /// </summary>
        /// <value>Daily durations for each day of this time off request in minutes</value>
        [DataMember(Name="durationMinutes", EmitDefaultValue=false)]
        public List<int?> DurationMinutes { get; set; }



        /// <summary>
        /// Payable minutes for each day of this time off request
        /// </summary>
        /// <value>Payable minutes for each day of this time off request</value>
        [DataMember(Name="payableMinutes", EmitDefaultValue=false)]
        public List<int?> PayableMinutes { get; set; }



        /// <summary>
        /// Version metadata for the time off request
        /// </summary>
        /// <value>Version metadata for the time off request</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminTimeOffRequestPatch {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  FullDayManagementUnitDates: ").Append(FullDayManagementUnitDates).Append("\n");
            sb.Append("  PartialDayStartDateTimes: ").Append(PartialDayStartDateTimes).Append("\n");
            sb.Append("  DailyDurationMinutes: ").Append(DailyDurationMinutes).Append("\n");
            sb.Append("  DurationMinutes: ").Append(DurationMinutes).Append("\n");
            sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as AdminTimeOffRequestPatch);
        }

        /// <summary>
        /// Returns true if AdminTimeOffRequestPatch instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminTimeOffRequestPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminTimeOffRequestPatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.FullDayManagementUnitDates == other.FullDayManagementUnitDates ||
                    this.FullDayManagementUnitDates != null &&
                    this.FullDayManagementUnitDates.SequenceEqual(other.FullDayManagementUnitDates)
                ) &&
                (
                    this.PartialDayStartDateTimes == other.PartialDayStartDateTimes ||
                    this.PartialDayStartDateTimes != null &&
                    this.PartialDayStartDateTimes.SequenceEqual(other.PartialDayStartDateTimes)
                ) &&
                (
                    this.DailyDurationMinutes == other.DailyDurationMinutes ||
                    this.DailyDurationMinutes != null &&
                    this.DailyDurationMinutes.Equals(other.DailyDurationMinutes)
                ) &&
                (
                    this.DurationMinutes == other.DurationMinutes ||
                    this.DurationMinutes != null &&
                    this.DurationMinutes.SequenceEqual(other.DurationMinutes)
                ) &&
                (
                    this.PayableMinutes == other.PayableMinutes ||
                    this.PayableMinutes != null &&
                    this.PayableMinutes.SequenceEqual(other.PayableMinutes)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                if (this.FullDayManagementUnitDates != null)
                    hash = hash * 59 + this.FullDayManagementUnitDates.GetHashCode();

                if (this.PartialDayStartDateTimes != null)
                    hash = hash * 59 + this.PartialDayStartDateTimes.GetHashCode();

                if (this.DailyDurationMinutes != null)
                    hash = hash * 59 + this.DailyDurationMinutes.GetHashCode();

                if (this.DurationMinutes != null)
                    hash = hash * 59 + this.DurationMinutes.GetHashCode();

                if (this.PayableMinutes != null)
                    hash = hash * 59 + this.PayableMinutes.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
