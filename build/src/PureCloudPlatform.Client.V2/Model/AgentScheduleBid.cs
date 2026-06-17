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
    /// AgentScheduleBid
    /// </summary>
    [DataContract]
    public partial class AgentScheduleBid :  IEquatable<AgentScheduleBid>
    {
        /// <summary>
        /// The state of the bid
        /// </summary>
        /// <value>The state of the bid</value>
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
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Locked for "Locked"
            /// </summary>
            [EnumMember(Value = "Locked")]
            Locked,
            
            /// <summary>
            /// Enum Optimized for "Optimized"
            /// </summary>
            [EnumMember(Value = "Optimized")]
            Optimized,
            
            /// <summary>
            /// Enum Scheduled for "Scheduled"
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed,
            
            /// <summary>
            /// Enum Processed for "Processed"
            /// </summary>
            [EnumMember(Value = "Processed")]
            Processed,
            
            /// <summary>
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published
        }
        /// <summary>
        /// The type of the bid
        /// </summary>
        /// <value>The type of the bid</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BidTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Workplanbid for "WorkPlanBid"
            /// </summary>
            [EnumMember(Value = "WorkPlanBid")]
            Workplanbid,
            
            /// <summary>
            /// Enum Schedulebid for "ScheduleBid"
            /// </summary>
            [EnumMember(Value = "ScheduleBid")]
            Schedulebid
        }
        /// <summary>
        /// The state of the bid
        /// </summary>
        /// <value>The state of the bid</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The type of the bid
        /// </summary>
        /// <value>The type of the bid</value>
        [DataMember(Name="bidType", EmitDefaultValue=false)]
        public BidTypeEnum? BidType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleBid" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentScheduleBid() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleBid" /> class.
        /// </summary>
        /// <param name="Id">The ID of the schedule bid (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="BidWindowStartDate">The bid start date when agents can start participating in schedule bidding relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="BidWindowEndDate">The bid end date relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="EffectiveDate">The date when schedule sets would be effective for schedule generation relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="Status">The state of the bid (required).</param>
        /// <param name="BidType">The type of the bid (required).</param>
        public AgentScheduleBid(string Id = null, string Name = null, String BidWindowStartDate = null, String BidWindowEndDate = null, String EffectiveDate = null, StatusEnum? Status = null, BidTypeEnum? BidType = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.BidWindowStartDate = BidWindowStartDate;
            this.BidWindowEndDate = BidWindowEndDate;
            this.EffectiveDate = EffectiveDate;
            this.Status = Status;
            this.BidType = BidType;
            
        }
        


        /// <summary>
        /// The ID of the schedule bid
        /// </summary>
        /// <value>The ID of the schedule bid</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The bid start date when agents can start participating in schedule bidding relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The bid start date when agents can start participating in schedule bidding relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="bidWindowStartDate", EmitDefaultValue=false)]
        public String BidWindowStartDate { get; set; }



        /// <summary>
        /// The bid end date relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The bid end date relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="bidWindowEndDate", EmitDefaultValue=false)]
        public String BidWindowEndDate { get; set; }



        /// <summary>
        /// The date when schedule sets would be effective for schedule generation relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The date when schedule sets would be effective for schedule generation relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public String EffectiveDate { get; set; }







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
            sb.Append("class AgentScheduleBid {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BidWindowStartDate: ").Append(BidWindowStartDate).Append("\n");
            sb.Append("  BidWindowEndDate: ").Append(BidWindowEndDate).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BidType: ").Append(BidType).Append("\n");
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
            return this.Equals(obj as AgentScheduleBid);
        }

        /// <summary>
        /// Returns true if AgentScheduleBid instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentScheduleBid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentScheduleBid other)
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
                    this.BidWindowStartDate == other.BidWindowStartDate ||
                    this.BidWindowStartDate != null &&
                    this.BidWindowStartDate.Equals(other.BidWindowStartDate)
                ) &&
                (
                    this.BidWindowEndDate == other.BidWindowEndDate ||
                    this.BidWindowEndDate != null &&
                    this.BidWindowEndDate.Equals(other.BidWindowEndDate)
                ) &&
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.BidType == other.BidType ||
                    this.BidType != null &&
                    this.BidType.Equals(other.BidType)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.BidWindowStartDate != null)
                    hash = hash * 59 + this.BidWindowStartDate.GetHashCode();

                if (this.BidWindowEndDate != null)
                    hash = hash * 59 + this.BidWindowEndDate.GetHashCode();

                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.BidType != null)
                    hash = hash * 59 + this.BidType.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
