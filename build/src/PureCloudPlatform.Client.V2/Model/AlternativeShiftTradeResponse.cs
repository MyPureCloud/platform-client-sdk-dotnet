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
    /// AlternativeShiftTradeResponse
    /// </summary>
    [DataContract]
    public partial class AlternativeShiftTradeResponse :  IEquatable<AlternativeShiftTradeResponse>
    {
        /// <summary>
        /// The state of this alternative shift trade
        /// </summary>
        /// <value>The state of this alternative shift trade</value>
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
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
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
            /// Enum Submitted for "Submitted"
            /// </summary>
            [EnumMember(Value = "Submitted")]
            Submitted,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved
        }
        /// <summary>
        /// The processing status of this alternative shift trade
        /// </summary>
        /// <value>The processing status of this alternative shift trade</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ProcessingStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Waitingforscheduleupdate for "WaitingForScheduleUpdate"
            /// </summary>
            [EnumMember(Value = "WaitingForScheduleUpdate")]
            Waitingforscheduleupdate,
            
            /// <summary>
            /// Enum Scheduleupdating for "ScheduleUpdating"
            /// </summary>
            [EnumMember(Value = "ScheduleUpdating")]
            Scheduleupdating,
            
            /// <summary>
            /// Enum Scheduleupdated for "ScheduleUpdated"
            /// </summary>
            [EnumMember(Value = "ScheduleUpdated")]
            Scheduleupdated,
            
            /// <summary>
            /// Enum Waitingforreview for "WaitingForReview"
            /// </summary>
            [EnumMember(Value = "WaitingForReview")]
            Waitingforreview,
            
            /// <summary>
            /// Enum Reviewing for "Reviewing"
            /// </summary>
            [EnumMember(Value = "Reviewing")]
            Reviewing
        }
        /// <summary>
        /// Gets or Sets Violations
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ViolationsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Servicegoalsnotmet for "ServiceGoalsNotMet"
            /// </summary>
            [EnumMember(Value = "ServiceGoalsNotMet")]
            Servicegoalsnotmet
        }
        /// <summary>
        /// The state of this alternative shift trade
        /// </summary>
        /// <value>The state of this alternative shift trade</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The processing status of this alternative shift trade
        /// </summary>
        /// <value>The processing status of this alternative shift trade</value>
        [DataMember(Name="processingStatus", EmitDefaultValue=false)]
        public ProcessingStatusEnum? ProcessingStatus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeShiftTradeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlternativeShiftTradeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeShiftTradeResponse" /> class.
        /// </summary>
        /// <param name="ShiftOfferJobId">The job ID of the alternative shift offer listing, from which the trade was chosen (required).</param>
        /// <param name="ExistingShifts">The existing shifts from the offer, may be empty (required).</param>
        /// <param name="OfferedShifts">The offered shifts from the offer, may be empty (required).</param>
        /// <param name="Schedule">The existing schedule information associated with the trade (required).</param>
        /// <param name="ManagementUnit">The management unit of this alternative shift trade request (required).</param>
        /// <param name="User">The user who submitted the trade request (required).</param>
        /// <param name="WeekDate">The start week date of the associated schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="ExpirationDate">The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration.</param>
        /// <param name="State">The state of this alternative shift trade (required).</param>
        /// <param name="ProcessingStatus">The processing status of this alternative shift trade.</param>
        /// <param name="SystemDateReviewed">The timestamp of when the trade request was reviewed by the system in ISO-8601 format.</param>
        /// <param name="AdminDateReviewed">The timestamp of when the trade request was reviewed by an admin in ISO-8601 format.</param>
        /// <param name="AdminReviewedBy">The admin who reviewed this alternative shift trade after system denial.</param>
        /// <param name="Violations">A list of trade match violations (required).</param>
        /// <param name="Metadata">Version metadata for this alternative shift trade (required).</param>
        public AlternativeShiftTradeResponse(string ShiftOfferJobId = null, List<AlternativeShiftAgentScheduledShift> ExistingShifts = null, List<AlternativeShiftAgentScheduledShift> OfferedShifts = null, AlternativeShiftScheduleLookup Schedule = null, ManagementUnitReference ManagementUnit = null, UserReference User = null, String WeekDate = null, DateTime? ExpirationDate = null, StateEnum? State = null, ProcessingStatusEnum? ProcessingStatus = null, DateTime? SystemDateReviewed = null, DateTime? AdminDateReviewed = null, UserReference AdminReviewedBy = null, List<ViolationsEnum> Violations = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.ShiftOfferJobId = ShiftOfferJobId;
            this.ExistingShifts = ExistingShifts;
            this.OfferedShifts = OfferedShifts;
            this.Schedule = Schedule;
            this.ManagementUnit = ManagementUnit;
            this.User = User;
            this.WeekDate = WeekDate;
            this.ExpirationDate = ExpirationDate;
            this.State = State;
            this.ProcessingStatus = ProcessingStatus;
            this.SystemDateReviewed = SystemDateReviewed;
            this.AdminDateReviewed = AdminDateReviewed;
            this.AdminReviewedBy = AdminReviewedBy;
            this.Violations = Violations;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The job ID of the alternative shift offer listing, from which the trade was chosen
        /// </summary>
        /// <value>The job ID of the alternative shift offer listing, from which the trade was chosen</value>
        [DataMember(Name="shiftOfferJobId", EmitDefaultValue=false)]
        public string ShiftOfferJobId { get; set; }



        /// <summary>
        /// The existing shifts from the offer, may be empty
        /// </summary>
        /// <value>The existing shifts from the offer, may be empty</value>
        [DataMember(Name="existingShifts", EmitDefaultValue=false)]
        public List<AlternativeShiftAgentScheduledShift> ExistingShifts { get; set; }



        /// <summary>
        /// The offered shifts from the offer, may be empty
        /// </summary>
        /// <value>The offered shifts from the offer, may be empty</value>
        [DataMember(Name="offeredShifts", EmitDefaultValue=false)]
        public List<AlternativeShiftAgentScheduledShift> OfferedShifts { get; set; }



        /// <summary>
        /// The existing schedule information associated with the trade
        /// </summary>
        /// <value>The existing schedule information associated with the trade</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public AlternativeShiftScheduleLookup Schedule { get; set; }



        /// <summary>
        /// The management unit of this alternative shift trade request
        /// </summary>
        /// <value>The management unit of this alternative shift trade request</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// The user who submitted the trade request
        /// </summary>
        /// <value>The user who submitted the trade request</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The start week date of the associated schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start week date of the associated schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }



        /// <summary>
        /// The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration
        /// </summary>
        /// <value>The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }







        /// <summary>
        /// The timestamp of when the trade request was reviewed by the system in ISO-8601 format
        /// </summary>
        /// <value>The timestamp of when the trade request was reviewed by the system in ISO-8601 format</value>
        [DataMember(Name="systemDateReviewed", EmitDefaultValue=false)]
        public DateTime? SystemDateReviewed { get; set; }



        /// <summary>
        /// The timestamp of when the trade request was reviewed by an admin in ISO-8601 format
        /// </summary>
        /// <value>The timestamp of when the trade request was reviewed by an admin in ISO-8601 format</value>
        [DataMember(Name="adminDateReviewed", EmitDefaultValue=false)]
        public DateTime? AdminDateReviewed { get; set; }



        /// <summary>
        /// The admin who reviewed this alternative shift trade after system denial
        /// </summary>
        /// <value>The admin who reviewed this alternative shift trade after system denial</value>
        [DataMember(Name="adminReviewedBy", EmitDefaultValue=false)]
        public UserReference AdminReviewedBy { get; set; }



        /// <summary>
        /// A list of trade match violations
        /// </summary>
        /// <value>A list of trade match violations</value>
        [DataMember(Name="violations", EmitDefaultValue=false)]
        public List<ViolationsEnum> Violations { get; set; }



        /// <summary>
        /// Version metadata for this alternative shift trade
        /// </summary>
        /// <value>Version metadata for this alternative shift trade</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlternativeShiftTradeResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ShiftOfferJobId: ").Append(ShiftOfferJobId).Append("\n");
            sb.Append("  ExistingShifts: ").Append(ExistingShifts).Append("\n");
            sb.Append("  OfferedShifts: ").Append(OfferedShifts).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ProcessingStatus: ").Append(ProcessingStatus).Append("\n");
            sb.Append("  SystemDateReviewed: ").Append(SystemDateReviewed).Append("\n");
            sb.Append("  AdminDateReviewed: ").Append(AdminDateReviewed).Append("\n");
            sb.Append("  AdminReviewedBy: ").Append(AdminReviewedBy).Append("\n");
            sb.Append("  Violations: ").Append(Violations).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as AlternativeShiftTradeResponse);
        }

        /// <summary>
        /// Returns true if AlternativeShiftTradeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AlternativeShiftTradeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlternativeShiftTradeResponse other)
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
                    this.ShiftOfferJobId == other.ShiftOfferJobId ||
                    this.ShiftOfferJobId != null &&
                    this.ShiftOfferJobId.Equals(other.ShiftOfferJobId)
                ) &&
                (
                    this.ExistingShifts == other.ExistingShifts ||
                    this.ExistingShifts != null &&
                    this.ExistingShifts.SequenceEqual(other.ExistingShifts)
                ) &&
                (
                    this.OfferedShifts == other.OfferedShifts ||
                    this.OfferedShifts != null &&
                    this.OfferedShifts.SequenceEqual(other.OfferedShifts)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ProcessingStatus == other.ProcessingStatus ||
                    this.ProcessingStatus != null &&
                    this.ProcessingStatus.Equals(other.ProcessingStatus)
                ) &&
                (
                    this.SystemDateReviewed == other.SystemDateReviewed ||
                    this.SystemDateReviewed != null &&
                    this.SystemDateReviewed.Equals(other.SystemDateReviewed)
                ) &&
                (
                    this.AdminDateReviewed == other.AdminDateReviewed ||
                    this.AdminDateReviewed != null &&
                    this.AdminDateReviewed.Equals(other.AdminDateReviewed)
                ) &&
                (
                    this.AdminReviewedBy == other.AdminReviewedBy ||
                    this.AdminReviewedBy != null &&
                    this.AdminReviewedBy.Equals(other.AdminReviewedBy)
                ) &&
                (
                    this.Violations == other.Violations ||
                    this.Violations != null &&
                    this.Violations.SequenceEqual(other.Violations)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.ShiftOfferJobId != null)
                    hash = hash * 59 + this.ShiftOfferJobId.GetHashCode();

                if (this.ExistingShifts != null)
                    hash = hash * 59 + this.ExistingShifts.GetHashCode();

                if (this.OfferedShifts != null)
                    hash = hash * 59 + this.OfferedShifts.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.ProcessingStatus != null)
                    hash = hash * 59 + this.ProcessingStatus.GetHashCode();

                if (this.SystemDateReviewed != null)
                    hash = hash * 59 + this.SystemDateReviewed.GetHashCode();

                if (this.AdminDateReviewed != null)
                    hash = hash * 59 + this.AdminDateReviewed.GetHashCode();

                if (this.AdminReviewedBy != null)
                    hash = hash * 59 + this.AdminReviewedBy.GetHashCode();

                if (this.Violations != null)
                    hash = hash * 59 + this.Violations.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
