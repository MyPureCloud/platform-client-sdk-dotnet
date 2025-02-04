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
    /// ShiftTradeResponse
    /// </summary>
    [DataContract]
    public partial class ShiftTradeResponse :  IEquatable<ShiftTradeResponse>
    {
        /// <summary>
        /// The state of this shift trade
        /// </summary>
        /// <value>The state of this shift trade</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unmatched for "Unmatched"
            /// </summary>
            [EnumMember(Value = "Unmatched")]
            Unmatched,
            
            /// <summary>
            /// Enum Matched for "Matched"
            /// </summary>
            [EnumMember(Value = "Matched")]
            Matched,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "Denied"
            /// </summary>
            [EnumMember(Value = "Denied")]
            Denied,
            
            /// <summary>
            /// Enum Expired for "Expired"
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled
        }
        /// <summary>
        /// The state of this shift trade
        /// </summary>
        /// <value>The state of this shift trade</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeResponse" /> class.
        /// </summary>
        /// <param name="Id">The ID of this shift trade.</param>
        /// <param name="WeekDate">The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="Schedule">A reference to the associated schedule.</param>
        /// <param name="State">The state of this shift trade.</param>
        /// <param name="InitiatingUser">The user who initiated this trade.</param>
        /// <param name="InitiatingShiftId">The ID of the shift offered for trade by the initiating user.</param>
        /// <param name="InitiatingShiftStart">The start date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="InitiatingShiftEnd">The end date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ReceivingUser">The user matching the trade, or if the state is not 'Matched', the user to whom the trade request was sent.</param>
        /// <param name="ReceivingShiftId">The ID of the shift being exchanged for the initiating shift, null if the receiving user is picking up a shift.</param>
        /// <param name="ReceivingShiftStart">The start date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ReceivingShiftEnd">The end date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Expiration">When this shift trade offer will expire if not matched or approved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="OneSided">Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return).</param>
        /// <param name="AcceptableIntervals">Time frames when the initiating user is willing to accept trades. Empty means giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="ReviewedBy">The user who reviewed this shift trade.</param>
        /// <param name="ReviewedDate">The timestamp when this shift trade was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Metadata">Version data for this trade.</param>
        public ShiftTradeResponse(string Id = null, String WeekDate = null, BuScheduleReferenceForMuRoute Schedule = null, StateEnum? State = null, UserReference InitiatingUser = null, string InitiatingShiftId = null, DateTime? InitiatingShiftStart = null, DateTime? InitiatingShiftEnd = null, UserReference ReceivingUser = null, string ReceivingShiftId = null, DateTime? ReceivingShiftStart = null, DateTime? ReceivingShiftEnd = null, DateTime? Expiration = null, bool? OneSided = null, List<string> AcceptableIntervals = null, UserReference ReviewedBy = null, DateTime? ReviewedDate = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Id = Id;
            this.WeekDate = WeekDate;
            this.Schedule = Schedule;
            this.State = State;
            this.InitiatingUser = InitiatingUser;
            this.InitiatingShiftId = InitiatingShiftId;
            this.InitiatingShiftStart = InitiatingShiftStart;
            this.InitiatingShiftEnd = InitiatingShiftEnd;
            this.ReceivingUser = ReceivingUser;
            this.ReceivingShiftId = ReceivingShiftId;
            this.ReceivingShiftStart = ReceivingShiftStart;
            this.ReceivingShiftEnd = ReceivingShiftEnd;
            this.Expiration = Expiration;
            this.OneSided = OneSided;
            this.AcceptableIntervals = AcceptableIntervals;
            this.ReviewedBy = ReviewedBy;
            this.ReviewedDate = ReviewedDate;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The ID of this shift trade
        /// </summary>
        /// <value>The ID of this shift trade</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start week date of the initiating shift in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }



        /// <summary>
        /// A reference to the associated schedule
        /// </summary>
        /// <value>A reference to the associated schedule</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public BuScheduleReferenceForMuRoute Schedule { get; set; }





        /// <summary>
        /// The user who initiated this trade
        /// </summary>
        /// <value>The user who initiated this trade</value>
        [DataMember(Name="initiatingUser", EmitDefaultValue=false)]
        public UserReference InitiatingUser { get; set; }



        /// <summary>
        /// The ID of the shift offered for trade by the initiating user
        /// </summary>
        /// <value>The ID of the shift offered for trade by the initiating user</value>
        [DataMember(Name="initiatingShiftId", EmitDefaultValue=false)]
        public string InitiatingShiftId { get; set; }



        /// <summary>
        /// The start date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="initiatingShiftStart", EmitDefaultValue=false)]
        public DateTime? InitiatingShiftStart { get; set; }



        /// <summary>
        /// The end date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end date/time of the shift being offered for trade. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="initiatingShiftEnd", EmitDefaultValue=false)]
        public DateTime? InitiatingShiftEnd { get; set; }



        /// <summary>
        /// The user matching the trade, or if the state is not 'Matched', the user to whom the trade request was sent
        /// </summary>
        /// <value>The user matching the trade, or if the state is not 'Matched', the user to whom the trade request was sent</value>
        [DataMember(Name="receivingUser", EmitDefaultValue=false)]
        public UserReference ReceivingUser { get; set; }



        /// <summary>
        /// The ID of the shift being exchanged for the initiating shift, null if the receiving user is picking up a shift
        /// </summary>
        /// <value>The ID of the shift being exchanged for the initiating shift, null if the receiving user is picking up a shift</value>
        [DataMember(Name="receivingShiftId", EmitDefaultValue=false)]
        public string ReceivingShiftId { get; set; }



        /// <summary>
        /// The start date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="receivingShiftStart", EmitDefaultValue=false)]
        public DateTime? ReceivingShiftStart { get; set; }



        /// <summary>
        /// The end date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end date/time of the receiving shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="receivingShiftEnd", EmitDefaultValue=false)]
        public DateTime? ReceivingShiftEnd { get; set; }



        /// <summary>
        /// When this shift trade offer will expire if not matched or approved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When this shift trade offer will expire if not matched or approved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public DateTime? Expiration { get; set; }



        /// <summary>
        /// Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return)
        /// </summary>
        /// <value>Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return)</value>
        [DataMember(Name="oneSided", EmitDefaultValue=false)]
        public bool? OneSided { get; set; }



        /// <summary>
        /// Time frames when the initiating user is willing to accept trades. Empty means giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Time frames when the initiating user is willing to accept trades. Empty means giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="acceptableIntervals", EmitDefaultValue=false)]
        public List<string> AcceptableIntervals { get; set; }



        /// <summary>
        /// The user who reviewed this shift trade
        /// </summary>
        /// <value>The user who reviewed this shift trade</value>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public UserReference ReviewedBy { get; set; }



        /// <summary>
        /// The timestamp when this shift trade was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when this shift trade was reviewed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="reviewedDate", EmitDefaultValue=false)]
        public DateTime? ReviewedDate { get; set; }



        /// <summary>
        /// Version data for this trade
        /// </summary>
        /// <value>Version data for this trade</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  InitiatingUser: ").Append(InitiatingUser).Append("\n");
            sb.Append("  InitiatingShiftId: ").Append(InitiatingShiftId).Append("\n");
            sb.Append("  InitiatingShiftStart: ").Append(InitiatingShiftStart).Append("\n");
            sb.Append("  InitiatingShiftEnd: ").Append(InitiatingShiftEnd).Append("\n");
            sb.Append("  ReceivingUser: ").Append(ReceivingUser).Append("\n");
            sb.Append("  ReceivingShiftId: ").Append(ReceivingShiftId).Append("\n");
            sb.Append("  ReceivingShiftStart: ").Append(ReceivingShiftStart).Append("\n");
            sb.Append("  ReceivingShiftEnd: ").Append(ReceivingShiftEnd).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  OneSided: ").Append(OneSided).Append("\n");
            sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
            sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
            sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
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
            return this.Equals(obj as ShiftTradeResponse);
        }

        /// <summary>
        /// Returns true if ShiftTradeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeResponse other)
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
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.InitiatingUser == other.InitiatingUser ||
                    this.InitiatingUser != null &&
                    this.InitiatingUser.Equals(other.InitiatingUser)
                ) &&
                (
                    this.InitiatingShiftId == other.InitiatingShiftId ||
                    this.InitiatingShiftId != null &&
                    this.InitiatingShiftId.Equals(other.InitiatingShiftId)
                ) &&
                (
                    this.InitiatingShiftStart == other.InitiatingShiftStart ||
                    this.InitiatingShiftStart != null &&
                    this.InitiatingShiftStart.Equals(other.InitiatingShiftStart)
                ) &&
                (
                    this.InitiatingShiftEnd == other.InitiatingShiftEnd ||
                    this.InitiatingShiftEnd != null &&
                    this.InitiatingShiftEnd.Equals(other.InitiatingShiftEnd)
                ) &&
                (
                    this.ReceivingUser == other.ReceivingUser ||
                    this.ReceivingUser != null &&
                    this.ReceivingUser.Equals(other.ReceivingUser)
                ) &&
                (
                    this.ReceivingShiftId == other.ReceivingShiftId ||
                    this.ReceivingShiftId != null &&
                    this.ReceivingShiftId.Equals(other.ReceivingShiftId)
                ) &&
                (
                    this.ReceivingShiftStart == other.ReceivingShiftStart ||
                    this.ReceivingShiftStart != null &&
                    this.ReceivingShiftStart.Equals(other.ReceivingShiftStart)
                ) &&
                (
                    this.ReceivingShiftEnd == other.ReceivingShiftEnd ||
                    this.ReceivingShiftEnd != null &&
                    this.ReceivingShiftEnd.Equals(other.ReceivingShiftEnd)
                ) &&
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
                ) &&
                (
                    this.OneSided == other.OneSided ||
                    this.OneSided != null &&
                    this.OneSided.Equals(other.OneSided)
                ) &&
                (
                    this.AcceptableIntervals == other.AcceptableIntervals ||
                    this.AcceptableIntervals != null &&
                    this.AcceptableIntervals.SequenceEqual(other.AcceptableIntervals)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.InitiatingUser != null)
                    hash = hash * 59 + this.InitiatingUser.GetHashCode();

                if (this.InitiatingShiftId != null)
                    hash = hash * 59 + this.InitiatingShiftId.GetHashCode();

                if (this.InitiatingShiftStart != null)
                    hash = hash * 59 + this.InitiatingShiftStart.GetHashCode();

                if (this.InitiatingShiftEnd != null)
                    hash = hash * 59 + this.InitiatingShiftEnd.GetHashCode();

                if (this.ReceivingUser != null)
                    hash = hash * 59 + this.ReceivingUser.GetHashCode();

                if (this.ReceivingShiftId != null)
                    hash = hash * 59 + this.ReceivingShiftId.GetHashCode();

                if (this.ReceivingShiftStart != null)
                    hash = hash * 59 + this.ReceivingShiftStart.GetHashCode();

                if (this.ReceivingShiftEnd != null)
                    hash = hash * 59 + this.ReceivingShiftEnd.GetHashCode();

                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();

                if (this.OneSided != null)
                    hash = hash * 59 + this.OneSided.GetHashCode();

                if (this.AcceptableIntervals != null)
                    hash = hash * 59 + this.AcceptableIntervals.GetHashCode();

                if (this.ReviewedBy != null)
                    hash = hash * 59 + this.ReviewedBy.GetHashCode();

                if (this.ReviewedDate != null)
                    hash = hash * 59 + this.ReviewedDate.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
