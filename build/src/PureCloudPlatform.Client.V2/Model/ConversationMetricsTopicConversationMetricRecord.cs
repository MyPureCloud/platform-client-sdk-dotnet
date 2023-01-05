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
    /// ConversationMetricsTopicConversationMetricRecord
    /// </summary>
    [DataContract]
    public partial class ConversationMetricsTopicConversationMetricRecord :  IEquatable<ConversationMetricsTopicConversationMetricRecord>
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
            /// Enum Nblindtransferred for "nBlindTransferred"
            /// </summary>
            [EnumMember(Value = "nBlindTransferred")]
            Nblindtransferred,
            
            /// <summary>
            /// Enum Ncobrowsesessions for "nCobrowseSessions"
            /// </summary>
            [EnumMember(Value = "nCobrowseSessions")]
            Ncobrowsesessions,
            
            /// <summary>
            /// Enum Nconnected for "nConnected"
            /// </summary>
            [EnumMember(Value = "nConnected")]
            Nconnected,
            
            /// <summary>
            /// Enum Nconsult for "nConsult"
            /// </summary>
            [EnumMember(Value = "nConsult")]
            Nconsult,
            
            /// <summary>
            /// Enum Nconsulttransferred for "nConsultTransferred"
            /// </summary>
            [EnumMember(Value = "nConsultTransferred")]
            Nconsulttransferred,
            
            /// <summary>
            /// Enum Nerror for "nError"
            /// </summary>
            [EnumMember(Value = "nError")]
            Nerror,
            
            /// <summary>
            /// Enum Noffered for "nOffered"
            /// </summary>
            [EnumMember(Value = "nOffered")]
            Noffered,
            
            /// <summary>
            /// Enum Noutbound for "nOutbound"
            /// </summary>
            [EnumMember(Value = "nOutbound")]
            Noutbound,
            
            /// <summary>
            /// Enum Noutboundabandoned for "nOutboundAbandoned"
            /// </summary>
            [EnumMember(Value = "nOutboundAbandoned")]
            Noutboundabandoned,
            
            /// <summary>
            /// Enum Noutboundattempted for "nOutboundAttempted"
            /// </summary>
            [EnumMember(Value = "nOutboundAttempted")]
            Noutboundattempted,
            
            /// <summary>
            /// Enum Noutboundconnected for "nOutboundConnected"
            /// </summary>
            [EnumMember(Value = "nOutboundConnected")]
            Noutboundconnected,
            
            /// <summary>
            /// Enum Noversla for "nOverSla"
            /// </summary>
            [EnumMember(Value = "nOverSla")]
            Noversla,
            
            /// <summary>
            /// Enum Ntransferred for "nTransferred"
            /// </summary>
            [EnumMember(Value = "nTransferred")]
            Ntransferred,
            
            /// <summary>
            /// Enum Oexternalmediacount for "oExternalMediaCount"
            /// </summary>
            [EnumMember(Value = "oExternalMediaCount")]
            Oexternalmediacount,
            
            /// <summary>
            /// Enum Omediacount for "oMediaCount"
            /// </summary>
            [EnumMember(Value = "oMediaCount")]
            Omediacount,
            
            /// <summary>
            /// Enum Omessageturn for "oMessageTurn"
            /// </summary>
            [EnumMember(Value = "oMessageTurn")]
            Omessageturn,
            
            /// <summary>
            /// Enum Tabandon for "tAbandon"
            /// </summary>
            [EnumMember(Value = "tAbandon")]
            Tabandon,
            
            /// <summary>
            /// Enum Tacd for "tAcd"
            /// </summary>
            [EnumMember(Value = "tAcd")]
            Tacd,
            
            /// <summary>
            /// Enum Tacw for "tAcw"
            /// </summary>
            [EnumMember(Value = "tAcw")]
            Tacw,
            
            /// <summary>
            /// Enum Tagentresponsetime for "tAgentResponseTime"
            /// </summary>
            [EnumMember(Value = "tAgentResponseTime")]
            Tagentresponsetime,
            
            /// <summary>
            /// Enum Talert for "tAlert"
            /// </summary>
            [EnumMember(Value = "tAlert")]
            Talert,
            
            /// <summary>
            /// Enum Tanswered for "tAnswered"
            /// </summary>
            [EnumMember(Value = "tAnswered")]
            Tanswered,
            
            /// <summary>
            /// Enum Tbarging for "tBarging"
            /// </summary>
            [EnumMember(Value = "tBarging")]
            Tbarging,
            
            /// <summary>
            /// Enum Tcallback for "tCallback"
            /// </summary>
            [EnumMember(Value = "tCallback")]
            Tcallback,
            
            /// <summary>
            /// Enum Tcallbackcomplete for "tCallbackComplete"
            /// </summary>
            [EnumMember(Value = "tCallbackComplete")]
            Tcallbackcomplete,
            
            /// <summary>
            /// Enum Tcoaching for "tCoaching"
            /// </summary>
            [EnumMember(Value = "tCoaching")]
            Tcoaching,
            
            /// <summary>
            /// Enum Tcoachingcomplete for "tCoachingComplete"
            /// </summary>
            [EnumMember(Value = "tCoachingComplete")]
            Tcoachingcomplete,
            
            /// <summary>
            /// Enum Tconnected for "tConnected"
            /// </summary>
            [EnumMember(Value = "tConnected")]
            Tconnected,
            
            /// <summary>
            /// Enum Tcontacting for "tContacting"
            /// </summary>
            [EnumMember(Value = "tContacting")]
            Tcontacting,
            
            /// <summary>
            /// Enum Tdialing for "tDialing"
            /// </summary>
            [EnumMember(Value = "tDialing")]
            Tdialing,
            
            /// <summary>
            /// Enum Tfirstconnect for "tFirstConnect"
            /// </summary>
            [EnumMember(Value = "tFirstConnect")]
            Tfirstconnect,
            
            /// <summary>
            /// Enum Tfirstdial for "tFirstDial"
            /// </summary>
            [EnumMember(Value = "tFirstDial")]
            Tfirstdial,
            
            /// <summary>
            /// Enum Tflowout for "tFlowOut"
            /// </summary>
            [EnumMember(Value = "tFlowOut")]
            Tflowout,
            
            /// <summary>
            /// Enum Thandle for "tHandle"
            /// </summary>
            [EnumMember(Value = "tHandle")]
            Thandle,
            
            /// <summary>
            /// Enum Theld for "tHeld"
            /// </summary>
            [EnumMember(Value = "tHeld")]
            Theld,
            
            /// <summary>
            /// Enum Theldcomplete for "tHeldComplete"
            /// </summary>
            [EnumMember(Value = "tHeldComplete")]
            Theldcomplete,
            
            /// <summary>
            /// Enum Tivr for "tIvr"
            /// </summary>
            [EnumMember(Value = "tIvr")]
            Tivr,
            
            /// <summary>
            /// Enum Tmonitoring for "tMonitoring"
            /// </summary>
            [EnumMember(Value = "tMonitoring")]
            Tmonitoring,
            
            /// <summary>
            /// Enum Tmonitoringcomplete for "tMonitoringComplete"
            /// </summary>
            [EnumMember(Value = "tMonitoringComplete")]
            Tmonitoringcomplete,
            
            /// <summary>
            /// Enum Tnotresponding for "tNotResponding"
            /// </summary>
            [EnumMember(Value = "tNotResponding")]
            Tnotresponding,
            
            /// <summary>
            /// Enum Ttalk for "tTalk"
            /// </summary>
            [EnumMember(Value = "tTalk")]
            Ttalk,
            
            /// <summary>
            /// Enum Ttalkcomplete for "tTalkComplete"
            /// </summary>
            [EnumMember(Value = "tTalkComplete")]
            Ttalkcomplete,
            
            /// <summary>
            /// Enum Tuserresponsetime for "tUserResponseTime"
            /// </summary>
            [EnumMember(Value = "tUserResponseTime")]
            Tuserresponsetime,
            
            /// <summary>
            /// Enum Tvoicemail for "tVoicemail"
            /// </summary>
            [EnumMember(Value = "tVoicemail")]
            Tvoicemail
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
        /// Reason for which participant flagged conversation
        /// </summary>
        /// <value>Reason for which participant flagged conversation</value>
        [DataMember(Name="flaggedReason", EmitDefaultValue=false)]
        public FlaggedReasonEnum? FlaggedReason { get; set; }
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
        /// Complete routing method
        /// </summary>
        /// <value>Complete routing method</value>
        [DataMember(Name="usedRouting", EmitDefaultValue=false)]
        public UsedRoutingEnum? UsedRouting { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMetricsTopicConversationMetricRecord" /> class.
        /// </summary>
        /// <param name="Metric">Metric name.</param>
        /// <param name="MetricDate">The date and time of metric creation.</param>
        /// <param name="Value">Metric value.</param>
        /// <param name="RecordId">Record identifier.</param>
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
        /// <param name="ErrorCode">A code corresponding to the error that occurred.</param>
        /// <param name="ExtendedDeliveryStatus">Extended delivery status.</param>
        /// <param name="ExternalContactId">External contact identifier.</param>
        /// <param name="ExternalMediaCount">Count of any media (images, files, etc) included on the external session.</param>
        /// <param name="ExternalOrganizationId">External organization identifier.</param>
        /// <param name="ExternalTag">External tag for the conversation.</param>
        /// <param name="FirstQueue">Marker that is set if the current queue is the first queue in a conversation.</param>
        /// <param name="FlaggedReason">Reason for which participant flagged conversation.</param>
        /// <param name="FlowInType">Type of flow in that occurred when entering ACD..</param>
        /// <param name="FlowOutType">Type of flow out that occurred when emitting tFlowOut..</param>
        /// <param name="GroupId">Unique identifier for a PureCloud group.</param>
        /// <param name="InteractionType">The interaction type (enterprise or contactCenter).</param>
        /// <param name="JourneyActionId">Identifier of the journey action..</param>
        /// <param name="JourneyActionMapId">Identifier of the journey action map that triggered the action..</param>
        /// <param name="JourneyActionMapVersion">Version of the journey action map that triggered the action..</param>
        /// <param name="JourneyCustomerId">Primary identifier of the journey customer in the source where the activities originate from..</param>
        /// <param name="JourneyCustomerIdType">Type of primary identifier of the journey customer (e.g. cookie)..</param>
        /// <param name="JourneyCustomerSessionId">Unique identifier of the journey session..</param>
        /// <param name="JourneyCustomerSessionIdType">Type or category of journey sessions (e.g. web, ticket, delivery, atm)..</param>
        /// <param name="KnowledgeBaseIds">The unique identifier(s) of the knowledge base(s) used.</param>
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
        /// <param name="Remote">Name, phone number, or email address of the remote party..</param>
        /// <param name="RemovedSkillIds">ID(s) of Skill(s) that have been removed by bullseye routing.</param>
        /// <param name="Reoffered">Marker for an interaction that got reoffered to the same queue by an in-queue flow.</param>
        /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
        /// <param name="RequestedRoutingSkillIds">Unique identifier(s) for skill(s) requested for an interaction.</param>
        /// <param name="RequestedRoutings">Routing type(s) for requested/attempted routing methods..</param>
        /// <param name="RoomId">Unique identifier for the room.</param>
        /// <param name="RoutingPriority">Routing priority for the current interaction.</param>
        /// <param name="RoutingRing">Routing ring for bullseye or preferred agent routing.</param>
        /// <param name="SelectedAgentId">Selected agent ID.</param>
        /// <param name="SelectedAgentRank">Selected agent GPR rank.</param>
        /// <param name="SelfServed">Indicates whether all flow sessions were self serviced.</param>
        /// <param name="SessionDnis">Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred.</param>
        /// <param name="SessionId">The unique identifier of this session.</param>
        /// <param name="StationId">Unique identifier for a phone.</param>
        /// <param name="TeamId">The team ID the user is a member of.</param>
        /// <param name="UsedRouting">Complete routing method.</param>
        /// <param name="UserId">Unique identifier for the user.</param>
        /// <param name="WaitingInteractionCounts">Number of waiting interactions for each predictive routing attempt.</param>
        /// <param name="WrapUpCode">Wrap up code.</param>
        /// <param name="ProposedAgents">Proposed agents.</param>
        /// <param name="ScoredAgents">Scored agents.</param>
        public ConversationMetricsTopicConversationMetricRecord(MetricEnum? Metric = null, DateTime? MetricDate = null, int? Value = null, string RecordId = null, List<string> ActiveSkillIds = null, string AddressFrom = null, string AddressTo = null, string AgentAssistantId = null, int? AgentBullseyeRing = null, bool? AgentOwned = null, string Ani = null, string AssignerId = null, bool? Authenticated = null, string ConversationId = null, ConversationInitiatorEnum? ConversationInitiator = null, string ConvertedFrom = null, string ConvertedTo = null, bool? CustomerParticipation = null, DeliveryStatusEnum? DeliveryStatus = null, List<string> DestinationAddresses = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, List<string> DivisionIds = null, string Dnis = null, string EdgeId = null, List<int?> EligibleAgentCounts = null, string ErrorCode = null, string ExtendedDeliveryStatus = null, string ExternalContactId = null, int? ExternalMediaCount = null, string ExternalOrganizationId = null, string ExternalTag = null, bool? FirstQueue = null, FlaggedReasonEnum? FlaggedReason = null, string FlowInType = null, string FlowOutType = null, string GroupId = null, string InteractionType = null, string JourneyActionId = null, string JourneyActionMapId = null, int? JourneyActionMapVersion = null, string JourneyCustomerId = null, string JourneyCustomerIdType = null, string JourneyCustomerSessionId = null, string JourneyCustomerSessionIdType = null, List<string> KnowledgeBaseIds = null, int? MediaCount = null, MediaTypeEnum? MediaType = null, string MessageType = null, OriginatingDirectionEnum? OriginatingDirection = null, string OutboundCampaignId = null, string OutboundContactId = null, string OutboundContactListId = null, string ParticipantName = null, string PeerId = null, string Provider = null, PurposeEnum? Purpose = null, string QueueId = null, string Remote = null, List<string> RemovedSkillIds = null, bool? Reoffered = null, string RequestedLanguageId = null, List<string> RequestedRoutingSkillIds = null, List<RequestedRoutingsEnum> RequestedRoutings = null, string RoomId = null, int? RoutingPriority = null, int? RoutingRing = null, string SelectedAgentId = null, int? SelectedAgentRank = null, bool? SelfServed = null, string SessionDnis = null, string SessionId = null, string StationId = null, string TeamId = null, UsedRoutingEnum? UsedRouting = null, string UserId = null, List<int?> WaitingInteractionCounts = null, string WrapUpCode = null, List<ConversationMetricsTopicConversationProposedAgent> ProposedAgents = null, List<ConversationMetricsTopicConversationScoredAgent> ScoredAgents = null)
        {
            this.Metric = Metric;
            this.MetricDate = MetricDate;
            this.Value = Value;
            this.RecordId = RecordId;
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
            this.ErrorCode = ErrorCode;
            this.ExtendedDeliveryStatus = ExtendedDeliveryStatus;
            this.ExternalContactId = ExternalContactId;
            this.ExternalMediaCount = ExternalMediaCount;
            this.ExternalOrganizationId = ExternalOrganizationId;
            this.ExternalTag = ExternalTag;
            this.FirstQueue = FirstQueue;
            this.FlaggedReason = FlaggedReason;
            this.FlowInType = FlowInType;
            this.FlowOutType = FlowOutType;
            this.GroupId = GroupId;
            this.InteractionType = InteractionType;
            this.JourneyActionId = JourneyActionId;
            this.JourneyActionMapId = JourneyActionMapId;
            this.JourneyActionMapVersion = JourneyActionMapVersion;
            this.JourneyCustomerId = JourneyCustomerId;
            this.JourneyCustomerIdType = JourneyCustomerIdType;
            this.JourneyCustomerSessionId = JourneyCustomerSessionId;
            this.JourneyCustomerSessionIdType = JourneyCustomerSessionIdType;
            this.KnowledgeBaseIds = KnowledgeBaseIds;
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
            this.Remote = Remote;
            this.RemovedSkillIds = RemovedSkillIds;
            this.Reoffered = Reoffered;
            this.RequestedLanguageId = RequestedLanguageId;
            this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
            this.RequestedRoutings = RequestedRoutings;
            this.RoomId = RoomId;
            this.RoutingPriority = RoutingPriority;
            this.RoutingRing = RoutingRing;
            this.SelectedAgentId = SelectedAgentId;
            this.SelectedAgentRank = SelectedAgentRank;
            this.SelfServed = SelfServed;
            this.SessionDnis = SessionDnis;
            this.SessionId = SessionId;
            this.StationId = StationId;
            this.TeamId = TeamId;
            this.UsedRouting = UsedRouting;
            this.UserId = UserId;
            this.WaitingInteractionCounts = WaitingInteractionCounts;
            this.WrapUpCode = WrapUpCode;
            this.ProposedAgents = ProposedAgents;
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
        /// A code corresponding to the error that occurred
        /// </summary>
        /// <value>A code corresponding to the error that occurred</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }



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
        /// Type of flow in that occurred when entering ACD.
        /// </summary>
        /// <value>Type of flow in that occurred when entering ACD.</value>
        [DataMember(Name="flowInType", EmitDefaultValue=false)]
        public string FlowInType { get; set; }



        /// <summary>
        /// Type of flow out that occurred when emitting tFlowOut.
        /// </summary>
        /// <value>Type of flow out that occurred when emitting tFlowOut.</value>
        [DataMember(Name="flowOutType", EmitDefaultValue=false)]
        public string FlowOutType { get; set; }



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
        /// The unique identifier(s) of the knowledge base(s) used
        /// </summary>
        /// <value>The unique identifier(s) of the knowledge base(s) used</value>
        [DataMember(Name="knowledgeBaseIds", EmitDefaultValue=false)]
        public List<string> KnowledgeBaseIds { get; set; }



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
        /// Marker for an interaction that got reoffered to the same queue by an in-queue flow
        /// </summary>
        /// <value>Marker for an interaction that got reoffered to the same queue by an in-queue flow</value>
        [DataMember(Name="reoffered", EmitDefaultValue=false)]
        public bool? Reoffered { get; set; }



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
        /// Indicates whether all flow sessions were self serviced
        /// </summary>
        /// <value>Indicates whether all flow sessions were self serviced</value>
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
        public List<ConversationMetricsTopicConversationProposedAgent> ProposedAgents { get; set; }



        /// <summary>
        /// Scored agents
        /// </summary>
        /// <value>Scored agents</value>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<ConversationMetricsTopicConversationScoredAgent> ScoredAgents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationMetricsTopicConversationMetricRecord {\n");

            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  MetricDate: ").Append(MetricDate).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
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
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ExtendedDeliveryStatus: ").Append(ExtendedDeliveryStatus).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  ExternalMediaCount: ").Append(ExternalMediaCount).Append("\n");
            sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
            sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
            sb.Append("  FirstQueue: ").Append(FirstQueue).Append("\n");
            sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
            sb.Append("  FlowInType: ").Append(FlowInType).Append("\n");
            sb.Append("  FlowOutType: ").Append(FlowOutType).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
            sb.Append("  JourneyActionId: ").Append(JourneyActionId).Append("\n");
            sb.Append("  JourneyActionMapId: ").Append(JourneyActionMapId).Append("\n");
            sb.Append("  JourneyActionMapVersion: ").Append(JourneyActionMapVersion).Append("\n");
            sb.Append("  JourneyCustomerId: ").Append(JourneyCustomerId).Append("\n");
            sb.Append("  JourneyCustomerIdType: ").Append(JourneyCustomerIdType).Append("\n");
            sb.Append("  JourneyCustomerSessionId: ").Append(JourneyCustomerSessionId).Append("\n");
            sb.Append("  JourneyCustomerSessionIdType: ").Append(JourneyCustomerSessionIdType).Append("\n");
            sb.Append("  KnowledgeBaseIds: ").Append(KnowledgeBaseIds).Append("\n");
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
            sb.Append("  Remote: ").Append(Remote).Append("\n");
            sb.Append("  RemovedSkillIds: ").Append(RemovedSkillIds).Append("\n");
            sb.Append("  Reoffered: ").Append(Reoffered).Append("\n");
            sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
            sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
            sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
            sb.Append("  RoutingRing: ").Append(RoutingRing).Append("\n");
            sb.Append("  SelectedAgentId: ").Append(SelectedAgentId).Append("\n");
            sb.Append("  SelectedAgentRank: ").Append(SelectedAgentRank).Append("\n");
            sb.Append("  SelfServed: ").Append(SelfServed).Append("\n");
            sb.Append("  SessionDnis: ").Append(SessionDnis).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  StationId: ").Append(StationId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  WaitingInteractionCounts: ").Append(WaitingInteractionCounts).Append("\n");
            sb.Append("  WrapUpCode: ").Append(WrapUpCode).Append("\n");
            sb.Append("  ProposedAgents: ").Append(ProposedAgents).Append("\n");
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
            return this.Equals(obj as ConversationMetricsTopicConversationMetricRecord);
        }

        /// <summary>
        /// Returns true if ConversationMetricsTopicConversationMetricRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationMetricsTopicConversationMetricRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationMetricsTopicConversationMetricRecord other)
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
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
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
                    this.FlowInType == other.FlowInType ||
                    this.FlowInType != null &&
                    this.FlowInType.Equals(other.FlowInType)
                ) &&
                (
                    this.FlowOutType == other.FlowOutType ||
                    this.FlowOutType != null &&
                    this.FlowOutType.Equals(other.FlowOutType)
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
                    this.KnowledgeBaseIds == other.KnowledgeBaseIds ||
                    this.KnowledgeBaseIds != null &&
                    this.KnowledgeBaseIds.SequenceEqual(other.KnowledgeBaseIds)
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
                    this.Reoffered == other.Reoffered ||
                    this.Reoffered != null &&
                    this.Reoffered.Equals(other.Reoffered)
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

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

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

                if (this.FlowInType != null)
                    hash = hash * 59 + this.FlowInType.GetHashCode();

                if (this.FlowOutType != null)
                    hash = hash * 59 + this.FlowOutType.GetHashCode();

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

                if (this.KnowledgeBaseIds != null)
                    hash = hash * 59 + this.KnowledgeBaseIds.GetHashCode();

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

                if (this.Remote != null)
                    hash = hash * 59 + this.Remote.GetHashCode();

                if (this.RemovedSkillIds != null)
                    hash = hash * 59 + this.RemovedSkillIds.GetHashCode();

                if (this.Reoffered != null)
                    hash = hash * 59 + this.Reoffered.GetHashCode();

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

                if (this.StationId != null)
                    hash = hash * 59 + this.StationId.GetHashCode();

                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();

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

                if (this.ScoredAgents != null)
                    hash = hash * 59 + this.ScoredAgents.GetHashCode();

                return hash;
            }
        }
    }

}
