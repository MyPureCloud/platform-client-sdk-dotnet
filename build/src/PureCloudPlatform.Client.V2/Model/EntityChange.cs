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
    /// EntityChange
    /// </summary>
    [DataContract]
    public partial class EntityChange :  IEquatable<EntityChange>
    {
        /// <summary>
        /// Type of the entity that was changed
        /// </summary>
        /// <value>Type of the entity that was changed</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Accesstoken for "AccessToken"
            /// </summary>
            [EnumMember(Value = "AccessToken")]
            Accesstoken,
            
            /// <summary>
            /// Enum Action for "Action"
            /// </summary>
            [EnumMember(Value = "Action")]
            Action,
            
            /// <summary>
            /// Enum Actiondraft for "ActionDraft"
            /// </summary>
            [EnumMember(Value = "ActionDraft")]
            Actiondraft,
            
            /// <summary>
            /// Enum Actionmap for "ActionMap"
            /// </summary>
            [EnumMember(Value = "ActionMap")]
            Actionmap,
            
            /// <summary>
            /// Enum Actiontemplate for "ActionTemplate"
            /// </summary>
            [EnumMember(Value = "ActionTemplate")]
            Actiontemplate,
            
            /// <summary>
            /// Enum Activitycode for "ActivityCode"
            /// </summary>
            [EnumMember(Value = "ActivityCode")]
            Activitycode,
            
            /// <summary>
            /// Enum Adherenceexplanation for "AdherenceExplanation"
            /// </summary>
            [EnumMember(Value = "AdherenceExplanation")]
            Adherenceexplanation,
            
            /// <summary>
            /// Enum Agentroutinginfo for "AgentRoutingInfo"
            /// </summary>
            [EnumMember(Value = "AgentRoutingInfo")]
            Agentroutinginfo,
            
            /// <summary>
            /// Enum Analyticsreportingsettings for "AnalyticsReportingSettings"
            /// </summary>
            [EnumMember(Value = "AnalyticsReportingSettings")]
            Analyticsreportingsettings,
            
            /// <summary>
            /// Enum Annotation for "Annotation"
            /// </summary>
            [EnumMember(Value = "Annotation")]
            Annotation,
            
            /// <summary>
            /// Enum Appointment for "Appointment"
            /// </summary>
            [EnumMember(Value = "Appointment")]
            Appointment,
            
            /// <summary>
            /// Enum Assignment for "Assignment"
            /// </summary>
            [EnumMember(Value = "Assignment")]
            Assignment,
            
            /// <summary>
            /// Enum Attemptlimits for "AttemptLimits"
            /// </summary>
            [EnumMember(Value = "AttemptLimits")]
            Attemptlimits,
            
            /// <summary>
            /// Enum Authorganization for "AuthOrganization"
            /// </summary>
            [EnumMember(Value = "AuthOrganization")]
            Authorganization,
            
            /// <summary>
            /// Enum Authuser for "AuthUser"
            /// </summary>
            [EnumMember(Value = "AuthUser")]
            Authuser,
            
            /// <summary>
            /// Enum Bulk for "Bulk"
            /// </summary>
            [EnumMember(Value = "Bulk")]
            Bulk,
            
            /// <summary>
            /// Enum Bulkactions for "BulkActions"
            /// </summary>
            [EnumMember(Value = "BulkActions")]
            Bulkactions,
            
            /// <summary>
            /// Enum Businessunit for "BusinessUnit"
            /// </summary>
            [EnumMember(Value = "BusinessUnit")]
            Businessunit,
            
            /// <summary>
            /// Enum Calibration for "Calibration"
            /// </summary>
            [EnumMember(Value = "Calibration")]
            Calibration,
            
            /// <summary>
            /// Enum Callabletimeset for "CallableTimeSet"
            /// </summary>
            [EnumMember(Value = "CallableTimeSet")]
            Callabletimeset,
            
            /// <summary>
            /// Enum Callanalysisresponseset for "CallAnalysisResponseSet"
            /// </summary>
            [EnumMember(Value = "CallAnalysisResponseSet")]
            Callanalysisresponseset,
            
            /// <summary>
            /// Enum Campaign for "Campaign"
            /// </summary>
            [EnumMember(Value = "Campaign")]
            Campaign,
            
            /// <summary>
            /// Enum Campaignrule for "CampaignRule"
            /// </summary>
            [EnumMember(Value = "CampaignRule")]
            Campaignrule,
            
            /// <summary>
            /// Enum Campaignschedule for "CampaignSchedule"
            /// </summary>
            [EnumMember(Value = "CampaignSchedule")]
            Campaignschedule,
            
            /// <summary>
            /// Enum Changerequest for "ChangeRequest"
            /// </summary>
            [EnumMember(Value = "ChangeRequest")]
            Changerequest,
            
            /// <summary>
            /// Enum Clickstreamsettings for "ClickstreamSettings"
            /// </summary>
            [EnumMember(Value = "ClickstreamSettings")]
            Clickstreamsettings,
            
            /// <summary>
            /// Enum Composerpage for "ComposerPage"
            /// </summary>
            [EnumMember(Value = "ComposerPage")]
            Composerpage,
            
            /// <summary>
            /// Enum Composerscript for "ComposerScript"
            /// </summary>
            [EnumMember(Value = "ComposerScript")]
            Composerscript,
            
            /// <summary>
            /// Enum Composerpublishedscript for "ComposerPublishedScript"
            /// </summary>
            [EnumMember(Value = "ComposerPublishedScript")]
            Composerpublishedscript,
            
            /// <summary>
            /// Enum Composertemplate for "ComposerTemplate"
            /// </summary>
            [EnumMember(Value = "ComposerTemplate")]
            Composertemplate,
            
            /// <summary>
            /// Enum Configuration for "Configuration"
            /// </summary>
            [EnumMember(Value = "Configuration")]
            Configuration,
            
            /// <summary>
            /// Enum Configurationversion for "ConfigurationVersion"
            /// </summary>
            [EnumMember(Value = "ConfigurationVersion")]
            Configurationversion,
            
            /// <summary>
            /// Enum Contactlist for "ContactList"
            /// </summary>
            [EnumMember(Value = "ContactList")]
            Contactlist,
            
            /// <summary>
            /// Enum Contactlistfilter for "ContactListFilter"
            /// </summary>
            [EnumMember(Value = "ContactListFilter")]
            Contactlistfilter,
            
            /// <summary>
            /// Enum Contactschema for "ContactSchema"
            /// </summary>
            [EnumMember(Value = "ContactSchema")]
            Contactschema,
            
            /// <summary>
            /// Enum Conversationattributes for "ConversationAttributes"
            /// </summary>
            [EnumMember(Value = "ConversationAttributes")]
            Conversationattributes,
            
            /// <summary>
            /// Enum Conversationaccount for "ConversationAccount"
            /// </summary>
            [EnumMember(Value = "ConversationAccount")]
            Conversationaccount,
            
            /// <summary>
            /// Enum Conversationdefaultsupportedcontent for "ConversationDefaultSupportedContent"
            /// </summary>
            [EnumMember(Value = "ConversationDefaultSupportedContent")]
            Conversationdefaultsupportedcontent,
            
            /// <summary>
            /// Enum Conversationphonenumber for "ConversationPhoneNumber"
            /// </summary>
            [EnumMember(Value = "ConversationPhoneNumber")]
            Conversationphonenumber,
            
            /// <summary>
            /// Enum Conversationrecipient for "ConversationRecipient"
            /// </summary>
            [EnumMember(Value = "ConversationRecipient")]
            Conversationrecipient,
            
            /// <summary>
            /// Enum Conversationthreadingwindow for "ConversationThreadingWindow"
            /// </summary>
            [EnumMember(Value = "ConversationThreadingWindow")]
            Conversationthreadingwindow,
            
            /// <summary>
            /// Enum Credential for "Credential"
            /// </summary>
            [EnumMember(Value = "Credential")]
            Credential,
            
            /// <summary>
            /// Enum Dashboardsettings for "DashboardSettings"
            /// </summary>
            [EnumMember(Value = "DashboardSettings")]
            Dashboardsettings,
            
            /// <summary>
            /// Enum Defaultpanelsettings for "DefaultPanelSettings"
            /// </summary>
            [EnumMember(Value = "DefaultPanelSettings")]
            Defaultpanelsettings,
            
            /// <summary>
            /// Enum Dependencytrackingbuild for "DependencyTrackingBuild"
            /// </summary>
            [EnumMember(Value = "DependencyTrackingBuild")]
            Dependencytrackingbuild,
            
            /// <summary>
            /// Enum Deployment for "Deployment"
            /// </summary>
            [EnumMember(Value = "Deployment")]
            Deployment,
            
            /// <summary>
            /// Enum Did for "DID"
            /// </summary>
            [EnumMember(Value = "DID")]
            Did,
            
            /// <summary>
            /// Enum Didpool for "DIDPool"
            /// </summary>
            [EnumMember(Value = "DIDPool")]
            Didpool,
            
            /// <summary>
            /// Enum Digitalruleset for "DigitalRuleSet"
            /// </summary>
            [EnumMember(Value = "DigitalRuleSet")]
            Digitalruleset,
            
            /// <summary>
            /// Enum Directorygroup for "DirectoryGroup"
            /// </summary>
            [EnumMember(Value = "DirectoryGroup")]
            Directorygroup,
            
            /// <summary>
            /// Enum Dnclist for "DNCList"
            /// </summary>
            [EnumMember(Value = "DNCList")]
            Dnclist,
            
            /// <summary>
            /// Enum Document for "Document"
            /// </summary>
            [EnumMember(Value = "Document")]
            Document,
            
            /// <summary>
            /// Enum Dynamicgroup for "DynamicGroup"
            /// </summary>
            [EnumMember(Value = "DynamicGroup")]
            Dynamicgroup,
            
            /// <summary>
            /// Enum Dynamicschema for "DynamicSchema"
            /// </summary>
            [EnumMember(Value = "DynamicSchema")]
            Dynamicschema,
            
            /// <summary>
            /// Enum Edge for "Edge"
            /// </summary>
            [EnumMember(Value = "Edge")]
            Edge,
            
            /// <summary>
            /// Enum Edgegroup for "EdgeGroup"
            /// </summary>
            [EnumMember(Value = "EdgeGroup")]
            Edgegroup,
            
            /// <summary>
            /// Enum Edgelog for "EdgeLog"
            /// </summary>
            [EnumMember(Value = "EdgeLog")]
            Edgelog,
            
            /// <summary>
            /// Enum Edgelogzip for "EdgeLogZip"
            /// </summary>
            [EnumMember(Value = "EdgeLogZip")]
            Edgelogzip,
            
            /// <summary>
            /// Enum Edgepcaps for "EdgePcaps"
            /// </summary>
            [EnumMember(Value = "EdgePcaps")]
            Edgepcaps,
            
            /// <summary>
            /// Enum Edgepreferences for "EdgePreferences"
            /// </summary>
            [EnumMember(Value = "EdgePreferences")]
            Edgepreferences,
            
            /// <summary>
            /// Enum Edgetracelevel for "EdgeTraceLevel"
            /// </summary>
            [EnumMember(Value = "EdgeTraceLevel")]
            Edgetracelevel,
            
            /// <summary>
            /// Enum Emailcampaignschedule for "EmailCampaignSchedule"
            /// </summary>
            [EnumMember(Value = "EmailCampaignSchedule")]
            Emailcampaignschedule,
            
            /// <summary>
            /// Enum Emergencygroup for "EmergencyGroup"
            /// </summary>
            [EnumMember(Value = "EmergencyGroup")]
            Emergencygroup,
            
            /// <summary>
            /// Enum Enterpriseagreement for "EnterpriseAgreement"
            /// </summary>
            [EnumMember(Value = "EnterpriseAgreement")]
            Enterpriseagreement,
            
            /// <summary>
            /// Enum Evaluation for "Evaluation"
            /// </summary>
            [EnumMember(Value = "Evaluation")]
            Evaluation,
            
            /// <summary>
            /// Enum Evaluationform for "EvaluationForm"
            /// </summary>
            [EnumMember(Value = "EvaluationForm")]
            Evaluationform,
            
            /// <summary>
            /// Enum Eventtype for "EventType"
            /// </summary>
            [EnumMember(Value = "EventType")]
            Eventtype,
            
            /// <summary>
            /// Enum Exports for "Exports"
            /// </summary>
            [EnumMember(Value = "Exports")]
            Exports,
            
            /// <summary>
            /// Enum Extension for "Extension"
            /// </summary>
            [EnumMember(Value = "Extension")]
            Extension,
            
            /// <summary>
            /// Enum Extensionpool for "ExtensionPool"
            /// </summary>
            [EnumMember(Value = "ExtensionPool")]
            Extensionpool,
            
            /// <summary>
            /// Enum Externalmetricsdata for "ExternalMetricsData"
            /// </summary>
            [EnumMember(Value = "ExternalMetricsData")]
            Externalmetricsdata,
            
            /// <summary>
            /// Enum Externalmetricsdefinition for "ExternalMetricsDefinition"
            /// </summary>
            [EnumMember(Value = "ExternalMetricsDefinition")]
            Externalmetricsdefinition,
            
            /// <summary>
            /// Enum Externalorganizationschema for "ExternalOrganizationSchema"
            /// </summary>
            [EnumMember(Value = "ExternalOrganizationSchema")]
            Externalorganizationschema,
            
            /// <summary>
            /// Enum Feedback for "Feedback"
            /// </summary>
            [EnumMember(Value = "Feedback")]
            Feedback,
            
            /// <summary>
            /// Enum Flow for "Flow"
            /// </summary>
            [EnumMember(Value = "Flow")]
            Flow,
            
            /// <summary>
            /// Enum Flowmilestone for "FlowMilestone"
            /// </summary>
            [EnumMember(Value = "FlowMilestone")]
            Flowmilestone,
            
            /// <summary>
            /// Enum Flowoutcome for "FlowOutcome"
            /// </summary>
            [EnumMember(Value = "FlowOutcome")]
            Flowoutcome,
            
            /// <summary>
            /// Enum Forecast for "Forecast"
            /// </summary>
            [EnumMember(Value = "Forecast")]
            Forecast,
            
            /// <summary>
            /// Enum Gdprrequest for "GdprRequest"
            /// </summary>
            [EnumMember(Value = "GdprRequest")]
            Gdprrequest,
            
            /// <summary>
            /// Enum Grammar for "Grammar"
            /// </summary>
            [EnumMember(Value = "Grammar")]
            Grammar,
            
            /// <summary>
            /// Enum Grammarlanguage for "GrammarLanguage"
            /// </summary>
            [EnumMember(Value = "GrammarLanguage")]
            Grammarlanguage,
            
            /// <summary>
            /// Enum Group for "Group"
            /// </summary>
            [EnumMember(Value = "Group")]
            Group,
            
            /// <summary>
            /// Enum Historicaldata for "HistoricalData"
            /// </summary>
            [EnumMember(Value = "HistoricalData")]
            Historicaldata,
            
            /// <summary>
            /// Enum Inbounddomain for "InboundDomain"
            /// </summary>
            [EnumMember(Value = "InboundDomain")]
            Inbounddomain,
            
            /// <summary>
            /// Enum Inboundroute for "InboundRoute"
            /// </summary>
            [EnumMember(Value = "InboundRoute")]
            Inboundroute,
            
            /// <summary>
            /// Enum Insightsettings for "InsightSettings"
            /// </summary>
            [EnumMember(Value = "InsightSettings")]
            Insightsettings,
            
            /// <summary>
            /// Enum Integration for "Integration"
            /// </summary>
            [EnumMember(Value = "Integration")]
            Integration,
            
            /// <summary>
            /// Enum Intentminer for "IntentMiner"
            /// </summary>
            [EnumMember(Value = "IntentMiner")]
            Intentminer,
            
            /// <summary>
            /// Enum Ivr for "IVR"
            /// </summary>
            [EnumMember(Value = "IVR")]
            Ivr,
            
            /// <summary>
            /// Enum Knowledgebase for "KnowledgeBase"
            /// </summary>
            [EnumMember(Value = "KnowledgeBase")]
            Knowledgebase,
            
            /// <summary>
            /// Enum Knowledgecategory for "KnowledgeCategory"
            /// </summary>
            [EnumMember(Value = "KnowledgeCategory")]
            Knowledgecategory,
            
            /// <summary>
            /// Enum Knowledgedocument for "KnowledgeDocument"
            /// </summary>
            [EnumMember(Value = "KnowledgeDocument")]
            Knowledgedocument,
            
            /// <summary>
            /// Enum Knowledgedocumentvariation for "KnowledgeDocumentVariation"
            /// </summary>
            [EnumMember(Value = "KnowledgeDocumentVariation")]
            Knowledgedocumentvariation,
            
            /// <summary>
            /// Enum Knowledgelabel for "KnowledgeLabel"
            /// </summary>
            [EnumMember(Value = "KnowledgeLabel")]
            Knowledgelabel,
            
            /// <summary>
            /// Enum Knowledgesearchfeedback for "KnowledgeSearchFeedback"
            /// </summary>
            [EnumMember(Value = "KnowledgeSearchFeedback")]
            Knowledgesearchfeedback,
            
            /// <summary>
            /// Enum Knowledgetraining for "KnowledgeTraining"
            /// </summary>
            [EnumMember(Value = "KnowledgeTraining")]
            Knowledgetraining,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            [EnumMember(Value = "Line")]
            Line,
            
            /// <summary>
            /// Enum Linebase for "LineBase"
            /// </summary>
            [EnumMember(Value = "LineBase")]
            Linebase,
            
            /// <summary>
            /// Enum Location for "Location"
            /// </summary>
            [EnumMember(Value = "Location")]
            Location,
            
            /// <summary>
            /// Enum Managementunit for "ManagementUnit"
            /// </summary>
            [EnumMember(Value = "ManagementUnit")]
            Managementunit,
            
            /// <summary>
            /// Enum Maxorgroutingutilizationcapacity for "MaxOrgRoutingUtilizationCapacity"
            /// </summary>
            [EnumMember(Value = "MaxOrgRoutingUtilizationCapacity")]
            Maxorgroutingutilizationcapacity,
            
            /// <summary>
            /// Enum Mediadiagnosticstracefile for "MediaDiagnosticsTraceFile"
            /// </summary>
            [EnumMember(Value = "MediaDiagnosticsTraceFile")]
            Mediadiagnosticstracefile,
            
            /// <summary>
            /// Enum Messagingcampaign for "MessagingCampaign"
            /// </summary>
            [EnumMember(Value = "MessagingCampaign")]
            Messagingcampaign,
            
            /// <summary>
            /// Enum Messagingcampaignschedule for "MessagingCampaignSchedule"
            /// </summary>
            [EnumMember(Value = "MessagingCampaignSchedule")]
            Messagingcampaignschedule,
            
            /// <summary>
            /// Enum Metric for "Metric"
            /// </summary>
            [EnumMember(Value = "Metric")]
            Metric,
            
            /// <summary>
            /// Enum Module for "Module"
            /// </summary>
            [EnumMember(Value = "Module")]
            Module,
            
            /// <summary>
            /// Enum Numberorder for "NumberOrder"
            /// </summary>
            [EnumMember(Value = "NumberOrder")]
            Numberorder,
            
            /// <summary>
            /// Enum Numberplan for "NumberPlan"
            /// </summary>
            [EnumMember(Value = "NumberPlan")]
            Numberplan,
            
            /// <summary>
            /// Enum Oauthclient for "OAuthClient"
            /// </summary>
            [EnumMember(Value = "OAuthClient")]
            Oauthclient,
            
            /// <summary>
            /// Enum Oauthclientauthorization for "OAuthClientAuthorization"
            /// </summary>
            [EnumMember(Value = "OAuthClientAuthorization")]
            Oauthclientauthorization,
            
            /// <summary>
            /// Enum Organization for "Organization"
            /// </summary>
            [EnumMember(Value = "Organization")]
            Organization,
            
            /// <summary>
            /// Enum Organizationauthorizationtrust for "OrganizationAuthorizationTrust"
            /// </summary>
            [EnumMember(Value = "OrganizationAuthorizationTrust")]
            Organizationauthorizationtrust,
            
            /// <summary>
            /// Enum Organizationauthorizationusertrust for "OrganizationAuthorizationUserTrust"
            /// </summary>
            [EnumMember(Value = "OrganizationAuthorizationUserTrust")]
            Organizationauthorizationusertrust,
            
            /// <summary>
            /// Enum Organizationfeature for "OrganizationFeature"
            /// </summary>
            [EnumMember(Value = "OrganizationFeature")]
            Organizationfeature,
            
            /// <summary>
            /// Enum Organizationintegrationsaccess for "OrganizationIntegrationsAccess"
            /// </summary>
            [EnumMember(Value = "OrganizationIntegrationsAccess")]
            Organizationintegrationsaccess,
            
            /// <summary>
            /// Enum Organizationlimits for "OrganizationLimits"
            /// </summary>
            [EnumMember(Value = "OrganizationLimits")]
            Organizationlimits,
            
            /// <summary>
            /// Enum Organizationsettings for "OrganizationSettings"
            /// </summary>
            [EnumMember(Value = "OrganizationSettings")]
            Organizationsettings,
            
            /// <summary>
            /// Enum Orphanedrecording for "OrphanedRecording"
            /// </summary>
            [EnumMember(Value = "OrphanedRecording")]
            Orphanedrecording,
            
            /// <summary>
            /// Enum Outbounddomain for "OutboundDomain"
            /// </summary>
            [EnumMember(Value = "OutboundDomain")]
            Outbounddomain,
            
            /// <summary>
            /// Enum Outboundroute for "OutboundRoute"
            /// </summary>
            [EnumMember(Value = "OutboundRoute")]
            Outboundroute,
            
            /// <summary>
            /// Enum Outcome for "Outcome"
            /// </summary>
            [EnumMember(Value = "Outcome")]
            Outcome,
            
            /// <summary>
            /// Enum Pcaps for "Pcaps"
            /// </summary>
            [EnumMember(Value = "Pcaps")]
            Pcaps,
            
            /// <summary>
            /// Enum Phone for "Phone"
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone,
            
            /// <summary>
            /// Enum Phonebase for "PhoneBase"
            /// </summary>
            [EnumMember(Value = "PhoneBase")]
            Phonebase,
            
            /// <summary>
            /// Enum Planninggroup for "PlanningGroup"
            /// </summary>
            [EnumMember(Value = "PlanningGroup")]
            Planninggroup,
            
            /// <summary>
            /// Enum Policy for "Policy"
            /// </summary>
            [EnumMember(Value = "Policy")]
            Policy,
            
            /// <summary>
            /// Enum Predictor for "Predictor"
            /// </summary>
            [EnumMember(Value = "Predictor")]
            Predictor,
            
            /// <summary>
            /// Enum Product for "Product"
            /// </summary>
            [EnumMember(Value = "Product")]
            Product,
            
            /// <summary>
            /// Enum Profile for "Profile"
            /// </summary>
            [EnumMember(Value = "Profile")]
            Profile,
            
            /// <summary>
            /// Enum Profilemembers for "ProfileMembers"
            /// </summary>
            [EnumMember(Value = "ProfileMembers")]
            Profilemembers,
            
            /// <summary>
            /// Enum Program for "Program"
            /// </summary>
            [EnumMember(Value = "Program")]
            Program,
            
            /// <summary>
            /// Enum Prompt for "Prompt"
            /// </summary>
            [EnumMember(Value = "Prompt")]
            Prompt,
            
            /// <summary>
            /// Enum Promptresource for "PromptResource"
            /// </summary>
            [EnumMember(Value = "PromptResource")]
            Promptresource,
            
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Recording for "Recording"
            /// </summary>
            [EnumMember(Value = "Recording")]
            Recording,
            
            /// <summary>
            /// Enum Recordingannotation for "RecordingAnnotation"
            /// </summary>
            [EnumMember(Value = "RecordingAnnotation")]
            Recordingannotation,
            
            /// <summary>
            /// Enum Recordingkey for "RecordingKey"
            /// </summary>
            [EnumMember(Value = "RecordingKey")]
            Recordingkey,
            
            /// <summary>
            /// Enum Recordingkeyconfig for "RecordingKeyConfig"
            /// </summary>
            [EnumMember(Value = "RecordingKeyConfig")]
            Recordingkeyconfig,
            
            /// <summary>
            /// Enum Recordingsettings for "RecordingSettings"
            /// </summary>
            [EnumMember(Value = "RecordingSettings")]
            Recordingsettings,
            
            /// <summary>
            /// Enum Response for "Response"
            /// </summary>
            [EnumMember(Value = "Response")]
            Response,
            
            /// <summary>
            /// Enum Responseasset for "ResponseAsset"
            /// </summary>
            [EnumMember(Value = "ResponseAsset")]
            Responseasset,
            
            /// <summary>
            /// Enum Role for "Role"
            /// </summary>
            [EnumMember(Value = "Role")]
            Role,
            
            /// <summary>
            /// Enum Rolesettings for "RoleSettings"
            /// </summary>
            [EnumMember(Value = "RoleSettings")]
            Rolesettings,
            
            /// <summary>
            /// Enum Row for "Row"
            /// </summary>
            [EnumMember(Value = "Row")]
            Row,
            
            /// <summary>
            /// Enum Routingtranscriptionsettings for "RoutingTranscriptionSettings"
            /// </summary>
            [EnumMember(Value = "RoutingTranscriptionSettings")]
            Routingtranscriptionsettings,
            
            /// <summary>
            /// Enum Routingutilizationtag for "RoutingUtilizationTag"
            /// </summary>
            [EnumMember(Value = "RoutingUtilizationTag")]
            Routingutilizationtag,
            
            /// <summary>
            /// Enum Rule for "Rule"
            /// </summary>
            [EnumMember(Value = "Rule")]
            Rule,
            
            /// <summary>
            /// Enum Ruleset for "RuleSet"
            /// </summary>
            [EnumMember(Value = "RuleSet")]
            Ruleset,
            
            /// <summary>
            /// Enum Schedule for "Schedule"
            /// </summary>
            [EnumMember(Value = "Schedule")]
            Schedule,
            
            /// <summary>
            /// Enum Scheduledexports for "ScheduledExports"
            /// </summary>
            [EnumMember(Value = "ScheduledExports")]
            Scheduledexports,
            
            /// <summary>
            /// Enum Schedulegroup for "ScheduleGroup"
            /// </summary>
            [EnumMember(Value = "ScheduleGroup")]
            Schedulegroup,
            
            /// <summary>
            /// Enum Schema for "Schema"
            /// </summary>
            [EnumMember(Value = "Schema")]
            Schema,
            
            /// <summary>
            /// Enum Screenrecording for "ScreenRecording"
            /// </summary>
            [EnumMember(Value = "ScreenRecording")]
            Screenrecording,
            
            /// <summary>
            /// Enum Segment for "Segment"
            /// </summary>
            [EnumMember(Value = "Segment")]
            Segment,
            
            /// <summary>
            /// Enum Sentimentfeedback for "SentimentFeedback"
            /// </summary>
            [EnumMember(Value = "SentimentFeedback")]
            Sentimentfeedback,
            
            /// <summary>
            /// Enum Sequence for "Sequence"
            /// </summary>
            [EnumMember(Value = "Sequence")]
            Sequence,
            
            /// <summary>
            /// Enum Sequenceschedule for "SequenceSchedule"
            /// </summary>
            [EnumMember(Value = "SequenceSchedule")]
            Sequenceschedule,
            
            /// <summary>
            /// Enum Servicegoaltemplate for "ServiceGoalTemplate"
            /// </summary>
            [EnumMember(Value = "ServiceGoalTemplate")]
            Servicegoaltemplate,
            
            /// <summary>
            /// Enum Sessiontype for "SessionType"
            /// </summary>
            [EnumMember(Value = "SessionType")]
            Sessiontype,
            
            /// <summary>
            /// Enum Shifttrade for "ShiftTrade"
            /// </summary>
            [EnumMember(Value = "ShiftTrade")]
            Shifttrade,
            
            /// <summary>
            /// Enum Site for "Site"
            /// </summary>
            [EnumMember(Value = "Site")]
            Site,
            
            /// <summary>
            /// Enum Skillsgroup for "SkillsGroup"
            /// </summary>
            [EnumMember(Value = "SkillsGroup")]
            Skillsgroup,
            
            /// <summary>
            /// Enum Skillgroupdefinition for "SkillGroupDefinition"
            /// </summary>
            [EnumMember(Value = "SkillGroupDefinition")]
            Skillgroupdefinition,
            
            /// <summary>
            /// Enum Speechtextanalyticssettings for "SpeechTextAnalyticsSettings"
            /// </summary>
            [EnumMember(Value = "SpeechTextAnalyticsSettings")]
            Speechtextanalyticssettings,
            
            /// <summary>
            /// Enum Staffinggroup for "StaffingGroup"
            /// </summary>
            [EnumMember(Value = "StaffingGroup")]
            Staffinggroup,
            
            /// <summary>
            /// Enum Status for "Status"
            /// </summary>
            [EnumMember(Value = "Status")]
            Status,
            
            /// <summary>
            /// Enum Supportedcontent for "SupportedContent"
            /// </summary>
            [EnumMember(Value = "SupportedContent")]
            Supportedcontent,
            
            /// <summary>
            /// Enum Supportfile for "SupportFile"
            /// </summary>
            [EnumMember(Value = "SupportFile")]
            Supportfile,
            
            /// <summary>
            /// Enum Survey for "Survey"
            /// </summary>
            [EnumMember(Value = "Survey")]
            Survey,
            
            /// <summary>
            /// Enum Surveyform for "SurveyForm"
            /// </summary>
            [EnumMember(Value = "SurveyForm")]
            Surveyform,
            
            /// <summary>
            /// Enum Tag for "Tag"
            /// </summary>
            [EnumMember(Value = "Tag")]
            Tag,
            
            /// <summary>
            /// Enum Team for "Team"
            /// </summary>
            [EnumMember(Value = "Team")]
            Team,
            
            /// <summary>
            /// Enum Timeofflimit for "TimeOffLimit"
            /// </summary>
            [EnumMember(Value = "TimeOffLimit")]
            Timeofflimit,
            
            /// <summary>
            /// Enum Timeoffplan for "TimeOffPlan"
            /// </summary>
            [EnumMember(Value = "TimeOffPlan")]
            Timeoffplan,
            
            /// <summary>
            /// Enum Timeoffrequest for "TimeOffRequest"
            /// </summary>
            [EnumMember(Value = "TimeOffRequest")]
            Timeoffrequest,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic,
            
            /// <summary>
            /// Enum Topicminer for "TopicMiner"
            /// </summary>
            [EnumMember(Value = "TopicMiner")]
            Topicminer,
            
            /// <summary>
            /// Enum Transcriptionsettings for "TranscriptionSettings"
            /// </summary>
            [EnumMember(Value = "TranscriptionSettings")]
            Transcriptionsettings,
            
            /// <summary>
            /// Enum Trigger for "Trigger"
            /// </summary>
            [EnumMember(Value = "Trigger")]
            Trigger,
            
            /// <summary>
            /// Enum Trunk for "Trunk"
            /// </summary>
            [EnumMember(Value = "Trunk")]
            Trunk,
            
            /// <summary>
            /// Enum Trunkbase for "TrunkBase"
            /// </summary>
            [EnumMember(Value = "TrunkBase")]
            Trunkbase,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Userlanguage for "UserLanguage"
            /// </summary>
            [EnumMember(Value = "UserLanguage")]
            Userlanguage,
            
            /// <summary>
            /// Enum Userpresence for "UserPresence"
            /// </summary>
            [EnumMember(Value = "UserPresence")]
            Userpresence,
            
            /// <summary>
            /// Enum Userskill for "UserSkill"
            /// </summary>
            [EnumMember(Value = "UserSkill")]
            Userskill,
            
            /// <summary>
            /// Enum Voicemailpolicy for "VoicemailPolicy"
            /// </summary>
            [EnumMember(Value = "VoicemailPolicy")]
            Voicemailpolicy,
            
            /// <summary>
            /// Enum Voicemailuserpolicy for "VoicemailUserPolicy"
            /// </summary>
            [EnumMember(Value = "VoicemailUserPolicy")]
            Voicemailuserpolicy,
            
            /// <summary>
            /// Enum Webhook for "Webhook"
            /// </summary>
            [EnumMember(Value = "Webhook")]
            Webhook,
            
            /// <summary>
            /// Enum Workbin for "Workbin"
            /// </summary>
            [EnumMember(Value = "Workbin")]
            Workbin,
            
            /// <summary>
            /// Enum Workitem for "Workitem"
            /// </summary>
            [EnumMember(Value = "Workitem")]
            Workitem,
            
            /// <summary>
            /// Enum Workplan for "WorkPlan"
            /// </summary>
            [EnumMember(Value = "WorkPlan")]
            Workplan,
            
            /// <summary>
            /// Enum Workplanrotation for "WorkPlanRotation"
            /// </summary>
            [EnumMember(Value = "WorkPlanRotation")]
            Workplanrotation,
            
            /// <summary>
            /// Enum Workspace for "Workspace"
            /// </summary>
            [EnumMember(Value = "Workspace")]
            Workspace,
            
            /// <summary>
            /// Enum Worktype for "Worktype"
            /// </summary>
            [EnumMember(Value = "Worktype")]
            Worktype,
            
            /// <summary>
            /// Enum Wrapupcode for "WrapupCode"
            /// </summary>
            [EnumMember(Value = "WrapupCode")]
            Wrapupcode,
            
            /// <summary>
            /// Enum Wrapupcodemapping for "WrapUpCodeMapping"
            /// </summary>
            [EnumMember(Value = "WrapUpCodeMapping")]
            Wrapupcodemapping,
            
            /// <summary>
            /// Enum Participant for "Participant"
            /// </summary>
            [EnumMember(Value = "Participant")]
            Participant
        }
        /// <summary>
        /// Type of the entity that was changed
        /// </summary>
        /// <value>Type of the entity that was changed</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityChange" /> class.
        /// </summary>
        /// <param name="EntityId">Id of the entity that was changed.</param>
        /// <param name="EntityName">Name of the entity that was changed.</param>
        /// <param name="EntityType">Type of the entity that was changed.</param>
        /// <param name="OldValues">Previous values for the entity..</param>
        /// <param name="NewValues">New values for the entity..</param>
        public EntityChange(string EntityId = null, string EntityName = null, EntityTypeEnum? EntityType = null, List<string> OldValues = null, List<string> NewValues = null)
        {
            this.EntityId = EntityId;
            this.EntityName = EntityName;
            this.EntityType = EntityType;
            this.OldValues = OldValues;
            this.NewValues = NewValues;
            
        }
        


        /// <summary>
        /// Id of the entity that was changed
        /// </summary>
        /// <value>Id of the entity that was changed</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }



        /// <summary>
        /// Name of the entity that was changed
        /// </summary>
        /// <value>Name of the entity that was changed</value>
        [DataMember(Name="entityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }





        /// <summary>
        /// Previous values for the entity.
        /// </summary>
        /// <value>Previous values for the entity.</value>
        [DataMember(Name="oldValues", EmitDefaultValue=false)]
        public List<string> OldValues { get; set; }



        /// <summary>
        /// New values for the entity.
        /// </summary>
        /// <value>New values for the entity.</value>
        [DataMember(Name="newValues", EmitDefaultValue=false)]
        public List<string> NewValues { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityChange {\n");

            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  OldValues: ").Append(OldValues).Append("\n");
            sb.Append("  NewValues: ").Append(NewValues).Append("\n");
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
            return this.Equals(obj as EntityChange);
        }

        /// <summary>
        /// Returns true if EntityChange instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EntityId == other.EntityId ||
                    this.EntityId != null &&
                    this.EntityId.Equals(other.EntityId)
                ) &&
                (
                    this.EntityName == other.EntityName ||
                    this.EntityName != null &&
                    this.EntityName.Equals(other.EntityName)
                ) &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.OldValues == other.OldValues ||
                    this.OldValues != null &&
                    this.OldValues.SequenceEqual(other.OldValues)
                ) &&
                (
                    this.NewValues == other.NewValues ||
                    this.NewValues != null &&
                    this.NewValues.SequenceEqual(other.NewValues)
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
                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();

                if (this.EntityName != null)
                    hash = hash * 59 + this.EntityName.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.OldValues != null)
                    hash = hash * 59 + this.OldValues.GetHashCode();

                if (this.NewValues != null)
                    hash = hash * 59 + this.NewValues.GetHashCode();

                return hash;
            }
        }
    }

}
