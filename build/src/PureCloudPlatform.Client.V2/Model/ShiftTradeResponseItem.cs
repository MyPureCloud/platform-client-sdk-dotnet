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
    /// ShiftTradeResponseItem
    /// </summary>
    [DataContract]
    public partial class ShiftTradeResponseItem :  IEquatable<ShiftTradeResponseItem>
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
        /// Initializes a new instance of the <see cref="ShiftTradeResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShiftTradeResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeResponseItem" /> class.
        /// </summary>
        /// <param name="Id">The ID of this shift trade (required).</param>
        /// <param name="State">The state of this shift trade (required).</param>
        /// <param name="ExpirationDate">When this shift trade will expire. Date time is represented as an ISO-8601 string.</param>
        /// <param name="Initiating">Details about the initiating user involved in this shift trade (required).</param>
        /// <param name="Receiving">Details about the receiving user involved in this shift trade.</param>
        /// <param name="AcceptableIntervals">Time frames when the initiating user is willing to accept trades. Empty means giving up the shift (required).</param>
        /// <param name="OneSided">Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return) (required).</param>
        /// <param name="Target">The user to whom the shift trade request was sent in a direct trade, or the user with whom a shift trade was Matched.</param>
        /// <param name="ReviewedBy">The admin who approved or denied this shift trade.</param>
        /// <param name="ReviewedDate">The timestamp of when the trade request was reviewed by an admin in ISO-8601 format.</param>
        /// <param name="Metadata">Version metadata for this shift trade (required).</param>
        public ShiftTradeResponseItem(string Id = null, StateEnum? State = null, DateTime? ExpirationDate = null, ShiftTradeInitiatingSideResponseItem Initiating = null, ShiftTradeReceivingSideResponseItem Receiving = null, List<RequiredDateRange> AcceptableIntervals = null, bool? OneSided = null, ShiftTradeTargetResponseItem Target = null, UserReference ReviewedBy = null, DateTime? ReviewedDate = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Id = Id;
            this.State = State;
            this.ExpirationDate = ExpirationDate;
            this.Initiating = Initiating;
            this.Receiving = Receiving;
            this.AcceptableIntervals = AcceptableIntervals;
            this.OneSided = OneSided;
            this.Target = Target;
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
        /// When this shift trade will expire. Date time is represented as an ISO-8601 string
        /// </summary>
        /// <value>When this shift trade will expire. Date time is represented as an ISO-8601 string</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }



        /// <summary>
        /// Details about the initiating user involved in this shift trade
        /// </summary>
        /// <value>Details about the initiating user involved in this shift trade</value>
        [DataMember(Name="initiating", EmitDefaultValue=false)]
        public ShiftTradeInitiatingSideResponseItem Initiating { get; set; }



        /// <summary>
        /// Details about the receiving user involved in this shift trade
        /// </summary>
        /// <value>Details about the receiving user involved in this shift trade</value>
        [DataMember(Name="receiving", EmitDefaultValue=false)]
        public ShiftTradeReceivingSideResponseItem Receiving { get; set; }



        /// <summary>
        /// Time frames when the initiating user is willing to accept trades. Empty means giving up the shift
        /// </summary>
        /// <value>Time frames when the initiating user is willing to accept trades. Empty means giving up the shift</value>
        [DataMember(Name="acceptableIntervals", EmitDefaultValue=false)]
        public List<RequiredDateRange> AcceptableIntervals { get; set; }



        /// <summary>
        /// Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return)
        /// </summary>
        /// <value>Whether this is a one-sided shift trade (e.g. the initiating user is not asking for a shift in return)</value>
        [DataMember(Name="oneSided", EmitDefaultValue=false)]
        public bool? OneSided { get; set; }



        /// <summary>
        /// The user to whom the shift trade request was sent in a direct trade, or the user with whom a shift trade was Matched
        /// </summary>
        /// <value>The user to whom the shift trade request was sent in a direct trade, or the user with whom a shift trade was Matched</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public ShiftTradeTargetResponseItem Target { get; set; }



        /// <summary>
        /// The admin who approved or denied this shift trade
        /// </summary>
        /// <value>The admin who approved or denied this shift trade</value>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public UserReference ReviewedBy { get; set; }



        /// <summary>
        /// The timestamp of when the trade request was reviewed by an admin in ISO-8601 format
        /// </summary>
        /// <value>The timestamp of when the trade request was reviewed by an admin in ISO-8601 format</value>
        [DataMember(Name="reviewedDate", EmitDefaultValue=false)]
        public DateTime? ReviewedDate { get; set; }



        /// <summary>
        /// Version metadata for this shift trade
        /// </summary>
        /// <value>Version metadata for this shift trade</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeResponseItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Initiating: ").Append(Initiating).Append("\n");
            sb.Append("  Receiving: ").Append(Receiving).Append("\n");
            sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
            sb.Append("  OneSided: ").Append(OneSided).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(obj as ShiftTradeResponseItem);
        }

        /// <summary>
        /// Returns true if ShiftTradeResponseItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeResponseItem other)
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
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
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

                if (this.Initiating != null)
                    hash = hash * 59 + this.Initiating.GetHashCode();

                if (this.Receiving != null)
                    hash = hash * 59 + this.Receiving.GetHashCode();

                if (this.AcceptableIntervals != null)
                    hash = hash * 59 + this.AcceptableIntervals.GetHashCode();

                if (this.OneSided != null)
                    hash = hash * 59 + this.OneSided.GetHashCode();

                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

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
