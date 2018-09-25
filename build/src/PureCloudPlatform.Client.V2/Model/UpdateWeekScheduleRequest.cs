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
    /// UpdateWeekScheduleRequest
    /// </summary>
    [DataContract]
    public partial class UpdateWeekScheduleRequest :  IEquatable<UpdateWeekScheduleRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// For a published schedule, this determines whether a notification will be shown to agents in the default PureCloud user interface.  The CPC notification will always be sent and the value specified here affects what data is returned in the 'updates' property.  In the default PureCloud UI, \"None\" means that agents will not be notified, \"ShiftTimesOnly\" means agents will only be notified for changes to shift start and end times,  and \"All\" means that agents will be notified for any change to a shift or activity (except for full day off activities).  When building a custom client, use this property to specify the level of detail you need. Defaults to \"ShiftTimesOnly\".
        /// </summary>
        /// <value>For a published schedule, this determines whether a notification will be shown to agents in the default PureCloud user interface.  The CPC notification will always be sent and the value specified here affects what data is returned in the 'updates' property.  In the default PureCloud UI, \"None\" means that agents will not be notified, \"ShiftTimesOnly\" means agents will only be notified for changes to shift start and end times,  and \"All\" means that agents will be notified for any change to a shift or activity (except for full day off activities).  When building a custom client, use this property to specify the level of detail you need. Defaults to \"ShiftTimesOnly\".</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AgentUpdateFilterEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Shifttimechange for "ShiftTimeChange"
            /// </summary>
            [EnumMember(Value = "ShiftTimeChange")]
            Shifttimechange,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// For a published schedule, this determines whether a notification will be shown to agents in the default PureCloud user interface.  The CPC notification will always be sent and the value specified here affects what data is returned in the 'updates' property.  In the default PureCloud UI, \"None\" means that agents will not be notified, \"ShiftTimesOnly\" means agents will only be notified for changes to shift start and end times,  and \"All\" means that agents will be notified for any change to a shift or activity (except for full day off activities).  When building a custom client, use this property to specify the level of detail you need. Defaults to \"ShiftTimesOnly\".
        /// </summary>
        /// <value>For a published schedule, this determines whether a notification will be shown to agents in the default PureCloud user interface.  The CPC notification will always be sent and the value specified here affects what data is returned in the 'updates' property.  In the default PureCloud UI, \"None\" means that agents will not be notified, \"ShiftTimesOnly\" means agents will only be notified for changes to shift start and end times,  and \"All\" means that agents will be notified for any change to a shift or activity (except for full day off activities).  When building a custom client, use this property to specify the level of detail you need. Defaults to \"ShiftTimesOnly\".</value>
        [DataMember(Name="agentUpdateFilter", EmitDefaultValue=false)]
        public AgentUpdateFilterEnum? AgentUpdateFilter { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWeekScheduleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateWeekScheduleRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWeekScheduleRequest" /> class.
        /// </summary>
        /// <param name="Description">Description of the week schedule.</param>
        /// <param name="Published">Whether the week schedule is published.</param>
        /// <param name="UserSchedules">User schedules in the week.</param>
        /// <param name="PartialUploadIds">IDs of partial uploads to include in this imported schedule. It is applicable only for large schedules where activity count in schedule is greater than 17500.</param>
        /// <param name="Metadata">Version metadata for this work plan (required).</param>
        /// <param name="AgentSchedulesVersion">Version of agent schedules in the week schedule (required).</param>
        /// <param name="ShortTermForecast">Reference to optionally point the schedule at a new short term forecast.</param>
        /// <param name="HeadcountForecast">The headcount forecast associated with the schedule.  If not null, existing values will be irrecoverably replaced.</param>
        /// <param name="AgentUpdateFilter">For a published schedule, this determines whether a notification will be shown to agents in the default PureCloud user interface.  The CPC notification will always be sent and the value specified here affects what data is returned in the &#39;updates&#39; property.  In the default PureCloud UI, \&quot;None\&quot; means that agents will not be notified, \&quot;ShiftTimesOnly\&quot; means agents will only be notified for changes to shift start and end times,  and \&quot;All\&quot; means that agents will be notified for any change to a shift or activity (except for full day off activities).  When building a custom client, use this property to specify the level of detail you need. Defaults to \&quot;ShiftTimesOnly\&quot;..</param>
        public UpdateWeekScheduleRequest(string Description = null, bool? Published = null, Dictionary<string, UserSchedule> UserSchedules = null, List<string> PartialUploadIds = null, WfmVersionedEntityMetadata Metadata = null, int? AgentSchedulesVersion = null, ShortTermForecastReference ShortTermForecast = null, HeadcountForecast HeadcountForecast = null, AgentUpdateFilterEnum? AgentUpdateFilter = null)
        {
            this.Description = Description;
            this.Published = Published;
            this.UserSchedules = UserSchedules;
            this.PartialUploadIds = PartialUploadIds;
            this.Metadata = Metadata;
            this.AgentSchedulesVersion = AgentSchedulesVersion;
            this.ShortTermForecast = ShortTermForecast;
            this.HeadcountForecast = HeadcountForecast;
            this.AgentUpdateFilter = AgentUpdateFilter;
            
        }
        
        
        
        /// <summary>
        /// Description of the week schedule
        /// </summary>
        /// <value>Description of the week schedule</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Whether the week schedule is published
        /// </summary>
        /// <value>Whether the week schedule is published</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }
        
        
        
        /// <summary>
        /// User schedules in the week
        /// </summary>
        /// <value>User schedules in the week</value>
        [DataMember(Name="userSchedules", EmitDefaultValue=false)]
        public Dictionary<string, UserSchedule> UserSchedules { get; set; }
        
        
        
        /// <summary>
        /// IDs of partial uploads to include in this imported schedule. It is applicable only for large schedules where activity count in schedule is greater than 17500
        /// </summary>
        /// <value>IDs of partial uploads to include in this imported schedule. It is applicable only for large schedules where activity count in schedule is greater than 17500</value>
        [DataMember(Name="partialUploadIds", EmitDefaultValue=false)]
        public List<string> PartialUploadIds { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for this work plan
        /// </summary>
        /// <value>Version metadata for this work plan</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        
        /// <summary>
        /// Version of agent schedules in the week schedule
        /// </summary>
        /// <value>Version of agent schedules in the week schedule</value>
        [DataMember(Name="agentSchedulesVersion", EmitDefaultValue=false)]
        public int? AgentSchedulesVersion { get; set; }
        
        
        
        /// <summary>
        /// Reference to optionally point the schedule at a new short term forecast
        /// </summary>
        /// <value>Reference to optionally point the schedule at a new short term forecast</value>
        [DataMember(Name="shortTermForecast", EmitDefaultValue=false)]
        public ShortTermForecastReference ShortTermForecast { get; set; }
        
        
        
        /// <summary>
        /// The headcount forecast associated with the schedule.  If not null, existing values will be irrecoverably replaced
        /// </summary>
        /// <value>The headcount forecast associated with the schedule.  If not null, existing values will be irrecoverably replaced</value>
        [DataMember(Name="headcountForecast", EmitDefaultValue=false)]
        public HeadcountForecast HeadcountForecast { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWeekScheduleRequest {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  UserSchedules: ").Append(UserSchedules).Append("\n");
            sb.Append("  PartialUploadIds: ").Append(PartialUploadIds).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  AgentSchedulesVersion: ").Append(AgentSchedulesVersion).Append("\n");
            sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
            sb.Append("  HeadcountForecast: ").Append(HeadcountForecast).Append("\n");
            sb.Append("  AgentUpdateFilter: ").Append(AgentUpdateFilter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UpdateWeekScheduleRequest);
        }

        /// <summary>
        /// Returns true if UpdateWeekScheduleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateWeekScheduleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateWeekScheduleRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.UserSchedules == other.UserSchedules ||
                    this.UserSchedules != null &&
                    this.UserSchedules.SequenceEqual(other.UserSchedules)
                ) &&
                (
                    this.PartialUploadIds == other.PartialUploadIds ||
                    this.PartialUploadIds != null &&
                    this.PartialUploadIds.SequenceEqual(other.PartialUploadIds)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.AgentSchedulesVersion == other.AgentSchedulesVersion ||
                    this.AgentSchedulesVersion != null &&
                    this.AgentSchedulesVersion.Equals(other.AgentSchedulesVersion)
                ) &&
                (
                    this.ShortTermForecast == other.ShortTermForecast ||
                    this.ShortTermForecast != null &&
                    this.ShortTermForecast.Equals(other.ShortTermForecast)
                ) &&
                (
                    this.HeadcountForecast == other.HeadcountForecast ||
                    this.HeadcountForecast != null &&
                    this.HeadcountForecast.Equals(other.HeadcountForecast)
                ) &&
                (
                    this.AgentUpdateFilter == other.AgentUpdateFilter ||
                    this.AgentUpdateFilter != null &&
                    this.AgentUpdateFilter.Equals(other.AgentUpdateFilter)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                
                if (this.UserSchedules != null)
                    hash = hash * 59 + this.UserSchedules.GetHashCode();
                
                if (this.PartialUploadIds != null)
                    hash = hash * 59 + this.PartialUploadIds.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                if (this.AgentSchedulesVersion != null)
                    hash = hash * 59 + this.AgentSchedulesVersion.GetHashCode();
                
                if (this.ShortTermForecast != null)
                    hash = hash * 59 + this.ShortTermForecast.GetHashCode();
                
                if (this.HeadcountForecast != null)
                    hash = hash * 59 + this.HeadcountForecast.GetHashCode();
                
                if (this.AgentUpdateFilter != null)
                    hash = hash * 59 + this.AgentUpdateFilter.GetHashCode();
                
                return hash;
            }
        }
    }

}
