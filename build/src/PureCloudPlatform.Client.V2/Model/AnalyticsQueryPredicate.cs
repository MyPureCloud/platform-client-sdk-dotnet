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
    /// AnalyticsQueryPredicate
    /// </summary>
    [DataContract]
    public partial class AnalyticsQueryPredicate :  IEquatable<AnalyticsQueryPredicate>
    {
        
        
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Dimension for "dimension"
            /// </summary>
            [EnumMember(Value = "dimension")]
            Dimension,
            
            /// <summary>
            /// Enum Property for "property"
            /// </summary>
            [EnumMember(Value = "property")]
            Property,
            
            /// <summary>
            /// Enum Metric for "metric"
            /// </summary>
            [EnumMember(Value = "metric")]
            Metric
        }
        
        
        
        
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Conversationid for "conversationId"
            /// </summary>
            [EnumMember(Value = "conversationId")]
            Conversationid,
            
            /// <summary>
            /// Enum Sessionid for "sessionId"
            /// </summary>
            [EnumMember(Value = "sessionId")]
            Sessionid,
            
            /// <summary>
            /// Enum Mediatype for "mediaType"
            /// </summary>
            [EnumMember(Value = "mediaType")]
            Mediatype,
            
            /// <summary>
            /// Enum Queueid for "queueId"
            /// </summary>
            [EnumMember(Value = "queueId")]
            Queueid,
            
            /// <summary>
            /// Enum Userid for "userId"
            /// </summary>
            [EnumMember(Value = "userId")]
            Userid,
            
            /// <summary>
            /// Enum Participantid for "participantId"
            /// </summary>
            [EnumMember(Value = "participantId")]
            Participantid,
            
            /// <summary>
            /// Enum Participantname for "participantName"
            /// </summary>
            [EnumMember(Value = "participantName")]
            Participantname,
            
            /// <summary>
            /// Enum Direction for "direction"
            /// </summary>
            [EnumMember(Value = "direction")]
            Direction,
            
            /// <summary>
            /// Enum Originatingdirection for "originatingDirection"
            /// </summary>
            [EnumMember(Value = "originatingDirection")]
            Originatingdirection,
            
            /// <summary>
            /// Enum Wrapupcode for "wrapUpCode"
            /// </summary>
            [EnumMember(Value = "wrapUpCode")]
            Wrapupcode,
            
            /// <summary>
            /// Enum Wrapupnote for "wrapUpNote"
            /// </summary>
            [EnumMember(Value = "wrapUpNote")]
            Wrapupnote,
            
            /// <summary>
            /// Enum Interactiontype for "interactionType"
            /// </summary>
            [EnumMember(Value = "interactionType")]
            Interactiontype,
            
            /// <summary>
            /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
            /// </summary>
            [EnumMember(Value = "requestedRoutingSkillId")]
            Requestedroutingskillid,
            
            /// <summary>
            /// Enum Requestedlanguageid for "requestedLanguageId"
            /// </summary>
            [EnumMember(Value = "requestedLanguageId")]
            Requestedlanguageid,
            
            /// <summary>
            /// Enum Requestedroutinguserids for "requestedRoutingUserIds"
            /// </summary>
            [EnumMember(Value = "requestedRoutingUserIds")]
            Requestedroutinguserids,
            
            /// <summary>
            /// Enum Purpose for "purpose"
            /// </summary>
            [EnumMember(Value = "purpose")]
            Purpose,
            
            /// <summary>
            /// Enum Participanttype for "participantType"
            /// </summary>
            [EnumMember(Value = "participantType")]
            Participanttype,
            
            /// <summary>
            /// Enum Segmenttype for "segmentType"
            /// </summary>
            [EnumMember(Value = "segmentType")]
            Segmenttype,
            
            /// <summary>
            /// Enum Disconnecttype for "disconnectType"
            /// </summary>
            [EnumMember(Value = "disconnectType")]
            Disconnecttype,
            
            /// <summary>
            /// Enum Errorcode for "errorCode"
            /// </summary>
            [EnumMember(Value = "errorCode")]
            Errorcode,
            
            /// <summary>
            /// Enum Conversationend for "conversationEnd"
            /// </summary>
            [EnumMember(Value = "conversationEnd")]
            Conversationend,
            
            /// <summary>
            /// Enum Segmentend for "segmentEnd"
            /// </summary>
            [EnumMember(Value = "segmentEnd")]
            Segmentend,
            
            /// <summary>
            /// Enum Externalcontactid for "externalContactId"
            /// </summary>
            [EnumMember(Value = "externalContactId")]
            Externalcontactid,
            
            /// <summary>
            /// Enum Externalorganizationid for "externalOrganizationId"
            /// </summary>
            [EnumMember(Value = "externalOrganizationId")]
            Externalorganizationid,
            
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
            /// Enum Divisionid for "divisionId"
            /// </summary>
            [EnumMember(Value = "divisionId")]
            Divisionid,
            
            /// <summary>
            /// Enum Flaggedreason for "flaggedReason"
            /// </summary>
            [EnumMember(Value = "flaggedReason")]
            Flaggedreason,
            
            /// <summary>
            /// Enum Stationid for "stationId"
            /// </summary>
            [EnumMember(Value = "stationId")]
            Stationid,
            
            /// <summary>
            /// Enum Edgeid for "edgeId"
            /// </summary>
            [EnumMember(Value = "edgeId")]
            Edgeid,
            
            /// <summary>
            /// Enum Dnis for "dnis"
            /// </summary>
            [EnumMember(Value = "dnis")]
            Dnis,
            
            /// <summary>
            /// Enum Ani for "ani"
            /// </summary>
            [EnumMember(Value = "ani")]
            Ani,
            
            /// <summary>
            /// Enum Sessiondnis for "sessionDnis"
            /// </summary>
            [EnumMember(Value = "sessionDnis")]
            Sessiondnis,
            
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
            /// Enum Monitoredparticipantid for "monitoredParticipantId"
            /// </summary>
            [EnumMember(Value = "monitoredParticipantId")]
            Monitoredparticipantid,
            
            /// <summary>
            /// Enum Sourcesessionid for "sourceSessionId"
            /// </summary>
            [EnumMember(Value = "sourceSessionId")]
            Sourcesessionid,
            
            /// <summary>
            /// Enum Destinationsessionid for "destinationSessionId"
            /// </summary>
            [EnumMember(Value = "destinationSessionId")]
            Destinationsessionid,
            
            /// <summary>
            /// Enum Sourceconversationid for "sourceConversationId"
            /// </summary>
            [EnumMember(Value = "sourceConversationId")]
            Sourceconversationid,
            
            /// <summary>
            /// Enum Destinationconversationid for "destinationConversationId"
            /// </summary>
            [EnumMember(Value = "destinationConversationId")]
            Destinationconversationid,
            
            /// <summary>
            /// Enum Remotenamedisplayable for "remoteNameDisplayable"
            /// </summary>
            [EnumMember(Value = "remoteNameDisplayable")]
            Remotenamedisplayable,
            
            /// <summary>
            /// Enum Sipresponsecode for "sipResponseCode"
            /// </summary>
            [EnumMember(Value = "sipResponseCode")]
            Sipresponsecode,
            
            /// <summary>
            /// Enum Q850responsecode for "q850ResponseCode"
            /// </summary>
            [EnumMember(Value = "q850ResponseCode")]
            Q850responsecode,
            
            /// <summary>
            /// Enum Conference for "conference"
            /// </summary>
            [EnumMember(Value = "conference")]
            Conference,
            
            /// <summary>
            /// Enum Groupid for "groupId"
            /// </summary>
            [EnumMember(Value = "groupId")]
            Groupid,
            
            /// <summary>
            /// Enum Roomid for "roomId"
            /// </summary>
            [EnumMember(Value = "roomId")]
            Roomid,
            
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
            /// Enum Addressself for "addressSelf"
            /// </summary>
            [EnumMember(Value = "addressSelf")]
            Addressself,
            
            /// <summary>
            /// Enum Addressother for "addressOther"
            /// </summary>
            [EnumMember(Value = "addressOther")]
            Addressother,
            
            /// <summary>
            /// Enum Subject for "subject"
            /// </summary>
            [EnumMember(Value = "subject")]
            Subject,
            
            /// <summary>
            /// Enum Messagetype for "messageType"
            /// </summary>
            [EnumMember(Value = "messageType")]
            Messagetype,
            
            /// <summary>
            /// Enum Peerid for "peerId"
            /// </summary>
            [EnumMember(Value = "peerId")]
            Peerid,
            
            /// <summary>
            /// Enum Scriptid for "scriptId"
            /// </summary>
            [EnumMember(Value = "scriptId")]
            Scriptid,
            
            /// <summary>
            /// Enum Evaluationid for "evaluationId"
            /// </summary>
            [EnumMember(Value = "evaluationId")]
            Evaluationid,
            
            /// <summary>
            /// Enum Evaluatorid for "evaluatorId"
            /// </summary>
            [EnumMember(Value = "evaluatorId")]
            Evaluatorid,
            
            /// <summary>
            /// Enum Contextid for "contextId"
            /// </summary>
            [EnumMember(Value = "contextId")]
            Contextid,
            
            /// <summary>
            /// Enum Formid for "formId"
            /// </summary>
            [EnumMember(Value = "formId")]
            Formid,
            
            /// <summary>
            /// Enum Formname for "formName"
            /// </summary>
            [EnumMember(Value = "formName")]
            Formname,
            
            /// <summary>
            /// Enum Eventtime for "eventTime"
            /// </summary>
            [EnumMember(Value = "eventTime")]
            Eventtime,
            
            /// <summary>
            /// Enum Calibrationid for "calibrationId"
            /// </summary>
            [EnumMember(Value = "calibrationId")]
            Calibrationid,
            
            /// <summary>
            /// Enum Surveyid for "surveyId"
            /// </summary>
            [EnumMember(Value = "surveyId")]
            Surveyid,
            
            /// <summary>
            /// Enum Surveyformcontextid for "surveyFormContextId"
            /// </summary>
            [EnumMember(Value = "surveyFormContextId")]
            Surveyformcontextid,
            
            /// <summary>
            /// Enum Surveyformid for "surveyFormId"
            /// </summary>
            [EnumMember(Value = "surveyFormId")]
            Surveyformid,
            
            /// <summary>
            /// Enum Surveyformname for "surveyFormName"
            /// </summary>
            [EnumMember(Value = "surveyFormName")]
            Surveyformname,
            
            /// <summary>
            /// Enum Surveyanswerid for "surveyAnswerId"
            /// </summary>
            [EnumMember(Value = "surveyAnswerId")]
            Surveyanswerid,
            
            /// <summary>
            /// Enum Surveyquestionid for "surveyQuestionId"
            /// </summary>
            [EnumMember(Value = "surveyQuestionId")]
            Surveyquestionid,
            
            /// <summary>
            /// Enum Surveyquestiongroupid for "surveyQuestionGroupId"
            /// </summary>
            [EnumMember(Value = "surveyQuestionGroupId")]
            Surveyquestiongroupid,
            
            /// <summary>
            /// Enum Surveypromoterscore for "surveyPromoterScore"
            /// </summary>
            [EnumMember(Value = "surveyPromoterScore")]
            Surveypromoterscore,
            
            /// <summary>
            /// Enum Surveycompleteddate for "surveyCompletedDate"
            /// </summary>
            [EnumMember(Value = "surveyCompletedDate")]
            Surveycompleteddate,
            
            /// <summary>
            /// Enum Surveyerrorreason for "surveyErrorReason"
            /// </summary>
            [EnumMember(Value = "surveyErrorReason")]
            Surveyerrorreason,
            
            /// <summary>
            /// Enum Surveypreviousstatus for "surveyPreviousStatus"
            /// </summary>
            [EnumMember(Value = "surveyPreviousStatus")]
            Surveypreviousstatus,
            
            /// <summary>
            /// Enum Surveystatus for "surveyStatus"
            /// </summary>
            [EnumMember(Value = "surveyStatus")]
            Surveystatus,
            
            /// <summary>
            /// Enum Systempresence for "systemPresence"
            /// </summary>
            [EnumMember(Value = "systemPresence")]
            Systempresence,
            
            /// <summary>
            /// Enum Organizationpresenceid for "organizationPresenceId"
            /// </summary>
            [EnumMember(Value = "organizationPresenceId")]
            Organizationpresenceid,
            
            /// <summary>
            /// Enum Routingstatus for "routingStatus"
            /// </summary>
            [EnumMember(Value = "routingStatus")]
            Routingstatus,
            
            /// <summary>
            /// Enum Flowid for "flowId"
            /// </summary>
            [EnumMember(Value = "flowId")]
            Flowid,
            
            /// <summary>
            /// Enum Flowname for "flowName"
            /// </summary>
            [EnumMember(Value = "flowName")]
            Flowname,
            
            /// <summary>
            /// Enum Flowversion for "flowVersion"
            /// </summary>
            [EnumMember(Value = "flowVersion")]
            Flowversion,
            
            /// <summary>
            /// Enum Flowtype for "flowType"
            /// </summary>
            [EnumMember(Value = "flowType")]
            Flowtype,
            
            /// <summary>
            /// Enum Exitreason for "exitReason"
            /// </summary>
            [EnumMember(Value = "exitReason")]
            Exitreason,
            
            /// <summary>
            /// Enum Entryreason for "entryReason"
            /// </summary>
            [EnumMember(Value = "entryReason")]
            Entryreason,
            
            /// <summary>
            /// Enum Entrytype for "entryType"
            /// </summary>
            [EnumMember(Value = "entryType")]
            Entrytype,
            
            /// <summary>
            /// Enum Transfertype for "transferType"
            /// </summary>
            [EnumMember(Value = "transferType")]
            Transfertype,
            
            /// <summary>
            /// Enum Transfertargetname for "transferTargetName"
            /// </summary>
            [EnumMember(Value = "transferTargetName")]
            Transfertargetname,
            
            /// <summary>
            /// Enum Transfertargetaddress for "transferTargetAddress"
            /// </summary>
            [EnumMember(Value = "transferTargetAddress")]
            Transfertargetaddress,
            
            /// <summary>
            /// Enum Issuedcallback for "issuedCallback"
            /// </summary>
            [EnumMember(Value = "issuedCallback")]
            Issuedcallback,
            
            /// <summary>
            /// Enum Startinglanguage for "startingLanguage"
            /// </summary>
            [EnumMember(Value = "startingLanguage")]
            Startinglanguage,
            
            /// <summary>
            /// Enum Endinglanguage for "endingLanguage"
            /// </summary>
            [EnumMember(Value = "endingLanguage")]
            Endinglanguage,
            
            /// <summary>
            /// Enum Flowoutcomeid for "flowOutcomeId"
            /// </summary>
            [EnumMember(Value = "flowOutcomeId")]
            Flowoutcomeid,
            
            /// <summary>
            /// Enum Flowoutcomevalue for "flowOutcomeValue"
            /// </summary>
            [EnumMember(Value = "flowOutcomeValue")]
            Flowoutcomevalue,
            
            /// <summary>
            /// Enum Flowoutcome for "flowOutcome"
            /// </summary>
            [EnumMember(Value = "flowOutcome")]
            Flowoutcome,
            
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
            /// Enum Minmos for "minMos"
            /// </summary>
            [EnumMember(Value = "minMos")]
            Minmos,
            
            /// <summary>
            /// Enum Mediastatsminconversationmos for "mediaStatsMinConversationMos"
            /// </summary>
            [EnumMember(Value = "mediaStatsMinConversationMos")]
            Mediastatsminconversationmos,
            
            /// <summary>
            /// Enum Minrfactor for "minRFactor"
            /// </summary>
            [EnumMember(Value = "minRFactor")]
            Minrfactor,
            
            /// <summary>
            /// Enum Mediastatsminconversationrfactor for "mediaStatsMinConversationRFactor"
            /// </summary>
            [EnumMember(Value = "mediaStatsMinConversationRFactor")]
            Mediastatsminconversationrfactor
        }
        
        
        
        
        /// <summary>
        /// Left hand side for property predicates
        /// </summary>
        /// <value>Left hand side for property predicates</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PropertyTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bool for "bool"
            /// </summary>
            [EnumMember(Value = "bool")]
            Bool,
            
            /// <summary>
            /// Enum Integer for "integer"
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer,
            
            /// <summary>
            /// Enum Real for "real"
            /// </summary>
            [EnumMember(Value = "real")]
            Real,
            
            /// <summary>
            /// Enum Date for "date"
            /// </summary>
            [EnumMember(Value = "date")]
            Date,
            
            /// <summary>
            /// Enum String for "string"
            /// </summary>
            [EnumMember(Value = "string")]
            String,
            
            /// <summary>
            /// Enum Uuid for "uuid"
            /// </summary>
            [EnumMember(Value = "uuid")]
            Uuid
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Left hand side for metric predicates
        /// </summary>
        /// <value>Left hand side for metric predicates</value>
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
            /// Enum Tsegmentduration for "tSegmentDuration"
            /// </summary>
            [EnumMember(Value = "tSegmentDuration")]
            Tsegmentduration,
            
            /// <summary>
            /// Enum Tconversationduration for "tConversationDuration"
            /// </summary>
            [EnumMember(Value = "tConversationDuration")]
            Tconversationduration,
            
            /// <summary>
            /// Enum Ototalcriticalscore for "oTotalCriticalScore"
            /// </summary>
            [EnumMember(Value = "oTotalCriticalScore")]
            Ototalcriticalscore,
            
            /// <summary>
            /// Enum Ototalscore for "oTotalScore"
            /// </summary>
            [EnumMember(Value = "oTotalScore")]
            Ototalscore,
            
            /// <summary>
            /// Enum Nevaluations for "nEvaluations"
            /// </summary>
            [EnumMember(Value = "nEvaluations")]
            Nevaluations,
            
            /// <summary>
            /// Enum Tabandon for "tAbandon"
            /// </summary>
            [EnumMember(Value = "tAbandon")]
            Tabandon,
            
            /// <summary>
            /// Enum Tivr for "tIvr"
            /// </summary>
            [EnumMember(Value = "tIvr")]
            Tivr,
            
            /// <summary>
            /// Enum Tanswered for "tAnswered"
            /// </summary>
            [EnumMember(Value = "tAnswered")]
            Tanswered,
            
            /// <summary>
            /// Enum Tflowout for "tFlowOut"
            /// </summary>
            [EnumMember(Value = "tFlowOut")]
            Tflowout,
            
            /// <summary>
            /// Enum Tacd for "tAcd"
            /// </summary>
            [EnumMember(Value = "tAcd")]
            Tacd,
            
            /// <summary>
            /// Enum Ttalk for "tTalk"
            /// </summary>
            [EnumMember(Value = "tTalk")]
            Ttalk,
            
            /// <summary>
            /// Enum Theld for "tHeld"
            /// </summary>
            [EnumMember(Value = "tHeld")]
            Theld,
            
            /// <summary>
            /// Enum Ttalkcomplete for "tTalkComplete"
            /// </summary>
            [EnumMember(Value = "tTalkComplete")]
            Ttalkcomplete,
            
            /// <summary>
            /// Enum Theldcomplete for "tHeldComplete"
            /// </summary>
            [EnumMember(Value = "tHeldComplete")]
            Theldcomplete,
            
            /// <summary>
            /// Enum Tacw for "tAcw"
            /// </summary>
            [EnumMember(Value = "tAcw")]
            Tacw,
            
            /// <summary>
            /// Enum Thandle for "tHandle"
            /// </summary>
            [EnumMember(Value = "tHandle")]
            Thandle,
            
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
            /// Enum Twait for "tWait"
            /// </summary>
            [EnumMember(Value = "tWait")]
            Twait,
            
            /// <summary>
            /// Enum Tagentroutingstatus for "tAgentRoutingStatus"
            /// </summary>
            [EnumMember(Value = "tAgentRoutingStatus")]
            Tagentroutingstatus,
            
            /// <summary>
            /// Enum Torganizationpresence for "tOrganizationPresence"
            /// </summary>
            [EnumMember(Value = "tOrganizationPresence")]
            Torganizationpresence,
            
            /// <summary>
            /// Enum Tsystempresence for "tSystemPresence"
            /// </summary>
            [EnumMember(Value = "tSystemPresence")]
            Tsystempresence,
            
            /// <summary>
            /// Enum Tuserresponsetime for "tUserResponseTime"
            /// </summary>
            [EnumMember(Value = "tUserResponseTime")]
            Tuserresponsetime,
            
            /// <summary>
            /// Enum Tagentresponsetime for "tAgentResponseTime"
            /// </summary>
            [EnumMember(Value = "tAgentResponseTime")]
            Tagentresponsetime,
            
            /// <summary>
            /// Enum Tvoicemail for "tVoicemail"
            /// </summary>
            [EnumMember(Value = "tVoicemail")]
            Tvoicemail,
            
            /// <summary>
            /// Enum Nstatetransitionerror for "nStateTransitionError"
            /// </summary>
            [EnumMember(Value = "nStateTransitionError")]
            Nstatetransitionerror,
            
            /// <summary>
            /// Enum Noffered for "nOffered"
            /// </summary>
            [EnumMember(Value = "nOffered")]
            Noffered,
            
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
            /// Enum Nblindtransferred for "nBlindTransferred"
            /// </summary>
            [EnumMember(Value = "nBlindTransferred")]
            Nblindtransferred,
            
            /// <summary>
            /// Enum Nconsulttransferred for "nConsultTransferred"
            /// </summary>
            [EnumMember(Value = "nConsultTransferred")]
            Nconsulttransferred,
            
            /// <summary>
            /// Enum Nconsult for "nConsult"
            /// </summary>
            [EnumMember(Value = "nConsult")]
            Nconsult,
            
            /// <summary>
            /// Enum Nconnected for "nConnected"
            /// </summary>
            [EnumMember(Value = "nConnected")]
            Nconnected,
            
            /// <summary>
            /// Enum Talert for "tAlert"
            /// </summary>
            [EnumMember(Value = "tAlert")]
            Talert,
            
            /// <summary>
            /// Enum Tnotresponding for "tNotResponding"
            /// </summary>
            [EnumMember(Value = "tNotResponding")]
            Tnotresponding,
            
            /// <summary>
            /// Enum Noutbound for "nOutbound"
            /// </summary>
            [EnumMember(Value = "nOutbound")]
            Noutbound,
            
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
            /// Enum Noutboundabandoned for "nOutboundAbandoned"
            /// </summary>
            [EnumMember(Value = "nOutboundAbandoned")]
            Noutboundabandoned,
            
            /// <summary>
            /// Enum Nerror for "nError"
            /// </summary>
            [EnumMember(Value = "nError")]
            Nerror,
            
            /// <summary>
            /// Enum Oservicetarget for "oServiceTarget"
            /// </summary>
            [EnumMember(Value = "oServiceTarget")]
            Oservicetarget,
            
            /// <summary>
            /// Enum Oservicelevel for "oServiceLevel"
            /// </summary>
            [EnumMember(Value = "oServiceLevel")]
            Oservicelevel,
            
            /// <summary>
            /// Enum Tactive for "tActive"
            /// </summary>
            [EnumMember(Value = "tActive")]
            Tactive,
            
            /// <summary>
            /// Enum Tinactive for "tInactive"
            /// </summary>
            [EnumMember(Value = "tInactive")]
            Tinactive,
            
            /// <summary>
            /// Enum Oactiveusers for "oActiveUsers"
            /// </summary>
            [EnumMember(Value = "oActiveUsers")]
            Oactiveusers,
            
            /// <summary>
            /// Enum Omemberusers for "oMemberUsers"
            /// </summary>
            [EnumMember(Value = "oMemberUsers")]
            Omemberusers,
            
            /// <summary>
            /// Enum Oactivequeues for "oActiveQueues"
            /// </summary>
            [EnumMember(Value = "oActiveQueues")]
            Oactivequeues,
            
            /// <summary>
            /// Enum Omemberqueues for "oMemberQueues"
            /// </summary>
            [EnumMember(Value = "oMemberQueues")]
            Omemberqueues,
            
            /// <summary>
            /// Enum Ointeracting for "oInteracting"
            /// </summary>
            [EnumMember(Value = "oInteracting")]
            Ointeracting,
            
            /// <summary>
            /// Enum Owaiting for "oWaiting"
            /// </summary>
            [EnumMember(Value = "oWaiting")]
            Owaiting,
            
            /// <summary>
            /// Enum Oonqueueusers for "oOnQueueUsers"
            /// </summary>
            [EnumMember(Value = "oOnQueueUsers")]
            Oonqueueusers,
            
            /// <summary>
            /// Enum Ooffqueueusers for "oOffQueueUsers"
            /// </summary>
            [EnumMember(Value = "oOffQueueUsers")]
            Ooffqueueusers,
            
            /// <summary>
            /// Enum Ouserpresences for "oUserPresences"
            /// </summary>
            [EnumMember(Value = "oUserPresences")]
            Ouserpresences,
            
            /// <summary>
            /// Enum Ouserroutingstatuses for "oUserRoutingStatuses"
            /// </summary>
            [EnumMember(Value = "oUserRoutingStatuses")]
            Ouserroutingstatuses,
            
            /// <summary>
            /// Enum Nsurveyssent for "nSurveysSent"
            /// </summary>
            [EnumMember(Value = "nSurveysSent")]
            Nsurveyssent,
            
            /// <summary>
            /// Enum Nsurveysstarted for "nSurveysStarted"
            /// </summary>
            [EnumMember(Value = "nSurveysStarted")]
            Nsurveysstarted,
            
            /// <summary>
            /// Enum Nsurveysabandoned for "nSurveysAbandoned"
            /// </summary>
            [EnumMember(Value = "nSurveysAbandoned")]
            Nsurveysabandoned,
            
            /// <summary>
            /// Enum Nsurveysexpired for "nSurveysExpired"
            /// </summary>
            [EnumMember(Value = "nSurveysExpired")]
            Nsurveysexpired,
            
            /// <summary>
            /// Enum Nsurveyerrors for "nSurveyErrors"
            /// </summary>
            [EnumMember(Value = "nSurveyErrors")]
            Nsurveyerrors,
            
            /// <summary>
            /// Enum Nsurveyresponses for "nSurveyResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyResponses")]
            Nsurveyresponses,
            
            /// <summary>
            /// Enum Nsurveyanswerresponses for "nSurveyAnswerResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyAnswerResponses")]
            Nsurveyanswerresponses,
            
            /// <summary>
            /// Enum Osurveytotalscore for "oSurveyTotalScore"
            /// </summary>
            [EnumMember(Value = "oSurveyTotalScore")]
            Osurveytotalscore,
            
            /// <summary>
            /// Enum Osurveyquestiongroupscore for "oSurveyQuestionGroupScore"
            /// </summary>
            [EnumMember(Value = "oSurveyQuestionGroupScore")]
            Osurveyquestiongroupscore,
            
            /// <summary>
            /// Enum Nsurveyquestiongroupresponses for "nSurveyQuestionGroupResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyQuestionGroupResponses")]
            Nsurveyquestiongroupresponses,
            
            /// <summary>
            /// Enum Osurveyquestionscore for "oSurveyQuestionScore"
            /// </summary>
            [EnumMember(Value = "oSurveyQuestionScore")]
            Osurveyquestionscore,
            
            /// <summary>
            /// Enum Nsurveyquestionresponses for "nSurveyQuestionResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyQuestionResponses")]
            Nsurveyquestionresponses,
            
            /// <summary>
            /// Enum Nsurveynpsresponses for "nSurveyNpsResponses"
            /// </summary>
            [EnumMember(Value = "nSurveyNpsResponses")]
            Nsurveynpsresponses,
            
            /// <summary>
            /// Enum Nsurveynpspromoters for "nSurveyNpsPromoters"
            /// </summary>
            [EnumMember(Value = "nSurveyNpsPromoters")]
            Nsurveynpspromoters,
            
            /// <summary>
            /// Enum Nsurveynpsdetractors for "nSurveyNpsDetractors"
            /// </summary>
            [EnumMember(Value = "nSurveyNpsDetractors")]
            Nsurveynpsdetractors,
            
            /// <summary>
            /// Enum Nflow for "nFlow"
            /// </summary>
            [EnumMember(Value = "nFlow")]
            Nflow,
            
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
            /// Enum Tflow for "tFlow"
            /// </summary>
            [EnumMember(Value = "tFlow")]
            Tflow,
            
            /// <summary>
            /// Enum Oflow for "oFlow"
            /// </summary>
            [EnumMember(Value = "oFlow")]
            Oflow,
            
            /// <summary>
            /// Enum Tflowoutcome for "tFlowOutcome"
            /// </summary>
            [EnumMember(Value = "tFlowOutcome")]
            Tflowoutcome,
            
            /// <summary>
            /// Enum Nflowoutcome for "nFlowOutcome"
            /// </summary>
            [EnumMember(Value = "nFlowOutcome")]
            Nflowoutcome,
            
            /// <summary>
            /// Enum Nflowoutcomefailed for "nFlowOutcomeFailed"
            /// </summary>
            [EnumMember(Value = "nFlowOutcomeFailed")]
            Nflowoutcomefailed
        }
        
        
        
        
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Matches for "matches"
            /// </summary>
            [EnumMember(Value = "matches")]
            Matches,
            
            /// <summary>
            /// Enum Exists for "exists"
            /// </summary>
            [EnumMember(Value = "exists")]
            Exists,
            
            /// <summary>
            /// Enum Notexists for "notExists"
            /// </summary>
            [EnumMember(Value = "notExists")]
            Notexists
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public DimensionEnum? Dimension { get; set; }
        
        
        
        /// <summary>
        /// Left hand side for property predicates
        /// </summary>
        /// <value>Left hand side for property predicates</value>
        [DataMember(Name="propertyType", EmitDefaultValue=false)]
        public PropertyTypeEnum? PropertyType { get; set; }
        
        
        
        
        
        /// <summary>
        /// Left hand side for metric predicates
        /// </summary>
        /// <value>Left hand side for metric predicates</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        
        
        
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPredicate" /> class.
        /// </summary>
        /// <param name="Type">Optional type, can usually be inferred.</param>
        /// <param name="Dimension">Left hand side for dimension predicates.</param>
        /// <param name="PropertyType">Left hand side for property predicates.</param>
        /// <param name="Property">Left hand side for property predicates.</param>
        /// <param name="Metric">Left hand side for metric predicates.</param>
        /// <param name="_Operator">Optional operator, default is matches.</param>
        /// <param name="Value">Right hand side for dimension, property, or metric predicates.</param>
        /// <param name="Range">Right hand side for property or metric predicates.</param>
        public AnalyticsQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, PropertyTypeEnum? PropertyType = null, string Property = null, MetricEnum? Metric = null, OperatorEnum? _Operator = null, string Value = null, NumericRange Range = null)
        {
            this.Type = Type;
            this.Dimension = Dimension;
            this.PropertyType = PropertyType;
            this.Property = Property;
            this.Metric = Metric;
            this._Operator = _Operator;
            this.Value = Value;
            this.Range = Range;
            
        }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Left hand side for property predicates
        /// </summary>
        /// <value>Left hand side for property predicates</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Right hand side for dimension, property, or metric predicates
        /// </summary>
        /// <value>Right hand side for dimension, property, or metric predicates</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// Right hand side for property or metric predicates
        /// </summary>
        /// <value>Right hand side for property or metric predicates</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public NumericRange Range { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQueryPredicate {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as AnalyticsQueryPredicate);
        }

        /// <summary>
        /// Returns true if AnalyticsQueryPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsQueryPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQueryPredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) &&
                (
                    this.PropertyType == other.PropertyType ||
                    this.PropertyType != null &&
                    this.PropertyType.Equals(other.PropertyType)
                ) &&
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();
                
                if (this.PropertyType != null)
                    hash = hash * 59 + this.PropertyType.GetHashCode();
                
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();
                
                return hash;
            }
        }
    }

}
