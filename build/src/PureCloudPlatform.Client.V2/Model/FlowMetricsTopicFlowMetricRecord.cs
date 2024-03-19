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
    /// FlowMetricsTopicFlowMetricRecord
    /// </summary>
    [DataContract]
    public partial class FlowMetricsTopicFlowMetricRecord :  IEquatable<FlowMetricsTopicFlowMetricRecord>
    {
        /// <summary>
        /// Metric name
        /// </summary>
        /// <value>Metric name</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Nflow for "nFlow"
            /// </summary>
            [EnumMember(Value = "nFlow")]
            Nflow,
            
            /// <summary>
            /// Enum Nflowmilestone for "nFlowMilestone"
            /// </summary>
            [EnumMember(Value = "nFlowMilestone")]
            Nflowmilestone,
            
            /// <summary>
            /// Enum Nflowoutcome for "nFlowOutcome"
            /// </summary>
            [EnumMember(Value = "nFlowOutcome")]
            Nflowoutcome,
            
            /// <summary>
            /// Enum Nflowoutcomefailed for "nFlowOutcomeFailed"
            /// </summary>
            [EnumMember(Value = "nFlowOutcomeFailed")]
            Nflowoutcomefailed,
            
            /// <summary>
            /// Enum Oflowmilestone for "oFlowMilestone"
            /// </summary>
            [EnumMember(Value = "oFlowMilestone")]
            Oflowmilestone,
            
            /// <summary>
            /// Enum Tflow for "tFlow"
            /// </summary>
            [EnumMember(Value = "tFlow")]
            Tflow,
            
            /// <summary>
            /// Enum Tflowdisconnect for "tFlowDisconnect"
            /// </summary>
            [EnumMember(Value = "tFlowDisconnect")]
            Tflowdisconnect,
            
            /// <summary>
            /// Enum Tflowexit for "tFlowExit"
            /// </summary>
            [EnumMember(Value = "tFlowExit")]
            Tflowexit,
            
            /// <summary>
            /// Enum Tflowoutcome for "tFlowOutcome"
            /// </summary>
            [EnumMember(Value = "tFlowOutcome")]
            Tflowoutcome
        }
        /// <summary>
        /// Active routing method
        /// </summary>
        /// <value>Active routing method</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActiveRoutingEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bullseye for "Bullseye"
            /// </summary>
            [EnumMember(Value = "Bullseye")]
            Bullseye,
            
            /// <summary>
            /// Enum Conditional for "Conditional"
            /// </summary>
            [EnumMember(Value = "Conditional")]
            Conditional,
            
            /// <summary>
            /// Enum Direct for "Direct"
            /// </summary>
            [EnumMember(Value = "Direct")]
            Direct,
            
            /// <summary>
            /// Enum Last for "Last"
            /// </summary>
            [EnumMember(Value = "Last")]
            Last,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Predictive for "Predictive"
            /// </summary>
            [EnumMember(Value = "Predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "Preferred"
            /// </summary>
            [EnumMember(Value = "Preferred")]
            Preferred,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard,
            
            /// <summary>
            /// Enum Vip for "Vip"
            /// </summary>
            [EnumMember(Value = "Vip")]
            Vip
        }
        /// <summary>
        /// Indicates the participant purpose of the participant initiating a message conversation
        /// </summary>
        /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ConversationInitiatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Acd for "acd"
            /// </summary>
            [EnumMember(Value = "acd")]
            Acd,
            
            /// <summary>
            /// Enum Agent for "agent"
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent,
            
            /// <summary>
            /// Enum Api for "api"
            /// </summary>
            [EnumMember(Value = "api")]
            Api,
            
            /// <summary>
            /// Enum Botflow for "botflow"
            /// </summary>
            [EnumMember(Value = "botflow")]
            Botflow,
            
            /// <summary>
            /// Enum Campaign for "campaign"
            /// </summary>
            [EnumMember(Value = "campaign")]
            Campaign,
            
            /// <summary>
            /// Enum Customer for "customer"
            /// </summary>
            [EnumMember(Value = "customer")]
            Customer,
            
            /// <summary>
            /// Enum Dialer for "dialer"
            /// </summary>
            [EnumMember(Value = "dialer")]
            Dialer,
            
            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External,
            
            /// <summary>
            /// Enum Fax for "fax"
            /// </summary>
            [EnumMember(Value = "fax")]
            Fax,
            
            /// <summary>
            /// Enum Group for "group"
            /// </summary>
            [EnumMember(Value = "group")]
            Group,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Ivr for "ivr"
            /// </summary>
            [EnumMember(Value = "ivr")]
            Ivr,
            
            /// <summary>
            /// Enum Manual for "manual"
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Station for "station"
            /// </summary>
            [EnumMember(Value = "station")]
            Station,
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Workflow for "workflow"
            /// </summary>
            [EnumMember(Value = "workflow")]
            Workflow
        }
        /// <summary>
        /// The email or SMS delivery status
        /// </summary>
        /// <value>The email or SMS delivery status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DeliveryStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Deliveryfailed for "DeliveryFailed"
            /// </summary>
            [EnumMember(Value = "DeliveryFailed")]
            Deliveryfailed,
            
            /// <summary>
            /// Enum Deliverysuccess for "DeliverySuccess"
            /// </summary>
            [EnumMember(Value = "DeliverySuccess")]
            Deliverysuccess,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Read for "Read"
            /// </summary>
            [EnumMember(Value = "Read")]
            Read,
            
            /// <summary>
            /// Enum Received for "Received"
            /// </summary>
            [EnumMember(Value = "Received")]
            Received,
            
            /// <summary>
            /// Enum Sent for "Sent"
            /// </summary>
            [EnumMember(Value = "Sent")]
            Sent
        }
        /// <summary>
        /// The direction of the communication
        /// </summary>
        /// <value>The direction of the communication</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        /// <summary>
        /// The session disconnect type
        /// </summary>
        /// <value>The session disconnect type</value>
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
            /// Enum Client for "client"
            /// </summary>
            [EnumMember(Value = "client")]
            Client,
            
            /// <summary>
            /// Enum Conferencetransfer for "conferenceTransfer"
            /// </summary>
            [EnumMember(Value = "conferenceTransfer")]
            Conferencetransfer,
            
            /// <summary>
            /// Enum Consulttransfer for "consultTransfer"
            /// </summary>
            [EnumMember(Value = "consultTransfer")]
            Consulttransfer,
            
            /// <summary>
            /// Enum Endpoint for "endpoint"
            /// </summary>
            [EnumMember(Value = "endpoint")]
            Endpoint,
            
            /// <summary>
            /// Enum Endpointdnd for "endpointDnd"
            /// </summary>
            [EnumMember(Value = "endpointDnd")]
            Endpointdnd,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error,
            
            /// <summary>
            /// Enum Forwardtransfer for "forwardTransfer"
            /// </summary>
            [EnumMember(Value = "forwardTransfer")]
            Forwardtransfer,
            
            /// <summary>
            /// Enum Noanswertransfer for "noAnswerTransfer"
            /// </summary>
            [EnumMember(Value = "noAnswerTransfer")]
            Noanswertransfer,
            
            /// <summary>
            /// Enum Notavailabletransfer for "notAvailableTransfer"
            /// </summary>
            [EnumMember(Value = "notAvailableTransfer")]
            Notavailabletransfer,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other,
            
            /// <summary>
            /// Enum Peer for "peer"
            /// </summary>
            [EnumMember(Value = "peer")]
            Peer,
            
            /// <summary>
            /// Enum Spam for "spam"
            /// </summary>
            [EnumMember(Value = "spam")]
            Spam,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System,
            
            /// <summary>
            /// Enum Timeout for "timeout"
            /// </summary>
            [EnumMember(Value = "timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Transfer for "transfer"
            /// </summary>
            [EnumMember(Value = "transfer")]
            Transfer,
            
            /// <summary>
            /// Enum Transferdnd for "transferDnd"
            /// </summary>
            [EnumMember(Value = "transferDnd")]
            Transferdnd,
            
            /// <summary>
            /// Enum Transportfailure for "transportFailure"
            /// </summary>
            [EnumMember(Value = "transportFailure")]
            Transportfailure,
            
            /// <summary>
            /// Enum Uncallable for "uncallable"
            /// </summary>
            [EnumMember(Value = "uncallable")]
            Uncallable
        }
        /// <summary>
        /// The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct
        /// </summary>
        /// <value>The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntryTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agent for "agent"
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent,
            
            /// <summary>
            /// Enum Direct for "direct"
            /// </summary>
            [EnumMember(Value = "direct")]
            Direct,
            
            /// <summary>
            /// Enum Dnis for "dnis"
            /// </summary>
            [EnumMember(Value = "dnis")]
            Dnis,
            
            /// <summary>
            /// Enum Flow for "flow"
            /// </summary>
            [EnumMember(Value = "flow")]
            Flow,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        /// <summary>
        /// Reason for which participant flagged conversation
        /// </summary>
        /// <value>Reason for which participant flagged conversation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlaggedReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum General for "general"
            /// </summary>
            [EnumMember(Value = "general")]
            General
        }
        /// <summary>
        /// The type of this flow
        /// </summary>
        /// <value>The type of this flow</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlowTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bot for "bot"
            /// </summary>
            [EnumMember(Value = "bot")]
            Bot,
            
            /// <summary>
            /// Enum Commonmodule for "commonmodule"
            /// </summary>
            [EnumMember(Value = "commonmodule")]
            Commonmodule,
            
            /// <summary>
            /// Enum Digitalbot for "digitalbot"
            /// </summary>
            [EnumMember(Value = "digitalbot")]
            Digitalbot,
            
            /// <summary>
            /// Enum Inboundcall for "inboundcall"
            /// </summary>
            [EnumMember(Value = "inboundcall")]
            Inboundcall,
            
            /// <summary>
            /// Enum Inboundchat for "inboundchat"
            /// </summary>
            [EnumMember(Value = "inboundchat")]
            Inboundchat,
            
            /// <summary>
            /// Enum Inboundemail for "inboundemail"
            /// </summary>
            [EnumMember(Value = "inboundemail")]
            Inboundemail,
            
            /// <summary>
            /// Enum Inboundshortmessage for "inboundshortmessage"
            /// </summary>
            [EnumMember(Value = "inboundshortmessage")]
            Inboundshortmessage,
            
            /// <summary>
            /// Enum Inqueuecall for "inqueuecall"
            /// </summary>
            [EnumMember(Value = "inqueuecall")]
            Inqueuecall,
            
            /// <summary>
            /// Enum Inqueueemail for "inqueueemail"
            /// </summary>
            [EnumMember(Value = "inqueueemail")]
            Inqueueemail,
            
            /// <summary>
            /// Enum Inqueueshortmessage for "inqueueshortmessage"
            /// </summary>
            [EnumMember(Value = "inqueueshortmessage")]
            Inqueueshortmessage,
            
            /// <summary>
            /// Enum Outboundcall for "outboundcall"
            /// </summary>
            [EnumMember(Value = "outboundcall")]
            Outboundcall,
            
            /// <summary>
            /// Enum Securecall for "securecall"
            /// </summary>
            [EnumMember(Value = "securecall")]
            Securecall,
            
            /// <summary>
            /// Enum Speech for "speech"
            /// </summary>
            [EnumMember(Value = "speech")]
            Speech,
            
            /// <summary>
            /// Enum Surveyinvite for "surveyinvite"
            /// </summary>
            [EnumMember(Value = "surveyinvite")]
            Surveyinvite,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Voicesurvey for "voicesurvey"
            /// </summary>
            [EnumMember(Value = "voicesurvey")]
            Voicesurvey,
            
            /// <summary>
            /// Enum Workflow for "workflow"
            /// </summary>
            [EnumMember(Value = "workflow")]
            Workflow,
            
            /// <summary>
            /// Enum Workitem for "workitem"
            /// </summary>
            [EnumMember(Value = "workitem")]
            Workitem
        }
        /// <summary>
        /// The session media type
        /// </summary>
        /// <value>The session media type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Cobrowse for "cobrowse"
            /// </summary>
            [EnumMember(Value = "cobrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message,
            
            /// <summary>
            /// Enum Screenshare for "screenshare"
            /// </summary>
            [EnumMember(Value = "screenshare")]
            Screenshare,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Video for "video"
            /// </summary>
            [EnumMember(Value = "video")]
            Video,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice
        }
        /// <summary>
        /// The original direction of the conversation
        /// </summary>
        /// <value>The original direction of the conversation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OriginatingDirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        /// <summary>
        /// The participant's purpose
        /// </summary>
        /// <value>The participant's purpose</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PurposeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Acd for "acd"
            /// </summary>
            [EnumMember(Value = "acd")]
            Acd,
            
            /// <summary>
            /// Enum Agent for "agent"
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent,
            
            /// <summary>
            /// Enum Api for "api"
            /// </summary>
            [EnumMember(Value = "api")]
            Api,
            
            /// <summary>
            /// Enum Botflow for "botflow"
            /// </summary>
            [EnumMember(Value = "botflow")]
            Botflow,
            
            /// <summary>
            /// Enum Campaign for "campaign"
            /// </summary>
            [EnumMember(Value = "campaign")]
            Campaign,
            
            /// <summary>
            /// Enum Customer for "customer"
            /// </summary>
            [EnumMember(Value = "customer")]
            Customer,
            
            /// <summary>
            /// Enum Dialer for "dialer"
            /// </summary>
            [EnumMember(Value = "dialer")]
            Dialer,
            
            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External,
            
            /// <summary>
            /// Enum Fax for "fax"
            /// </summary>
            [EnumMember(Value = "fax")]
            Fax,
            
            /// <summary>
            /// Enum Group for "group"
            /// </summary>
            [EnumMember(Value = "group")]
            Group,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Ivr for "ivr"
            /// </summary>
            [EnumMember(Value = "ivr")]
            Ivr,
            
            /// <summary>
            /// Enum Manual for "manual"
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Station for "station"
            /// </summary>
            [EnumMember(Value = "station")]
            Station,
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Workflow for "workflow"
            /// </summary>
            [EnumMember(Value = "workflow")]
            Workflow
        }
        /// <summary>
        /// Gets or Sets RequestedRoutings
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RequestedRoutingsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bullseye for "Bullseye"
            /// </summary>
            [EnumMember(Value = "Bullseye")]
            Bullseye,
            
            /// <summary>
            /// Enum Conditional for "Conditional"
            /// </summary>
            [EnumMember(Value = "Conditional")]
            Conditional,
            
            /// <summary>
            /// Enum Direct for "Direct"
            /// </summary>
            [EnumMember(Value = "Direct")]
            Direct,
            
            /// <summary>
            /// Enum Last for "Last"
            /// </summary>
            [EnumMember(Value = "Last")]
            Last,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Predictive for "Predictive"
            /// </summary>
            [EnumMember(Value = "Predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "Preferred"
            /// </summary>
            [EnumMember(Value = "Preferred")]
            Preferred,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard,
            
            /// <summary>
            /// Enum Vip for "Vip"
            /// </summary>
            [EnumMember(Value = "Vip")]
            Vip
        }
        /// <summary>
        /// Routing rule type
        /// </summary>
        /// <value>Routing rule type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RoutingRuleTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bullseye for "Bullseye"
            /// </summary>
            [EnumMember(Value = "Bullseye")]
            Bullseye,
            
            /// <summary>
            /// Enum Conditional for "Conditional"
            /// </summary>
            [EnumMember(Value = "Conditional")]
            Conditional,
            
            /// <summary>
            /// Enum Predictive for "Predictive"
            /// </summary>
            [EnumMember(Value = "Predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "Preferred"
            /// </summary>
            [EnumMember(Value = "Preferred")]
            Preferred
        }
        /// <summary>
        /// Complete routing method
        /// </summary>
        /// <value>Complete routing method</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UsedRoutingEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bullseye for "Bullseye"
            /// </summary>
            [EnumMember(Value = "Bullseye")]
            Bullseye,
            
            /// <summary>
            /// Enum Conditional for "Conditional"
            /// </summary>
            [EnumMember(Value = "Conditional")]
            Conditional,
            
            /// <summary>
            /// Enum Direct for "Direct"
            /// </summary>
            [EnumMember(Value = "Direct")]
            Direct,
            
            /// <summary>
            /// Enum Last for "Last"
            /// </summary>
            [EnumMember(Value = "Last")]
            Last,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Predictive for "Predictive"
            /// </summary>
            [EnumMember(Value = "Predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "Preferred"
            /// </summary>
            [EnumMember(Value = "Preferred")]
            Preferred,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard,
            
            /// <summary>
            /// Enum Vip for "Vip"
            /// </summary>
            [EnumMember(Value = "Vip")]
            Vip
        }
        /// <summary>
        /// Metric name
        /// </summary>
        /// <value>Metric name</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        /// <summary>
        /// Active routing method
        /// </summary>
        /// <value>Active routing method</value>
        [DataMember(Name="activeRouting", EmitDefaultValue=false)]
        public ActiveRoutingEnum? ActiveRouting { get; set; }
        /// <summary>
        /// Indicates the participant purpose of the participant initiating a message conversation
        /// </summary>
        /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
        [DataMember(Name="conversationInitiator", EmitDefaultValue=false)]
        public ConversationInitiatorEnum? ConversationInitiator { get; set; }
        /// <summary>
        /// The email or SMS delivery status
        /// </summary>
        /// <value>The email or SMS delivery status</value>
        [DataMember(Name="deliveryStatus", EmitDefaultValue=false)]
        public DeliveryStatusEnum? DeliveryStatus { get; set; }
        /// <summary>
        /// The direction of the communication
        /// </summary>
        /// <value>The direction of the communication</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// The session disconnect type
        /// </summary>
        /// <value>The session disconnect type</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct
        /// </summary>
        /// <value>The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct</value>
        [DataMember(Name="entryType", EmitDefaultValue=false)]
        public EntryTypeEnum? EntryType { get; set; }
        /// <summary>
        /// Reason for which participant flagged conversation
        /// </summary>
        /// <value>Reason for which participant flagged conversation</value>
        [DataMember(Name="flaggedReason", EmitDefaultValue=false)]
        public FlaggedReasonEnum? FlaggedReason { get; set; }
        /// <summary>
        /// The type of this flow
        /// </summary>
        /// <value>The type of this flow</value>
        [DataMember(Name="flowType", EmitDefaultValue=false)]
        public FlowTypeEnum? FlowType { get; set; }
        /// <summary>
        /// The session media type
        /// </summary>
        /// <value>The session media type</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// The original direction of the conversation
        /// </summary>
        /// <value>The original direction of the conversation</value>
        [DataMember(Name="originatingDirection", EmitDefaultValue=false)]
        public OriginatingDirectionEnum? OriginatingDirection { get; set; }
        /// <summary>
        /// The participant's purpose
        /// </summary>
        /// <value>The participant's purpose</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public PurposeEnum? Purpose { get; set; }
        /// <summary>
        /// Routing rule type
        /// </summary>
        /// <value>Routing rule type</value>
        [DataMember(Name="routingRuleType", EmitDefaultValue=false)]
        public RoutingRuleTypeEnum? RoutingRuleType { get; set; }
        /// <summary>
        /// Complete routing method
        /// </summary>
        /// <value>Complete routing method</value>
        [DataMember(Name="usedRouting", EmitDefaultValue=false)]
        public UsedRoutingEnum? UsedRouting { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowMetricsTopicFlowMetricRecord" /> class.
        /// </summary>
        /// <param name="Metric">Metric name.</param>
        /// <param name="MetricDate">The date and time of metric creation.</param>
        /// <param name="Value">Metric value.</param>
        /// <param name="RecordId">Record identifier.</param>
        /// <param name="ActiveRouting">Active routing method.</param>
        /// <param name="ActiveSkillIds">ID(s) of Skill(s) that are active on the conversation.</param>
        /// <param name="AddressFrom">The address that initiated an action.</param>
        /// <param name="AddressTo">The address receiving an action.</param>
        /// <param name="AgentAssistantId">Unique identifier of the active virtual agent assistant.</param>
        /// <param name="AgentBullseyeRing">Bullseye ring of the targeted agent.</param>
        /// <param name="AgentOwned">Flag indicating an agent-owned callback.</param>
        /// <param name="Ani">Automatic Number Identification (caller's number).</param>
        /// <param name="AssignerId">ID of the user that manually assigned a conversation.</param>
        /// <param name="Authenticated">Flag that indicates that the identity of the customer has been asserted as verified by the provider..</param>
        /// <param name="ConversationId">Unique identifier for the conversation.</param>
        /// <param name="ConversationInitiator">Indicates the participant purpose of the participant initiating a message conversation.</param>
        /// <param name="ConvertedFrom">Session media type that was converted from in case of a media type conversion.</param>
        /// <param name="ConvertedTo">Session media type that was converted to in case of a media type conversion.</param>
        /// <param name="CustomerParticipation">Indicates a messaging conversation in which the customer participated by sending at least one message.</param>
        /// <param name="DeliveryStatus">The email or SMS delivery status.</param>
        /// <param name="DestinationAddresses">Destination address(es) of transfers or consults.</param>
        /// <param name="Direction">The direction of the communication.</param>
        /// <param name="DisconnectType">The session disconnect type.</param>
        /// <param name="DivisionIds">Identifier(s) of division(s) associated with a conversation.</param>
        /// <param name="Dnis">Dialed number identification service (number dialed by the calling party).</param>
        /// <param name="EdgeId">Unique identifier of the edge device.</param>
        /// <param name="EligibleAgentCounts">Number of eligible agents for each predictive routing attempt.</param>
        /// <param name="EndingLanguage">Flow ending language, e.g. en-us.</param>
        /// <param name="EntryReason">The particular entry reason for this flow, e.g. an address, userId, or flowId.</param>
        /// <param name="EntryType">The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct.</param>
        /// <param name="ErrorCode">A code corresponding to the error that occurred.</param>
        /// <param name="ExitReason">The exit reason for this flow, e.g. DISCONNECT.</param>
        /// <param name="ExtendedDeliveryStatus">Extended delivery status.</param>
        /// <param name="ExternalContactId">External contact identifier.</param>
        /// <param name="ExternalMediaCount">Count of any media (images, files, etc) included on the external session.</param>
        /// <param name="ExternalOrganizationId">External organization identifier.</param>
        /// <param name="ExternalTag">External tag for the conversation.</param>
        /// <param name="FirstQueue">Marker that is set if the current queue is the first queue in a conversation.</param>
        /// <param name="FlaggedReason">Reason for which participant flagged conversation.</param>
        /// <param name="FlowId">The unique identifier of this flow.</param>
        /// <param name="FlowInType">Type of flow in that occurred when entering ACD..</param>
        /// <param name="FlowMilestoneIds">The ID of a flow outcome milestone.</param>
        /// <param name="FlowName">The name of this flow at the time of flow execution.</param>
        /// <param name="FlowOutType">Type of flow out that occurred when emitting tFlowOut..</param>
        /// <param name="FlowType">The type of this flow.</param>
        /// <param name="FlowVersion">The version of this flow.</param>
        /// <param name="GroupId">Unique identifier for a PureCloud group.</param>
        /// <param name="InteractionType">The interaction type (enterprise or contactCenter).</param>
        /// <param name="JourneyActionId">Identifier of the journey action..</param>
        /// <param name="JourneyActionMapId">Identifier of the journey action map that triggered the action..</param>
        /// <param name="JourneyActionMapVersion">Version of the journey action map that triggered the action..</param>
        /// <param name="JourneyCustomerId">Primary identifier of the journey customer in the source where the activities originate from..</param>
        /// <param name="JourneyCustomerIdType">Type of primary identifier of the journey customer (e.g. cookie)..</param>
        /// <param name="JourneyCustomerSessionId">Unique identifier of the journey session..</param>
        /// <param name="JourneyCustomerSessionIdType">Type or category of journey sessions (e.g. web, ticket, delivery, atm)..</param>
        /// <param name="KnowledgeBaseId">The unique identifier of the knowledge base used.</param>
        /// <param name="MediaCount">Count of any media (images, files, etc) included in this session.</param>
        /// <param name="MediaType">The session media type.</param>
        /// <param name="MessageType">Message type for messaging services. E.g.: sms, facebook, twitter, line.</param>
        /// <param name="OriginatingDirection">The original direction of the conversation.</param>
        /// <param name="OutboundCampaignId">(Dialer) Unique identifier of the outbound campaign.</param>
        /// <param name="OutboundContactId">(Dialer) Unique identifier of the contact.</param>
        /// <param name="OutboundContactListId">(Dialer) Unique identifier of the contact list that this contact belongs to.</param>
        /// <param name="ParticipantName">A human readable name identifying the participant.</param>
        /// <param name="PeerId">This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session..</param>
        /// <param name="Provider">The source provider for the communication..</param>
        /// <param name="Purpose">The participant's purpose.</param>
        /// <param name="QueueId">Queue identifier.</param>
        /// <param name="RecognitionFailureReason">The recognition failure reason causing to exit/disconnect.</param>
        /// <param name="Remote">Name, phone number, or email address of the remote party..</param>
        /// <param name="RemovedSkillIds">ID(s) of Skill(s) that have been removed by bullseye routing.</param>
        /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
        /// <param name="RequestedRoutingSkillIds">Unique identifier(s) for skill(s) requested for an interaction.</param>
        /// <param name="RequestedRoutings">Routing type(s) for requested/attempted routing methods..</param>
        /// <param name="RoomId">Unique identifier for the room.</param>
        /// <param name="RoutingPriority">Routing priority for the current interaction.</param>
        /// <param name="RoutingRing">Routing ring for bullseye or preferred agent routing.</param>
        /// <param name="RoutingRule">Routing rule for preferred, conditional and predictive routing type.</param>
        /// <param name="RoutingRuleType">Routing rule type.</param>
        /// <param name="SelectedAgentId">Selected agent ID.</param>
        /// <param name="SelectedAgentRank">Selected agent GPR rank.</param>
        /// <param name="SelfServed">Indicates whether the flow session was self serviced.</param>
        /// <param name="SessionDnis">Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred.</param>
        /// <param name="SessionId">The unique identifier of this session.</param>
        /// <param name="StartingLanguage">Flow starting language, e.g. en-us.</param>
        /// <param name="StationId">Unique identifier for a phone.</param>
        /// <param name="TeamId">The team ID the user is a member of.</param>
        /// <param name="TransferTargetAddress">The address of a flow transfer target, e.g. a phone number, an email address, or a queueId.</param>
        /// <param name="TransferTargetName">The name of a flow transfer target.</param>
        /// <param name="TransferType">The type of transfer for flows that ended with a transfer.</param>
        /// <param name="UsedRouting">Complete routing method.</param>
        /// <param name="UserId">Unique identifier for the user.</param>
        /// <param name="WaitingInteractionCounts">Number of waiting interactions for each predictive routing attempt.</param>
        /// <param name="WrapUpCode">Wrap up code.</param>
        /// <param name="ProposedAgents">Proposed agents.</param>
        /// <param name="Outcomes">Flow outcomes.</param>
        /// <param name="ScoredAgents">Scored agents.</param>
        public FlowMetricsTopicFlowMetricRecord(MetricEnum? Metric = null, DateTime? MetricDate = null, int? Value = null, string RecordId = null, ActiveRoutingEnum? ActiveRouting = null, List<string> ActiveSkillIds = null, string AddressFrom = null, string AddressTo = null, string AgentAssistantId = null, int? AgentBullseyeRing = null, bool? AgentOwned = null, string Ani = null, string AssignerId = null, bool? Authenticated = null, string ConversationId = null, ConversationInitiatorEnum? ConversationInitiator = null, string ConvertedFrom = null, string ConvertedTo = null, bool? CustomerParticipation = null, DeliveryStatusEnum? DeliveryStatus = null, List<string> DestinationAddresses = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, List<string> DivisionIds = null, string Dnis = null, string EdgeId = null, List<int?> EligibleAgentCounts = null, string EndingLanguage = null, string EntryReason = null, EntryTypeEnum? EntryType = null, string ErrorCode = null, string ExitReason = null, string ExtendedDeliveryStatus = null, string ExternalContactId = null, int? ExternalMediaCount = null, string ExternalOrganizationId = null, string ExternalTag = null, bool? FirstQueue = null, FlaggedReasonEnum? FlaggedReason = null, string FlowId = null, string FlowInType = null, List<string> FlowMilestoneIds = null, string FlowName = null, string FlowOutType = null, FlowTypeEnum? FlowType = null, string FlowVersion = null, string GroupId = null, string InteractionType = null, string JourneyActionId = null, string JourneyActionMapId = null, int? JourneyActionMapVersion = null, string JourneyCustomerId = null, string JourneyCustomerIdType = null, string JourneyCustomerSessionId = null, string JourneyCustomerSessionIdType = null, string KnowledgeBaseId = null, int? MediaCount = null, MediaTypeEnum? MediaType = null, string MessageType = null, OriginatingDirectionEnum? OriginatingDirection = null, string OutboundCampaignId = null, string OutboundContactId = null, string OutboundContactListId = null, string ParticipantName = null, string PeerId = null, string Provider = null, PurposeEnum? Purpose = null, string QueueId = null, string RecognitionFailureReason = null, string Remote = null, List<string> RemovedSkillIds = null, string RequestedLanguageId = null, List<string> RequestedRoutingSkillIds = null, List<RequestedRoutingsEnum> RequestedRoutings = null, string RoomId = null, int? RoutingPriority = null, int? RoutingRing = null, string RoutingRule = null, RoutingRuleTypeEnum? RoutingRuleType = null, string SelectedAgentId = null, int? SelectedAgentRank = null, bool? SelfServed = null, string SessionDnis = null, string SessionId = null, string StartingLanguage = null, string StationId = null, string TeamId = null, string TransferTargetAddress = null, string TransferTargetName = null, string TransferType = null, UsedRoutingEnum? UsedRouting = null, string UserId = null, List<int?> WaitingInteractionCounts = null, string WrapUpCode = null, List<FlowMetricsTopicFlowProposedAgent> ProposedAgents = null, List<FlowMetricsTopicFlowOutcome> Outcomes = null, List<FlowMetricsTopicFlowScoredAgent> ScoredAgents = null)
        {
            this.Metric = Metric;
            this.MetricDate = MetricDate;
            this.Value = Value;
            this.RecordId = RecordId;
            this.ActiveRouting = ActiveRouting;
            this.ActiveSkillIds = ActiveSkillIds;
            this.AddressFrom = AddressFrom;
            this.AddressTo = AddressTo;
            this.AgentAssistantId = AgentAssistantId;
            this.AgentBullseyeRing = AgentBullseyeRing;
            this.AgentOwned = AgentOwned;
            this.Ani = Ani;
            this.AssignerId = AssignerId;
            this.Authenticated = Authenticated;
            this.ConversationId = ConversationId;
            this.ConversationInitiator = ConversationInitiator;
            this.ConvertedFrom = ConvertedFrom;
            this.ConvertedTo = ConvertedTo;
            this.CustomerParticipation = CustomerParticipation;
            this.DeliveryStatus = DeliveryStatus;
            this.DestinationAddresses = DestinationAddresses;
            this.Direction = Direction;
            this.DisconnectType = DisconnectType;
            this.DivisionIds = DivisionIds;
            this.Dnis = Dnis;
            this.EdgeId = EdgeId;
            this.EligibleAgentCounts = EligibleAgentCounts;
            this.EndingLanguage = EndingLanguage;
            this.EntryReason = EntryReason;
            this.EntryType = EntryType;
            this.ErrorCode = ErrorCode;
            this.ExitReason = ExitReason;
            this.ExtendedDeliveryStatus = ExtendedDeliveryStatus;
            this.ExternalContactId = ExternalContactId;
            this.ExternalMediaCount = ExternalMediaCount;
            this.ExternalOrganizationId = ExternalOrganizationId;
            this.ExternalTag = ExternalTag;
            this.FirstQueue = FirstQueue;
            this.FlaggedReason = FlaggedReason;
            this.FlowId = FlowId;
            this.FlowInType = FlowInType;
            this.FlowMilestoneIds = FlowMilestoneIds;
            this.FlowName = FlowName;
            this.FlowOutType = FlowOutType;
            this.FlowType = FlowType;
            this.FlowVersion = FlowVersion;
            this.GroupId = GroupId;
            this.InteractionType = InteractionType;
            this.JourneyActionId = JourneyActionId;
            this.JourneyActionMapId = JourneyActionMapId;
            this.JourneyActionMapVersion = JourneyActionMapVersion;
            this.JourneyCustomerId = JourneyCustomerId;
            this.JourneyCustomerIdType = JourneyCustomerIdType;
            this.JourneyCustomerSessionId = JourneyCustomerSessionId;
            this.JourneyCustomerSessionIdType = JourneyCustomerSessionIdType;
            this.KnowledgeBaseId = KnowledgeBaseId;
            this.MediaCount = MediaCount;
            this.MediaType = MediaType;
            this.MessageType = MessageType;
            this.OriginatingDirection = OriginatingDirection;
            this.OutboundCampaignId = OutboundCampaignId;
            this.OutboundContactId = OutboundContactId;
            this.OutboundContactListId = OutboundContactListId;
            this.ParticipantName = ParticipantName;
            this.PeerId = PeerId;
            this.Provider = Provider;
            this.Purpose = Purpose;
            this.QueueId = QueueId;
            this.RecognitionFailureReason = RecognitionFailureReason;
            this.Remote = Remote;
            this.RemovedSkillIds = RemovedSkillIds;
            this.RequestedLanguageId = RequestedLanguageId;
            this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
            this.RequestedRoutings = RequestedRoutings;
            this.RoomId = RoomId;
            this.RoutingPriority = RoutingPriority;
            this.RoutingRing = RoutingRing;
            this.RoutingRule = RoutingRule;
            this.RoutingRuleType = RoutingRuleType;
            this.SelectedAgentId = SelectedAgentId;
            this.SelectedAgentRank = SelectedAgentRank;
            this.SelfServed = SelfServed;
            this.SessionDnis = SessionDnis;
            this.SessionId = SessionId;
            this.StartingLanguage = StartingLanguage;
            this.StationId = StationId;
            this.TeamId = TeamId;
            this.TransferTargetAddress = TransferTargetAddress;
            this.TransferTargetName = TransferTargetName;
            this.TransferType = TransferType;
            this.UsedRouting = UsedRouting;
            this.UserId = UserId;
            this.WaitingInteractionCounts = WaitingInteractionCounts;
            this.WrapUpCode = WrapUpCode;
            this.ProposedAgents = ProposedAgents;
            this.Outcomes = Outcomes;
            this.ScoredAgents = ScoredAgents;
            
        }
        




        /// <summary>
        /// The date and time of metric creation
        /// </summary>
        /// <value>The date and time of metric creation</value>
        [DataMember(Name="metricDate", EmitDefaultValue=false)]
        public DateTime? MetricDate { get; set; }



        /// <summary>
        /// Metric value
        /// </summary>
        /// <value>Metric value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }



        /// <summary>
        /// Record identifier
        /// </summary>
        /// <value>Record identifier</value>
        [DataMember(Name="recordId", EmitDefaultValue=false)]
        public string RecordId { get; set; }





        /// <summary>
        /// ID(s) of Skill(s) that are active on the conversation
        /// </summary>
        /// <value>ID(s) of Skill(s) that are active on the conversation</value>
        [DataMember(Name="activeSkillIds", EmitDefaultValue=false)]
        public List<string> ActiveSkillIds { get; set; }



        /// <summary>
        /// The address that initiated an action
        /// </summary>
        /// <value>The address that initiated an action</value>
        [DataMember(Name="addressFrom", EmitDefaultValue=false)]
        public string AddressFrom { get; set; }



        /// <summary>
        /// The address receiving an action
        /// </summary>
        /// <value>The address receiving an action</value>
        [DataMember(Name="addressTo", EmitDefaultValue=false)]
        public string AddressTo { get; set; }



        /// <summary>
        /// Unique identifier of the active virtual agent assistant
        /// </summary>
        /// <value>Unique identifier of the active virtual agent assistant</value>
        [DataMember(Name="agentAssistantId", EmitDefaultValue=false)]
        public string AgentAssistantId { get; set; }



        /// <summary>
        /// Bullseye ring of the targeted agent
        /// </summary>
        /// <value>Bullseye ring of the targeted agent</value>
        [DataMember(Name="agentBullseyeRing", EmitDefaultValue=false)]
        public int? AgentBullseyeRing { get; set; }



        /// <summary>
        /// Flag indicating an agent-owned callback
        /// </summary>
        /// <value>Flag indicating an agent-owned callback</value>
        [DataMember(Name="agentOwned", EmitDefaultValue=false)]
        public bool? AgentOwned { get; set; }



        /// <summary>
        /// Automatic Number Identification (caller's number)
        /// </summary>
        /// <value>Automatic Number Identification (caller's number)</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }



        /// <summary>
        /// ID of the user that manually assigned a conversation
        /// </summary>
        /// <value>ID of the user that manually assigned a conversation</value>
        [DataMember(Name="assignerId", EmitDefaultValue=false)]
        public string AssignerId { get; set; }



        /// <summary>
        /// Flag that indicates that the identity of the customer has been asserted as verified by the provider.
        /// </summary>
        /// <value>Flag that indicates that the identity of the customer has been asserted as verified by the provider.</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }



        /// <summary>
        /// Unique identifier for the conversation
        /// </summary>
        /// <value>Unique identifier for the conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }





        /// <summary>
        /// Session media type that was converted from in case of a media type conversion
        /// </summary>
        /// <value>Session media type that was converted from in case of a media type conversion</value>
        [DataMember(Name="convertedFrom", EmitDefaultValue=false)]
        public string ConvertedFrom { get; set; }



        /// <summary>
        /// Session media type that was converted to in case of a media type conversion
        /// </summary>
        /// <value>Session media type that was converted to in case of a media type conversion</value>
        [DataMember(Name="convertedTo", EmitDefaultValue=false)]
        public string ConvertedTo { get; set; }



        /// <summary>
        /// Indicates a messaging conversation in which the customer participated by sending at least one message
        /// </summary>
        /// <value>Indicates a messaging conversation in which the customer participated by sending at least one message</value>
        [DataMember(Name="customerParticipation", EmitDefaultValue=false)]
        public bool? CustomerParticipation { get; set; }





        /// <summary>
        /// Destination address(es) of transfers or consults
        /// </summary>
        /// <value>Destination address(es) of transfers or consults</value>
        [DataMember(Name="destinationAddresses", EmitDefaultValue=false)]
        public List<string> DestinationAddresses { get; set; }







        /// <summary>
        /// Identifier(s) of division(s) associated with a conversation
        /// </summary>
        /// <value>Identifier(s) of division(s) associated with a conversation</value>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }



        /// <summary>
        /// Dialed number identification service (number dialed by the calling party)
        /// </summary>
        /// <value>Dialed number identification service (number dialed by the calling party)</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }



        /// <summary>
        /// Unique identifier of the edge device
        /// </summary>
        /// <value>Unique identifier of the edge device</value>
        [DataMember(Name="edgeId", EmitDefaultValue=false)]
        public string EdgeId { get; set; }



        /// <summary>
        /// Number of eligible agents for each predictive routing attempt
        /// </summary>
        /// <value>Number of eligible agents for each predictive routing attempt</value>
        [DataMember(Name="eligibleAgentCounts", EmitDefaultValue=false)]
        public List<int?> EligibleAgentCounts { get; set; }



        /// <summary>
        /// Flow ending language, e.g. en-us
        /// </summary>
        /// <value>Flow ending language, e.g. en-us</value>
        [DataMember(Name="endingLanguage", EmitDefaultValue=false)]
        public string EndingLanguage { get; set; }



        /// <summary>
        /// The particular entry reason for this flow, e.g. an address, userId, or flowId
        /// </summary>
        /// <value>The particular entry reason for this flow, e.g. an address, userId, or flowId</value>
        [DataMember(Name="entryReason", EmitDefaultValue=false)]
        public string EntryReason { get; set; }





        /// <summary>
        /// A code corresponding to the error that occurred
        /// </summary>
        /// <value>A code corresponding to the error that occurred</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// The exit reason for this flow, e.g. DISCONNECT
        /// </summary>
        /// <value>The exit reason for this flow, e.g. DISCONNECT</value>
        [DataMember(Name="exitReason", EmitDefaultValue=false)]
        public string ExitReason { get; set; }



        /// <summary>
        /// Extended delivery status
        /// </summary>
        /// <value>Extended delivery status</value>
        [DataMember(Name="extendedDeliveryStatus", EmitDefaultValue=false)]
        public string ExtendedDeliveryStatus { get; set; }



        /// <summary>
        /// External contact identifier
        /// </summary>
        /// <value>External contact identifier</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }



        /// <summary>
        /// Count of any media (images, files, etc) included on the external session
        /// </summary>
        /// <value>Count of any media (images, files, etc) included on the external session</value>
        [DataMember(Name="externalMediaCount", EmitDefaultValue=false)]
        public int? ExternalMediaCount { get; set; }



        /// <summary>
        /// External organization identifier
        /// </summary>
        /// <value>External organization identifier</value>
        [DataMember(Name="externalOrganizationId", EmitDefaultValue=false)]
        public string ExternalOrganizationId { get; set; }



        /// <summary>
        /// External tag for the conversation
        /// </summary>
        /// <value>External tag for the conversation</value>
        [DataMember(Name="externalTag", EmitDefaultValue=false)]
        public string ExternalTag { get; set; }



        /// <summary>
        /// Marker that is set if the current queue is the first queue in a conversation
        /// </summary>
        /// <value>Marker that is set if the current queue is the first queue in a conversation</value>
        [DataMember(Name="firstQueue", EmitDefaultValue=false)]
        public bool? FirstQueue { get; set; }





        /// <summary>
        /// The unique identifier of this flow
        /// </summary>
        /// <value>The unique identifier of this flow</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public string FlowId { get; set; }



        /// <summary>
        /// Type of flow in that occurred when entering ACD.
        /// </summary>
        /// <value>Type of flow in that occurred when entering ACD.</value>
        [DataMember(Name="flowInType", EmitDefaultValue=false)]
        public string FlowInType { get; set; }



        /// <summary>
        /// The ID of a flow outcome milestone
        /// </summary>
        /// <value>The ID of a flow outcome milestone</value>
        [DataMember(Name="flowMilestoneIds", EmitDefaultValue=false)]
        public List<string> FlowMilestoneIds { get; set; }



        /// <summary>
        /// The name of this flow at the time of flow execution
        /// </summary>
        /// <value>The name of this flow at the time of flow execution</value>
        [DataMember(Name="flowName", EmitDefaultValue=false)]
        public string FlowName { get; set; }



        /// <summary>
        /// Type of flow out that occurred when emitting tFlowOut.
        /// </summary>
        /// <value>Type of flow out that occurred when emitting tFlowOut.</value>
        [DataMember(Name="flowOutType", EmitDefaultValue=false)]
        public string FlowOutType { get; set; }





        /// <summary>
        /// The version of this flow
        /// </summary>
        /// <value>The version of this flow</value>
        [DataMember(Name="flowVersion", EmitDefaultValue=false)]
        public string FlowVersion { get; set; }



        /// <summary>
        /// Unique identifier for a PureCloud group
        /// </summary>
        /// <value>Unique identifier for a PureCloud group</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }



        /// <summary>
        /// The interaction type (enterprise or contactCenter)
        /// </summary>
        /// <value>The interaction type (enterprise or contactCenter)</value>
        [DataMember(Name="interactionType", EmitDefaultValue=false)]
        public string InteractionType { get; set; }



        /// <summary>
        /// Identifier of the journey action.
        /// </summary>
        /// <value>Identifier of the journey action.</value>
        [DataMember(Name="journeyActionId", EmitDefaultValue=false)]
        public string JourneyActionId { get; set; }



        /// <summary>
        /// Identifier of the journey action map that triggered the action.
        /// </summary>
        /// <value>Identifier of the journey action map that triggered the action.</value>
        [DataMember(Name="journeyActionMapId", EmitDefaultValue=false)]
        public string JourneyActionMapId { get; set; }



        /// <summary>
        /// Version of the journey action map that triggered the action.
        /// </summary>
        /// <value>Version of the journey action map that triggered the action.</value>
        [DataMember(Name="journeyActionMapVersion", EmitDefaultValue=false)]
        public int? JourneyActionMapVersion { get; set; }



        /// <summary>
        /// Primary identifier of the journey customer in the source where the activities originate from.
        /// </summary>
        /// <value>Primary identifier of the journey customer in the source where the activities originate from.</value>
        [DataMember(Name="journeyCustomerId", EmitDefaultValue=false)]
        public string JourneyCustomerId { get; set; }



        /// <summary>
        /// Type of primary identifier of the journey customer (e.g. cookie).
        /// </summary>
        /// <value>Type of primary identifier of the journey customer (e.g. cookie).</value>
        [DataMember(Name="journeyCustomerIdType", EmitDefaultValue=false)]
        public string JourneyCustomerIdType { get; set; }



        /// <summary>
        /// Unique identifier of the journey session.
        /// </summary>
        /// <value>Unique identifier of the journey session.</value>
        [DataMember(Name="journeyCustomerSessionId", EmitDefaultValue=false)]
        public string JourneyCustomerSessionId { get; set; }



        /// <summary>
        /// Type or category of journey sessions (e.g. web, ticket, delivery, atm).
        /// </summary>
        /// <value>Type or category of journey sessions (e.g. web, ticket, delivery, atm).</value>
        [DataMember(Name="journeyCustomerSessionIdType", EmitDefaultValue=false)]
        public string JourneyCustomerSessionIdType { get; set; }



        /// <summary>
        /// The unique identifier of the knowledge base used
        /// </summary>
        /// <value>The unique identifier of the knowledge base used</value>
        [DataMember(Name="knowledgeBaseId", EmitDefaultValue=false)]
        public string KnowledgeBaseId { get; set; }



        /// <summary>
        /// Count of any media (images, files, etc) included in this session
        /// </summary>
        /// <value>Count of any media (images, files, etc) included in this session</value>
        [DataMember(Name="mediaCount", EmitDefaultValue=false)]
        public int? MediaCount { get; set; }





        /// <summary>
        /// Message type for messaging services. E.g.: sms, facebook, twitter, line
        /// </summary>
        /// <value>Message type for messaging services. E.g.: sms, facebook, twitter, line</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public string MessageType { get; set; }





        /// <summary>
        /// (Dialer) Unique identifier of the outbound campaign
        /// </summary>
        /// <value>(Dialer) Unique identifier of the outbound campaign</value>
        [DataMember(Name="outboundCampaignId", EmitDefaultValue=false)]
        public string OutboundCampaignId { get; set; }



        /// <summary>
        /// (Dialer) Unique identifier of the contact
        /// </summary>
        /// <value>(Dialer) Unique identifier of the contact</value>
        [DataMember(Name="outboundContactId", EmitDefaultValue=false)]
        public string OutboundContactId { get; set; }



        /// <summary>
        /// (Dialer) Unique identifier of the contact list that this contact belongs to
        /// </summary>
        /// <value>(Dialer) Unique identifier of the contact list that this contact belongs to</value>
        [DataMember(Name="outboundContactListId", EmitDefaultValue=false)]
        public string OutboundContactListId { get; set; }



        /// <summary>
        /// A human readable name identifying the participant
        /// </summary>
        /// <value>A human readable name identifying the participant</value>
        [DataMember(Name="participantName", EmitDefaultValue=false)]
        public string ParticipantName { get; set; }



        /// <summary>
        /// This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.
        /// </summary>
        /// <value>This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.</value>
        [DataMember(Name="peerId", EmitDefaultValue=false)]
        public string PeerId { get; set; }



        /// <summary>
        /// The source provider for the communication.
        /// </summary>
        /// <value>The source provider for the communication.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }





        /// <summary>
        /// Queue identifier
        /// </summary>
        /// <value>Queue identifier</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The recognition failure reason causing to exit/disconnect
        /// </summary>
        /// <value>The recognition failure reason causing to exit/disconnect</value>
        [DataMember(Name="recognitionFailureReason", EmitDefaultValue=false)]
        public string RecognitionFailureReason { get; set; }



        /// <summary>
        /// Name, phone number, or email address of the remote party.
        /// </summary>
        /// <value>Name, phone number, or email address of the remote party.</value>
        [DataMember(Name="remote", EmitDefaultValue=false)]
        public string Remote { get; set; }



        /// <summary>
        /// ID(s) of Skill(s) that have been removed by bullseye routing
        /// </summary>
        /// <value>ID(s) of Skill(s) that have been removed by bullseye routing</value>
        [DataMember(Name="removedSkillIds", EmitDefaultValue=false)]
        public List<string> RemovedSkillIds { get; set; }



        /// <summary>
        /// Unique identifier for the language requested for an interaction
        /// </summary>
        /// <value>Unique identifier for the language requested for an interaction</value>
        [DataMember(Name="requestedLanguageId", EmitDefaultValue=false)]
        public string RequestedLanguageId { get; set; }



        /// <summary>
        /// Unique identifier(s) for skill(s) requested for an interaction
        /// </summary>
        /// <value>Unique identifier(s) for skill(s) requested for an interaction</value>
        [DataMember(Name="requestedRoutingSkillIds", EmitDefaultValue=false)]
        public List<string> RequestedRoutingSkillIds { get; set; }



        /// <summary>
        /// Routing type(s) for requested/attempted routing methods.
        /// </summary>
        /// <value>Routing type(s) for requested/attempted routing methods.</value>
        [DataMember(Name="requestedRoutings", EmitDefaultValue=false)]
        public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }



        /// <summary>
        /// Unique identifier for the room
        /// </summary>
        /// <value>Unique identifier for the room</value>
        [DataMember(Name="roomId", EmitDefaultValue=false)]
        public string RoomId { get; set; }



        /// <summary>
        /// Routing priority for the current interaction
        /// </summary>
        /// <value>Routing priority for the current interaction</value>
        [DataMember(Name="routingPriority", EmitDefaultValue=false)]
        public int? RoutingPriority { get; set; }



        /// <summary>
        /// Routing ring for bullseye or preferred agent routing
        /// </summary>
        /// <value>Routing ring for bullseye or preferred agent routing</value>
        [DataMember(Name="routingRing", EmitDefaultValue=false)]
        public int? RoutingRing { get; set; }



        /// <summary>
        /// Routing rule for preferred, conditional and predictive routing type
        /// </summary>
        /// <value>Routing rule for preferred, conditional and predictive routing type</value>
        [DataMember(Name="routingRule", EmitDefaultValue=false)]
        public string RoutingRule { get; set; }





        /// <summary>
        /// Selected agent ID
        /// </summary>
        /// <value>Selected agent ID</value>
        [DataMember(Name="selectedAgentId", EmitDefaultValue=false)]
        public string SelectedAgentId { get; set; }



        /// <summary>
        /// Selected agent GPR rank
        /// </summary>
        /// <value>Selected agent GPR rank</value>
        [DataMember(Name="selectedAgentRank", EmitDefaultValue=false)]
        public int? SelectedAgentRank { get; set; }



        /// <summary>
        /// Indicates whether the flow session was self serviced
        /// </summary>
        /// <value>Indicates whether the flow session was self serviced</value>
        [DataMember(Name="selfServed", EmitDefaultValue=false)]
        public bool? SelfServed { get; set; }



        /// <summary>
        /// Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred
        /// </summary>
        /// <value>Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred</value>
        [DataMember(Name="sessionDnis", EmitDefaultValue=false)]
        public string SessionDnis { get; set; }



        /// <summary>
        /// The unique identifier of this session
        /// </summary>
        /// <value>The unique identifier of this session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// Flow starting language, e.g. en-us
        /// </summary>
        /// <value>Flow starting language, e.g. en-us</value>
        [DataMember(Name="startingLanguage", EmitDefaultValue=false)]
        public string StartingLanguage { get; set; }



        /// <summary>
        /// Unique identifier for a phone
        /// </summary>
        /// <value>Unique identifier for a phone</value>
        [DataMember(Name="stationId", EmitDefaultValue=false)]
        public string StationId { get; set; }



        /// <summary>
        /// The team ID the user is a member of
        /// </summary>
        /// <value>The team ID the user is a member of</value>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }



        /// <summary>
        /// The address of a flow transfer target, e.g. a phone number, an email address, or a queueId
        /// </summary>
        /// <value>The address of a flow transfer target, e.g. a phone number, an email address, or a queueId</value>
        [DataMember(Name="transferTargetAddress", EmitDefaultValue=false)]
        public string TransferTargetAddress { get; set; }



        /// <summary>
        /// The name of a flow transfer target
        /// </summary>
        /// <value>The name of a flow transfer target</value>
        [DataMember(Name="transferTargetName", EmitDefaultValue=false)]
        public string TransferTargetName { get; set; }



        /// <summary>
        /// The type of transfer for flows that ended with a transfer
        /// </summary>
        /// <value>The type of transfer for flows that ended with a transfer</value>
        [DataMember(Name="transferType", EmitDefaultValue=false)]
        public string TransferType { get; set; }





        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        /// <value>Unique identifier for the user</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Number of waiting interactions for each predictive routing attempt
        /// </summary>
        /// <value>Number of waiting interactions for each predictive routing attempt</value>
        [DataMember(Name="waitingInteractionCounts", EmitDefaultValue=false)]
        public List<int?> WaitingInteractionCounts { get; set; }



        /// <summary>
        /// Wrap up code
        /// </summary>
        /// <value>Wrap up code</value>
        [DataMember(Name="wrapUpCode", EmitDefaultValue=false)]
        public string WrapUpCode { get; set; }



        /// <summary>
        /// Proposed agents
        /// </summary>
        /// <value>Proposed agents</value>
        [DataMember(Name="proposedAgents", EmitDefaultValue=false)]
        public List<FlowMetricsTopicFlowProposedAgent> ProposedAgents { get; set; }



        /// <summary>
        /// Flow outcomes
        /// </summary>
        /// <value>Flow outcomes</value>
        [DataMember(Name="outcomes", EmitDefaultValue=false)]
        public List<FlowMetricsTopicFlowOutcome> Outcomes { get; set; }



        /// <summary>
        /// Scored agents
        /// </summary>
        /// <value>Scored agents</value>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<FlowMetricsTopicFlowScoredAgent> ScoredAgents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowMetricsTopicFlowMetricRecord {\n");

            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  MetricDate: ").Append(MetricDate).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  ActiveRouting: ").Append(ActiveRouting).Append("\n");
            sb.Append("  ActiveSkillIds: ").Append(ActiveSkillIds).Append("\n");
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
            sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
            sb.Append("  AgentBullseyeRing: ").Append(AgentBullseyeRing).Append("\n");
            sb.Append("  AgentOwned: ").Append(AgentOwned).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  AssignerId: ").Append(AssignerId).Append("\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ConversationInitiator: ").Append(ConversationInitiator).Append("\n");
            sb.Append("  ConvertedFrom: ").Append(ConvertedFrom).Append("\n");
            sb.Append("  ConvertedTo: ").Append(ConvertedTo).Append("\n");
            sb.Append("  CustomerParticipation: ").Append(CustomerParticipation).Append("\n");
            sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
            sb.Append("  DestinationAddresses: ").Append(DestinationAddresses).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  EdgeId: ").Append(EdgeId).Append("\n");
            sb.Append("  EligibleAgentCounts: ").Append(EligibleAgentCounts).Append("\n");
            sb.Append("  EndingLanguage: ").Append(EndingLanguage).Append("\n");
            sb.Append("  EntryReason: ").Append(EntryReason).Append("\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ExitReason: ").Append(ExitReason).Append("\n");
            sb.Append("  ExtendedDeliveryStatus: ").Append(ExtendedDeliveryStatus).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  ExternalMediaCount: ").Append(ExternalMediaCount).Append("\n");
            sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
            sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
            sb.Append("  FirstQueue: ").Append(FirstQueue).Append("\n");
            sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  FlowInType: ").Append(FlowInType).Append("\n");
            sb.Append("  FlowMilestoneIds: ").Append(FlowMilestoneIds).Append("\n");
            sb.Append("  FlowName: ").Append(FlowName).Append("\n");
            sb.Append("  FlowOutType: ").Append(FlowOutType).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
            sb.Append("  JourneyActionId: ").Append(JourneyActionId).Append("\n");
            sb.Append("  JourneyActionMapId: ").Append(JourneyActionMapId).Append("\n");
            sb.Append("  JourneyActionMapVersion: ").Append(JourneyActionMapVersion).Append("\n");
            sb.Append("  JourneyCustomerId: ").Append(JourneyCustomerId).Append("\n");
            sb.Append("  JourneyCustomerIdType: ").Append(JourneyCustomerIdType).Append("\n");
            sb.Append("  JourneyCustomerSessionId: ").Append(JourneyCustomerSessionId).Append("\n");
            sb.Append("  JourneyCustomerSessionIdType: ").Append(JourneyCustomerSessionIdType).Append("\n");
            sb.Append("  KnowledgeBaseId: ").Append(KnowledgeBaseId).Append("\n");
            sb.Append("  MediaCount: ").Append(MediaCount).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
            sb.Append("  OutboundCampaignId: ").Append(OutboundCampaignId).Append("\n");
            sb.Append("  OutboundContactId: ").Append(OutboundContactId).Append("\n");
            sb.Append("  OutboundContactListId: ").Append(OutboundContactListId).Append("\n");
            sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  RecognitionFailureReason: ").Append(RecognitionFailureReason).Append("\n");
            sb.Append("  Remote: ").Append(Remote).Append("\n");
            sb.Append("  RemovedSkillIds: ").Append(RemovedSkillIds).Append("\n");
            sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
            sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
            sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
            sb.Append("  RoutingRing: ").Append(RoutingRing).Append("\n");
            sb.Append("  RoutingRule: ").Append(RoutingRule).Append("\n");
            sb.Append("  RoutingRuleType: ").Append(RoutingRuleType).Append("\n");
            sb.Append("  SelectedAgentId: ").Append(SelectedAgentId).Append("\n");
            sb.Append("  SelectedAgentRank: ").Append(SelectedAgentRank).Append("\n");
            sb.Append("  SelfServed: ").Append(SelfServed).Append("\n");
            sb.Append("  SessionDnis: ").Append(SessionDnis).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  StartingLanguage: ").Append(StartingLanguage).Append("\n");
            sb.Append("  StationId: ").Append(StationId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  TransferTargetAddress: ").Append(TransferTargetAddress).Append("\n");
            sb.Append("  TransferTargetName: ").Append(TransferTargetName).Append("\n");
            sb.Append("  TransferType: ").Append(TransferType).Append("\n");
            sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  WaitingInteractionCounts: ").Append(WaitingInteractionCounts).Append("\n");
            sb.Append("  WrapUpCode: ").Append(WrapUpCode).Append("\n");
            sb.Append("  ProposedAgents: ").Append(ProposedAgents).Append("\n");
            sb.Append("  Outcomes: ").Append(Outcomes).Append("\n");
            sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
            return this.Equals(obj as FlowMetricsTopicFlowMetricRecord);
        }

        /// <summary>
        /// Returns true if FlowMetricsTopicFlowMetricRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowMetricsTopicFlowMetricRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowMetricsTopicFlowMetricRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.MetricDate == other.MetricDate ||
                    this.MetricDate != null &&
                    this.MetricDate.Equals(other.MetricDate)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.RecordId == other.RecordId ||
                    this.RecordId != null &&
                    this.RecordId.Equals(other.RecordId)
                ) &&
                (
                    this.ActiveRouting == other.ActiveRouting ||
                    this.ActiveRouting != null &&
                    this.ActiveRouting.Equals(other.ActiveRouting)
                ) &&
                (
                    this.ActiveSkillIds == other.ActiveSkillIds ||
                    this.ActiveSkillIds != null &&
                    this.ActiveSkillIds.SequenceEqual(other.ActiveSkillIds)
                ) &&
                (
                    this.AddressFrom == other.AddressFrom ||
                    this.AddressFrom != null &&
                    this.AddressFrom.Equals(other.AddressFrom)
                ) &&
                (
                    this.AddressTo == other.AddressTo ||
                    this.AddressTo != null &&
                    this.AddressTo.Equals(other.AddressTo)
                ) &&
                (
                    this.AgentAssistantId == other.AgentAssistantId ||
                    this.AgentAssistantId != null &&
                    this.AgentAssistantId.Equals(other.AgentAssistantId)
                ) &&
                (
                    this.AgentBullseyeRing == other.AgentBullseyeRing ||
                    this.AgentBullseyeRing != null &&
                    this.AgentBullseyeRing.Equals(other.AgentBullseyeRing)
                ) &&
                (
                    this.AgentOwned == other.AgentOwned ||
                    this.AgentOwned != null &&
                    this.AgentOwned.Equals(other.AgentOwned)
                ) &&
                (
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.AssignerId == other.AssignerId ||
                    this.AssignerId != null &&
                    this.AssignerId.Equals(other.AssignerId)
                ) &&
                (
                    this.Authenticated == other.Authenticated ||
                    this.Authenticated != null &&
                    this.Authenticated.Equals(other.Authenticated)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.ConversationInitiator == other.ConversationInitiator ||
                    this.ConversationInitiator != null &&
                    this.ConversationInitiator.Equals(other.ConversationInitiator)
                ) &&
                (
                    this.ConvertedFrom == other.ConvertedFrom ||
                    this.ConvertedFrom != null &&
                    this.ConvertedFrom.Equals(other.ConvertedFrom)
                ) &&
                (
                    this.ConvertedTo == other.ConvertedTo ||
                    this.ConvertedTo != null &&
                    this.ConvertedTo.Equals(other.ConvertedTo)
                ) &&
                (
                    this.CustomerParticipation == other.CustomerParticipation ||
                    this.CustomerParticipation != null &&
                    this.CustomerParticipation.Equals(other.CustomerParticipation)
                ) &&
                (
                    this.DeliveryStatus == other.DeliveryStatus ||
                    this.DeliveryStatus != null &&
                    this.DeliveryStatus.Equals(other.DeliveryStatus)
                ) &&
                (
                    this.DestinationAddresses == other.DestinationAddresses ||
                    this.DestinationAddresses != null &&
                    this.DestinationAddresses.SequenceEqual(other.DestinationAddresses)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
                ) &&
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
                ) &&
                (
                    this.EdgeId == other.EdgeId ||
                    this.EdgeId != null &&
                    this.EdgeId.Equals(other.EdgeId)
                ) &&
                (
                    this.EligibleAgentCounts == other.EligibleAgentCounts ||
                    this.EligibleAgentCounts != null &&
                    this.EligibleAgentCounts.SequenceEqual(other.EligibleAgentCounts)
                ) &&
                (
                    this.EndingLanguage == other.EndingLanguage ||
                    this.EndingLanguage != null &&
                    this.EndingLanguage.Equals(other.EndingLanguage)
                ) &&
                (
                    this.EntryReason == other.EntryReason ||
                    this.EntryReason != null &&
                    this.EntryReason.Equals(other.EntryReason)
                ) &&
                (
                    this.EntryType == other.EntryType ||
                    this.EntryType != null &&
                    this.EntryType.Equals(other.EntryType)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ExitReason == other.ExitReason ||
                    this.ExitReason != null &&
                    this.ExitReason.Equals(other.ExitReason)
                ) &&
                (
                    this.ExtendedDeliveryStatus == other.ExtendedDeliveryStatus ||
                    this.ExtendedDeliveryStatus != null &&
                    this.ExtendedDeliveryStatus.Equals(other.ExtendedDeliveryStatus)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.ExternalMediaCount == other.ExternalMediaCount ||
                    this.ExternalMediaCount != null &&
                    this.ExternalMediaCount.Equals(other.ExternalMediaCount)
                ) &&
                (
                    this.ExternalOrganizationId == other.ExternalOrganizationId ||
                    this.ExternalOrganizationId != null &&
                    this.ExternalOrganizationId.Equals(other.ExternalOrganizationId)
                ) &&
                (
                    this.ExternalTag == other.ExternalTag ||
                    this.ExternalTag != null &&
                    this.ExternalTag.Equals(other.ExternalTag)
                ) &&
                (
                    this.FirstQueue == other.FirstQueue ||
                    this.FirstQueue != null &&
                    this.FirstQueue.Equals(other.FirstQueue)
                ) &&
                (
                    this.FlaggedReason == other.FlaggedReason ||
                    this.FlaggedReason != null &&
                    this.FlaggedReason.Equals(other.FlaggedReason)
                ) &&
                (
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
                ) &&
                (
                    this.FlowInType == other.FlowInType ||
                    this.FlowInType != null &&
                    this.FlowInType.Equals(other.FlowInType)
                ) &&
                (
                    this.FlowMilestoneIds == other.FlowMilestoneIds ||
                    this.FlowMilestoneIds != null &&
                    this.FlowMilestoneIds.SequenceEqual(other.FlowMilestoneIds)
                ) &&
                (
                    this.FlowName == other.FlowName ||
                    this.FlowName != null &&
                    this.FlowName.Equals(other.FlowName)
                ) &&
                (
                    this.FlowOutType == other.FlowOutType ||
                    this.FlowOutType != null &&
                    this.FlowOutType.Equals(other.FlowOutType)
                ) &&
                (
                    this.FlowType == other.FlowType ||
                    this.FlowType != null &&
                    this.FlowType.Equals(other.FlowType)
                ) &&
                (
                    this.FlowVersion == other.FlowVersion ||
                    this.FlowVersion != null &&
                    this.FlowVersion.Equals(other.FlowVersion)
                ) &&
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) &&
                (
                    this.InteractionType == other.InteractionType ||
                    this.InteractionType != null &&
                    this.InteractionType.Equals(other.InteractionType)
                ) &&
                (
                    this.JourneyActionId == other.JourneyActionId ||
                    this.JourneyActionId != null &&
                    this.JourneyActionId.Equals(other.JourneyActionId)
                ) &&
                (
                    this.JourneyActionMapId == other.JourneyActionMapId ||
                    this.JourneyActionMapId != null &&
                    this.JourneyActionMapId.Equals(other.JourneyActionMapId)
                ) &&
                (
                    this.JourneyActionMapVersion == other.JourneyActionMapVersion ||
                    this.JourneyActionMapVersion != null &&
                    this.JourneyActionMapVersion.Equals(other.JourneyActionMapVersion)
                ) &&
                (
                    this.JourneyCustomerId == other.JourneyCustomerId ||
                    this.JourneyCustomerId != null &&
                    this.JourneyCustomerId.Equals(other.JourneyCustomerId)
                ) &&
                (
                    this.JourneyCustomerIdType == other.JourneyCustomerIdType ||
                    this.JourneyCustomerIdType != null &&
                    this.JourneyCustomerIdType.Equals(other.JourneyCustomerIdType)
                ) &&
                (
                    this.JourneyCustomerSessionId == other.JourneyCustomerSessionId ||
                    this.JourneyCustomerSessionId != null &&
                    this.JourneyCustomerSessionId.Equals(other.JourneyCustomerSessionId)
                ) &&
                (
                    this.JourneyCustomerSessionIdType == other.JourneyCustomerSessionIdType ||
                    this.JourneyCustomerSessionIdType != null &&
                    this.JourneyCustomerSessionIdType.Equals(other.JourneyCustomerSessionIdType)
                ) &&
                (
                    this.KnowledgeBaseId == other.KnowledgeBaseId ||
                    this.KnowledgeBaseId != null &&
                    this.KnowledgeBaseId.Equals(other.KnowledgeBaseId)
                ) &&
                (
                    this.MediaCount == other.MediaCount ||
                    this.MediaCount != null &&
                    this.MediaCount.Equals(other.MediaCount)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) &&
                (
                    this.OriginatingDirection == other.OriginatingDirection ||
                    this.OriginatingDirection != null &&
                    this.OriginatingDirection.Equals(other.OriginatingDirection)
                ) &&
                (
                    this.OutboundCampaignId == other.OutboundCampaignId ||
                    this.OutboundCampaignId != null &&
                    this.OutboundCampaignId.Equals(other.OutboundCampaignId)
                ) &&
                (
                    this.OutboundContactId == other.OutboundContactId ||
                    this.OutboundContactId != null &&
                    this.OutboundContactId.Equals(other.OutboundContactId)
                ) &&
                (
                    this.OutboundContactListId == other.OutboundContactListId ||
                    this.OutboundContactListId != null &&
                    this.OutboundContactListId.Equals(other.OutboundContactListId)
                ) &&
                (
                    this.ParticipantName == other.ParticipantName ||
                    this.ParticipantName != null &&
                    this.ParticipantName.Equals(other.ParticipantName)
                ) &&
                (
                    this.PeerId == other.PeerId ||
                    this.PeerId != null &&
                    this.PeerId.Equals(other.PeerId)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.RecognitionFailureReason == other.RecognitionFailureReason ||
                    this.RecognitionFailureReason != null &&
                    this.RecognitionFailureReason.Equals(other.RecognitionFailureReason)
                ) &&
                (
                    this.Remote == other.Remote ||
                    this.Remote != null &&
                    this.Remote.Equals(other.Remote)
                ) &&
                (
                    this.RemovedSkillIds == other.RemovedSkillIds ||
                    this.RemovedSkillIds != null &&
                    this.RemovedSkillIds.SequenceEqual(other.RemovedSkillIds)
                ) &&
                (
                    this.RequestedLanguageId == other.RequestedLanguageId ||
                    this.RequestedLanguageId != null &&
                    this.RequestedLanguageId.Equals(other.RequestedLanguageId)
                ) &&
                (
                    this.RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                    this.RequestedRoutingSkillIds != null &&
                    this.RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
                ) &&
                (
                    this.RequestedRoutings == other.RequestedRoutings ||
                    this.RequestedRoutings != null &&
                    this.RequestedRoutings.SequenceEqual(other.RequestedRoutings)
                ) &&
                (
                    this.RoomId == other.RoomId ||
                    this.RoomId != null &&
                    this.RoomId.Equals(other.RoomId)
                ) &&
                (
                    this.RoutingPriority == other.RoutingPriority ||
                    this.RoutingPriority != null &&
                    this.RoutingPriority.Equals(other.RoutingPriority)
                ) &&
                (
                    this.RoutingRing == other.RoutingRing ||
                    this.RoutingRing != null &&
                    this.RoutingRing.Equals(other.RoutingRing)
                ) &&
                (
                    this.RoutingRule == other.RoutingRule ||
                    this.RoutingRule != null &&
                    this.RoutingRule.Equals(other.RoutingRule)
                ) &&
                (
                    this.RoutingRuleType == other.RoutingRuleType ||
                    this.RoutingRuleType != null &&
                    this.RoutingRuleType.Equals(other.RoutingRuleType)
                ) &&
                (
                    this.SelectedAgentId == other.SelectedAgentId ||
                    this.SelectedAgentId != null &&
                    this.SelectedAgentId.Equals(other.SelectedAgentId)
                ) &&
                (
                    this.SelectedAgentRank == other.SelectedAgentRank ||
                    this.SelectedAgentRank != null &&
                    this.SelectedAgentRank.Equals(other.SelectedAgentRank)
                ) &&
                (
                    this.SelfServed == other.SelfServed ||
                    this.SelfServed != null &&
                    this.SelfServed.Equals(other.SelfServed)
                ) &&
                (
                    this.SessionDnis == other.SessionDnis ||
                    this.SessionDnis != null &&
                    this.SessionDnis.Equals(other.SessionDnis)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.StartingLanguage == other.StartingLanguage ||
                    this.StartingLanguage != null &&
                    this.StartingLanguage.Equals(other.StartingLanguage)
                ) &&
                (
                    this.StationId == other.StationId ||
                    this.StationId != null &&
                    this.StationId.Equals(other.StationId)
                ) &&
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) &&
                (
                    this.TransferTargetAddress == other.TransferTargetAddress ||
                    this.TransferTargetAddress != null &&
                    this.TransferTargetAddress.Equals(other.TransferTargetAddress)
                ) &&
                (
                    this.TransferTargetName == other.TransferTargetName ||
                    this.TransferTargetName != null &&
                    this.TransferTargetName.Equals(other.TransferTargetName)
                ) &&
                (
                    this.TransferType == other.TransferType ||
                    this.TransferType != null &&
                    this.TransferType.Equals(other.TransferType)
                ) &&
                (
                    this.UsedRouting == other.UsedRouting ||
                    this.UsedRouting != null &&
                    this.UsedRouting.Equals(other.UsedRouting)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.WaitingInteractionCounts == other.WaitingInteractionCounts ||
                    this.WaitingInteractionCounts != null &&
                    this.WaitingInteractionCounts.SequenceEqual(other.WaitingInteractionCounts)
                ) &&
                (
                    this.WrapUpCode == other.WrapUpCode ||
                    this.WrapUpCode != null &&
                    this.WrapUpCode.Equals(other.WrapUpCode)
                ) &&
                (
                    this.ProposedAgents == other.ProposedAgents ||
                    this.ProposedAgents != null &&
                    this.ProposedAgents.SequenceEqual(other.ProposedAgents)
                ) &&
                (
                    this.Outcomes == other.Outcomes ||
                    this.Outcomes != null &&
                    this.Outcomes.SequenceEqual(other.Outcomes)
                ) &&
                (
                    this.ScoredAgents == other.ScoredAgents ||
                    this.ScoredAgents != null &&
                    this.ScoredAgents.SequenceEqual(other.ScoredAgents)
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
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.MetricDate != null)
                    hash = hash * 59 + this.MetricDate.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.RecordId != null)
                    hash = hash * 59 + this.RecordId.GetHashCode();

                if (this.ActiveRouting != null)
                    hash = hash * 59 + this.ActiveRouting.GetHashCode();

                if (this.ActiveSkillIds != null)
                    hash = hash * 59 + this.ActiveSkillIds.GetHashCode();

                if (this.AddressFrom != null)
                    hash = hash * 59 + this.AddressFrom.GetHashCode();

                if (this.AddressTo != null)
                    hash = hash * 59 + this.AddressTo.GetHashCode();

                if (this.AgentAssistantId != null)
                    hash = hash * 59 + this.AgentAssistantId.GetHashCode();

                if (this.AgentBullseyeRing != null)
                    hash = hash * 59 + this.AgentBullseyeRing.GetHashCode();

                if (this.AgentOwned != null)
                    hash = hash * 59 + this.AgentOwned.GetHashCode();

                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();

                if (this.AssignerId != null)
                    hash = hash * 59 + this.AssignerId.GetHashCode();

                if (this.Authenticated != null)
                    hash = hash * 59 + this.Authenticated.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.ConversationInitiator != null)
                    hash = hash * 59 + this.ConversationInitiator.GetHashCode();

                if (this.ConvertedFrom != null)
                    hash = hash * 59 + this.ConvertedFrom.GetHashCode();

                if (this.ConvertedTo != null)
                    hash = hash * 59 + this.ConvertedTo.GetHashCode();

                if (this.CustomerParticipation != null)
                    hash = hash * 59 + this.CustomerParticipation.GetHashCode();

                if (this.DeliveryStatus != null)
                    hash = hash * 59 + this.DeliveryStatus.GetHashCode();

                if (this.DestinationAddresses != null)
                    hash = hash * 59 + this.DestinationAddresses.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();

                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();

                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();

                if (this.EdgeId != null)
                    hash = hash * 59 + this.EdgeId.GetHashCode();

                if (this.EligibleAgentCounts != null)
                    hash = hash * 59 + this.EligibleAgentCounts.GetHashCode();

                if (this.EndingLanguage != null)
                    hash = hash * 59 + this.EndingLanguage.GetHashCode();

                if (this.EntryReason != null)
                    hash = hash * 59 + this.EntryReason.GetHashCode();

                if (this.EntryType != null)
                    hash = hash * 59 + this.EntryType.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.ExitReason != null)
                    hash = hash * 59 + this.ExitReason.GetHashCode();

                if (this.ExtendedDeliveryStatus != null)
                    hash = hash * 59 + this.ExtendedDeliveryStatus.GetHashCode();

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                if (this.ExternalMediaCount != null)
                    hash = hash * 59 + this.ExternalMediaCount.GetHashCode();

                if (this.ExternalOrganizationId != null)
                    hash = hash * 59 + this.ExternalOrganizationId.GetHashCode();

                if (this.ExternalTag != null)
                    hash = hash * 59 + this.ExternalTag.GetHashCode();

                if (this.FirstQueue != null)
                    hash = hash * 59 + this.FirstQueue.GetHashCode();

                if (this.FlaggedReason != null)
                    hash = hash * 59 + this.FlaggedReason.GetHashCode();

                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();

                if (this.FlowInType != null)
                    hash = hash * 59 + this.FlowInType.GetHashCode();

                if (this.FlowMilestoneIds != null)
                    hash = hash * 59 + this.FlowMilestoneIds.GetHashCode();

                if (this.FlowName != null)
                    hash = hash * 59 + this.FlowName.GetHashCode();

                if (this.FlowOutType != null)
                    hash = hash * 59 + this.FlowOutType.GetHashCode();

                if (this.FlowType != null)
                    hash = hash * 59 + this.FlowType.GetHashCode();

                if (this.FlowVersion != null)
                    hash = hash * 59 + this.FlowVersion.GetHashCode();

                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();

                if (this.InteractionType != null)
                    hash = hash * 59 + this.InteractionType.GetHashCode();

                if (this.JourneyActionId != null)
                    hash = hash * 59 + this.JourneyActionId.GetHashCode();

                if (this.JourneyActionMapId != null)
                    hash = hash * 59 + this.JourneyActionMapId.GetHashCode();

                if (this.JourneyActionMapVersion != null)
                    hash = hash * 59 + this.JourneyActionMapVersion.GetHashCode();

                if (this.JourneyCustomerId != null)
                    hash = hash * 59 + this.JourneyCustomerId.GetHashCode();

                if (this.JourneyCustomerIdType != null)
                    hash = hash * 59 + this.JourneyCustomerIdType.GetHashCode();

                if (this.JourneyCustomerSessionId != null)
                    hash = hash * 59 + this.JourneyCustomerSessionId.GetHashCode();

                if (this.JourneyCustomerSessionIdType != null)
                    hash = hash * 59 + this.JourneyCustomerSessionIdType.GetHashCode();

                if (this.KnowledgeBaseId != null)
                    hash = hash * 59 + this.KnowledgeBaseId.GetHashCode();

                if (this.MediaCount != null)
                    hash = hash * 59 + this.MediaCount.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();

                if (this.OriginatingDirection != null)
                    hash = hash * 59 + this.OriginatingDirection.GetHashCode();

                if (this.OutboundCampaignId != null)
                    hash = hash * 59 + this.OutboundCampaignId.GetHashCode();

                if (this.OutboundContactId != null)
                    hash = hash * 59 + this.OutboundContactId.GetHashCode();

                if (this.OutboundContactListId != null)
                    hash = hash * 59 + this.OutboundContactListId.GetHashCode();

                if (this.ParticipantName != null)
                    hash = hash * 59 + this.ParticipantName.GetHashCode();

                if (this.PeerId != null)
                    hash = hash * 59 + this.PeerId.GetHashCode();

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.RecognitionFailureReason != null)
                    hash = hash * 59 + this.RecognitionFailureReason.GetHashCode();

                if (this.Remote != null)
                    hash = hash * 59 + this.Remote.GetHashCode();

                if (this.RemovedSkillIds != null)
                    hash = hash * 59 + this.RemovedSkillIds.GetHashCode();

                if (this.RequestedLanguageId != null)
                    hash = hash * 59 + this.RequestedLanguageId.GetHashCode();

                if (this.RequestedRoutingSkillIds != null)
                    hash = hash * 59 + this.RequestedRoutingSkillIds.GetHashCode();

                if (this.RequestedRoutings != null)
                    hash = hash * 59 + this.RequestedRoutings.GetHashCode();

                if (this.RoomId != null)
                    hash = hash * 59 + this.RoomId.GetHashCode();

                if (this.RoutingPriority != null)
                    hash = hash * 59 + this.RoutingPriority.GetHashCode();

                if (this.RoutingRing != null)
                    hash = hash * 59 + this.RoutingRing.GetHashCode();

                if (this.RoutingRule != null)
                    hash = hash * 59 + this.RoutingRule.GetHashCode();

                if (this.RoutingRuleType != null)
                    hash = hash * 59 + this.RoutingRuleType.GetHashCode();

                if (this.SelectedAgentId != null)
                    hash = hash * 59 + this.SelectedAgentId.GetHashCode();

                if (this.SelectedAgentRank != null)
                    hash = hash * 59 + this.SelectedAgentRank.GetHashCode();

                if (this.SelfServed != null)
                    hash = hash * 59 + this.SelfServed.GetHashCode();

                if (this.SessionDnis != null)
                    hash = hash * 59 + this.SessionDnis.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.StartingLanguage != null)
                    hash = hash * 59 + this.StartingLanguage.GetHashCode();

                if (this.StationId != null)
                    hash = hash * 59 + this.StationId.GetHashCode();

                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();

                if (this.TransferTargetAddress != null)
                    hash = hash * 59 + this.TransferTargetAddress.GetHashCode();

                if (this.TransferTargetName != null)
                    hash = hash * 59 + this.TransferTargetName.GetHashCode();

                if (this.TransferType != null)
                    hash = hash * 59 + this.TransferType.GetHashCode();

                if (this.UsedRouting != null)
                    hash = hash * 59 + this.UsedRouting.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.WaitingInteractionCounts != null)
                    hash = hash * 59 + this.WaitingInteractionCounts.GetHashCode();

                if (this.WrapUpCode != null)
                    hash = hash * 59 + this.WrapUpCode.GetHashCode();

                if (this.ProposedAgents != null)
                    hash = hash * 59 + this.ProposedAgents.GetHashCode();

                if (this.Outcomes != null)
                    hash = hash * 59 + this.Outcomes.GetHashCode();

                if (this.ScoredAgents != null)
                    hash = hash * 59 + this.ScoredAgents.GetHashCode();

                return hash;
            }
        }
    }

}
