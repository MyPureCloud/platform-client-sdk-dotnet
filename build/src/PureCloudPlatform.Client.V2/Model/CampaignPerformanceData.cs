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
    /// CampaignPerformanceData
    /// </summary>
    [DataContract]
    public partial class CampaignPerformanceData :  IEquatable<CampaignPerformanceData>
    {
        /// <summary>
        /// The status of the campaign
        /// </summary>
        /// <value>The status of the campaign</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CampaignStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum On for "on"
            /// </summary>
            [EnumMember(Value = "on")]
            On,
            
            /// <summary>
            /// Enum Stopping for "stopping"
            /// </summary>
            [EnumMember(Value = "stopping")]
            Stopping,
            
            /// <summary>
            /// Enum Off for "off"
            /// </summary>
            [EnumMember(Value = "off")]
            Off,
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete,
            
            /// <summary>
            /// Enum Invalid for "invalid"
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid,
            
            /// <summary>
            /// Enum ForcedOff for "forced_off"
            /// </summary>
            [EnumMember(Value = "forced_off")]
            ForcedOff,
            
            /// <summary>
            /// Enum ForcedStopping for "forced_stopping"
            /// </summary>
            [EnumMember(Value = "forced_stopping")]
            ForcedStopping
        }
        /// <summary>
        /// The strategy this Campaign will use for dialing
        /// </summary>
        /// <value>The strategy this Campaign will use for dialing</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DialingModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agentless for "agentless"
            /// </summary>
            [EnumMember(Value = "agentless")]
            Agentless,
            
            /// <summary>
            /// Enum Preview for "preview"
            /// </summary>
            [EnumMember(Value = "preview")]
            Preview,
            
            /// <summary>
            /// Enum Power for "power"
            /// </summary>
            [EnumMember(Value = "power")]
            Power,
            
            /// <summary>
            /// Enum Predictive for "predictive"
            /// </summary>
            [EnumMember(Value = "predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Progressive for "progressive"
            /// </summary>
            [EnumMember(Value = "progressive")]
            Progressive,
            
            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External
        }
        /// <summary>
        /// The status of the campaign
        /// </summary>
        /// <value>The status of the campaign</value>
        [DataMember(Name="campaignStatus", EmitDefaultValue=false)]
        public CampaignStatusEnum? CampaignStatus { get; set; }
        /// <summary>
        /// The strategy this Campaign will use for dialing
        /// </summary>
        /// <value>The strategy this Campaign will use for dialing</value>
        [DataMember(Name="dialingMode", EmitDefaultValue=false)]
        public DialingModeEnum? DialingMode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPerformanceData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignPerformanceData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPerformanceData" /> class.
        /// </summary>
        /// <param name="Campaign">Identifier of the campaign (required).</param>
        /// <param name="Division">The division the campaign belongs to.</param>
        /// <param name="ContactRate">Information regarding the campaign&#39;s connect rate.</param>
        /// <param name="IdleAgents">Number of available agents not currently being utilized.</param>
        /// <param name="EffectiveIdleAgents">Number of effective available agents not currently being utilized.</param>
        /// <param name="AdjustedCallsPerAgent">Calls per agent adjusted by pace.</param>
        /// <param name="OutstandingCalls">Number of campaign calls currently ongoing.</param>
        /// <param name="ScheduledCalls">Number of campaign calls currently scheduled.</param>
        /// <param name="RightPartyContactsCount">Information on the campaign&#39;s number of Right Party Contacts.</param>
        /// <param name="CampaignStatus">The status of the campaign.</param>
        /// <param name="DialingMode">The strategy this Campaign will use for dialing.</param>
        /// <param name="Progress">Information on the campaign&#39;s progress.</param>
        /// <param name="LinesUtilization">Information on the campaign&#39;s lines utilization.</param>
        /// <param name="BusinessCategoryMetrics">Information on the campaign&#39;s business category metrics.</param>
        public CampaignPerformanceData(DomainEntityRef Campaign = null, AddressableEntityRef Division = null, CampaignPerformanceDataContactRate ContactRate = null, int? IdleAgents = null, double? EffectiveIdleAgents = null, double? AdjustedCallsPerAgent = null, int? OutstandingCalls = null, int? ScheduledCalls = null, int? RightPartyContactsCount = null, CampaignStatusEnum? CampaignStatus = null, DialingModeEnum? DialingMode = null, CampaignPerformanceDataProgress Progress = null, CampaignLinesUtilization LinesUtilization = null, CampaignBusinessCategoryMetrics BusinessCategoryMetrics = null)
        {
            this.Campaign = Campaign;
            this.Division = Division;
            this.ContactRate = ContactRate;
            this.IdleAgents = IdleAgents;
            this.EffectiveIdleAgents = EffectiveIdleAgents;
            this.AdjustedCallsPerAgent = AdjustedCallsPerAgent;
            this.OutstandingCalls = OutstandingCalls;
            this.ScheduledCalls = ScheduledCalls;
            this.RightPartyContactsCount = RightPartyContactsCount;
            this.CampaignStatus = CampaignStatus;
            this.DialingMode = DialingMode;
            this.Progress = Progress;
            this.LinesUtilization = LinesUtilization;
            this.BusinessCategoryMetrics = BusinessCategoryMetrics;
            
        }
        


        /// <summary>
        /// Identifier of the campaign
        /// </summary>
        /// <value>Identifier of the campaign</value>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public DomainEntityRef Campaign { get; set; }



        /// <summary>
        /// The division the campaign belongs to
        /// </summary>
        /// <value>The division the campaign belongs to</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public AddressableEntityRef Division { get; set; }



        /// <summary>
        /// Information regarding the campaign&#39;s connect rate
        /// </summary>
        /// <value>Information regarding the campaign&#39;s connect rate</value>
        [DataMember(Name="contactRate", EmitDefaultValue=false)]
        public CampaignPerformanceDataContactRate ContactRate { get; set; }



        /// <summary>
        /// Number of available agents not currently being utilized
        /// </summary>
        /// <value>Number of available agents not currently being utilized</value>
        [DataMember(Name="idleAgents", EmitDefaultValue=false)]
        public int? IdleAgents { get; set; }



        /// <summary>
        /// Number of effective available agents not currently being utilized
        /// </summary>
        /// <value>Number of effective available agents not currently being utilized</value>
        [DataMember(Name="effectiveIdleAgents", EmitDefaultValue=false)]
        public double? EffectiveIdleAgents { get; set; }



        /// <summary>
        /// Calls per agent adjusted by pace
        /// </summary>
        /// <value>Calls per agent adjusted by pace</value>
        [DataMember(Name="adjustedCallsPerAgent", EmitDefaultValue=false)]
        public double? AdjustedCallsPerAgent { get; set; }



        /// <summary>
        /// Number of campaign calls currently ongoing
        /// </summary>
        /// <value>Number of campaign calls currently ongoing</value>
        [DataMember(Name="outstandingCalls", EmitDefaultValue=false)]
        public int? OutstandingCalls { get; set; }



        /// <summary>
        /// Number of campaign calls currently scheduled
        /// </summary>
        /// <value>Number of campaign calls currently scheduled</value>
        [DataMember(Name="scheduledCalls", EmitDefaultValue=false)]
        public int? ScheduledCalls { get; set; }



        /// <summary>
        /// Information on the campaign&#39;s number of Right Party Contacts
        /// </summary>
        /// <value>Information on the campaign&#39;s number of Right Party Contacts</value>
        [DataMember(Name="rightPartyContactsCount", EmitDefaultValue=false)]
        public int? RightPartyContactsCount { get; set; }







        /// <summary>
        /// Information on the campaign&#39;s progress
        /// </summary>
        /// <value>Information on the campaign&#39;s progress</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public CampaignPerformanceDataProgress Progress { get; set; }



        /// <summary>
        /// Information on the campaign&#39;s lines utilization
        /// </summary>
        /// <value>Information on the campaign&#39;s lines utilization</value>
        [DataMember(Name="linesUtilization", EmitDefaultValue=false)]
        public CampaignLinesUtilization LinesUtilization { get; set; }



        /// <summary>
        /// Information on the campaign&#39;s business category metrics
        /// </summary>
        /// <value>Information on the campaign&#39;s business category metrics</value>
        [DataMember(Name="businessCategoryMetrics", EmitDefaultValue=false)]
        public CampaignBusinessCategoryMetrics BusinessCategoryMetrics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignPerformanceData {\n");

            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  ContactRate: ").Append(ContactRate).Append("\n");
            sb.Append("  IdleAgents: ").Append(IdleAgents).Append("\n");
            sb.Append("  EffectiveIdleAgents: ").Append(EffectiveIdleAgents).Append("\n");
            sb.Append("  AdjustedCallsPerAgent: ").Append(AdjustedCallsPerAgent).Append("\n");
            sb.Append("  OutstandingCalls: ").Append(OutstandingCalls).Append("\n");
            sb.Append("  ScheduledCalls: ").Append(ScheduledCalls).Append("\n");
            sb.Append("  RightPartyContactsCount: ").Append(RightPartyContactsCount).Append("\n");
            sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
            sb.Append("  DialingMode: ").Append(DialingMode).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  LinesUtilization: ").Append(LinesUtilization).Append("\n");
            sb.Append("  BusinessCategoryMetrics: ").Append(BusinessCategoryMetrics).Append("\n");
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
            return this.Equals(obj as CampaignPerformanceData);
        }

        /// <summary>
        /// Returns true if CampaignPerformanceData instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignPerformanceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignPerformanceData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Campaign == other.Campaign ||
                    this.Campaign != null &&
                    this.Campaign.Equals(other.Campaign)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.ContactRate == other.ContactRate ||
                    this.ContactRate != null &&
                    this.ContactRate.Equals(other.ContactRate)
                ) &&
                (
                    this.IdleAgents == other.IdleAgents ||
                    this.IdleAgents != null &&
                    this.IdleAgents.Equals(other.IdleAgents)
                ) &&
                (
                    this.EffectiveIdleAgents == other.EffectiveIdleAgents ||
                    this.EffectiveIdleAgents != null &&
                    this.EffectiveIdleAgents.Equals(other.EffectiveIdleAgents)
                ) &&
                (
                    this.AdjustedCallsPerAgent == other.AdjustedCallsPerAgent ||
                    this.AdjustedCallsPerAgent != null &&
                    this.AdjustedCallsPerAgent.Equals(other.AdjustedCallsPerAgent)
                ) &&
                (
                    this.OutstandingCalls == other.OutstandingCalls ||
                    this.OutstandingCalls != null &&
                    this.OutstandingCalls.Equals(other.OutstandingCalls)
                ) &&
                (
                    this.ScheduledCalls == other.ScheduledCalls ||
                    this.ScheduledCalls != null &&
                    this.ScheduledCalls.Equals(other.ScheduledCalls)
                ) &&
                (
                    this.RightPartyContactsCount == other.RightPartyContactsCount ||
                    this.RightPartyContactsCount != null &&
                    this.RightPartyContactsCount.Equals(other.RightPartyContactsCount)
                ) &&
                (
                    this.CampaignStatus == other.CampaignStatus ||
                    this.CampaignStatus != null &&
                    this.CampaignStatus.Equals(other.CampaignStatus)
                ) &&
                (
                    this.DialingMode == other.DialingMode ||
                    this.DialingMode != null &&
                    this.DialingMode.Equals(other.DialingMode)
                ) &&
                (
                    this.Progress == other.Progress ||
                    this.Progress != null &&
                    this.Progress.Equals(other.Progress)
                ) &&
                (
                    this.LinesUtilization == other.LinesUtilization ||
                    this.LinesUtilization != null &&
                    this.LinesUtilization.Equals(other.LinesUtilization)
                ) &&
                (
                    this.BusinessCategoryMetrics == other.BusinessCategoryMetrics ||
                    this.BusinessCategoryMetrics != null &&
                    this.BusinessCategoryMetrics.Equals(other.BusinessCategoryMetrics)
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
                if (this.Campaign != null)
                    hash = hash * 59 + this.Campaign.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.ContactRate != null)
                    hash = hash * 59 + this.ContactRate.GetHashCode();

                if (this.IdleAgents != null)
                    hash = hash * 59 + this.IdleAgents.GetHashCode();

                if (this.EffectiveIdleAgents != null)
                    hash = hash * 59 + this.EffectiveIdleAgents.GetHashCode();

                if (this.AdjustedCallsPerAgent != null)
                    hash = hash * 59 + this.AdjustedCallsPerAgent.GetHashCode();

                if (this.OutstandingCalls != null)
                    hash = hash * 59 + this.OutstandingCalls.GetHashCode();

                if (this.ScheduledCalls != null)
                    hash = hash * 59 + this.ScheduledCalls.GetHashCode();

                if (this.RightPartyContactsCount != null)
                    hash = hash * 59 + this.RightPartyContactsCount.GetHashCode();

                if (this.CampaignStatus != null)
                    hash = hash * 59 + this.CampaignStatus.GetHashCode();

                if (this.DialingMode != null)
                    hash = hash * 59 + this.DialingMode.GetHashCode();

                if (this.Progress != null)
                    hash = hash * 59 + this.Progress.GetHashCode();

                if (this.LinesUtilization != null)
                    hash = hash * 59 + this.LinesUtilization.GetHashCode();

                if (this.BusinessCategoryMetrics != null)
                    hash = hash * 59 + this.BusinessCategoryMetrics.GetHashCode();

                return hash;
            }
        }
    }

}
