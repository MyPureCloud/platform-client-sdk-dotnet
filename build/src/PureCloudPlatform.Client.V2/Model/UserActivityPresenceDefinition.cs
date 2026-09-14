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
    /// UserActivityPresenceDefinition
    /// </summary>
    [DataContract]
    public partial class UserActivityPresenceDefinition :  IEquatable<UserActivityPresenceDefinition>
    {
        /// <summary>
        /// The system presence to which this definition maps
        /// </summary>
        /// <value>The system presence to which this definition maps</value>
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
        /// The system presence to which this definition maps
        /// </summary>
        /// <value>The system presence to which this definition maps</value>
        [DataMember(Name="systemPresence", EmitDefaultValue=false)]
        public SystemPresenceEnum? SystemPresence { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivityPresenceDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserActivityPresenceDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivityPresenceDefinition" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the presence definition (required).</param>
        /// <param name="SystemPresence">The system presence to which this definition maps (required).</param>
        public UserActivityPresenceDefinition(string Id = null, SystemPresenceEnum? SystemPresence = null)
        {
            this.Id = Id;
            this.SystemPresence = SystemPresence;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the presence definition
        /// </summary>
        /// <value>The globally unique identifier for the presence definition</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserActivityPresenceDefinition {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
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
            return this.Equals(obj as UserActivityPresenceDefinition);
        }

        /// <summary>
        /// Returns true if UserActivityPresenceDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of UserActivityPresenceDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserActivityPresenceDefinition other)
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
                    this.SystemPresence == other.SystemPresence ||
                    this.SystemPresence != null &&
                    this.SystemPresence.Equals(other.SystemPresence)
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

                if (this.SystemPresence != null)
                    hash = hash * 59 + this.SystemPresence.GetHashCode();

                return hash;
            }
        }
    }

}
