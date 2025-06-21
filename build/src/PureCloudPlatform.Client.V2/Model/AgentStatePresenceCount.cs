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
    /// AgentStatePresenceCount
    /// </summary>
    [DataContract]
    public partial class AgentStatePresenceCount :  IEquatable<AgentStatePresenceCount>
    {
        /// <summary>
        /// System presence
        /// </summary>
        /// <value>System presence</value>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
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
        /// System presence
        /// </summary>
        /// <value>System presence</value>
        [DataMember(Name="systemPresence", EmitDefaultValue=false)]
        public SystemPresenceEnum? SystemPresence { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatePresenceCount" /> class.
        /// </summary>
        /// <param name="SystemPresence">System presence.</param>
        /// <param name="OrganizationPresenceId">The identifier for the organization presence.</param>
        /// <param name="Count">Count of users with this system presence and organization presence.</param>
        public AgentStatePresenceCount(SystemPresenceEnum? SystemPresence = null, string OrganizationPresenceId = null, int? Count = null)
        {
            this.SystemPresence = SystemPresence;
            this.OrganizationPresenceId = OrganizationPresenceId;
            this.Count = Count;
            
        }
        




        /// <summary>
        /// The identifier for the organization presence
        /// </summary>
        /// <value>The identifier for the organization presence</value>
        [DataMember(Name="organizationPresenceId", EmitDefaultValue=false)]
        public string OrganizationPresenceId { get; set; }



        /// <summary>
        /// Count of users with this system presence and organization presence
        /// </summary>
        /// <value>Count of users with this system presence and organization presence</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStatePresenceCount {\n");

            sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
            sb.Append("  OrganizationPresenceId: ").Append(OrganizationPresenceId).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as AgentStatePresenceCount);
        }

        /// <summary>
        /// Returns true if AgentStatePresenceCount instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentStatePresenceCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentStatePresenceCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SystemPresence == other.SystemPresence ||
                    this.SystemPresence != null &&
                    this.SystemPresence.Equals(other.SystemPresence)
                ) &&
                (
                    this.OrganizationPresenceId == other.OrganizationPresenceId ||
                    this.OrganizationPresenceId != null &&
                    this.OrganizationPresenceId.Equals(other.OrganizationPresenceId)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.SystemPresence != null)
                    hash = hash * 59 + this.SystemPresence.GetHashCode();

                if (this.OrganizationPresenceId != null)
                    hash = hash * 59 + this.OrganizationPresenceId.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
