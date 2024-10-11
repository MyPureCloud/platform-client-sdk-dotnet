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
    /// ReportingExportJobResponse
    /// </summary>
    [DataContract]
    public partial class ReportingExportJobResponse :  IEquatable<ReportingExportJobResponse>
    {
        /// <summary>
        /// The current status of the export request
        /// </summary>
        /// <value>The current status of the export request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Submitted for "SUBMITTED"
            /// </summary>
            [EnumMember(Value = "SUBMITTED")]
            Submitted,
            
            /// <summary>
            /// Enum Running for "RUNNING"
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            Running,
            
            /// <summary>
            /// Enum Cancelling for "CANCELLING"
            /// </summary>
            [EnumMember(Value = "CANCELLING")]
            Cancelling,
            
            /// <summary>
            /// Enum Cancelled for "CANCELLED"
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            Cancelled,
            
            /// <summary>
            /// Enum Completed for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            Completed,
            
            /// <summary>
            /// Enum CompletedWithPartialResults for "COMPLETED_WITH_PARTIAL_RESULTS"
            /// </summary>
            [EnumMember(Value = "COMPLETED_WITH_PARTIAL_RESULTS")]
            CompletedWithPartialResults,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }
        /// <summary>
        /// The requested format of the exported data
        /// </summary>
        /// <value>The requested format of the exported data</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExportFormatEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Csv for "CSV"
            /// </summary>
            [EnumMember(Value = "CSV")]
            Csv,
            
            /// <summary>
            /// Enum Pdf for "PDF"
            /// </summary>
            [EnumMember(Value = "PDF")]
            Pdf
        }
        /// <summary>
        /// The type of view export job to be created
        /// </summary>
        /// <value>The type of view export job to be created</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ViewTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum QueuePerformanceSummaryView for "QUEUE_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_PERFORMANCE_SUMMARY_VIEW")]
            QueuePerformanceSummaryView,
            
            /// <summary>
            /// Enum QueuePerformanceDetailView for "QUEUE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_PERFORMANCE_DETAIL_VIEW")]
            QueuePerformanceDetailView,
            
            /// <summary>
            /// Enum InteractionSearchView for "INTERACTION_SEARCH_VIEW"
            /// </summary>
            [EnumMember(Value = "INTERACTION_SEARCH_VIEW")]
            InteractionSearchView,
            
            /// <summary>
            /// Enum AgentPerformanceSummaryView for "AGENT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_SUMMARY_VIEW")]
            AgentPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentPerformanceDetailView for "AGENT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_DETAIL_VIEW")]
            AgentPerformanceDetailView,
            
            /// <summary>
            /// Enum AgentStatusSummaryView for "AGENT_STATUS_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_SUMMARY_VIEW")]
            AgentStatusSummaryView,
            
            /// <summary>
            /// Enum AgentStatusDetailView for "AGENT_STATUS_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_DETAIL_VIEW")]
            AgentStatusDetailView,
            
            /// <summary>
            /// Enum AgentEvaluationSummaryView for "AGENT_EVALUATION_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_SUMMARY_VIEW")]
            AgentEvaluationSummaryView,
            
            /// <summary>
            /// Enum AgentEvaluationDetailView for "AGENT_EVALUATION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_DETAIL_VIEW")]
            AgentEvaluationDetailView,
            
            /// <summary>
            /// Enum AgentQueueDetailView for "AGENT_QUEUE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_QUEUE_DETAIL_VIEW")]
            AgentQueueDetailView,
            
            /// <summary>
            /// Enum AgentInteractionDetailView for "AGENT_INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_INTERACTION_DETAIL_VIEW")]
            AgentInteractionDetailView,
            
            /// <summary>
            /// Enum AbandonInsightsView for "ABANDON_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ABANDON_INSIGHTS_VIEW")]
            AbandonInsightsView,
            
            /// <summary>
            /// Enum SkillsPerformanceView for "SKILLS_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "SKILLS_PERFORMANCE_VIEW")]
            SkillsPerformanceView,
            
            /// <summary>
            /// Enum SurveyFormPerformanceSummaryView for "SURVEY_FORM_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "SURVEY_FORM_PERFORMANCE_SUMMARY_VIEW")]
            SurveyFormPerformanceSummaryView,
            
            /// <summary>
            /// Enum SurveyFormPerformanceDetailView for "SURVEY_FORM_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "SURVEY_FORM_PERFORMANCE_DETAIL_VIEW")]
            SurveyFormPerformanceDetailView,
            
            /// <summary>
            /// Enum DnisPerformanceSummaryView for "DNIS_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "DNIS_PERFORMANCE_SUMMARY_VIEW")]
            DnisPerformanceSummaryView,
            
            /// <summary>
            /// Enum DnisPerformanceDetailView for "DNIS_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "DNIS_PERFORMANCE_DETAIL_VIEW")]
            DnisPerformanceDetailView,
            
            /// <summary>
            /// Enum WrapUpPerformanceSummaryView for "WRAP_UP_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "WRAP_UP_PERFORMANCE_SUMMARY_VIEW")]
            WrapUpPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentWrapUpPerformanceDetailView for "AGENT_WRAP_UP_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WRAP_UP_PERFORMANCE_DETAIL_VIEW")]
            AgentWrapUpPerformanceDetailView,
            
            /// <summary>
            /// Enum QueueActivitySummaryView for "QUEUE_ACTIVITY_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_ACTIVITY_SUMMARY_VIEW")]
            QueueActivitySummaryView,
            
            /// <summary>
            /// Enum QueueActivityDetailView for "QUEUE_ACTIVITY_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_ACTIVITY_DETAIL_VIEW")]
            QueueActivityDetailView,
            
            /// <summary>
            /// Enum AgentQueueActivitySummaryView for "AGENT_QUEUE_ACTIVITY_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_QUEUE_ACTIVITY_SUMMARY_VIEW")]
            AgentQueueActivitySummaryView,
            
            /// <summary>
            /// Enum QueueAgentDetailView for "QUEUE_AGENT_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_AGENT_DETAIL_VIEW")]
            QueueAgentDetailView,
            
            /// <summary>
            /// Enum QueueInteractionDetailView for "QUEUE_INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_INTERACTION_DETAIL_VIEW")]
            QueueInteractionDetailView,
            
            /// <summary>
            /// Enum AgentScheduleDetailView for "AGENT_SCHEDULE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCHEDULE_DETAIL_VIEW")]
            AgentScheduleDetailView,
            
            /// <summary>
            /// Enum IvrPerformanceSummaryView for "IVR_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "IVR_PERFORMANCE_SUMMARY_VIEW")]
            IvrPerformanceSummaryView,
            
            /// <summary>
            /// Enum IvrPerformanceDetailView for "IVR_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "IVR_PERFORMANCE_DETAIL_VIEW")]
            IvrPerformanceDetailView,
            
            /// <summary>
            /// Enum AnswerInsightsView for "ANSWER_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ANSWER_INSIGHTS_VIEW")]
            AnswerInsightsView,
            
            /// <summary>
            /// Enum HandleInsightsView for "HANDLE_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "HANDLE_INSIGHTS_VIEW")]
            HandleInsightsView,
            
            /// <summary>
            /// Enum TalkInsightsView for "TALK_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "TALK_INSIGHTS_VIEW")]
            TalkInsightsView,
            
            /// <summary>
            /// Enum HoldInsightsView for "HOLD_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "HOLD_INSIGHTS_VIEW")]
            HoldInsightsView,
            
            /// <summary>
            /// Enum AcwInsightsView for "ACW_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ACW_INSIGHTS_VIEW")]
            AcwInsightsView,
            
            /// <summary>
            /// Enum WaitInsightsView for "WAIT_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "WAIT_INSIGHTS_VIEW")]
            WaitInsightsView,
            
            /// <summary>
            /// Enum AgentWrapUpPerformanceIntervalDetailView for "AGENT_WRAP_UP_PERFORMANCE_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WRAP_UP_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
            AgentWrapUpPerformanceIntervalDetailView,
            
            /// <summary>
            /// Enum FlowOutcomeSummaryView for "FLOW_OUTCOME_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_SUMMARY_VIEW")]
            FlowOutcomeSummaryView,
            
            /// <summary>
            /// Enum FlowOutcomePerformanceDetailView for "FLOW_OUTCOME_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_PERFORMANCE_DETAIL_VIEW")]
            FlowOutcomePerformanceDetailView,
            
            /// <summary>
            /// Enum FlowOutcomePerformanceIntervalDetailView for "FLOW_OUTCOME_PERFORMANCE_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
            FlowOutcomePerformanceIntervalDetailView,
            
            /// <summary>
            /// Enum FlowDestinationSummaryView for "FLOW_DESTINATION_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_DESTINATION_SUMMARY_VIEW")]
            FlowDestinationSummaryView,
            
            /// <summary>
            /// Enum FlowDestinationDetailView for "FLOW_DESTINATION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_DESTINATION_DETAIL_VIEW")]
            FlowDestinationDetailView,
            
            /// <summary>
            /// Enum ApiUsageView for "API_USAGE_VIEW"
            /// </summary>
            [EnumMember(Value = "API_USAGE_VIEW")]
            ApiUsageView,
            
            /// <summary>
            /// Enum ScheduledCallbacksView for "SCHEDULED_CALLBACKS_VIEW"
            /// </summary>
            [EnumMember(Value = "SCHEDULED_CALLBACKS_VIEW")]
            ScheduledCallbacksView,
            
            /// <summary>
            /// Enum ContentSearchView for "CONTENT_SEARCH_VIEW"
            /// </summary>
            [EnumMember(Value = "CONTENT_SEARCH_VIEW")]
            ContentSearchView,
            
            /// <summary>
            /// Enum LandingPage for "LANDING_PAGE"
            /// </summary>
            [EnumMember(Value = "LANDING_PAGE")]
            LandingPage,
            
            /// <summary>
            /// Enum DashboardSummary for "DASHBOARD_SUMMARY"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_SUMMARY")]
            DashboardSummary,
            
            /// <summary>
            /// Enum DashboardDetail for "DASHBOARD_DETAIL"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_DETAIL")]
            DashboardDetail,
            
            /// <summary>
            /// Enum DashboardUsers for "DASHBOARD_USERS"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_USERS")]
            DashboardUsers,
            
            /// <summary>
            /// Enum DashboardUsersDetail for "DASHBOARD_USERS_DETAIL"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_USERS_DETAIL")]
            DashboardUsersDetail,
            
            /// <summary>
            /// Enum JourneyActionMapSummaryView for "JOURNEY_ACTION_MAP_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "JOURNEY_ACTION_MAP_SUMMARY_VIEW")]
            JourneyActionMapSummaryView,
            
            /// <summary>
            /// Enum JourneyOutcomeSummaryView for "JOURNEY_OUTCOME_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "JOURNEY_OUTCOME_SUMMARY_VIEW")]
            JourneyOutcomeSummaryView,
            
            /// <summary>
            /// Enum JourneySegmentSummaryView for "JOURNEY_SEGMENT_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "JOURNEY_SEGMENT_SUMMARY_VIEW")]
            JourneySegmentSummaryView,
            
            /// <summary>
            /// Enum AgentDevelopmentDetailView for "AGENT_DEVELOPMENT_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_DEVELOPMENT_DETAIL_VIEW")]
            AgentDevelopmentDetailView,
            
            /// <summary>
            /// Enum AgentDevelopmentDetailMeView for "AGENT_DEVELOPMENT_DETAIL_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_DEVELOPMENT_DETAIL_ME_VIEW")]
            AgentDevelopmentDetailMeView,
            
            /// <summary>
            /// Enum AgentDevelopmentSummaryView for "AGENT_DEVELOPMENT_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_DEVELOPMENT_SUMMARY_VIEW")]
            AgentDevelopmentSummaryView,
            
            /// <summary>
            /// Enum AgentPerformanceMeView for "AGENT_PERFORMANCE_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_ME_VIEW")]
            AgentPerformanceMeView,
            
            /// <summary>
            /// Enum AgentStatusMeView for "AGENT_STATUS_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_ME_VIEW")]
            AgentStatusMeView,
            
            /// <summary>
            /// Enum AgentEvaluationMeView for "AGENT_EVALUATION_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_ME_VIEW")]
            AgentEvaluationMeView,
            
            /// <summary>
            /// Enum AgentScorecardView for "AGENT_SCORECARD_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCORECARD_VIEW")]
            AgentScorecardView,
            
            /// <summary>
            /// Enum AgentScorecardMeView for "AGENT_SCORECARD_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCORECARD_ME_VIEW")]
            AgentScorecardMeView,
            
            /// <summary>
            /// Enum AgentGamificationLeadershipView for "AGENT_GAMIFICATION_LEADERSHIP_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_GAMIFICATION_LEADERSHIP_VIEW")]
            AgentGamificationLeadershipView,
            
            /// <summary>
            /// Enum AgentScheduleMeView for "AGENT_SCHEDULE_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCHEDULE_ME_VIEW")]
            AgentScheduleMeView,
            
            /// <summary>
            /// Enum BotPerformanceSummaryView for "BOT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "BOT_PERFORMANCE_SUMMARY_VIEW")]
            BotPerformanceSummaryView,
            
            /// <summary>
            /// Enum BotPerformanceDetailView for "BOT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "BOT_PERFORMANCE_DETAIL_VIEW")]
            BotPerformanceDetailView,
            
            /// <summary>
            /// Enum ScheduledExportsView for "SCHEDULED_EXPORTS_VIEW"
            /// </summary>
            [EnumMember(Value = "SCHEDULED_EXPORTS_VIEW")]
            ScheduledExportsView,
            
            /// <summary>
            /// Enum TopicTrendSummaryView for "TOPIC_TREND_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "TOPIC_TREND_SUMMARY_VIEW")]
            TopicTrendSummaryView,
            
            /// <summary>
            /// Enum TopicTrendDetailView for "TOPIC_TREND_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "TOPIC_TREND_DETAIL_VIEW")]
            TopicTrendDetailView,
            
            /// <summary>
            /// Enum ActionMapBlockedConstraintsDetailView for "ACTION_MAP_BLOCKED_CONSTRAINTS_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "ACTION_MAP_BLOCKED_CONSTRAINTS_DETAIL_VIEW")]
            ActionMapBlockedConstraintsDetailView,
            
            /// <summary>
            /// Enum ActionMapBlockedConstraintsIntervalDetailView for "ACTION_MAP_BLOCKED_CONSTRAINTS_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "ACTION_MAP_BLOCKED_CONSTRAINTS_INTERVAL_DETAIL_VIEW")]
            ActionMapBlockedConstraintsIntervalDetailView,
            
            /// <summary>
            /// Enum FlowMilestonePerformanceDetailView for "FLOW_MILESTONE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_MILESTONE_PERFORMANCE_DETAIL_VIEW")]
            FlowMilestonePerformanceDetailView,
            
            /// <summary>
            /// Enum FlowMilestonePerformanceIntervalDetailView for "FLOW_MILESTONE_PERFORMANCE_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_MILESTONE_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
            FlowMilestonePerformanceIntervalDetailView,
            
            /// <summary>
            /// Enum AgentTopicSummaryView for "AGENT_TOPIC_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_TOPIC_SUMMARY_VIEW")]
            AgentTopicSummaryView,
            
            /// <summary>
            /// Enum AgentTopicDetailView for "AGENT_TOPIC_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_TOPIC_DETAIL_VIEW")]
            AgentTopicDetailView,
            
            /// <summary>
            /// Enum QueueTopicSummaryView for "QUEUE_TOPIC_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_TOPIC_SUMMARY_VIEW")]
            QueueTopicSummaryView,
            
            /// <summary>
            /// Enum QueueTopicDetailView for "QUEUE_TOPIC_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_TOPIC_DETAIL_VIEW")]
            QueueTopicDetailView,
            
            /// <summary>
            /// Enum FlowTopicSummaryView for "FLOW_TOPIC_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_TOPIC_SUMMARY_VIEW")]
            FlowTopicSummaryView,
            
            /// <summary>
            /// Enum FlowTopicDetailView for "FLOW_TOPIC_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_TOPIC_DETAIL_VIEW")]
            FlowTopicDetailView,
            
            /// <summary>
            /// Enum AgentInteractionsMeView for "AGENT_INTERACTIONS_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_INTERACTIONS_ME_VIEW")]
            AgentInteractionsMeView,
            
            /// <summary>
            /// Enum AlertRulesView for "ALERT_RULES_VIEW"
            /// </summary>
            [EnumMember(Value = "ALERT_RULES_VIEW")]
            AlertRulesView,
            
            /// <summary>
            /// Enum ConfigureAlertRuleView for "CONFIGURE_ALERT_RULE_VIEW"
            /// </summary>
            [EnumMember(Value = "CONFIGURE_ALERT_RULE_VIEW")]
            ConfigureAlertRuleView,
            
            /// <summary>
            /// Enum PredictiveRoutingView for "PREDICTIVE_ROUTING_VIEW"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE_ROUTING_VIEW")]
            PredictiveRoutingView,
            
            /// <summary>
            /// Enum PredictiveRoutingQueueOverview for "PREDICTIVE_ROUTING_QUEUE_OVERVIEW"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE_ROUTING_QUEUE_OVERVIEW")]
            PredictiveRoutingQueueOverview,
            
            /// <summary>
            /// Enum PredictiveRoutingModelView for "PREDICTIVE_ROUTING_MODEL_VIEW"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE_ROUTING_MODEL_VIEW")]
            PredictiveRoutingModelView,
            
            /// <summary>
            /// Enum PredictiveRoutingImpactView for "PREDICTIVE_ROUTING_IMPACT_VIEW"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE_ROUTING_IMPACT_VIEW")]
            PredictiveRoutingImpactView,
            
            /// <summary>
            /// Enum DataActionsPerformanceSummaryView for "DATA_ACTIONS_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "DATA_ACTIONS_PERFORMANCE_SUMMARY_VIEW")]
            DataActionsPerformanceSummaryView,
            
            /// <summary>
            /// Enum DataActionsPerformanceDetailView for "DATA_ACTIONS_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "DATA_ACTIONS_PERFORMANCE_DETAIL_VIEW")]
            DataActionsPerformanceDetailView,
            
            /// <summary>
            /// Enum AgentTimelineSummaryView for "AGENT_TIMELINE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_TIMELINE_SUMMARY_VIEW")]
            AgentTimelineSummaryView,
            
            /// <summary>
            /// Enum AgentTimelineDetailView for "AGENT_TIMELINE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_TIMELINE_DETAIL_VIEW")]
            AgentTimelineDetailView,
            
            /// <summary>
            /// Enum AgentLoginLogoutSummaryView for "AGENT_LOGIN_LOGOUT_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_LOGIN_LOGOUT_SUMMARY_VIEW")]
            AgentLoginLogoutSummaryView,
            
            /// <summary>
            /// Enum AgentLoginLogoutDetailView for "AGENT_LOGIN_LOGOUT_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_LOGIN_LOGOUT_DETAIL_VIEW")]
            AgentLoginLogoutDetailView,
            
            /// <summary>
            /// Enum CampaignPerformanceSummaryView for "CAMPAIGN_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN_PERFORMANCE_SUMMARY_VIEW")]
            CampaignPerformanceSummaryView,
            
            /// <summary>
            /// Enum CampaignPerformanceDetailView for "CAMPAIGN_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN_PERFORMANCE_DETAIL_VIEW")]
            CampaignPerformanceDetailView,
            
            /// <summary>
            /// Enum KnowledgePerformanceView for "KNOWLEDGE_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "KNOWLEDGE_PERFORMANCE_VIEW")]
            KnowledgePerformanceView,
            
            /// <summary>
            /// Enum AgentScorecardInsightsSummaryView for "AGENT_SCORECARD_INSIGHTS_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCORECARD_INSIGHTS_SUMMARY_VIEW")]
            AgentScorecardInsightsSummaryView,
            
            /// <summary>
            /// Enum AgentScorecardInsightsDetailView for "AGENT_SCORECARD_INSIGHTS_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCORECARD_INSIGHTS_DETAIL_VIEW")]
            AgentScorecardInsightsDetailView,
            
            /// <summary>
            /// Enum QueueWrapupDetailView for "QUEUE_WRAPUP_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_WRAPUP_DETAIL_VIEW")]
            QueueWrapupDetailView,
            
            /// <summary>
            /// Enum InteractionDetailView for "INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "INTERACTION_DETAIL_VIEW")]
            InteractionDetailView,
            
            /// <summary>
            /// Enum CampaignInteractionDetailView for "CAMPAIGN_INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN_INTERACTION_DETAIL_VIEW")]
            CampaignInteractionDetailView,
            
            /// <summary>
            /// Enum CampaignAttemptDetailView for "CAMPAIGN_ATTEMPT_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN_ATTEMPT_DETAIL_VIEW")]
            CampaignAttemptDetailView,
            
            /// <summary>
            /// Enum WorkitemPerformanceSummaryView for "WORKITEM_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "WORKITEM_PERFORMANCE_SUMMARY_VIEW")]
            WorkitemPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentAssistPerformanceView for "AGENT_ASSIST_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_ASSIST_PERFORMANCE_VIEW")]
            AgentAssistPerformanceView,
            
            /// <summary>
            /// Enum ContactCenterPerformanceView for "CONTACT_CENTER_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "CONTACT_CENTER_PERFORMANCE_VIEW")]
            ContactCenterPerformanceView,
            
            /// <summary>
            /// Enum QueueRoutingPerformanceView for "QUEUE_ROUTING_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_ROUTING_PERFORMANCE_VIEW")]
            QueueRoutingPerformanceView,
            
            /// <summary>
            /// Enum AgentWorkitemPerformanceSummaryView for "AGENT_WORKITEM_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WORKITEM_PERFORMANCE_SUMMARY_VIEW")]
            AgentWorkitemPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentWorkitemPerformanceDetailView for "AGENT_WORKITEM_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WORKITEM_PERFORMANCE_DETAIL_VIEW")]
            AgentWorkitemPerformanceDetailView,
            
            /// <summary>
            /// Enum QueueWorkitemPerformanceSummaryView for "QUEUE_WORKITEM_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_WORKITEM_PERFORMANCE_SUMMARY_VIEW")]
            QueueWorkitemPerformanceSummaryView,
            
            /// <summary>
            /// Enum QueueWorkitemPerformanceDetailView for "QUEUE_WORKITEM_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_WORKITEM_PERFORMANCE_DETAIL_VIEW")]
            QueueWorkitemPerformanceDetailView,
            
            /// <summary>
            /// Enum EmailAgentPerformanceSummaryView for "EMAIL_AGENT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "EMAIL_AGENT_PERFORMANCE_SUMMARY_VIEW")]
            EmailAgentPerformanceSummaryView,
            
            /// <summary>
            /// Enum EmailAgentPerformanceDetailView for "EMAIL_AGENT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "EMAIL_AGENT_PERFORMANCE_DETAIL_VIEW")]
            EmailAgentPerformanceDetailView,
            
            /// <summary>
            /// Enum MessagingAgentPerformanceSummaryView for "MESSAGING_AGENT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "MESSAGING_AGENT_PERFORMANCE_SUMMARY_VIEW")]
            MessagingAgentPerformanceSummaryView,
            
            /// <summary>
            /// Enum MessagingAgentPerformanceDetailView for "MESSAGING_AGENT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "MESSAGING_AGENT_PERFORMANCE_DETAIL_VIEW")]
            MessagingAgentPerformanceDetailView,
            
            /// <summary>
            /// Enum EmailQueuePerformanceSummaryView for "EMAIL_QUEUE_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "EMAIL_QUEUE_PERFORMANCE_SUMMARY_VIEW")]
            EmailQueuePerformanceSummaryView,
            
            /// <summary>
            /// Enum EmailQueuePerformanceDetailView for "EMAIL_QUEUE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "EMAIL_QUEUE_PERFORMANCE_DETAIL_VIEW")]
            EmailQueuePerformanceDetailView,
            
            /// <summary>
            /// Enum MessagingQueuePerformanceSummaryView for "MESSAGING_QUEUE_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "MESSAGING_QUEUE_PERFORMANCE_SUMMARY_VIEW")]
            MessagingQueuePerformanceSummaryView,
            
            /// <summary>
            /// Enum MessagingQueuePerformanceDetailView for "MESSAGING_QUEUE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "MESSAGING_QUEUE_PERFORMANCE_DETAIL_VIEW")]
            MessagingQueuePerformanceDetailView,
            
            /// <summary>
            /// Enum SocialListeningView for "SOCIAL_LISTENING_VIEW"
            /// </summary>
            [EnumMember(Value = "SOCIAL_LISTENING_VIEW")]
            SocialListeningView,
            
            /// <summary>
            /// Enum SocialListeningPostsView for "SOCIAL_LISTENING_POSTS_VIEW"
            /// </summary>
            [EnumMember(Value = "SOCIAL_LISTENING_POSTS_VIEW")]
            SocialListeningPostsView,
            
            /// <summary>
            /// Enum AgentPerformanceTimelineDetailView for "AGENT_PERFORMANCE_TIMELINE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_TIMELINE_DETAIL_VIEW")]
            AgentPerformanceTimelineDetailView
        }
        /// <summary>
        /// The error message in case the export request failed
        /// </summary>
        /// <value>The error message in case the export request failed</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExportErrorMessagesTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum FailedConvertingExportJob for "FAILED_CONVERTING_EXPORT_JOB"
            /// </summary>
            [EnumMember(Value = "FAILED_CONVERTING_EXPORT_JOB")]
            FailedConvertingExportJob,
            
            /// <summary>
            /// Enum FailedNoDataExportJobFound for "FAILED_NO_DATA_EXPORT_JOB_FOUND"
            /// </summary>
            [EnumMember(Value = "FAILED_NO_DATA_EXPORT_JOB_FOUND")]
            FailedNoDataExportJobFound,
            
            /// <summary>
            /// Enum FailedGettingDataFromService for "FAILED_GETTING_DATA_FROM_SERVICE"
            /// </summary>
            [EnumMember(Value = "FAILED_GETTING_DATA_FROM_SERVICE")]
            FailedGettingDataFromService,
            
            /// <summary>
            /// Enum FailedGeneratingTempFile for "FAILED_GENERATING_TEMP_FILE"
            /// </summary>
            [EnumMember(Value = "FAILED_GENERATING_TEMP_FILE")]
            FailedGeneratingTempFile,
            
            /// <summary>
            /// Enum FailedSavingFileToS3 for "FAILED_SAVING_FILE_TO_S3"
            /// </summary>
            [EnumMember(Value = "FAILED_SAVING_FILE_TO_S3")]
            FailedSavingFileToS3,
            
            /// <summary>
            /// Enum FailedNotifyingSkywalkerOfDownload for "FAILED_NOTIFYING_SKYWALKER_OF_DOWNLOAD"
            /// </summary>
            [EnumMember(Value = "FAILED_NOTIFYING_SKYWALKER_OF_DOWNLOAD")]
            FailedNotifyingSkywalkerOfDownload,
            
            /// <summary>
            /// Enum FailedBuildingDownloadUrlFromSkywalkerResponse for "FAILED_BUILDING_DOWNLOAD_URL_FROM_SKYWALKER_RESPONSE"
            /// </summary>
            [EnumMember(Value = "FAILED_BUILDING_DOWNLOAD_URL_FROM_SKYWALKER_RESPONSE")]
            FailedBuildingDownloadUrlFromSkywalkerResponse,
            
            /// <summary>
            /// Enum FailedConvertingExportJobToQueuePerformanceJob for "FAILED_CONVERTING_EXPORT_JOB_TO_QUEUE_PERFORMANCE_JOB"
            /// </summary>
            [EnumMember(Value = "FAILED_CONVERTING_EXPORT_JOB_TO_QUEUE_PERFORMANCE_JOB")]
            FailedConvertingExportJobToQueuePerformanceJob,
            
            /// <summary>
            /// Enum ExportTypeNotImplemented for "EXPORT_TYPE_NOT_IMPLEMENTED"
            /// </summary>
            [EnumMember(Value = "EXPORT_TYPE_NOT_IMPLEMENTED")]
            ExportTypeNotImplemented,
            
            /// <summary>
            /// Enum ReachedMaximumAttemptOfRetry for "REACHED_MAXIMUM_ATTEMPT_OF_RETRY"
            /// </summary>
            [EnumMember(Value = "REACHED_MAXIMUM_ATTEMPT_OF_RETRY")]
            ReachedMaximumAttemptOfRetry,
            
            /// <summary>
            /// Enum FailedLongRunningExport for "FAILED_LONG_RUNNING_EXPORT"
            /// </summary>
            [EnumMember(Value = "FAILED_LONG_RUNNING_EXPORT")]
            FailedLongRunningExport,
            
            /// <summary>
            /// Enum TooManyRequestsFromAnOrganization for "TOO_MANY_REQUESTS_FROM_AN_ORGANIZATION"
            /// </summary>
            [EnumMember(Value = "TOO_MANY_REQUESTS_FROM_AN_ORGANIZATION")]
            TooManyRequestsFromAnOrganization,
            
            /// <summary>
            /// Enum FailedAsExportFileSizeIsGreaterThan10mb for "FAILED_AS_EXPORT_FILE_SIZE_IS_GREATER_THAN_10MB"
            /// </summary>
            [EnumMember(Value = "FAILED_AS_EXPORT_FILE_SIZE_IS_GREATER_THAN_10MB")]
            FailedAsExportFileSizeIsGreaterThan10mb,
            
            /// <summary>
            /// Enum NotAuthorizedToViewExport for "NOT_AUTHORIZED_TO_VIEW_EXPORT"
            /// </summary>
            [EnumMember(Value = "NOT_AUTHORIZED_TO_VIEW_EXPORT")]
            NotAuthorizedToViewExport,
            
            /// <summary>
            /// Enum StaticLinkExportFailed for "STATIC_LINK_EXPORT_FAILED"
            /// </summary>
            [EnumMember(Value = "STATIC_LINK_EXPORT_FAILED")]
            StaticLinkExportFailed,
            
            /// <summary>
            /// Enum TooManySearchCriteria for "TOO_MANY_SEARCH_CRITERIA"
            /// </summary>
            [EnumMember(Value = "TOO_MANY_SEARCH_CRITERIA")]
            TooManySearchCriteria,
            
            /// <summary>
            /// Enum SearchCriteriaValuesExceedLimit for "SEARCH_CRITERIA_VALUES_EXCEED_LIMIT"
            /// </summary>
            [EnumMember(Value = "SEARCH_CRITERIA_VALUES_EXCEED_LIMIT")]
            SearchCriteriaValuesExceedLimit,
            
            /// <summary>
            /// Enum ExportEmailFileSizeExceededLimit for "EXPORT_EMAIL_FILE_SIZE_EXCEEDED_LIMIT"
            /// </summary>
            [EnumMember(Value = "EXPORT_EMAIL_FILE_SIZE_EXCEEDED_LIMIT")]
            ExportEmailFileSizeExceededLimit,
            
            /// <summary>
            /// Enum CircuitBreakerOpenForViewType for "CIRCUIT_BREAKER_OPEN_FOR_VIEW_TYPE"
            /// </summary>
            [EnumMember(Value = "CIRCUIT_BREAKER_OPEN_FOR_VIEW_TYPE")]
            CircuitBreakerOpenForViewType,
            
            /// <summary>
            /// Enum BadRequestScheduledRun for "BAD_REQUEST_SCHEDULED_RUN"
            /// </summary>
            [EnumMember(Value = "BAD_REQUEST_SCHEDULED_RUN")]
            BadRequestScheduledRun
        }
        /// <summary>
        /// The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request
        /// </summary>
        /// <value>The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CsvDelimiterEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Semicolon for "SEMICOLON"
            /// </summary>
            [EnumMember(Value = "SEMICOLON")]
            Semicolon,
            
            /// <summary>
            /// Enum Comma for "COMMA"
            /// </summary>
            [EnumMember(Value = "COMMA")]
            Comma
        }
        /// <summary>
        /// Gets or Sets Inner
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InnerEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sent for "Sent"
            /// </summary>
            [EnumMember(Value = "Sent")]
            Sent,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// Indicates the duration format for the exports
        /// </summary>
        /// <value>Indicates the duration format for the exports</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DurationFormatEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Seconds for "Seconds"
            /// </summary>
            [EnumMember(Value = "Seconds")]
            Seconds,
            
            /// <summary>
            /// Enum Milliseconds for "Milliseconds"
            /// </summary>
            [EnumMember(Value = "Milliseconds")]
            Milliseconds,
            
            /// <summary>
            /// Enum Hhmmss for "Hhmmss"
            /// </summary>
            [EnumMember(Value = "Hhmmss")]
            Hhmmss,
            
            /// <summary>
            /// Enum Hms for "Hms"
            /// </summary>
            [EnumMember(Value = "Hms")]
            Hms
        }
        /// <summary>
        /// The current status of the export request
        /// </summary>
        /// <value>The current status of the export request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The requested format of the exported data
        /// </summary>
        /// <value>The requested format of the exported data</value>
        [DataMember(Name="exportFormat", EmitDefaultValue=false)]
        public ExportFormatEnum? ExportFormat { get; set; }
        /// <summary>
        /// The type of view export job to be created
        /// </summary>
        /// <value>The type of view export job to be created</value>
        [DataMember(Name="viewType", EmitDefaultValue=false)]
        public ViewTypeEnum? ViewType { get; set; }
        /// <summary>
        /// The error message in case the export request failed
        /// </summary>
        /// <value>The error message in case the export request failed</value>
        [DataMember(Name="exportErrorMessagesType", EmitDefaultValue=false)]
        public ExportErrorMessagesTypeEnum? ExportErrorMessagesType { get; set; }
        /// <summary>
        /// The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request
        /// </summary>
        /// <value>The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request</value>
        [DataMember(Name="csvDelimiter", EmitDefaultValue=false)]
        public CsvDelimiterEnum? CsvDelimiter { get; set; }
        /// <summary>
        /// Indicates the duration format for the exports
        /// </summary>
        /// <value>Indicates the duration format for the exports</value>
        [DataMember(Name="durationFormat", EmitDefaultValue=false)]
        public DurationFormatEnum? DurationFormat { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingExportJobResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportingExportJobResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingExportJobResponse" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="RunId">The unique run id of the export schedule execute (required).</param>
        /// <param name="Status">The current status of the export request (required).</param>
        /// <param name="TimeZone">The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London (required).</param>
        /// <param name="ExportFormat">The requested format of the exported data (required).</param>
        /// <param name="Interval">The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="DownloadUrl">The url to download the request if it's status is completed.</param>
        /// <param name="ViewType">The type of view export job to be created (required).</param>
        /// <param name="ExportErrorMessagesType">The error message in case the export request failed.</param>
        /// <param name="Period">The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H (required).</param>
        /// <param name="Filter">Filters to apply to create the view (required).</param>
        /// <param name="Read">Indicates if the request has been marked as read (required).</param>
        /// <param name="CreatedDateTime">The created date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ModifiedDateTime">The last modified date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="Locale">The locale use for localization of the exported data, i.e. en-us, es-mx   (required).</param>
        /// <param name="PercentageComplete">The percentage of the job that has completed processing (required).</param>
        /// <param name="HasFormatDurations">Indicates if durations are formatted in hh:mm:ss format instead of ms.</param>
        /// <param name="HasSplitFilters">Indicates if filters will be split in aggregate detail exports.</param>
        /// <param name="ExcludeEmptyRows">Excludes empty rows from the exports.</param>
        /// <param name="HasSplitByMedia">Indicates if media type will be split in aggregate detail exports.</param>
        /// <param name="HasSummaryRow">Indicates if summary row needs to be present in exports.</param>
        /// <param name="CsvDelimiter">The user supplied csv delimiter string value either of type 'comma' or 'semicolon' permitted for the export request.</param>
        /// <param name="SelectedColumns">The list of ordered selected columns from the export view by the user.</param>
        /// <param name="HasCustomParticipantAttributes">Indicates if custom participant attributes will be exported.</param>
        /// <param name="RecipientEmails">The list of email recipients for the exports.</param>
        /// <param name="EmailStatuses">The status of individual email addresses as a map.</param>
        /// <param name="EmailErrorDescription">The optional error message in case the export fail to email.</param>
        /// <param name="IncludeDurationFormatInHeader">Indicates whether to include selected duration format to the column headers.</param>
        /// <param name="DurationFormat">Indicates the duration format for the exports.</param>
        /// <param name="ExportAllowedToRerun">Indicates whether the export run is allowed to rerun.</param>
        /// <param name="Enabled">Enabled.</param>
        public ReportingExportJobResponse(string Name = null, string RunId = null, StatusEnum? Status = null, string TimeZone = null, ExportFormatEnum? ExportFormat = null, string Interval = null, string DownloadUrl = null, ViewTypeEnum? ViewType = null, ExportErrorMessagesTypeEnum? ExportErrorMessagesType = null, string Period = null, ViewFilter Filter = null, bool? Read = null, DateTime? CreatedDateTime = null, DateTime? ModifiedDateTime = null, string Locale = null, double? PercentageComplete = null, bool? HasFormatDurations = null, bool? HasSplitFilters = null, bool? ExcludeEmptyRows = null, bool? HasSplitByMedia = null, bool? HasSummaryRow = null, CsvDelimiterEnum? CsvDelimiter = null, List<SelectedColumns> SelectedColumns = null, bool? HasCustomParticipantAttributes = null, List<string> RecipientEmails = null, Dictionary<string, string> EmailStatuses = null, string EmailErrorDescription = null, bool? IncludeDurationFormatInHeader = null, DurationFormatEnum? DurationFormat = null, bool? ExportAllowedToRerun = null, bool? Enabled = null)
        {
            this.Name = Name;
            this.RunId = RunId;
            this.Status = Status;
            this.TimeZone = TimeZone;
            this.ExportFormat = ExportFormat;
            this.Interval = Interval;
            this.DownloadUrl = DownloadUrl;
            this.ViewType = ViewType;
            this.ExportErrorMessagesType = ExportErrorMessagesType;
            this.Period = Period;
            this.Filter = Filter;
            this.Read = Read;
            this.CreatedDateTime = CreatedDateTime;
            this.ModifiedDateTime = ModifiedDateTime;
            this.Locale = Locale;
            this.PercentageComplete = PercentageComplete;
            this.HasFormatDurations = HasFormatDurations;
            this.HasSplitFilters = HasSplitFilters;
            this.ExcludeEmptyRows = ExcludeEmptyRows;
            this.HasSplitByMedia = HasSplitByMedia;
            this.HasSummaryRow = HasSummaryRow;
            this.CsvDelimiter = CsvDelimiter;
            this.SelectedColumns = SelectedColumns;
            this.HasCustomParticipantAttributes = HasCustomParticipantAttributes;
            this.RecipientEmails = RecipientEmails;
            this.EmailStatuses = EmailStatuses;
            this.EmailErrorDescription = EmailErrorDescription;
            this.IncludeDurationFormatInHeader = IncludeDurationFormatInHeader;
            this.DurationFormat = DurationFormat;
            this.ExportAllowedToRerun = ExportAllowedToRerun;
            this.Enabled = Enabled;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The unique run id of the export schedule execute
        /// </summary>
        /// <value>The unique run id of the export schedule execute</value>
        [DataMember(Name="runId", EmitDefaultValue=false)]
        public string RunId { get; set; }





        /// <summary>
        /// The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
        /// </summary>
        /// <value>The requested timezone of the exported data. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }





        /// <summary>
        /// The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>The time period used to limit the the exported data. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }



        /// <summary>
        /// The url to download the request if it's status is completed
        /// </summary>
        /// <value>The url to download the request if it's status is completed</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }







        /// <summary>
        /// The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
        /// </summary>
        /// <value>The Period of the request in which to break down the intervals. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }



        /// <summary>
        /// Filters to apply to create the view
        /// </summary>
        /// <value>Filters to apply to create the view</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public ViewFilter Filter { get; set; }



        /// <summary>
        /// Indicates if the request has been marked as read
        /// </summary>
        /// <value>Indicates if the request has been marked as read</value>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }



        /// <summary>
        /// The created date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The created date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public DateTime? CreatedDateTime { get; set; }



        /// <summary>
        /// The last modified date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The last modified date/time of the request. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDateTime", EmitDefaultValue=false)]
        public DateTime? ModifiedDateTime { get; set; }



        /// <summary>
        /// The locale use for localization of the exported data, i.e. en-us, es-mx  
        /// </summary>
        /// <value>The locale use for localization of the exported data, i.e. en-us, es-mx  </value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }



        /// <summary>
        /// The percentage of the job that has completed processing
        /// </summary>
        /// <value>The percentage of the job that has completed processing</value>
        [DataMember(Name="percentageComplete", EmitDefaultValue=false)]
        public double? PercentageComplete { get; set; }



        /// <summary>
        /// Indicates if durations are formatted in hh:mm:ss format instead of ms
        /// </summary>
        /// <value>Indicates if durations are formatted in hh:mm:ss format instead of ms</value>
        [DataMember(Name="hasFormatDurations", EmitDefaultValue=false)]
        public bool? HasFormatDurations { get; set; }



        /// <summary>
        /// Indicates if filters will be split in aggregate detail exports
        /// </summary>
        /// <value>Indicates if filters will be split in aggregate detail exports</value>
        [DataMember(Name="hasSplitFilters", EmitDefaultValue=false)]
        public bool? HasSplitFilters { get; set; }



        /// <summary>
        /// Excludes empty rows from the exports
        /// </summary>
        /// <value>Excludes empty rows from the exports</value>
        [DataMember(Name="excludeEmptyRows", EmitDefaultValue=false)]
        public bool? ExcludeEmptyRows { get; set; }



        /// <summary>
        /// Indicates if media type will be split in aggregate detail exports
        /// </summary>
        /// <value>Indicates if media type will be split in aggregate detail exports</value>
        [DataMember(Name="hasSplitByMedia", EmitDefaultValue=false)]
        public bool? HasSplitByMedia { get; set; }



        /// <summary>
        /// Indicates if summary row needs to be present in exports
        /// </summary>
        /// <value>Indicates if summary row needs to be present in exports</value>
        [DataMember(Name="hasSummaryRow", EmitDefaultValue=false)]
        public bool? HasSummaryRow { get; set; }





        /// <summary>
        /// The list of ordered selected columns from the export view by the user
        /// </summary>
        /// <value>The list of ordered selected columns from the export view by the user</value>
        [DataMember(Name="selectedColumns", EmitDefaultValue=false)]
        public List<SelectedColumns> SelectedColumns { get; set; }



        /// <summary>
        /// Indicates if custom participant attributes will be exported
        /// </summary>
        /// <value>Indicates if custom participant attributes will be exported</value>
        [DataMember(Name="hasCustomParticipantAttributes", EmitDefaultValue=false)]
        public bool? HasCustomParticipantAttributes { get; set; }



        /// <summary>
        /// The list of email recipients for the exports
        /// </summary>
        /// <value>The list of email recipients for the exports</value>
        [DataMember(Name="recipientEmails", EmitDefaultValue=false)]
        public List<string> RecipientEmails { get; set; }



        /// <summary>
        /// The status of individual email addresses as a map
        /// </summary>
        /// <value>The status of individual email addresses as a map</value>
        [DataMember(Name="emailStatuses", EmitDefaultValue=false)]
        public Dictionary<string, string> EmailStatuses { get; set; }



        /// <summary>
        /// The optional error message in case the export fail to email
        /// </summary>
        /// <value>The optional error message in case the export fail to email</value>
        [DataMember(Name="emailErrorDescription", EmitDefaultValue=false)]
        public string EmailErrorDescription { get; set; }



        /// <summary>
        /// Indicates whether to include selected duration format to the column headers
        /// </summary>
        /// <value>Indicates whether to include selected duration format to the column headers</value>
        [DataMember(Name="includeDurationFormatInHeader", EmitDefaultValue=false)]
        public bool? IncludeDurationFormatInHeader { get; set; }





        /// <summary>
        /// Indicates whether the export run is allowed to rerun
        /// </summary>
        /// <value>Indicates whether the export run is allowed to rerun</value>
        [DataMember(Name="exportAllowedToRerun", EmitDefaultValue=false)]
        public bool? ExportAllowedToRerun { get; set; }



        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingExportJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  ExportFormat: ").Append(ExportFormat).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  ViewType: ").Append(ViewType).Append("\n");
            sb.Append("  ExportErrorMessagesType: ").Append(ExportErrorMessagesType).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  ModifiedDateTime: ").Append(ModifiedDateTime).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  PercentageComplete: ").Append(PercentageComplete).Append("\n");
            sb.Append("  HasFormatDurations: ").Append(HasFormatDurations).Append("\n");
            sb.Append("  HasSplitFilters: ").Append(HasSplitFilters).Append("\n");
            sb.Append("  ExcludeEmptyRows: ").Append(ExcludeEmptyRows).Append("\n");
            sb.Append("  HasSplitByMedia: ").Append(HasSplitByMedia).Append("\n");
            sb.Append("  HasSummaryRow: ").Append(HasSummaryRow).Append("\n");
            sb.Append("  CsvDelimiter: ").Append(CsvDelimiter).Append("\n");
            sb.Append("  SelectedColumns: ").Append(SelectedColumns).Append("\n");
            sb.Append("  HasCustomParticipantAttributes: ").Append(HasCustomParticipantAttributes).Append("\n");
            sb.Append("  RecipientEmails: ").Append(RecipientEmails).Append("\n");
            sb.Append("  EmailStatuses: ").Append(EmailStatuses).Append("\n");
            sb.Append("  EmailErrorDescription: ").Append(EmailErrorDescription).Append("\n");
            sb.Append("  IncludeDurationFormatInHeader: ").Append(IncludeDurationFormatInHeader).Append("\n");
            sb.Append("  DurationFormat: ").Append(DurationFormat).Append("\n");
            sb.Append("  ExportAllowedToRerun: ").Append(ExportAllowedToRerun).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ReportingExportJobResponse);
        }

        /// <summary>
        /// Returns true if ReportingExportJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingExportJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingExportJobResponse other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.RunId == other.RunId ||
                    this.RunId != null &&
                    this.RunId.Equals(other.RunId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.ExportFormat == other.ExportFormat ||
                    this.ExportFormat != null &&
                    this.ExportFormat.Equals(other.ExportFormat)
                ) &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.ViewType == other.ViewType ||
                    this.ViewType != null &&
                    this.ViewType.Equals(other.ViewType)
                ) &&
                (
                    this.ExportErrorMessagesType == other.ExportErrorMessagesType ||
                    this.ExportErrorMessagesType != null &&
                    this.ExportErrorMessagesType.Equals(other.ExportErrorMessagesType)
                ) &&
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) &&
                (
                    this.CreatedDateTime == other.CreatedDateTime ||
                    this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(other.CreatedDateTime)
                ) &&
                (
                    this.ModifiedDateTime == other.ModifiedDateTime ||
                    this.ModifiedDateTime != null &&
                    this.ModifiedDateTime.Equals(other.ModifiedDateTime)
                ) &&
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
                ) &&
                (
                    this.PercentageComplete == other.PercentageComplete ||
                    this.PercentageComplete != null &&
                    this.PercentageComplete.Equals(other.PercentageComplete)
                ) &&
                (
                    this.HasFormatDurations == other.HasFormatDurations ||
                    this.HasFormatDurations != null &&
                    this.HasFormatDurations.Equals(other.HasFormatDurations)
                ) &&
                (
                    this.HasSplitFilters == other.HasSplitFilters ||
                    this.HasSplitFilters != null &&
                    this.HasSplitFilters.Equals(other.HasSplitFilters)
                ) &&
                (
                    this.ExcludeEmptyRows == other.ExcludeEmptyRows ||
                    this.ExcludeEmptyRows != null &&
                    this.ExcludeEmptyRows.Equals(other.ExcludeEmptyRows)
                ) &&
                (
                    this.HasSplitByMedia == other.HasSplitByMedia ||
                    this.HasSplitByMedia != null &&
                    this.HasSplitByMedia.Equals(other.HasSplitByMedia)
                ) &&
                (
                    this.HasSummaryRow == other.HasSummaryRow ||
                    this.HasSummaryRow != null &&
                    this.HasSummaryRow.Equals(other.HasSummaryRow)
                ) &&
                (
                    this.CsvDelimiter == other.CsvDelimiter ||
                    this.CsvDelimiter != null &&
                    this.CsvDelimiter.Equals(other.CsvDelimiter)
                ) &&
                (
                    this.SelectedColumns == other.SelectedColumns ||
                    this.SelectedColumns != null &&
                    this.SelectedColumns.SequenceEqual(other.SelectedColumns)
                ) &&
                (
                    this.HasCustomParticipantAttributes == other.HasCustomParticipantAttributes ||
                    this.HasCustomParticipantAttributes != null &&
                    this.HasCustomParticipantAttributes.Equals(other.HasCustomParticipantAttributes)
                ) &&
                (
                    this.RecipientEmails == other.RecipientEmails ||
                    this.RecipientEmails != null &&
                    this.RecipientEmails.SequenceEqual(other.RecipientEmails)
                ) &&
                (
                    this.EmailStatuses == other.EmailStatuses ||
                    this.EmailStatuses != null &&
                    this.EmailStatuses.SequenceEqual(other.EmailStatuses)
                ) &&
                (
                    this.EmailErrorDescription == other.EmailErrorDescription ||
                    this.EmailErrorDescription != null &&
                    this.EmailErrorDescription.Equals(other.EmailErrorDescription)
                ) &&
                (
                    this.IncludeDurationFormatInHeader == other.IncludeDurationFormatInHeader ||
                    this.IncludeDurationFormatInHeader != null &&
                    this.IncludeDurationFormatInHeader.Equals(other.IncludeDurationFormatInHeader)
                ) &&
                (
                    this.DurationFormat == other.DurationFormat ||
                    this.DurationFormat != null &&
                    this.DurationFormat.Equals(other.DurationFormat)
                ) &&
                (
                    this.ExportAllowedToRerun == other.ExportAllowedToRerun ||
                    this.ExportAllowedToRerun != null &&
                    this.ExportAllowedToRerun.Equals(other.ExportAllowedToRerun)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.RunId != null)
                    hash = hash * 59 + this.RunId.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                if (this.ExportFormat != null)
                    hash = hash * 59 + this.ExportFormat.GetHashCode();

                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.ViewType != null)
                    hash = hash * 59 + this.ViewType.GetHashCode();

                if (this.ExportErrorMessagesType != null)
                    hash = hash * 59 + this.ExportErrorMessagesType.GetHashCode();

                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();

                if (this.CreatedDateTime != null)
                    hash = hash * 59 + this.CreatedDateTime.GetHashCode();

                if (this.ModifiedDateTime != null)
                    hash = hash * 59 + this.ModifiedDateTime.GetHashCode();

                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();

                if (this.PercentageComplete != null)
                    hash = hash * 59 + this.PercentageComplete.GetHashCode();

                if (this.HasFormatDurations != null)
                    hash = hash * 59 + this.HasFormatDurations.GetHashCode();

                if (this.HasSplitFilters != null)
                    hash = hash * 59 + this.HasSplitFilters.GetHashCode();

                if (this.ExcludeEmptyRows != null)
                    hash = hash * 59 + this.ExcludeEmptyRows.GetHashCode();

                if (this.HasSplitByMedia != null)
                    hash = hash * 59 + this.HasSplitByMedia.GetHashCode();

                if (this.HasSummaryRow != null)
                    hash = hash * 59 + this.HasSummaryRow.GetHashCode();

                if (this.CsvDelimiter != null)
                    hash = hash * 59 + this.CsvDelimiter.GetHashCode();

                if (this.SelectedColumns != null)
                    hash = hash * 59 + this.SelectedColumns.GetHashCode();

                if (this.HasCustomParticipantAttributes != null)
                    hash = hash * 59 + this.HasCustomParticipantAttributes.GetHashCode();

                if (this.RecipientEmails != null)
                    hash = hash * 59 + this.RecipientEmails.GetHashCode();

                if (this.EmailStatuses != null)
                    hash = hash * 59 + this.EmailStatuses.GetHashCode();

                if (this.EmailErrorDescription != null)
                    hash = hash * 59 + this.EmailErrorDescription.GetHashCode();

                if (this.IncludeDurationFormatInHeader != null)
                    hash = hash * 59 + this.IncludeDurationFormatInHeader.GetHashCode();

                if (this.DurationFormat != null)
                    hash = hash * 59 + this.DurationFormat.GetHashCode();

                if (this.ExportAllowedToRerun != null)
                    hash = hash * 59 + this.ExportAllowedToRerun.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
