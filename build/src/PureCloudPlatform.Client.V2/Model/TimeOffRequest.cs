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
    /// TimeOffRequest
    /// </summary>
    [DataContract]
    public partial class TimeOffRequest :  IEquatable<TimeOffRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The administrative status of this TimeOffRequest
        /// </summary>
        /// <value>The administrative status of this TimeOffRequest</value>
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
        /// The administrative status of this TimeOffRequest
        /// </summary>
        /// <value>The administrative status of this TimeOffRequest</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeOffRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequest" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="User">The user associated with this TimeOffRequest (required).</param>
        
        
        
        /// <param name="IsFullDayRequest">Whether this is a full day request (false means partial day) (required).</param>
        
        
        
        /// <param name="MarkedAsRead">Whether this request has been marked as read by the agent (required).</param>
        
        
        
        /// <param name="ActivityCodeId">The ID of the activity code associated with this TimeOffRequest (required).</param>
        
        
        
        /// <param name="Status">The administrative status of this TimeOffRequest (required).</param>
        
        
        
        /// <param name="PartialDayStartDateTimes">The start date-times for partial day requests.  Required if isFullDayRequest == false.</param>
        
        
        
        /// <param name="DailyDurationMinutes">The daily duration of this TimeOffRequest in minutes (required).</param>
        
        
        
        /// <param name="Notes">The notes as input by the one who entered the TimeOffRequest.</param>
        
        
        
        /// <param name="SubmittedBy">The user who submitted this TimeOffRequest.</param>
        
        
        
        
        
        /// <param name="ReviewedBy">The user who reviewed this TimeOffRequest.</param>
        
        
        
        
        
        /// <param name="ModifiedBy">The user who last modified this TimeOffRequest.</param>
        
        
        
        
        
        
        
        /// <param name="FullDayManagementUnitDates">ISO-8601 date only with no timezones.  Should be interpreted in the Management Unit&#39;s configured time zone.  Required if isFullDayRequest == true.</param>
        
        
        public TimeOffRequest(string Name = null, User User = null, bool? IsFullDayRequest = null, bool? MarkedAsRead = null, string ActivityCodeId = null, StatusEnum? Status = null, List<DateTime?> PartialDayStartDateTimes = null, int? DailyDurationMinutes = null, string Notes = null, User SubmittedBy = null, User ReviewedBy = null, User ModifiedBy = null, List<string> FullDayManagementUnitDates = null)
        {
            
            
            
            
            
            
            
            
            
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for TimeOffRequest and cannot be null");
            }
            else
            {
                this.User = User;
            }
            
            
            
            
            
            // to ensure "IsFullDayRequest" is required (not null)
            if (IsFullDayRequest == null)
            {
                throw new InvalidDataException("IsFullDayRequest is a required property for TimeOffRequest and cannot be null");
            }
            else
            {
                this.IsFullDayRequest = IsFullDayRequest;
            }
            
            
            
            
            
            // to ensure "MarkedAsRead" is required (not null)
            if (MarkedAsRead == null)
            {
                throw new InvalidDataException("MarkedAsRead is a required property for TimeOffRequest and cannot be null");
            }
            else
            {
                this.MarkedAsRead = MarkedAsRead;
            }
            
            
            
            
            
            // to ensure "ActivityCodeId" is required (not null)
            if (ActivityCodeId == null)
            {
                throw new InvalidDataException("ActivityCodeId is a required property for TimeOffRequest and cannot be null");
            }
            else
            {
                this.ActivityCodeId = ActivityCodeId;
            }
            
            
            
            
            
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for TimeOffRequest and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            
            
            
            
            
            
            
            
            
            // to ensure "DailyDurationMinutes" is required (not null)
            if (DailyDurationMinutes == null)
            {
                throw new InvalidDataException("DailyDurationMinutes is a required property for TimeOffRequest and cannot be null");
            }
            else
            {
                this.DailyDurationMinutes = DailyDurationMinutes;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.PartialDayStartDateTimes = PartialDayStartDateTimes;
            
            
            
            
            
            
            
            
            
            
            
            
this.Notes = Notes;
            
            
            
            
            
            
            
            
this.SubmittedBy = SubmittedBy;
            
            
            
            
            
            
            
            
            
            
this.ReviewedBy = ReviewedBy;
            
            
            
            
            
            
            
            
            
            
this.ModifiedBy = ModifiedBy;
            
            
            
            
            
            
            
            
            
            
            
            
this.FullDayManagementUnitDates = FullDayManagementUnitDates;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The user associated with this TimeOffRequest
        /// </summary>
        /// <value>The user associated with this TimeOffRequest</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        
        
        
        /// <summary>
        /// Whether this is a full day request (false means partial day)
        /// </summary>
        /// <value>Whether this is a full day request (false means partial day)</value>
        [DataMember(Name="isFullDayRequest", EmitDefaultValue=false)]
        public bool? IsFullDayRequest { get; set; }
        
        
        
        /// <summary>
        /// Whether this request has been marked as read by the agent
        /// </summary>
        /// <value>Whether this request has been marked as read by the agent</value>
        [DataMember(Name="markedAsRead", EmitDefaultValue=false)]
        public bool? MarkedAsRead { get; set; }
        
        
        
        /// <summary>
        /// The ID of the activity code associated with this TimeOffRequest
        /// </summary>
        /// <value>The ID of the activity code associated with this TimeOffRequest</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }
        
        
        
        
        
        /// <summary>
        /// The start date-times for partial day requests.  Required if isFullDayRequest == false
        /// </summary>
        /// <value>The start date-times for partial day requests.  Required if isFullDayRequest == false</value>
        [DataMember(Name="partialDayStartDateTimes", EmitDefaultValue=false)]
        public List<DateTime?> PartialDayStartDateTimes { get; set; }
        
        
        
        /// <summary>
        /// The daily duration of this TimeOffRequest in minutes
        /// </summary>
        /// <value>The daily duration of this TimeOffRequest in minutes</value>
        [DataMember(Name="dailyDurationMinutes", EmitDefaultValue=false)]
        public int? DailyDurationMinutes { get; set; }
        
        
        
        /// <summary>
        /// The notes as input by the one who entered the TimeOffRequest
        /// </summary>
        /// <value>The notes as input by the one who entered the TimeOffRequest</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        
        
        
        /// <summary>
        /// The user who submitted this TimeOffRequest
        /// </summary>
        /// <value>The user who submitted this TimeOffRequest</value>
        [DataMember(Name="submittedBy", EmitDefaultValue=false)]
        public User SubmittedBy { get; set; }
        
        
        
        /// <summary>
        /// The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="submittedDate", EmitDefaultValue=false)]
        public DateTime? SubmittedDate { get; private set; }
        
        
        
        /// <summary>
        /// The user who reviewed this TimeOffRequest
        /// </summary>
        /// <value>The user who reviewed this TimeOffRequest</value>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public User ReviewedBy { get; set; }
        
        
        
        /// <summary>
        /// The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this request was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="reviewedDate", EmitDefaultValue=false)]
        public DateTime? ReviewedDate { get; private set; }
        
        
        
        /// <summary>
        /// The user who last modified this TimeOffRequest
        /// </summary>
        /// <value>The user who last modified this TimeOffRequest</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public User ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// The timestamp when this request was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this request was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// ISO-8601 date only with no timezones.  Should be interpreted in the Management Unit&#39;s configured time zone.  Required if isFullDayRequest == true
        /// </summary>
        /// <value>ISO-8601 date only with no timezones.  Should be interpreted in the Management Unit&#39;s configured time zone.  Required if isFullDayRequest == true</value>
        [DataMember(Name="fullDayManagementUnitDates", EmitDefaultValue=false)]
        public List<string> FullDayManagementUnitDates { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeOffRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            
            sb.Append("  IsFullDayRequest: ").Append(IsFullDayRequest).Append("\n");
            
            sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
            
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            
            sb.Append("  Status: ").Append(Status).Append("\n");
            
            sb.Append("  PartialDayStartDateTimes: ").Append(PartialDayStartDateTimes).Append("\n");
            
            sb.Append("  DailyDurationMinutes: ").Append(DailyDurationMinutes).Append("\n");
            
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            
            sb.Append("  SubmittedBy: ").Append(SubmittedBy).Append("\n");
            
            sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
            
            sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
            
            sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
            
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
            sb.Append("  FullDayManagementUnitDates: ").Append(FullDayManagementUnitDates).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TimeOffRequest);
        }

        /// <summary>
        /// Returns true if TimeOffRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeOffRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffRequest other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.SubmittedBy == other.SubmittedBy ||
                    this.SubmittedBy != null &&
                    this.SubmittedBy.Equals(other.SubmittedBy)
                ) &&
                (
                    this.SubmittedDate == other.SubmittedDate ||
                    this.SubmittedDate != null &&
                    this.SubmittedDate.Equals(other.SubmittedDate)
                ) &&
                (
                    this.ReviewedBy == other.ReviewedBy ||
                    this.ReviewedBy != null &&
                    this.ReviewedBy.Equals(other.ReviewedBy)
                ) &&
                (
                    this.ReviewedDate == other.ReviewedDate ||
                    this.ReviewedDate != null &&
                    this.ReviewedDate.Equals(other.ReviewedDate)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.FullDayManagementUnitDates == other.FullDayManagementUnitDates ||
                    this.FullDayManagementUnitDates != null &&
                    this.FullDayManagementUnitDates.SequenceEqual(other.FullDayManagementUnitDates)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.IsFullDayRequest != null)
                    hash = hash * 59 + this.IsFullDayRequest.GetHashCode();
                
                if (this.MarkedAsRead != null)
                    hash = hash * 59 + this.MarkedAsRead.GetHashCode();
                
                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.PartialDayStartDateTimes != null)
                    hash = hash * 59 + this.PartialDayStartDateTimes.GetHashCode();
                
                if (this.DailyDurationMinutes != null)
                    hash = hash * 59 + this.DailyDurationMinutes.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.SubmittedBy != null)
                    hash = hash * 59 + this.SubmittedBy.GetHashCode();
                
                if (this.SubmittedDate != null)
                    hash = hash * 59 + this.SubmittedDate.GetHashCode();
                
                if (this.ReviewedBy != null)
                    hash = hash * 59 + this.ReviewedBy.GetHashCode();
                
                if (this.ReviewedDate != null)
                    hash = hash * 59 + this.ReviewedDate.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.FullDayManagementUnitDates != null)
                    hash = hash * 59 + this.FullDayManagementUnitDates.GetHashCode();
                
                return hash;
            }
        }
    }

}
