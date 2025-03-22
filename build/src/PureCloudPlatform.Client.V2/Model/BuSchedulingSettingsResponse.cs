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
    /// BuSchedulingSettingsResponse
    /// </summary>
    [DataContract]
    public partial class BuSchedulingSettingsResponse :  IEquatable<BuSchedulingSettingsResponse>
    {
        /// <summary>
        /// Gets or Sets SyncTimeOffProperties
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SyncTimeOffPropertiesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Payableminutes for "PayableMinutes"
            /// </summary>
            [EnumMember(Value = "PayableMinutes")]
            Payableminutes
        }
        /// <summary>
        /// The activity smoothing type for schedule generation in this business unit
        /// </summary>
        /// <value>The activity smoothing type for schedule generation in this business unit</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActivitySmoothingTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Reduceconcurrentactivitiesacrossbu for "ReduceConcurrentActivitiesAcrossBu"
            /// </summary>
            [EnumMember(Value = "ReduceConcurrentActivitiesAcrossBu")]
            Reduceconcurrentactivitiesacrossbu,
            
            /// <summary>
            /// Enum Reduceconcurrentactivitiesacrossmu for "ReduceConcurrentActivitiesAcrossMu"
            /// </summary>
            [EnumMember(Value = "ReduceConcurrentActivitiesAcrossMu")]
            Reduceconcurrentactivitiesacrossmu,
            
            /// <summary>
            /// Enum Consistentservicelevel for "ConsistentServiceLevel"
            /// </summary>
            [EnumMember(Value = "ConsistentServiceLevel")]
            Consistentservicelevel
        }
        /// <summary>
        /// The activity smoothing type for schedule generation in this business unit
        /// </summary>
        /// <value>The activity smoothing type for schedule generation in this business unit</value>
        [DataMember(Name="activitySmoothingType", EmitDefaultValue=false)]
        public ActivitySmoothingTypeEnum? ActivitySmoothingType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuSchedulingSettingsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuSchedulingSettingsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuSchedulingSettingsResponse" /> class.
        /// </summary>
        /// <param name="MessageSeverities">Schedule generation message severity configuration.</param>
        /// <param name="SyncTimeOffProperties">Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published..</param>
        /// <param name="ServiceGoalImpact">Configures the max percent increase and decrease of service goals for this business unit.</param>
        /// <param name="AllowWorkPlanPerMinuteGranularity">Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false..</param>
        /// <param name="ActivitySmoothingType">The activity smoothing type for schedule generation in this business unit (required).</param>
        /// <param name="InduceScheduleVariability">Indicates whether to provide variability in schedule generation (required).</param>
        public BuSchedulingSettingsResponse(List<SchedulerMessageTypeSeverity> MessageSeverities = null, List<SyncTimeOffPropertiesEnum> SyncTimeOffProperties = null, WfmServiceGoalImpactSettings ServiceGoalImpact = null, bool? AllowWorkPlanPerMinuteGranularity = null, ActivitySmoothingTypeEnum? ActivitySmoothingType = null, bool? InduceScheduleVariability = null)
        {
            this.MessageSeverities = MessageSeverities;
            this.SyncTimeOffProperties = SyncTimeOffProperties;
            this.ServiceGoalImpact = ServiceGoalImpact;
            this.AllowWorkPlanPerMinuteGranularity = AllowWorkPlanPerMinuteGranularity;
            this.ActivitySmoothingType = ActivitySmoothingType;
            this.InduceScheduleVariability = InduceScheduleVariability;
            
        }
        


        /// <summary>
        /// Schedule generation message severity configuration
        /// </summary>
        /// <value>Schedule generation message severity configuration</value>
        [DataMember(Name="messageSeverities", EmitDefaultValue=false)]
        public List<SchedulerMessageTypeSeverity> MessageSeverities { get; set; }



        /// <summary>
        /// Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published.
        /// </summary>
        /// <value>Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published.</value>
        [DataMember(Name="syncTimeOffProperties", EmitDefaultValue=false)]
        public List<SyncTimeOffPropertiesEnum> SyncTimeOffProperties { get; set; }



        /// <summary>
        /// Configures the max percent increase and decrease of service goals for this business unit
        /// </summary>
        /// <value>Configures the max percent increase and decrease of service goals for this business unit</value>
        [DataMember(Name="serviceGoalImpact", EmitDefaultValue=false)]
        public WfmServiceGoalImpactSettings ServiceGoalImpact { get; set; }



        /// <summary>
        /// Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false.
        /// </summary>
        /// <value>Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false.</value>
        [DataMember(Name="allowWorkPlanPerMinuteGranularity", EmitDefaultValue=false)]
        public bool? AllowWorkPlanPerMinuteGranularity { get; set; }





        /// <summary>
        /// Indicates whether to provide variability in schedule generation
        /// </summary>
        /// <value>Indicates whether to provide variability in schedule generation</value>
        [DataMember(Name="induceScheduleVariability", EmitDefaultValue=false)]
        public bool? InduceScheduleVariability { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuSchedulingSettingsResponse {\n");

            sb.Append("  MessageSeverities: ").Append(MessageSeverities).Append("\n");
            sb.Append("  SyncTimeOffProperties: ").Append(SyncTimeOffProperties).Append("\n");
            sb.Append("  ServiceGoalImpact: ").Append(ServiceGoalImpact).Append("\n");
            sb.Append("  AllowWorkPlanPerMinuteGranularity: ").Append(AllowWorkPlanPerMinuteGranularity).Append("\n");
            sb.Append("  ActivitySmoothingType: ").Append(ActivitySmoothingType).Append("\n");
            sb.Append("  InduceScheduleVariability: ").Append(InduceScheduleVariability).Append("\n");
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
            return this.Equals(obj as BuSchedulingSettingsResponse);
        }

        /// <summary>
        /// Returns true if BuSchedulingSettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuSchedulingSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuSchedulingSettingsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MessageSeverities == other.MessageSeverities ||
                    this.MessageSeverities != null &&
                    this.MessageSeverities.SequenceEqual(other.MessageSeverities)
                ) &&
                (
                    this.SyncTimeOffProperties == other.SyncTimeOffProperties ||
                    this.SyncTimeOffProperties != null &&
                    this.SyncTimeOffProperties.SequenceEqual(other.SyncTimeOffProperties)
                ) &&
                (
                    this.ServiceGoalImpact == other.ServiceGoalImpact ||
                    this.ServiceGoalImpact != null &&
                    this.ServiceGoalImpact.Equals(other.ServiceGoalImpact)
                ) &&
                (
                    this.AllowWorkPlanPerMinuteGranularity == other.AllowWorkPlanPerMinuteGranularity ||
                    this.AllowWorkPlanPerMinuteGranularity != null &&
                    this.AllowWorkPlanPerMinuteGranularity.Equals(other.AllowWorkPlanPerMinuteGranularity)
                ) &&
                (
                    this.ActivitySmoothingType == other.ActivitySmoothingType ||
                    this.ActivitySmoothingType != null &&
                    this.ActivitySmoothingType.Equals(other.ActivitySmoothingType)
                ) &&
                (
                    this.InduceScheduleVariability == other.InduceScheduleVariability ||
                    this.InduceScheduleVariability != null &&
                    this.InduceScheduleVariability.Equals(other.InduceScheduleVariability)
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
                if (this.MessageSeverities != null)
                    hash = hash * 59 + this.MessageSeverities.GetHashCode();

                if (this.SyncTimeOffProperties != null)
                    hash = hash * 59 + this.SyncTimeOffProperties.GetHashCode();

                if (this.ServiceGoalImpact != null)
                    hash = hash * 59 + this.ServiceGoalImpact.GetHashCode();

                if (this.AllowWorkPlanPerMinuteGranularity != null)
                    hash = hash * 59 + this.AllowWorkPlanPerMinuteGranularity.GetHashCode();

                if (this.ActivitySmoothingType != null)
                    hash = hash * 59 + this.ActivitySmoothingType.GetHashCode();

                if (this.InduceScheduleVariability != null)
                    hash = hash * 59 + this.InduceScheduleVariability.GetHashCode();

                return hash;
            }
        }
    }

}
