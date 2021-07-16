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
    /// HistoricalAdherenceExceptionInfo
    /// </summary>
    [DataContract]
    public partial class HistoricalAdherenceExceptionInfo :  IEquatable<HistoricalAdherenceExceptionInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Activity for which the user is scheduled
        /// </summary>
        /// <value>Activity for which the user is scheduled</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ScheduledActivityCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Onqueuework for "OnQueueWork"
            /// </summary>
            [EnumMember(Value = "OnQueueWork")]
            Onqueuework,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Offqueuework for "OffQueueWork"
            /// </summary>
            [EnumMember(Value = "OffQueueWork")]
            Offqueuework,
            
            /// <summary>
            /// Enum Timeoff for "TimeOff"
            /// </summary>
            [EnumMember(Value = "TimeOff")]
            Timeoff,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Unavailable for "Unavailable"
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable,
            
            /// <summary>
            /// Enum Unscheduled for "Unscheduled"
            /// </summary>
            [EnumMember(Value = "Unscheduled")]
            Unscheduled
        }
        
        
        
        
        /// <summary>
        /// Activity for which the user is actually engaged
        /// </summary>
        /// <value>Activity for which the user is actually engaged</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActualActivityCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Onqueuework for "OnQueueWork"
            /// </summary>
            [EnumMember(Value = "OnQueueWork")]
            Onqueuework,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Offqueuework for "OffQueueWork"
            /// </summary>
            [EnumMember(Value = "OffQueueWork")]
            Offqueuework,
            
            /// <summary>
            /// Enum Timeoff for "TimeOff"
            /// </summary>
            [EnumMember(Value = "TimeOff")]
            Timeoff,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Unavailable for "Unavailable"
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable,
            
            /// <summary>
            /// Enum Unscheduled for "Unscheduled"
            /// </summary>
            [EnumMember(Value = "Unscheduled")]
            Unscheduled
        }
        
        
        
        
        /// <summary>
        /// Actual underlying system presence value
        /// </summary>
        /// <value>Actual underlying system presence value</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SystemPresenceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Available for "Available"
            /// </summary>
            [EnumMember(Value = "Available")]
            Available,
            
            /// <summary>
            /// Enum Away for "Away"
            /// </summary>
            [EnumMember(Value = "Away")]
            Away,
            
            /// <summary>
            /// Enum Busy for "Busy"
            /// </summary>
            [EnumMember(Value = "Busy")]
            Busy,
            
            /// <summary>
            /// Enum Offline for "Offline"
            /// </summary>
            [EnumMember(Value = "Offline")]
            Offline,
            
            /// <summary>
            /// Enum Idle for "Idle"
            /// </summary>
            [EnumMember(Value = "Idle")]
            Idle,
            
            /// <summary>
            /// Enum Onqueue for "OnQueue"
            /// </summary>
            [EnumMember(Value = "OnQueue")]
            Onqueue,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The impact of the current adherence state for this user
        /// </summary>
        /// <value>The impact of the current adherence state for this user</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ImpactEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Positive for "Positive"
            /// </summary>
            [EnumMember(Value = "Positive")]
            Positive,
            
            /// <summary>
            /// Enum Negative for "Negative"
            /// </summary>
            [EnumMember(Value = "Negative")]
            Negative,
            
            /// <summary>
            /// Enum Neutral for "Neutral"
            /// </summary>
            [EnumMember(Value = "Neutral")]
            Neutral,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Activity for which the user is scheduled
        /// </summary>
        /// <value>Activity for which the user is scheduled</value>
        [DataMember(Name="scheduledActivityCategory", EmitDefaultValue=false)]
        public ScheduledActivityCategoryEnum? ScheduledActivityCategory { get; set; }
        
        
        
        /// <summary>
        /// Activity for which the user is actually engaged
        /// </summary>
        /// <value>Activity for which the user is actually engaged</value>
        [DataMember(Name="actualActivityCategory", EmitDefaultValue=false)]
        public ActualActivityCategoryEnum? ActualActivityCategory { get; set; }
        
        
        
        /// <summary>
        /// Actual underlying system presence value
        /// </summary>
        /// <value>Actual underlying system presence value</value>
        [DataMember(Name="systemPresence", EmitDefaultValue=false)]
        public SystemPresenceEnum? SystemPresence { get; set; }
        
        
        
        
        
        /// <summary>
        /// The impact of the current adherence state for this user
        /// </summary>
        /// <value>The impact of the current adherence state for this user</value>
        [DataMember(Name="impact", EmitDefaultValue=false)]
        public ImpactEnum? Impact { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalAdherenceExceptionInfo" /> class.
        /// </summary>
        /// <param name="StartOffsetSeconds">Exception start offset in seconds relative to query start time.</param>
        /// <param name="EndOffsetSeconds">Exception end offset in seconds relative to query start time.</param>
        /// <param name="ScheduledActivityCodeId">The ID of the scheduled activity for this user.</param>
        /// <param name="ScheduledActivityCategory">Activity for which the user is scheduled.</param>
        /// <param name="ActualActivityCategory">Activity for which the user is actually engaged.</param>
        /// <param name="SystemPresence">Actual underlying system presence value.</param>
        /// <param name="RoutingStatus">Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue.</param>
        /// <param name="Impact">The impact of the current adherence state for this user.</param>
        /// <param name="SecondaryPresenceLookupId">The lookup ID used to retrieve secondary status from map of lookup ID to corresponding secondary presence ID.</param>
        public HistoricalAdherenceExceptionInfo(int? StartOffsetSeconds = null, int? EndOffsetSeconds = null, string ScheduledActivityCodeId = null, ScheduledActivityCategoryEnum? ScheduledActivityCategory = null, ActualActivityCategoryEnum? ActualActivityCategory = null, SystemPresenceEnum? SystemPresence = null, RoutingStatus RoutingStatus = null, ImpactEnum? Impact = null, string SecondaryPresenceLookupId = null)
        {
            this.StartOffsetSeconds = StartOffsetSeconds;
            this.EndOffsetSeconds = EndOffsetSeconds;
            this.ScheduledActivityCodeId = ScheduledActivityCodeId;
            this.ScheduledActivityCategory = ScheduledActivityCategory;
            this.ActualActivityCategory = ActualActivityCategory;
            this.SystemPresence = SystemPresence;
            this.RoutingStatus = RoutingStatus;
            this.Impact = Impact;
            this.SecondaryPresenceLookupId = SecondaryPresenceLookupId;
            
        }
        
        
        
        /// <summary>
        /// Exception start offset in seconds relative to query start time
        /// </summary>
        /// <value>Exception start offset in seconds relative to query start time</value>
        [DataMember(Name="startOffsetSeconds", EmitDefaultValue=false)]
        public int? StartOffsetSeconds { get; set; }
        
        
        
        /// <summary>
        /// Exception end offset in seconds relative to query start time
        /// </summary>
        /// <value>Exception end offset in seconds relative to query start time</value>
        [DataMember(Name="endOffsetSeconds", EmitDefaultValue=false)]
        public int? EndOffsetSeconds { get; set; }
        
        
        
        /// <summary>
        /// The ID of the scheduled activity for this user
        /// </summary>
        /// <value>The ID of the scheduled activity for this user</value>
        [DataMember(Name="scheduledActivityCodeId", EmitDefaultValue=false)]
        public string ScheduledActivityCodeId { get; set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue
        /// </summary>
        /// <value>Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue</value>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatus RoutingStatus { get; set; }
        
        
        
        
        
        /// <summary>
        /// The lookup ID used to retrieve secondary status from map of lookup ID to corresponding secondary presence ID
        /// </summary>
        /// <value>The lookup ID used to retrieve secondary status from map of lookup ID to corresponding secondary presence ID</value>
        [DataMember(Name="secondaryPresenceLookupId", EmitDefaultValue=false)]
        public string SecondaryPresenceLookupId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricalAdherenceExceptionInfo {\n");
            
            sb.Append("  StartOffsetSeconds: ").Append(StartOffsetSeconds).Append("\n");
            sb.Append("  EndOffsetSeconds: ").Append(EndOffsetSeconds).Append("\n");
            sb.Append("  ScheduledActivityCodeId: ").Append(ScheduledActivityCodeId).Append("\n");
            sb.Append("  ScheduledActivityCategory: ").Append(ScheduledActivityCategory).Append("\n");
            sb.Append("  ActualActivityCategory: ").Append(ActualActivityCategory).Append("\n");
            sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            sb.Append("  Impact: ").Append(Impact).Append("\n");
            sb.Append("  SecondaryPresenceLookupId: ").Append(SecondaryPresenceLookupId).Append("\n");
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
            return this.Equals(obj as HistoricalAdherenceExceptionInfo);
        }

        /// <summary>
        /// Returns true if HistoricalAdherenceExceptionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricalAdherenceExceptionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalAdherenceExceptionInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartOffsetSeconds == other.StartOffsetSeconds ||
                    this.StartOffsetSeconds != null &&
                    this.StartOffsetSeconds.Equals(other.StartOffsetSeconds)
                ) &&
                (
                    this.EndOffsetSeconds == other.EndOffsetSeconds ||
                    this.EndOffsetSeconds != null &&
                    this.EndOffsetSeconds.Equals(other.EndOffsetSeconds)
                ) &&
                (
                    this.ScheduledActivityCodeId == other.ScheduledActivityCodeId ||
                    this.ScheduledActivityCodeId != null &&
                    this.ScheduledActivityCodeId.Equals(other.ScheduledActivityCodeId)
                ) &&
                (
                    this.ScheduledActivityCategory == other.ScheduledActivityCategory ||
                    this.ScheduledActivityCategory != null &&
                    this.ScheduledActivityCategory.Equals(other.ScheduledActivityCategory)
                ) &&
                (
                    this.ActualActivityCategory == other.ActualActivityCategory ||
                    this.ActualActivityCategory != null &&
                    this.ActualActivityCategory.Equals(other.ActualActivityCategory)
                ) &&
                (
                    this.SystemPresence == other.SystemPresence ||
                    this.SystemPresence != null &&
                    this.SystemPresence.Equals(other.SystemPresence)
                ) &&
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
                ) &&
                (
                    this.Impact == other.Impact ||
                    this.Impact != null &&
                    this.Impact.Equals(other.Impact)
                ) &&
                (
                    this.SecondaryPresenceLookupId == other.SecondaryPresenceLookupId ||
                    this.SecondaryPresenceLookupId != null &&
                    this.SecondaryPresenceLookupId.Equals(other.SecondaryPresenceLookupId)
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
                
                if (this.StartOffsetSeconds != null)
                    hash = hash * 59 + this.StartOffsetSeconds.GetHashCode();
                
                if (this.EndOffsetSeconds != null)
                    hash = hash * 59 + this.EndOffsetSeconds.GetHashCode();
                
                if (this.ScheduledActivityCodeId != null)
                    hash = hash * 59 + this.ScheduledActivityCodeId.GetHashCode();
                
                if (this.ScheduledActivityCategory != null)
                    hash = hash * 59 + this.ScheduledActivityCategory.GetHashCode();
                
                if (this.ActualActivityCategory != null)
                    hash = hash * 59 + this.ActualActivityCategory.GetHashCode();
                
                if (this.SystemPresence != null)
                    hash = hash * 59 + this.SystemPresence.GetHashCode();
                
                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();
                
                if (this.Impact != null)
                    hash = hash * 59 + this.Impact.GetHashCode();
                
                if (this.SecondaryPresenceLookupId != null)
                    hash = hash * 59 + this.SecondaryPresenceLookupId.GetHashCode();
                
                return hash;
            }
        }
    }

}
