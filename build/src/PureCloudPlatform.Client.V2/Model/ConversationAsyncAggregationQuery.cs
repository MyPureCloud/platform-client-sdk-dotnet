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
    /// ConversationAsyncAggregationQuery
    /// </summary>
    [DataContract]
    public partial class ConversationAsyncAggregationQuery :  IEquatable<ConversationAsyncAggregationQuery>
    {
        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GroupByEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Activerouting for "activeRouting"
            /// </summary>
            [EnumMember(Value = "activeRouting")]
            Activerouting,
            
            /// <summary>
            /// Enum Activeskillid for "activeSkillId"
            /// </summary>
            [EnumMember(Value = "activeSkillId")]
            Activeskillid,
            
            /// <summary>
            /// Enum Addressfrom for "addressFrom"
            /// </summary>
            [EnumMember(Value = "addressFrom")]
            Addressfrom,
            
            /// <summary>
            /// Enum Addressto for "addressTo"
            /// </summary>
            [EnumMember(Value = "addressTo")]
            Addressto,
            
            /// <summary>
            /// Enum Agentassistantid for "agentAssistantId"
            /// </summary>
            [EnumMember(Value = "agentAssistantId")]
            Agentassistantid,
            
            /// <summary>
            /// Enum Agentbullseyering for "agentBullseyeRing"
            /// </summary>
            [EnumMember(Value = "agentBullseyeRing")]
            Agentbullseyering,
            
            /// <summary>
            /// Enum Agentowned for "agentOwned"
            /// </summary>
            [EnumMember(Value = "agentOwned")]
            Agentowned,
            
            /// <summary>
            /// Enum Agentrank for "agentRank"
            /// </summary>
            [EnumMember(Value = "agentRank")]
            Agentrank,
            
            /// <summary>
            /// Enum Agentscore for "agentScore"
            /// </summary>
            [EnumMember(Value = "agentScore")]
            Agentscore,
            
            /// <summary>
            /// Enum Ani for "ani"
            /// </summary>
            [EnumMember(Value = "ani")]
            Ani,
            
            /// <summary>
            /// Enum Assignerid for "assignerId"
            /// </summary>
            [EnumMember(Value = "assignerId")]
            Assignerid,
            
            /// <summary>
            /// Enum Authenticated for "authenticated"
            /// </summary>
            [EnumMember(Value = "authenticated")]
            Authenticated,
            
            /// <summary>
            /// Enum Conversationid for "conversationId"
            /// </summary>
            [EnumMember(Value = "conversationId")]
            Conversationid,
            
            /// <summary>
            /// Enum Conversationinitiator for "conversationInitiator"
            /// </summary>
            [EnumMember(Value = "conversationInitiator")]
            Conversationinitiator,
            
            /// <summary>
            /// Enum Convertedfrom for "convertedFrom"
            /// </summary>
            [EnumMember(Value = "convertedFrom")]
            Convertedfrom,
            
            /// <summary>
            /// Enum Convertedto for "convertedTo"
            /// </summary>
            [EnumMember(Value = "convertedTo")]
            Convertedto,
            
            /// <summary>
            /// Enum Customerparticipation for "customerParticipation"
            /// </summary>
            [EnumMember(Value = "customerParticipation")]
            Customerparticipation,
            
            /// <summary>
            /// Enum Deliverystatus for "deliveryStatus"
            /// </summary>
            [EnumMember(Value = "deliveryStatus")]
            Deliverystatus,
            
            /// <summary>
            /// Enum Destinationaddress for "destinationAddress"
            /// </summary>
            [EnumMember(Value = "destinationAddress")]
            Destinationaddress,
            
            /// <summary>
            /// Enum Direction for "direction"
            /// </summary>
            [EnumMember(Value = "direction")]
            Direction,
            
            /// <summary>
            /// Enum Disconnecttype for "disconnectType"
            /// </summary>
            [EnumMember(Value = "disconnectType")]
            Disconnecttype,
            
            /// <summary>
            /// Enum Divisionid for "divisionId"
            /// </summary>
            [EnumMember(Value = "divisionId")]
            Divisionid,
            
            /// <summary>
            /// Enum Dnis for "dnis"
            /// </summary>
            [EnumMember(Value = "dnis")]
            Dnis,
            
            /// <summary>
            /// Enum Edgeid for "edgeId"
            /// </summary>
            [EnumMember(Value = "edgeId")]
            Edgeid,
            
            /// <summary>
            /// Enum Eligibleagentcount for "eligibleAgentCount"
            /// </summary>
            [EnumMember(Value = "eligibleAgentCount")]
            Eligibleagentcount,
            
            /// <summary>
            /// Enum Errorcode for "errorCode"
            /// </summary>
            [EnumMember(Value = "errorCode")]
            Errorcode,
            
            /// <summary>
            /// Enum Extendeddeliverystatus for "extendedDeliveryStatus"
            /// </summary>
            [EnumMember(Value = "extendedDeliveryStatus")]
            Extendeddeliverystatus,
            
            /// <summary>
            /// Enum Externalcontactid for "externalContactId"
            /// </summary>
            [EnumMember(Value = "externalContactId")]
            Externalcontactid,
            
            /// <summary>
            /// Enum Externalmediacount for "externalMediaCount"
            /// </summary>
            [EnumMember(Value = "externalMediaCount")]
            Externalmediacount,
            
            /// <summary>
            /// Enum Externalorganizationid for "externalOrganizationId"
            /// </summary>
            [EnumMember(Value = "externalOrganizationId")]
            Externalorganizationid,
            
            /// <summary>
            /// Enum Externaltag for "externalTag"
            /// </summary>
            [EnumMember(Value = "externalTag")]
            Externaltag,
            
            /// <summary>
            /// Enum Firstqueue for "firstQueue"
            /// </summary>
            [EnumMember(Value = "firstQueue")]
            Firstqueue,
            
            /// <summary>
            /// Enum Flaggedreason for "flaggedReason"
            /// </summary>
            [EnumMember(Value = "flaggedReason")]
            Flaggedreason,
            
            /// <summary>
            /// Enum Flowintype for "flowInType"
            /// </summary>
            [EnumMember(Value = "flowInType")]
            Flowintype,
            
            /// <summary>
            /// Enum Flowouttype for "flowOutType"
            /// </summary>
            [EnumMember(Value = "flowOutType")]
            Flowouttype,
            
            /// <summary>
            /// Enum Groupid for "groupId"
            /// </summary>
            [EnumMember(Value = "groupId")]
            Groupid,
            
            /// <summary>
            /// Enum Interactiontype for "interactionType"
            /// </summary>
            [EnumMember(Value = "interactionType")]
            Interactiontype,
            
            /// <summary>
            /// Enum Journeyactionid for "journeyActionId"
            /// </summary>
            [EnumMember(Value = "journeyActionId")]
            Journeyactionid,
            
            /// <summary>
            /// Enum Journeyactionmapid for "journeyActionMapId"
            /// </summary>
            [EnumMember(Value = "journeyActionMapId")]
            Journeyactionmapid,
            
            /// <summary>
            /// Enum Journeyactionmapversion for "journeyActionMapVersion"
            /// </summary>
            [EnumMember(Value = "journeyActionMapVersion")]
            Journeyactionmapversion,
            
            /// <summary>
            /// Enum Journeycustomerid for "journeyCustomerId"
            /// </summary>
            [EnumMember(Value = "journeyCustomerId")]
            Journeycustomerid,
            
            /// <summary>
            /// Enum Journeycustomeridtype for "journeyCustomerIdType"
            /// </summary>
            [EnumMember(Value = "journeyCustomerIdType")]
            Journeycustomeridtype,
            
            /// <summary>
            /// Enum Journeycustomersessionid for "journeyCustomerSessionId"
            /// </summary>
            [EnumMember(Value = "journeyCustomerSessionId")]
            Journeycustomersessionid,
            
            /// <summary>
            /// Enum Journeycustomersessionidtype for "journeyCustomerSessionIdType"
            /// </summary>
            [EnumMember(Value = "journeyCustomerSessionIdType")]
            Journeycustomersessionidtype,
            
            /// <summary>
            /// Enum Knowledgebaseid for "knowledgeBaseId"
            /// </summary>
            [EnumMember(Value = "knowledgeBaseId")]
            Knowledgebaseid,
            
            /// <summary>
            /// Enum Mediacount for "mediaCount"
            /// </summary>
            [EnumMember(Value = "mediaCount")]
            Mediacount,
            
            /// <summary>
            /// Enum Mediatype for "mediaType"
            /// </summary>
            [EnumMember(Value = "mediaType")]
            Mediatype,
            
            /// <summary>
            /// Enum Messagetype for "messageType"
            /// </summary>
            [EnumMember(Value = "messageType")]
            Messagetype,
            
            /// <summary>
            /// Enum Originatingdirection for "originatingDirection"
            /// </summary>
            [EnumMember(Value = "originatingDirection")]
            Originatingdirection,
            
            /// <summary>
            /// Enum Originatingsocialmediapublic for "originatingSocialMediaPublic"
            /// </summary>
            [EnumMember(Value = "originatingSocialMediaPublic")]
            Originatingsocialmediapublic,
            
            /// <summary>
            /// Enum Outboundcampaignid for "outboundCampaignId"
            /// </summary>
            [EnumMember(Value = "outboundCampaignId")]
            Outboundcampaignid,
            
            /// <summary>
            /// Enum Outboundcontactid for "outboundContactId"
            /// </summary>
            [EnumMember(Value = "outboundContactId")]
            Outboundcontactid,
            
            /// <summary>
            /// Enum Outboundcontactlistid for "outboundContactListId"
            /// </summary>
            [EnumMember(Value = "outboundContactListId")]
            Outboundcontactlistid,
            
            /// <summary>
            /// Enum Participantname for "participantName"
            /// </summary>
            [EnumMember(Value = "participantName")]
            Participantname,
            
            /// <summary>
            /// Enum Peerid for "peerId"
            /// </summary>
            [EnumMember(Value = "peerId")]
            Peerid,
            
            /// <summary>
            /// Enum Proposedagentid for "proposedAgentId"
            /// </summary>
            [EnumMember(Value = "proposedAgentId")]
            Proposedagentid,
            
            /// <summary>
            /// Enum Provider for "provider"
            /// </summary>
            [EnumMember(Value = "provider")]
            Provider,
            
            /// <summary>
            /// Enum Purpose for "purpose"
            /// </summary>
            [EnumMember(Value = "purpose")]
            Purpose,
            
            /// <summary>
            /// Enum Queueid for "queueId"
            /// </summary>
            [EnumMember(Value = "queueId")]
            Queueid,
            
            /// <summary>
            /// Enum Remote for "remote"
            /// </summary>
            [EnumMember(Value = "remote")]
            Remote,
            
            /// <summary>
            /// Enum Removedskillid for "removedSkillId"
            /// </summary>
            [EnumMember(Value = "removedSkillId")]
            Removedskillid,
            
            /// <summary>
            /// Enum Requestedlanguageid for "requestedLanguageId"
            /// </summary>
            [EnumMember(Value = "requestedLanguageId")]
            Requestedlanguageid,
            
            /// <summary>
            /// Enum Requestedrouting for "requestedRouting"
            /// </summary>
            [EnumMember(Value = "requestedRouting")]
            Requestedrouting,
            
            /// <summary>
            /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
            /// </summary>
            [EnumMember(Value = "requestedRoutingSkillId")]
            Requestedroutingskillid,
            
            /// <summary>
            /// Enum Roomid for "roomId"
            /// </summary>
            [EnumMember(Value = "roomId")]
            Roomid,
            
            /// <summary>
            /// Enum Routingpriority for "routingPriority"
            /// </summary>
            [EnumMember(Value = "routingPriority")]
            Routingpriority,
            
            /// <summary>
            /// Enum Routingring for "routingRing"
            /// </summary>
            [EnumMember(Value = "routingRing")]
            Routingring,
            
            /// <summary>
            /// Enum Routingrule for "routingRule"
            /// </summary>
            [EnumMember(Value = "routingRule")]
            Routingrule,
            
            /// <summary>
            /// Enum Routingruletype for "routingRuleType"
            /// </summary>
            [EnumMember(Value = "routingRuleType")]
            Routingruletype,
            
            /// <summary>
            /// Enum Scoredagentid for "scoredAgentId"
            /// </summary>
            [EnumMember(Value = "scoredAgentId")]
            Scoredagentid,
            
            /// <summary>
            /// Enum Selectedagentid for "selectedAgentId"
            /// </summary>
            [EnumMember(Value = "selectedAgentId")]
            Selectedagentid,
            
            /// <summary>
            /// Enum Selectedagentrank for "selectedAgentRank"
            /// </summary>
            [EnumMember(Value = "selectedAgentRank")]
            Selectedagentrank,
            
            /// <summary>
            /// Enum Selfserved for "selfServed"
            /// </summary>
            [EnumMember(Value = "selfServed")]
            Selfserved,
            
            /// <summary>
            /// Enum Sessiondnis for "sessionDnis"
            /// </summary>
            [EnumMember(Value = "sessionDnis")]
            Sessiondnis,
            
            /// <summary>
            /// Enum Sessionid for "sessionId"
            /// </summary>
            [EnumMember(Value = "sessionId")]
            Sessionid,
            
            /// <summary>
            /// Enum Stationid for "stationId"
            /// </summary>
            [EnumMember(Value = "stationId")]
            Stationid,
            
            /// <summary>
            /// Enum Teamid for "teamId"
            /// </summary>
            [EnumMember(Value = "teamId")]
            Teamid,
            
            /// <summary>
            /// Enum Usedrouting for "usedRouting"
            /// </summary>
            [EnumMember(Value = "usedRouting")]
            Usedrouting,
            
            /// <summary>
            /// Enum Userid for "userId"
            /// </summary>
            [EnumMember(Value = "userId")]
            Userid,
            
            /// <summary>
            /// Enum Videopresent for "videoPresent"
            /// </summary>
            [EnumMember(Value = "videoPresent")]
            Videopresent,
            
            /// <summary>
            /// Enum Waitinginteractioncount for "waitingInteractionCount"
            /// </summary>
            [EnumMember(Value = "waitingInteractionCount")]
            Waitinginteractioncount,
            
            /// <summary>
            /// Enum Wrapupcode for "wrapUpCode"
            /// </summary>
            [EnumMember(Value = "wrapUpCode")]
            Wrapupcode
        }
        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricsEnum
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
            /// Enum Nbotinteractions for "nBotInteractions"
            /// </summary>
            [EnumMember(Value = "nBotInteractions")]
            Nbotinteractions,
            
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
            /// Enum Nconversations for "nConversations"
            /// </summary>
            [EnumMember(Value = "nConversations")]
            Nconversations,
            
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
            /// Enum Nstatetransitionerror for "nStateTransitionError"
            /// </summary>
            [EnumMember(Value = "nStateTransitionError")]
            Nstatetransitionerror,
            
            /// <summary>
            /// Enum Ntransferred for "nTransferred"
            /// </summary>
            [EnumMember(Value = "nTransferred")]
            Ntransferred,
            
            /// <summary>
            /// Enum Oaudiomessagecount for "oAudioMessageCount"
            /// </summary>
            [EnumMember(Value = "oAudioMessageCount")]
            Oaudiomessagecount,
            
            /// <summary>
            /// Enum Oexternalaudiomessagecount for "oExternalAudioMessageCount"
            /// </summary>
            [EnumMember(Value = "oExternalAudioMessageCount")]
            Oexternalaudiomessagecount,
            
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
            /// Enum Omessagecount for "oMessageCount"
            /// </summary>
            [EnumMember(Value = "oMessageCount")]
            Omessagecount,
            
            /// <summary>
            /// Enum Omessagesegmentcount for "oMessageSegmentCount"
            /// </summary>
            [EnumMember(Value = "oMessageSegmentCount")]
            Omessagesegmentcount,
            
            /// <summary>
            /// Enum Omessageturn for "oMessageTurn"
            /// </summary>
            [EnumMember(Value = "oMessageTurn")]
            Omessageturn,
            
            /// <summary>
            /// Enum Oservicelevel for "oServiceLevel"
            /// </summary>
            [EnumMember(Value = "oServiceLevel")]
            Oservicelevel,
            
            /// <summary>
            /// Enum Oservicetarget for "oServiceTarget"
            /// </summary>
            [EnumMember(Value = "oServiceTarget")]
            Oservicetarget,
            
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
            /// Enum Tactivecallback for "tActiveCallback"
            /// </summary>
            [EnumMember(Value = "tActiveCallback")]
            Tactivecallback,
            
            /// <summary>
            /// Enum Tactivecallbackcomplete for "tActiveCallbackComplete"
            /// </summary>
            [EnumMember(Value = "tActiveCallbackComplete")]
            Tactivecallbackcomplete,
            
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
            /// Enum Tagentvideoconnected for "tAgentVideoConnected"
            /// </summary>
            [EnumMember(Value = "tAgentVideoConnected")]
            Tagentvideoconnected,
            
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
            /// Enum Taverageagentresponsetime for "tAverageAgentResponseTime"
            /// </summary>
            [EnumMember(Value = "tAverageAgentResponseTime")]
            Taverageagentresponsetime,
            
            /// <summary>
            /// Enum Taveragecustomerresponsetime for "tAverageCustomerResponseTime"
            /// </summary>
            [EnumMember(Value = "tAverageCustomerResponseTime")]
            Taveragecustomerresponsetime,
            
            /// <summary>
            /// Enum Tbarging for "tBarging"
            /// </summary>
            [EnumMember(Value = "tBarging")]
            Tbarging,
            
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
            /// Enum Tfirstengagement for "tFirstEngagement"
            /// </summary>
            [EnumMember(Value = "tFirstEngagement")]
            Tfirstengagement,
            
            /// <summary>
            /// Enum Tfirstresponse for "tFirstResponse"
            /// </summary>
            [EnumMember(Value = "tFirstResponse")]
            Tfirstresponse,
            
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
            /// Enum Tpark for "tPark"
            /// </summary>
            [EnumMember(Value = "tPark")]
            Tpark,
            
            /// <summary>
            /// Enum Tparkcomplete for "tParkComplete"
            /// </summary>
            [EnumMember(Value = "tParkComplete")]
            Tparkcomplete,
            
            /// <summary>
            /// Enum Tshortabandon for "tShortAbandon"
            /// </summary>
            [EnumMember(Value = "tShortAbandon")]
            Tshortabandon,
            
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
            Tvoicemail,
            
            /// <summary>
            /// Enum Twait for "tWait"
            /// </summary>
            [EnumMember(Value = "tWait")]
            Twait
        }
        /// <summary>
        /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
        /// </summary>
        /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AlternateTimeDimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Eventtime for "eventTime"
            /// </summary>
            [EnumMember(Value = "eventTime")]
            Eventtime
        }
        /// <summary>
        /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
        /// </summary>
        /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
        [DataMember(Name="alternateTimeDimension", EmitDefaultValue=false)]
        public AlternateTimeDimensionEnum? AlternateTimeDimension { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAsyncAggregationQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationAsyncAggregationQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAsyncAggregationQuery" /> class.
        /// </summary>
        /// <param name="Interval">Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="Granularity">Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
        /// <param name="TimeZone">Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London.</param>
        /// <param name="GroupBy">Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group..</param>
        /// <param name="Filter">Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters.</param>
        /// <param name="Metrics">Behaves like a SQL SELECT clause. Only named metrics will be retrieved. (required).</param>
        /// <param name="FlattenMultivaluedDimensions">Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;).</param>
        /// <param name="Views">Custom derived metric views.</param>
        /// <param name="AlternateTimeDimension">Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \&quot;eventTime\&quot; uses the actual time of the data event..</param>
        /// <param name="PageSize">The number of results per page.</param>
        public ConversationAsyncAggregationQuery(string Interval = null, string Granularity = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, ConversationAggregateQueryFilter Filter = null, List<MetricsEnum> Metrics = null, bool? FlattenMultivaluedDimensions = null, List<ConversationAggregationView> Views = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null, int? PageSize = null)
        {
            this.Interval = Interval;
            this.Granularity = Granularity;
            this.TimeZone = TimeZone;
            this.GroupBy = GroupBy;
            this.Filter = Filter;
            this.Metrics = Metrics;
            this.FlattenMultivaluedDimensions = FlattenMultivaluedDimensions;
            this.Views = Views;
            this.AlternateTimeDimension = AlternateTimeDimension;
            this.PageSize = PageSize;
            
        }
        


        /// <summary>
        /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }



        /// <summary>
        /// Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
        /// </summary>
        /// <value>Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public string Granularity { get; set; }



        /// <summary>
        /// Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
        /// </summary>
        /// <value>Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }



        /// <summary>
        /// Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.
        /// </summary>
        /// <value>Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.</value>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public List<GroupByEnum> GroupBy { get; set; }



        /// <summary>
        /// Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters
        /// </summary>
        /// <value>Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public ConversationAggregateQueryFilter Filter { get; set; }



        /// <summary>
        /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
        /// </summary>
        /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<MetricsEnum> Metrics { get; set; }



        /// <summary>
        /// Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)
        /// </summary>
        /// <value>Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)</value>
        [DataMember(Name="flattenMultivaluedDimensions", EmitDefaultValue=false)]
        public bool? FlattenMultivaluedDimensions { get; set; }



        /// <summary>
        /// Custom derived metric views
        /// </summary>
        /// <value>Custom derived metric views</value>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<ConversationAggregationView> Views { get; set; }





        /// <summary>
        /// The number of results per page
        /// </summary>
        /// <value>The number of results per page</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAsyncAggregationQuery {\n");

            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  FlattenMultivaluedDimensions: ").Append(FlattenMultivaluedDimensions).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  AlternateTimeDimension: ").Append(AlternateTimeDimension).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(obj as ConversationAsyncAggregationQuery);
        }

        /// <summary>
        /// Returns true if ConversationAsyncAggregationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationAsyncAggregationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationAsyncAggregationQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.GroupBy == other.GroupBy ||
                    this.GroupBy != null &&
                    this.GroupBy.SequenceEqual(other.GroupBy)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.FlattenMultivaluedDimensions == other.FlattenMultivaluedDimensions ||
                    this.FlattenMultivaluedDimensions != null &&
                    this.FlattenMultivaluedDimensions.Equals(other.FlattenMultivaluedDimensions)
                ) &&
                (
                    this.Views == other.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(other.Views)
                ) &&
                (
                    this.AlternateTimeDimension == other.AlternateTimeDimension ||
                    this.AlternateTimeDimension != null &&
                    this.AlternateTimeDimension.Equals(other.AlternateTimeDimension)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
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
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                if (this.GroupBy != null)
                    hash = hash * 59 + this.GroupBy.GetHashCode();

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.FlattenMultivaluedDimensions != null)
                    hash = hash * 59 + this.FlattenMultivaluedDimensions.GetHashCode();

                if (this.Views != null)
                    hash = hash * 59 + this.Views.GetHashCode();

                if (this.AlternateTimeDimension != null)
                    hash = hash * 59 + this.AlternateTimeDimension.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                return hash;
            }
        }
    }

}
