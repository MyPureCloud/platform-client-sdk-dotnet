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
    /// The response for QueryCapabilities which contains the allowed criteria, flow types and action types for the organization.
    /// </summary>
    [DataContract]
    public partial class FlowsQueryCriteriaResponse :  IEquatable<FlowsQueryCriteriaResponse>
    {
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
        /// Gets or Sets ActionTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Actionabortsurveyinvite for "actionAbortSurveyInvite"
            /// </summary>
            [EnumMember(Value = "actionAbortSurveyInvite")]
            Actionabortsurveyinvite,
            
            /// <summary>
            /// Enum Actionaddflowmilestone for "actionAddFlowMilestone"
            /// </summary>
            [EnumMember(Value = "actionAddFlowMilestone")]
            Actionaddflowmilestone,
            
            /// <summary>
            /// Enum Actionaskforboolean for "actionAskForBoolean"
            /// </summary>
            [EnumMember(Value = "actionAskForBoolean")]
            Actionaskforboolean,
            
            /// <summary>
            /// Enum Actionaskfornluintent for "actionAskForNLUIntent"
            /// </summary>
            [EnumMember(Value = "actionAskForNLUIntent")]
            Actionaskfornluintent,
            
            /// <summary>
            /// Enum Actionaskfornlunextintent for "actionAskForNLUNextIntent"
            /// </summary>
            [EnumMember(Value = "actionAskForNLUNextIntent")]
            Actionaskfornlunextintent,
            
            /// <summary>
            /// Enum Actionaskforslot for "actionAskForSlot"
            /// </summary>
            [EnumMember(Value = "actionAskForSlot")]
            Actionaskforslot,
            
            /// <summary>
            /// Enum Actioncallbotconnector for "actionCallBotConnector"
            /// </summary>
            [EnumMember(Value = "actionCallBotConnector")]
            Actioncallbotconnector,
            
            /// <summary>
            /// Enum Actioncallbotflow for "actionCallBotFlow"
            /// </summary>
            [EnumMember(Value = "actionCallBotFlow")]
            Actioncallbotflow,
            
            /// <summary>
            /// Enum Actioncallcommonmodule for "actionCallCommonModule"
            /// </summary>
            [EnumMember(Value = "actionCallCommonModule")]
            Actioncallcommonmodule,
            
            /// <summary>
            /// Enum Actioncalldata for "actionCallData"
            /// </summary>
            [EnumMember(Value = "actionCallData")]
            Actioncalldata,
            
            /// <summary>
            /// Enum Actioncalldatasecure for "actionCallDataSecure"
            /// </summary>
            [EnumMember(Value = "actionCallDataSecure")]
            Actioncalldatasecure,
            
            /// <summary>
            /// Enum Actioncalldialogenginebot for "actionCallDialogEngineBot"
            /// </summary>
            [EnumMember(Value = "actionCallDialogEngineBot")]
            Actioncalldialogenginebot,
            
            /// <summary>
            /// Enum Actioncalldialogflowbot for "actionCallDialogflowBot"
            /// </summary>
            [EnumMember(Value = "actionCallDialogflowBot")]
            Actioncalldialogflowbot,
            
            /// <summary>
            /// Enum Actioncalldialogflowcxbot for "actionCallDialogflowCxBot"
            /// </summary>
            [EnumMember(Value = "actionCallDialogflowCxBot")]
            Actioncalldialogflowcxbot,
            
            /// <summary>
            /// Enum Actioncalldigitalbotflow for "actionCallDigitalBotFlow"
            /// </summary>
            [EnumMember(Value = "actionCallDigitalBotFlow")]
            Actioncalldigitalbotflow,
            
            /// <summary>
            /// Enum Actioncalllexbot for "actionCallLexBot"
            /// </summary>
            [EnumMember(Value = "actionCallLexBot")]
            Actioncalllexbot,
            
            /// <summary>
            /// Enum Actioncalllexv2bot for "actionCallLexV2Bot"
            /// </summary>
            [EnumMember(Value = "actionCallLexV2Bot")]
            Actioncalllexv2bot,
            
            /// <summary>
            /// Enum Actioncallnuancemixbot for "actionCallNuanceMixBot"
            /// </summary>
            [EnumMember(Value = "actionCallNuanceMixBot")]
            Actioncallnuancemixbot,
            
            /// <summary>
            /// Enum Actioncalltask for "actionCallTask"
            /// </summary>
            [EnumMember(Value = "actionCallTask")]
            Actioncalltask,
            
            /// <summary>
            /// Enum Actionchangestate for "actionChangeState"
            /// </summary>
            [EnumMember(Value = "actionChangeState")]
            Actionchangestate,
            
            /// <summary>
            /// Enum Actionclearslot for "actionClearSlot"
            /// </summary>
            [EnumMember(Value = "actionClearSlot")]
            Actionclearslot,
            
            /// <summary>
            /// Enum Actionclearvoicemailsnippet for "actionClearVoicemailSnippet"
            /// </summary>
            [EnumMember(Value = "actionClearVoicemailSnippet")]
            Actionclearvoicemailsnippet,
            
            /// <summary>
            /// Enum Actioncollectinput for "actionCollectInput"
            /// </summary>
            [EnumMember(Value = "actionCollectInput")]
            Actioncollectinput,
            
            /// <summary>
            /// Enum Actioncommunicate for "actionCommunicate"
            /// </summary>
            [EnumMember(Value = "actionCommunicate")]
            Actioncommunicate,
            
            /// <summary>
            /// Enum Actioncompletesurveyinvite for "actionCompleteSurveyInvite"
            /// </summary>
            [EnumMember(Value = "actionCompleteSurveyInvite")]
            Actioncompletesurveyinvite,
            
            /// <summary>
            /// Enum Actioncreatecallback for "actionCreateCallback"
            /// </summary>
            [EnumMember(Value = "actionCreateCallback")]
            Actioncreatecallback,
            
            /// <summary>
            /// Enum Actiondatatablelookup for "actionDataTableLookup"
            /// </summary>
            [EnumMember(Value = "actionDataTableLookup")]
            Actiondatatablelookup,
            
            /// <summary>
            /// Enum Actiondecision for "actionDecision"
            /// </summary>
            [EnumMember(Value = "actionDecision")]
            Actiondecision,
            
            /// <summary>
            /// Enum Actiondecryptdata for "actionDecryptData"
            /// </summary>
            [EnumMember(Value = "actionDecryptData")]
            Actiondecryptdata,
            
            /// <summary>
            /// Enum Actiondetectsilence for "actionDetectSilence"
            /// </summary>
            [EnumMember(Value = "actionDetectSilence")]
            Actiondetectsilence,
            
            /// <summary>
            /// Enum Actiondialextension for "actionDialExtension"
            /// </summary>
            [EnumMember(Value = "actionDialExtension")]
            Actiondialextension,
            
            /// <summary>
            /// Enum Actiondialname for "actionDialName"
            /// </summary>
            [EnumMember(Value = "actionDialName")]
            Actiondialname,
            
            /// <summary>
            /// Enum Actiondigitalmenu for "actionDigitalMenu"
            /// </summary>
            [EnumMember(Value = "actionDigitalMenu")]
            Actiondigitalmenu,
            
            /// <summary>
            /// Enum Actiondisconnect for "actionDisconnect"
            /// </summary>
            [EnumMember(Value = "actionDisconnect")]
            Actiondisconnect,
            
            /// <summary>
            /// Enum Actionenableparticipantrecord for "actionEnableParticipantRecord"
            /// </summary>
            [EnumMember(Value = "actionEnableParticipantRecord")]
            Actionenableparticipantrecord,
            
            /// <summary>
            /// Enum Actionencryptdata for "actionEncryptData"
            /// </summary>
            [EnumMember(Value = "actionEncryptData")]
            Actionencryptdata,
            
            /// <summary>
            /// Enum Actionendstate for "actionEndState"
            /// </summary>
            [EnumMember(Value = "actionEndState")]
            Actionendstate,
            
            /// <summary>
            /// Enum Actionendtask for "actionEndTask"
            /// </summary>
            [EnumMember(Value = "actionEndTask")]
            Actionendtask,
            
            /// <summary>
            /// Enum Actionendworkflow for "actionEndWorkflow"
            /// </summary>
            [EnumMember(Value = "actionEndWorkflow")]
            Actionendworkflow,
            
            /// <summary>
            /// Enum Actionevaluateschedule for "actionEvaluateSchedule"
            /// </summary>
            [EnumMember(Value = "actionEvaluateSchedule")]
            Actionevaluateschedule,
            
            /// <summary>
            /// Enum Actionevaluateschedulegroup for "actionEvaluateScheduleGroup"
            /// </summary>
            [EnumMember(Value = "actionEvaluateScheduleGroup")]
            Actionevaluateschedulegroup,
            
            /// <summary>
            /// Enum Actionexitbotflow for "actionExitBotFlow"
            /// </summary>
            [EnumMember(Value = "actionExitBotFlow")]
            Actionexitbotflow,
            
            /// <summary>
            /// Enum Actionexitloop for "actionExitLoop"
            /// </summary>
            [EnumMember(Value = "actionExitLoop")]
            Actionexitloop,
            
            /// <summary>
            /// Enum Actionextractsecuredata for "actionExtractSecureData"
            /// </summary>
            [EnumMember(Value = "actionExtractSecureData")]
            Actionextractsecuredata,
            
            /// <summary>
            /// Enum Actionfindemergencygroup for "actionFindEmergencyGroup"
            /// </summary>
            [EnumMember(Value = "actionFindEmergencyGroup")]
            Actionfindemergencygroup,
            
            /// <summary>
            /// Enum Actionfindgroup for "actionFindGroup"
            /// </summary>
            [EnumMember(Value = "actionFindGroup")]
            Actionfindgroup,
            
            /// <summary>
            /// Enum Actionfindlanguageskill for "actionFindLanguageSkill"
            /// </summary>
            [EnumMember(Value = "actionFindLanguageSkill")]
            Actionfindlanguageskill,
            
            /// <summary>
            /// Enum Actionfindqueue for "actionFindQueue"
            /// </summary>
            [EnumMember(Value = "actionFindQueue")]
            Actionfindqueue,
            
            /// <summary>
            /// Enum Actionfindqueuebyid for "actionFindQueueById"
            /// </summary>
            [EnumMember(Value = "actionFindQueueById")]
            Actionfindqueuebyid,
            
            /// <summary>
            /// Enum Actionfindschedule for "actionFindSchedule"
            /// </summary>
            [EnumMember(Value = "actionFindSchedule")]
            Actionfindschedule,
            
            /// <summary>
            /// Enum Actionfindschedulegroup for "actionFindScheduleGroup"
            /// </summary>
            [EnumMember(Value = "actionFindScheduleGroup")]
            Actionfindschedulegroup,
            
            /// <summary>
            /// Enum Actionfindskill for "actionFindSkill"
            /// </summary>
            [EnumMember(Value = "actionFindSkill")]
            Actionfindskill,
            
            /// <summary>
            /// Enum Actionfindsystemprompt for "actionFindSystemPrompt"
            /// </summary>
            [EnumMember(Value = "actionFindSystemPrompt")]
            Actionfindsystemprompt,
            
            /// <summary>
            /// Enum Actionfinduser for "actionFindUser"
            /// </summary>
            [EnumMember(Value = "actionFindUser")]
            Actionfinduser,
            
            /// <summary>
            /// Enum Actionfinduserbyid for "actionFindUserById"
            /// </summary>
            [EnumMember(Value = "actionFindUserById")]
            Actionfinduserbyid,
            
            /// <summary>
            /// Enum Actionfinduserprompt for "actionFindUserPrompt"
            /// </summary>
            [EnumMember(Value = "actionFindUserPrompt")]
            Actionfinduserprompt,
            
            /// <summary>
            /// Enum Actionfindusersbyid for "actionFindUsersById"
            /// </summary>
            [EnumMember(Value = "actionFindUsersById")]
            Actionfindusersbyid,
            
            /// <summary>
            /// Enum Actionflushaudio for "actionFlushAudio"
            /// </summary>
            [EnumMember(Value = "actionFlushAudio")]
            Actionflushaudio,
            
            /// <summary>
            /// Enum Actiongetconversationdata for "actionGetConversationData"
            /// </summary>
            [EnumMember(Value = "actionGetConversationData")]
            Actiongetconversationdata,
            
            /// <summary>
            /// Enum Actiongetexternalcontact for "actionGetExternalContact"
            /// </summary>
            [EnumMember(Value = "actionGetExternalContact")]
            Actiongetexternalcontact,
            
            /// <summary>
            /// Enum Actiongetexternalorganization for "actionGetExternalOrganization"
            /// </summary>
            [EnumMember(Value = "actionGetExternalOrganization")]
            Actiongetexternalorganization,
            
            /// <summary>
            /// Enum Actiongetjourneyoutcome for "actionGetJourneyOutcome"
            /// </summary>
            [EnumMember(Value = "actionGetJourneyOutcome")]
            Actiongetjourneyoutcome,
            
            /// <summary>
            /// Enum Actiongetjourneyoutcomescoresbysession for "actionGetJourneyOutcomeScoresBySession"
            /// </summary>
            [EnumMember(Value = "actionGetJourneyOutcomeScoresBySession")]
            Actiongetjourneyoutcomescoresbysession,
            
            /// <summary>
            /// Enum Actiongetjourneysegment for "actionGetJourneySegment"
            /// </summary>
            [EnumMember(Value = "actionGetJourneySegment")]
            Actiongetjourneysegment,
            
            /// <summary>
            /// Enum Actiongetjourneysession for "actionGetJourneySession"
            /// </summary>
            [EnumMember(Value = "actionGetJourneySession")]
            Actiongetjourneysession,
            
            /// <summary>
            /// Enum Actiongetjourneysessionsbycustomer for "actionGetJourneySessionsByCustomer"
            /// </summary>
            [EnumMember(Value = "actionGetJourneySessionsByCustomer")]
            Actiongetjourneysessionsbycustomer,
            
            /// <summary>
            /// Enum Actiongetjourneysessionsbyexternalcontact for "actionGetJourneySessionsByExternalContact"
            /// </summary>
            [EnumMember(Value = "actionGetJourneySessionsByExternalContact")]
            Actiongetjourneysessionsbyexternalcontact,
            
            /// <summary>
            /// Enum Actiongetparticipantdata for "actionGetParticipantData"
            /// </summary>
            [EnumMember(Value = "actionGetParticipantData")]
            Actiongetparticipantdata,
            
            /// <summary>
            /// Enum Actiongetresponse for "actionGetResponse"
            /// </summary>
            [EnumMember(Value = "actionGetResponse")]
            Actiongetresponse,
            
            /// <summary>
            /// Enum Actiongetsecureddata for "actionGetSecuredData"
            /// </summary>
            [EnumMember(Value = "actionGetSecuredData")]
            Actiongetsecureddata,
            
            /// <summary>
            /// Enum Actionholdmusic for "actionHoldMusic"
            /// </summary>
            [EnumMember(Value = "actionHoldMusic")]
            Actionholdmusic,
            
            /// <summary>
            /// Enum Actioninitializeflowoutcome for "actionInitializeFlowOutcome"
            /// </summary>
            [EnumMember(Value = "actionInitializeFlowOutcome")]
            Actioninitializeflowoutcome,
            
            /// <summary>
            /// Enum Actionjumptomenu for "actionJumpToMenu"
            /// </summary>
            [EnumMember(Value = "actionJumpToMenu")]
            Actionjumptomenu,
            
            /// <summary>
            /// Enum Actionjumptotask for "actionJumpToTask"
            /// </summary>
            [EnumMember(Value = "actionJumpToTask")]
            Actionjumptotask,
            
            /// <summary>
            /// Enum Actionloop for "actionLoop"
            /// </summary>
            [EnumMember(Value = "actionLoop")]
            Actionloop,
            
            /// <summary>
            /// Enum Actionloopuntil for "actionLoopUntil"
            /// </summary>
            [EnumMember(Value = "actionLoopUntil")]
            Actionloopuntil,
            
            /// <summary>
            /// Enum Actionnextloop for "actionNextLoop"
            /// </summary>
            [EnumMember(Value = "actionNextLoop")]
            Actionnextloop,
            
            /// <summary>
            /// Enum Actionplayaudio for "actionPlayAudio"
            /// </summary>
            [EnumMember(Value = "actionPlayAudio")]
            Actionplayaudio,
            
            /// <summary>
            /// Enum Actionplayaudioonsilence for "actionPlayAudioOnSilence"
            /// </summary>
            [EnumMember(Value = "actionPlayAudioOnSilence")]
            Actionplayaudioonsilence,
            
            /// <summary>
            /// Enum Actionplayestimatedwaittime for "actionPlayEstimatedWaitTime"
            /// </summary>
            [EnumMember(Value = "actionPlayEstimatedWaitTime")]
            Actionplayestimatedwaittime,
            
            /// <summary>
            /// Enum Actionplaypositioninqueue for "actionPlayPositionInQueue"
            /// </summary>
            [EnumMember(Value = "actionPlayPositionInQueue")]
            Actionplaypositioninqueue,
            
            /// <summary>
            /// Enum Actionplayusergreeting for "actionPlayUserGreeting"
            /// </summary>
            [EnumMember(Value = "actionPlayUserGreeting")]
            Actionplayusergreeting,
            
            /// <summary>
            /// Enum Actionplayusername for "actionPlayUserName"
            /// </summary>
            [EnumMember(Value = "actionPlayUserName")]
            Actionplayusername,
            
            /// <summary>
            /// Enum Actionpreviousmenu for "actionPreviousMenu"
            /// </summary>
            [EnumMember(Value = "actionPreviousMenu")]
            Actionpreviousmenu,
            
            /// <summary>
            /// Enum Actionprocessvoicemailinput for "actionProcessVoicemailInput"
            /// </summary>
            [EnumMember(Value = "actionProcessVoicemailInput")]
            Actionprocessvoicemailinput,
            
            /// <summary>
            /// Enum Actionrepeatmenu for "actionRepeatMenu"
            /// </summary>
            [EnumMember(Value = "actionRepeatMenu")]
            Actionrepeatmenu,
            
            /// <summary>
            /// Enum Actionreturntoagent for "actionReturnToAgent"
            /// </summary>
            [EnumMember(Value = "actionReturnToAgent")]
            Actionreturntoagent,
            
            /// <summary>
            /// Enum Actionsaveworkitem for "actionSaveWorkitem"
            /// </summary>
            [EnumMember(Value = "actionSaveWorkitem")]
            Actionsaveworkitem,
            
            /// <summary>
            /// Enum Actionscreenpop for "actionScreenPop"
            /// </summary>
            [EnumMember(Value = "actionScreenPop")]
            Actionscreenpop,
            
            /// <summary>
            /// Enum Actionsearchexternalcontacts for "actionSearchExternalContacts"
            /// </summary>
            [EnumMember(Value = "actionSearchExternalContacts")]
            Actionsearchexternalcontacts,
            
            /// <summary>
            /// Enum Actionsendautoreply for "actionSendAutoReply"
            /// </summary>
            [EnumMember(Value = "actionSendAutoReply")]
            Actionsendautoreply,
            
            /// <summary>
            /// Enum Actionsendresponse for "actionSendResponse"
            /// </summary>
            [EnumMember(Value = "actionSendResponse")]
            Actionsendresponse,
            
            /// <summary>
            /// Enum Actionsetactiveintent for "actionSetActiveIntent"
            /// </summary>
            [EnumMember(Value = "actionSetActiveIntent")]
            Actionsetactiveintent,
            
            /// <summary>
            /// Enum Actionsetconversationdata for "actionSetConversationData"
            /// </summary>
            [EnumMember(Value = "actionSetConversationData")]
            Actionsetconversationdata,
            
            /// <summary>
            /// Enum Actionsetexternaltag for "actionSetExternalTag"
            /// </summary>
            [EnumMember(Value = "actionSetExternalTag")]
            Actionsetexternaltag,
            
            /// <summary>
            /// Enum Actionsetflowoutcome for "actionSetFlowOutcome"
            /// </summary>
            [EnumMember(Value = "actionSetFlowOutcome")]
            Actionsetflowoutcome,
            
            /// <summary>
            /// Enum Actionsetlocale for "actionSetLocale"
            /// </summary>
            [EnumMember(Value = "actionSetLocale")]
            Actionsetlocale,
            
            /// <summary>
            /// Enum Actionsetparticipantdata for "actionSetParticipantData"
            /// </summary>
            [EnumMember(Value = "actionSetParticipantData")]
            Actionsetparticipantdata,
            
            /// <summary>
            /// Enum Actionsetpriority for "actionSetPriority"
            /// </summary>
            [EnumMember(Value = "actionSetPriority")]
            Actionsetpriority,
            
            /// <summary>
            /// Enum Actionsetsecureddata for "actionSetSecuredData"
            /// </summary>
            [EnumMember(Value = "actionSetSecuredData")]
            Actionsetsecureddata,
            
            /// <summary>
            /// Enum Actionsetskills for "actionSetSkills"
            /// </summary>
            [EnumMember(Value = "actionSetSkills")]
            Actionsetskills,
            
            /// <summary>
            /// Enum Actionsetuuidata for "actionSetUUIData"
            /// </summary>
            [EnumMember(Value = "actionSetUUIData")]
            Actionsetuuidata,
            
            /// <summary>
            /// Enum Actionsetwhisperaudio for "actionSetWhisperAudio"
            /// </summary>
            [EnumMember(Value = "actionSetWhisperAudio")]
            Actionsetwhisperaudio,
            
            /// <summary>
            /// Enum Actionsetwrapupcode for "actionSetWrapupCode"
            /// </summary>
            [EnumMember(Value = "actionSetWrapupCode")]
            Actionsetwrapupcode,
            
            /// <summary>
            /// Enum Actionshowknowledgearticle for "actionShowKnowledgeArticle"
            /// </summary>
            [EnumMember(Value = "actionShowKnowledgeArticle")]
            Actionshowknowledgearticle,
            
            /// <summary>
            /// Enum Actionsubmitvoicemailsnippet for "actionSubmitVoicemailSnippet"
            /// </summary>
            [EnumMember(Value = "actionSubmitVoicemailSnippet")]
            Actionsubmitvoicemailsnippet,
            
            /// <summary>
            /// Enum Actionswitch for "actionSwitch"
            /// </summary>
            [EnumMember(Value = "actionSwitch")]
            Actionswitch,
            
            /// <summary>
            /// Enum Actiontranscription for "actionTranscription"
            /// </summary>
            [EnumMember(Value = "actionTranscription")]
            Actiontranscription,
            
            /// <summary>
            /// Enum Actiontransferexternal for "actionTransferExternal"
            /// </summary>
            [EnumMember(Value = "actionTransferExternal")]
            Actiontransferexternal,
            
            /// <summary>
            /// Enum Actiontransferflow for "actionTransferFlow"
            /// </summary>
            [EnumMember(Value = "actionTransferFlow")]
            Actiontransferflow,
            
            /// <summary>
            /// Enum Actiontransferflowsecure for "actionTransferFlowSecure"
            /// </summary>
            [EnumMember(Value = "actionTransferFlowSecure")]
            Actiontransferflowsecure,
            
            /// <summary>
            /// Enum Actiontransfergroup for "actionTransferGroup"
            /// </summary>
            [EnumMember(Value = "actionTransferGroup")]
            Actiontransfergroup,
            
            /// <summary>
            /// Enum Actiontransfertoacd for "actionTransferToAcd"
            /// </summary>
            [EnumMember(Value = "actionTransferToAcd")]
            Actiontransfertoacd,
            
            /// <summary>
            /// Enum Actiontransferuser for "actionTransferUser"
            /// </summary>
            [EnumMember(Value = "actionTransferUser")]
            Actiontransferuser,
            
            /// <summary>
            /// Enum Actiontransfervoicemail for "actionTransferVoicemail"
            /// </summary>
            [EnumMember(Value = "actionTransferVoicemail")]
            Actiontransfervoicemail,
            
            /// <summary>
            /// Enum Actionupdatedata for "actionUpdateData"
            /// </summary>
            [EnumMember(Value = "actionUpdateData")]
            Actionupdatedata,
            
            /// <summary>
            /// Enum Actionwait for "actionWait"
            /// </summary>
            [EnumMember(Value = "actionWait")]
            Actionwait,
            
            /// <summary>
            /// Enum Actionwaitforinput for "actionWaitForInput"
            /// </summary>
            [EnumMember(Value = "actionWaitForInput")]
            Actionwaitforinput,
            
            /// <summary>
            /// Enum Menudialextension for "menuDialExtension"
            /// </summary>
            [EnumMember(Value = "menuDialExtension")]
            Menudialextension,
            
            /// <summary>
            /// Enum Menudialname for "menuDialName"
            /// </summary>
            [EnumMember(Value = "menuDialName")]
            Menudialname,
            
            /// <summary>
            /// Enum Menudisconnect for "menuDisconnect"
            /// </summary>
            [EnumMember(Value = "menuDisconnect")]
            Menudisconnect,
            
            /// <summary>
            /// Enum Menujumptomenu for "menuJumpToMenu"
            /// </summary>
            [EnumMember(Value = "menuJumpToMenu")]
            Menujumptomenu,
            
            /// <summary>
            /// Enum Menujumptotask for "menuJumpToTask"
            /// </summary>
            [EnumMember(Value = "menuJumpToTask")]
            Menujumptotask,
            
            /// <summary>
            /// Enum Menumenu for "menuMenu"
            /// </summary>
            [EnumMember(Value = "menuMenu")]
            Menumenu,
            
            /// <summary>
            /// Enum Menupreviousmenu for "menuPreviousMenu"
            /// </summary>
            [EnumMember(Value = "menuPreviousMenu")]
            Menupreviousmenu,
            
            /// <summary>
            /// Enum Menurepeatmenu for "menuRepeatMenu"
            /// </summary>
            [EnumMember(Value = "menuRepeatMenu")]
            Menurepeatmenu,
            
            /// <summary>
            /// Enum Menushowknowledgearticle for "menuShowKnowledgeArticle"
            /// </summary>
            [EnumMember(Value = "menuShowKnowledgeArticle")]
            Menushowknowledgearticle,
            
            /// <summary>
            /// Enum Menutask for "menuTask"
            /// </summary>
            [EnumMember(Value = "menuTask")]
            Menutask,
            
            /// <summary>
            /// Enum Menutransfertoacd for "menuTransferToAcd"
            /// </summary>
            [EnumMember(Value = "menuTransferToAcd")]
            Menutransfertoacd,
            
            /// <summary>
            /// Enum Menutransferflow for "menuTransferFlow"
            /// </summary>
            [EnumMember(Value = "menuTransferFlow")]
            Menutransferflow,
            
            /// <summary>
            /// Enum Menutransfergroup for "menuTransferGroup"
            /// </summary>
            [EnumMember(Value = "menuTransferGroup")]
            Menutransfergroup,
            
            /// <summary>
            /// Enum Menutransferexternal for "menuTransferExternal"
            /// </summary>
            [EnumMember(Value = "menuTransferExternal")]
            Menutransferexternal,
            
            /// <summary>
            /// Enum Menutransferflowsecure for "menuTransferFlowSecure"
            /// </summary>
            [EnumMember(Value = "menuTransferFlowSecure")]
            Menutransferflowsecure,
            
            /// <summary>
            /// Enum Menutransferuser for "menuTransferUser"
            /// </summary>
            [EnumMember(Value = "menuTransferUser")]
            Menutransferuser,
            
            /// <summary>
            /// Enum Menutransfervoicemail for "menuTransferVoicemail"
            /// </summary>
            [EnumMember(Value = "menuTransferVoicemail")]
            Menutransfervoicemail
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowsQueryCriteriaResponse" /> class.
        /// </summary>
        /// <param name="Criteria">The is a list of allowed criteria to query on..</param>
        /// <param name="FlowTypes">The is a list of flow types the organization has access to..</param>
        /// <param name="ActionTypes">The is a list of action types the organization has access to..</param>
        /// <param name="ErrorCodes">The is a list of potential error codes the organization may encounter..</param>
        /// <param name="WarningCodes">The is a list of potential warning codes the organization may encounter..</param>
        public FlowsQueryCriteriaResponse(List<QueryCriteria> Criteria = null, List<FlowTypesEnum> FlowTypes = null, List<ActionTypesEnum> ActionTypes = null, List<string> ErrorCodes = null, List<string> WarningCodes = null)
        {
            this.Criteria = Criteria;
            this.FlowTypes = FlowTypes;
            this.ActionTypes = ActionTypes;
            this.ErrorCodes = ErrorCodes;
            this.WarningCodes = WarningCodes;
            
        }
        


        /// <summary>
        /// The is a list of allowed criteria to query on.
        /// </summary>
        /// <value>The is a list of allowed criteria to query on.</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public List<QueryCriteria> Criteria { get; set; }



        /// <summary>
        /// The is a list of flow types the organization has access to.
        /// </summary>
        /// <value>The is a list of flow types the organization has access to.</value>
        [DataMember(Name="flowTypes", EmitDefaultValue=false)]
        public List<FlowTypesEnum> FlowTypes { get; set; }



        /// <summary>
        /// The is a list of action types the organization has access to.
        /// </summary>
        /// <value>The is a list of action types the organization has access to.</value>
        [DataMember(Name="actionTypes", EmitDefaultValue=false)]
        public List<ActionTypesEnum> ActionTypes { get; set; }



        /// <summary>
        /// The is a list of potential error codes the organization may encounter.
        /// </summary>
        /// <value>The is a list of potential error codes the organization may encounter.</value>
        [DataMember(Name="errorCodes", EmitDefaultValue=false)]
        public List<string> ErrorCodes { get; set; }



        /// <summary>
        /// The is a list of potential warning codes the organization may encounter.
        /// </summary>
        /// <value>The is a list of potential warning codes the organization may encounter.</value>
        [DataMember(Name="warningCodes", EmitDefaultValue=false)]
        public List<string> WarningCodes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowsQueryCriteriaResponse {\n");

            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  FlowTypes: ").Append(FlowTypes).Append("\n");
            sb.Append("  ActionTypes: ").Append(ActionTypes).Append("\n");
            sb.Append("  ErrorCodes: ").Append(ErrorCodes).Append("\n");
            sb.Append("  WarningCodes: ").Append(WarningCodes).Append("\n");
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
            return this.Equals(obj as FlowsQueryCriteriaResponse);
        }

        /// <summary>
        /// Returns true if FlowsQueryCriteriaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowsQueryCriteriaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowsQueryCriteriaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.SequenceEqual(other.Criteria)
                ) &&
                (
                    this.FlowTypes == other.FlowTypes ||
                    this.FlowTypes != null &&
                    this.FlowTypes.SequenceEqual(other.FlowTypes)
                ) &&
                (
                    this.ActionTypes == other.ActionTypes ||
                    this.ActionTypes != null &&
                    this.ActionTypes.SequenceEqual(other.ActionTypes)
                ) &&
                (
                    this.ErrorCodes == other.ErrorCodes ||
                    this.ErrorCodes != null &&
                    this.ErrorCodes.SequenceEqual(other.ErrorCodes)
                ) &&
                (
                    this.WarningCodes == other.WarningCodes ||
                    this.WarningCodes != null &&
                    this.WarningCodes.SequenceEqual(other.WarningCodes)
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
                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();

                if (this.FlowTypes != null)
                    hash = hash * 59 + this.FlowTypes.GetHashCode();

                if (this.ActionTypes != null)
                    hash = hash * 59 + this.ActionTypes.GetHashCode();

                if (this.ErrorCodes != null)
                    hash = hash * 59 + this.ErrorCodes.GetHashCode();

                if (this.WarningCodes != null)
                    hash = hash * 59 + this.WarningCodes.GetHashCode();

                return hash;
            }
        }
    }

}
