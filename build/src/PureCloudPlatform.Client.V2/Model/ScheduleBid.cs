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
    /// ScheduleBid
    /// </summary>
    [DataContract]
    public partial class ScheduleBid :  IEquatable<ScheduleBid>
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
        /// The type of agent ranking selected for this bid
        /// </summary>
        /// <value>The type of agent ranking selected for this bid</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AgentRankingTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Hiredate for "HireDate"
            /// </summary>
            [EnumMember(Value = "HireDate")]
            Hiredate,
            
            /// <summary>
            /// Enum Performance for "Performance"
            /// </summary>
            [EnumMember(Value = "Performance")]
            Performance
        }
        /// <summary>
        /// Ranking tiebreaker
        /// </summary>
        /// <value>Ranking tiebreaker</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RankingTiebreakerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Hiredate for "HireDate"
            /// </summary>
            [EnumMember(Value = "HireDate")]
            Hiredate,
            
            /// <summary>
            /// Enum Performance for "Performance"
            /// </summary>
            [EnumMember(Value = "Performance")]
            Performance,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom,
            
            /// <summary>
            /// Enum Randomlyassign for "RandomlyAssign"
            /// </summary>
            [EnumMember(Value = "RandomlyAssign")]
            Randomlyassign
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
        /// The type of agent ranking selected for this bid
        /// </summary>
        /// <value>The type of agent ranking selected for this bid</value>
        [DataMember(Name="agentRankingType", EmitDefaultValue=false)]
        public AgentRankingTypeEnum? AgentRankingType { get; set; }
        /// <summary>
        /// Ranking tiebreaker
        /// </summary>
        /// <value>Ranking tiebreaker</value>
        [DataMember(Name="rankingTiebreakerType", EmitDefaultValue=false)]
        public RankingTiebreakerTypeEnum? RankingTiebreakerType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBid" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleBid() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBid" /> class.
        /// </summary>
        /// <param name="Id">The ID of the schedule bid (required).</param>
        /// <param name="Name">The name of the schedule bid (required).</param>
        /// <param name="BidWindowStartDate">The bid start date when agents can start participating in schedule bidding relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="BidWindowEndDate">The bid end date relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="EffectiveDate">The date when schedule sets would be effective for schedule generation relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="Status">The state of the bid (required).</param>
        /// <param name="BidType">The type of the bid (required).</param>
        /// <param name="Forecast">The selected forecast used for schedule set generation for this bid.</param>
        /// <param name="WeeksToSchedule">The number of weeks to generate schedule sets through this bid (required).</param>
        /// <param name="EndOverridesAndRotations">If true, all existing overrides, work plan rotations will be ended one day before effective date of this bid (required).</param>
        /// <param name="AgentRankingType">The type of agent ranking selected for this bid (required).</param>
        /// <param name="RankingTiebreakerType">Ranking tiebreaker (required).</param>
        /// <param name="PublishedDate">The date the schedule bid is published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EndDate">The end date until which schedule sets can be used for schedule generation. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="Metadata">The metadata of this bid (required).</param>
        public ScheduleBid(string Id = null, string Name = null, String BidWindowStartDate = null, String BidWindowEndDate = null, String EffectiveDate = null, StatusEnum? Status = null, BidTypeEnum? BidType = null, BuShortTermForecastWeekReference Forecast = null, int? WeeksToSchedule = null, bool? EndOverridesAndRotations = null, AgentRankingTypeEnum? AgentRankingType = null, RankingTiebreakerTypeEnum? RankingTiebreakerType = null, DateTime? PublishedDate = null, String EndDate = null, WorkPlanBidMetadata Metadata = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.BidWindowStartDate = BidWindowStartDate;
            this.BidWindowEndDate = BidWindowEndDate;
            this.EffectiveDate = EffectiveDate;
            this.Status = Status;
            this.BidType = BidType;
            this.Forecast = Forecast;
            this.WeeksToSchedule = WeeksToSchedule;
            this.EndOverridesAndRotations = EndOverridesAndRotations;
            this.AgentRankingType = AgentRankingType;
            this.RankingTiebreakerType = RankingTiebreakerType;
            this.PublishedDate = PublishedDate;
            this.EndDate = EndDate;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The ID of the schedule bid
        /// </summary>
        /// <value>The ID of the schedule bid</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name of the schedule bid
        /// </summary>
        /// <value>The name of the schedule bid</value>
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
        /// The selected forecast used for schedule set generation for this bid
        /// </summary>
        /// <value>The selected forecast used for schedule set generation for this bid</value>
        [DataMember(Name="forecast", EmitDefaultValue=false)]
        public BuShortTermForecastWeekReference Forecast { get; set; }



        /// <summary>
        /// The number of weeks to generate schedule sets through this bid
        /// </summary>
        /// <value>The number of weeks to generate schedule sets through this bid</value>
        [DataMember(Name="weeksToSchedule", EmitDefaultValue=false)]
        public int? WeeksToSchedule { get; set; }



        /// <summary>
        /// If true, all existing overrides, work plan rotations will be ended one day before effective date of this bid
        /// </summary>
        /// <value>If true, all existing overrides, work plan rotations will be ended one day before effective date of this bid</value>
        [DataMember(Name="endOverridesAndRotations", EmitDefaultValue=false)]
        public bool? EndOverridesAndRotations { get; set; }







        /// <summary>
        /// The date the schedule bid is published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the schedule bid is published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="publishedDate", EmitDefaultValue=false)]
        public DateTime? PublishedDate { get; set; }



        /// <summary>
        /// The end date until which schedule sets can be used for schedule generation. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The end date until which schedule sets can be used for schedule generation. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public String EndDate { get; set; }



        /// <summary>
        /// The metadata of this bid
        /// </summary>
        /// <value>The metadata of this bid</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WorkPlanBidMetadata Metadata { get; set; }



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
            sb.Append("class ScheduleBid {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BidWindowStartDate: ").Append(BidWindowStartDate).Append("\n");
            sb.Append("  BidWindowEndDate: ").Append(BidWindowEndDate).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BidType: ").Append(BidType).Append("\n");
            sb.Append("  Forecast: ").Append(Forecast).Append("\n");
            sb.Append("  WeeksToSchedule: ").Append(WeeksToSchedule).Append("\n");
            sb.Append("  EndOverridesAndRotations: ").Append(EndOverridesAndRotations).Append("\n");
            sb.Append("  AgentRankingType: ").Append(AgentRankingType).Append("\n");
            sb.Append("  RankingTiebreakerType: ").Append(RankingTiebreakerType).Append("\n");
            sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(obj as ScheduleBid);
        }

        /// <summary>
        /// Returns true if ScheduleBid instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleBid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleBid other)
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
                    this.Forecast == other.Forecast ||
                    this.Forecast != null &&
                    this.Forecast.Equals(other.Forecast)
                ) &&
                (
                    this.WeeksToSchedule == other.WeeksToSchedule ||
                    this.WeeksToSchedule != null &&
                    this.WeeksToSchedule.Equals(other.WeeksToSchedule)
                ) &&
                (
                    this.EndOverridesAndRotations == other.EndOverridesAndRotations ||
                    this.EndOverridesAndRotations != null &&
                    this.EndOverridesAndRotations.Equals(other.EndOverridesAndRotations)
                ) &&
                (
                    this.AgentRankingType == other.AgentRankingType ||
                    this.AgentRankingType != null &&
                    this.AgentRankingType.Equals(other.AgentRankingType)
                ) &&
                (
                    this.RankingTiebreakerType == other.RankingTiebreakerType ||
                    this.RankingTiebreakerType != null &&
                    this.RankingTiebreakerType.Equals(other.RankingTiebreakerType)
                ) &&
                (
                    this.PublishedDate == other.PublishedDate ||
                    this.PublishedDate != null &&
                    this.PublishedDate.Equals(other.PublishedDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
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

                if (this.Forecast != null)
                    hash = hash * 59 + this.Forecast.GetHashCode();

                if (this.WeeksToSchedule != null)
                    hash = hash * 59 + this.WeeksToSchedule.GetHashCode();

                if (this.EndOverridesAndRotations != null)
                    hash = hash * 59 + this.EndOverridesAndRotations.GetHashCode();

                if (this.AgentRankingType != null)
                    hash = hash * 59 + this.AgentRankingType.GetHashCode();

                if (this.RankingTiebreakerType != null)
                    hash = hash * 59 + this.RankingTiebreakerType.GetHashCode();

                if (this.PublishedDate != null)
                    hash = hash * 59 + this.PublishedDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
