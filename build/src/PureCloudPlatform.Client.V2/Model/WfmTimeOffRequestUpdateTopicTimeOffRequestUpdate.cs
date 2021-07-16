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
    /// WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate
    /// </summary>
    [DataContract]
    public partial class WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate :  IEquatable<WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate>
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
            Denied,
            
            /// <summary>
            /// Enum Canceled for "CANCELED"
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            Canceled
        }
        
        
        
        
        /// <summary>
        /// Gets or Sets Substatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SubstatusEnum
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
            /// Enum Invaliddailyduration for "InvalidDailyDuration"
            /// </summary>
            [EnumMember(Value = "InvalidDailyDuration")]
            Invaliddailyduration,
            
            /// <summary>
            /// Enum Outsideshift for "OutsideShift"
            /// </summary>
            [EnumMember(Value = "OutsideShift")]
            Outsideshift,
            
            /// <summary>
            /// Enum Removedfromwaitlist for "RemovedFromWaitlist"
            /// </summary>
            [EnumMember(Value = "RemovedFromWaitlist")]
            Removedfromwaitlist,
            
            /// <summary>
            /// Enum Waitlisted for "Waitlisted"
            /// </summary>
            [EnumMember(Value = "Waitlisted")]
            Waitlisted
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Substatus
        /// </summary>
        [DataMember(Name="substatus", EmitDefaultValue=false)]
        public SubstatusEnum? Substatus { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="User">User.</param>
        /// <param name="IsFullDayRequest">IsFullDayRequest.</param>
        /// <param name="MarkedAsRead">MarkedAsRead.</param>
        /// <param name="ActivityCodeId">ActivityCodeId.</param>
        /// <param name="Paid">Paid.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Substatus">Substatus.</param>
        /// <param name="PartialDayStartDateTimes">PartialDayStartDateTimes.</param>
        /// <param name="FullDayManagementUnitDates">FullDayManagementUnitDates.</param>
        /// <param name="DailyDurationMinutes">DailyDurationMinutes.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="ReviewedDate">ReviewedDate.</param>
        /// <param name="ReviewedBy">ReviewedBy.</param>
        /// <param name="SubmittedDate">SubmittedDate.</param>
        /// <param name="SubmittedBy">SubmittedBy.</param>
        /// <param name="ModifiedDate">ModifiedDate.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        public WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate(string Id = null, WfmTimeOffRequestUpdateTopicUserReference User = null, bool? IsFullDayRequest = null, bool? MarkedAsRead = null, string ActivityCodeId = null, bool? Paid = null, StatusEnum? Status = null, SubstatusEnum? Substatus = null, List<string> PartialDayStartDateTimes = null, List<string> FullDayManagementUnitDates = null, int? DailyDurationMinutes = null, string Notes = null, string ReviewedDate = null, string ReviewedBy = null, string SubmittedDate = null, string SubmittedBy = null, string ModifiedDate = null, string ModifiedBy = null)
        {
            this.Id = Id;
            this.User = User;
            this.IsFullDayRequest = IsFullDayRequest;
            this.MarkedAsRead = MarkedAsRead;
            this.ActivityCodeId = ActivityCodeId;
            this.Paid = Paid;
            this.Status = Status;
            this.Substatus = Substatus;
            this.PartialDayStartDateTimes = PartialDayStartDateTimes;
            this.FullDayManagementUnitDates = FullDayManagementUnitDates;
            this.DailyDurationMinutes = DailyDurationMinutes;
            this.Notes = Notes;
            this.ReviewedDate = ReviewedDate;
            this.ReviewedBy = ReviewedBy;
            this.SubmittedDate = SubmittedDate;
            this.SubmittedBy = SubmittedBy;
            this.ModifiedDate = ModifiedDate;
            this.ModifiedBy = ModifiedBy;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public WfmTimeOffRequestUpdateTopicUserReference User { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IsFullDayRequest
        /// </summary>
        [DataMember(Name="isFullDayRequest", EmitDefaultValue=false)]
        public bool? IsFullDayRequest { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MarkedAsRead
        /// </summary>
        [DataMember(Name="markedAsRead", EmitDefaultValue=false)]
        public bool? MarkedAsRead { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ActivityCodeId
        /// </summary>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public bool? Paid { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets PartialDayStartDateTimes
        /// </summary>
        [DataMember(Name="partialDayStartDateTimes", EmitDefaultValue=false)]
        public List<string> PartialDayStartDateTimes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FullDayManagementUnitDates
        /// </summary>
        [DataMember(Name="fullDayManagementUnitDates", EmitDefaultValue=false)]
        public List<string> FullDayManagementUnitDates { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DailyDurationMinutes
        /// </summary>
        [DataMember(Name="dailyDurationMinutes", EmitDefaultValue=false)]
        public int? DailyDurationMinutes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ReviewedDate
        /// </summary>
        [DataMember(Name="reviewedDate", EmitDefaultValue=false)]
        public string ReviewedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ReviewedBy
        /// </summary>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public string ReviewedBy { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SubmittedDate
        /// </summary>
        [DataMember(Name="submittedDate", EmitDefaultValue=false)]
        public string SubmittedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SubmittedBy
        /// </summary>
        [DataMember(Name="submittedBy", EmitDefaultValue=false)]
        public string SubmittedBy { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public string ModifiedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  IsFullDayRequest: ").Append(IsFullDayRequest).Append("\n");
            sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Substatus: ").Append(Substatus).Append("\n");
            sb.Append("  PartialDayStartDateTimes: ").Append(PartialDayStartDateTimes).Append("\n");
            sb.Append("  FullDayManagementUnitDates: ").Append(FullDayManagementUnitDates).Append("\n");
            sb.Append("  DailyDurationMinutes: ").Append(DailyDurationMinutes).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
            sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
            sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
            sb.Append("  SubmittedBy: ").Append(SubmittedBy).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
            return this.Equals(obj as WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate);
        }

        /// <summary>
        /// Returns true if WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.IsFullDayRequest == other.IsFullDayRequest ||
                    this.IsFullDayRequest != null &&
                    this.IsFullDayRequest.Equals(other.IsFullDayRequest)
                ) &&
                (
                    this.MarkedAsRead == other.MarkedAsRead ||
                    this.MarkedAsRead != null &&
                    this.MarkedAsRead.Equals(other.MarkedAsRead)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Substatus == other.Substatus ||
                    this.Substatus != null &&
                    this.Substatus.Equals(other.Substatus)
                ) &&
                (
                    this.PartialDayStartDateTimes == other.PartialDayStartDateTimes ||
                    this.PartialDayStartDateTimes != null &&
                    this.PartialDayStartDateTimes.SequenceEqual(other.PartialDayStartDateTimes)
                ) &&
                (
                    this.FullDayManagementUnitDates == other.FullDayManagementUnitDates ||
                    this.FullDayManagementUnitDates != null &&
                    this.FullDayManagementUnitDates.SequenceEqual(other.FullDayManagementUnitDates)
                ) &&
                (
                    this.DailyDurationMinutes == other.DailyDurationMinutes ||
                    this.DailyDurationMinutes != null &&
                    this.DailyDurationMinutes.Equals(other.DailyDurationMinutes)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.ReviewedDate == other.ReviewedDate ||
                    this.ReviewedDate != null &&
                    this.ReviewedDate.Equals(other.ReviewedDate)
                ) &&
                (
                    this.ReviewedBy == other.ReviewedBy ||
                    this.ReviewedBy != null &&
                    this.ReviewedBy.Equals(other.ReviewedBy)
                ) &&
                (
                    this.SubmittedDate == other.SubmittedDate ||
                    this.SubmittedDate != null &&
                    this.SubmittedDate.Equals(other.SubmittedDate)
                ) &&
                (
                    this.SubmittedBy == other.SubmittedBy ||
                    this.SubmittedBy != null &&
                    this.SubmittedBy.Equals(other.SubmittedBy)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.IsFullDayRequest != null)
                    hash = hash * 59 + this.IsFullDayRequest.GetHashCode();
                
                if (this.MarkedAsRead != null)
                    hash = hash * 59 + this.MarkedAsRead.GetHashCode();
                
                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();
                
                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Substatus != null)
                    hash = hash * 59 + this.Substatus.GetHashCode();
                
                if (this.PartialDayStartDateTimes != null)
                    hash = hash * 59 + this.PartialDayStartDateTimes.GetHashCode();
                
                if (this.FullDayManagementUnitDates != null)
                    hash = hash * 59 + this.FullDayManagementUnitDates.GetHashCode();
                
                if (this.DailyDurationMinutes != null)
                    hash = hash * 59 + this.DailyDurationMinutes.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.ReviewedDate != null)
                    hash = hash * 59 + this.ReviewedDate.GetHashCode();
                
                if (this.ReviewedBy != null)
                    hash = hash * 59 + this.ReviewedBy.GetHashCode();
                
                if (this.SubmittedDate != null)
                    hash = hash * 59 + this.SubmittedDate.GetHashCode();
                
                if (this.SubmittedBy != null)
                    hash = hash * 59 + this.SubmittedBy.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                return hash;
            }
        }
    }

}
