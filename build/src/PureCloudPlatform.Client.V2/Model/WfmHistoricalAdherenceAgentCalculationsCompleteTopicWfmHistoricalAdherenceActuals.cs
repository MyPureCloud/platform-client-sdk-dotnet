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
    /// WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals :  IEquatable<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals>
    {
        /// <summary>
        /// Gets or Sets ActualActivityCategory
        /// </summary>
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
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
        /// Gets or Sets ActualActivityCategory
        /// </summary>
        [DataMember(Name="actualActivityCategory", EmitDefaultValue=false)]
        public ActualActivityCategoryEnum? ActualActivityCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals" /> class.
        /// </summary>
        /// <param name="ActualActivityCategory">ActualActivityCategory.</param>
        /// <param name="ActualSecondaryPresenceId">ActualSecondaryPresenceId.</param>
        /// <param name="StartOffsetSeconds">StartOffsetSeconds.</param>
        /// <param name="EndOffsetSeconds">EndOffsetSeconds.</param>
        public WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals(ActualActivityCategoryEnum? ActualActivityCategory = null, string ActualSecondaryPresenceId = null, long? StartOffsetSeconds = null, long? EndOffsetSeconds = null)
        {
            this.ActualActivityCategory = ActualActivityCategory;
            this.ActualSecondaryPresenceId = ActualSecondaryPresenceId;
            this.StartOffsetSeconds = StartOffsetSeconds;
            this.EndOffsetSeconds = EndOffsetSeconds;
            
        }
        




        /// <summary>
        /// Gets or Sets ActualSecondaryPresenceId
        /// </summary>
        [DataMember(Name="actualSecondaryPresenceId", EmitDefaultValue=false)]
        public string ActualSecondaryPresenceId { get; set; }



        /// <summary>
        /// Gets or Sets StartOffsetSeconds
        /// </summary>
        [DataMember(Name="startOffsetSeconds", EmitDefaultValue=false)]
        public long? StartOffsetSeconds { get; set; }



        /// <summary>
        /// Gets or Sets EndOffsetSeconds
        /// </summary>
        [DataMember(Name="endOffsetSeconds", EmitDefaultValue=false)]
        public long? EndOffsetSeconds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals {\n");

            sb.Append("  ActualActivityCategory: ").Append(ActualActivityCategory).Append("\n");
            sb.Append("  ActualSecondaryPresenceId: ").Append(ActualSecondaryPresenceId).Append("\n");
            sb.Append("  StartOffsetSeconds: ").Append(StartOffsetSeconds).Append("\n");
            sb.Append("  EndOffsetSeconds: ").Append(EndOffsetSeconds).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActualActivityCategory == other.ActualActivityCategory ||
                    this.ActualActivityCategory != null &&
                    this.ActualActivityCategory.Equals(other.ActualActivityCategory)
                ) &&
                (
                    this.ActualSecondaryPresenceId == other.ActualSecondaryPresenceId ||
                    this.ActualSecondaryPresenceId != null &&
                    this.ActualSecondaryPresenceId.Equals(other.ActualSecondaryPresenceId)
                ) &&
                (
                    this.StartOffsetSeconds == other.StartOffsetSeconds ||
                    this.StartOffsetSeconds != null &&
                    this.StartOffsetSeconds.Equals(other.StartOffsetSeconds)
                ) &&
                (
                    this.EndOffsetSeconds == other.EndOffsetSeconds ||
                    this.EndOffsetSeconds != null &&
                    this.EndOffsetSeconds.Equals(other.EndOffsetSeconds)
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
                if (this.ActualActivityCategory != null)
                    hash = hash * 59 + this.ActualActivityCategory.GetHashCode();

                if (this.ActualSecondaryPresenceId != null)
                    hash = hash * 59 + this.ActualSecondaryPresenceId.GetHashCode();

                if (this.StartOffsetSeconds != null)
                    hash = hash * 59 + this.StartOffsetSeconds.GetHashCode();

                if (this.EndOffsetSeconds != null)
                    hash = hash * 59 + this.EndOffsetSeconds.GetHashCode();

                return hash;
            }
        }
    }

}
