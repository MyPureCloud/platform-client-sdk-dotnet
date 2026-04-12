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
    /// WfmShiftTradingJobCompleteEventTradeEntity
    /// </summary>
    [DataContract]
    public partial class WfmShiftTradingJobCompleteEventTradeEntity :  IEquatable<WfmShiftTradingJobCompleteEventTradeEntity>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
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
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShiftTradingJobCompleteEventTradeEntity" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="State">State.</param>
        /// <param name="ExpirationDate">ExpirationDate.</param>
        /// <param name="AcceptableIntervals">AcceptableIntervals.</param>
        /// <param name="OneSided">OneSided.</param>
        /// <param name="Initiating">Initiating.</param>
        /// <param name="Receiving">Receiving.</param>
        /// <param name="TargetUserId">TargetUserId.</param>
        /// <param name="ReviewedBy">ReviewedBy.</param>
        /// <param name="ReviewedDate">ReviewedDate.</param>
        /// <param name="Metadata">Metadata.</param>
        public WfmShiftTradingJobCompleteEventTradeEntity(string Id = null, StateEnum? State = null, string ExpirationDate = null, List<WfmShiftTradingJobCompleteEventWfmDateTimeInterval> AcceptableIntervals = null, bool? OneSided = null, WfmShiftTradingJobCompleteEventTradeSide Initiating = null, WfmShiftTradingJobCompleteEventTradeSide Receiving = null, string TargetUserId = null, string ReviewedBy = null, string ReviewedDate = null, WfmShiftTradingJobCompleteEventWfmVersionMetadata Metadata = null)
        {
            this.Id = Id;
            this.State = State;
            this.ExpirationDate = ExpirationDate;
            this.AcceptableIntervals = AcceptableIntervals;
            this.OneSided = OneSided;
            this.Initiating = Initiating;
            this.Receiving = Receiving;
            this.TargetUserId = TargetUserId;
            this.ReviewedBy = ReviewedBy;
            this.ReviewedDate = ReviewedDate;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }



        /// <summary>
        /// Gets or Sets AcceptableIntervals
        /// </summary>
        [DataMember(Name="acceptableIntervals", EmitDefaultValue=false)]
        public List<WfmShiftTradingJobCompleteEventWfmDateTimeInterval> AcceptableIntervals { get; set; }



        /// <summary>
        /// Gets or Sets OneSided
        /// </summary>
        [DataMember(Name="oneSided", EmitDefaultValue=false)]
        public bool? OneSided { get; set; }



        /// <summary>
        /// Gets or Sets Initiating
        /// </summary>
        [DataMember(Name="initiating", EmitDefaultValue=false)]
        public WfmShiftTradingJobCompleteEventTradeSide Initiating { get; set; }



        /// <summary>
        /// Gets or Sets Receiving
        /// </summary>
        [DataMember(Name="receiving", EmitDefaultValue=false)]
        public WfmShiftTradingJobCompleteEventTradeSide Receiving { get; set; }



        /// <summary>
        /// Gets or Sets TargetUserId
        /// </summary>
        [DataMember(Name="targetUserId", EmitDefaultValue=false)]
        public string TargetUserId { get; set; }



        /// <summary>
        /// Gets or Sets ReviewedBy
        /// </summary>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public string ReviewedBy { get; set; }



        /// <summary>
        /// Gets or Sets ReviewedDate
        /// </summary>
        [DataMember(Name="reviewedDate", EmitDefaultValue=false)]
        public string ReviewedDate { get; set; }



        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmShiftTradingJobCompleteEventWfmVersionMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShiftTradingJobCompleteEventTradeEntity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
            sb.Append("  OneSided: ").Append(OneSided).Append("\n");
            sb.Append("  Initiating: ").Append(Initiating).Append("\n");
            sb.Append("  Receiving: ").Append(Receiving).Append("\n");
            sb.Append("  TargetUserId: ").Append(TargetUserId).Append("\n");
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
            return this.Equals(obj as WfmShiftTradingJobCompleteEventTradeEntity);
        }

        /// <summary>
        /// Returns true if WfmShiftTradingJobCompleteEventTradeEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShiftTradingJobCompleteEventTradeEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShiftTradingJobCompleteEventTradeEntity other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) &&
                (
                    this.AcceptableIntervals == other.AcceptableIntervals ||
                    this.AcceptableIntervals != null &&
                    this.AcceptableIntervals.SequenceEqual(other.AcceptableIntervals)
                ) &&
                (
                    this.OneSided == other.OneSided ||
                    this.OneSided != null &&
                    this.OneSided.Equals(other.OneSided)
                ) &&
                (
                    this.Initiating == other.Initiating ||
                    this.Initiating != null &&
                    this.Initiating.Equals(other.Initiating)
                ) &&
                (
                    this.Receiving == other.Receiving ||
                    this.Receiving != null &&
                    this.Receiving.Equals(other.Receiving)
                ) &&
                (
                    this.TargetUserId == other.TargetUserId ||
                    this.TargetUserId != null &&
                    this.TargetUserId.Equals(other.TargetUserId)
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

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();

                if (this.AcceptableIntervals != null)
                    hash = hash * 59 + this.AcceptableIntervals.GetHashCode();

                if (this.OneSided != null)
                    hash = hash * 59 + this.OneSided.GetHashCode();

                if (this.Initiating != null)
                    hash = hash * 59 + this.Initiating.GetHashCode();

                if (this.Receiving != null)
                    hash = hash * 59 + this.Receiving.GetHashCode();

                if (this.TargetUserId != null)
                    hash = hash * 59 + this.TargetUserId.GetHashCode();

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
