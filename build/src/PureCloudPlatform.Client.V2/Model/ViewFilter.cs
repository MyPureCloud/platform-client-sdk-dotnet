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
            /// Enum Internalmessage for "internalmessage"
            /// </summary>
            [EnumMember(Value = "internalmessage")]
            Internalmessage,
            
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
            Instagram,
            
            /// <summary>
            /// Enum Apple for "apple"
            /// </summary>
            [EnumMember(Value = "apple")]
            Apple
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
            Architectflow,
            
            /// <summary>
            /// Enum Openaction for "openAction"
            /// </summary>
            [EnumMember(Value = "openAction")]
            Openaction
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
            Coaching,
            
            /// <summary>
            /// Enum Assessment for "Assessment"
            /// </summary>
            [EnumMember(Value = "Assessment")]
            Assessment,
            
            /// <summary>
            /// Enum Assessedcontent for "AssessedContent"
            /// </summary>
            [EnumMember(Value = "AssessedContent")]
            Assessedcontent,
            
            /// <summary>
            /// Enum External for "External"
            /// </summary>
            [EnumMember(Value = "External")]
            External,
            
            /// <summary>
            /// Enum Native for "Native"
            /// </summary>
            [EnumMember(Value = "Native")]
            Native
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
            Completed,
            
            /// <summary>
            /// Enum Notcompleted for "NotCompleted"
            /// </summary>
            [EnumMember(Value = "NotCompleted")]
            Notcompleted
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
            Genesysbyob,
            
            /// <summary>
            /// Enum Amazonlexv2 for "AmazonLexV2"
            /// </summary>
            [EnumMember(Value = "AmazonLexV2")]
            Amazonlexv2,
            
            /// <summary>
            /// Enum Googledialogflowcxresell for "GoogleDialogFlowCxResell"
            /// </summary>
            [EnumMember(Value = "GoogleDialogFlowCxResell")]
            Googledialogflowcxresell,
            
            /// <summary>
            /// Enum Googlesttbotflow for "GoogleSttBotFlow"
            /// </summary>
            [EnumMember(Value = "GoogleSttBotFlow")]
            Googlesttbotflow,
            
            /// <summary>
            /// Enum Microsoftsttbotflow for "MicrosoftSttBotFlow"
            /// </summary>
            [EnumMember(Value = "MicrosoftSttBotFlow")]
            Microsoftsttbotflow
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
            /// Enum Noinputdisambiguation for "NoInputDisambiguation"
            /// </summary>
            [EnumMember(Value = "NoInputDisambiguation")]
            Noinputdisambiguation,
            
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
            /// Enum Nomatchdisambiguation for "NoMatchDisambiguation"
            /// </summary>
            [EnumMember(Value = "NoMatchDisambiguation")]
            Nomatchdisambiguation,
            
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
            Disconnectrecognitionfailure,
            
            /// <summary>
            /// Enum Transfertoacd for "TransferToACD"
            /// </summary>
            [EnumMember(Value = "TransferToACD")]
            Transfertoacd
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
        /// Gets or Sets EmailDeliveryStatusList
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EmailDeliveryStatusListEnum
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
            /// Enum Deliverypushed for "DeliveryPushed"
            /// </summary>
            [EnumMember(Value = "DeliveryPushed")]
            Deliverypushed,
            
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
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published,
            
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
        /// Filter to indicate the availability of the dashboard is public or private.
        /// </summary>
        /// <value>Filter to indicate the availability of the dashboard is public or private.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AvailableDashboardEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public,
            
            /// <summary>
            /// Enum Private for "Private"
            /// </summary>
            [EnumMember(Value = "Private")]
            Private
        }
        /// <summary>
        /// Gets or Sets EvaluationStatuses
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EvaluationStatusesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Finished for "Finished"
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Inreview for "InReview"
            /// </summary>
            [EnumMember(Value = "InReview")]
            Inreview,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Retracted for "Retracted"
            /// </summary>
            [EnumMember(Value = "Retracted")]
            Retracted
        }
        /// <summary>
        /// The user supplied state value in the view
        /// </summary>
        /// <value>The user supplied state value in the view</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UserStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Activeandinactive for "ActiveAndInactive"
            /// </summary>
            [EnumMember(Value = "ActiveAndInactive")]
            Activeandinactive,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted
        }
        /// <summary>
        /// Gets or Sets SurveyTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SurveyTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Web for "Web"
            /// </summary>
            [EnumMember(Value = "Web")]
            Web,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice
        }
        /// <summary>
        /// Gets or Sets SurveyResponseStatuses
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SurveyResponseStatusesEnum
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
            /// Enum Fullresponse for "FullResponse"
            /// </summary>
            [EnumMember(Value = "FullResponse")]
            Fullresponse,
            
            /// <summary>
            /// Enum Partialresponse for "PartialResponse"
            /// </summary>
            [EnumMember(Value = "PartialResponse")]
            Partialresponse
        }
        /// <summary>
        /// Gets or Sets BotFlowTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BotFlowTypesEnum
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
            /// Enum Bot for "Bot"
            /// </summary>
            [EnumMember(Value = "Bot")]
            Bot,
            
            /// <summary>
            /// Enum Digitalbot for "DigitalBot"
            /// </summary>
            [EnumMember(Value = "DigitalBot")]
            Digitalbot,
            
            /// <summary>
            /// Enum Voicesurvey for "VoiceSurvey"
            /// </summary>
            [EnumMember(Value = "VoiceSurvey")]
            Voicesurvey
        }
        /// <summary>
        /// The state of dashboard being filtered
        /// </summary>
        /// <value>The state of dashboard being filtered</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DashboardStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted
        }
        /// <summary>
        /// The type of dashboard being filtered
        /// </summary>
        /// <value>The type of dashboard being filtered</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DashboardTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public,
            
            /// <summary>
            /// Enum Private for "Private"
            /// </summary>
            [EnumMember(Value = "Private")]
            Private,
            
            /// <summary>
            /// Enum Shared for "Shared"
            /// </summary>
            [EnumMember(Value = "Shared")]
            Shared,
            
            /// <summary>
            /// Enum Favorites for "Favorites"
            /// </summary>
            [EnumMember(Value = "Favorites")]
            Favorites
        }
        /// <summary>
        /// The type of dashboard access being filtered
        /// </summary>
        /// <value>The type of dashboard access being filtered</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DashboardAccessFilterEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ownedbyme for "OwnedByMe"
            /// </summary>
            [EnumMember(Value = "OwnedByMe")]
            Ownedbyme,
            
            /// <summary>
            /// Enum Ownedbyanyone for "OwnedByAnyone"
            /// </summary>
            [EnumMember(Value = "OwnedByAnyone")]
            Ownedbyanyone,
            
            /// <summary>
            /// Enum Notownedbyme for "NotOwnedByMe"
            /// </summary>
            [EnumMember(Value = "NotOwnedByMe")]
            Notownedbyme
        }
        /// <summary>
        /// Gets or Sets SocialChannels
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SocialChannelsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Twitter for "Twitter"
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Facebook for "Facebook"
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Instagram for "Instagram"
            /// </summary>
            [EnumMember(Value = "Instagram")]
            Instagram,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open
        }
        /// <summary>
        /// Gets or Sets SocialSentimentCategory
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SocialSentimentCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Positive for "Positive"
            /// </summary>
            [EnumMember(Value = "Positive")]
            Positive,
            
            /// <summary>
            /// Enum Negative for "Negative"
            /// </summary>
            [EnumMember(Value = "Negative")]
            Negative,
            
            /// <summary>
            /// Enum Neutral for "Neutral"
            /// </summary>
            [EnumMember(Value = "Neutral")]
            Neutral,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Gets or Sets SocialContentType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SocialContentTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>
            [EnumMember(Value = "Image")]
            Image,
            
            /// <summary>
            /// Enum Video for "Video"
            /// </summary>
            [EnumMember(Value = "Video")]
            Video
        }
        /// <summary>
        /// Gets or Sets SocialClassifications
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SocialClassificationsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public,
            
            /// <summary>
            /// Enum Private for "Private"
            /// </summary>
            [EnumMember(Value = "Private")]
            Private
        }
        /// <summary>
        /// Gets or Sets RecommendationSources
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RecommendationSourcesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Knowledgesearch for "KnowledgeSearch"
            /// </summary>
            [EnumMember(Value = "KnowledgeSearch")]
            Knowledgesearch,
            
            /// <summary>
            /// Enum Rulesengine for "RulesEngine"
            /// </summary>
            [EnumMember(Value = "RulesEngine")]
            Rulesengine,
            
            /// <summary>
            /// Enum Manualsearch for "ManualSearch"
            /// </summary>
            [EnumMember(Value = "ManualSearch")]
            Manualsearch
        }
        /// <summary>
        /// Sets the role when viewing agent evaluations
        /// </summary>
        /// <value>Sets the role when viewing agent evaluations</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EvaluationRoleEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Evaluator for "Evaluator"
            /// </summary>
            [EnumMember(Value = "Evaluator")]
            Evaluator,
            
            /// <summary>
            /// Enum Supervisor for "Supervisor"
            /// </summary>
            [EnumMember(Value = "Supervisor")]
            Supervisor
        }
        /// <summary>
        /// Gets or Sets ViewMetrics
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ViewMetricsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum AvgTalkTime for "AVG_TALK_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_TALK_TIME")]
            AvgTalkTime,
            
            /// <summary>
            /// Enum AvgHoldTime for "AVG_HOLD_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_HOLD_TIME")]
            AvgHoldTime,
            
            /// <summary>
            /// Enum AvgAcwTime for "AVG_ACW_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_ACW_TIME")]
            AvgAcwTime,
            
            /// <summary>
            /// Enum AvgWaitTime for "AVG_WAIT_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_WAIT_TIME")]
            AvgWaitTime,
            
            /// <summary>
            /// Enum AvgHandleTime for "AVG_HANDLE_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_HANDLE_TIME")]
            AvgHandleTime,
            
            /// <summary>
            /// Enum AvgAlertTime for "AVG_ALERT_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_ALERT_TIME")]
            AvgAlertTime,
            
            /// <summary>
            /// Enum AvgAnswerTime for "AVG_ANSWER_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_ANSWER_TIME")]
            AvgAnswerTime,
            
            /// <summary>
            /// Enum AvgAbandonTime for "AVG_ABANDON_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_ABANDON_TIME")]
            AvgAbandonTime,
            
            /// <summary>
            /// Enum TotalTalkTime for "TOTAL_TALK_TIME"
            /// </summary>
            [EnumMember(Value = "TOTAL_TALK_TIME")]
            TotalTalkTime,
            
            /// <summary>
            /// Enum TotalHandleTime for "TOTAL_HANDLE_TIME"
            /// </summary>
            [EnumMember(Value = "TOTAL_HANDLE_TIME")]
            TotalHandleTime,
            
            /// <summary>
            /// Enum TotalHoldTime for "TOTAL_HOLD_TIME"
            /// </summary>
            [EnumMember(Value = "TOTAL_HOLD_TIME")]
            TotalHoldTime,
            
            /// <summary>
            /// Enum TotalAcwTime for "TOTAL_ACW_TIME"
            /// </summary>
            [EnumMember(Value = "TOTAL_ACW_TIME")]
            TotalAcwTime,
            
            /// <summary>
            /// Enum TotalAlertTime for "TOTAL_ALERT_TIME"
            /// </summary>
            [EnumMember(Value = "TOTAL_ALERT_TIME")]
            TotalAlertTime,
            
            /// <summary>
            /// Enum MaxAbandonTime for "MAX_ABANDON_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_ABANDON_TIME")]
            MaxAbandonTime,
            
            /// <summary>
            /// Enum MaxWaitTime for "MAX_WAIT_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_WAIT_TIME")]
            MaxWaitTime,
            
            /// <summary>
            /// Enum MaxTalkTime for "MAX_TALK_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_TALK_TIME")]
            MaxTalkTime,
            
            /// <summary>
            /// Enum MaxHoldTime for "MAX_HOLD_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_HOLD_TIME")]
            MaxHoldTime,
            
            /// <summary>
            /// Enum MaxAcwTime for "MAX_ACW_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_ACW_TIME")]
            MaxAcwTime,
            
            /// <summary>
            /// Enum MinAbandonTime for "MIN_ABANDON_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_ABANDON_TIME")]
            MinAbandonTime,
            
            /// <summary>
            /// Enum MinWaitTime for "MIN_WAIT_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_WAIT_TIME")]
            MinWaitTime,
            
            /// <summary>
            /// Enum MinTalkTime for "MIN_TALK_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_TALK_TIME")]
            MinTalkTime,
            
            /// <summary>
            /// Enum MinHoldTime for "MIN_HOLD_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_HOLD_TIME")]
            MinHoldTime,
            
            /// <summary>
            /// Enum MinAcwTime for "MIN_ACW_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_ACW_TIME")]
            MinAcwTime,
            
            /// <summary>
            /// Enum AlertCount for "ALERT_COUNT"
            /// </summary>
            [EnumMember(Value = "ALERT_COUNT")]
            AlertCount,
            
            /// <summary>
            /// Enum OfferedCount for "OFFERED_COUNT"
            /// </summary>
            [EnumMember(Value = "OFFERED_COUNT")]
            OfferedCount,
            
            /// <summary>
            /// Enum AbandonedCount for "ABANDONED_COUNT"
            /// </summary>
            [EnumMember(Value = "ABANDONED_COUNT")]
            AbandonedCount,
            
            /// <summary>
            /// Enum AbandonedPercent for "ABANDONED_PERCENT"
            /// </summary>
            [EnumMember(Value = "ABANDONED_PERCENT")]
            AbandonedPercent,
            
            /// <summary>
            /// Enum ShortAbandonedCount for "SHORT_ABANDONED_COUNT"
            /// </summary>
            [EnumMember(Value = "SHORT_ABANDONED_COUNT")]
            ShortAbandonedCount,
            
            /// <summary>
            /// Enum ShortAbandonedPercent for "SHORT_ABANDONED_PERCENT"
            /// </summary>
            [EnumMember(Value = "SHORT_ABANDONED_PERCENT")]
            ShortAbandonedPercent,
            
            /// <summary>
            /// Enum AbandonedNoShortCount for "ABANDONED_NO_SHORT_COUNT"
            /// </summary>
            [EnumMember(Value = "ABANDONED_NO_SHORT_COUNT")]
            AbandonedNoShortCount,
            
            /// <summary>
            /// Enum AbandonedNoShortPercent for "ABANDONED_NO_SHORT_PERCENT"
            /// </summary>
            [EnumMember(Value = "ABANDONED_NO_SHORT_PERCENT")]
            AbandonedNoShortPercent,
            
            /// <summary>
            /// Enum AnsweredCount for "ANSWERED_COUNT"
            /// </summary>
            [EnumMember(Value = "ANSWERED_COUNT")]
            AnsweredCount,
            
            /// <summary>
            /// Enum AnsweredPercent for "ANSWERED_PERCENT"
            /// </summary>
            [EnumMember(Value = "ANSWERED_PERCENT")]
            AnsweredPercent,
            
            /// <summary>
            /// Enum FlowoutCount for "FLOWOUT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOWOUT_COUNT")]
            FlowoutCount,
            
            /// <summary>
            /// Enum FlowoutPercent for "FLOWOUT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOWOUT_PERCENT")]
            FlowoutPercent,
            
            /// <summary>
            /// Enum OutboundCount for "OUTBOUND_COUNT"
            /// </summary>
            [EnumMember(Value = "OUTBOUND_COUNT")]
            OutboundCount,
            
            /// <summary>
            /// Enum OutboundAttemptedCount for "OUTBOUND_ATTEMPTED_COUNT"
            /// </summary>
            [EnumMember(Value = "OUTBOUND_ATTEMPTED_COUNT")]
            OutboundAttemptedCount,
            
            /// <summary>
            /// Enum VoicemailCount for "VOICEMAIL_COUNT"
            /// </summary>
            [EnumMember(Value = "VOICEMAIL_COUNT")]
            VoicemailCount,
            
            /// <summary>
            /// Enum HandledCount for "HANDLED_COUNT"
            /// </summary>
            [EnumMember(Value = "HANDLED_COUNT")]
            HandledCount,
            
            /// <summary>
            /// Enum HeldCount for "HELD_COUNT"
            /// </summary>
            [EnumMember(Value = "HELD_COUNT")]
            HeldCount,
            
            /// <summary>
            /// Enum TransferredCount for "TRANSFERRED_COUNT"
            /// </summary>
            [EnumMember(Value = "TRANSFERRED_COUNT")]
            TransferredCount,
            
            /// <summary>
            /// Enum TransferredPercent for "TRANSFERRED_PERCENT"
            /// </summary>
            [EnumMember(Value = "TRANSFERRED_PERCENT")]
            TransferredPercent,
            
            /// <summary>
            /// Enum WaitingCurrent for "WAITING_CURRENT"
            /// </summary>
            [EnumMember(Value = "WAITING_CURRENT")]
            WaitingCurrent,
            
            /// <summary>
            /// Enum InteractingCurrent for "INTERACTING_CURRENT"
            /// </summary>
            [EnumMember(Value = "INTERACTING_CURRENT")]
            InteractingCurrent,
            
            /// <summary>
            /// Enum HeldCurrent for "HELD_CURRENT"
            /// </summary>
            [EnumMember(Value = "HELD_CURRENT")]
            HeldCurrent,
            
            /// <summary>
            /// Enum AlertingCurrent for "ALERTING_CURRENT"
            /// </summary>
            [EnumMember(Value = "ALERTING_CURRENT")]
            AlertingCurrent,
            
            /// <summary>
            /// Enum ServiceLevel for "SERVICE_LEVEL"
            /// </summary>
            [EnumMember(Value = "SERVICE_LEVEL")]
            ServiceLevel,
            
            /// <summary>
            /// Enum OverServiceLevel for "OVER_SERVICE_LEVEL"
            /// </summary>
            [EnumMember(Value = "OVER_SERVICE_LEVEL")]
            OverServiceLevel,
            
            /// <summary>
            /// Enum OnlineAgents for "ONLINE_AGENTS"
            /// </summary>
            [EnumMember(Value = "ONLINE_AGENTS")]
            OnlineAgents,
            
            /// <summary>
            /// Enum AvailableAgents for "AVAILABLE_AGENTS"
            /// </summary>
            [EnumMember(Value = "AVAILABLE_AGENTS")]
            AvailableAgents,
            
            /// <summary>
            /// Enum AwayAgents for "AWAY_AGENTS"
            /// </summary>
            [EnumMember(Value = "AWAY_AGENTS")]
            AwayAgents,
            
            /// <summary>
            /// Enum BreakAgents for "BREAK_AGENTS"
            /// </summary>
            [EnumMember(Value = "BREAK_AGENTS")]
            BreakAgents,
            
            /// <summary>
            /// Enum MealAgents for "MEAL_AGENTS"
            /// </summary>
            [EnumMember(Value = "MEAL_AGENTS")]
            MealAgents,
            
            /// <summary>
            /// Enum TrainingAgents for "TRAINING_AGENTS"
            /// </summary>
            [EnumMember(Value = "TRAINING_AGENTS")]
            TrainingAgents,
            
            /// <summary>
            /// Enum BusyAgents for "BUSY_AGENTS"
            /// </summary>
            [EnumMember(Value = "BUSY_AGENTS")]
            BusyAgents,
            
            /// <summary>
            /// Enum MeetingAgents for "MEETING_AGENTS"
            /// </summary>
            [EnumMember(Value = "MEETING_AGENTS")]
            MeetingAgents,
            
            /// <summary>
            /// Enum SystemAwayAgents for "SYSTEM_AWAY_AGENTS"
            /// </summary>
            [EnumMember(Value = "SYSTEM_AWAY_AGENTS")]
            SystemAwayAgents,
            
            /// <summary>
            /// Enum OfflineAgents for "OFFLINE_AGENTS"
            /// </summary>
            [EnumMember(Value = "OFFLINE_AGENTS")]
            OfflineAgents,
            
            /// <summary>
            /// Enum OnQueueAgents for "ON_QUEUE_AGENTS"
            /// </summary>
            [EnumMember(Value = "ON_QUEUE_AGENTS")]
            OnQueueAgents,
            
            /// <summary>
            /// Enum OffQueueAgents for "OFF_QUEUE_AGENTS"
            /// </summary>
            [EnumMember(Value = "OFF_QUEUE_AGENTS")]
            OffQueueAgents,
            
            /// <summary>
            /// Enum InteractingAgents for "INTERACTING_AGENTS"
            /// </summary>
            [EnumMember(Value = "INTERACTING_AGENTS")]
            InteractingAgents,
            
            /// <summary>
            /// Enum AcwAgents for "ACW_AGENTS"
            /// </summary>
            [EnumMember(Value = "ACW_AGENTS")]
            AcwAgents,
            
            /// <summary>
            /// Enum CommunicatingAgents for "COMMUNICATING_AGENTS"
            /// </summary>
            [EnumMember(Value = "COMMUNICATING_AGENTS")]
            CommunicatingAgents,
            
            /// <summary>
            /// Enum IdleAgents for "IDLE_AGENTS"
            /// </summary>
            [EnumMember(Value = "IDLE_AGENTS")]
            IdleAgents,
            
            /// <summary>
            /// Enum NotRespondingAgents for "NOT_RESPONDING_AGENTS"
            /// </summary>
            [EnumMember(Value = "NOT_RESPONDING_AGENTS")]
            NotRespondingAgents,
            
            /// <summary>
            /// Enum LongestWaiting for "LONGEST_WAITING"
            /// </summary>
            [EnumMember(Value = "LONGEST_WAITING")]
            LongestWaiting,
            
            /// <summary>
            /// Enum LongestInteracting for "LONGEST_INTERACTING"
            /// </summary>
            [EnumMember(Value = "LONGEST_INTERACTING")]
            LongestInteracting,
            
            /// <summary>
            /// Enum FlowActiveLongest for "FLOW_ACTIVE_LONGEST"
            /// </summary>
            [EnumMember(Value = "FLOW_ACTIVE_LONGEST")]
            FlowActiveLongest,
            
            /// <summary>
            /// Enum FlowActiveCurrent for "FLOW_ACTIVE_CURRENT"
            /// </summary>
            [EnumMember(Value = "FLOW_ACTIVE_CURRENT")]
            FlowActiveCurrent,
            
            /// <summary>
            /// Enum FlowEntriesCount for "FLOW_ENTRIES_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_ENTRIES_COUNT")]
            FlowEntriesCount,
            
            /// <summary>
            /// Enum FlowTotalDuration for "FLOW_TOTAL_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_TOTAL_DURATION")]
            FlowTotalDuration,
            
            /// <summary>
            /// Enum FlowMaxDuration for "FLOW_MAX_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_MAX_DURATION")]
            FlowMaxDuration,
            
            /// <summary>
            /// Enum FlowAvgDuration for "FLOW_AVG_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_AVG_DURATION")]
            FlowAvgDuration,
            
            /// <summary>
            /// Enum FlowDisconnectCount for "FLOW_DISCONNECT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_DISCONNECT_COUNT")]
            FlowDisconnectCount,
            
            /// <summary>
            /// Enum FlowDisconnectPercent for "FLOW_DISCONNECT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_DISCONNECT_PERCENT")]
            FlowDisconnectPercent,
            
            /// <summary>
            /// Enum FlowTotalDisconnectDuration for "FLOW_TOTAL_DISCONNECT_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_TOTAL_DISCONNECT_DURATION")]
            FlowTotalDisconnectDuration,
            
            /// <summary>
            /// Enum FlowAvgDisconnectDuration for "FLOW_AVG_DISCONNECT_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_AVG_DISCONNECT_DURATION")]
            FlowAvgDisconnectDuration,
            
            /// <summary>
            /// Enum FlowMaxDisconnectDuration for "FLOW_MAX_DISCONNECT_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_MAX_DISCONNECT_DURATION")]
            FlowMaxDisconnectDuration,
            
            /// <summary>
            /// Enum FlowFlowDisconnect for "FLOW_FLOW_DISCONNECT"
            /// </summary>
            [EnumMember(Value = "FLOW_FLOW_DISCONNECT")]
            FlowFlowDisconnect,
            
            /// <summary>
            /// Enum FlowFlowDisconnectPercent for "FLOW_FLOW_DISCONNECT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_FLOW_DISCONNECT_PERCENT")]
            FlowFlowDisconnectPercent,
            
            /// <summary>
            /// Enum FlowSystemErrorDisconnect for "FLOW_SYSTEM_ERROR_DISCONNECT"
            /// </summary>
            [EnumMember(Value = "FLOW_SYSTEM_ERROR_DISCONNECT")]
            FlowSystemErrorDisconnect,
            
            /// <summary>
            /// Enum FlowSystemErrorDisconnectPercent for "FLOW_SYSTEM_ERROR_DISCONNECT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_SYSTEM_ERROR_DISCONNECT_PERCENT")]
            FlowSystemErrorDisconnectPercent,
            
            /// <summary>
            /// Enum FlowCustomerDisconnect for "FLOW_CUSTOMER_DISCONNECT"
            /// </summary>
            [EnumMember(Value = "FLOW_CUSTOMER_DISCONNECT")]
            FlowCustomerDisconnect,
            
            /// <summary>
            /// Enum FlowCustomerDisconnectPercent for "FLOW_CUSTOMER_DISCONNECT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_CUSTOMER_DISCONNECT_PERCENT")]
            FlowCustomerDisconnectPercent,
            
            /// <summary>
            /// Enum FlowShortDisconnect for "FLOW_SHORT_DISCONNECT"
            /// </summary>
            [EnumMember(Value = "FLOW_SHORT_DISCONNECT")]
            FlowShortDisconnect,
            
            /// <summary>
            /// Enum FlowShortDisconnectPercent for "FLOW_SHORT_DISCONNECT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_SHORT_DISCONNECT_PERCENT")]
            FlowShortDisconnectPercent,
            
            /// <summary>
            /// Enum FlowExitCount for "FLOW_EXIT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_EXIT_COUNT")]
            FlowExitCount,
            
            /// <summary>
            /// Enum FlowExitPercent for "FLOW_EXIT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_EXIT_PERCENT")]
            FlowExitPercent,
            
            /// <summary>
            /// Enum FlowTotalExitDuration for "FLOW_TOTAL_EXIT_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_TOTAL_EXIT_DURATION")]
            FlowTotalExitDuration,
            
            /// <summary>
            /// Enum FlowMaxExitDuration for "FLOW_MAX_EXIT_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_MAX_EXIT_DURATION")]
            FlowMaxExitDuration,
            
            /// <summary>
            /// Enum FlowAvgExitDuration for "FLOW_AVG_EXIT_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_AVG_EXIT_DURATION")]
            FlowAvgExitDuration,
            
            /// <summary>
            /// Enum FlowAcdExitCount for "FLOW_ACD_EXIT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_ACD_EXIT_COUNT")]
            FlowAcdExitCount,
            
            /// <summary>
            /// Enum FlowAcdExitPercent for "FLOW_ACD_EXIT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_ACD_EXIT_PERCENT")]
            FlowAcdExitPercent,
            
            /// <summary>
            /// Enum FlowGroupExitCount for "FLOW_GROUP_EXIT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_GROUP_EXIT_COUNT")]
            FlowGroupExitCount,
            
            /// <summary>
            /// Enum FlowGroupExitPercent for "FLOW_GROUP_EXIT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_GROUP_EXIT_PERCENT")]
            FlowGroupExitPercent,
            
            /// <summary>
            /// Enum FlowNumberExitCount for "FLOW_NUMBER_EXIT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_NUMBER_EXIT_COUNT")]
            FlowNumberExitCount,
            
            /// <summary>
            /// Enum FlowNumberExitPercent for "FLOW_NUMBER_EXIT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_NUMBER_EXIT_PERCENT")]
            FlowNumberExitPercent,
            
            /// <summary>
            /// Enum FlowUserExitCount for "FLOW_USER_EXIT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_USER_EXIT_COUNT")]
            FlowUserExitCount,
            
            /// <summary>
            /// Enum FlowUserExitPercent for "FLOW_USER_EXIT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_USER_EXIT_PERCENT")]
            FlowUserExitPercent,
            
            /// <summary>
            /// Enum FlowFlowExitCount for "FLOW_FLOW_EXIT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_FLOW_EXIT_COUNT")]
            FlowFlowExitCount,
            
            /// <summary>
            /// Enum FlowFlowExitPercent for "FLOW_FLOW_EXIT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_FLOW_EXIT_PERCENT")]
            FlowFlowExitPercent,
            
            /// <summary>
            /// Enum FlowSecureFlowExitCount for "FLOW_SECURE_FLOW_EXIT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_SECURE_FLOW_EXIT_COUNT")]
            FlowSecureFlowExitCount,
            
            /// <summary>
            /// Enum FlowSecureFlowExitPercent for "FLOW_SECURE_FLOW_EXIT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_SECURE_FLOW_EXIT_PERCENT")]
            FlowSecureFlowExitPercent,
            
            /// <summary>
            /// Enum FlowAcdVoicemailExitCount for "FLOW_ACD_VOICEMAIL_EXIT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_ACD_VOICEMAIL_EXIT_COUNT")]
            FlowAcdVoicemailExitCount,
            
            /// <summary>
            /// Enum FlowAcdVoicemailExitPercent for "FLOW_ACD_VOICEMAIL_EXIT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_ACD_VOICEMAIL_EXIT_PERCENT")]
            FlowAcdVoicemailExitPercent,
            
            /// <summary>
            /// Enum FlowUserVoicemailExitCount for "FLOW_USER_VOICEMAIL_EXIT_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_USER_VOICEMAIL_EXIT_COUNT")]
            FlowUserVoicemailExitCount,
            
            /// <summary>
            /// Enum FlowUserVoicemailExitPercent for "FLOW_USER_VOICEMAIL_EXIT_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_USER_VOICEMAIL_EXIT_PERCENT")]
            FlowUserVoicemailExitPercent,
            
            /// <summary>
            /// Enum FlowOutcomeCount for "FLOW_OUTCOME_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_COUNT")]
            FlowOutcomeCount,
            
            /// <summary>
            /// Enum FlowAvgOutcomeDecimal for "FLOW_AVG_OUTCOME_DECIMAL"
            /// </summary>
            [EnumMember(Value = "FLOW_AVG_OUTCOME_DECIMAL")]
            FlowAvgOutcomeDecimal,
            
            /// <summary>
            /// Enum FlowOutcomeFailureCount for "FLOW_OUTCOME_FAILURE_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_FAILURE_COUNT")]
            FlowOutcomeFailureCount,
            
            /// <summary>
            /// Enum FlowOutcomeFailurePercent for "FLOW_OUTCOME_FAILURE_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_FAILURE_PERCENT")]
            FlowOutcomeFailurePercent,
            
            /// <summary>
            /// Enum FlowOutcomeSuccessCount for "FLOW_OUTCOME_SUCCESS_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_SUCCESS_COUNT")]
            FlowOutcomeSuccessCount,
            
            /// <summary>
            /// Enum FlowOutcomeSuccessPercent for "FLOW_OUTCOME_SUCCESS_PERCENT"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_SUCCESS_PERCENT")]
            FlowOutcomeSuccessPercent,
            
            /// <summary>
            /// Enum FlowOutcomeTotalDuration for "FLOW_OUTCOME_TOTAL_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_TOTAL_DURATION")]
            FlowOutcomeTotalDuration,
            
            /// <summary>
            /// Enum FlowOutcomeMaxDuration for "FLOW_OUTCOME_MAX_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_MAX_DURATION")]
            FlowOutcomeMaxDuration,
            
            /// <summary>
            /// Enum FlowOutcomeAvgDuration for "FLOW_OUTCOME_AVG_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_AVG_DURATION")]
            FlowOutcomeAvgDuration,
            
            /// <summary>
            /// Enum FlowOutcomeMinDuration for "FLOW_OUTCOME_MIN_DURATION"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_MIN_DURATION")]
            FlowOutcomeMinDuration,
            
            /// <summary>
            /// Enum OffQueueTime for "OFF_QUEUE_TIME"
            /// </summary>
            [EnumMember(Value = "OFF_QUEUE_TIME")]
            OffQueueTime,
            
            /// <summary>
            /// Enum OffQueuePercent for "OFF_QUEUE_PERCENT"
            /// </summary>
            [EnumMember(Value = "OFF_QUEUE_PERCENT")]
            OffQueuePercent,
            
            /// <summary>
            /// Enum AvailableTime for "AVAILABLE_TIME"
            /// </summary>
            [EnumMember(Value = "AVAILABLE_TIME")]
            AvailableTime,
            
            /// <summary>
            /// Enum AvailablePercent for "AVAILABLE_PERCENT"
            /// </summary>
            [EnumMember(Value = "AVAILABLE_PERCENT")]
            AvailablePercent,
            
            /// <summary>
            /// Enum BusyTime for "BUSY_TIME"
            /// </summary>
            [EnumMember(Value = "BUSY_TIME")]
            BusyTime,
            
            /// <summary>
            /// Enum BusyPercent for "BUSY_PERCENT"
            /// </summary>
            [EnumMember(Value = "BUSY_PERCENT")]
            BusyPercent,
            
            /// <summary>
            /// Enum AwayTime for "AWAY_TIME"
            /// </summary>
            [EnumMember(Value = "AWAY_TIME")]
            AwayTime,
            
            /// <summary>
            /// Enum AwayPercent for "AWAY_PERCENT"
            /// </summary>
            [EnumMember(Value = "AWAY_PERCENT")]
            AwayPercent,
            
            /// <summary>
            /// Enum BreakTime for "BREAK_TIME"
            /// </summary>
            [EnumMember(Value = "BREAK_TIME")]
            BreakTime,
            
            /// <summary>
            /// Enum BreakPercent for "BREAK_PERCENT"
            /// </summary>
            [EnumMember(Value = "BREAK_PERCENT")]
            BreakPercent,
            
            /// <summary>
            /// Enum MealTime for "MEAL_TIME"
            /// </summary>
            [EnumMember(Value = "MEAL_TIME")]
            MealTime,
            
            /// <summary>
            /// Enum MealPercent for "MEAL_PERCENT"
            /// </summary>
            [EnumMember(Value = "MEAL_PERCENT")]
            MealPercent,
            
            /// <summary>
            /// Enum MeetingTime for "MEETING_TIME"
            /// </summary>
            [EnumMember(Value = "MEETING_TIME")]
            MeetingTime,
            
            /// <summary>
            /// Enum MeetingPercent for "MEETING_PERCENT"
            /// </summary>
            [EnumMember(Value = "MEETING_PERCENT")]
            MeetingPercent,
            
            /// <summary>
            /// Enum TrainingTime for "TRAINING_TIME"
            /// </summary>
            [EnumMember(Value = "TRAINING_TIME")]
            TrainingTime,
            
            /// <summary>
            /// Enum TrainingPercent for "TRAINING_PERCENT"
            /// </summary>
            [EnumMember(Value = "TRAINING_PERCENT")]
            TrainingPercent,
            
            /// <summary>
            /// Enum InteractingTime for "INTERACTING_TIME"
            /// </summary>
            [EnumMember(Value = "INTERACTING_TIME")]
            InteractingTime,
            
            /// <summary>
            /// Enum InteractingPercent for "INTERACTING_PERCENT"
            /// </summary>
            [EnumMember(Value = "INTERACTING_PERCENT")]
            InteractingPercent,
            
            /// <summary>
            /// Enum CommunicatingTime for "COMMUNICATING_TIME"
            /// </summary>
            [EnumMember(Value = "COMMUNICATING_TIME")]
            CommunicatingTime,
            
            /// <summary>
            /// Enum CommunicatingPercent for "COMMUNICATING_PERCENT"
            /// </summary>
            [EnumMember(Value = "COMMUNICATING_PERCENT")]
            CommunicatingPercent,
            
            /// <summary>
            /// Enum SystemAwayTime for "SYSTEM_AWAY_TIME"
            /// </summary>
            [EnumMember(Value = "SYSTEM_AWAY_TIME")]
            SystemAwayTime,
            
            /// <summary>
            /// Enum SystemAwayPercent for "SYSTEM_AWAY_PERCENT"
            /// </summary>
            [EnumMember(Value = "SYSTEM_AWAY_PERCENT")]
            SystemAwayPercent,
            
            /// <summary>
            /// Enum OnQueueTime for "ON_QUEUE_TIME"
            /// </summary>
            [EnumMember(Value = "ON_QUEUE_TIME")]
            OnQueueTime,
            
            /// <summary>
            /// Enum OnQueuePercent for "ON_QUEUE_PERCENT"
            /// </summary>
            [EnumMember(Value = "ON_QUEUE_PERCENT")]
            OnQueuePercent,
            
            /// <summary>
            /// Enum IdleTime for "IDLE_TIME"
            /// </summary>
            [EnumMember(Value = "IDLE_TIME")]
            IdleTime,
            
            /// <summary>
            /// Enum IdlePercent for "IDLE_PERCENT"
            /// </summary>
            [EnumMember(Value = "IDLE_PERCENT")]
            IdlePercent,
            
            /// <summary>
            /// Enum NotRespondingTime for "NOT_RESPONDING_TIME"
            /// </summary>
            [EnumMember(Value = "NOT_RESPONDING_TIME")]
            NotRespondingTime,
            
            /// <summary>
            /// Enum NotRespondingPercent for "NOT_RESPONDING_PERCENT"
            /// </summary>
            [EnumMember(Value = "NOT_RESPONDING_PERCENT")]
            NotRespondingPercent,
            
            /// <summary>
            /// Enum LoggedInTime for "LOGGED_IN_TIME"
            /// </summary>
            [EnumMember(Value = "LOGGED_IN_TIME")]
            LoggedInTime,
            
            /// <summary>
            /// Enum OccupancyPercent for "OCCUPANCY_PERCENT"
            /// </summary>
            [EnumMember(Value = "OCCUPANCY_PERCENT")]
            OccupancyPercent,
            
            /// <summary>
            /// Enum MinAlertTime for "MIN_ALERT_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_ALERT_TIME")]
            MinAlertTime,
            
            /// <summary>
            /// Enum MaxAlertTime for "MAX_ALERT_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_ALERT_TIME")]
            MaxAlertTime,
            
            /// <summary>
            /// Enum MinHandleTime for "MIN_HANDLE_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_HANDLE_TIME")]
            MinHandleTime,
            
            /// <summary>
            /// Enum MaxHandleTime for "MAX_HANDLE_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_HANDLE_TIME")]
            MaxHandleTime,
            
            /// <summary>
            /// Enum MinAnsweredTime for "MIN_ANSWERED_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_ANSWERED_TIME")]
            MinAnsweredTime,
            
            /// <summary>
            /// Enum MaxAnsweredTime for "MAX_ANSWERED_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_ANSWERED_TIME")]
            MaxAnsweredTime,
            
            /// <summary>
            /// Enum MinNotRespondingTime for "MIN_NOT_RESPONDING_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_NOT_RESPONDING_TIME")]
            MinNotRespondingTime,
            
            /// <summary>
            /// Enum MaxNotRespondingTime for "MAX_NOT_RESPONDING_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_NOT_RESPONDING_TIME")]
            MaxNotRespondingTime,
            
            /// <summary>
            /// Enum MetServiceLevel for "MET_SERVICE_LEVEL"
            /// </summary>
            [EnumMember(Value = "MET_SERVICE_LEVEL")]
            MetServiceLevel,
            
            /// <summary>
            /// Enum WfmAdherenceStatus for "WFM_ADHERENCE_STATUS"
            /// </summary>
            [EnumMember(Value = "WFM_ADHERENCE_STATUS")]
            WfmAdherenceStatus,
            
            /// <summary>
            /// Enum WfmScheduledActivity for "WFM_SCHEDULED_ACTIVITY"
            /// </summary>
            [EnumMember(Value = "WFM_SCHEDULED_ACTIVITY")]
            WfmScheduledActivity,
            
            /// <summary>
            /// Enum WfmAdherenceDuration for "WFM_ADHERENCE_DURATION"
            /// </summary>
            [EnumMember(Value = "WFM_ADHERENCE_DURATION")]
            WfmAdherenceDuration,
            
            /// <summary>
            /// Enum AgentTitle for "AGENT_TITLE"
            /// </summary>
            [EnumMember(Value = "AGENT_TITLE")]
            AgentTitle,
            
            /// <summary>
            /// Enum AgentDepartment for "AGENT_DEPARTMENT"
            /// </summary>
            [EnumMember(Value = "AGENT_DEPARTMENT")]
            AgentDepartment,
            
            /// <summary>
            /// Enum AgentExtension for "AGENT_EXTENSION"
            /// </summary>
            [EnumMember(Value = "AGENT_EXTENSION")]
            AgentExtension,
            
            /// <summary>
            /// Enum AgentSkills for "AGENT_SKILLS"
            /// </summary>
            [EnumMember(Value = "AGENT_SKILLS")]
            AgentSkills,
            
            /// <summary>
            /// Enum AgentLocation for "AGENT_LOCATION"
            /// </summary>
            [EnumMember(Value = "AGENT_LOCATION")]
            AgentLocation,
            
            /// <summary>
            /// Enum AgentReportsTo for "AGENT_REPORTS_TO"
            /// </summary>
            [EnumMember(Value = "AGENT_REPORTS_TO")]
            AgentReportsTo,
            
            /// <summary>
            /// Enum AgentEmail for "AGENT_EMAIL"
            /// </summary>
            [EnumMember(Value = "AGENT_EMAIL")]
            AgentEmail,
            
            /// <summary>
            /// Enum AgentRole for "AGENT_ROLE"
            /// </summary>
            [EnumMember(Value = "AGENT_ROLE")]
            AgentRole,
            
            /// <summary>
            /// Enum AgentGroup for "AGENT_GROUP"
            /// </summary>
            [EnumMember(Value = "AGENT_GROUP")]
            AgentGroup,
            
            /// <summary>
            /// Enum AgentTimeInStatus for "AGENT_TIME_IN_STATUS"
            /// </summary>
            [EnumMember(Value = "AGENT_TIME_IN_STATUS")]
            AgentTimeInStatus,
            
            /// <summary>
            /// Enum AgentTimeInRoutingStatus for "AGENT_TIME_IN_ROUTING_STATUS"
            /// </summary>
            [EnumMember(Value = "AGENT_TIME_IN_ROUTING_STATUS")]
            AgentTimeInRoutingStatus,
            
            /// <summary>
            /// Enum AgentStatus for "AGENT_STATUS"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS")]
            AgentStatus,
            
            /// <summary>
            /// Enum AgentSecondaryStatus for "AGENT_SECONDARY_STATUS"
            /// </summary>
            [EnumMember(Value = "AGENT_SECONDARY_STATUS")]
            AgentSecondaryStatus,
            
            /// <summary>
            /// Enum AgentRoutingStatus for "AGENT_ROUTING_STATUS"
            /// </summary>
            [EnumMember(Value = "AGENT_ROUTING_STATUS")]
            AgentRoutingStatus,
            
            /// <summary>
            /// Enum AgentMediaTypes for "AGENT_MEDIA_TYPES"
            /// </summary>
            [EnumMember(Value = "AGENT_MEDIA_TYPES")]
            AgentMediaTypes,
            
            /// <summary>
            /// Enum AcwCount for "ACW_COUNT"
            /// </summary>
            [EnumMember(Value = "ACW_COUNT")]
            AcwCount,
            
            /// <summary>
            /// Enum AnswerTransferredPercent for "ANSWER_TRANSFERRED_PERCENT"
            /// </summary>
            [EnumMember(Value = "ANSWER_TRANSFERRED_PERCENT")]
            AnswerTransferredPercent,
            
            /// <summary>
            /// Enum FlowAvgMilestoneDecimal for "FLOW_AVG_MILESTONE_DECIMAL"
            /// </summary>
            [EnumMember(Value = "FLOW_AVG_MILESTONE_DECIMAL")]
            FlowAvgMilestoneDecimal,
            
            /// <summary>
            /// Enum NotRespondingCount for "NOT_RESPONDING_COUNT"
            /// </summary>
            [EnumMember(Value = "NOT_RESPONDING_COUNT")]
            NotRespondingCount,
            
            /// <summary>
            /// Enum AvgAcwHandled for "AVG_ACW_HANDLED"
            /// </summary>
            [EnumMember(Value = "AVG_ACW_HANDLED")]
            AvgAcwHandled,
            
            /// <summary>
            /// Enum AvgContactingTime for "AVG_CONTACTING_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_CONTACTING_TIME")]
            AvgContactingTime,
            
            /// <summary>
            /// Enum AvgDialingTime for "AVG_DIALING_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_DIALING_TIME")]
            AvgDialingTime,
            
            /// <summary>
            /// Enum AvgFlowoutTime for "AVG_FLOWOUT_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_FLOWOUT_TIME")]
            AvgFlowoutTime,
            
            /// <summary>
            /// Enum AvgHoldHandled for "AVG_HOLD_HANDLED"
            /// </summary>
            [EnumMember(Value = "AVG_HOLD_HANDLED")]
            AvgHoldHandled,
            
            /// <summary>
            /// Enum AvgMonitor for "AVG_MONITOR"
            /// </summary>
            [EnumMember(Value = "AVG_MONITOR")]
            AvgMonitor,
            
            /// <summary>
            /// Enum BlindTransferCount for "BLIND_TRANSFER_COUNT"
            /// </summary>
            [EnumMember(Value = "BLIND_TRANSFER_COUNT")]
            BlindTransferCount,
            
            /// <summary>
            /// Enum BlindTransferPercent for "BLIND_TRANSFER_PERCENT"
            /// </summary>
            [EnumMember(Value = "BLIND_TRANSFER_PERCENT")]
            BlindTransferPercent,
            
            /// <summary>
            /// Enum ConnectedCount for "CONNECTED_COUNT"
            /// </summary>
            [EnumMember(Value = "CONNECTED_COUNT")]
            ConnectedCount,
            
            /// <summary>
            /// Enum ConsultCount for "CONSULT_COUNT"
            /// </summary>
            [EnumMember(Value = "CONSULT_COUNT")]
            ConsultCount,
            
            /// <summary>
            /// Enum ConsultTransferCount for "CONSULT_TRANSFER_COUNT"
            /// </summary>
            [EnumMember(Value = "CONSULT_TRANSFER_COUNT")]
            ConsultTransferCount,
            
            /// <summary>
            /// Enum ConsultTransferPercent for "CONSULT_TRANSFER_PERCENT"
            /// </summary>
            [EnumMember(Value = "CONSULT_TRANSFER_PERCENT")]
            ConsultTransferPercent,
            
            /// <summary>
            /// Enum ContactingCount for "CONTACTING_COUNT"
            /// </summary>
            [EnumMember(Value = "CONTACTING_COUNT")]
            ContactingCount,
            
            /// <summary>
            /// Enum DialingCount for "DIALING_COUNT"
            /// </summary>
            [EnumMember(Value = "DIALING_COUNT")]
            DialingCount,
            
            /// <summary>
            /// Enum ErrorCount for "ERROR_COUNT"
            /// </summary>
            [EnumMember(Value = "ERROR_COUNT")]
            ErrorCount,
            
            /// <summary>
            /// Enum ExternalMediaCount for "EXTERNAL_MEDIA_COUNT"
            /// </summary>
            [EnumMember(Value = "EXTERNAL_MEDIA_COUNT")]
            ExternalMediaCount,
            
            /// <summary>
            /// Enum MaxContactingTime for "MAX_CONTACTING_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_CONTACTING_TIME")]
            MaxContactingTime,
            
            /// <summary>
            /// Enum MaxDialingTime for "MAX_DIALING_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_DIALING_TIME")]
            MaxDialingTime,
            
            /// <summary>
            /// Enum MaxFlowoutTime for "MAX_FLOWOUT_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_FLOWOUT_TIME")]
            MaxFlowoutTime,
            
            /// <summary>
            /// Enum FlowMilestoneCount for "FLOW_MILESTONE_COUNT"
            /// </summary>
            [EnumMember(Value = "FLOW_MILESTONE_COUNT")]
            FlowMilestoneCount,
            
            /// <summary>
            /// Enum MinFlowoutTime for "MIN_FLOWOUT_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_FLOWOUT_TIME")]
            MinFlowoutTime,
            
            /// <summary>
            /// Enum MaxMonitor for "MAX_MONITOR"
            /// </summary>
            [EnumMember(Value = "MAX_MONITOR")]
            MaxMonitor,
            
            /// <summary>
            /// Enum MinContactingTime for "MIN_CONTACTING_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_CONTACTING_TIME")]
            MinContactingTime,
            
            /// <summary>
            /// Enum MinDialingTime for "MIN_DIALING_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_DIALING_TIME")]
            MinDialingTime,
            
            /// <summary>
            /// Enum MinMonitor for "MIN_MONITOR"
            /// </summary>
            [EnumMember(Value = "MIN_MONITOR")]
            MinMonitor,
            
            /// <summary>
            /// Enum MonitorCount for "MONITOR_COUNT"
            /// </summary>
            [EnumMember(Value = "MONITOR_COUNT")]
            MonitorCount,
            
            /// <summary>
            /// Enum MediaCount for "MEDIA_COUNT"
            /// </summary>
            [EnumMember(Value = "MEDIA_COUNT")]
            MediaCount,
            
            /// <summary>
            /// Enum ServiceLevelTarget for "SERVICE_LEVEL_TARGET"
            /// </summary>
            [EnumMember(Value = "SERVICE_LEVEL_TARGET")]
            ServiceLevelTarget,
            
            /// <summary>
            /// Enum ServiceLevelTargetCurrent for "SERVICE_LEVEL_TARGET_CURRENT"
            /// </summary>
            [EnumMember(Value = "SERVICE_LEVEL_TARGET_CURRENT")]
            ServiceLevelTargetCurrent,
            
            /// <summary>
            /// Enum TalkCount for "TALK_COUNT"
            /// </summary>
            [EnumMember(Value = "TALK_COUNT")]
            TalkCount,
            
            /// <summary>
            /// Enum TotalAbandonTime for "TOTAL_ABANDON_TIME"
            /// </summary>
            [EnumMember(Value = "TOTAL_ABANDON_TIME")]
            TotalAbandonTime,
            
            /// <summary>
            /// Enum TotalNotRespondingTime for "TOTAL_NOT_RESPONDING_TIME"
            /// </summary>
            [EnumMember(Value = "TOTAL_NOT_RESPONDING_TIME")]
            TotalNotRespondingTime,
            
            /// <summary>
            /// Enum TotalContacting for "TOTAL_CONTACTING"
            /// </summary>
            [EnumMember(Value = "TOTAL_CONTACTING")]
            TotalContacting,
            
            /// <summary>
            /// Enum TotalDialing for "TOTAL_DIALING"
            /// </summary>
            [EnumMember(Value = "TOTAL_DIALING")]
            TotalDialing,
            
            /// <summary>
            /// Enum TotalMonitor for "TOTAL_MONITOR"
            /// </summary>
            [EnumMember(Value = "TOTAL_MONITOR")]
            TotalMonitor,
            
            /// <summary>
            /// Enum TotalWaitTime for "TOTAL_WAIT_TIME"
            /// </summary>
            [EnumMember(Value = "TOTAL_WAIT_TIME")]
            TotalWaitTime,
            
            /// <summary>
            /// Enum WaitCount for "WAIT_COUNT"
            /// </summary>
            [EnumMember(Value = "WAIT_COUNT")]
            WaitCount,
            
            /// <summary>
            /// Enum ParkCount for "PARK_COUNT"
            /// </summary>
            [EnumMember(Value = "PARK_COUNT")]
            ParkCount,
            
            /// <summary>
            /// Enum AvgParkTime for "AVG_PARK_TIME"
            /// </summary>
            [EnumMember(Value = "AVG_PARK_TIME")]
            AvgParkTime,
            
            /// <summary>
            /// Enum TotalParkTime for "TOTAL_PARK_TIME"
            /// </summary>
            [EnumMember(Value = "TOTAL_PARK_TIME")]
            TotalParkTime,
            
            /// <summary>
            /// Enum MinParkTime for "MIN_PARK_TIME"
            /// </summary>
            [EnumMember(Value = "MIN_PARK_TIME")]
            MinParkTime,
            
            /// <summary>
            /// Enum MaxParkTime for "MAX_PARK_TIME"
            /// </summary>
            [EnumMember(Value = "MAX_PARK_TIME")]
            MaxParkTime
        }
        /// <summary>
        /// Filter to indicate the availability of the dashboard is public or private.
        /// </summary>
        /// <value>Filter to indicate the availability of the dashboard is public or private.</value>
        [DataMember(Name="availableDashboard", EmitDefaultValue=false)]
        public AvailableDashboardEnum? AvailableDashboard { get; set; }
        /// <summary>
        /// The user supplied state value in the view
        /// </summary>
        /// <value>The user supplied state value in the view</value>
        [DataMember(Name="userState", EmitDefaultValue=false)]
        public UserStateEnum? UserState { get; set; }
        /// <summary>
        /// The state of dashboard being filtered
        /// </summary>
        /// <value>The state of dashboard being filtered</value>
        [DataMember(Name="dashboardState", EmitDefaultValue=false)]
        public DashboardStateEnum? DashboardState { get; set; }
        /// <summary>
        /// The type of dashboard being filtered
        /// </summary>
        /// <value>The type of dashboard being filtered</value>
        [DataMember(Name="dashboardType", EmitDefaultValue=false)]
        public DashboardTypeEnum? DashboardType { get; set; }
        /// <summary>
        /// The type of dashboard access being filtered
        /// </summary>
        /// <value>The type of dashboard access being filtered</value>
        [DataMember(Name="dashboardAccessFilter", EmitDefaultValue=false)]
        public DashboardAccessFilterEnum? DashboardAccessFilter { get; set; }
        /// <summary>
        /// Sets the role when viewing agent evaluations
        /// </summary>
        /// <value>Sets the role when viewing agent evaluations</value>
        [DataMember(Name="evaluationRole", EmitDefaultValue=false)]
        public EvaluationRoleEnum? EvaluationRole { get; set; }
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
        /// <param name="ManagementUnitIds">The management unit ids are used to filter the view.</param>
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
        /// <param name="CallbackNumberList">A list of callback numbers or substrings of numbers (ex: [\"317\", \"13172222222\"]).</param>
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
        /// <param name="IsRecorded">Indicates filtering for recorded.</param>
        /// <param name="HasEvaluation">Indicates filtering for evaluation.</param>
        /// <param name="HasScoredEvaluation">Indicates filtering for scored evaluation.</param>
        /// <param name="EmailDeliveryStatusList">The list of email delivery statuses used to filter views.</param>
        /// <param name="IsAgentOwnedCallback">Indicates filtering for agent owned callback interactions.</param>
        /// <param name="AgentCallbackOwnerIds">The list of callback owners used to filter interactions.</param>
        /// <param name="TranscriptTopics">The list of transcript topics requested in filter.</param>
        /// <param name="JourneyFrequencyCapReasons">The list of frequency cap reasons to filter offer constraints.</param>
        /// <param name="JourneyBlockingActionMapIds">The list of blocking action maps to filter offer constraints.</param>
        /// <param name="JourneyActionTargetIds">The list of action targets to filter offer constraints.</param>
        /// <param name="JourneyBlockingScheduleGroupIds">The list of blocking schedule groups to filter offer constraints.</param>
        /// <param name="JourneyBlockingEmergencyScheduleGroupIds">The list of emergency schedule groups to filter offer constraints.</param>
        /// <param name="JourneyUrlEqualConditions">The list of url equal conditions to filter offer constraints.</param>
        /// <param name="JourneyUrlNotEqualConditions">The list of url not equal conditions to filter offer constraints.</param>
        /// <param name="JourneyUrlStartsWithConditions">The list of url starts with conditions to filter offer constraints.</param>
        /// <param name="JourneyUrlEndsWithConditions">The list of url ends with conditions to filter offer constraints.</param>
        /// <param name="JourneyUrlContainsAnyConditions">The list of url contains any conditions to filter offer constraints.</param>
        /// <param name="JourneyUrlNotContainsAnyConditions">The list of url not contains any conditions to filter offer constraints.</param>
        /// <param name="JourneyUrlContainsAllConditions">The list of url contains all conditions to filter offer constraints.</param>
        /// <param name="JourneyUrlNotContainsAllConditions">The list of url not contains all conditions to filter offer constraints.</param>
        /// <param name="FlowMilestoneIds">The list of flow milestones to filter exports.</param>
        /// <param name="IsAssessmentPassed">Filter to indicate if Agent passed assessment or not.</param>
        /// <param name="ConversationInitiators">The list to filter based on Brands (Bot/User/Agent) or End User who initiated the first message in the conversation.</param>
        /// <param name="HasCustomerParticipated">Indicates if the customer has participated in an initiated conversation.</param>
        /// <param name="IsAcdInteraction">Filter to indicate if interaction was ACD or non-ACD.</param>
        /// <param name="HasFax">Filters to indicate if interaction has FAX.</param>
        /// <param name="DataActionIds">The list of Data Action IDs .</param>
        /// <param name="ActionCategoryName">Deprecated - Please use integrationIds instead.</param>
        /// <param name="IntegrationIds">The list of integration IDs for Data Action.</param>
        /// <param name="ResponseStatuses">The list of Response codes for Data Action.</param>
        /// <param name="AvailableDashboard">Filter to indicate the availability of the dashboard is public or private..</param>
        /// <param name="FavouriteDashboard">Filter to indicate whether the dashboard is favorite or unfavorite..</param>
        /// <param name="MyDashboard">Filter to indicate the dashboard owned by the user..</param>
        /// <param name="StationErrors">The list of agent errors that are related to station.</param>
        /// <param name="CanonicalContactIds">The canonical contact ids are used to filter the view.</param>
        /// <param name="AlertRuleIds">The list of Alert Rule IDs.</param>
        /// <param name="EvaluationFormContextIds">The list of Evaluation Form Context IDs.</param>
        /// <param name="EvaluationStatuses">The evaluation statuses that are used to filter the view.</param>
        /// <param name="WorkbinIds">The list of Workbin IDs.</param>
        /// <param name="WorktypeIds">The list of Worktype IDs.</param>
        /// <param name="WorkitemIds">The list of Workitem IDs.</param>
        /// <param name="WorkitemAssigneeIds">The list of Workitem Assignee IDs.</param>
        /// <param name="WorkitemStatuses">The list of Workitem Statuses IDs.</param>
        /// <param name="IsAnalyzedForSensitiveData">Deprecated - Use hasPciData or hasPiiData instead..</param>
        /// <param name="HasSensitiveData">Deprecated. Use hasPciData or hasPiiData instead..</param>
        /// <param name="HasPciData">Filter to indicate the transcript contains Pci data..</param>
        /// <param name="HasPiiData">Filter to indicate the transcript contains Pii data..</param>
        /// <param name="SubPath">Filter for Sub Path.</param>
        /// <param name="UserState">The user supplied state value in the view.</param>
        /// <param name="IsClearedByCustomer">Filter to indicate if the customer cleared the conversation..</param>
        /// <param name="EvaluationAssigneeIds">The evaluation assignee ids that are used to filter the view..</param>
        /// <param name="EvaluationAssigned">Filter to indicate that the user has no assigned evaluation..</param>
        /// <param name="AssistantIds">The assistant ids that are used to filter the view..</param>
        /// <param name="KnowledgeBaseIds">The knowledge base ids that are used to filter the view..</param>
        /// <param name="IsParked">Filter to indicate if the interactions are parked..</param>
        /// <param name="AgentEmpathyScore">The agentEmpathyScore is used to filter the view.</param>
        /// <param name="SurveyTypes">The surveyTypes is used to filter the view.</param>
        /// <param name="SurveyResponseStatuses">The list of Survey Response Status.</param>
        /// <param name="BotFlowTypes">The botFlowTypes is used to filter the view.</param>
        /// <param name="AgentTalkDurationMilliseconds">The agent talk durations in milliseconds used to filter the view.</param>
        /// <param name="CustomerTalkDurationMilliseconds">The customer talk durations in milliseconds used to filter the view.</param>
        /// <param name="OvertalkDurationMilliseconds">The overtalk durations in milliseconds used to filter the view.</param>
        /// <param name="SilenceDurationMilliseconds">The silence durations in milliseconds used to filter the view.</param>
        /// <param name="AcdDurationMilliseconds">The acd durations in milliseconds used to filter the view.</param>
        /// <param name="IvrDurationMilliseconds">The ivr durations in milliseconds used to filter the view.</param>
        /// <param name="OtherDurationMilliseconds">The other (hold/music) durations in milliseconds used to filter the view.</param>
        /// <param name="AgentTalkPercentage">The agent talk percentage used to filter the view.</param>
        /// <param name="CustomerTalkPercentage">The customer talk percentage used to filter the view.</param>
        /// <param name="OvertalkPercentage">The overtalk percentage used to filter the view.</param>
        /// <param name="SilencePercentage">The silence percentage used to filter the view.</param>
        /// <param name="AcdPercentage">The acd percentage used to filter the view.</param>
        /// <param name="IvrPercentage">The ivr percentage used to filter the view.</param>
        /// <param name="OtherPercentage">The other (hold/music percentage used to filter the view.</param>
        /// <param name="OvertalkInstances">The overtalk instance range used to filter the view.</param>
        /// <param name="IsScreenRecorded">Filter to indicate if the screen is recorded.</param>
        /// <param name="ScreenMonitorUserIds">The list of Screen Monitor User Ids.</param>
        /// <param name="DashboardState">The state of dashboard being filtered.</param>
        /// <param name="DashboardType">The type of dashboard being filtered.</param>
        /// <param name="DashboardAccessFilter">The type of dashboard access being filtered.</param>
        /// <param name="TranscriptDurationMilliseconds">The transcript durations in milliseconds used to filter the view.</param>
        /// <param name="WorkitemsStatuses">The list of workitem status with worktype.</param>
        /// <param name="SocialCountries">List of countries for social filtering.</param>
        /// <param name="SocialLanguages">List of languages for social filtering.</param>
        /// <param name="SocialChannels">List of channels for social filtering.</param>
        /// <param name="SocialSentimentCategory">The sentiment of the social post.</param>
        /// <param name="SocialTopicIds">The list of topicIds for social filtering.</param>
        /// <param name="SocialIngestionRuleIds">The list of ingestion ruleIds for social filtering.</param>
        /// <param name="SocialConversationCreated">Filter to indicate if the post has created a conversation.</param>
        /// <param name="SocialContentType">The list of content Type for social filtering.</param>
        /// <param name="SocialKeywords">The list of keywords for social filtering.</param>
        /// <param name="SocialPostEscalated">Filter to indicate if the post is escalated.</param>
        /// <param name="SocialClassifications">Indicates if a social message was public or private.</param>
        /// <param name="FilterUsersByManagerIds">The manager ids used to fetch associated users for the view.</param>
        /// <param name="SlideshowIds">List of Dashboard slideshowIds to be filtered.</param>
        /// <param name="Conferenced">Filter to indicate if the conversation has conference.</param>
        /// <param name="Video">Filter to indicate if the conversation has video.</param>
        /// <param name="LinkedInteraction">Filter to indicate if the conversation has linked interaction.</param>
        /// <param name="RecommendationSources">List of recommendation sources for filtering recommendation details pane.</param>
        /// <param name="EvaluationRole">Sets the role when viewing agent evaluations.</param>
        /// <param name="ComparisonQueueIds">The queue ids are used to for comparison to the primary queue filter in reporting.</param>
        /// <param name="ViewMetrics">A list of metrics selected for the view.</param>
        /// <param name="TimelineCategories">A list of timeline categories.</param>
        public ViewFilter(List<MediaTypesEnum> MediaTypes = null, List<string> QueueIds = null, List<string> SkillIds = null, List<string> SkillGroups = null, List<string> LanguageIds = null, List<string> LanguageGroups = null, List<DirectionsEnum> Directions = null, List<OriginatingDirectionsEnum> OriginatingDirections = null, List<string> WrapUpCodes = null, List<string> DnisList = null, List<string> SessionDnisList = null, List<string> FilterQueuesByUserIds = null, List<string> FilterUsersByQueueIds = null, List<string> UserIds = null, List<string> ManagementUnitIds = null, List<string> AddressTos = null, List<string> AddressFroms = null, List<string> OutboundCampaignIds = null, List<string> OutboundContactListIds = null, List<string> ContactIds = null, List<string> ExternalContactIds = null, List<string> ExternalOrgIds = null, List<string> AniList = null, List<NumericRange> DurationsMilliseconds = null, List<NumericRange> AcdDurationsMilliseconds = null, List<NumericRange> TalkDurationsMilliseconds = null, List<NumericRange> AcwDurationsMilliseconds = null, List<NumericRange> HandleDurationsMilliseconds = null, List<NumericRange> HoldDurationsMilliseconds = null, List<NumericRange> AbandonDurationsMilliseconds = null, NumericRange EvaluationScore = null, NumericRange EvaluationCriticalScore = null, List<string> EvaluationFormIds = null, List<string> EvaluatedAgentIds = null, List<string> EvaluatorIds = null, bool? Transferred = null, bool? Abandoned = null, bool? Answered = null, List<MessageTypesEnum> MessageTypes = null, List<string> DivisionIds = null, List<string> SurveyFormIds = null, NumericRange SurveyTotalScore = null, NumericRange SurveyNpsScore = null, NumericRange Mos = null, NumericRange SurveyQuestionGroupScore = null, NumericRange SurveyPromoterScore = null, List<string> SurveyFormContextIds = null, List<string> ConversationIds = null, List<string> SipCallIds = null, bool? IsEnded = null, bool? IsSurveyed = null, List<NumericRange> SurveyScores = null, List<NumericRange> PromoterScores = null, bool? IsCampaign = null, List<string> SurveyStatuses = null, ConversationProperties ConversationProperties = null, bool? IsBlindTransferred = null, bool? IsConsulted = null, bool? IsConsultTransferred = null, List<string> RemoteParticipants = null, List<string> FlowIds = null, List<string> FlowOutcomeIds = null, List<FlowOutcomeValuesEnum> FlowOutcomeValues = null, List<FlowDestinationTypesEnum> FlowDestinationTypes = null, List<FlowDisconnectReasonsEnum> FlowDisconnectReasons = null, List<FlowTypesEnum> FlowTypes = null, List<FlowEntryTypesEnum> FlowEntryTypes = null, List<string> FlowEntryReasons = null, List<string> FlowVersions = null, List<string> GroupIds = null, bool? HasJourneyCustomerId = null, bool? HasJourneyActionMapId = null, bool? HasJourneyVisitId = null, bool? HasMedia = null, List<string> RoleIds = null, List<string> ReportsTos = null, List<string> LocationIds = null, List<string> FlowOutTypes = null, List<string> ProviderList = null, List<string> CallbackNumberList = null, string CallbackInterval = null, List<UsedRoutingTypesEnum> UsedRoutingTypes = null, List<RequestedRoutingTypesEnum> RequestedRoutingTypes = null, bool? HasAgentAssistId = null, List<Transcripts> Transcripts = null, List<string> TranscriptLanguages = null, List<ParticipantPurposesEnum> ParticipantPurposes = null, bool? ShowFirstQueue = null, List<string> TeamIds = null, List<string> FilterUsersByTeamIds = null, List<string> JourneyActionMapIds = null, List<string> JourneyOutcomeIds = null, List<string> JourneySegmentIds = null, List<JourneyActionMapTypesEnum> JourneyActionMapTypes = null, List<DevelopmentRoleListEnum> DevelopmentRoleList = null, List<DevelopmentTypeListEnum> DevelopmentTypeList = null, List<DevelopmentStatusListEnum> DevelopmentStatusList = null, List<string> DevelopmentModuleIds = null, bool? DevelopmentActivityOverdue = null, NumericRange CustomerSentimentScore = null, NumericRange CustomerSentimentTrend = null, List<string> FlowTransferTargets = null, string DevelopmentName = null, List<string> TopicIds = null, List<string> ExternalTags = null, bool? IsNotResponding = null, bool? IsAuthenticated = null, List<string> BotIds = null, List<string> BotVersions = null, List<BotMessageTypesEnum> BotMessageTypes = null, List<BotProviderListEnum> BotProviderList = null, List<BotProductListEnum> BotProductList = null, List<BotRecognitionFailureReasonListEnum> BotRecognitionFailureReasonList = null, List<string> BotIntentList = null, List<string> BotFinalIntentList = null, List<string> BotSlotList = null, List<BotResultListEnum> BotResultList = null, List<BlockedReasonsEnum> BlockedReasons = null, bool? IsRecorded = null, bool? HasEvaluation = null, bool? HasScoredEvaluation = null, List<EmailDeliveryStatusListEnum> EmailDeliveryStatusList = null, bool? IsAgentOwnedCallback = null, List<string> AgentCallbackOwnerIds = null, List<TranscriptTopics> TranscriptTopics = null, List<string> JourneyFrequencyCapReasons = null, List<string> JourneyBlockingActionMapIds = null, List<string> JourneyActionTargetIds = null, List<string> JourneyBlockingScheduleGroupIds = null, List<string> JourneyBlockingEmergencyScheduleGroupIds = null, List<string> JourneyUrlEqualConditions = null, List<string> JourneyUrlNotEqualConditions = null, List<string> JourneyUrlStartsWithConditions = null, List<string> JourneyUrlEndsWithConditions = null, List<string> JourneyUrlContainsAnyConditions = null, List<string> JourneyUrlNotContainsAnyConditions = null, List<string> JourneyUrlContainsAllConditions = null, List<string> JourneyUrlNotContainsAllConditions = null, List<string> FlowMilestoneIds = null, bool? IsAssessmentPassed = null, List<string> ConversationInitiators = null, bool? HasCustomerParticipated = null, bool? IsAcdInteraction = null, bool? HasFax = null, List<string> DataActionIds = null, string ActionCategoryName = null, List<string> IntegrationIds = null, List<string> ResponseStatuses = null, AvailableDashboardEnum? AvailableDashboard = null, bool? FavouriteDashboard = null, bool? MyDashboard = null, List<string> StationErrors = null, List<string> CanonicalContactIds = null, List<string> AlertRuleIds = null, List<string> EvaluationFormContextIds = null, List<EvaluationStatusesEnum> EvaluationStatuses = null, List<string> WorkbinIds = null, List<string> WorktypeIds = null, List<string> WorkitemIds = null, List<string> WorkitemAssigneeIds = null, List<string> WorkitemStatuses = null, bool? IsAnalyzedForSensitiveData = null, bool? HasSensitiveData = null, bool? HasPciData = null, bool? HasPiiData = null, string SubPath = null, UserStateEnum? UserState = null, bool? IsClearedByCustomer = null, List<string> EvaluationAssigneeIds = null, bool? EvaluationAssigned = null, List<string> AssistantIds = null, List<string> KnowledgeBaseIds = null, bool? IsParked = null, NumericRange AgentEmpathyScore = null, List<SurveyTypesEnum> SurveyTypes = null, List<SurveyResponseStatusesEnum> SurveyResponseStatuses = null, List<BotFlowTypesEnum> BotFlowTypes = null, List<NumericRange> AgentTalkDurationMilliseconds = null, List<NumericRange> CustomerTalkDurationMilliseconds = null, List<NumericRange> OvertalkDurationMilliseconds = null, List<NumericRange> SilenceDurationMilliseconds = null, List<NumericRange> AcdDurationMilliseconds = null, List<NumericRange> IvrDurationMilliseconds = null, List<NumericRange> OtherDurationMilliseconds = null, NumericRange AgentTalkPercentage = null, NumericRange CustomerTalkPercentage = null, NumericRange OvertalkPercentage = null, NumericRange SilencePercentage = null, NumericRange AcdPercentage = null, NumericRange IvrPercentage = null, NumericRange OtherPercentage = null, NumericRange OvertalkInstances = null, bool? IsScreenRecorded = null, List<string> ScreenMonitorUserIds = null, DashboardStateEnum? DashboardState = null, DashboardTypeEnum? DashboardType = null, DashboardAccessFilterEnum? DashboardAccessFilter = null, List<NumericRange> TranscriptDurationMilliseconds = null, List<WorkitemStatusFilter> WorkitemsStatuses = null, List<string> SocialCountries = null, List<string> SocialLanguages = null, List<SocialChannelsEnum> SocialChannels = null, List<SocialSentimentCategoryEnum> SocialSentimentCategory = null, List<string> SocialTopicIds = null, List<string> SocialIngestionRuleIds = null, bool? SocialConversationCreated = null, List<SocialContentTypeEnum> SocialContentType = null, List<SocialKeyword> SocialKeywords = null, bool? SocialPostEscalated = null, List<SocialClassificationsEnum> SocialClassifications = null, List<string> FilterUsersByManagerIds = null, List<string> SlideshowIds = null, bool? Conferenced = null, bool? Video = null, bool? LinkedInteraction = null, List<RecommendationSourcesEnum> RecommendationSources = null, EvaluationRoleEnum? EvaluationRole = null, List<string> ComparisonQueueIds = null, List<ViewMetricsEnum> ViewMetrics = null, List<string> TimelineCategories = null)
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
            this.ManagementUnitIds = ManagementUnitIds;
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
            this.IsRecorded = IsRecorded;
            this.HasEvaluation = HasEvaluation;
            this.HasScoredEvaluation = HasScoredEvaluation;
            this.EmailDeliveryStatusList = EmailDeliveryStatusList;
            this.IsAgentOwnedCallback = IsAgentOwnedCallback;
            this.AgentCallbackOwnerIds = AgentCallbackOwnerIds;
            this.TranscriptTopics = TranscriptTopics;
            this.JourneyFrequencyCapReasons = JourneyFrequencyCapReasons;
            this.JourneyBlockingActionMapIds = JourneyBlockingActionMapIds;
            this.JourneyActionTargetIds = JourneyActionTargetIds;
            this.JourneyBlockingScheduleGroupIds = JourneyBlockingScheduleGroupIds;
            this.JourneyBlockingEmergencyScheduleGroupIds = JourneyBlockingEmergencyScheduleGroupIds;
            this.JourneyUrlEqualConditions = JourneyUrlEqualConditions;
            this.JourneyUrlNotEqualConditions = JourneyUrlNotEqualConditions;
            this.JourneyUrlStartsWithConditions = JourneyUrlStartsWithConditions;
            this.JourneyUrlEndsWithConditions = JourneyUrlEndsWithConditions;
            this.JourneyUrlContainsAnyConditions = JourneyUrlContainsAnyConditions;
            this.JourneyUrlNotContainsAnyConditions = JourneyUrlNotContainsAnyConditions;
            this.JourneyUrlContainsAllConditions = JourneyUrlContainsAllConditions;
            this.JourneyUrlNotContainsAllConditions = JourneyUrlNotContainsAllConditions;
            this.FlowMilestoneIds = FlowMilestoneIds;
            this.IsAssessmentPassed = IsAssessmentPassed;
            this.ConversationInitiators = ConversationInitiators;
            this.HasCustomerParticipated = HasCustomerParticipated;
            this.IsAcdInteraction = IsAcdInteraction;
            this.HasFax = HasFax;
            this.DataActionIds = DataActionIds;
            this.ActionCategoryName = ActionCategoryName;
            this.IntegrationIds = IntegrationIds;
            this.ResponseStatuses = ResponseStatuses;
            this.AvailableDashboard = AvailableDashboard;
            this.FavouriteDashboard = FavouriteDashboard;
            this.MyDashboard = MyDashboard;
            this.StationErrors = StationErrors;
            this.CanonicalContactIds = CanonicalContactIds;
            this.AlertRuleIds = AlertRuleIds;
            this.EvaluationFormContextIds = EvaluationFormContextIds;
            this.EvaluationStatuses = EvaluationStatuses;
            this.WorkbinIds = WorkbinIds;
            this.WorktypeIds = WorktypeIds;
            this.WorkitemIds = WorkitemIds;
            this.WorkitemAssigneeIds = WorkitemAssigneeIds;
            this.WorkitemStatuses = WorkitemStatuses;
            this.IsAnalyzedForSensitiveData = IsAnalyzedForSensitiveData;
            this.HasSensitiveData = HasSensitiveData;
            this.HasPciData = HasPciData;
            this.HasPiiData = HasPiiData;
            this.SubPath = SubPath;
            this.UserState = UserState;
            this.IsClearedByCustomer = IsClearedByCustomer;
            this.EvaluationAssigneeIds = EvaluationAssigneeIds;
            this.EvaluationAssigned = EvaluationAssigned;
            this.AssistantIds = AssistantIds;
            this.KnowledgeBaseIds = KnowledgeBaseIds;
            this.IsParked = IsParked;
            this.AgentEmpathyScore = AgentEmpathyScore;
            this.SurveyTypes = SurveyTypes;
            this.SurveyResponseStatuses = SurveyResponseStatuses;
            this.BotFlowTypes = BotFlowTypes;
            this.AgentTalkDurationMilliseconds = AgentTalkDurationMilliseconds;
            this.CustomerTalkDurationMilliseconds = CustomerTalkDurationMilliseconds;
            this.OvertalkDurationMilliseconds = OvertalkDurationMilliseconds;
            this.SilenceDurationMilliseconds = SilenceDurationMilliseconds;
            this.AcdDurationMilliseconds = AcdDurationMilliseconds;
            this.IvrDurationMilliseconds = IvrDurationMilliseconds;
            this.OtherDurationMilliseconds = OtherDurationMilliseconds;
            this.AgentTalkPercentage = AgentTalkPercentage;
            this.CustomerTalkPercentage = CustomerTalkPercentage;
            this.OvertalkPercentage = OvertalkPercentage;
            this.SilencePercentage = SilencePercentage;
            this.AcdPercentage = AcdPercentage;
            this.IvrPercentage = IvrPercentage;
            this.OtherPercentage = OtherPercentage;
            this.OvertalkInstances = OvertalkInstances;
            this.IsScreenRecorded = IsScreenRecorded;
            this.ScreenMonitorUserIds = ScreenMonitorUserIds;
            this.DashboardState = DashboardState;
            this.DashboardType = DashboardType;
            this.DashboardAccessFilter = DashboardAccessFilter;
            this.TranscriptDurationMilliseconds = TranscriptDurationMilliseconds;
            this.WorkitemsStatuses = WorkitemsStatuses;
            this.SocialCountries = SocialCountries;
            this.SocialLanguages = SocialLanguages;
            this.SocialChannels = SocialChannels;
            this.SocialSentimentCategory = SocialSentimentCategory;
            this.SocialTopicIds = SocialTopicIds;
            this.SocialIngestionRuleIds = SocialIngestionRuleIds;
            this.SocialConversationCreated = SocialConversationCreated;
            this.SocialContentType = SocialContentType;
            this.SocialKeywords = SocialKeywords;
            this.SocialPostEscalated = SocialPostEscalated;
            this.SocialClassifications = SocialClassifications;
            this.FilterUsersByManagerIds = FilterUsersByManagerIds;
            this.SlideshowIds = SlideshowIds;
            this.Conferenced = Conferenced;
            this.Video = Video;
            this.LinkedInteraction = LinkedInteraction;
            this.RecommendationSources = RecommendationSources;
            this.EvaluationRole = EvaluationRole;
            this.ComparisonQueueIds = ComparisonQueueIds;
            this.ViewMetrics = ViewMetrics;
            this.TimelineCategories = TimelineCategories;
            
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
        /// The management unit ids are used to filter the view
        /// </summary>
        /// <value>The management unit ids are used to filter the view</value>
        [DataMember(Name="managementUnitIds", EmitDefaultValue=false)]
        public List<string> ManagementUnitIds { get; set; }



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
        /// A list of callback numbers or substrings of numbers (ex: [\"317\", \"13172222222\"])
        /// </summary>
        /// <value>A list of callback numbers or substrings of numbers (ex: [\"317\", \"13172222222\"])</value>
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
        /// Indicates filtering for recorded
        /// </summary>
        /// <value>Indicates filtering for recorded</value>
        [DataMember(Name="isRecorded", EmitDefaultValue=false)]
        public bool? IsRecorded { get; set; }



        /// <summary>
        /// Indicates filtering for evaluation
        /// </summary>
        /// <value>Indicates filtering for evaluation</value>
        [DataMember(Name="hasEvaluation", EmitDefaultValue=false)]
        public bool? HasEvaluation { get; set; }



        /// <summary>
        /// Indicates filtering for scored evaluation
        /// </summary>
        /// <value>Indicates filtering for scored evaluation</value>
        [DataMember(Name="hasScoredEvaluation", EmitDefaultValue=false)]
        public bool? HasScoredEvaluation { get; set; }



        /// <summary>
        /// The list of email delivery statuses used to filter views
        /// </summary>
        /// <value>The list of email delivery statuses used to filter views</value>
        [DataMember(Name="emailDeliveryStatusList", EmitDefaultValue=false)]
        public List<EmailDeliveryStatusListEnum> EmailDeliveryStatusList { get; set; }



        /// <summary>
        /// Indicates filtering for agent owned callback interactions
        /// </summary>
        /// <value>Indicates filtering for agent owned callback interactions</value>
        [DataMember(Name="isAgentOwnedCallback", EmitDefaultValue=false)]
        public bool? IsAgentOwnedCallback { get; set; }



        /// <summary>
        /// The list of callback owners used to filter interactions
        /// </summary>
        /// <value>The list of callback owners used to filter interactions</value>
        [DataMember(Name="agentCallbackOwnerIds", EmitDefaultValue=false)]
        public List<string> AgentCallbackOwnerIds { get; set; }



        /// <summary>
        /// The list of transcript topics requested in filter
        /// </summary>
        /// <value>The list of transcript topics requested in filter</value>
        [DataMember(Name="transcriptTopics", EmitDefaultValue=false)]
        public List<TranscriptTopics> TranscriptTopics { get; set; }



        /// <summary>
        /// The list of frequency cap reasons to filter offer constraints
        /// </summary>
        /// <value>The list of frequency cap reasons to filter offer constraints</value>
        [DataMember(Name="journeyFrequencyCapReasons", EmitDefaultValue=false)]
        public List<string> JourneyFrequencyCapReasons { get; set; }



        /// <summary>
        /// The list of blocking action maps to filter offer constraints
        /// </summary>
        /// <value>The list of blocking action maps to filter offer constraints</value>
        [DataMember(Name="journeyBlockingActionMapIds", EmitDefaultValue=false)]
        public List<string> JourneyBlockingActionMapIds { get; set; }



        /// <summary>
        /// The list of action targets to filter offer constraints
        /// </summary>
        /// <value>The list of action targets to filter offer constraints</value>
        [DataMember(Name="journeyActionTargetIds", EmitDefaultValue=false)]
        public List<string> JourneyActionTargetIds { get; set; }



        /// <summary>
        /// The list of blocking schedule groups to filter offer constraints
        /// </summary>
        /// <value>The list of blocking schedule groups to filter offer constraints</value>
        [DataMember(Name="journeyBlockingScheduleGroupIds", EmitDefaultValue=false)]
        public List<string> JourneyBlockingScheduleGroupIds { get; set; }



        /// <summary>
        /// The list of emergency schedule groups to filter offer constraints
        /// </summary>
        /// <value>The list of emergency schedule groups to filter offer constraints</value>
        [DataMember(Name="journeyBlockingEmergencyScheduleGroupIds", EmitDefaultValue=false)]
        public List<string> JourneyBlockingEmergencyScheduleGroupIds { get; set; }



        /// <summary>
        /// The list of url equal conditions to filter offer constraints
        /// </summary>
        /// <value>The list of url equal conditions to filter offer constraints</value>
        [DataMember(Name="journeyUrlEqualConditions", EmitDefaultValue=false)]
        public List<string> JourneyUrlEqualConditions { get; set; }



        /// <summary>
        /// The list of url not equal conditions to filter offer constraints
        /// </summary>
        /// <value>The list of url not equal conditions to filter offer constraints</value>
        [DataMember(Name="journeyUrlNotEqualConditions", EmitDefaultValue=false)]
        public List<string> JourneyUrlNotEqualConditions { get; set; }



        /// <summary>
        /// The list of url starts with conditions to filter offer constraints
        /// </summary>
        /// <value>The list of url starts with conditions to filter offer constraints</value>
        [DataMember(Name="journeyUrlStartsWithConditions", EmitDefaultValue=false)]
        public List<string> JourneyUrlStartsWithConditions { get; set; }



        /// <summary>
        /// The list of url ends with conditions to filter offer constraints
        /// </summary>
        /// <value>The list of url ends with conditions to filter offer constraints</value>
        [DataMember(Name="journeyUrlEndsWithConditions", EmitDefaultValue=false)]
        public List<string> JourneyUrlEndsWithConditions { get; set; }



        /// <summary>
        /// The list of url contains any conditions to filter offer constraints
        /// </summary>
        /// <value>The list of url contains any conditions to filter offer constraints</value>
        [DataMember(Name="journeyUrlContainsAnyConditions", EmitDefaultValue=false)]
        public List<string> JourneyUrlContainsAnyConditions { get; set; }



        /// <summary>
        /// The list of url not contains any conditions to filter offer constraints
        /// </summary>
        /// <value>The list of url not contains any conditions to filter offer constraints</value>
        [DataMember(Name="journeyUrlNotContainsAnyConditions", EmitDefaultValue=false)]
        public List<string> JourneyUrlNotContainsAnyConditions { get; set; }



        /// <summary>
        /// The list of url contains all conditions to filter offer constraints
        /// </summary>
        /// <value>The list of url contains all conditions to filter offer constraints</value>
        [DataMember(Name="journeyUrlContainsAllConditions", EmitDefaultValue=false)]
        public List<string> JourneyUrlContainsAllConditions { get; set; }



        /// <summary>
        /// The list of url not contains all conditions to filter offer constraints
        /// </summary>
        /// <value>The list of url not contains all conditions to filter offer constraints</value>
        [DataMember(Name="journeyUrlNotContainsAllConditions", EmitDefaultValue=false)]
        public List<string> JourneyUrlNotContainsAllConditions { get; set; }



        /// <summary>
        /// The list of flow milestones to filter exports
        /// </summary>
        /// <value>The list of flow milestones to filter exports</value>
        [DataMember(Name="flowMilestoneIds", EmitDefaultValue=false)]
        public List<string> FlowMilestoneIds { get; set; }



        /// <summary>
        /// Filter to indicate if Agent passed assessment or not
        /// </summary>
        /// <value>Filter to indicate if Agent passed assessment or not</value>
        [DataMember(Name="isAssessmentPassed", EmitDefaultValue=false)]
        public bool? IsAssessmentPassed { get; set; }



        /// <summary>
        /// The list to filter based on Brands (Bot/User/Agent) or End User who initiated the first message in the conversation
        /// </summary>
        /// <value>The list to filter based on Brands (Bot/User/Agent) or End User who initiated the first message in the conversation</value>
        [DataMember(Name="conversationInitiators", EmitDefaultValue=false)]
        public List<string> ConversationInitiators { get; set; }



        /// <summary>
        /// Indicates if the customer has participated in an initiated conversation
        /// </summary>
        /// <value>Indicates if the customer has participated in an initiated conversation</value>
        [DataMember(Name="hasCustomerParticipated", EmitDefaultValue=false)]
        public bool? HasCustomerParticipated { get; set; }



        /// <summary>
        /// Filter to indicate if interaction was ACD or non-ACD
        /// </summary>
        /// <value>Filter to indicate if interaction was ACD or non-ACD</value>
        [DataMember(Name="isAcdInteraction", EmitDefaultValue=false)]
        public bool? IsAcdInteraction { get; set; }



        /// <summary>
        /// Filters to indicate if interaction has FAX
        /// </summary>
        /// <value>Filters to indicate if interaction has FAX</value>
        [DataMember(Name="hasFax", EmitDefaultValue=false)]
        public bool? HasFax { get; set; }



        /// <summary>
        /// The list of Data Action IDs 
        /// </summary>
        /// <value>The list of Data Action IDs </value>
        [DataMember(Name="dataActionIds", EmitDefaultValue=false)]
        public List<string> DataActionIds { get; set; }



        /// <summary>
        /// Deprecated - Please use integrationIds instead
        /// </summary>
        /// <value>Deprecated - Please use integrationIds instead</value>
        [DataMember(Name="actionCategoryName", EmitDefaultValue=false)]
        public string ActionCategoryName { get; set; }



        /// <summary>
        /// The list of integration IDs for Data Action
        /// </summary>
        /// <value>The list of integration IDs for Data Action</value>
        [DataMember(Name="integrationIds", EmitDefaultValue=false)]
        public List<string> IntegrationIds { get; set; }



        /// <summary>
        /// The list of Response codes for Data Action
        /// </summary>
        /// <value>The list of Response codes for Data Action</value>
        [DataMember(Name="responseStatuses", EmitDefaultValue=false)]
        public List<string> ResponseStatuses { get; set; }





        /// <summary>
        /// Filter to indicate whether the dashboard is favorite or unfavorite.
        /// </summary>
        /// <value>Filter to indicate whether the dashboard is favorite or unfavorite.</value>
        [DataMember(Name="favouriteDashboard", EmitDefaultValue=false)]
        public bool? FavouriteDashboard { get; set; }



        /// <summary>
        /// Filter to indicate the dashboard owned by the user.
        /// </summary>
        /// <value>Filter to indicate the dashboard owned by the user.</value>
        [DataMember(Name="myDashboard", EmitDefaultValue=false)]
        public bool? MyDashboard { get; set; }



        /// <summary>
        /// The list of agent errors that are related to station
        /// </summary>
        /// <value>The list of agent errors that are related to station</value>
        [DataMember(Name="stationErrors", EmitDefaultValue=false)]
        public List<string> StationErrors { get; set; }



        /// <summary>
        /// The canonical contact ids are used to filter the view
        /// </summary>
        /// <value>The canonical contact ids are used to filter the view</value>
        [DataMember(Name="canonicalContactIds", EmitDefaultValue=false)]
        public List<string> CanonicalContactIds { get; set; }



        /// <summary>
        /// The list of Alert Rule IDs
        /// </summary>
        /// <value>The list of Alert Rule IDs</value>
        [DataMember(Name="alertRuleIds", EmitDefaultValue=false)]
        public List<string> AlertRuleIds { get; set; }



        /// <summary>
        /// The list of Evaluation Form Context IDs
        /// </summary>
        /// <value>The list of Evaluation Form Context IDs</value>
        [DataMember(Name="evaluationFormContextIds", EmitDefaultValue=false)]
        public List<string> EvaluationFormContextIds { get; set; }



        /// <summary>
        /// The evaluation statuses that are used to filter the view
        /// </summary>
        /// <value>The evaluation statuses that are used to filter the view</value>
        [DataMember(Name="evaluationStatuses", EmitDefaultValue=false)]
        public List<EvaluationStatusesEnum> EvaluationStatuses { get; set; }



        /// <summary>
        /// The list of Workbin IDs
        /// </summary>
        /// <value>The list of Workbin IDs</value>
        [DataMember(Name="workbinIds", EmitDefaultValue=false)]
        public List<string> WorkbinIds { get; set; }



        /// <summary>
        /// The list of Worktype IDs
        /// </summary>
        /// <value>The list of Worktype IDs</value>
        [DataMember(Name="worktypeIds", EmitDefaultValue=false)]
        public List<string> WorktypeIds { get; set; }



        /// <summary>
        /// The list of Workitem IDs
        /// </summary>
        /// <value>The list of Workitem IDs</value>
        [DataMember(Name="workitemIds", EmitDefaultValue=false)]
        public List<string> WorkitemIds { get; set; }



        /// <summary>
        /// The list of Workitem Assignee IDs
        /// </summary>
        /// <value>The list of Workitem Assignee IDs</value>
        [DataMember(Name="workitemAssigneeIds", EmitDefaultValue=false)]
        public List<string> WorkitemAssigneeIds { get; set; }



        /// <summary>
        /// The list of Workitem Statuses IDs
        /// </summary>
        /// <value>The list of Workitem Statuses IDs</value>
        [DataMember(Name="workitemStatuses", EmitDefaultValue=false)]
        public List<string> WorkitemStatuses { get; set; }



        /// <summary>
        /// Deprecated - Use hasPciData or hasPiiData instead.
        /// </summary>
        /// <value>Deprecated - Use hasPciData or hasPiiData instead.</value>
        [DataMember(Name="isAnalyzedForSensitiveData", EmitDefaultValue=false)]
        public bool? IsAnalyzedForSensitiveData { get; set; }



        /// <summary>
        /// Deprecated. Use hasPciData or hasPiiData instead.
        /// </summary>
        /// <value>Deprecated. Use hasPciData or hasPiiData instead.</value>
        [DataMember(Name="hasSensitiveData", EmitDefaultValue=false)]
        public bool? HasSensitiveData { get; set; }



        /// <summary>
        /// Filter to indicate the transcript contains Pci data.
        /// </summary>
        /// <value>Filter to indicate the transcript contains Pci data.</value>
        [DataMember(Name="hasPciData", EmitDefaultValue=false)]
        public bool? HasPciData { get; set; }



        /// <summary>
        /// Filter to indicate the transcript contains Pii data.
        /// </summary>
        /// <value>Filter to indicate the transcript contains Pii data.</value>
        [DataMember(Name="hasPiiData", EmitDefaultValue=false)]
        public bool? HasPiiData { get; set; }



        /// <summary>
        /// Filter for Sub Path
        /// </summary>
        /// <value>Filter for Sub Path</value>
        [DataMember(Name="subPath", EmitDefaultValue=false)]
        public string SubPath { get; set; }





        /// <summary>
        /// Filter to indicate if the customer cleared the conversation.
        /// </summary>
        /// <value>Filter to indicate if the customer cleared the conversation.</value>
        [DataMember(Name="isClearedByCustomer", EmitDefaultValue=false)]
        public bool? IsClearedByCustomer { get; set; }



        /// <summary>
        /// The evaluation assignee ids that are used to filter the view.
        /// </summary>
        /// <value>The evaluation assignee ids that are used to filter the view.</value>
        [DataMember(Name="evaluationAssigneeIds", EmitDefaultValue=false)]
        public List<string> EvaluationAssigneeIds { get; set; }



        /// <summary>
        /// Filter to indicate that the user has no assigned evaluation.
        /// </summary>
        /// <value>Filter to indicate that the user has no assigned evaluation.</value>
        [DataMember(Name="evaluationAssigned", EmitDefaultValue=false)]
        public bool? EvaluationAssigned { get; set; }



        /// <summary>
        /// The assistant ids that are used to filter the view.
        /// </summary>
        /// <value>The assistant ids that are used to filter the view.</value>
        [DataMember(Name="assistantIds", EmitDefaultValue=false)]
        public List<string> AssistantIds { get; set; }



        /// <summary>
        /// The knowledge base ids that are used to filter the view.
        /// </summary>
        /// <value>The knowledge base ids that are used to filter the view.</value>
        [DataMember(Name="knowledgeBaseIds", EmitDefaultValue=false)]
        public List<string> KnowledgeBaseIds { get; set; }



        /// <summary>
        /// Filter to indicate if the interactions are parked.
        /// </summary>
        /// <value>Filter to indicate if the interactions are parked.</value>
        [DataMember(Name="isParked", EmitDefaultValue=false)]
        public bool? IsParked { get; set; }



        /// <summary>
        /// The agentEmpathyScore is used to filter the view
        /// </summary>
        /// <value>The agentEmpathyScore is used to filter the view</value>
        [DataMember(Name="agentEmpathyScore", EmitDefaultValue=false)]
        public NumericRange AgentEmpathyScore { get; set; }



        /// <summary>
        /// The surveyTypes is used to filter the view
        /// </summary>
        /// <value>The surveyTypes is used to filter the view</value>
        [DataMember(Name="surveyTypes", EmitDefaultValue=false)]
        public List<SurveyTypesEnum> SurveyTypes { get; set; }



        /// <summary>
        /// The list of Survey Response Status
        /// </summary>
        /// <value>The list of Survey Response Status</value>
        [DataMember(Name="surveyResponseStatuses", EmitDefaultValue=false)]
        public List<SurveyResponseStatusesEnum> SurveyResponseStatuses { get; set; }



        /// <summary>
        /// The botFlowTypes is used to filter the view
        /// </summary>
        /// <value>The botFlowTypes is used to filter the view</value>
        [DataMember(Name="botFlowTypes", EmitDefaultValue=false)]
        public List<BotFlowTypesEnum> BotFlowTypes { get; set; }



        /// <summary>
        /// The agent talk durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The agent talk durations in milliseconds used to filter the view</value>
        [DataMember(Name="agentTalkDurationMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> AgentTalkDurationMilliseconds { get; set; }



        /// <summary>
        /// The customer talk durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The customer talk durations in milliseconds used to filter the view</value>
        [DataMember(Name="customerTalkDurationMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> CustomerTalkDurationMilliseconds { get; set; }



        /// <summary>
        /// The overtalk durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The overtalk durations in milliseconds used to filter the view</value>
        [DataMember(Name="overtalkDurationMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> OvertalkDurationMilliseconds { get; set; }



        /// <summary>
        /// The silence durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The silence durations in milliseconds used to filter the view</value>
        [DataMember(Name="silenceDurationMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> SilenceDurationMilliseconds { get; set; }



        /// <summary>
        /// The acd durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The acd durations in milliseconds used to filter the view</value>
        [DataMember(Name="acdDurationMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> AcdDurationMilliseconds { get; set; }



        /// <summary>
        /// The ivr durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The ivr durations in milliseconds used to filter the view</value>
        [DataMember(Name="ivrDurationMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> IvrDurationMilliseconds { get; set; }



        /// <summary>
        /// The other (hold/music) durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The other (hold/music) durations in milliseconds used to filter the view</value>
        [DataMember(Name="otherDurationMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> OtherDurationMilliseconds { get; set; }



        /// <summary>
        /// The agent talk percentage used to filter the view
        /// </summary>
        /// <value>The agent talk percentage used to filter the view</value>
        [DataMember(Name="agentTalkPercentage", EmitDefaultValue=false)]
        public NumericRange AgentTalkPercentage { get; set; }



        /// <summary>
        /// The customer talk percentage used to filter the view
        /// </summary>
        /// <value>The customer talk percentage used to filter the view</value>
        [DataMember(Name="customerTalkPercentage", EmitDefaultValue=false)]
        public NumericRange CustomerTalkPercentage { get; set; }



        /// <summary>
        /// The overtalk percentage used to filter the view
        /// </summary>
        /// <value>The overtalk percentage used to filter the view</value>
        [DataMember(Name="overtalkPercentage", EmitDefaultValue=false)]
        public NumericRange OvertalkPercentage { get; set; }



        /// <summary>
        /// The silence percentage used to filter the view
        /// </summary>
        /// <value>The silence percentage used to filter the view</value>
        [DataMember(Name="silencePercentage", EmitDefaultValue=false)]
        public NumericRange SilencePercentage { get; set; }



        /// <summary>
        /// The acd percentage used to filter the view
        /// </summary>
        /// <value>The acd percentage used to filter the view</value>
        [DataMember(Name="acdPercentage", EmitDefaultValue=false)]
        public NumericRange AcdPercentage { get; set; }



        /// <summary>
        /// The ivr percentage used to filter the view
        /// </summary>
        /// <value>The ivr percentage used to filter the view</value>
        [DataMember(Name="ivrPercentage", EmitDefaultValue=false)]
        public NumericRange IvrPercentage { get; set; }



        /// <summary>
        /// The other (hold/music percentage used to filter the view
        /// </summary>
        /// <value>The other (hold/music percentage used to filter the view</value>
        [DataMember(Name="otherPercentage", EmitDefaultValue=false)]
        public NumericRange OtherPercentage { get; set; }



        /// <summary>
        /// The overtalk instance range used to filter the view
        /// </summary>
        /// <value>The overtalk instance range used to filter the view</value>
        [DataMember(Name="overtalkInstances", EmitDefaultValue=false)]
        public NumericRange OvertalkInstances { get; set; }



        /// <summary>
        /// Filter to indicate if the screen is recorded
        /// </summary>
        /// <value>Filter to indicate if the screen is recorded</value>
        [DataMember(Name="isScreenRecorded", EmitDefaultValue=false)]
        public bool? IsScreenRecorded { get; set; }



        /// <summary>
        /// The list of Screen Monitor User Ids
        /// </summary>
        /// <value>The list of Screen Monitor User Ids</value>
        [DataMember(Name="screenMonitorUserIds", EmitDefaultValue=false)]
        public List<string> ScreenMonitorUserIds { get; set; }









        /// <summary>
        /// The transcript durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The transcript durations in milliseconds used to filter the view</value>
        [DataMember(Name="transcriptDurationMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> TranscriptDurationMilliseconds { get; set; }



        /// <summary>
        /// The list of workitem status with worktype
        /// </summary>
        /// <value>The list of workitem status with worktype</value>
        [DataMember(Name="workitemsStatuses", EmitDefaultValue=false)]
        public List<WorkitemStatusFilter> WorkitemsStatuses { get; set; }



        /// <summary>
        /// List of countries for social filtering
        /// </summary>
        /// <value>List of countries for social filtering</value>
        [DataMember(Name="socialCountries", EmitDefaultValue=false)]
        public List<string> SocialCountries { get; set; }



        /// <summary>
        /// List of languages for social filtering
        /// </summary>
        /// <value>List of languages for social filtering</value>
        [DataMember(Name="socialLanguages", EmitDefaultValue=false)]
        public List<string> SocialLanguages { get; set; }



        /// <summary>
        /// List of channels for social filtering
        /// </summary>
        /// <value>List of channels for social filtering</value>
        [DataMember(Name="socialChannels", EmitDefaultValue=false)]
        public List<SocialChannelsEnum> SocialChannels { get; set; }



        /// <summary>
        /// The sentiment of the social post
        /// </summary>
        /// <value>The sentiment of the social post</value>
        [DataMember(Name="socialSentimentCategory", EmitDefaultValue=false)]
        public List<SocialSentimentCategoryEnum> SocialSentimentCategory { get; set; }



        /// <summary>
        /// The list of topicIds for social filtering
        /// </summary>
        /// <value>The list of topicIds for social filtering</value>
        [DataMember(Name="socialTopicIds", EmitDefaultValue=false)]
        public List<string> SocialTopicIds { get; set; }



        /// <summary>
        /// The list of ingestion ruleIds for social filtering
        /// </summary>
        /// <value>The list of ingestion ruleIds for social filtering</value>
        [DataMember(Name="socialIngestionRuleIds", EmitDefaultValue=false)]
        public List<string> SocialIngestionRuleIds { get; set; }



        /// <summary>
        /// Filter to indicate if the post has created a conversation
        /// </summary>
        /// <value>Filter to indicate if the post has created a conversation</value>
        [DataMember(Name="socialConversationCreated", EmitDefaultValue=false)]
        public bool? SocialConversationCreated { get; set; }



        /// <summary>
        /// The list of content Type for social filtering
        /// </summary>
        /// <value>The list of content Type for social filtering</value>
        [DataMember(Name="socialContentType", EmitDefaultValue=false)]
        public List<SocialContentTypeEnum> SocialContentType { get; set; }



        /// <summary>
        /// The list of keywords for social filtering
        /// </summary>
        /// <value>The list of keywords for social filtering</value>
        [DataMember(Name="socialKeywords", EmitDefaultValue=false)]
        public List<SocialKeyword> SocialKeywords { get; set; }



        /// <summary>
        /// Filter to indicate if the post is escalated
        /// </summary>
        /// <value>Filter to indicate if the post is escalated</value>
        [DataMember(Name="socialPostEscalated", EmitDefaultValue=false)]
        public bool? SocialPostEscalated { get; set; }



        /// <summary>
        /// Indicates if a social message was public or private
        /// </summary>
        /// <value>Indicates if a social message was public or private</value>
        [DataMember(Name="socialClassifications", EmitDefaultValue=false)]
        public List<SocialClassificationsEnum> SocialClassifications { get; set; }



        /// <summary>
        /// The manager ids used to fetch associated users for the view
        /// </summary>
        /// <value>The manager ids used to fetch associated users for the view</value>
        [DataMember(Name="filterUsersByManagerIds", EmitDefaultValue=false)]
        public List<string> FilterUsersByManagerIds { get; set; }



        /// <summary>
        /// List of Dashboard slideshowIds to be filtered
        /// </summary>
        /// <value>List of Dashboard slideshowIds to be filtered</value>
        [DataMember(Name="slideshowIds", EmitDefaultValue=false)]
        public List<string> SlideshowIds { get; set; }



        /// <summary>
        /// Filter to indicate if the conversation has conference
        /// </summary>
        /// <value>Filter to indicate if the conversation has conference</value>
        [DataMember(Name="conferenced", EmitDefaultValue=false)]
        public bool? Conferenced { get; set; }



        /// <summary>
        /// Filter to indicate if the conversation has video
        /// </summary>
        /// <value>Filter to indicate if the conversation has video</value>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public bool? Video { get; set; }



        /// <summary>
        /// Filter to indicate if the conversation has linked interaction
        /// </summary>
        /// <value>Filter to indicate if the conversation has linked interaction</value>
        [DataMember(Name="linkedInteraction", EmitDefaultValue=false)]
        public bool? LinkedInteraction { get; set; }



        /// <summary>
        /// List of recommendation sources for filtering recommendation details pane
        /// </summary>
        /// <value>List of recommendation sources for filtering recommendation details pane</value>
        [DataMember(Name="recommendationSources", EmitDefaultValue=false)]
        public List<RecommendationSourcesEnum> RecommendationSources { get; set; }





        /// <summary>
        /// The queue ids are used to for comparison to the primary queue filter in reporting
        /// </summary>
        /// <value>The queue ids are used to for comparison to the primary queue filter in reporting</value>
        [DataMember(Name="comparisonQueueIds", EmitDefaultValue=false)]
        public List<string> ComparisonQueueIds { get; set; }



        /// <summary>
        /// A list of metrics selected for the view
        /// </summary>
        /// <value>A list of metrics selected for the view</value>
        [DataMember(Name="viewMetrics", EmitDefaultValue=false)]
        public List<ViewMetricsEnum> ViewMetrics { get; set; }



        /// <summary>
        /// A list of timeline categories
        /// </summary>
        /// <value>A list of timeline categories</value>
        [DataMember(Name="timelineCategories", EmitDefaultValue=false)]
        public List<string> TimelineCategories { get; set; }


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
            sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
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
            sb.Append("  IsRecorded: ").Append(IsRecorded).Append("\n");
            sb.Append("  HasEvaluation: ").Append(HasEvaluation).Append("\n");
            sb.Append("  HasScoredEvaluation: ").Append(HasScoredEvaluation).Append("\n");
            sb.Append("  EmailDeliveryStatusList: ").Append(EmailDeliveryStatusList).Append("\n");
            sb.Append("  IsAgentOwnedCallback: ").Append(IsAgentOwnedCallback).Append("\n");
            sb.Append("  AgentCallbackOwnerIds: ").Append(AgentCallbackOwnerIds).Append("\n");
            sb.Append("  TranscriptTopics: ").Append(TranscriptTopics).Append("\n");
            sb.Append("  JourneyFrequencyCapReasons: ").Append(JourneyFrequencyCapReasons).Append("\n");
            sb.Append("  JourneyBlockingActionMapIds: ").Append(JourneyBlockingActionMapIds).Append("\n");
            sb.Append("  JourneyActionTargetIds: ").Append(JourneyActionTargetIds).Append("\n");
            sb.Append("  JourneyBlockingScheduleGroupIds: ").Append(JourneyBlockingScheduleGroupIds).Append("\n");
            sb.Append("  JourneyBlockingEmergencyScheduleGroupIds: ").Append(JourneyBlockingEmergencyScheduleGroupIds).Append("\n");
            sb.Append("  JourneyUrlEqualConditions: ").Append(JourneyUrlEqualConditions).Append("\n");
            sb.Append("  JourneyUrlNotEqualConditions: ").Append(JourneyUrlNotEqualConditions).Append("\n");
            sb.Append("  JourneyUrlStartsWithConditions: ").Append(JourneyUrlStartsWithConditions).Append("\n");
            sb.Append("  JourneyUrlEndsWithConditions: ").Append(JourneyUrlEndsWithConditions).Append("\n");
            sb.Append("  JourneyUrlContainsAnyConditions: ").Append(JourneyUrlContainsAnyConditions).Append("\n");
            sb.Append("  JourneyUrlNotContainsAnyConditions: ").Append(JourneyUrlNotContainsAnyConditions).Append("\n");
            sb.Append("  JourneyUrlContainsAllConditions: ").Append(JourneyUrlContainsAllConditions).Append("\n");
            sb.Append("  JourneyUrlNotContainsAllConditions: ").Append(JourneyUrlNotContainsAllConditions).Append("\n");
            sb.Append("  FlowMilestoneIds: ").Append(FlowMilestoneIds).Append("\n");
            sb.Append("  IsAssessmentPassed: ").Append(IsAssessmentPassed).Append("\n");
            sb.Append("  ConversationInitiators: ").Append(ConversationInitiators).Append("\n");
            sb.Append("  HasCustomerParticipated: ").Append(HasCustomerParticipated).Append("\n");
            sb.Append("  IsAcdInteraction: ").Append(IsAcdInteraction).Append("\n");
            sb.Append("  HasFax: ").Append(HasFax).Append("\n");
            sb.Append("  DataActionIds: ").Append(DataActionIds).Append("\n");
            sb.Append("  ActionCategoryName: ").Append(ActionCategoryName).Append("\n");
            sb.Append("  IntegrationIds: ").Append(IntegrationIds).Append("\n");
            sb.Append("  ResponseStatuses: ").Append(ResponseStatuses).Append("\n");
            sb.Append("  AvailableDashboard: ").Append(AvailableDashboard).Append("\n");
            sb.Append("  FavouriteDashboard: ").Append(FavouriteDashboard).Append("\n");
            sb.Append("  MyDashboard: ").Append(MyDashboard).Append("\n");
            sb.Append("  StationErrors: ").Append(StationErrors).Append("\n");
            sb.Append("  CanonicalContactIds: ").Append(CanonicalContactIds).Append("\n");
            sb.Append("  AlertRuleIds: ").Append(AlertRuleIds).Append("\n");
            sb.Append("  EvaluationFormContextIds: ").Append(EvaluationFormContextIds).Append("\n");
            sb.Append("  EvaluationStatuses: ").Append(EvaluationStatuses).Append("\n");
            sb.Append("  WorkbinIds: ").Append(WorkbinIds).Append("\n");
            sb.Append("  WorktypeIds: ").Append(WorktypeIds).Append("\n");
            sb.Append("  WorkitemIds: ").Append(WorkitemIds).Append("\n");
            sb.Append("  WorkitemAssigneeIds: ").Append(WorkitemAssigneeIds).Append("\n");
            sb.Append("  WorkitemStatuses: ").Append(WorkitemStatuses).Append("\n");
            sb.Append("  IsAnalyzedForSensitiveData: ").Append(IsAnalyzedForSensitiveData).Append("\n");
            sb.Append("  HasSensitiveData: ").Append(HasSensitiveData).Append("\n");
            sb.Append("  HasPciData: ").Append(HasPciData).Append("\n");
            sb.Append("  HasPiiData: ").Append(HasPiiData).Append("\n");
            sb.Append("  SubPath: ").Append(SubPath).Append("\n");
            sb.Append("  UserState: ").Append(UserState).Append("\n");
            sb.Append("  IsClearedByCustomer: ").Append(IsClearedByCustomer).Append("\n");
            sb.Append("  EvaluationAssigneeIds: ").Append(EvaluationAssigneeIds).Append("\n");
            sb.Append("  EvaluationAssigned: ").Append(EvaluationAssigned).Append("\n");
            sb.Append("  AssistantIds: ").Append(AssistantIds).Append("\n");
            sb.Append("  KnowledgeBaseIds: ").Append(KnowledgeBaseIds).Append("\n");
            sb.Append("  IsParked: ").Append(IsParked).Append("\n");
            sb.Append("  AgentEmpathyScore: ").Append(AgentEmpathyScore).Append("\n");
            sb.Append("  SurveyTypes: ").Append(SurveyTypes).Append("\n");
            sb.Append("  SurveyResponseStatuses: ").Append(SurveyResponseStatuses).Append("\n");
            sb.Append("  BotFlowTypes: ").Append(BotFlowTypes).Append("\n");
            sb.Append("  AgentTalkDurationMilliseconds: ").Append(AgentTalkDurationMilliseconds).Append("\n");
            sb.Append("  CustomerTalkDurationMilliseconds: ").Append(CustomerTalkDurationMilliseconds).Append("\n");
            sb.Append("  OvertalkDurationMilliseconds: ").Append(OvertalkDurationMilliseconds).Append("\n");
            sb.Append("  SilenceDurationMilliseconds: ").Append(SilenceDurationMilliseconds).Append("\n");
            sb.Append("  AcdDurationMilliseconds: ").Append(AcdDurationMilliseconds).Append("\n");
            sb.Append("  IvrDurationMilliseconds: ").Append(IvrDurationMilliseconds).Append("\n");
            sb.Append("  OtherDurationMilliseconds: ").Append(OtherDurationMilliseconds).Append("\n");
            sb.Append("  AgentTalkPercentage: ").Append(AgentTalkPercentage).Append("\n");
            sb.Append("  CustomerTalkPercentage: ").Append(CustomerTalkPercentage).Append("\n");
            sb.Append("  OvertalkPercentage: ").Append(OvertalkPercentage).Append("\n");
            sb.Append("  SilencePercentage: ").Append(SilencePercentage).Append("\n");
            sb.Append("  AcdPercentage: ").Append(AcdPercentage).Append("\n");
            sb.Append("  IvrPercentage: ").Append(IvrPercentage).Append("\n");
            sb.Append("  OtherPercentage: ").Append(OtherPercentage).Append("\n");
            sb.Append("  OvertalkInstances: ").Append(OvertalkInstances).Append("\n");
            sb.Append("  IsScreenRecorded: ").Append(IsScreenRecorded).Append("\n");
            sb.Append("  ScreenMonitorUserIds: ").Append(ScreenMonitorUserIds).Append("\n");
            sb.Append("  DashboardState: ").Append(DashboardState).Append("\n");
            sb.Append("  DashboardType: ").Append(DashboardType).Append("\n");
            sb.Append("  DashboardAccessFilter: ").Append(DashboardAccessFilter).Append("\n");
            sb.Append("  TranscriptDurationMilliseconds: ").Append(TranscriptDurationMilliseconds).Append("\n");
            sb.Append("  WorkitemsStatuses: ").Append(WorkitemsStatuses).Append("\n");
            sb.Append("  SocialCountries: ").Append(SocialCountries).Append("\n");
            sb.Append("  SocialLanguages: ").Append(SocialLanguages).Append("\n");
            sb.Append("  SocialChannels: ").Append(SocialChannels).Append("\n");
            sb.Append("  SocialSentimentCategory: ").Append(SocialSentimentCategory).Append("\n");
            sb.Append("  SocialTopicIds: ").Append(SocialTopicIds).Append("\n");
            sb.Append("  SocialIngestionRuleIds: ").Append(SocialIngestionRuleIds).Append("\n");
            sb.Append("  SocialConversationCreated: ").Append(SocialConversationCreated).Append("\n");
            sb.Append("  SocialContentType: ").Append(SocialContentType).Append("\n");
            sb.Append("  SocialKeywords: ").Append(SocialKeywords).Append("\n");
            sb.Append("  SocialPostEscalated: ").Append(SocialPostEscalated).Append("\n");
            sb.Append("  SocialClassifications: ").Append(SocialClassifications).Append("\n");
            sb.Append("  FilterUsersByManagerIds: ").Append(FilterUsersByManagerIds).Append("\n");
            sb.Append("  SlideshowIds: ").Append(SlideshowIds).Append("\n");
            sb.Append("  Conferenced: ").Append(Conferenced).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  LinkedInteraction: ").Append(LinkedInteraction).Append("\n");
            sb.Append("  RecommendationSources: ").Append(RecommendationSources).Append("\n");
            sb.Append("  EvaluationRole: ").Append(EvaluationRole).Append("\n");
            sb.Append("  ComparisonQueueIds: ").Append(ComparisonQueueIds).Append("\n");
            sb.Append("  ViewMetrics: ").Append(ViewMetrics).Append("\n");
            sb.Append("  TimelineCategories: ").Append(TimelineCategories).Append("\n");
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
                    this.ManagementUnitIds == other.ManagementUnitIds ||
                    this.ManagementUnitIds != null &&
                    this.ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
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
                ) &&
                (
                    this.IsRecorded == other.IsRecorded ||
                    this.IsRecorded != null &&
                    this.IsRecorded.Equals(other.IsRecorded)
                ) &&
                (
                    this.HasEvaluation == other.HasEvaluation ||
                    this.HasEvaluation != null &&
                    this.HasEvaluation.Equals(other.HasEvaluation)
                ) &&
                (
                    this.HasScoredEvaluation == other.HasScoredEvaluation ||
                    this.HasScoredEvaluation != null &&
                    this.HasScoredEvaluation.Equals(other.HasScoredEvaluation)
                ) &&
                (
                    this.EmailDeliveryStatusList == other.EmailDeliveryStatusList ||
                    this.EmailDeliveryStatusList != null &&
                    this.EmailDeliveryStatusList.SequenceEqual(other.EmailDeliveryStatusList)
                ) &&
                (
                    this.IsAgentOwnedCallback == other.IsAgentOwnedCallback ||
                    this.IsAgentOwnedCallback != null &&
                    this.IsAgentOwnedCallback.Equals(other.IsAgentOwnedCallback)
                ) &&
                (
                    this.AgentCallbackOwnerIds == other.AgentCallbackOwnerIds ||
                    this.AgentCallbackOwnerIds != null &&
                    this.AgentCallbackOwnerIds.SequenceEqual(other.AgentCallbackOwnerIds)
                ) &&
                (
                    this.TranscriptTopics == other.TranscriptTopics ||
                    this.TranscriptTopics != null &&
                    this.TranscriptTopics.SequenceEqual(other.TranscriptTopics)
                ) &&
                (
                    this.JourneyFrequencyCapReasons == other.JourneyFrequencyCapReasons ||
                    this.JourneyFrequencyCapReasons != null &&
                    this.JourneyFrequencyCapReasons.SequenceEqual(other.JourneyFrequencyCapReasons)
                ) &&
                (
                    this.JourneyBlockingActionMapIds == other.JourneyBlockingActionMapIds ||
                    this.JourneyBlockingActionMapIds != null &&
                    this.JourneyBlockingActionMapIds.SequenceEqual(other.JourneyBlockingActionMapIds)
                ) &&
                (
                    this.JourneyActionTargetIds == other.JourneyActionTargetIds ||
                    this.JourneyActionTargetIds != null &&
                    this.JourneyActionTargetIds.SequenceEqual(other.JourneyActionTargetIds)
                ) &&
                (
                    this.JourneyBlockingScheduleGroupIds == other.JourneyBlockingScheduleGroupIds ||
                    this.JourneyBlockingScheduleGroupIds != null &&
                    this.JourneyBlockingScheduleGroupIds.SequenceEqual(other.JourneyBlockingScheduleGroupIds)
                ) &&
                (
                    this.JourneyBlockingEmergencyScheduleGroupIds == other.JourneyBlockingEmergencyScheduleGroupIds ||
                    this.JourneyBlockingEmergencyScheduleGroupIds != null &&
                    this.JourneyBlockingEmergencyScheduleGroupIds.SequenceEqual(other.JourneyBlockingEmergencyScheduleGroupIds)
                ) &&
                (
                    this.JourneyUrlEqualConditions == other.JourneyUrlEqualConditions ||
                    this.JourneyUrlEqualConditions != null &&
                    this.JourneyUrlEqualConditions.SequenceEqual(other.JourneyUrlEqualConditions)
                ) &&
                (
                    this.JourneyUrlNotEqualConditions == other.JourneyUrlNotEqualConditions ||
                    this.JourneyUrlNotEqualConditions != null &&
                    this.JourneyUrlNotEqualConditions.SequenceEqual(other.JourneyUrlNotEqualConditions)
                ) &&
                (
                    this.JourneyUrlStartsWithConditions == other.JourneyUrlStartsWithConditions ||
                    this.JourneyUrlStartsWithConditions != null &&
                    this.JourneyUrlStartsWithConditions.SequenceEqual(other.JourneyUrlStartsWithConditions)
                ) &&
                (
                    this.JourneyUrlEndsWithConditions == other.JourneyUrlEndsWithConditions ||
                    this.JourneyUrlEndsWithConditions != null &&
                    this.JourneyUrlEndsWithConditions.SequenceEqual(other.JourneyUrlEndsWithConditions)
                ) &&
                (
                    this.JourneyUrlContainsAnyConditions == other.JourneyUrlContainsAnyConditions ||
                    this.JourneyUrlContainsAnyConditions != null &&
                    this.JourneyUrlContainsAnyConditions.SequenceEqual(other.JourneyUrlContainsAnyConditions)
                ) &&
                (
                    this.JourneyUrlNotContainsAnyConditions == other.JourneyUrlNotContainsAnyConditions ||
                    this.JourneyUrlNotContainsAnyConditions != null &&
                    this.JourneyUrlNotContainsAnyConditions.SequenceEqual(other.JourneyUrlNotContainsAnyConditions)
                ) &&
                (
                    this.JourneyUrlContainsAllConditions == other.JourneyUrlContainsAllConditions ||
                    this.JourneyUrlContainsAllConditions != null &&
                    this.JourneyUrlContainsAllConditions.SequenceEqual(other.JourneyUrlContainsAllConditions)
                ) &&
                (
                    this.JourneyUrlNotContainsAllConditions == other.JourneyUrlNotContainsAllConditions ||
                    this.JourneyUrlNotContainsAllConditions != null &&
                    this.JourneyUrlNotContainsAllConditions.SequenceEqual(other.JourneyUrlNotContainsAllConditions)
                ) &&
                (
                    this.FlowMilestoneIds == other.FlowMilestoneIds ||
                    this.FlowMilestoneIds != null &&
                    this.FlowMilestoneIds.SequenceEqual(other.FlowMilestoneIds)
                ) &&
                (
                    this.IsAssessmentPassed == other.IsAssessmentPassed ||
                    this.IsAssessmentPassed != null &&
                    this.IsAssessmentPassed.Equals(other.IsAssessmentPassed)
                ) &&
                (
                    this.ConversationInitiators == other.ConversationInitiators ||
                    this.ConversationInitiators != null &&
                    this.ConversationInitiators.SequenceEqual(other.ConversationInitiators)
                ) &&
                (
                    this.HasCustomerParticipated == other.HasCustomerParticipated ||
                    this.HasCustomerParticipated != null &&
                    this.HasCustomerParticipated.Equals(other.HasCustomerParticipated)
                ) &&
                (
                    this.IsAcdInteraction == other.IsAcdInteraction ||
                    this.IsAcdInteraction != null &&
                    this.IsAcdInteraction.Equals(other.IsAcdInteraction)
                ) &&
                (
                    this.HasFax == other.HasFax ||
                    this.HasFax != null &&
                    this.HasFax.Equals(other.HasFax)
                ) &&
                (
                    this.DataActionIds == other.DataActionIds ||
                    this.DataActionIds != null &&
                    this.DataActionIds.SequenceEqual(other.DataActionIds)
                ) &&
                (
                    this.ActionCategoryName == other.ActionCategoryName ||
                    this.ActionCategoryName != null &&
                    this.ActionCategoryName.Equals(other.ActionCategoryName)
                ) &&
                (
                    this.IntegrationIds == other.IntegrationIds ||
                    this.IntegrationIds != null &&
                    this.IntegrationIds.SequenceEqual(other.IntegrationIds)
                ) &&
                (
                    this.ResponseStatuses == other.ResponseStatuses ||
                    this.ResponseStatuses != null &&
                    this.ResponseStatuses.SequenceEqual(other.ResponseStatuses)
                ) &&
                (
                    this.AvailableDashboard == other.AvailableDashboard ||
                    this.AvailableDashboard != null &&
                    this.AvailableDashboard.Equals(other.AvailableDashboard)
                ) &&
                (
                    this.FavouriteDashboard == other.FavouriteDashboard ||
                    this.FavouriteDashboard != null &&
                    this.FavouriteDashboard.Equals(other.FavouriteDashboard)
                ) &&
                (
                    this.MyDashboard == other.MyDashboard ||
                    this.MyDashboard != null &&
                    this.MyDashboard.Equals(other.MyDashboard)
                ) &&
                (
                    this.StationErrors == other.StationErrors ||
                    this.StationErrors != null &&
                    this.StationErrors.SequenceEqual(other.StationErrors)
                ) &&
                (
                    this.CanonicalContactIds == other.CanonicalContactIds ||
                    this.CanonicalContactIds != null &&
                    this.CanonicalContactIds.SequenceEqual(other.CanonicalContactIds)
                ) &&
                (
                    this.AlertRuleIds == other.AlertRuleIds ||
                    this.AlertRuleIds != null &&
                    this.AlertRuleIds.SequenceEqual(other.AlertRuleIds)
                ) &&
                (
                    this.EvaluationFormContextIds == other.EvaluationFormContextIds ||
                    this.EvaluationFormContextIds != null &&
                    this.EvaluationFormContextIds.SequenceEqual(other.EvaluationFormContextIds)
                ) &&
                (
                    this.EvaluationStatuses == other.EvaluationStatuses ||
                    this.EvaluationStatuses != null &&
                    this.EvaluationStatuses.SequenceEqual(other.EvaluationStatuses)
                ) &&
                (
                    this.WorkbinIds == other.WorkbinIds ||
                    this.WorkbinIds != null &&
                    this.WorkbinIds.SequenceEqual(other.WorkbinIds)
                ) &&
                (
                    this.WorktypeIds == other.WorktypeIds ||
                    this.WorktypeIds != null &&
                    this.WorktypeIds.SequenceEqual(other.WorktypeIds)
                ) &&
                (
                    this.WorkitemIds == other.WorkitemIds ||
                    this.WorkitemIds != null &&
                    this.WorkitemIds.SequenceEqual(other.WorkitemIds)
                ) &&
                (
                    this.WorkitemAssigneeIds == other.WorkitemAssigneeIds ||
                    this.WorkitemAssigneeIds != null &&
                    this.WorkitemAssigneeIds.SequenceEqual(other.WorkitemAssigneeIds)
                ) &&
                (
                    this.WorkitemStatuses == other.WorkitemStatuses ||
                    this.WorkitemStatuses != null &&
                    this.WorkitemStatuses.SequenceEqual(other.WorkitemStatuses)
                ) &&
                (
                    this.IsAnalyzedForSensitiveData == other.IsAnalyzedForSensitiveData ||
                    this.IsAnalyzedForSensitiveData != null &&
                    this.IsAnalyzedForSensitiveData.Equals(other.IsAnalyzedForSensitiveData)
                ) &&
                (
                    this.HasSensitiveData == other.HasSensitiveData ||
                    this.HasSensitiveData != null &&
                    this.HasSensitiveData.Equals(other.HasSensitiveData)
                ) &&
                (
                    this.HasPciData == other.HasPciData ||
                    this.HasPciData != null &&
                    this.HasPciData.Equals(other.HasPciData)
                ) &&
                (
                    this.HasPiiData == other.HasPiiData ||
                    this.HasPiiData != null &&
                    this.HasPiiData.Equals(other.HasPiiData)
                ) &&
                (
                    this.SubPath == other.SubPath ||
                    this.SubPath != null &&
                    this.SubPath.Equals(other.SubPath)
                ) &&
                (
                    this.UserState == other.UserState ||
                    this.UserState != null &&
                    this.UserState.Equals(other.UserState)
                ) &&
                (
                    this.IsClearedByCustomer == other.IsClearedByCustomer ||
                    this.IsClearedByCustomer != null &&
                    this.IsClearedByCustomer.Equals(other.IsClearedByCustomer)
                ) &&
                (
                    this.EvaluationAssigneeIds == other.EvaluationAssigneeIds ||
                    this.EvaluationAssigneeIds != null &&
                    this.EvaluationAssigneeIds.SequenceEqual(other.EvaluationAssigneeIds)
                ) &&
                (
                    this.EvaluationAssigned == other.EvaluationAssigned ||
                    this.EvaluationAssigned != null &&
                    this.EvaluationAssigned.Equals(other.EvaluationAssigned)
                ) &&
                (
                    this.AssistantIds == other.AssistantIds ||
                    this.AssistantIds != null &&
                    this.AssistantIds.SequenceEqual(other.AssistantIds)
                ) &&
                (
                    this.KnowledgeBaseIds == other.KnowledgeBaseIds ||
                    this.KnowledgeBaseIds != null &&
                    this.KnowledgeBaseIds.SequenceEqual(other.KnowledgeBaseIds)
                ) &&
                (
                    this.IsParked == other.IsParked ||
                    this.IsParked != null &&
                    this.IsParked.Equals(other.IsParked)
                ) &&
                (
                    this.AgentEmpathyScore == other.AgentEmpathyScore ||
                    this.AgentEmpathyScore != null &&
                    this.AgentEmpathyScore.Equals(other.AgentEmpathyScore)
                ) &&
                (
                    this.SurveyTypes == other.SurveyTypes ||
                    this.SurveyTypes != null &&
                    this.SurveyTypes.SequenceEqual(other.SurveyTypes)
                ) &&
                (
                    this.SurveyResponseStatuses == other.SurveyResponseStatuses ||
                    this.SurveyResponseStatuses != null &&
                    this.SurveyResponseStatuses.SequenceEqual(other.SurveyResponseStatuses)
                ) &&
                (
                    this.BotFlowTypes == other.BotFlowTypes ||
                    this.BotFlowTypes != null &&
                    this.BotFlowTypes.SequenceEqual(other.BotFlowTypes)
                ) &&
                (
                    this.AgentTalkDurationMilliseconds == other.AgentTalkDurationMilliseconds ||
                    this.AgentTalkDurationMilliseconds != null &&
                    this.AgentTalkDurationMilliseconds.SequenceEqual(other.AgentTalkDurationMilliseconds)
                ) &&
                (
                    this.CustomerTalkDurationMilliseconds == other.CustomerTalkDurationMilliseconds ||
                    this.CustomerTalkDurationMilliseconds != null &&
                    this.CustomerTalkDurationMilliseconds.SequenceEqual(other.CustomerTalkDurationMilliseconds)
                ) &&
                (
                    this.OvertalkDurationMilliseconds == other.OvertalkDurationMilliseconds ||
                    this.OvertalkDurationMilliseconds != null &&
                    this.OvertalkDurationMilliseconds.SequenceEqual(other.OvertalkDurationMilliseconds)
                ) &&
                (
                    this.SilenceDurationMilliseconds == other.SilenceDurationMilliseconds ||
                    this.SilenceDurationMilliseconds != null &&
                    this.SilenceDurationMilliseconds.SequenceEqual(other.SilenceDurationMilliseconds)
                ) &&
                (
                    this.AcdDurationMilliseconds == other.AcdDurationMilliseconds ||
                    this.AcdDurationMilliseconds != null &&
                    this.AcdDurationMilliseconds.SequenceEqual(other.AcdDurationMilliseconds)
                ) &&
                (
                    this.IvrDurationMilliseconds == other.IvrDurationMilliseconds ||
                    this.IvrDurationMilliseconds != null &&
                    this.IvrDurationMilliseconds.SequenceEqual(other.IvrDurationMilliseconds)
                ) &&
                (
                    this.OtherDurationMilliseconds == other.OtherDurationMilliseconds ||
                    this.OtherDurationMilliseconds != null &&
                    this.OtherDurationMilliseconds.SequenceEqual(other.OtherDurationMilliseconds)
                ) &&
                (
                    this.AgentTalkPercentage == other.AgentTalkPercentage ||
                    this.AgentTalkPercentage != null &&
                    this.AgentTalkPercentage.Equals(other.AgentTalkPercentage)
                ) &&
                (
                    this.CustomerTalkPercentage == other.CustomerTalkPercentage ||
                    this.CustomerTalkPercentage != null &&
                    this.CustomerTalkPercentage.Equals(other.CustomerTalkPercentage)
                ) &&
                (
                    this.OvertalkPercentage == other.OvertalkPercentage ||
                    this.OvertalkPercentage != null &&
                    this.OvertalkPercentage.Equals(other.OvertalkPercentage)
                ) &&
                (
                    this.SilencePercentage == other.SilencePercentage ||
                    this.SilencePercentage != null &&
                    this.SilencePercentage.Equals(other.SilencePercentage)
                ) &&
                (
                    this.AcdPercentage == other.AcdPercentage ||
                    this.AcdPercentage != null &&
                    this.AcdPercentage.Equals(other.AcdPercentage)
                ) &&
                (
                    this.IvrPercentage == other.IvrPercentage ||
                    this.IvrPercentage != null &&
                    this.IvrPercentage.Equals(other.IvrPercentage)
                ) &&
                (
                    this.OtherPercentage == other.OtherPercentage ||
                    this.OtherPercentage != null &&
                    this.OtherPercentage.Equals(other.OtherPercentage)
                ) &&
                (
                    this.OvertalkInstances == other.OvertalkInstances ||
                    this.OvertalkInstances != null &&
                    this.OvertalkInstances.Equals(other.OvertalkInstances)
                ) &&
                (
                    this.IsScreenRecorded == other.IsScreenRecorded ||
                    this.IsScreenRecorded != null &&
                    this.IsScreenRecorded.Equals(other.IsScreenRecorded)
                ) &&
                (
                    this.ScreenMonitorUserIds == other.ScreenMonitorUserIds ||
                    this.ScreenMonitorUserIds != null &&
                    this.ScreenMonitorUserIds.SequenceEqual(other.ScreenMonitorUserIds)
                ) &&
                (
                    this.DashboardState == other.DashboardState ||
                    this.DashboardState != null &&
                    this.DashboardState.Equals(other.DashboardState)
                ) &&
                (
                    this.DashboardType == other.DashboardType ||
                    this.DashboardType != null &&
                    this.DashboardType.Equals(other.DashboardType)
                ) &&
                (
                    this.DashboardAccessFilter == other.DashboardAccessFilter ||
                    this.DashboardAccessFilter != null &&
                    this.DashboardAccessFilter.Equals(other.DashboardAccessFilter)
                ) &&
                (
                    this.TranscriptDurationMilliseconds == other.TranscriptDurationMilliseconds ||
                    this.TranscriptDurationMilliseconds != null &&
                    this.TranscriptDurationMilliseconds.SequenceEqual(other.TranscriptDurationMilliseconds)
                ) &&
                (
                    this.WorkitemsStatuses == other.WorkitemsStatuses ||
                    this.WorkitemsStatuses != null &&
                    this.WorkitemsStatuses.SequenceEqual(other.WorkitemsStatuses)
                ) &&
                (
                    this.SocialCountries == other.SocialCountries ||
                    this.SocialCountries != null &&
                    this.SocialCountries.SequenceEqual(other.SocialCountries)
                ) &&
                (
                    this.SocialLanguages == other.SocialLanguages ||
                    this.SocialLanguages != null &&
                    this.SocialLanguages.SequenceEqual(other.SocialLanguages)
                ) &&
                (
                    this.SocialChannels == other.SocialChannels ||
                    this.SocialChannels != null &&
                    this.SocialChannels.SequenceEqual(other.SocialChannels)
                ) &&
                (
                    this.SocialSentimentCategory == other.SocialSentimentCategory ||
                    this.SocialSentimentCategory != null &&
                    this.SocialSentimentCategory.SequenceEqual(other.SocialSentimentCategory)
                ) &&
                (
                    this.SocialTopicIds == other.SocialTopicIds ||
                    this.SocialTopicIds != null &&
                    this.SocialTopicIds.SequenceEqual(other.SocialTopicIds)
                ) &&
                (
                    this.SocialIngestionRuleIds == other.SocialIngestionRuleIds ||
                    this.SocialIngestionRuleIds != null &&
                    this.SocialIngestionRuleIds.SequenceEqual(other.SocialIngestionRuleIds)
                ) &&
                (
                    this.SocialConversationCreated == other.SocialConversationCreated ||
                    this.SocialConversationCreated != null &&
                    this.SocialConversationCreated.Equals(other.SocialConversationCreated)
                ) &&
                (
                    this.SocialContentType == other.SocialContentType ||
                    this.SocialContentType != null &&
                    this.SocialContentType.SequenceEqual(other.SocialContentType)
                ) &&
                (
                    this.SocialKeywords == other.SocialKeywords ||
                    this.SocialKeywords != null &&
                    this.SocialKeywords.SequenceEqual(other.SocialKeywords)
                ) &&
                (
                    this.SocialPostEscalated == other.SocialPostEscalated ||
                    this.SocialPostEscalated != null &&
                    this.SocialPostEscalated.Equals(other.SocialPostEscalated)
                ) &&
                (
                    this.SocialClassifications == other.SocialClassifications ||
                    this.SocialClassifications != null &&
                    this.SocialClassifications.SequenceEqual(other.SocialClassifications)
                ) &&
                (
                    this.FilterUsersByManagerIds == other.FilterUsersByManagerIds ||
                    this.FilterUsersByManagerIds != null &&
                    this.FilterUsersByManagerIds.SequenceEqual(other.FilterUsersByManagerIds)
                ) &&
                (
                    this.SlideshowIds == other.SlideshowIds ||
                    this.SlideshowIds != null &&
                    this.SlideshowIds.SequenceEqual(other.SlideshowIds)
                ) &&
                (
                    this.Conferenced == other.Conferenced ||
                    this.Conferenced != null &&
                    this.Conferenced.Equals(other.Conferenced)
                ) &&
                (
                    this.Video == other.Video ||
                    this.Video != null &&
                    this.Video.Equals(other.Video)
                ) &&
                (
                    this.LinkedInteraction == other.LinkedInteraction ||
                    this.LinkedInteraction != null &&
                    this.LinkedInteraction.Equals(other.LinkedInteraction)
                ) &&
                (
                    this.RecommendationSources == other.RecommendationSources ||
                    this.RecommendationSources != null &&
                    this.RecommendationSources.SequenceEqual(other.RecommendationSources)
                ) &&
                (
                    this.EvaluationRole == other.EvaluationRole ||
                    this.EvaluationRole != null &&
                    this.EvaluationRole.Equals(other.EvaluationRole)
                ) &&
                (
                    this.ComparisonQueueIds == other.ComparisonQueueIds ||
                    this.ComparisonQueueIds != null &&
                    this.ComparisonQueueIds.SequenceEqual(other.ComparisonQueueIds)
                ) &&
                (
                    this.ViewMetrics == other.ViewMetrics ||
                    this.ViewMetrics != null &&
                    this.ViewMetrics.SequenceEqual(other.ViewMetrics)
                ) &&
                (
                    this.TimelineCategories == other.TimelineCategories ||
                    this.TimelineCategories != null &&
                    this.TimelineCategories.SequenceEqual(other.TimelineCategories)
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

                if (this.ManagementUnitIds != null)
                    hash = hash * 59 + this.ManagementUnitIds.GetHashCode();

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

                if (this.IsRecorded != null)
                    hash = hash * 59 + this.IsRecorded.GetHashCode();

                if (this.HasEvaluation != null)
                    hash = hash * 59 + this.HasEvaluation.GetHashCode();

                if (this.HasScoredEvaluation != null)
                    hash = hash * 59 + this.HasScoredEvaluation.GetHashCode();

                if (this.EmailDeliveryStatusList != null)
                    hash = hash * 59 + this.EmailDeliveryStatusList.GetHashCode();

                if (this.IsAgentOwnedCallback != null)
                    hash = hash * 59 + this.IsAgentOwnedCallback.GetHashCode();

                if (this.AgentCallbackOwnerIds != null)
                    hash = hash * 59 + this.AgentCallbackOwnerIds.GetHashCode();

                if (this.TranscriptTopics != null)
                    hash = hash * 59 + this.TranscriptTopics.GetHashCode();

                if (this.JourneyFrequencyCapReasons != null)
                    hash = hash * 59 + this.JourneyFrequencyCapReasons.GetHashCode();

                if (this.JourneyBlockingActionMapIds != null)
                    hash = hash * 59 + this.JourneyBlockingActionMapIds.GetHashCode();

                if (this.JourneyActionTargetIds != null)
                    hash = hash * 59 + this.JourneyActionTargetIds.GetHashCode();

                if (this.JourneyBlockingScheduleGroupIds != null)
                    hash = hash * 59 + this.JourneyBlockingScheduleGroupIds.GetHashCode();

                if (this.JourneyBlockingEmergencyScheduleGroupIds != null)
                    hash = hash * 59 + this.JourneyBlockingEmergencyScheduleGroupIds.GetHashCode();

                if (this.JourneyUrlEqualConditions != null)
                    hash = hash * 59 + this.JourneyUrlEqualConditions.GetHashCode();

                if (this.JourneyUrlNotEqualConditions != null)
                    hash = hash * 59 + this.JourneyUrlNotEqualConditions.GetHashCode();

                if (this.JourneyUrlStartsWithConditions != null)
                    hash = hash * 59 + this.JourneyUrlStartsWithConditions.GetHashCode();

                if (this.JourneyUrlEndsWithConditions != null)
                    hash = hash * 59 + this.JourneyUrlEndsWithConditions.GetHashCode();

                if (this.JourneyUrlContainsAnyConditions != null)
                    hash = hash * 59 + this.JourneyUrlContainsAnyConditions.GetHashCode();

                if (this.JourneyUrlNotContainsAnyConditions != null)
                    hash = hash * 59 + this.JourneyUrlNotContainsAnyConditions.GetHashCode();

                if (this.JourneyUrlContainsAllConditions != null)
                    hash = hash * 59 + this.JourneyUrlContainsAllConditions.GetHashCode();

                if (this.JourneyUrlNotContainsAllConditions != null)
                    hash = hash * 59 + this.JourneyUrlNotContainsAllConditions.GetHashCode();

                if (this.FlowMilestoneIds != null)
                    hash = hash * 59 + this.FlowMilestoneIds.GetHashCode();

                if (this.IsAssessmentPassed != null)
                    hash = hash * 59 + this.IsAssessmentPassed.GetHashCode();

                if (this.ConversationInitiators != null)
                    hash = hash * 59 + this.ConversationInitiators.GetHashCode();

                if (this.HasCustomerParticipated != null)
                    hash = hash * 59 + this.HasCustomerParticipated.GetHashCode();

                if (this.IsAcdInteraction != null)
                    hash = hash * 59 + this.IsAcdInteraction.GetHashCode();

                if (this.HasFax != null)
                    hash = hash * 59 + this.HasFax.GetHashCode();

                if (this.DataActionIds != null)
                    hash = hash * 59 + this.DataActionIds.GetHashCode();

                if (this.ActionCategoryName != null)
                    hash = hash * 59 + this.ActionCategoryName.GetHashCode();

                if (this.IntegrationIds != null)
                    hash = hash * 59 + this.IntegrationIds.GetHashCode();

                if (this.ResponseStatuses != null)
                    hash = hash * 59 + this.ResponseStatuses.GetHashCode();

                if (this.AvailableDashboard != null)
                    hash = hash * 59 + this.AvailableDashboard.GetHashCode();

                if (this.FavouriteDashboard != null)
                    hash = hash * 59 + this.FavouriteDashboard.GetHashCode();

                if (this.MyDashboard != null)
                    hash = hash * 59 + this.MyDashboard.GetHashCode();

                if (this.StationErrors != null)
                    hash = hash * 59 + this.StationErrors.GetHashCode();

                if (this.CanonicalContactIds != null)
                    hash = hash * 59 + this.CanonicalContactIds.GetHashCode();

                if (this.AlertRuleIds != null)
                    hash = hash * 59 + this.AlertRuleIds.GetHashCode();

                if (this.EvaluationFormContextIds != null)
                    hash = hash * 59 + this.EvaluationFormContextIds.GetHashCode();

                if (this.EvaluationStatuses != null)
                    hash = hash * 59 + this.EvaluationStatuses.GetHashCode();

                if (this.WorkbinIds != null)
                    hash = hash * 59 + this.WorkbinIds.GetHashCode();

                if (this.WorktypeIds != null)
                    hash = hash * 59 + this.WorktypeIds.GetHashCode();

                if (this.WorkitemIds != null)
                    hash = hash * 59 + this.WorkitemIds.GetHashCode();

                if (this.WorkitemAssigneeIds != null)
                    hash = hash * 59 + this.WorkitemAssigneeIds.GetHashCode();

                if (this.WorkitemStatuses != null)
                    hash = hash * 59 + this.WorkitemStatuses.GetHashCode();

                if (this.IsAnalyzedForSensitiveData != null)
                    hash = hash * 59 + this.IsAnalyzedForSensitiveData.GetHashCode();

                if (this.HasSensitiveData != null)
                    hash = hash * 59 + this.HasSensitiveData.GetHashCode();

                if (this.HasPciData != null)
                    hash = hash * 59 + this.HasPciData.GetHashCode();

                if (this.HasPiiData != null)
                    hash = hash * 59 + this.HasPiiData.GetHashCode();

                if (this.SubPath != null)
                    hash = hash * 59 + this.SubPath.GetHashCode();

                if (this.UserState != null)
                    hash = hash * 59 + this.UserState.GetHashCode();

                if (this.IsClearedByCustomer != null)
                    hash = hash * 59 + this.IsClearedByCustomer.GetHashCode();

                if (this.EvaluationAssigneeIds != null)
                    hash = hash * 59 + this.EvaluationAssigneeIds.GetHashCode();

                if (this.EvaluationAssigned != null)
                    hash = hash * 59 + this.EvaluationAssigned.GetHashCode();

                if (this.AssistantIds != null)
                    hash = hash * 59 + this.AssistantIds.GetHashCode();

                if (this.KnowledgeBaseIds != null)
                    hash = hash * 59 + this.KnowledgeBaseIds.GetHashCode();

                if (this.IsParked != null)
                    hash = hash * 59 + this.IsParked.GetHashCode();

                if (this.AgentEmpathyScore != null)
                    hash = hash * 59 + this.AgentEmpathyScore.GetHashCode();

                if (this.SurveyTypes != null)
                    hash = hash * 59 + this.SurveyTypes.GetHashCode();

                if (this.SurveyResponseStatuses != null)
                    hash = hash * 59 + this.SurveyResponseStatuses.GetHashCode();

                if (this.BotFlowTypes != null)
                    hash = hash * 59 + this.BotFlowTypes.GetHashCode();

                if (this.AgentTalkDurationMilliseconds != null)
                    hash = hash * 59 + this.AgentTalkDurationMilliseconds.GetHashCode();

                if (this.CustomerTalkDurationMilliseconds != null)
                    hash = hash * 59 + this.CustomerTalkDurationMilliseconds.GetHashCode();

                if (this.OvertalkDurationMilliseconds != null)
                    hash = hash * 59 + this.OvertalkDurationMilliseconds.GetHashCode();

                if (this.SilenceDurationMilliseconds != null)
                    hash = hash * 59 + this.SilenceDurationMilliseconds.GetHashCode();

                if (this.AcdDurationMilliseconds != null)
                    hash = hash * 59 + this.AcdDurationMilliseconds.GetHashCode();

                if (this.IvrDurationMilliseconds != null)
                    hash = hash * 59 + this.IvrDurationMilliseconds.GetHashCode();

                if (this.OtherDurationMilliseconds != null)
                    hash = hash * 59 + this.OtherDurationMilliseconds.GetHashCode();

                if (this.AgentTalkPercentage != null)
                    hash = hash * 59 + this.AgentTalkPercentage.GetHashCode();

                if (this.CustomerTalkPercentage != null)
                    hash = hash * 59 + this.CustomerTalkPercentage.GetHashCode();

                if (this.OvertalkPercentage != null)
                    hash = hash * 59 + this.OvertalkPercentage.GetHashCode();

                if (this.SilencePercentage != null)
                    hash = hash * 59 + this.SilencePercentage.GetHashCode();

                if (this.AcdPercentage != null)
                    hash = hash * 59 + this.AcdPercentage.GetHashCode();

                if (this.IvrPercentage != null)
                    hash = hash * 59 + this.IvrPercentage.GetHashCode();

                if (this.OtherPercentage != null)
                    hash = hash * 59 + this.OtherPercentage.GetHashCode();

                if (this.OvertalkInstances != null)
                    hash = hash * 59 + this.OvertalkInstances.GetHashCode();

                if (this.IsScreenRecorded != null)
                    hash = hash * 59 + this.IsScreenRecorded.GetHashCode();

                if (this.ScreenMonitorUserIds != null)
                    hash = hash * 59 + this.ScreenMonitorUserIds.GetHashCode();

                if (this.DashboardState != null)
                    hash = hash * 59 + this.DashboardState.GetHashCode();

                if (this.DashboardType != null)
                    hash = hash * 59 + this.DashboardType.GetHashCode();

                if (this.DashboardAccessFilter != null)
                    hash = hash * 59 + this.DashboardAccessFilter.GetHashCode();

                if (this.TranscriptDurationMilliseconds != null)
                    hash = hash * 59 + this.TranscriptDurationMilliseconds.GetHashCode();

                if (this.WorkitemsStatuses != null)
                    hash = hash * 59 + this.WorkitemsStatuses.GetHashCode();

                if (this.SocialCountries != null)
                    hash = hash * 59 + this.SocialCountries.GetHashCode();

                if (this.SocialLanguages != null)
                    hash = hash * 59 + this.SocialLanguages.GetHashCode();

                if (this.SocialChannels != null)
                    hash = hash * 59 + this.SocialChannels.GetHashCode();

                if (this.SocialSentimentCategory != null)
                    hash = hash * 59 + this.SocialSentimentCategory.GetHashCode();

                if (this.SocialTopicIds != null)
                    hash = hash * 59 + this.SocialTopicIds.GetHashCode();

                if (this.SocialIngestionRuleIds != null)
                    hash = hash * 59 + this.SocialIngestionRuleIds.GetHashCode();

                if (this.SocialConversationCreated != null)
                    hash = hash * 59 + this.SocialConversationCreated.GetHashCode();

                if (this.SocialContentType != null)
                    hash = hash * 59 + this.SocialContentType.GetHashCode();

                if (this.SocialKeywords != null)
                    hash = hash * 59 + this.SocialKeywords.GetHashCode();

                if (this.SocialPostEscalated != null)
                    hash = hash * 59 + this.SocialPostEscalated.GetHashCode();

                if (this.SocialClassifications != null)
                    hash = hash * 59 + this.SocialClassifications.GetHashCode();

                if (this.FilterUsersByManagerIds != null)
                    hash = hash * 59 + this.FilterUsersByManagerIds.GetHashCode();

                if (this.SlideshowIds != null)
                    hash = hash * 59 + this.SlideshowIds.GetHashCode();

                if (this.Conferenced != null)
                    hash = hash * 59 + this.Conferenced.GetHashCode();

                if (this.Video != null)
                    hash = hash * 59 + this.Video.GetHashCode();

                if (this.LinkedInteraction != null)
                    hash = hash * 59 + this.LinkedInteraction.GetHashCode();

                if (this.RecommendationSources != null)
                    hash = hash * 59 + this.RecommendationSources.GetHashCode();

                if (this.EvaluationRole != null)
                    hash = hash * 59 + this.EvaluationRole.GetHashCode();

                if (this.ComparisonQueueIds != null)
                    hash = hash * 59 + this.ComparisonQueueIds.GetHashCode();

                if (this.ViewMetrics != null)
                    hash = hash * 59 + this.ViewMetrics.GetHashCode();

                if (this.TimelineCategories != null)
                    hash = hash * 59 + this.TimelineCategories.GetHashCode();

                return hash;
            }
        }
    }

}
