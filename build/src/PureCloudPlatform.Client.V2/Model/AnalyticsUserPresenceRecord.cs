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
    /// AnalyticsUserPresenceRecord
    /// </summary>
    [DataContract]
    public partial class AnalyticsUserPresenceRecord :  IEquatable<AnalyticsUserPresenceRecord>
    {
        /// <summary>
        /// The user's system presence
        /// </summary>
        /// <value>The user's system presence</value>
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
            /// Enum Available for "AVAILABLE"
            /// </summary>
            [EnumMember(Value = "AVAILABLE")]
            Available,
            
            /// <summary>
            /// Enum Away for "AWAY"
            /// </summary>
            [EnumMember(Value = "AWAY")]
            Away,
            
            /// <summary>
            /// Enum Busy for "BUSY"
            /// </summary>
            [EnumMember(Value = "BUSY")]
            Busy,
            
            /// <summary>
            /// Enum Offline for "OFFLINE"
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            Offline,
            
            /// <summary>
            /// Enum Idle for "IDLE"
            /// </summary>
            [EnumMember(Value = "IDLE")]
            Idle,
            
            /// <summary>
            /// Enum OnQueue for "ON_QUEUE"
            /// </summary>
            [EnumMember(Value = "ON_QUEUE")]
            OnQueue,
            
            /// <summary>
            /// Enum Meal for "MEAL"
            /// </summary>
            [EnumMember(Value = "MEAL")]
            Meal,
            
            /// <summary>
            /// Enum Training for "TRAINING"
            /// </summary>
            [EnumMember(Value = "TRAINING")]
            Training,
            
            /// <summary>
            /// Enum Meeting for "MEETING"
            /// </summary>
            [EnumMember(Value = "MEETING")]
            Meeting,
            
            /// <summary>
            /// Enum Break for "BREAK"
            /// </summary>
            [EnumMember(Value = "BREAK")]
            Break
        }
        /// <summary>
        /// The user's system presence
        /// </summary>
        /// <value>The user's system presence</value>
        [DataMember(Name="systemPresence", EmitDefaultValue=false)]
        public SystemPresenceEnum? SystemPresence { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsUserPresenceRecord" /> class.
        /// </summary>
        /// <param name="StartTime">The start time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EndTime">The end time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="SystemPresence">The user's system presence.</param>
        /// <param name="OrganizationPresenceId">The identifier for the user's organization presence.</param>
        public AnalyticsUserPresenceRecord(DateTime? StartTime = null, DateTime? EndTime = null, SystemPresenceEnum? SystemPresence = null, string OrganizationPresenceId = null)
        {
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.SystemPresence = SystemPresence;
            this.OrganizationPresenceId = OrganizationPresenceId;
            
        }
        


        /// <summary>
        /// The start time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }



        /// <summary>
        /// The end time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end time of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }





        /// <summary>
        /// The identifier for the user's organization presence
        /// </summary>
        /// <value>The identifier for the user's organization presence</value>
        [DataMember(Name="organizationPresenceId", EmitDefaultValue=false)]
        public string OrganizationPresenceId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsUserPresenceRecord {\n");

            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
            sb.Append("  OrganizationPresenceId: ").Append(OrganizationPresenceId).Append("\n");
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
            return this.Equals(obj as AnalyticsUserPresenceRecord);
        }

        /// <summary>
        /// Returns true if AnalyticsUserPresenceRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsUserPresenceRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsUserPresenceRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.SystemPresence == other.SystemPresence ||
                    this.SystemPresence != null &&
                    this.SystemPresence.Equals(other.SystemPresence)
                ) &&
                (
                    this.OrganizationPresenceId == other.OrganizationPresenceId ||
                    this.OrganizationPresenceId != null &&
                    this.OrganizationPresenceId.Equals(other.OrganizationPresenceId)
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
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();

                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();

                if (this.SystemPresence != null)
                    hash = hash * 59 + this.SystemPresence.GetHashCode();

                if (this.OrganizationPresenceId != null)
                    hash = hash * 59 + this.OrganizationPresenceId.GetHashCode();

                return hash;
            }
        }
    }

}
