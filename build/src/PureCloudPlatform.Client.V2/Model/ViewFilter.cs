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
    /// ViewFilter
    /// </summary>
    [DataContract]
    public partial class ViewFilter :  IEquatable<ViewFilter>
    {
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
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
        /// Gets or Sets Directions
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionsEnum
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
        /// Gets or Sets OriginatingDirections
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OriginatingDirectionsEnum
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
        /// Gets or Sets MessageTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessageTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms,
            
            /// <summary>
            /// Enum Twitter for "twitter"
            /// </summary>
            [EnumMember(Value = "twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Line for "line"
            /// </summary>
            [EnumMember(Value = "line")]
            Line,
            
            /// <summary>
            /// Enum Facebook for "facebook"
            /// </summary>
            [EnumMember(Value = "facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Whatsapp for "whatsapp"
            /// </summary>
            [EnumMember(Value = "whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "webmessaging"
            /// </summary>
            [EnumMember(Value = "webmessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open,
            
            /// <summary>
            /// Enum Instagram for "instagram"
            /// </summary>
            [EnumMember(Value = "instagram")]
            Instagram
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets FlowOutcomeValues
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlowOutcomeValuesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Success for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            /// <summary>
            /// Enum Failure for "FAILURE"
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            Failure
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets FlowDestinationTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlowDestinationTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Acd for "ACD"
            /// </summary>
            [EnumMember(Value = "ACD")]
            Acd,
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum Group for "GROUP"
            /// </summary>
            [EnumMember(Value = "GROUP")]
            Group,
            
            /// <summary>
            /// Enum Number for "NUMBER"
            /// </summary>
            [EnumMember(Value = "NUMBER")]
            Number,
            
            /// <summary>
            /// Enum Flow for "FLOW"
            /// </summary>
            [EnumMember(Value = "FLOW")]
            Flow,
            
            /// <summary>
            /// Enum SecureFlow for "SECURE_FLOW"
            /// </summary>
            [EnumMember(Value = "SECURE_FLOW")]
            SecureFlow,
            
            /// <summary>
            /// Enum AcdVoicemail for "ACD_VOICEMAIL"
            /// </summary>
            [EnumMember(Value = "ACD_VOICEMAIL")]
            AcdVoicemail,
            
            /// <summary>
            /// Enum UserVoicemail for "USER_VOICEMAIL"
            /// </summary>
            [EnumMember(Value = "USER_VOICEMAIL")]
            UserVoicemail,
            
            /// <summary>
            /// Enum GroupVoicemail for "GROUP_VOICEMAIL"
            /// </summary>
            [EnumMember(Value = "GROUP_VOICEMAIL")]
            GroupVoicemail,
            
            /// <summary>
            /// Enum ReturnToAgent for "RETURN_TO_AGENT"
            /// </summary>
            [EnumMember(Value = "RETURN_TO_AGENT")]
            ReturnToAgent
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets FlowDisconnectReasons
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlowDisconnectReasonsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum FlowDisconnect for "FLOW_DISCONNECT"
            /// </summary>
            [EnumMember(Value = "FLOW_DISCONNECT")]
            FlowDisconnect,
            
            /// <summary>
            /// Enum FlowErrorDisconnect for "FLOW_ERROR_DISCONNECT"
            /// </summary>
            [EnumMember(Value = "FLOW_ERROR_DISCONNECT")]
            FlowErrorDisconnect,
            
            /// <summary>
            /// Enum Disconnect for "DISCONNECT"
            /// </summary>
            [EnumMember(Value = "DISCONNECT")]
            Disconnect
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets FlowTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlowTypesEnum
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
            /// Enum Inqueueshortmessage for "inqueueshortmessage"
            /// </summary>
            [EnumMember(Value = "inqueueshortmessage")]
            Inqueueshortmessage,
            
            /// <summary>
            /// Enum Inqueueemail for "inqueueemail"
            /// </summary>
            [EnumMember(Value = "inqueueemail")]
            Inqueueemail,
            
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
            /// Enum Surveyinvite for "surveyinvite"
            /// </summary>
            [EnumMember(Value = "surveyinvite")]
            Surveyinvite,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
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
        /// Gets or Sets FlowEntryTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlowEntryTypesEnum
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
        /// Gets or Sets UsedRoutingTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UsedRoutingTypesEnum
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
            Standard
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets RequestedRoutingTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RequestedRoutingTypesEnum
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
            Standard
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ParticipantPurposes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ParticipantPurposesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Internal for "internal"
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal,
            
            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets JourneyActionMapTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum JourneyActionMapTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Webchat for "webchat"
            /// </summary>
            [EnumMember(Value = "webchat")]
            Webchat,
            
            /// <summary>
            /// Enum Webmessagingoffer for "webMessagingOffer"
            /// </summary>
            [EnumMember(Value = "webMessagingOffer")]
            Webmessagingoffer,
            
            /// <summary>
            /// Enum Contentoffer for "contentOffer"
            /// </summary>
            [EnumMember(Value = "contentOffer")]
            Contentoffer,
            
            /// <summary>
            /// Enum Integrationaction for "integrationAction"
            /// </summary>
            [EnumMember(Value = "integrationAction")]
            Integrationaction,
            
            /// <summary>
            /// Enum Architectflow for "architectFlow"
            /// </summary>
            [EnumMember(Value = "architectFlow")]
            Architectflow
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DevelopmentRoleList
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DevelopmentRoleListEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Creator for "Creator"
            /// </summary>
            [EnumMember(Value = "Creator")]
            Creator,
            
            /// <summary>
            /// Enum Facilitator for "Facilitator"
            /// </summary>
            [EnumMember(Value = "Facilitator")]
            Facilitator,
            
            /// <summary>
            /// Enum Attendee for "Attendee"
            /// </summary>
            [EnumMember(Value = "Attendee")]
            Attendee
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DevelopmentTypeList
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DevelopmentTypeListEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Informational for "Informational"
            /// </summary>
            [EnumMember(Value = "Informational")]
            Informational,
            
            /// <summary>
            /// Enum Coaching for "Coaching"
            /// </summary>
            [EnumMember(Value = "Coaching")]
            Coaching
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DevelopmentStatusList
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DevelopmentStatusListEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Planned for "Planned"
            /// </summary>
            [EnumMember(Value = "Planned")]
            Planned,
            
            /// <summary>
            /// Enum Scheduled for "Scheduled"
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Invalidschedule for "InvalidSchedule"
            /// </summary>
            [EnumMember(Value = "InvalidSchedule")]
            Invalidschedule,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets BotMessageTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BotMessageTypesEnum
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
            /// Enum Phone for "Phone"
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone,
            
            /// <summary>
            /// Enum Sms for "SMS"
            /// </summary>
            [EnumMember(Value = "SMS")]
            Sms,
            
            /// <summary>
            /// Enum Genesyschatwidget for "GenesysChatWidget"
            /// </summary>
            [EnumMember(Value = "GenesysChatWidget")]
            Genesyschatwidget,
            
            /// <summary>
            /// Enum Facebookmessenger for "FacebookMessenger"
            /// </summary>
            [EnumMember(Value = "FacebookMessenger")]
            Facebookmessenger,
            
            /// <summary>
            /// Enum Wechat for "WeChat"
            /// </summary>
            [EnumMember(Value = "WeChat")]
            Wechat,
            
            /// <summary>
            /// Enum Whatsapp for "Whatsapp"
            /// </summary>
            [EnumMember(Value = "Whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Applebusinesschat for "AppleBusinessChat"
            /// </summary>
            [EnumMember(Value = "AppleBusinessChat")]
            Applebusinesschat,
            
            /// <summary>
            /// Enum Telegram for "Telegram"
            /// </summary>
            [EnumMember(Value = "Telegram")]
            Telegram,
            
            /// <summary>
            /// Enum Slack for "Slack"
            /// </summary>
            [EnumMember(Value = "Slack")]
            Slack,
            
            /// <summary>
            /// Enum Signal for "Signal"
            /// </summary>
            [EnumMember(Value = "Signal")]
            Signal,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            [EnumMember(Value = "Line")]
            Line,
            
            /// <summary>
            /// Enum Discord for "Discord"
            /// </summary>
            [EnumMember(Value = "Discord")]
            Discord,
            
            /// <summary>
            /// Enum Twitterdirectmessage for "TwitterDirectMessage"
            /// </summary>
            [EnumMember(Value = "TwitterDirectMessage")]
            Twitterdirectmessage,
            
            /// <summary>
            /// Enum Other for "Other"
            /// </summary>
            [EnumMember(Value = "Other")]
            Other
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets BotProviderList
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BotProviderListEnum
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
            /// Enum Genesys for "Genesys"
            /// </summary>
            [EnumMember(Value = "Genesys")]
            Genesys,
            
            /// <summary>
            /// Enum Amazon for "Amazon"
            /// </summary>
            [EnumMember(Value = "Amazon")]
            Amazon,
            
            /// <summary>
            /// Enum Google for "Google"
            /// </summary>
            [EnumMember(Value = "Google")]
            Google,
            
            /// <summary>
            /// Enum Nuance for "Nuance"
            /// </summary>
            [EnumMember(Value = "Nuance")]
            Nuance
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets BotProductList
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BotProductListEnum
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
            /// Enum Genesysdialogengine for "GenesysDialogEngine"
            /// </summary>
            [EnumMember(Value = "GenesysDialogEngine")]
            Genesysdialogengine,
            
            /// <summary>
            /// Enum Amazonlex for "AmazonLex"
            /// </summary>
            [EnumMember(Value = "AmazonLex")]
            Amazonlex,
            
            /// <summary>
            /// Enum Googledialogflow for "GoogleDialogFlow"
            /// </summary>
            [EnumMember(Value = "GoogleDialogFlow")]
            Googledialogflow,
            
            /// <summary>
            /// Enum Googledialogflowresell for "GoogleDialogFlowResell"
            /// </summary>
            [EnumMember(Value = "GoogleDialogFlowResell")]
            Googledialogflowresell,
            
            /// <summary>
            /// Enum Genesysbotflow for "GenesysBotFlow"
            /// </summary>
            [EnumMember(Value = "GenesysBotFlow")]
            Genesysbotflow,
            
            /// <summary>
            /// Enum Nuancedlg for "NuanceDlg"
            /// </summary>
            [EnumMember(Value = "NuanceDlg")]
            Nuancedlg,
            
            /// <summary>
            /// Enum Googledialogflowcx for "GoogleDialogFlowCx"
            /// </summary>
            [EnumMember(Value = "GoogleDialogFlowCx")]
            Googledialogflowcx,
            
            /// <summary>
            /// Enum Genesysbyob for "GenesysByob"
            /// </summary>
            [EnumMember(Value = "GenesysByob")]
            Genesysbyob
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets BotRecognitionFailureReasonList
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BotRecognitionFailureReasonListEnum
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
            /// Enum Noinputcollection for "NoInputCollection"
            /// </summary>
            [EnumMember(Value = "NoInputCollection")]
            Noinputcollection,
            
            /// <summary>
            /// Enum Noinputconfirmation for "NoInputConfirmation"
            /// </summary>
            [EnumMember(Value = "NoInputConfirmation")]
            Noinputconfirmation,
            
            /// <summary>
            /// Enum Nomatchcollection for "NoMatchCollection"
            /// </summary>
            [EnumMember(Value = "NoMatchCollection")]
            Nomatchcollection,
            
            /// <summary>
            /// Enum Nomatchconfirmation for "NoMatchConfirmation"
            /// </summary>
            [EnumMember(Value = "NoMatchConfirmation")]
            Nomatchconfirmation,
            
            /// <summary>
            /// Enum Maxwrongmatch for "MaxWrongMatch"
            /// </summary>
            [EnumMember(Value = "MaxWrongMatch")]
            Maxwrongmatch
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets BotResultList
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BotResultListEnum
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
            /// Enum Exitrequestedbyuser for "ExitRequestedByUser"
            /// </summary>
            [EnumMember(Value = "ExitRequestedByUser")]
            Exitrequestedbyuser,
            
            /// <summary>
            /// Enum Exitrequestedbybot for "ExitRequestedByBot"
            /// </summary>
            [EnumMember(Value = "ExitRequestedByBot")]
            Exitrequestedbybot,
            
            /// <summary>
            /// Enum Exiterror for "ExitError"
            /// </summary>
            [EnumMember(Value = "ExitError")]
            Exiterror,
            
            /// <summary>
            /// Enum Exitrecognitionfailure for "ExitRecognitionFailure"
            /// </summary>
            [EnumMember(Value = "ExitRecognitionFailure")]
            Exitrecognitionfailure,
            
            /// <summary>
            /// Enum Disconnectrequestedbyuser for "DisconnectRequestedByUser"
            /// </summary>
            [EnumMember(Value = "DisconnectRequestedByUser")]
            Disconnectrequestedbyuser,
            
            /// <summary>
            /// Enum Disconnectrequestedbybot for "DisconnectRequestedByBot"
            /// </summary>
            [EnumMember(Value = "DisconnectRequestedByBot")]
            Disconnectrequestedbybot,
            
            /// <summary>
            /// Enum Disconnectsessionexpired for "DisconnectSessionExpired"
            /// </summary>
            [EnumMember(Value = "DisconnectSessionExpired")]
            Disconnectsessionexpired,
            
            /// <summary>
            /// Enum Disconnecterror for "DisconnectError"
            /// </summary>
            [EnumMember(Value = "DisconnectError")]
            Disconnecterror,
            
            /// <summary>
            /// Enum Disconnectrecognitionfailure for "DisconnectRecognitionFailure"
            /// </summary>
            [EnumMember(Value = "DisconnectRecognitionFailure")]
            Disconnectrecognitionfailure
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets BlockedReasons
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BlockedReasonsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Pageurlconditionsnotmatching for "PageUrlConditionsNotMatching"
            /// </summary>
            [EnumMember(Value = "PageUrlConditionsNotMatching")]
            Pageurlconditionsnotmatching,
            
            /// <summary>
            /// Enum Alreadyexistingoffer for "AlreadyExistingOffer"
            /// </summary>
            [EnumMember(Value = "AlreadyExistingOffer")]
            Alreadyexistingoffer,
            
            /// <summary>
            /// Enum Triggerdateinfuture for "TriggerDateInFuture"
            /// </summary>
            [EnumMember(Value = "TriggerDateInFuture")]
            Triggerdateinfuture,
            
            /// <summary>
            /// Enum Multiplesimultaneousoffers for "MultipleSimultaneousOffers"
            /// </summary>
            [EnumMember(Value = "MultipleSimultaneousOffers")]
            Multiplesimultaneousoffers,
            
            /// <summary>
            /// Enum Frequencycapping for "FrequencyCapping"
            /// </summary>
            [EnumMember(Value = "FrequencyCapping")]
            Frequencycapping,
            
            /// <summary>
            /// Enum Offeredoutsideschedule for "OfferedOutsideSchedule"
            /// </summary>
            [EnumMember(Value = "OfferedOutsideSchedule")]
            Offeredoutsideschedule,
            
            /// <summary>
            /// Enum Servicelevelthrottling for "ServiceLevelThrottling"
            /// </summary>
            [EnumMember(Value = "ServiceLevelThrottling")]
            Servicelevelthrottling,
            
            /// <summary>
            /// Enum Noavailableagents for "NoAvailableAgents"
            /// </summary>
            [EnumMember(Value = "NoAvailableAgents")]
            Noavailableagents
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewFilter" /> class.
        /// </summary>
        /// <param name="MediaTypes">The media types are used to filter the view.</param>
        /// <param name="QueueIds">The queue ids are used to filter the view.</param>
        /// <param name="SkillIds">The skill ids are used to filter the view.</param>
        /// <param name="SkillGroups">The skill groups used to filter the view.</param>
        /// <param name="LanguageIds">The language ids are used to filter the view.</param>
        /// <param name="LanguageGroups">The language groups used to filter the view.</param>
        /// <param name="Directions">The directions are used to filter the view.</param>
        /// <param name="OriginatingDirections">The list of orginating directions used to filter the view.</param>
        /// <param name="WrapUpCodes">The wrap up codes are used to filter the view.</param>
        /// <param name="DnisList">The dnis list is used to filter the view.</param>
        /// <param name="SessionDnisList">The list of session dnis used to filter the view.</param>
        /// <param name="FilterQueuesByUserIds">The user ids are used to fetch associated queues for the view.</param>
        /// <param name="FilterUsersByQueueIds">The queue ids are used to fetch associated users for the view.</param>
        /// <param name="UserIds">The user ids are used to filter the view.</param>
        /// <param name="AddressTos">The address To values are used to filter the view.</param>
        /// <param name="AddressFroms">The address from values are used to filter the view.</param>
        /// <param name="OutboundCampaignIds">The outbound campaign ids are used to filter the view.</param>
        /// <param name="OutboundContactListIds">The outbound contact list ids are used to filter the view.</param>
        /// <param name="ContactIds">The contact ids are used to filter the view.</param>
        /// <param name="ExternalContactIds">The external contact ids are used to filter the view.</param>
        /// <param name="ExternalOrgIds">The external org ids are used to filter the view.</param>
        /// <param name="AniList">The ani list ids are used to filter the view.</param>
        /// <param name="DurationsMilliseconds">The durations in milliseconds used to filter the view.</param>
        /// <param name="AcdDurationsMilliseconds">The acd durations in milliseconds used to filter the view.</param>
        /// <param name="TalkDurationsMilliseconds">The talk durations in milliseconds used to filter the view.</param>
        /// <param name="AcwDurationsMilliseconds">The acw durations in milliseconds used to filter the view.</param>
        /// <param name="HandleDurationsMilliseconds">The handle durations in milliseconds used to filter the view.</param>
        /// <param name="HoldDurationsMilliseconds">The hold durations in milliseconds used to filter the view.</param>
        /// <param name="AbandonDurationsMilliseconds">The abandon durations in milliseconds used to filter the view.</param>
        /// <param name="EvaluationScore">The evaluationScore is used to filter the view.</param>
        /// <param name="EvaluationCriticalScore">The evaluationCriticalScore is used to filter the view.</param>
        /// <param name="EvaluationFormIds">The evaluation form ids are used to filter the view.</param>
        /// <param name="EvaluatedAgentIds">The evaluated agent ids are used to filter the view.</param>
        /// <param name="EvaluatorIds">The evaluator ids are used to filter the view.</param>
        /// <param name="Transferred">Indicates filtering for transfers.</param>
        /// <param name="Abandoned">Indicates filtering for abandons.</param>
        /// <param name="Answered">Indicates filtering for answered interactions.</param>
        /// <param name="MessageTypes">The message media types used to filter the view.</param>
        /// <param name="DivisionIds">The divison Ids used to filter the view.</param>
        /// <param name="SurveyFormIds">The survey form ids used to filter the view.</param>
        /// <param name="SurveyTotalScore">The survey total score used to filter the view.</param>
        /// <param name="SurveyNpsScore">The survey NPS score used to filter the view.</param>
        /// <param name="Mos">The desired range for mos values.</param>
        /// <param name="SurveyQuestionGroupScore">The survey question group score used to filter the view.</param>
        /// <param name="SurveyPromoterScore">The survey promoter score used to filter the view.</param>
        /// <param name="SurveyFormContextIds">The list of survey form context ids used to filter the view.</param>
        /// <param name="ConversationIds">The list of conversation ids used to filter the view.</param>
        /// <param name="SipCallIds">The list of SIP call ids used to filter the view.</param>
        /// <param name="IsEnded">Indicates filtering for ended.</param>
        /// <param name="IsSurveyed">Indicates filtering for survey.</param>
        /// <param name="SurveyScores">The list of survey score ranges used to filter the view.</param>
        /// <param name="PromoterScores">The list of promoter score ranges used to filter the view.</param>
        /// <param name="IsCampaign">Indicates filtering for campaign.</param>
        /// <param name="SurveyStatuses">The list of survey statuses used to filter the view.</param>
        /// <param name="ConversationProperties">A grouping of conversation level filters.</param>
        /// <param name="IsBlindTransferred">Indicates filtering for blind transferred.</param>
        /// <param name="IsConsulted">Indicates filtering for consulted.</param>
        /// <param name="IsConsultTransferred">Indicates filtering for consult transferred.</param>
        /// <param name="RemoteParticipants">The list of remote participants used to filter the view.</param>
        /// <param name="FlowIds">The list of flow Ids.</param>
        /// <param name="FlowOutcomeIds">A list of outcome ids of the flow.</param>
        /// <param name="FlowOutcomeValues">A list of outcome values of the flow.</param>
        /// <param name="FlowDestinationTypes">The list of destination types of the flow.</param>
        /// <param name="FlowDisconnectReasons">The list of reasons for the flow to disconnect.</param>
        /// <param name="FlowTypes">A list of types of the flow.</param>
        /// <param name="FlowEntryTypes">A list of types of the flow entry.</param>
        /// <param name="FlowEntryReasons">A list of reasons of flow entry.</param>
        /// <param name="FlowVersions">A list of versions of a flow.</param>
        /// <param name="GroupIds">A list of directory group ids.</param>
        /// <param name="HasJourneyCustomerId">Indicates filtering for journey customer id.</param>
        /// <param name="HasJourneyActionMapId">Indicates filtering for Journey action map id.</param>
        /// <param name="HasJourneyVisitId">Indicates filtering for Journey visit id.</param>
        /// <param name="HasMedia">Indicates filtering for presence of MMS media.</param>
        /// <param name="RoleIds">The role Ids used to filter the view.</param>
        /// <param name="ReportsTos">The report to user IDs used to filter the view.</param>
        /// <param name="LocationIds">The location Ids used to filter the view.</param>
        /// <param name="FlowOutTypes">A list of flow out types.</param>
        /// <param name="ProviderList">A list of providers.</param>
        /// <param name="CallbackNumberList">A list of callback numbers or substrings of numbers (ex: [\&quot;317\&quot;, \&quot;13172222222\&quot;]).</param>
        /// <param name="CallbackInterval">An interval of time to filter for scheduled callbacks. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="UsedRoutingTypes">A list of routing types used.</param>
        /// <param name="RequestedRoutingTypes">A list of routing types requested.</param>
        /// <param name="HasAgentAssistId">Indicates filtering for agent assist id.</param>
        /// <param name="Transcripts">A list of transcript contents requested.</param>
        /// <param name="TranscriptLanguages">A list of transcript languages requested.</param>
        /// <param name="ParticipantPurposes">A list of participant purpose requested.</param>
        /// <param name="ShowFirstQueue">Indicates filtering for first queue data.</param>
        /// <param name="TeamIds">The team ids used to filter the view data.</param>
        /// <param name="FilterUsersByTeamIds">The team ids are used to fetch associated users for the view.</param>
        /// <param name="JourneyActionMapIds">The journey action map ids are used to fetch action maps for the associated view.</param>
        /// <param name="JourneyOutcomeIds">The journey outcome ids are used to fetch outcomes for the associated view.</param>
        /// <param name="JourneySegmentIds">The journey segment ids are used to fetch segments for the associated view.</param>
        /// <param name="JourneyActionMapTypes">The journey action map types are used to filter action map data for the associated view.</param>
        /// <param name="DevelopmentRoleList">The list of development roles used to filter agent development view.</param>
        /// <param name="DevelopmentTypeList">The list of development types used to filter agent development view.</param>
        /// <param name="DevelopmentStatusList">The list of development status used to filter agent development view.</param>
        /// <param name="DevelopmentModuleIds">The list of development moduleIds used to filter agent development view.</param>
        /// <param name="DevelopmentActivityOverdue">Indicates filtering for development activities.</param>
        /// <param name="CustomerSentimentScore">The customer sentiment score used to filter the view.</param>
        /// <param name="CustomerSentimentTrend">The customer sentiment trend used to filter the view.</param>
        /// <param name="FlowTransferTargets">The list of transfer targets used to filter flow data.</param>
        /// <param name="DevelopmentName">Filter for development name.</param>
        /// <param name="TopicIds">Represents the topics detected in the transcript.</param>
        /// <param name="ExternalTags">The list of external Tags used to filter conversation data.</param>
        /// <param name="IsNotResponding">Indicates filtering for not responding users.</param>
        /// <param name="IsAuthenticated">Indicates filtering for the authenticated chat.</param>
        /// <param name="BotIds">The list of bot IDs used to filter bot views.</param>
        /// <param name="BotVersions">The list of bot versions used to filter bot views.</param>
        /// <param name="BotMessageTypes">The list of bot message types used to filter bot views.</param>
        /// <param name="BotProviderList">The list of bot providers used to filter bot views.</param>
        /// <param name="BotProductList">The list of bot products used to filter bot views.</param>
        /// <param name="BotRecognitionFailureReasonList">The list of bot recognition failure reasons used to filter bot views.</param>
        /// <param name="BotIntentList">The list of bot intents used to filter bot views.</param>
        /// <param name="BotFinalIntentList">The list of bot final intents used to filter bot views.</param>
        /// <param name="BotSlotList">The list of bot slots used to filter bot views.</param>
        /// <param name="BotResultList">The list of bot results used to filter bot views.</param>
        /// <param name="BlockedReasons">The list of blocked reason used to filter action map constraints views.</param>
        public ViewFilter(List<MediaTypesEnum> MediaTypes = null, List<string> QueueIds = null, List<string> SkillIds = null, List<string> SkillGroups = null, List<string> LanguageIds = null, List<string> LanguageGroups = null, List<DirectionsEnum> Directions = null, List<OriginatingDirectionsEnum> OriginatingDirections = null, List<string> WrapUpCodes = null, List<string> DnisList = null, List<string> SessionDnisList = null, List<string> FilterQueuesByUserIds = null, List<string> FilterUsersByQueueIds = null, List<string> UserIds = null, List<string> AddressTos = null, List<string> AddressFroms = null, List<string> OutboundCampaignIds = null, List<string> OutboundContactListIds = null, List<string> ContactIds = null, List<string> ExternalContactIds = null, List<string> ExternalOrgIds = null, List<string> AniList = null, List<NumericRange> DurationsMilliseconds = null, List<NumericRange> AcdDurationsMilliseconds = null, List<NumericRange> TalkDurationsMilliseconds = null, List<NumericRange> AcwDurationsMilliseconds = null, List<NumericRange> HandleDurationsMilliseconds = null, List<NumericRange> HoldDurationsMilliseconds = null, List<NumericRange> AbandonDurationsMilliseconds = null, NumericRange EvaluationScore = null, NumericRange EvaluationCriticalScore = null, List<string> EvaluationFormIds = null, List<string> EvaluatedAgentIds = null, List<string> EvaluatorIds = null, bool? Transferred = null, bool? Abandoned = null, bool? Answered = null, List<MessageTypesEnum> MessageTypes = null, List<string> DivisionIds = null, List<string> SurveyFormIds = null, NumericRange SurveyTotalScore = null, NumericRange SurveyNpsScore = null, NumericRange Mos = null, NumericRange SurveyQuestionGroupScore = null, NumericRange SurveyPromoterScore = null, List<string> SurveyFormContextIds = null, List<string> ConversationIds = null, List<string> SipCallIds = null, bool? IsEnded = null, bool? IsSurveyed = null, List<NumericRange> SurveyScores = null, List<NumericRange> PromoterScores = null, bool? IsCampaign = null, List<string> SurveyStatuses = null, ConversationProperties ConversationProperties = null, bool? IsBlindTransferred = null, bool? IsConsulted = null, bool? IsConsultTransferred = null, List<string> RemoteParticipants = null, List<string> FlowIds = null, List<string> FlowOutcomeIds = null, List<FlowOutcomeValuesEnum> FlowOutcomeValues = null, List<FlowDestinationTypesEnum> FlowDestinationTypes = null, List<FlowDisconnectReasonsEnum> FlowDisconnectReasons = null, List<FlowTypesEnum> FlowTypes = null, List<FlowEntryTypesEnum> FlowEntryTypes = null, List<string> FlowEntryReasons = null, List<string> FlowVersions = null, List<string> GroupIds = null, bool? HasJourneyCustomerId = null, bool? HasJourneyActionMapId = null, bool? HasJourneyVisitId = null, bool? HasMedia = null, List<string> RoleIds = null, List<string> ReportsTos = null, List<string> LocationIds = null, List<string> FlowOutTypes = null, List<string> ProviderList = null, List<string> CallbackNumberList = null, string CallbackInterval = null, List<UsedRoutingTypesEnum> UsedRoutingTypes = null, List<RequestedRoutingTypesEnum> RequestedRoutingTypes = null, bool? HasAgentAssistId = null, List<Transcripts> Transcripts = null, List<string> TranscriptLanguages = null, List<ParticipantPurposesEnum> ParticipantPurposes = null, bool? ShowFirstQueue = null, List<string> TeamIds = null, List<string> FilterUsersByTeamIds = null, List<string> JourneyActionMapIds = null, List<string> JourneyOutcomeIds = null, List<string> JourneySegmentIds = null, List<JourneyActionMapTypesEnum> JourneyActionMapTypes = null, List<DevelopmentRoleListEnum> DevelopmentRoleList = null, List<DevelopmentTypeListEnum> DevelopmentTypeList = null, List<DevelopmentStatusListEnum> DevelopmentStatusList = null, List<string> DevelopmentModuleIds = null, bool? DevelopmentActivityOverdue = null, NumericRange CustomerSentimentScore = null, NumericRange CustomerSentimentTrend = null, List<string> FlowTransferTargets = null, string DevelopmentName = null, List<string> TopicIds = null, List<string> ExternalTags = null, bool? IsNotResponding = null, bool? IsAuthenticated = null, List<string> BotIds = null, List<string> BotVersions = null, List<BotMessageTypesEnum> BotMessageTypes = null, List<BotProviderListEnum> BotProviderList = null, List<BotProductListEnum> BotProductList = null, List<BotRecognitionFailureReasonListEnum> BotRecognitionFailureReasonList = null, List<string> BotIntentList = null, List<string> BotFinalIntentList = null, List<string> BotSlotList = null, List<BotResultListEnum> BotResultList = null, List<BlockedReasonsEnum> BlockedReasons = null)
        {
            this.MediaTypes = MediaTypes;
            this.QueueIds = QueueIds;
            this.SkillIds = SkillIds;
            this.SkillGroups = SkillGroups;
            this.LanguageIds = LanguageIds;
            this.LanguageGroups = LanguageGroups;
            this.Directions = Directions;
            this.OriginatingDirections = OriginatingDirections;
            this.WrapUpCodes = WrapUpCodes;
            this.DnisList = DnisList;
            this.SessionDnisList = SessionDnisList;
            this.FilterQueuesByUserIds = FilterQueuesByUserIds;
            this.FilterUsersByQueueIds = FilterUsersByQueueIds;
            this.UserIds = UserIds;
            this.AddressTos = AddressTos;
            this.AddressFroms = AddressFroms;
            this.OutboundCampaignIds = OutboundCampaignIds;
            this.OutboundContactListIds = OutboundContactListIds;
            this.ContactIds = ContactIds;
            this.ExternalContactIds = ExternalContactIds;
            this.ExternalOrgIds = ExternalOrgIds;
            this.AniList = AniList;
            this.DurationsMilliseconds = DurationsMilliseconds;
            this.AcdDurationsMilliseconds = AcdDurationsMilliseconds;
            this.TalkDurationsMilliseconds = TalkDurationsMilliseconds;
            this.AcwDurationsMilliseconds = AcwDurationsMilliseconds;
            this.HandleDurationsMilliseconds = HandleDurationsMilliseconds;
            this.HoldDurationsMilliseconds = HoldDurationsMilliseconds;
            this.AbandonDurationsMilliseconds = AbandonDurationsMilliseconds;
            this.EvaluationScore = EvaluationScore;
            this.EvaluationCriticalScore = EvaluationCriticalScore;
            this.EvaluationFormIds = EvaluationFormIds;
            this.EvaluatedAgentIds = EvaluatedAgentIds;
            this.EvaluatorIds = EvaluatorIds;
            this.Transferred = Transferred;
            this.Abandoned = Abandoned;
            this.Answered = Answered;
            this.MessageTypes = MessageTypes;
            this.DivisionIds = DivisionIds;
            this.SurveyFormIds = SurveyFormIds;
            this.SurveyTotalScore = SurveyTotalScore;
            this.SurveyNpsScore = SurveyNpsScore;
            this.Mos = Mos;
            this.SurveyQuestionGroupScore = SurveyQuestionGroupScore;
            this.SurveyPromoterScore = SurveyPromoterScore;
            this.SurveyFormContextIds = SurveyFormContextIds;
            this.ConversationIds = ConversationIds;
            this.SipCallIds = SipCallIds;
            this.IsEnded = IsEnded;
            this.IsSurveyed = IsSurveyed;
            this.SurveyScores = SurveyScores;
            this.PromoterScores = PromoterScores;
            this.IsCampaign = IsCampaign;
            this.SurveyStatuses = SurveyStatuses;
            this.ConversationProperties = ConversationProperties;
            this.IsBlindTransferred = IsBlindTransferred;
            this.IsConsulted = IsConsulted;
            this.IsConsultTransferred = IsConsultTransferred;
            this.RemoteParticipants = RemoteParticipants;
            this.FlowIds = FlowIds;
            this.FlowOutcomeIds = FlowOutcomeIds;
            this.FlowOutcomeValues = FlowOutcomeValues;
            this.FlowDestinationTypes = FlowDestinationTypes;
            this.FlowDisconnectReasons = FlowDisconnectReasons;
            this.FlowTypes = FlowTypes;
            this.FlowEntryTypes = FlowEntryTypes;
            this.FlowEntryReasons = FlowEntryReasons;
            this.FlowVersions = FlowVersions;
            this.GroupIds = GroupIds;
            this.HasJourneyCustomerId = HasJourneyCustomerId;
            this.HasJourneyActionMapId = HasJourneyActionMapId;
            this.HasJourneyVisitId = HasJourneyVisitId;
            this.HasMedia = HasMedia;
            this.RoleIds = RoleIds;
            this.ReportsTos = ReportsTos;
            this.LocationIds = LocationIds;
            this.FlowOutTypes = FlowOutTypes;
            this.ProviderList = ProviderList;
            this.CallbackNumberList = CallbackNumberList;
            this.CallbackInterval = CallbackInterval;
            this.UsedRoutingTypes = UsedRoutingTypes;
            this.RequestedRoutingTypes = RequestedRoutingTypes;
            this.HasAgentAssistId = HasAgentAssistId;
            this.Transcripts = Transcripts;
            this.TranscriptLanguages = TranscriptLanguages;
            this.ParticipantPurposes = ParticipantPurposes;
            this.ShowFirstQueue = ShowFirstQueue;
            this.TeamIds = TeamIds;
            this.FilterUsersByTeamIds = FilterUsersByTeamIds;
            this.JourneyActionMapIds = JourneyActionMapIds;
            this.JourneyOutcomeIds = JourneyOutcomeIds;
            this.JourneySegmentIds = JourneySegmentIds;
            this.JourneyActionMapTypes = JourneyActionMapTypes;
            this.DevelopmentRoleList = DevelopmentRoleList;
            this.DevelopmentTypeList = DevelopmentTypeList;
            this.DevelopmentStatusList = DevelopmentStatusList;
            this.DevelopmentModuleIds = DevelopmentModuleIds;
            this.DevelopmentActivityOverdue = DevelopmentActivityOverdue;
            this.CustomerSentimentScore = CustomerSentimentScore;
            this.CustomerSentimentTrend = CustomerSentimentTrend;
            this.FlowTransferTargets = FlowTransferTargets;
            this.DevelopmentName = DevelopmentName;
            this.TopicIds = TopicIds;
            this.ExternalTags = ExternalTags;
            this.IsNotResponding = IsNotResponding;
            this.IsAuthenticated = IsAuthenticated;
            this.BotIds = BotIds;
            this.BotVersions = BotVersions;
            this.BotMessageTypes = BotMessageTypes;
            this.BotProviderList = BotProviderList;
            this.BotProductList = BotProductList;
            this.BotRecognitionFailureReasonList = BotRecognitionFailureReasonList;
            this.BotIntentList = BotIntentList;
            this.BotFinalIntentList = BotFinalIntentList;
            this.BotSlotList = BotSlotList;
            this.BotResultList = BotResultList;
            this.BlockedReasons = BlockedReasons;
            
        }
        
        
        
        /// <summary>
        /// The media types are used to filter the view
        /// </summary>
        /// <value>The media types are used to filter the view</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }
        
        
        
        /// <summary>
        /// The queue ids are used to filter the view
        /// </summary>
        /// <value>The queue ids are used to filter the view</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; set; }
        
        
        
        /// <summary>
        /// The skill ids are used to filter the view
        /// </summary>
        /// <value>The skill ids are used to filter the view</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }
        
        
        
        /// <summary>
        /// The skill groups used to filter the view
        /// </summary>
        /// <value>The skill groups used to filter the view</value>
        [DataMember(Name="skillGroups", EmitDefaultValue=false)]
        public List<string> SkillGroups { get; set; }
        
        
        
        /// <summary>
        /// The language ids are used to filter the view
        /// </summary>
        /// <value>The language ids are used to filter the view</value>
        [DataMember(Name="languageIds", EmitDefaultValue=false)]
        public List<string> LanguageIds { get; set; }
        
        
        
        /// <summary>
        /// The language groups used to filter the view
        /// </summary>
        /// <value>The language groups used to filter the view</value>
        [DataMember(Name="languageGroups", EmitDefaultValue=false)]
        public List<string> LanguageGroups { get; set; }
        
        
        
        /// <summary>
        /// The directions are used to filter the view
        /// </summary>
        /// <value>The directions are used to filter the view</value>
        [DataMember(Name="directions", EmitDefaultValue=false)]
        public List<DirectionsEnum> Directions { get; set; }
        
        
        
        /// <summary>
        /// The list of orginating directions used to filter the view
        /// </summary>
        /// <value>The list of orginating directions used to filter the view</value>
        [DataMember(Name="originatingDirections", EmitDefaultValue=false)]
        public List<OriginatingDirectionsEnum> OriginatingDirections { get; set; }
        
        
        
        /// <summary>
        /// The wrap up codes are used to filter the view
        /// </summary>
        /// <value>The wrap up codes are used to filter the view</value>
        [DataMember(Name="wrapUpCodes", EmitDefaultValue=false)]
        public List<string> WrapUpCodes { get; set; }
        
        
        
        /// <summary>
        /// The dnis list is used to filter the view
        /// </summary>
        /// <value>The dnis list is used to filter the view</value>
        [DataMember(Name="dnisList", EmitDefaultValue=false)]
        public List<string> DnisList { get; set; }
        
        
        
        /// <summary>
        /// The list of session dnis used to filter the view
        /// </summary>
        /// <value>The list of session dnis used to filter the view</value>
        [DataMember(Name="sessionDnisList", EmitDefaultValue=false)]
        public List<string> SessionDnisList { get; set; }
        
        
        
        /// <summary>
        /// The user ids are used to fetch associated queues for the view
        /// </summary>
        /// <value>The user ids are used to fetch associated queues for the view</value>
        [DataMember(Name="filterQueuesByUserIds", EmitDefaultValue=false)]
        public List<string> FilterQueuesByUserIds { get; set; }
        
        
        
        /// <summary>
        /// The queue ids are used to fetch associated users for the view
        /// </summary>
        /// <value>The queue ids are used to fetch associated users for the view</value>
        [DataMember(Name="filterUsersByQueueIds", EmitDefaultValue=false)]
        public List<string> FilterUsersByQueueIds { get; set; }
        
        
        
        /// <summary>
        /// The user ids are used to filter the view
        /// </summary>
        /// <value>The user ids are used to filter the view</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }
        
        
        
        /// <summary>
        /// The address To values are used to filter the view
        /// </summary>
        /// <value>The address To values are used to filter the view</value>
        [DataMember(Name="addressTos", EmitDefaultValue=false)]
        public List<string> AddressTos { get; set; }
        
        
        
        /// <summary>
        /// The address from values are used to filter the view
        /// </summary>
        /// <value>The address from values are used to filter the view</value>
        [DataMember(Name="addressFroms", EmitDefaultValue=false)]
        public List<string> AddressFroms { get; set; }
        
        
        
        /// <summary>
        /// The outbound campaign ids are used to filter the view
        /// </summary>
        /// <value>The outbound campaign ids are used to filter the view</value>
        [DataMember(Name="outboundCampaignIds", EmitDefaultValue=false)]
        public List<string> OutboundCampaignIds { get; set; }
        
        
        
        /// <summary>
        /// The outbound contact list ids are used to filter the view
        /// </summary>
        /// <value>The outbound contact list ids are used to filter the view</value>
        [DataMember(Name="outboundContactListIds", EmitDefaultValue=false)]
        public List<string> OutboundContactListIds { get; set; }
        
        
        
        /// <summary>
        /// The contact ids are used to filter the view
        /// </summary>
        /// <value>The contact ids are used to filter the view</value>
        [DataMember(Name="contactIds", EmitDefaultValue=false)]
        public List<string> ContactIds { get; set; }
        
        
        
        /// <summary>
        /// The external contact ids are used to filter the view
        /// </summary>
        /// <value>The external contact ids are used to filter the view</value>
        [DataMember(Name="externalContactIds", EmitDefaultValue=false)]
        public List<string> ExternalContactIds { get; set; }
        
        
        
        /// <summary>
        /// The external org ids are used to filter the view
        /// </summary>
        /// <value>The external org ids are used to filter the view</value>
        [DataMember(Name="externalOrgIds", EmitDefaultValue=false)]
        public List<string> ExternalOrgIds { get; set; }
        
        
        
        /// <summary>
        /// The ani list ids are used to filter the view
        /// </summary>
        /// <value>The ani list ids are used to filter the view</value>
        [DataMember(Name="aniList", EmitDefaultValue=false)]
        public List<string> AniList { get; set; }
        
        
        
        /// <summary>
        /// The durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The durations in milliseconds used to filter the view</value>
        [DataMember(Name="durationsMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> DurationsMilliseconds { get; set; }
        
        
        
        /// <summary>
        /// The acd durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The acd durations in milliseconds used to filter the view</value>
        [DataMember(Name="acdDurationsMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> AcdDurationsMilliseconds { get; set; }
        
        
        
        /// <summary>
        /// The talk durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The talk durations in milliseconds used to filter the view</value>
        [DataMember(Name="talkDurationsMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> TalkDurationsMilliseconds { get; set; }
        
        
        
        /// <summary>
        /// The acw durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The acw durations in milliseconds used to filter the view</value>
        [DataMember(Name="acwDurationsMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> AcwDurationsMilliseconds { get; set; }
        
        
        
        /// <summary>
        /// The handle durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The handle durations in milliseconds used to filter the view</value>
        [DataMember(Name="handleDurationsMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> HandleDurationsMilliseconds { get; set; }
        
        
        
        /// <summary>
        /// The hold durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The hold durations in milliseconds used to filter the view</value>
        [DataMember(Name="holdDurationsMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> HoldDurationsMilliseconds { get; set; }
        
        
        
        /// <summary>
        /// The abandon durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The abandon durations in milliseconds used to filter the view</value>
        [DataMember(Name="abandonDurationsMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> AbandonDurationsMilliseconds { get; set; }
        
        
        
        /// <summary>
        /// The evaluationScore is used to filter the view
        /// </summary>
        /// <value>The evaluationScore is used to filter the view</value>
        [DataMember(Name="evaluationScore", EmitDefaultValue=false)]
        public NumericRange EvaluationScore { get; set; }
        
        
        
        /// <summary>
        /// The evaluationCriticalScore is used to filter the view
        /// </summary>
        /// <value>The evaluationCriticalScore is used to filter the view</value>
        [DataMember(Name="evaluationCriticalScore", EmitDefaultValue=false)]
        public NumericRange EvaluationCriticalScore { get; set; }
        
        
        
        /// <summary>
        /// The evaluation form ids are used to filter the view
        /// </summary>
        /// <value>The evaluation form ids are used to filter the view</value>
        [DataMember(Name="evaluationFormIds", EmitDefaultValue=false)]
        public List<string> EvaluationFormIds { get; set; }
        
        
        
        /// <summary>
        /// The evaluated agent ids are used to filter the view
        /// </summary>
        /// <value>The evaluated agent ids are used to filter the view</value>
        [DataMember(Name="evaluatedAgentIds", EmitDefaultValue=false)]
        public List<string> EvaluatedAgentIds { get; set; }
        
        
        
        /// <summary>
        /// The evaluator ids are used to filter the view
        /// </summary>
        /// <value>The evaluator ids are used to filter the view</value>
        [DataMember(Name="evaluatorIds", EmitDefaultValue=false)]
        public List<string> EvaluatorIds { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for transfers
        /// </summary>
        /// <value>Indicates filtering for transfers</value>
        [DataMember(Name="transferred", EmitDefaultValue=false)]
        public bool? Transferred { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for abandons
        /// </summary>
        /// <value>Indicates filtering for abandons</value>
        [DataMember(Name="abandoned", EmitDefaultValue=false)]
        public bool? Abandoned { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for answered interactions
        /// </summary>
        /// <value>Indicates filtering for answered interactions</value>
        [DataMember(Name="answered", EmitDefaultValue=false)]
        public bool? Answered { get; set; }
        
        
        
        /// <summary>
        /// The message media types used to filter the view
        /// </summary>
        /// <value>The message media types used to filter the view</value>
        [DataMember(Name="messageTypes", EmitDefaultValue=false)]
        public List<MessageTypesEnum> MessageTypes { get; set; }
        
        
        
        /// <summary>
        /// The divison Ids used to filter the view
        /// </summary>
        /// <value>The divison Ids used to filter the view</value>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }
        
        
        
        /// <summary>
        /// The survey form ids used to filter the view
        /// </summary>
        /// <value>The survey form ids used to filter the view</value>
        [DataMember(Name="surveyFormIds", EmitDefaultValue=false)]
        public List<string> SurveyFormIds { get; set; }
        
        
        
        /// <summary>
        /// The survey total score used to filter the view
        /// </summary>
        /// <value>The survey total score used to filter the view</value>
        [DataMember(Name="surveyTotalScore", EmitDefaultValue=false)]
        public NumericRange SurveyTotalScore { get; set; }
        
        
        
        /// <summary>
        /// The survey NPS score used to filter the view
        /// </summary>
        /// <value>The survey NPS score used to filter the view</value>
        [DataMember(Name="surveyNpsScore", EmitDefaultValue=false)]
        public NumericRange SurveyNpsScore { get; set; }
        
        
        
        /// <summary>
        /// The desired range for mos values
        /// </summary>
        /// <value>The desired range for mos values</value>
        [DataMember(Name="mos", EmitDefaultValue=false)]
        public NumericRange Mos { get; set; }
        
        
        
        /// <summary>
        /// The survey question group score used to filter the view
        /// </summary>
        /// <value>The survey question group score used to filter the view</value>
        [DataMember(Name="surveyQuestionGroupScore", EmitDefaultValue=false)]
        public NumericRange SurveyQuestionGroupScore { get; set; }
        
        
        
        /// <summary>
        /// The survey promoter score used to filter the view
        /// </summary>
        /// <value>The survey promoter score used to filter the view</value>
        [DataMember(Name="surveyPromoterScore", EmitDefaultValue=false)]
        public NumericRange SurveyPromoterScore { get; set; }
        
        
        
        /// <summary>
        /// The list of survey form context ids used to filter the view
        /// </summary>
        /// <value>The list of survey form context ids used to filter the view</value>
        [DataMember(Name="surveyFormContextIds", EmitDefaultValue=false)]
        public List<string> SurveyFormContextIds { get; set; }
        
        
        
        /// <summary>
        /// The list of conversation ids used to filter the view
        /// </summary>
        /// <value>The list of conversation ids used to filter the view</value>
        [DataMember(Name="conversationIds", EmitDefaultValue=false)]
        public List<string> ConversationIds { get; set; }
        
        
        
        /// <summary>
        /// The list of SIP call ids used to filter the view
        /// </summary>
        /// <value>The list of SIP call ids used to filter the view</value>
        [DataMember(Name="sipCallIds", EmitDefaultValue=false)]
        public List<string> SipCallIds { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for ended
        /// </summary>
        /// <value>Indicates filtering for ended</value>
        [DataMember(Name="isEnded", EmitDefaultValue=false)]
        public bool? IsEnded { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for survey
        /// </summary>
        /// <value>Indicates filtering for survey</value>
        [DataMember(Name="isSurveyed", EmitDefaultValue=false)]
        public bool? IsSurveyed { get; set; }
        
        
        
        /// <summary>
        /// The list of survey score ranges used to filter the view
        /// </summary>
        /// <value>The list of survey score ranges used to filter the view</value>
        [DataMember(Name="surveyScores", EmitDefaultValue=false)]
        public List<NumericRange> SurveyScores { get; set; }
        
        
        
        /// <summary>
        /// The list of promoter score ranges used to filter the view
        /// </summary>
        /// <value>The list of promoter score ranges used to filter the view</value>
        [DataMember(Name="promoterScores", EmitDefaultValue=false)]
        public List<NumericRange> PromoterScores { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for campaign
        /// </summary>
        /// <value>Indicates filtering for campaign</value>
        [DataMember(Name="isCampaign", EmitDefaultValue=false)]
        public bool? IsCampaign { get; set; }
        
        
        
        /// <summary>
        /// The list of survey statuses used to filter the view
        /// </summary>
        /// <value>The list of survey statuses used to filter the view</value>
        [DataMember(Name="surveyStatuses", EmitDefaultValue=false)]
        public List<string> SurveyStatuses { get; set; }
        
        
        
        /// <summary>
        /// A grouping of conversation level filters
        /// </summary>
        /// <value>A grouping of conversation level filters</value>
        [DataMember(Name="conversationProperties", EmitDefaultValue=false)]
        public ConversationProperties ConversationProperties { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for blind transferred
        /// </summary>
        /// <value>Indicates filtering for blind transferred</value>
        [DataMember(Name="isBlindTransferred", EmitDefaultValue=false)]
        public bool? IsBlindTransferred { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for consulted
        /// </summary>
        /// <value>Indicates filtering for consulted</value>
        [DataMember(Name="isConsulted", EmitDefaultValue=false)]
        public bool? IsConsulted { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for consult transferred
        /// </summary>
        /// <value>Indicates filtering for consult transferred</value>
        [DataMember(Name="isConsultTransferred", EmitDefaultValue=false)]
        public bool? IsConsultTransferred { get; set; }
        
        
        
        /// <summary>
        /// The list of remote participants used to filter the view
        /// </summary>
        /// <value>The list of remote participants used to filter the view</value>
        [DataMember(Name="remoteParticipants", EmitDefaultValue=false)]
        public List<string> RemoteParticipants { get; set; }
        
        
        
        /// <summary>
        /// The list of flow Ids
        /// </summary>
        /// <value>The list of flow Ids</value>
        [DataMember(Name="flowIds", EmitDefaultValue=false)]
        public List<string> FlowIds { get; set; }
        
        
        
        /// <summary>
        /// A list of outcome ids of the flow
        /// </summary>
        /// <value>A list of outcome ids of the flow</value>
        [DataMember(Name="flowOutcomeIds", EmitDefaultValue=false)]
        public List<string> FlowOutcomeIds { get; set; }
        
        
        
        /// <summary>
        /// A list of outcome values of the flow
        /// </summary>
        /// <value>A list of outcome values of the flow</value>
        [DataMember(Name="flowOutcomeValues", EmitDefaultValue=false)]
        public List<FlowOutcomeValuesEnum> FlowOutcomeValues { get; set; }
        
        
        
        /// <summary>
        /// The list of destination types of the flow
        /// </summary>
        /// <value>The list of destination types of the flow</value>
        [DataMember(Name="flowDestinationTypes", EmitDefaultValue=false)]
        public List<FlowDestinationTypesEnum> FlowDestinationTypes { get; set; }
        
        
        
        /// <summary>
        /// The list of reasons for the flow to disconnect
        /// </summary>
        /// <value>The list of reasons for the flow to disconnect</value>
        [DataMember(Name="flowDisconnectReasons", EmitDefaultValue=false)]
        public List<FlowDisconnectReasonsEnum> FlowDisconnectReasons { get; set; }
        
        
        
        /// <summary>
        /// A list of types of the flow
        /// </summary>
        /// <value>A list of types of the flow</value>
        [DataMember(Name="flowTypes", EmitDefaultValue=false)]
        public List<FlowTypesEnum> FlowTypes { get; set; }
        
        
        
        /// <summary>
        /// A list of types of the flow entry
        /// </summary>
        /// <value>A list of types of the flow entry</value>
        [DataMember(Name="flowEntryTypes", EmitDefaultValue=false)]
        public List<FlowEntryTypesEnum> FlowEntryTypes { get; set; }
        
        
        
        /// <summary>
        /// A list of reasons of flow entry
        /// </summary>
        /// <value>A list of reasons of flow entry</value>
        [DataMember(Name="flowEntryReasons", EmitDefaultValue=false)]
        public List<string> FlowEntryReasons { get; set; }
        
        
        
        /// <summary>
        /// A list of versions of a flow
        /// </summary>
        /// <value>A list of versions of a flow</value>
        [DataMember(Name="flowVersions", EmitDefaultValue=false)]
        public List<string> FlowVersions { get; set; }
        
        
        
        /// <summary>
        /// A list of directory group ids
        /// </summary>
        /// <value>A list of directory group ids</value>
        [DataMember(Name="groupIds", EmitDefaultValue=false)]
        public List<string> GroupIds { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for journey customer id
        /// </summary>
        /// <value>Indicates filtering for journey customer id</value>
        [DataMember(Name="hasJourneyCustomerId", EmitDefaultValue=false)]
        public bool? HasJourneyCustomerId { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for Journey action map id
        /// </summary>
        /// <value>Indicates filtering for Journey action map id</value>
        [DataMember(Name="hasJourneyActionMapId", EmitDefaultValue=false)]
        public bool? HasJourneyActionMapId { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for Journey visit id
        /// </summary>
        /// <value>Indicates filtering for Journey visit id</value>
        [DataMember(Name="hasJourneyVisitId", EmitDefaultValue=false)]
        public bool? HasJourneyVisitId { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for presence of MMS media
        /// </summary>
        /// <value>Indicates filtering for presence of MMS media</value>
        [DataMember(Name="hasMedia", EmitDefaultValue=false)]
        public bool? HasMedia { get; set; }
        
        
        
        /// <summary>
        /// The role Ids used to filter the view
        /// </summary>
        /// <value>The role Ids used to filter the view</value>
        [DataMember(Name="roleIds", EmitDefaultValue=false)]
        public List<string> RoleIds { get; set; }
        
        
        
        /// <summary>
        /// The report to user IDs used to filter the view
        /// </summary>
        /// <value>The report to user IDs used to filter the view</value>
        [DataMember(Name="reportsTos", EmitDefaultValue=false)]
        public List<string> ReportsTos { get; set; }
        
        
        
        /// <summary>
        /// The location Ids used to filter the view
        /// </summary>
        /// <value>The location Ids used to filter the view</value>
        [DataMember(Name="locationIds", EmitDefaultValue=false)]
        public List<string> LocationIds { get; set; }
        
        
        
        /// <summary>
        /// A list of flow out types
        /// </summary>
        /// <value>A list of flow out types</value>
        [DataMember(Name="flowOutTypes", EmitDefaultValue=false)]
        public List<string> FlowOutTypes { get; set; }
        
        
        
        /// <summary>
        /// A list of providers
        /// </summary>
        /// <value>A list of providers</value>
        [DataMember(Name="providerList", EmitDefaultValue=false)]
        public List<string> ProviderList { get; set; }
        
        
        
        /// <summary>
        /// A list of callback numbers or substrings of numbers (ex: [\&quot;317\&quot;, \&quot;13172222222\&quot;])
        /// </summary>
        /// <value>A list of callback numbers or substrings of numbers (ex: [\&quot;317\&quot;, \&quot;13172222222\&quot;])</value>
        [DataMember(Name="callbackNumberList", EmitDefaultValue=false)]
        public List<string> CallbackNumberList { get; set; }
        
        
        
        /// <summary>
        /// An interval of time to filter for scheduled callbacks. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>An interval of time to filter for scheduled callbacks. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="callbackInterval", EmitDefaultValue=false)]
        public string CallbackInterval { get; set; }
        
        
        
        /// <summary>
        /// A list of routing types used
        /// </summary>
        /// <value>A list of routing types used</value>
        [DataMember(Name="usedRoutingTypes", EmitDefaultValue=false)]
        public List<UsedRoutingTypesEnum> UsedRoutingTypes { get; set; }
        
        
        
        /// <summary>
        /// A list of routing types requested
        /// </summary>
        /// <value>A list of routing types requested</value>
        [DataMember(Name="requestedRoutingTypes", EmitDefaultValue=false)]
        public List<RequestedRoutingTypesEnum> RequestedRoutingTypes { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for agent assist id
        /// </summary>
        /// <value>Indicates filtering for agent assist id</value>
        [DataMember(Name="hasAgentAssistId", EmitDefaultValue=false)]
        public bool? HasAgentAssistId { get; set; }
        
        
        
        /// <summary>
        /// A list of transcript contents requested
        /// </summary>
        /// <value>A list of transcript contents requested</value>
        [DataMember(Name="transcripts", EmitDefaultValue=false)]
        public List<Transcripts> Transcripts { get; set; }
        
        
        
        /// <summary>
        /// A list of transcript languages requested
        /// </summary>
        /// <value>A list of transcript languages requested</value>
        [DataMember(Name="transcriptLanguages", EmitDefaultValue=false)]
        public List<string> TranscriptLanguages { get; set; }
        
        
        
        /// <summary>
        /// A list of participant purpose requested
        /// </summary>
        /// <value>A list of participant purpose requested</value>
        [DataMember(Name="participantPurposes", EmitDefaultValue=false)]
        public List<ParticipantPurposesEnum> ParticipantPurposes { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for first queue data
        /// </summary>
        /// <value>Indicates filtering for first queue data</value>
        [DataMember(Name="showFirstQueue", EmitDefaultValue=false)]
        public bool? ShowFirstQueue { get; set; }
        
        
        
        /// <summary>
        /// The team ids used to filter the view data
        /// </summary>
        /// <value>The team ids used to filter the view data</value>
        [DataMember(Name="teamIds", EmitDefaultValue=false)]
        public List<string> TeamIds { get; set; }
        
        
        
        /// <summary>
        /// The team ids are used to fetch associated users for the view
        /// </summary>
        /// <value>The team ids are used to fetch associated users for the view</value>
        [DataMember(Name="filterUsersByTeamIds", EmitDefaultValue=false)]
        public List<string> FilterUsersByTeamIds { get; set; }
        
        
        
        /// <summary>
        /// The journey action map ids are used to fetch action maps for the associated view
        /// </summary>
        /// <value>The journey action map ids are used to fetch action maps for the associated view</value>
        [DataMember(Name="journeyActionMapIds", EmitDefaultValue=false)]
        public List<string> JourneyActionMapIds { get; set; }
        
        
        
        /// <summary>
        /// The journey outcome ids are used to fetch outcomes for the associated view
        /// </summary>
        /// <value>The journey outcome ids are used to fetch outcomes for the associated view</value>
        [DataMember(Name="journeyOutcomeIds", EmitDefaultValue=false)]
        public List<string> JourneyOutcomeIds { get; set; }
        
        
        
        /// <summary>
        /// The journey segment ids are used to fetch segments for the associated view
        /// </summary>
        /// <value>The journey segment ids are used to fetch segments for the associated view</value>
        [DataMember(Name="journeySegmentIds", EmitDefaultValue=false)]
        public List<string> JourneySegmentIds { get; set; }
        
        
        
        /// <summary>
        /// The journey action map types are used to filter action map data for the associated view
        /// </summary>
        /// <value>The journey action map types are used to filter action map data for the associated view</value>
        [DataMember(Name="journeyActionMapTypes", EmitDefaultValue=false)]
        public List<JourneyActionMapTypesEnum> JourneyActionMapTypes { get; set; }
        
        
        
        /// <summary>
        /// The list of development roles used to filter agent development view
        /// </summary>
        /// <value>The list of development roles used to filter agent development view</value>
        [DataMember(Name="developmentRoleList", EmitDefaultValue=false)]
        public List<DevelopmentRoleListEnum> DevelopmentRoleList { get; set; }
        
        
        
        /// <summary>
        /// The list of development types used to filter agent development view
        /// </summary>
        /// <value>The list of development types used to filter agent development view</value>
        [DataMember(Name="developmentTypeList", EmitDefaultValue=false)]
        public List<DevelopmentTypeListEnum> DevelopmentTypeList { get; set; }
        
        
        
        /// <summary>
        /// The list of development status used to filter agent development view
        /// </summary>
        /// <value>The list of development status used to filter agent development view</value>
        [DataMember(Name="developmentStatusList", EmitDefaultValue=false)]
        public List<DevelopmentStatusListEnum> DevelopmentStatusList { get; set; }
        
        
        
        /// <summary>
        /// The list of development moduleIds used to filter agent development view
        /// </summary>
        /// <value>The list of development moduleIds used to filter agent development view</value>
        [DataMember(Name="developmentModuleIds", EmitDefaultValue=false)]
        public List<string> DevelopmentModuleIds { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for development activities
        /// </summary>
        /// <value>Indicates filtering for development activities</value>
        [DataMember(Name="developmentActivityOverdue", EmitDefaultValue=false)]
        public bool? DevelopmentActivityOverdue { get; set; }
        
        
        
        /// <summary>
        /// The customer sentiment score used to filter the view
        /// </summary>
        /// <value>The customer sentiment score used to filter the view</value>
        [DataMember(Name="customerSentimentScore", EmitDefaultValue=false)]
        public NumericRange CustomerSentimentScore { get; set; }
        
        
        
        /// <summary>
        /// The customer sentiment trend used to filter the view
        /// </summary>
        /// <value>The customer sentiment trend used to filter the view</value>
        [DataMember(Name="customerSentimentTrend", EmitDefaultValue=false)]
        public NumericRange CustomerSentimentTrend { get; set; }
        
        
        
        /// <summary>
        /// The list of transfer targets used to filter flow data
        /// </summary>
        /// <value>The list of transfer targets used to filter flow data</value>
        [DataMember(Name="flowTransferTargets", EmitDefaultValue=false)]
        public List<string> FlowTransferTargets { get; set; }
        
        
        
        /// <summary>
        /// Filter for development name
        /// </summary>
        /// <value>Filter for development name</value>
        [DataMember(Name="developmentName", EmitDefaultValue=false)]
        public string DevelopmentName { get; set; }
        
        
        
        /// <summary>
        /// Represents the topics detected in the transcript
        /// </summary>
        /// <value>Represents the topics detected in the transcript</value>
        [DataMember(Name="topicIds", EmitDefaultValue=false)]
        public List<string> TopicIds { get; set; }
        
        
        
        /// <summary>
        /// The list of external Tags used to filter conversation data
        /// </summary>
        /// <value>The list of external Tags used to filter conversation data</value>
        [DataMember(Name="externalTags", EmitDefaultValue=false)]
        public List<string> ExternalTags { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for not responding users
        /// </summary>
        /// <value>Indicates filtering for not responding users</value>
        [DataMember(Name="isNotResponding", EmitDefaultValue=false)]
        public bool? IsNotResponding { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for the authenticated chat
        /// </summary>
        /// <value>Indicates filtering for the authenticated chat</value>
        [DataMember(Name="isAuthenticated", EmitDefaultValue=false)]
        public bool? IsAuthenticated { get; set; }
        
        
        
        /// <summary>
        /// The list of bot IDs used to filter bot views
        /// </summary>
        /// <value>The list of bot IDs used to filter bot views</value>
        [DataMember(Name="botIds", EmitDefaultValue=false)]
        public List<string> BotIds { get; set; }
        
        
        
        /// <summary>
        /// The list of bot versions used to filter bot views
        /// </summary>
        /// <value>The list of bot versions used to filter bot views</value>
        [DataMember(Name="botVersions", EmitDefaultValue=false)]
        public List<string> BotVersions { get; set; }
        
        
        
        /// <summary>
        /// The list of bot message types used to filter bot views
        /// </summary>
        /// <value>The list of bot message types used to filter bot views</value>
        [DataMember(Name="botMessageTypes", EmitDefaultValue=false)]
        public List<BotMessageTypesEnum> BotMessageTypes { get; set; }
        
        
        
        /// <summary>
        /// The list of bot providers used to filter bot views
        /// </summary>
        /// <value>The list of bot providers used to filter bot views</value>
        [DataMember(Name="botProviderList", EmitDefaultValue=false)]
        public List<BotProviderListEnum> BotProviderList { get; set; }
        
        
        
        /// <summary>
        /// The list of bot products used to filter bot views
        /// </summary>
        /// <value>The list of bot products used to filter bot views</value>
        [DataMember(Name="botProductList", EmitDefaultValue=false)]
        public List<BotProductListEnum> BotProductList { get; set; }
        
        
        
        /// <summary>
        /// The list of bot recognition failure reasons used to filter bot views
        /// </summary>
        /// <value>The list of bot recognition failure reasons used to filter bot views</value>
        [DataMember(Name="botRecognitionFailureReasonList", EmitDefaultValue=false)]
        public List<BotRecognitionFailureReasonListEnum> BotRecognitionFailureReasonList { get; set; }
        
        
        
        /// <summary>
        /// The list of bot intents used to filter bot views
        /// </summary>
        /// <value>The list of bot intents used to filter bot views</value>
        [DataMember(Name="botIntentList", EmitDefaultValue=false)]
        public List<string> BotIntentList { get; set; }
        
        
        
        /// <summary>
        /// The list of bot final intents used to filter bot views
        /// </summary>
        /// <value>The list of bot final intents used to filter bot views</value>
        [DataMember(Name="botFinalIntentList", EmitDefaultValue=false)]
        public List<string> BotFinalIntentList { get; set; }
        
        
        
        /// <summary>
        /// The list of bot slots used to filter bot views
        /// </summary>
        /// <value>The list of bot slots used to filter bot views</value>
        [DataMember(Name="botSlotList", EmitDefaultValue=false)]
        public List<string> BotSlotList { get; set; }
        
        
        
        /// <summary>
        /// The list of bot results used to filter bot views
        /// </summary>
        /// <value>The list of bot results used to filter bot views</value>
        [DataMember(Name="botResultList", EmitDefaultValue=false)]
        public List<BotResultListEnum> BotResultList { get; set; }
        
        
        
        /// <summary>
        /// The list of blocked reason used to filter action map constraints views
        /// </summary>
        /// <value>The list of blocked reason used to filter action map constraints views</value>
        [DataMember(Name="blockedReasons", EmitDefaultValue=false)]
        public List<BlockedReasonsEnum> BlockedReasons { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewFilter {\n");
            
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  SkillGroups: ").Append(SkillGroups).Append("\n");
            sb.Append("  LanguageIds: ").Append(LanguageIds).Append("\n");
            sb.Append("  LanguageGroups: ").Append(LanguageGroups).Append("\n");
            sb.Append("  Directions: ").Append(Directions).Append("\n");
            sb.Append("  OriginatingDirections: ").Append(OriginatingDirections).Append("\n");
            sb.Append("  WrapUpCodes: ").Append(WrapUpCodes).Append("\n");
            sb.Append("  DnisList: ").Append(DnisList).Append("\n");
            sb.Append("  SessionDnisList: ").Append(SessionDnisList).Append("\n");
            sb.Append("  FilterQueuesByUserIds: ").Append(FilterQueuesByUserIds).Append("\n");
            sb.Append("  FilterUsersByQueueIds: ").Append(FilterUsersByQueueIds).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  AddressTos: ").Append(AddressTos).Append("\n");
            sb.Append("  AddressFroms: ").Append(AddressFroms).Append("\n");
            sb.Append("  OutboundCampaignIds: ").Append(OutboundCampaignIds).Append("\n");
            sb.Append("  OutboundContactListIds: ").Append(OutboundContactListIds).Append("\n");
            sb.Append("  ContactIds: ").Append(ContactIds).Append("\n");
            sb.Append("  ExternalContactIds: ").Append(ExternalContactIds).Append("\n");
            sb.Append("  ExternalOrgIds: ").Append(ExternalOrgIds).Append("\n");
            sb.Append("  AniList: ").Append(AniList).Append("\n");
            sb.Append("  DurationsMilliseconds: ").Append(DurationsMilliseconds).Append("\n");
            sb.Append("  AcdDurationsMilliseconds: ").Append(AcdDurationsMilliseconds).Append("\n");
            sb.Append("  TalkDurationsMilliseconds: ").Append(TalkDurationsMilliseconds).Append("\n");
            sb.Append("  AcwDurationsMilliseconds: ").Append(AcwDurationsMilliseconds).Append("\n");
            sb.Append("  HandleDurationsMilliseconds: ").Append(HandleDurationsMilliseconds).Append("\n");
            sb.Append("  HoldDurationsMilliseconds: ").Append(HoldDurationsMilliseconds).Append("\n");
            sb.Append("  AbandonDurationsMilliseconds: ").Append(AbandonDurationsMilliseconds).Append("\n");
            sb.Append("  EvaluationScore: ").Append(EvaluationScore).Append("\n");
            sb.Append("  EvaluationCriticalScore: ").Append(EvaluationCriticalScore).Append("\n");
            sb.Append("  EvaluationFormIds: ").Append(EvaluationFormIds).Append("\n");
            sb.Append("  EvaluatedAgentIds: ").Append(EvaluatedAgentIds).Append("\n");
            sb.Append("  EvaluatorIds: ").Append(EvaluatorIds).Append("\n");
            sb.Append("  Transferred: ").Append(Transferred).Append("\n");
            sb.Append("  Abandoned: ").Append(Abandoned).Append("\n");
            sb.Append("  Answered: ").Append(Answered).Append("\n");
            sb.Append("  MessageTypes: ").Append(MessageTypes).Append("\n");
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
            sb.Append("  SurveyFormIds: ").Append(SurveyFormIds).Append("\n");
            sb.Append("  SurveyTotalScore: ").Append(SurveyTotalScore).Append("\n");
            sb.Append("  SurveyNpsScore: ").Append(SurveyNpsScore).Append("\n");
            sb.Append("  Mos: ").Append(Mos).Append("\n");
            sb.Append("  SurveyQuestionGroupScore: ").Append(SurveyQuestionGroupScore).Append("\n");
            sb.Append("  SurveyPromoterScore: ").Append(SurveyPromoterScore).Append("\n");
            sb.Append("  SurveyFormContextIds: ").Append(SurveyFormContextIds).Append("\n");
            sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
            sb.Append("  SipCallIds: ").Append(SipCallIds).Append("\n");
            sb.Append("  IsEnded: ").Append(IsEnded).Append("\n");
            sb.Append("  IsSurveyed: ").Append(IsSurveyed).Append("\n");
            sb.Append("  SurveyScores: ").Append(SurveyScores).Append("\n");
            sb.Append("  PromoterScores: ").Append(PromoterScores).Append("\n");
            sb.Append("  IsCampaign: ").Append(IsCampaign).Append("\n");
            sb.Append("  SurveyStatuses: ").Append(SurveyStatuses).Append("\n");
            sb.Append("  ConversationProperties: ").Append(ConversationProperties).Append("\n");
            sb.Append("  IsBlindTransferred: ").Append(IsBlindTransferred).Append("\n");
            sb.Append("  IsConsulted: ").Append(IsConsulted).Append("\n");
            sb.Append("  IsConsultTransferred: ").Append(IsConsultTransferred).Append("\n");
            sb.Append("  RemoteParticipants: ").Append(RemoteParticipants).Append("\n");
            sb.Append("  FlowIds: ").Append(FlowIds).Append("\n");
            sb.Append("  FlowOutcomeIds: ").Append(FlowOutcomeIds).Append("\n");
            sb.Append("  FlowOutcomeValues: ").Append(FlowOutcomeValues).Append("\n");
            sb.Append("  FlowDestinationTypes: ").Append(FlowDestinationTypes).Append("\n");
            sb.Append("  FlowDisconnectReasons: ").Append(FlowDisconnectReasons).Append("\n");
            sb.Append("  FlowTypes: ").Append(FlowTypes).Append("\n");
            sb.Append("  FlowEntryTypes: ").Append(FlowEntryTypes).Append("\n");
            sb.Append("  FlowEntryReasons: ").Append(FlowEntryReasons).Append("\n");
            sb.Append("  FlowVersions: ").Append(FlowVersions).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
            sb.Append("  HasJourneyCustomerId: ").Append(HasJourneyCustomerId).Append("\n");
            sb.Append("  HasJourneyActionMapId: ").Append(HasJourneyActionMapId).Append("\n");
            sb.Append("  HasJourneyVisitId: ").Append(HasJourneyVisitId).Append("\n");
            sb.Append("  HasMedia: ").Append(HasMedia).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  ReportsTos: ").Append(ReportsTos).Append("\n");
            sb.Append("  LocationIds: ").Append(LocationIds).Append("\n");
            sb.Append("  FlowOutTypes: ").Append(FlowOutTypes).Append("\n");
            sb.Append("  ProviderList: ").Append(ProviderList).Append("\n");
            sb.Append("  CallbackNumberList: ").Append(CallbackNumberList).Append("\n");
            sb.Append("  CallbackInterval: ").Append(CallbackInterval).Append("\n");
            sb.Append("  UsedRoutingTypes: ").Append(UsedRoutingTypes).Append("\n");
            sb.Append("  RequestedRoutingTypes: ").Append(RequestedRoutingTypes).Append("\n");
            sb.Append("  HasAgentAssistId: ").Append(HasAgentAssistId).Append("\n");
            sb.Append("  Transcripts: ").Append(Transcripts).Append("\n");
            sb.Append("  TranscriptLanguages: ").Append(TranscriptLanguages).Append("\n");
            sb.Append("  ParticipantPurposes: ").Append(ParticipantPurposes).Append("\n");
            sb.Append("  ShowFirstQueue: ").Append(ShowFirstQueue).Append("\n");
            sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
            sb.Append("  FilterUsersByTeamIds: ").Append(FilterUsersByTeamIds).Append("\n");
            sb.Append("  JourneyActionMapIds: ").Append(JourneyActionMapIds).Append("\n");
            sb.Append("  JourneyOutcomeIds: ").Append(JourneyOutcomeIds).Append("\n");
            sb.Append("  JourneySegmentIds: ").Append(JourneySegmentIds).Append("\n");
            sb.Append("  JourneyActionMapTypes: ").Append(JourneyActionMapTypes).Append("\n");
            sb.Append("  DevelopmentRoleList: ").Append(DevelopmentRoleList).Append("\n");
            sb.Append("  DevelopmentTypeList: ").Append(DevelopmentTypeList).Append("\n");
            sb.Append("  DevelopmentStatusList: ").Append(DevelopmentStatusList).Append("\n");
            sb.Append("  DevelopmentModuleIds: ").Append(DevelopmentModuleIds).Append("\n");
            sb.Append("  DevelopmentActivityOverdue: ").Append(DevelopmentActivityOverdue).Append("\n");
            sb.Append("  CustomerSentimentScore: ").Append(CustomerSentimentScore).Append("\n");
            sb.Append("  CustomerSentimentTrend: ").Append(CustomerSentimentTrend).Append("\n");
            sb.Append("  FlowTransferTargets: ").Append(FlowTransferTargets).Append("\n");
            sb.Append("  DevelopmentName: ").Append(DevelopmentName).Append("\n");
            sb.Append("  TopicIds: ").Append(TopicIds).Append("\n");
            sb.Append("  ExternalTags: ").Append(ExternalTags).Append("\n");
            sb.Append("  IsNotResponding: ").Append(IsNotResponding).Append("\n");
            sb.Append("  IsAuthenticated: ").Append(IsAuthenticated).Append("\n");
            sb.Append("  BotIds: ").Append(BotIds).Append("\n");
            sb.Append("  BotVersions: ").Append(BotVersions).Append("\n");
            sb.Append("  BotMessageTypes: ").Append(BotMessageTypes).Append("\n");
            sb.Append("  BotProviderList: ").Append(BotProviderList).Append("\n");
            sb.Append("  BotProductList: ").Append(BotProductList).Append("\n");
            sb.Append("  BotRecognitionFailureReasonList: ").Append(BotRecognitionFailureReasonList).Append("\n");
            sb.Append("  BotIntentList: ").Append(BotIntentList).Append("\n");
            sb.Append("  BotFinalIntentList: ").Append(BotFinalIntentList).Append("\n");
            sb.Append("  BotSlotList: ").Append(BotSlotList).Append("\n");
            sb.Append("  BotResultList: ").Append(BotResultList).Append("\n");
            sb.Append("  BlockedReasons: ").Append(BlockedReasons).Append("\n");
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
            return this.Equals(obj as ViewFilter);
        }

        /// <summary>
        /// Returns true if ViewFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ViewFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.QueueIds == other.QueueIds ||
                    this.QueueIds != null &&
                    this.QueueIds.SequenceEqual(other.QueueIds)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
                ) &&
                (
                    this.SkillGroups == other.SkillGroups ||
                    this.SkillGroups != null &&
                    this.SkillGroups.SequenceEqual(other.SkillGroups)
                ) &&
                (
                    this.LanguageIds == other.LanguageIds ||
                    this.LanguageIds != null &&
                    this.LanguageIds.SequenceEqual(other.LanguageIds)
                ) &&
                (
                    this.LanguageGroups == other.LanguageGroups ||
                    this.LanguageGroups != null &&
                    this.LanguageGroups.SequenceEqual(other.LanguageGroups)
                ) &&
                (
                    this.Directions == other.Directions ||
                    this.Directions != null &&
                    this.Directions.SequenceEqual(other.Directions)
                ) &&
                (
                    this.OriginatingDirections == other.OriginatingDirections ||
                    this.OriginatingDirections != null &&
                    this.OriginatingDirections.SequenceEqual(other.OriginatingDirections)
                ) &&
                (
                    this.WrapUpCodes == other.WrapUpCodes ||
                    this.WrapUpCodes != null &&
                    this.WrapUpCodes.SequenceEqual(other.WrapUpCodes)
                ) &&
                (
                    this.DnisList == other.DnisList ||
                    this.DnisList != null &&
                    this.DnisList.SequenceEqual(other.DnisList)
                ) &&
                (
                    this.SessionDnisList == other.SessionDnisList ||
                    this.SessionDnisList != null &&
                    this.SessionDnisList.SequenceEqual(other.SessionDnisList)
                ) &&
                (
                    this.FilterQueuesByUserIds == other.FilterQueuesByUserIds ||
                    this.FilterQueuesByUserIds != null &&
                    this.FilterQueuesByUserIds.SequenceEqual(other.FilterQueuesByUserIds)
                ) &&
                (
                    this.FilterUsersByQueueIds == other.FilterUsersByQueueIds ||
                    this.FilterUsersByQueueIds != null &&
                    this.FilterUsersByQueueIds.SequenceEqual(other.FilterUsersByQueueIds)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
                ) &&
                (
                    this.AddressTos == other.AddressTos ||
                    this.AddressTos != null &&
                    this.AddressTos.SequenceEqual(other.AddressTos)
                ) &&
                (
                    this.AddressFroms == other.AddressFroms ||
                    this.AddressFroms != null &&
                    this.AddressFroms.SequenceEqual(other.AddressFroms)
                ) &&
                (
                    this.OutboundCampaignIds == other.OutboundCampaignIds ||
                    this.OutboundCampaignIds != null &&
                    this.OutboundCampaignIds.SequenceEqual(other.OutboundCampaignIds)
                ) &&
                (
                    this.OutboundContactListIds == other.OutboundContactListIds ||
                    this.OutboundContactListIds != null &&
                    this.OutboundContactListIds.SequenceEqual(other.OutboundContactListIds)
                ) &&
                (
                    this.ContactIds == other.ContactIds ||
                    this.ContactIds != null &&
                    this.ContactIds.SequenceEqual(other.ContactIds)
                ) &&
                (
                    this.ExternalContactIds == other.ExternalContactIds ||
                    this.ExternalContactIds != null &&
                    this.ExternalContactIds.SequenceEqual(other.ExternalContactIds)
                ) &&
                (
                    this.ExternalOrgIds == other.ExternalOrgIds ||
                    this.ExternalOrgIds != null &&
                    this.ExternalOrgIds.SequenceEqual(other.ExternalOrgIds)
                ) &&
                (
                    this.AniList == other.AniList ||
                    this.AniList != null &&
                    this.AniList.SequenceEqual(other.AniList)
                ) &&
                (
                    this.DurationsMilliseconds == other.DurationsMilliseconds ||
                    this.DurationsMilliseconds != null &&
                    this.DurationsMilliseconds.SequenceEqual(other.DurationsMilliseconds)
                ) &&
                (
                    this.AcdDurationsMilliseconds == other.AcdDurationsMilliseconds ||
                    this.AcdDurationsMilliseconds != null &&
                    this.AcdDurationsMilliseconds.SequenceEqual(other.AcdDurationsMilliseconds)
                ) &&
                (
                    this.TalkDurationsMilliseconds == other.TalkDurationsMilliseconds ||
                    this.TalkDurationsMilliseconds != null &&
                    this.TalkDurationsMilliseconds.SequenceEqual(other.TalkDurationsMilliseconds)
                ) &&
                (
                    this.AcwDurationsMilliseconds == other.AcwDurationsMilliseconds ||
                    this.AcwDurationsMilliseconds != null &&
                    this.AcwDurationsMilliseconds.SequenceEqual(other.AcwDurationsMilliseconds)
                ) &&
                (
                    this.HandleDurationsMilliseconds == other.HandleDurationsMilliseconds ||
                    this.HandleDurationsMilliseconds != null &&
                    this.HandleDurationsMilliseconds.SequenceEqual(other.HandleDurationsMilliseconds)
                ) &&
                (
                    this.HoldDurationsMilliseconds == other.HoldDurationsMilliseconds ||
                    this.HoldDurationsMilliseconds != null &&
                    this.HoldDurationsMilliseconds.SequenceEqual(other.HoldDurationsMilliseconds)
                ) &&
                (
                    this.AbandonDurationsMilliseconds == other.AbandonDurationsMilliseconds ||
                    this.AbandonDurationsMilliseconds != null &&
                    this.AbandonDurationsMilliseconds.SequenceEqual(other.AbandonDurationsMilliseconds)
                ) &&
                (
                    this.EvaluationScore == other.EvaluationScore ||
                    this.EvaluationScore != null &&
                    this.EvaluationScore.Equals(other.EvaluationScore)
                ) &&
                (
                    this.EvaluationCriticalScore == other.EvaluationCriticalScore ||
                    this.EvaluationCriticalScore != null &&
                    this.EvaluationCriticalScore.Equals(other.EvaluationCriticalScore)
                ) &&
                (
                    this.EvaluationFormIds == other.EvaluationFormIds ||
                    this.EvaluationFormIds != null &&
                    this.EvaluationFormIds.SequenceEqual(other.EvaluationFormIds)
                ) &&
                (
                    this.EvaluatedAgentIds == other.EvaluatedAgentIds ||
                    this.EvaluatedAgentIds != null &&
                    this.EvaluatedAgentIds.SequenceEqual(other.EvaluatedAgentIds)
                ) &&
                (
                    this.EvaluatorIds == other.EvaluatorIds ||
                    this.EvaluatorIds != null &&
                    this.EvaluatorIds.SequenceEqual(other.EvaluatorIds)
                ) &&
                (
                    this.Transferred == other.Transferred ||
                    this.Transferred != null &&
                    this.Transferred.Equals(other.Transferred)
                ) &&
                (
                    this.Abandoned == other.Abandoned ||
                    this.Abandoned != null &&
                    this.Abandoned.Equals(other.Abandoned)
                ) &&
                (
                    this.Answered == other.Answered ||
                    this.Answered != null &&
                    this.Answered.Equals(other.Answered)
                ) &&
                (
                    this.MessageTypes == other.MessageTypes ||
                    this.MessageTypes != null &&
                    this.MessageTypes.SequenceEqual(other.MessageTypes)
                ) &&
                (
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
                ) &&
                (
                    this.SurveyFormIds == other.SurveyFormIds ||
                    this.SurveyFormIds != null &&
                    this.SurveyFormIds.SequenceEqual(other.SurveyFormIds)
                ) &&
                (
                    this.SurveyTotalScore == other.SurveyTotalScore ||
                    this.SurveyTotalScore != null &&
                    this.SurveyTotalScore.Equals(other.SurveyTotalScore)
                ) &&
                (
                    this.SurveyNpsScore == other.SurveyNpsScore ||
                    this.SurveyNpsScore != null &&
                    this.SurveyNpsScore.Equals(other.SurveyNpsScore)
                ) &&
                (
                    this.Mos == other.Mos ||
                    this.Mos != null &&
                    this.Mos.Equals(other.Mos)
                ) &&
                (
                    this.SurveyQuestionGroupScore == other.SurveyQuestionGroupScore ||
                    this.SurveyQuestionGroupScore != null &&
                    this.SurveyQuestionGroupScore.Equals(other.SurveyQuestionGroupScore)
                ) &&
                (
                    this.SurveyPromoterScore == other.SurveyPromoterScore ||
                    this.SurveyPromoterScore != null &&
                    this.SurveyPromoterScore.Equals(other.SurveyPromoterScore)
                ) &&
                (
                    this.SurveyFormContextIds == other.SurveyFormContextIds ||
                    this.SurveyFormContextIds != null &&
                    this.SurveyFormContextIds.SequenceEqual(other.SurveyFormContextIds)
                ) &&
                (
                    this.ConversationIds == other.ConversationIds ||
                    this.ConversationIds != null &&
                    this.ConversationIds.SequenceEqual(other.ConversationIds)
                ) &&
                (
                    this.SipCallIds == other.SipCallIds ||
                    this.SipCallIds != null &&
                    this.SipCallIds.SequenceEqual(other.SipCallIds)
                ) &&
                (
                    this.IsEnded == other.IsEnded ||
                    this.IsEnded != null &&
                    this.IsEnded.Equals(other.IsEnded)
                ) &&
                (
                    this.IsSurveyed == other.IsSurveyed ||
                    this.IsSurveyed != null &&
                    this.IsSurveyed.Equals(other.IsSurveyed)
                ) &&
                (
                    this.SurveyScores == other.SurveyScores ||
                    this.SurveyScores != null &&
                    this.SurveyScores.SequenceEqual(other.SurveyScores)
                ) &&
                (
                    this.PromoterScores == other.PromoterScores ||
                    this.PromoterScores != null &&
                    this.PromoterScores.SequenceEqual(other.PromoterScores)
                ) &&
                (
                    this.IsCampaign == other.IsCampaign ||
                    this.IsCampaign != null &&
                    this.IsCampaign.Equals(other.IsCampaign)
                ) &&
                (
                    this.SurveyStatuses == other.SurveyStatuses ||
                    this.SurveyStatuses != null &&
                    this.SurveyStatuses.SequenceEqual(other.SurveyStatuses)
                ) &&
                (
                    this.ConversationProperties == other.ConversationProperties ||
                    this.ConversationProperties != null &&
                    this.ConversationProperties.Equals(other.ConversationProperties)
                ) &&
                (
                    this.IsBlindTransferred == other.IsBlindTransferred ||
                    this.IsBlindTransferred != null &&
                    this.IsBlindTransferred.Equals(other.IsBlindTransferred)
                ) &&
                (
                    this.IsConsulted == other.IsConsulted ||
                    this.IsConsulted != null &&
                    this.IsConsulted.Equals(other.IsConsulted)
                ) &&
                (
                    this.IsConsultTransferred == other.IsConsultTransferred ||
                    this.IsConsultTransferred != null &&
                    this.IsConsultTransferred.Equals(other.IsConsultTransferred)
                ) &&
                (
                    this.RemoteParticipants == other.RemoteParticipants ||
                    this.RemoteParticipants != null &&
                    this.RemoteParticipants.SequenceEqual(other.RemoteParticipants)
                ) &&
                (
                    this.FlowIds == other.FlowIds ||
                    this.FlowIds != null &&
                    this.FlowIds.SequenceEqual(other.FlowIds)
                ) &&
                (
                    this.FlowOutcomeIds == other.FlowOutcomeIds ||
                    this.FlowOutcomeIds != null &&
                    this.FlowOutcomeIds.SequenceEqual(other.FlowOutcomeIds)
                ) &&
                (
                    this.FlowOutcomeValues == other.FlowOutcomeValues ||
                    this.FlowOutcomeValues != null &&
                    this.FlowOutcomeValues.SequenceEqual(other.FlowOutcomeValues)
                ) &&
                (
                    this.FlowDestinationTypes == other.FlowDestinationTypes ||
                    this.FlowDestinationTypes != null &&
                    this.FlowDestinationTypes.SequenceEqual(other.FlowDestinationTypes)
                ) &&
                (
                    this.FlowDisconnectReasons == other.FlowDisconnectReasons ||
                    this.FlowDisconnectReasons != null &&
                    this.FlowDisconnectReasons.SequenceEqual(other.FlowDisconnectReasons)
                ) &&
                (
                    this.FlowTypes == other.FlowTypes ||
                    this.FlowTypes != null &&
                    this.FlowTypes.SequenceEqual(other.FlowTypes)
                ) &&
                (
                    this.FlowEntryTypes == other.FlowEntryTypes ||
                    this.FlowEntryTypes != null &&
                    this.FlowEntryTypes.SequenceEqual(other.FlowEntryTypes)
                ) &&
                (
                    this.FlowEntryReasons == other.FlowEntryReasons ||
                    this.FlowEntryReasons != null &&
                    this.FlowEntryReasons.SequenceEqual(other.FlowEntryReasons)
                ) &&
                (
                    this.FlowVersions == other.FlowVersions ||
                    this.FlowVersions != null &&
                    this.FlowVersions.SequenceEqual(other.FlowVersions)
                ) &&
                (
                    this.GroupIds == other.GroupIds ||
                    this.GroupIds != null &&
                    this.GroupIds.SequenceEqual(other.GroupIds)
                ) &&
                (
                    this.HasJourneyCustomerId == other.HasJourneyCustomerId ||
                    this.HasJourneyCustomerId != null &&
                    this.HasJourneyCustomerId.Equals(other.HasJourneyCustomerId)
                ) &&
                (
                    this.HasJourneyActionMapId == other.HasJourneyActionMapId ||
                    this.HasJourneyActionMapId != null &&
                    this.HasJourneyActionMapId.Equals(other.HasJourneyActionMapId)
                ) &&
                (
                    this.HasJourneyVisitId == other.HasJourneyVisitId ||
                    this.HasJourneyVisitId != null &&
                    this.HasJourneyVisitId.Equals(other.HasJourneyVisitId)
                ) &&
                (
                    this.HasMedia == other.HasMedia ||
                    this.HasMedia != null &&
                    this.HasMedia.Equals(other.HasMedia)
                ) &&
                (
                    this.RoleIds == other.RoleIds ||
                    this.RoleIds != null &&
                    this.RoleIds.SequenceEqual(other.RoleIds)
                ) &&
                (
                    this.ReportsTos == other.ReportsTos ||
                    this.ReportsTos != null &&
                    this.ReportsTos.SequenceEqual(other.ReportsTos)
                ) &&
                (
                    this.LocationIds == other.LocationIds ||
                    this.LocationIds != null &&
                    this.LocationIds.SequenceEqual(other.LocationIds)
                ) &&
                (
                    this.FlowOutTypes == other.FlowOutTypes ||
                    this.FlowOutTypes != null &&
                    this.FlowOutTypes.SequenceEqual(other.FlowOutTypes)
                ) &&
                (
                    this.ProviderList == other.ProviderList ||
                    this.ProviderList != null &&
                    this.ProviderList.SequenceEqual(other.ProviderList)
                ) &&
                (
                    this.CallbackNumberList == other.CallbackNumberList ||
                    this.CallbackNumberList != null &&
                    this.CallbackNumberList.SequenceEqual(other.CallbackNumberList)
                ) &&
                (
                    this.CallbackInterval == other.CallbackInterval ||
                    this.CallbackInterval != null &&
                    this.CallbackInterval.Equals(other.CallbackInterval)
                ) &&
                (
                    this.UsedRoutingTypes == other.UsedRoutingTypes ||
                    this.UsedRoutingTypes != null &&
                    this.UsedRoutingTypes.SequenceEqual(other.UsedRoutingTypes)
                ) &&
                (
                    this.RequestedRoutingTypes == other.RequestedRoutingTypes ||
                    this.RequestedRoutingTypes != null &&
                    this.RequestedRoutingTypes.SequenceEqual(other.RequestedRoutingTypes)
                ) &&
                (
                    this.HasAgentAssistId == other.HasAgentAssistId ||
                    this.HasAgentAssistId != null &&
                    this.HasAgentAssistId.Equals(other.HasAgentAssistId)
                ) &&
                (
                    this.Transcripts == other.Transcripts ||
                    this.Transcripts != null &&
                    this.Transcripts.SequenceEqual(other.Transcripts)
                ) &&
                (
                    this.TranscriptLanguages == other.TranscriptLanguages ||
                    this.TranscriptLanguages != null &&
                    this.TranscriptLanguages.SequenceEqual(other.TranscriptLanguages)
                ) &&
                (
                    this.ParticipantPurposes == other.ParticipantPurposes ||
                    this.ParticipantPurposes != null &&
                    this.ParticipantPurposes.SequenceEqual(other.ParticipantPurposes)
                ) &&
                (
                    this.ShowFirstQueue == other.ShowFirstQueue ||
                    this.ShowFirstQueue != null &&
                    this.ShowFirstQueue.Equals(other.ShowFirstQueue)
                ) &&
                (
                    this.TeamIds == other.TeamIds ||
                    this.TeamIds != null &&
                    this.TeamIds.SequenceEqual(other.TeamIds)
                ) &&
                (
                    this.FilterUsersByTeamIds == other.FilterUsersByTeamIds ||
                    this.FilterUsersByTeamIds != null &&
                    this.FilterUsersByTeamIds.SequenceEqual(other.FilterUsersByTeamIds)
                ) &&
                (
                    this.JourneyActionMapIds == other.JourneyActionMapIds ||
                    this.JourneyActionMapIds != null &&
                    this.JourneyActionMapIds.SequenceEqual(other.JourneyActionMapIds)
                ) &&
                (
                    this.JourneyOutcomeIds == other.JourneyOutcomeIds ||
                    this.JourneyOutcomeIds != null &&
                    this.JourneyOutcomeIds.SequenceEqual(other.JourneyOutcomeIds)
                ) &&
                (
                    this.JourneySegmentIds == other.JourneySegmentIds ||
                    this.JourneySegmentIds != null &&
                    this.JourneySegmentIds.SequenceEqual(other.JourneySegmentIds)
                ) &&
                (
                    this.JourneyActionMapTypes == other.JourneyActionMapTypes ||
                    this.JourneyActionMapTypes != null &&
                    this.JourneyActionMapTypes.SequenceEqual(other.JourneyActionMapTypes)
                ) &&
                (
                    this.DevelopmentRoleList == other.DevelopmentRoleList ||
                    this.DevelopmentRoleList != null &&
                    this.DevelopmentRoleList.SequenceEqual(other.DevelopmentRoleList)
                ) &&
                (
                    this.DevelopmentTypeList == other.DevelopmentTypeList ||
                    this.DevelopmentTypeList != null &&
                    this.DevelopmentTypeList.SequenceEqual(other.DevelopmentTypeList)
                ) &&
                (
                    this.DevelopmentStatusList == other.DevelopmentStatusList ||
                    this.DevelopmentStatusList != null &&
                    this.DevelopmentStatusList.SequenceEqual(other.DevelopmentStatusList)
                ) &&
                (
                    this.DevelopmentModuleIds == other.DevelopmentModuleIds ||
                    this.DevelopmentModuleIds != null &&
                    this.DevelopmentModuleIds.SequenceEqual(other.DevelopmentModuleIds)
                ) &&
                (
                    this.DevelopmentActivityOverdue == other.DevelopmentActivityOverdue ||
                    this.DevelopmentActivityOverdue != null &&
                    this.DevelopmentActivityOverdue.Equals(other.DevelopmentActivityOverdue)
                ) &&
                (
                    this.CustomerSentimentScore == other.CustomerSentimentScore ||
                    this.CustomerSentimentScore != null &&
                    this.CustomerSentimentScore.Equals(other.CustomerSentimentScore)
                ) &&
                (
                    this.CustomerSentimentTrend == other.CustomerSentimentTrend ||
                    this.CustomerSentimentTrend != null &&
                    this.CustomerSentimentTrend.Equals(other.CustomerSentimentTrend)
                ) &&
                (
                    this.FlowTransferTargets == other.FlowTransferTargets ||
                    this.FlowTransferTargets != null &&
                    this.FlowTransferTargets.SequenceEqual(other.FlowTransferTargets)
                ) &&
                (
                    this.DevelopmentName == other.DevelopmentName ||
                    this.DevelopmentName != null &&
                    this.DevelopmentName.Equals(other.DevelopmentName)
                ) &&
                (
                    this.TopicIds == other.TopicIds ||
                    this.TopicIds != null &&
                    this.TopicIds.SequenceEqual(other.TopicIds)
                ) &&
                (
                    this.ExternalTags == other.ExternalTags ||
                    this.ExternalTags != null &&
                    this.ExternalTags.SequenceEqual(other.ExternalTags)
                ) &&
                (
                    this.IsNotResponding == other.IsNotResponding ||
                    this.IsNotResponding != null &&
                    this.IsNotResponding.Equals(other.IsNotResponding)
                ) &&
                (
                    this.IsAuthenticated == other.IsAuthenticated ||
                    this.IsAuthenticated != null &&
                    this.IsAuthenticated.Equals(other.IsAuthenticated)
                ) &&
                (
                    this.BotIds == other.BotIds ||
                    this.BotIds != null &&
                    this.BotIds.SequenceEqual(other.BotIds)
                ) &&
                (
                    this.BotVersions == other.BotVersions ||
                    this.BotVersions != null &&
                    this.BotVersions.SequenceEqual(other.BotVersions)
                ) &&
                (
                    this.BotMessageTypes == other.BotMessageTypes ||
                    this.BotMessageTypes != null &&
                    this.BotMessageTypes.SequenceEqual(other.BotMessageTypes)
                ) &&
                (
                    this.BotProviderList == other.BotProviderList ||
                    this.BotProviderList != null &&
                    this.BotProviderList.SequenceEqual(other.BotProviderList)
                ) &&
                (
                    this.BotProductList == other.BotProductList ||
                    this.BotProductList != null &&
                    this.BotProductList.SequenceEqual(other.BotProductList)
                ) &&
                (
                    this.BotRecognitionFailureReasonList == other.BotRecognitionFailureReasonList ||
                    this.BotRecognitionFailureReasonList != null &&
                    this.BotRecognitionFailureReasonList.SequenceEqual(other.BotRecognitionFailureReasonList)
                ) &&
                (
                    this.BotIntentList == other.BotIntentList ||
                    this.BotIntentList != null &&
                    this.BotIntentList.SequenceEqual(other.BotIntentList)
                ) &&
                (
                    this.BotFinalIntentList == other.BotFinalIntentList ||
                    this.BotFinalIntentList != null &&
                    this.BotFinalIntentList.SequenceEqual(other.BotFinalIntentList)
                ) &&
                (
                    this.BotSlotList == other.BotSlotList ||
                    this.BotSlotList != null &&
                    this.BotSlotList.SequenceEqual(other.BotSlotList)
                ) &&
                (
                    this.BotResultList == other.BotResultList ||
                    this.BotResultList != null &&
                    this.BotResultList.SequenceEqual(other.BotResultList)
                ) &&
                (
                    this.BlockedReasons == other.BlockedReasons ||
                    this.BlockedReasons != null &&
                    this.BlockedReasons.SequenceEqual(other.BlockedReasons)
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
                
                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();
                
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();
                
                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();
                
                if (this.SkillGroups != null)
                    hash = hash * 59 + this.SkillGroups.GetHashCode();
                
                if (this.LanguageIds != null)
                    hash = hash * 59 + this.LanguageIds.GetHashCode();
                
                if (this.LanguageGroups != null)
                    hash = hash * 59 + this.LanguageGroups.GetHashCode();
                
                if (this.Directions != null)
                    hash = hash * 59 + this.Directions.GetHashCode();
                
                if (this.OriginatingDirections != null)
                    hash = hash * 59 + this.OriginatingDirections.GetHashCode();
                
                if (this.WrapUpCodes != null)
                    hash = hash * 59 + this.WrapUpCodes.GetHashCode();
                
                if (this.DnisList != null)
                    hash = hash * 59 + this.DnisList.GetHashCode();
                
                if (this.SessionDnisList != null)
                    hash = hash * 59 + this.SessionDnisList.GetHashCode();
                
                if (this.FilterQueuesByUserIds != null)
                    hash = hash * 59 + this.FilterQueuesByUserIds.GetHashCode();
                
                if (this.FilterUsersByQueueIds != null)
                    hash = hash * 59 + this.FilterUsersByQueueIds.GetHashCode();
                
                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();
                
                if (this.AddressTos != null)
                    hash = hash * 59 + this.AddressTos.GetHashCode();
                
                if (this.AddressFroms != null)
                    hash = hash * 59 + this.AddressFroms.GetHashCode();
                
                if (this.OutboundCampaignIds != null)
                    hash = hash * 59 + this.OutboundCampaignIds.GetHashCode();
                
                if (this.OutboundContactListIds != null)
                    hash = hash * 59 + this.OutboundContactListIds.GetHashCode();
                
                if (this.ContactIds != null)
                    hash = hash * 59 + this.ContactIds.GetHashCode();
                
                if (this.ExternalContactIds != null)
                    hash = hash * 59 + this.ExternalContactIds.GetHashCode();
                
                if (this.ExternalOrgIds != null)
                    hash = hash * 59 + this.ExternalOrgIds.GetHashCode();
                
                if (this.AniList != null)
                    hash = hash * 59 + this.AniList.GetHashCode();
                
                if (this.DurationsMilliseconds != null)
                    hash = hash * 59 + this.DurationsMilliseconds.GetHashCode();
                
                if (this.AcdDurationsMilliseconds != null)
                    hash = hash * 59 + this.AcdDurationsMilliseconds.GetHashCode();
                
                if (this.TalkDurationsMilliseconds != null)
                    hash = hash * 59 + this.TalkDurationsMilliseconds.GetHashCode();
                
                if (this.AcwDurationsMilliseconds != null)
                    hash = hash * 59 + this.AcwDurationsMilliseconds.GetHashCode();
                
                if (this.HandleDurationsMilliseconds != null)
                    hash = hash * 59 + this.HandleDurationsMilliseconds.GetHashCode();
                
                if (this.HoldDurationsMilliseconds != null)
                    hash = hash * 59 + this.HoldDurationsMilliseconds.GetHashCode();
                
                if (this.AbandonDurationsMilliseconds != null)
                    hash = hash * 59 + this.AbandonDurationsMilliseconds.GetHashCode();
                
                if (this.EvaluationScore != null)
                    hash = hash * 59 + this.EvaluationScore.GetHashCode();
                
                if (this.EvaluationCriticalScore != null)
                    hash = hash * 59 + this.EvaluationCriticalScore.GetHashCode();
                
                if (this.EvaluationFormIds != null)
                    hash = hash * 59 + this.EvaluationFormIds.GetHashCode();
                
                if (this.EvaluatedAgentIds != null)
                    hash = hash * 59 + this.EvaluatedAgentIds.GetHashCode();
                
                if (this.EvaluatorIds != null)
                    hash = hash * 59 + this.EvaluatorIds.GetHashCode();
                
                if (this.Transferred != null)
                    hash = hash * 59 + this.Transferred.GetHashCode();
                
                if (this.Abandoned != null)
                    hash = hash * 59 + this.Abandoned.GetHashCode();
                
                if (this.Answered != null)
                    hash = hash * 59 + this.Answered.GetHashCode();
                
                if (this.MessageTypes != null)
                    hash = hash * 59 + this.MessageTypes.GetHashCode();
                
                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();
                
                if (this.SurveyFormIds != null)
                    hash = hash * 59 + this.SurveyFormIds.GetHashCode();
                
                if (this.SurveyTotalScore != null)
                    hash = hash * 59 + this.SurveyTotalScore.GetHashCode();
                
                if (this.SurveyNpsScore != null)
                    hash = hash * 59 + this.SurveyNpsScore.GetHashCode();
                
                if (this.Mos != null)
                    hash = hash * 59 + this.Mos.GetHashCode();
                
                if (this.SurveyQuestionGroupScore != null)
                    hash = hash * 59 + this.SurveyQuestionGroupScore.GetHashCode();
                
                if (this.SurveyPromoterScore != null)
                    hash = hash * 59 + this.SurveyPromoterScore.GetHashCode();
                
                if (this.SurveyFormContextIds != null)
                    hash = hash * 59 + this.SurveyFormContextIds.GetHashCode();
                
                if (this.ConversationIds != null)
                    hash = hash * 59 + this.ConversationIds.GetHashCode();
                
                if (this.SipCallIds != null)
                    hash = hash * 59 + this.SipCallIds.GetHashCode();
                
                if (this.IsEnded != null)
                    hash = hash * 59 + this.IsEnded.GetHashCode();
                
                if (this.IsSurveyed != null)
                    hash = hash * 59 + this.IsSurveyed.GetHashCode();
                
                if (this.SurveyScores != null)
                    hash = hash * 59 + this.SurveyScores.GetHashCode();
                
                if (this.PromoterScores != null)
                    hash = hash * 59 + this.PromoterScores.GetHashCode();
                
                if (this.IsCampaign != null)
                    hash = hash * 59 + this.IsCampaign.GetHashCode();
                
                if (this.SurveyStatuses != null)
                    hash = hash * 59 + this.SurveyStatuses.GetHashCode();
                
                if (this.ConversationProperties != null)
                    hash = hash * 59 + this.ConversationProperties.GetHashCode();
                
                if (this.IsBlindTransferred != null)
                    hash = hash * 59 + this.IsBlindTransferred.GetHashCode();
                
                if (this.IsConsulted != null)
                    hash = hash * 59 + this.IsConsulted.GetHashCode();
                
                if (this.IsConsultTransferred != null)
                    hash = hash * 59 + this.IsConsultTransferred.GetHashCode();
                
                if (this.RemoteParticipants != null)
                    hash = hash * 59 + this.RemoteParticipants.GetHashCode();
                
                if (this.FlowIds != null)
                    hash = hash * 59 + this.FlowIds.GetHashCode();
                
                if (this.FlowOutcomeIds != null)
                    hash = hash * 59 + this.FlowOutcomeIds.GetHashCode();
                
                if (this.FlowOutcomeValues != null)
                    hash = hash * 59 + this.FlowOutcomeValues.GetHashCode();
                
                if (this.FlowDestinationTypes != null)
                    hash = hash * 59 + this.FlowDestinationTypes.GetHashCode();
                
                if (this.FlowDisconnectReasons != null)
                    hash = hash * 59 + this.FlowDisconnectReasons.GetHashCode();
                
                if (this.FlowTypes != null)
                    hash = hash * 59 + this.FlowTypes.GetHashCode();
                
                if (this.FlowEntryTypes != null)
                    hash = hash * 59 + this.FlowEntryTypes.GetHashCode();
                
                if (this.FlowEntryReasons != null)
                    hash = hash * 59 + this.FlowEntryReasons.GetHashCode();
                
                if (this.FlowVersions != null)
                    hash = hash * 59 + this.FlowVersions.GetHashCode();
                
                if (this.GroupIds != null)
                    hash = hash * 59 + this.GroupIds.GetHashCode();
                
                if (this.HasJourneyCustomerId != null)
                    hash = hash * 59 + this.HasJourneyCustomerId.GetHashCode();
                
                if (this.HasJourneyActionMapId != null)
                    hash = hash * 59 + this.HasJourneyActionMapId.GetHashCode();
                
                if (this.HasJourneyVisitId != null)
                    hash = hash * 59 + this.HasJourneyVisitId.GetHashCode();
                
                if (this.HasMedia != null)
                    hash = hash * 59 + this.HasMedia.GetHashCode();
                
                if (this.RoleIds != null)
                    hash = hash * 59 + this.RoleIds.GetHashCode();
                
                if (this.ReportsTos != null)
                    hash = hash * 59 + this.ReportsTos.GetHashCode();
                
                if (this.LocationIds != null)
                    hash = hash * 59 + this.LocationIds.GetHashCode();
                
                if (this.FlowOutTypes != null)
                    hash = hash * 59 + this.FlowOutTypes.GetHashCode();
                
                if (this.ProviderList != null)
                    hash = hash * 59 + this.ProviderList.GetHashCode();
                
                if (this.CallbackNumberList != null)
                    hash = hash * 59 + this.CallbackNumberList.GetHashCode();
                
                if (this.CallbackInterval != null)
                    hash = hash * 59 + this.CallbackInterval.GetHashCode();
                
                if (this.UsedRoutingTypes != null)
                    hash = hash * 59 + this.UsedRoutingTypes.GetHashCode();
                
                if (this.RequestedRoutingTypes != null)
                    hash = hash * 59 + this.RequestedRoutingTypes.GetHashCode();
                
                if (this.HasAgentAssistId != null)
                    hash = hash * 59 + this.HasAgentAssistId.GetHashCode();
                
                if (this.Transcripts != null)
                    hash = hash * 59 + this.Transcripts.GetHashCode();
                
                if (this.TranscriptLanguages != null)
                    hash = hash * 59 + this.TranscriptLanguages.GetHashCode();
                
                if (this.ParticipantPurposes != null)
                    hash = hash * 59 + this.ParticipantPurposes.GetHashCode();
                
                if (this.ShowFirstQueue != null)
                    hash = hash * 59 + this.ShowFirstQueue.GetHashCode();
                
                if (this.TeamIds != null)
                    hash = hash * 59 + this.TeamIds.GetHashCode();
                
                if (this.FilterUsersByTeamIds != null)
                    hash = hash * 59 + this.FilterUsersByTeamIds.GetHashCode();
                
                if (this.JourneyActionMapIds != null)
                    hash = hash * 59 + this.JourneyActionMapIds.GetHashCode();
                
                if (this.JourneyOutcomeIds != null)
                    hash = hash * 59 + this.JourneyOutcomeIds.GetHashCode();
                
                if (this.JourneySegmentIds != null)
                    hash = hash * 59 + this.JourneySegmentIds.GetHashCode();
                
                if (this.JourneyActionMapTypes != null)
                    hash = hash * 59 + this.JourneyActionMapTypes.GetHashCode();
                
                if (this.DevelopmentRoleList != null)
                    hash = hash * 59 + this.DevelopmentRoleList.GetHashCode();
                
                if (this.DevelopmentTypeList != null)
                    hash = hash * 59 + this.DevelopmentTypeList.GetHashCode();
                
                if (this.DevelopmentStatusList != null)
                    hash = hash * 59 + this.DevelopmentStatusList.GetHashCode();
                
                if (this.DevelopmentModuleIds != null)
                    hash = hash * 59 + this.DevelopmentModuleIds.GetHashCode();
                
                if (this.DevelopmentActivityOverdue != null)
                    hash = hash * 59 + this.DevelopmentActivityOverdue.GetHashCode();
                
                if (this.CustomerSentimentScore != null)
                    hash = hash * 59 + this.CustomerSentimentScore.GetHashCode();
                
                if (this.CustomerSentimentTrend != null)
                    hash = hash * 59 + this.CustomerSentimentTrend.GetHashCode();
                
                if (this.FlowTransferTargets != null)
                    hash = hash * 59 + this.FlowTransferTargets.GetHashCode();
                
                if (this.DevelopmentName != null)
                    hash = hash * 59 + this.DevelopmentName.GetHashCode();
                
                if (this.TopicIds != null)
                    hash = hash * 59 + this.TopicIds.GetHashCode();
                
                if (this.ExternalTags != null)
                    hash = hash * 59 + this.ExternalTags.GetHashCode();
                
                if (this.IsNotResponding != null)
                    hash = hash * 59 + this.IsNotResponding.GetHashCode();
                
                if (this.IsAuthenticated != null)
                    hash = hash * 59 + this.IsAuthenticated.GetHashCode();
                
                if (this.BotIds != null)
                    hash = hash * 59 + this.BotIds.GetHashCode();
                
                if (this.BotVersions != null)
                    hash = hash * 59 + this.BotVersions.GetHashCode();
                
                if (this.BotMessageTypes != null)
                    hash = hash * 59 + this.BotMessageTypes.GetHashCode();
                
                if (this.BotProviderList != null)
                    hash = hash * 59 + this.BotProviderList.GetHashCode();
                
                if (this.BotProductList != null)
                    hash = hash * 59 + this.BotProductList.GetHashCode();
                
                if (this.BotRecognitionFailureReasonList != null)
                    hash = hash * 59 + this.BotRecognitionFailureReasonList.GetHashCode();
                
                if (this.BotIntentList != null)
                    hash = hash * 59 + this.BotIntentList.GetHashCode();
                
                if (this.BotFinalIntentList != null)
                    hash = hash * 59 + this.BotFinalIntentList.GetHashCode();
                
                if (this.BotSlotList != null)
                    hash = hash * 59 + this.BotSlotList.GetHashCode();
                
                if (this.BotResultList != null)
                    hash = hash * 59 + this.BotResultList.GetHashCode();
                
                if (this.BlockedReasons != null)
                    hash = hash * 59 + this.BlockedReasons.GetHashCode();
                
                return hash;
            }
        }
    }

}
