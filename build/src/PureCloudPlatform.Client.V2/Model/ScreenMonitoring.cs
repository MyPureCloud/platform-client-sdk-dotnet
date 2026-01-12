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
    /// ScreenMonitoring
    /// </summary>
    [DataContract]
    public partial class ScreenMonitoring :  IEquatable<ScreenMonitoring>
    {
        /// <summary>
        /// The initial connection state of this communication.
        /// </summary>
        /// <value>The initial connection state of this communication.</value>
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
        /// The connection state of this communication.
        /// </summary>
        /// <value>The connection state of this communication.</value>
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
        /// The initial connection state of this communication.
        /// </summary>
        /// <value>The initial connection state of this communication.</value>
        [DataMember(Name="initialState", EmitDefaultValue=false)]
        public InitialStateEnum? InitialState { get; set; }
        /// <summary>
        /// The connection state of this communication.
        /// </summary>
        /// <value>The connection state of this communication.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
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
        /// Initializes a new instance of the <see cref="ScreenMonitoring" /> class.
        /// </summary>
        /// <param name="Id">A globally unique identifier for this communication..</param>
        /// <param name="InitialState">The initial connection state of this communication..</param>
        /// <param name="State">The connection state of this communication..</param>
        /// <param name="Segments">The time line of the participant&#39;s Screen Monitoring media, divided into activity segments..</param>
        /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
        /// <param name="Provider">The source provider of Screen Monitoring media..</param>
        /// <param name="TargetUser">The user participant who is being screen monitored..</param>
        /// <param name="_ScreenMonitoring">Screen Monitoring identifier unique to the sourceUserId-targetUserId pair..</param>
        /// <param name="MonitoringType">The screen monitoring type..</param>
        /// <param name="Count">Number of Screen Monitoring sessions the targetUserId is involved in..</param>
        /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public ScreenMonitoring(string Id = null, InitialStateEnum? InitialState = null, StateEnum? State = null, List<Segment> Segments = null, DisconnectTypeEnum? DisconnectType = null, string Provider = null, AddressableEntityRef TargetUser = null, AddressableEntityRef _ScreenMonitoring = null, MonitoringTypeEnum? MonitoringType = null, long? Count = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null)
        {
            this.Id = Id;
            this.InitialState = InitialState;
            this.State = State;
            this.Segments = Segments;
            this.DisconnectType = DisconnectType;
            this.Provider = Provider;
            this.TargetUser = TargetUser;
            this._ScreenMonitoring = _ScreenMonitoring;
            this.MonitoringType = MonitoringType;
            this.Count = Count;
            this.ConnectedTime = ConnectedTime;
            this.DisconnectedTime = DisconnectedTime;
            
        }
        


        /// <summary>
        /// A globally unique identifier for this communication.
        /// </summary>
        /// <value>A globally unique identifier for this communication.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }







        /// <summary>
        /// The time line of the participant&#39;s Screen Monitoring media, divided into activity segments.
        /// </summary>
        /// <value>The time line of the participant&#39;s Screen Monitoring media, divided into activity segments.</value>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<Segment> Segments { get; set; }





        /// <summary>
        /// The source provider of Screen Monitoring media.
        /// </summary>
        /// <value>The source provider of Screen Monitoring media.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }



        /// <summary>
        /// The user participant who is being screen monitored.
        /// </summary>
        /// <value>The user participant who is being screen monitored.</value>
        [DataMember(Name="targetUser", EmitDefaultValue=false)]
        public AddressableEntityRef TargetUser { get; set; }



        /// <summary>
        /// Screen Monitoring identifier unique to the sourceUserId-targetUserId pair.
        /// </summary>
        /// <value>Screen Monitoring identifier unique to the sourceUserId-targetUserId pair.</value>
        [DataMember(Name="screenMonitoring", EmitDefaultValue=false)]
        public AddressableEntityRef _ScreenMonitoring { get; set; }





        /// <summary>
        /// Number of Screen Monitoring sessions the targetUserId is involved in.
        /// </summary>
        /// <value>Number of Screen Monitoring sessions the targetUserId is involved in.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }



        /// <summary>
        /// The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }



        /// <summary>
        /// The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="disconnectedTime", EmitDefaultValue=false)]
        public DateTime? DisconnectedTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenMonitoring {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InitialState: ").Append(InitialState).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  TargetUser: ").Append(TargetUser).Append("\n");
            sb.Append("  _ScreenMonitoring: ").Append(_ScreenMonitoring).Append("\n");
            sb.Append("  MonitoringType: ").Append(MonitoringType).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
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
            return this.Equals(obj as ScreenMonitoring);
        }

        /// <summary>
        /// Returns true if ScreenMonitoring instances are equal
        /// </summary>
        /// <param name="other">Instance of ScreenMonitoring to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenMonitoring other)
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
                    this.InitialState == other.InitialState ||
                    this.InitialState != null &&
                    this.InitialState.Equals(other.InitialState)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Segments == other.Segments ||
                    this.Segments != null &&
                    this.Segments.SequenceEqual(other.Segments)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.TargetUser == other.TargetUser ||
                    this.TargetUser != null &&
                    this.TargetUser.Equals(other.TargetUser)
                ) &&
                (
                    this._ScreenMonitoring == other._ScreenMonitoring ||
                    this._ScreenMonitoring != null &&
                    this._ScreenMonitoring.Equals(other._ScreenMonitoring)
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

                if (this.InitialState != null)
                    hash = hash * 59 + this.InitialState.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Segments != null)
                    hash = hash * 59 + this.Segments.GetHashCode();

                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                if (this.TargetUser != null)
                    hash = hash * 59 + this.TargetUser.GetHashCode();

                if (this._ScreenMonitoring != null)
                    hash = hash * 59 + this._ScreenMonitoring.GetHashCode();

                if (this.MonitoringType != null)
                    hash = hash * 59 + this.MonitoringType.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();

                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();

                return hash;
            }
        }
    }

}
