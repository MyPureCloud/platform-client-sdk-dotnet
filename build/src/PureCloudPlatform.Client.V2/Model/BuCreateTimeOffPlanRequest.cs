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
    /// BuCreateTimeOffPlanRequest
    /// </summary>
    [DataContract]
    public partial class BuCreateTimeOffPlanRequest :  IEquatable<BuCreateTimeOffPlanRequest>
    {
        /// <summary>
        /// Auto approval rule for this time-off plan. Default is Never
        /// </summary>
        /// <value>Auto approval rule for this time-off plan. Default is Never</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AutoApprovalRuleEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Never for "Never"
            /// </summary>
            [EnumMember(Value = "Never")]
            Never,
            
            /// <summary>
            /// Enum Always for "Always"
            /// </summary>
            [EnumMember(Value = "Always")]
            Always,
            
            /// <summary>
            /// Enum Checklimits for "CheckLimits"
            /// </summary>
            [EnumMember(Value = "CheckLimits")]
            Checklimits
        }
        /// <summary>
        /// Auto approval rule for this time-off plan. Default is Never
        /// </summary>
        /// <value>Auto approval rule for this time-off plan. Default is Never</value>
        [DataMember(Name="autoApprovalRule", EmitDefaultValue=false)]
        public AutoApprovalRuleEnum? AutoApprovalRule { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuCreateTimeOffPlanRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuCreateTimeOffPlanRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuCreateTimeOffPlanRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of this time-off plan (required).</param>
        /// <param name="ActivityCodeIds">The IDs of activity codes to associate with this time-off plan.</param>
        /// <param name="AutoApprovalRule">Auto approval rule for this time-off plan. Default is Never.</param>
        /// <param name="DaysBeforeStartToExpireFromWaitlist">The number of days before the time-off request start date for when the request will be expired from the waitlist. Default is 0.</param>
        /// <param name="HrisTimeOffType">Time-off type, if this time-off plan is associated with the integration.</param>
        /// <param name="Enabled">Whether this time-off plan should be used by agents. Default is true.</param>
        /// <param name="CountAgainstTimeOffLimits">Whether this time-off plan should count against time-off limits. Default is false.</param>
        /// <param name="BusinessUnitAssociation">Business unit association, if the time-off plan belongs to a business unit. managementUnitAssociation must not be set if this is populated.</param>
        /// <param name="ManagementUnitAssociation">Management unit association, if the time-off plan belongs to a management unit. businessUnitAssociation must not be set if this is populated.</param>
        public BuCreateTimeOffPlanRequest(string Name = null, List<string> ActivityCodeIds = null, AutoApprovalRuleEnum? AutoApprovalRule = null, int? DaysBeforeStartToExpireFromWaitlist = null, HrisTimeOffType HrisTimeOffType = null, bool? Enabled = null, bool? CountAgainstTimeOffLimits = null, CreateTimeOffPlanBusinessUnitAssociation BusinessUnitAssociation = null, CreateTimeOffPlanManagementUnitAssociation ManagementUnitAssociation = null)
        {
            this.Name = Name;
            this.ActivityCodeIds = ActivityCodeIds;
            this.AutoApprovalRule = AutoApprovalRule;
            this.DaysBeforeStartToExpireFromWaitlist = DaysBeforeStartToExpireFromWaitlist;
            this.HrisTimeOffType = HrisTimeOffType;
            this.Enabled = Enabled;
            this.CountAgainstTimeOffLimits = CountAgainstTimeOffLimits;
            this.BusinessUnitAssociation = BusinessUnitAssociation;
            this.ManagementUnitAssociation = ManagementUnitAssociation;
            
        }
        


        /// <summary>
        /// The name of this time-off plan
        /// </summary>
        /// <value>The name of this time-off plan</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The IDs of activity codes to associate with this time-off plan
        /// </summary>
        /// <value>The IDs of activity codes to associate with this time-off plan</value>
        [DataMember(Name="activityCodeIds", EmitDefaultValue=false)]
        public List<string> ActivityCodeIds { get; set; }





        /// <summary>
        /// The number of days before the time-off request start date for when the request will be expired from the waitlist. Default is 0
        /// </summary>
        /// <value>The number of days before the time-off request start date for when the request will be expired from the waitlist. Default is 0</value>
        [DataMember(Name="daysBeforeStartToExpireFromWaitlist", EmitDefaultValue=false)]
        public int? DaysBeforeStartToExpireFromWaitlist { get; set; }



        /// <summary>
        /// Time-off type, if this time-off plan is associated with the integration
        /// </summary>
        /// <value>Time-off type, if this time-off plan is associated with the integration</value>
        [DataMember(Name="hrisTimeOffType", EmitDefaultValue=false)]
        public HrisTimeOffType HrisTimeOffType { get; set; }



        /// <summary>
        /// Whether this time-off plan should be used by agents. Default is true
        /// </summary>
        /// <value>Whether this time-off plan should be used by agents. Default is true</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Whether this time-off plan should count against time-off limits. Default is false
        /// </summary>
        /// <value>Whether this time-off plan should count against time-off limits. Default is false</value>
        [DataMember(Name="countAgainstTimeOffLimits", EmitDefaultValue=false)]
        public bool? CountAgainstTimeOffLimits { get; set; }



        /// <summary>
        /// Business unit association, if the time-off plan belongs to a business unit. managementUnitAssociation must not be set if this is populated
        /// </summary>
        /// <value>Business unit association, if the time-off plan belongs to a business unit. managementUnitAssociation must not be set if this is populated</value>
        [DataMember(Name="businessUnitAssociation", EmitDefaultValue=false)]
        public CreateTimeOffPlanBusinessUnitAssociation BusinessUnitAssociation { get; set; }



        /// <summary>
        /// Management unit association, if the time-off plan belongs to a management unit. businessUnitAssociation must not be set if this is populated
        /// </summary>
        /// <value>Management unit association, if the time-off plan belongs to a management unit. businessUnitAssociation must not be set if this is populated</value>
        [DataMember(Name="managementUnitAssociation", EmitDefaultValue=false)]
        public CreateTimeOffPlanManagementUnitAssociation ManagementUnitAssociation { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuCreateTimeOffPlanRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ActivityCodeIds: ").Append(ActivityCodeIds).Append("\n");
            sb.Append("  AutoApprovalRule: ").Append(AutoApprovalRule).Append("\n");
            sb.Append("  DaysBeforeStartToExpireFromWaitlist: ").Append(DaysBeforeStartToExpireFromWaitlist).Append("\n");
            sb.Append("  HrisTimeOffType: ").Append(HrisTimeOffType).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  CountAgainstTimeOffLimits: ").Append(CountAgainstTimeOffLimits).Append("\n");
            sb.Append("  BusinessUnitAssociation: ").Append(BusinessUnitAssociation).Append("\n");
            sb.Append("  ManagementUnitAssociation: ").Append(ManagementUnitAssociation).Append("\n");
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
            return this.Equals(obj as BuCreateTimeOffPlanRequest);
        }

        /// <summary>
        /// Returns true if BuCreateTimeOffPlanRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BuCreateTimeOffPlanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuCreateTimeOffPlanRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ActivityCodeIds == other.ActivityCodeIds ||
                    this.ActivityCodeIds != null &&
                    this.ActivityCodeIds.SequenceEqual(other.ActivityCodeIds)
                ) &&
                (
                    this.AutoApprovalRule == other.AutoApprovalRule ||
                    this.AutoApprovalRule != null &&
                    this.AutoApprovalRule.Equals(other.AutoApprovalRule)
                ) &&
                (
                    this.DaysBeforeStartToExpireFromWaitlist == other.DaysBeforeStartToExpireFromWaitlist ||
                    this.DaysBeforeStartToExpireFromWaitlist != null &&
                    this.DaysBeforeStartToExpireFromWaitlist.Equals(other.DaysBeforeStartToExpireFromWaitlist)
                ) &&
                (
                    this.HrisTimeOffType == other.HrisTimeOffType ||
                    this.HrisTimeOffType != null &&
                    this.HrisTimeOffType.Equals(other.HrisTimeOffType)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.CountAgainstTimeOffLimits == other.CountAgainstTimeOffLimits ||
                    this.CountAgainstTimeOffLimits != null &&
                    this.CountAgainstTimeOffLimits.Equals(other.CountAgainstTimeOffLimits)
                ) &&
                (
                    this.BusinessUnitAssociation == other.BusinessUnitAssociation ||
                    this.BusinessUnitAssociation != null &&
                    this.BusinessUnitAssociation.Equals(other.BusinessUnitAssociation)
                ) &&
                (
                    this.ManagementUnitAssociation == other.ManagementUnitAssociation ||
                    this.ManagementUnitAssociation != null &&
                    this.ManagementUnitAssociation.Equals(other.ManagementUnitAssociation)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ActivityCodeIds != null)
                    hash = hash * 59 + this.ActivityCodeIds.GetHashCode();

                if (this.AutoApprovalRule != null)
                    hash = hash * 59 + this.AutoApprovalRule.GetHashCode();

                if (this.DaysBeforeStartToExpireFromWaitlist != null)
                    hash = hash * 59 + this.DaysBeforeStartToExpireFromWaitlist.GetHashCode();

                if (this.HrisTimeOffType != null)
                    hash = hash * 59 + this.HrisTimeOffType.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.CountAgainstTimeOffLimits != null)
                    hash = hash * 59 + this.CountAgainstTimeOffLimits.GetHashCode();

                if (this.BusinessUnitAssociation != null)
                    hash = hash * 59 + this.BusinessUnitAssociation.GetHashCode();

                if (this.ManagementUnitAssociation != null)
                    hash = hash * 59 + this.ManagementUnitAssociation.GetHashCode();

                return hash;
            }
        }
    }

}
