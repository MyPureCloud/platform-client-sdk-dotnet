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
    /// ConversationEventTopicScreenMonitoring
    /// </summary>
    [DataContract]
    public partial class ConversationEventTopicScreenMonitoring :  IEquatable<ConversationEventTopicScreenMonitoring>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Connected for "connected"
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "disconnected"
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected
        }
        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InitialStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Connected for "connected"
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "disconnected"
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected
        }
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DisconnectTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System
        }
        /// <summary>
        /// The screen monitoring type.
        /// </summary>
        /// <value>The screen monitoring type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MonitoringTypeEnum
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
            /// Enum Agentlevel for "AgentLevel"
            /// </summary>
            [EnumMember(Value = "AgentLevel")]
            Agentlevel,
            
            /// <summary>
            /// Enum Conversationlevel for "ConversationLevel"
            /// </summary>
            [EnumMember(Value = "ConversationLevel")]
            Conversationlevel
        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [DataMember(Name="initialState", EmitDefaultValue=false)]
        public InitialStateEnum? InitialState { get; set; }
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// The screen monitoring type.
        /// </summary>
        /// <value>The screen monitoring type.</value>
        [DataMember(Name="monitoringType", EmitDefaultValue=false)]
        public MonitoringTypeEnum? MonitoringType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventTopicScreenMonitoring" /> class.
        /// </summary>
        /// <param name="Id">A globally unique identifier for this communication..</param>
        /// <param name="State">State.</param>
        /// <param name="InitialState">InitialState.</param>
        /// <param name="Provider">The source provider..</param>
        /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
        /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
        /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
        /// <param name="TargetUserId">The user ID for the participant who is being screen monitored..</param>
        /// <param name="ScreenMonitoringId">Screen Monitoring identifier unique to the sourceUserId-targetUserId pair..</param>
        /// <param name="MonitoringType">The screen monitoring type..</param>
        /// <param name="Count">Number of Screen Monitoring sessions the targetUserId is involved in..</param>
        public ConversationEventTopicScreenMonitoring(string Id = null, StateEnum? State = null, InitialStateEnum? InitialState = null, string Provider = null, DisconnectTypeEnum? DisconnectType = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, string TargetUserId = null, string ScreenMonitoringId = null, MonitoringTypeEnum? MonitoringType = null, long? Count = null)
        {
            this.Id = Id;
            this.State = State;
            this.InitialState = InitialState;
            this.Provider = Provider;
            this.DisconnectType = DisconnectType;
            this.ConnectedTime = ConnectedTime;
            this.DisconnectedTime = DisconnectedTime;
            this.TargetUserId = TargetUserId;
            this.ScreenMonitoringId = ScreenMonitoringId;
            this.MonitoringType = MonitoringType;
            this.Count = Count;
            
        }
        


        /// <summary>
        /// A globally unique identifier for this communication.
        /// </summary>
        /// <value>A globally unique identifier for this communication.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }







        /// <summary>
        /// The source provider.
        /// </summary>
        /// <value>The source provider.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }





        /// <summary>
        /// The timestamp when this communication was connected in the cloud clock.
        /// </summary>
        /// <value>The timestamp when this communication was connected in the cloud clock.</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }



        /// <summary>
        /// The timestamp when this communication disconnected from the conversation in the provider clock.
        /// </summary>
        /// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
        [DataMember(Name="disconnectedTime", EmitDefaultValue=false)]
        public DateTime? DisconnectedTime { get; set; }



        /// <summary>
        /// The user ID for the participant who is being screen monitored.
        /// </summary>
        /// <value>The user ID for the participant who is being screen monitored.</value>
        [DataMember(Name="targetUserId", EmitDefaultValue=false)]
        public string TargetUserId { get; set; }



        /// <summary>
        /// Screen Monitoring identifier unique to the sourceUserId-targetUserId pair.
        /// </summary>
        /// <value>Screen Monitoring identifier unique to the sourceUserId-targetUserId pair.</value>
        [DataMember(Name="screenMonitoringId", EmitDefaultValue=false)]
        public string ScreenMonitoringId { get; set; }





        /// <summary>
        /// Number of Screen Monitoring sessions the targetUserId is involved in.
        /// </summary>
        /// <value>Number of Screen Monitoring sessions the targetUserId is involved in.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventTopicScreenMonitoring {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  InitialState: ").Append(InitialState).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
            sb.Append("  TargetUserId: ").Append(TargetUserId).Append("\n");
            sb.Append("  ScreenMonitoringId: ").Append(ScreenMonitoringId).Append("\n");
            sb.Append("  MonitoringType: ").Append(MonitoringType).Append("\n");
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
            return this.Equals(obj as ConversationEventTopicScreenMonitoring);
        }

        /// <summary>
        /// Returns true if ConversationEventTopicScreenMonitoring instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationEventTopicScreenMonitoring to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventTopicScreenMonitoring other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.InitialState == other.InitialState ||
                    this.InitialState != null &&
                    this.InitialState.Equals(other.InitialState)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.DisconnectedTime == other.DisconnectedTime ||
                    this.DisconnectedTime != null &&
                    this.DisconnectedTime.Equals(other.DisconnectedTime)
                ) &&
                (
                    this.TargetUserId == other.TargetUserId ||
                    this.TargetUserId != null &&
                    this.TargetUserId.Equals(other.TargetUserId)
                ) &&
                (
                    this.ScreenMonitoringId == other.ScreenMonitoringId ||
                    this.ScreenMonitoringId != null &&
                    this.ScreenMonitoringId.Equals(other.ScreenMonitoringId)
                ) &&
                (
                    this.MonitoringType == other.MonitoringType ||
                    this.MonitoringType != null &&
                    this.MonitoringType.Equals(other.MonitoringType)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.InitialState != null)
                    hash = hash * 59 + this.InitialState.GetHashCode();

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();

                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();

                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();

                if (this.TargetUserId != null)
                    hash = hash * 59 + this.TargetUserId.GetHashCode();

                if (this.ScreenMonitoringId != null)
                    hash = hash * 59 + this.ScreenMonitoringId.GetHashCode();

                if (this.MonitoringType != null)
                    hash = hash * 59 + this.MonitoringType.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
