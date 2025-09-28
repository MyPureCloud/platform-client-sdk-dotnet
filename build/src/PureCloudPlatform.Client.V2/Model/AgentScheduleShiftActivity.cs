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
    /// AgentScheduleShiftActivity
    /// </summary>
    [DataContract]
    public partial class AgentScheduleShiftActivity :  IEquatable<AgentScheduleShiftActivity>
    {
        /// <summary>
        /// The activity category for which the agent is scheduled
        /// </summary>
        /// <value>The activity category for which the agent is scheduled</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActivityCategoryEnum
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
            Unavailable
        }
        /// <summary>
        /// The activity category for which the agent is scheduled
        /// </summary>
        /// <value>The activity category for which the agent is scheduled</value>
        [DataMember(Name="activityCategory", EmitDefaultValue=false)]
        public ActivityCategoryEnum? ActivityCategory { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleShiftActivity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentScheduleShiftActivity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleShiftActivity" /> class.
        /// </summary>
        /// <param name="ActivityCategory">The activity category for which the agent is scheduled (required).</param>
        /// <param name="StartOffsetMinutes">The start offset of the activity, relative to referenceStartDate at the top level (required).</param>
        /// <param name="LengthMinutes">The length of the activity in minutes (required).</param>
        public AgentScheduleShiftActivity(ActivityCategoryEnum? ActivityCategory = null, int? StartOffsetMinutes = null, int? LengthMinutes = null)
        {
            this.ActivityCategory = ActivityCategory;
            this.StartOffsetMinutes = StartOffsetMinutes;
            this.LengthMinutes = LengthMinutes;
            
        }
        




        /// <summary>
        /// The start offset of the activity, relative to referenceStartDate at the top level
        /// </summary>
        /// <value>The start offset of the activity, relative to referenceStartDate at the top level</value>
        [DataMember(Name="startOffsetMinutes", EmitDefaultValue=false)]
        public int? StartOffsetMinutes { get; set; }



        /// <summary>
        /// The length of the activity in minutes
        /// </summary>
        /// <value>The length of the activity in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentScheduleShiftActivity {\n");

            sb.Append("  ActivityCategory: ").Append(ActivityCategory).Append("\n");
            sb.Append("  StartOffsetMinutes: ").Append(StartOffsetMinutes).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
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
            return this.Equals(obj as AgentScheduleShiftActivity);
        }

        /// <summary>
        /// Returns true if AgentScheduleShiftActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentScheduleShiftActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentScheduleShiftActivity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActivityCategory == other.ActivityCategory ||
                    this.ActivityCategory != null &&
                    this.ActivityCategory.Equals(other.ActivityCategory)
                ) &&
                (
                    this.StartOffsetMinutes == other.StartOffsetMinutes ||
                    this.StartOffsetMinutes != null &&
                    this.StartOffsetMinutes.Equals(other.StartOffsetMinutes)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
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
                if (this.ActivityCategory != null)
                    hash = hash * 59 + this.ActivityCategory.GetHashCode();

                if (this.StartOffsetMinutes != null)
                    hash = hash * 59 + this.StartOffsetMinutes.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
