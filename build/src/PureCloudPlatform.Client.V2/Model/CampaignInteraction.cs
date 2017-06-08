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
    /// CampaignInteraction
    /// </summary>
    [DataContract]
    public partial class CampaignInteraction :  IEquatable<CampaignInteraction>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer
        /// </summary>
        /// <value>Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DispositionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Disconnect for "DISCONNECT"
            /// </summary>
            [EnumMember(Value = "DISCONNECT")]
            Disconnect,
            
            /// <summary>
            /// Enum LiveVoice for "LIVE_VOICE"
            /// </summary>
            [EnumMember(Value = "LIVE_VOICE")]
            LiveVoice,
            
            /// <summary>
            /// Enum Busy for "BUSY"
            /// </summary>
            [EnumMember(Value = "BUSY")]
            Busy,
            
            /// <summary>
            /// Enum Machine for "MACHINE"
            /// </summary>
            [EnumMember(Value = "MACHINE")]
            Machine,
            
            /// <summary>
            /// Enum NoAnswer for "NO_ANSWER"
            /// </summary>
            [EnumMember(Value = "NO_ANSWER")]
            NoAnswer,
            
            /// <summary>
            /// Enum SitCallable for "SIT_CALLABLE"
            /// </summary>
            [EnumMember(Value = "SIT_CALLABLE")]
            SitCallable,
            
            /// <summary>
            /// Enum SitUncallable for "SIT_UNCALLABLE"
            /// </summary>
            [EnumMember(Value = "SIT_UNCALLABLE")]
            SitUncallable,
            
            /// <summary>
            /// Enum Fax for "FAX"
            /// </summary>
            [EnumMember(Value = "FAX")]
            Fax
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer
        /// </summary>
        /// <value>Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer</value>
        [DataMember(Name="disposition", EmitDefaultValue=false)]
        public DispositionEnum? Disposition { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignInteraction" /> class.
        /// </summary>
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="Campaign">Campaign.</param>
        
        
        
        /// <param name="Agent">Agent.</param>
        
        
        
        /// <param name="Contact">Contact.</param>
        
        
        
        /// <param name="DestinationAddress">DestinationAddress.</param>
        
        
        
        /// <param name="ActivePreviewCall">Boolean value if there is an active preview call on the interaction.</param>
        
        
        
        /// <param name="LastActivePreviewWrapupTime">The time when the last preview of the interaction was wrapped up. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="CreationTime">The time when dialer created the interaction. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="CallPlacedTime">The time when the agent or system places the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="CallRoutedTime">The time when the agent was connected to the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="PreviewConnectedTime">The time when the customer and routing participant are connected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="Queue">Queue.</param>
        
        
        
        /// <param name="Script">Script.</param>
        
        
        
        /// <param name="Disposition">Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer.</param>
        
        
        
        /// <param name="CallerName">CallerName.</param>
        
        
        
        /// <param name="CallerAddress">CallerAddress.</param>
        
        
        
        /// <param name="PreviewPopDeliveredTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="Conversation">Conversation.</param>
        
        
        
        /// <param name="DialerSystemParticipantId">conversation participant id that is the dialer system participant to monitor the call from dialer perspective.</param>
        
        
        
        /// <param name="DialingMode">DialingMode.</param>
        
        
        
        /// <param name="Skills">Any skills that are attached to the call for routing.</param>
        
        
        public CampaignInteraction(string Id = null, UriReference Campaign = null, UriReference Agent = null, UriReference Contact = null, string DestinationAddress = null, bool? ActivePreviewCall = null, DateTime? LastActivePreviewWrapupTime = null, DateTime? CreationTime = null, DateTime? CallPlacedTime = null, DateTime? CallRoutedTime = null, DateTime? PreviewConnectedTime = null, UriReference Queue = null, UriReference Script = null, DispositionEnum? Disposition = null, string CallerName = null, string CallerAddress = null, DateTime? PreviewPopDeliveredTime = null, ConversationBasic Conversation = null, string DialerSystemParticipantId = null, string DialingMode = null, List<UriReference> Skills = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Campaign = Campaign;
            
            
            
            
            
            
            
            
this.Agent = Agent;
            
            
            
            
            
            
            
            
this.Contact = Contact;
            
            
            
            
            
            
            
            
this.DestinationAddress = DestinationAddress;
            
            
            
            
            
            
            
            
this.ActivePreviewCall = ActivePreviewCall;
            
            
            
            
            
            
            
            
this.LastActivePreviewWrapupTime = LastActivePreviewWrapupTime;
            
            
            
            
            
            
            
            
this.CreationTime = CreationTime;
            
            
            
            
            
            
            
            
this.CallPlacedTime = CallPlacedTime;
            
            
            
            
            
            
            
            
this.CallRoutedTime = CallRoutedTime;
            
            
            
            
            
            
            
            
this.PreviewConnectedTime = PreviewConnectedTime;
            
            
            
            
            
            
            
            
this.Queue = Queue;
            
            
            
            
            
            
            
            
this.Script = Script;
            
            
            
            
            
            
            
            
this.Disposition = Disposition;
            
            
            
            
            
            
            
            
this.CallerName = CallerName;
            
            
            
            
            
            
            
            
this.CallerAddress = CallerAddress;
            
            
            
            
            
            
            
            
this.PreviewPopDeliveredTime = PreviewPopDeliveredTime;
            
            
            
            
            
            
            
            
this.Conversation = Conversation;
            
            
            
            
            
            
            
            
this.DialerSystemParticipantId = DialerSystemParticipantId;
            
            
            
            
            
            
            
            
this.DialingMode = DialingMode;
            
            
            
            
            
            
            
            
this.Skills = Skills;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public UriReference Campaign { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public UriReference Agent { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public UriReference Contact { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DestinationAddress
        /// </summary>
        [DataMember(Name="destinationAddress", EmitDefaultValue=false)]
        public string DestinationAddress { get; set; }
        
        
        
        /// <summary>
        /// Boolean value if there is an active preview call on the interaction
        /// </summary>
        /// <value>Boolean value if there is an active preview call on the interaction</value>
        [DataMember(Name="activePreviewCall", EmitDefaultValue=false)]
        public bool? ActivePreviewCall { get; set; }
        
        
        
        /// <summary>
        /// The time when the last preview of the interaction was wrapped up. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the last preview of the interaction was wrapped up. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="lastActivePreviewWrapupTime", EmitDefaultValue=false)]
        public DateTime? LastActivePreviewWrapupTime { get; set; }
        
        
        
        /// <summary>
        /// The time when dialer created the interaction. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when dialer created the interaction. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; set; }
        
        
        
        /// <summary>
        /// The time when the agent or system places the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the agent or system places the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="callPlacedTime", EmitDefaultValue=false)]
        public DateTime? CallPlacedTime { get; set; }
        
        
        
        /// <summary>
        /// The time when the agent was connected to the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the agent was connected to the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="callRoutedTime", EmitDefaultValue=false)]
        public DateTime? CallRoutedTime { get; set; }
        
        
        
        /// <summary>
        /// The time when the customer and routing participant are connected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the customer and routing participant are connected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="previewConnectedTime", EmitDefaultValue=false)]
        public DateTime? PreviewConnectedTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public UriReference Queue { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Script
        /// </summary>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public UriReference Script { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets CallerName
        /// </summary>
        [DataMember(Name="callerName", EmitDefaultValue=false)]
        public string CallerName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CallerAddress
        /// </summary>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="previewPopDeliveredTime", EmitDefaultValue=false)]
        public DateTime? PreviewPopDeliveredTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public ConversationBasic Conversation { get; set; }
        
        
        
        /// <summary>
        /// conversation participant id that is the dialer system participant to monitor the call from dialer perspective
        /// </summary>
        /// <value>conversation participant id that is the dialer system participant to monitor the call from dialer perspective</value>
        [DataMember(Name="dialerSystemParticipantId", EmitDefaultValue=false)]
        public string DialerSystemParticipantId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DialingMode
        /// </summary>
        [DataMember(Name="dialingMode", EmitDefaultValue=false)]
        public string DialingMode { get; set; }
        
        
        
        /// <summary>
        /// Any skills that are attached to the call for routing
        /// </summary>
        /// <value>Any skills that are attached to the call for routing</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<UriReference> Skills { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignInteraction {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            
            sb.Append("  ActivePreviewCall: ").Append(ActivePreviewCall).Append("\n");
            
            sb.Append("  LastActivePreviewWrapupTime: ").Append(LastActivePreviewWrapupTime).Append("\n");
            
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            
            sb.Append("  CallPlacedTime: ").Append(CallPlacedTime).Append("\n");
            
            sb.Append("  CallRoutedTime: ").Append(CallRoutedTime).Append("\n");
            
            sb.Append("  PreviewConnectedTime: ").Append(PreviewConnectedTime).Append("\n");
            
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            
            sb.Append("  Script: ").Append(Script).Append("\n");
            
            sb.Append("  Disposition: ").Append(Disposition).Append("\n");
            
            sb.Append("  CallerName: ").Append(CallerName).Append("\n");
            
            sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
            
            sb.Append("  PreviewPopDeliveredTime: ").Append(PreviewPopDeliveredTime).Append("\n");
            
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            
            sb.Append("  DialerSystemParticipantId: ").Append(DialerSystemParticipantId).Append("\n");
            
            sb.Append("  DialingMode: ").Append(DialingMode).Append("\n");
            
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            
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
            return this.Equals(obj as CampaignInteraction);
        }

        /// <summary>
        /// Returns true if CampaignInteraction instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignInteraction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignInteraction other)
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
                    this.Campaign == other.Campaign ||
                    this.Campaign != null &&
                    this.Campaign.Equals(other.Campaign)
                ) &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) &&
                (
                    this.DestinationAddress == other.DestinationAddress ||
                    this.DestinationAddress != null &&
                    this.DestinationAddress.Equals(other.DestinationAddress)
                ) &&
                (
                    this.ActivePreviewCall == other.ActivePreviewCall ||
                    this.ActivePreviewCall != null &&
                    this.ActivePreviewCall.Equals(other.ActivePreviewCall)
                ) &&
                (
                    this.LastActivePreviewWrapupTime == other.LastActivePreviewWrapupTime ||
                    this.LastActivePreviewWrapupTime != null &&
                    this.LastActivePreviewWrapupTime.Equals(other.LastActivePreviewWrapupTime)
                ) &&
                (
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
                ) &&
                (
                    this.CallPlacedTime == other.CallPlacedTime ||
                    this.CallPlacedTime != null &&
                    this.CallPlacedTime.Equals(other.CallPlacedTime)
                ) &&
                (
                    this.CallRoutedTime == other.CallRoutedTime ||
                    this.CallRoutedTime != null &&
                    this.CallRoutedTime.Equals(other.CallRoutedTime)
                ) &&
                (
                    this.PreviewConnectedTime == other.PreviewConnectedTime ||
                    this.PreviewConnectedTime != null &&
                    this.PreviewConnectedTime.Equals(other.PreviewConnectedTime)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Script == other.Script ||
                    this.Script != null &&
                    this.Script.Equals(other.Script)
                ) &&
                (
                    this.Disposition == other.Disposition ||
                    this.Disposition != null &&
                    this.Disposition.Equals(other.Disposition)
                ) &&
                (
                    this.CallerName == other.CallerName ||
                    this.CallerName != null &&
                    this.CallerName.Equals(other.CallerName)
                ) &&
                (
                    this.CallerAddress == other.CallerAddress ||
                    this.CallerAddress != null &&
                    this.CallerAddress.Equals(other.CallerAddress)
                ) &&
                (
                    this.PreviewPopDeliveredTime == other.PreviewPopDeliveredTime ||
                    this.PreviewPopDeliveredTime != null &&
                    this.PreviewPopDeliveredTime.Equals(other.PreviewPopDeliveredTime)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.DialerSystemParticipantId == other.DialerSystemParticipantId ||
                    this.DialerSystemParticipantId != null &&
                    this.DialerSystemParticipantId.Equals(other.DialerSystemParticipantId)
                ) &&
                (
                    this.DialingMode == other.DialingMode ||
                    this.DialingMode != null &&
                    this.DialingMode.Equals(other.DialingMode)
                ) &&
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
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
                
                if (this.Campaign != null)
                    hash = hash * 59 + this.Campaign.GetHashCode();
                
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();
                
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                
                if (this.DestinationAddress != null)
                    hash = hash * 59 + this.DestinationAddress.GetHashCode();
                
                if (this.ActivePreviewCall != null)
                    hash = hash * 59 + this.ActivePreviewCall.GetHashCode();
                
                if (this.LastActivePreviewWrapupTime != null)
                    hash = hash * 59 + this.LastActivePreviewWrapupTime.GetHashCode();
                
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                
                if (this.CallPlacedTime != null)
                    hash = hash * 59 + this.CallPlacedTime.GetHashCode();
                
                if (this.CallRoutedTime != null)
                    hash = hash * 59 + this.CallRoutedTime.GetHashCode();
                
                if (this.PreviewConnectedTime != null)
                    hash = hash * 59 + this.PreviewConnectedTime.GetHashCode();
                
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                
                if (this.Script != null)
                    hash = hash * 59 + this.Script.GetHashCode();
                
                if (this.Disposition != null)
                    hash = hash * 59 + this.Disposition.GetHashCode();
                
                if (this.CallerName != null)
                    hash = hash * 59 + this.CallerName.GetHashCode();
                
                if (this.CallerAddress != null)
                    hash = hash * 59 + this.CallerAddress.GetHashCode();
                
                if (this.PreviewPopDeliveredTime != null)
                    hash = hash * 59 + this.PreviewPopDeliveredTime.GetHashCode();
                
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                
                if (this.DialerSystemParticipantId != null)
                    hash = hash * 59 + this.DialerSystemParticipantId.GetHashCode();
                
                if (this.DialingMode != null)
                    hash = hash * 59 + this.DialingMode.GetHashCode();
                
                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();
                
                return hash;
            }
        }
    }

}
