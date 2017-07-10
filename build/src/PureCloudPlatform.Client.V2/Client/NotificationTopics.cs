using System;
using System.Collections.Generic;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Client
{
    public static class NotificationTopics
    {
        public static Dictionary<string, Type> Topics;

        static NotificationTopics()
        {
            Topics = new Dictionary<string, Type>
            { 
              {"v2.architect.dependencytracking.build", typeof(DependencyTrackingBuildNotificationNotification)},
              {"v2.architect.flows.{id}.generation.{id}", typeof(PublishFlowNotificationNotification)},
              {"v2.architect.prompts.{id}", typeof(PromptNotificationNotification)},
              {"v2.architect.prompts.{id}.resources.{id}", typeof(PromptResourceNotificationNotification)},
              {"v2.architect.systemprompts.{id}.resources.{id}", typeof(SystemPromptResourceNotificationNotification)},
              {"v2.contentmanagement.documents.{id}", typeof(DocumentDataV2Notification)},
              {"v2.contentmanagement.workspaces.{id}.documents", typeof(DocumentDataV2Notification)},
              {"v2.flows.{id}", typeof(FlowNotificationNotification)},
              {"v2.groups.{id}.greetings", typeof(GreetingNotification)},
              {"v2.managementunits.{id}.workforcemanagement.intraday", typeof(IntradayDataUpdateNotification)},
              {"v2.outbound.attemptlimits.{id}", typeof(AttemptLimitsNotification)},
              {"v2.outbound.callabletimesets.{id}", typeof(CallableTimeSetNotification)},
              {"v2.outbound.campaignrules.{id}", typeof(CampaignRuleNotification)},
              {"v2.outbound.campaigns.{id}", typeof(CampaignNotification)},
              {"v2.outbound.campaigns.{id}.progress", typeof(CampaignProgressNotification)},
              {"v2.outbound.campaigns.{id}.stats", typeof(StatsNotificationNotification)},
              {"v2.outbound.contactlistfilters.{id}", typeof(ContactListFilterNotification)},
              {"v2.outbound.contactlists.{id}", typeof(ContactListNotification)},
              {"v2.outbound.contactlists.{id}.importstatus", typeof(ImportStatusNotification)},
              {"v2.outbound.dnclists.{id}", typeof(DncListNotification)},
              {"v2.outbound.dnclists.{id}.importstatus", typeof(ImportStatusNotification)},
              {"v2.outbound.responsesets.{id}", typeof(ResponseSetNotification)},
              {"v2.outbound.rulesets.{id}", typeof(RuleSetNotification)},
              {"v2.outbound.schedules.campaigns.{id}", typeof(CampaignScheduleNotification)},
              {"v2.outbound.schedules.sequences.{id}", typeof(SequenceScheduleNotification)},
              {"v2.outbound.sequences.{id}", typeof(CampaignSequenceNotification)},
              {"v2.outbound.wrapupcodemappings.{id}", typeof(WrapUpCodeMappingNotification)},
              {"v2.routing.queues.{id}.conversations", typeof(ConversationNotification)},
              {"v2.routing.queues.{id}.conversations.callbacks", typeof(CallbackConversationNotification)},
              {"v2.routing.queues.{id}.conversations.calls", typeof(CallConversationNotification)},
              {"v2.routing.queues.{id}.conversations.chats", typeof(ChatConversationNotification)},
              {"v2.routing.queues.{id}.conversations.cobrowseSessions", typeof(CobrowseConversationNotification)},
              {"v2.routing.queues.{id}.conversations.emails", typeof(EmailConversationNotification)},
              {"v2.routing.queues.{id}.conversations.screenshares", typeof(ScreenShareConversationNotification)},
              {"v2.routing.queues.{id}.conversations.socialexpressions", typeof(ConversationNotification)},
              {"v2.routing.queues.{id}.conversations.videos", typeof(ConversationNotification)},
              {"v2.routing.queues.{id}.users", typeof(QueueMemberNotification)},
              {"v2.users.{id}.alerting.heartbeat.alerts", typeof(HeartBeatAlertNotification)},
              {"v2.users.{id}.alerting.heartbeat.rules", typeof(HeartBeatRuleNotification)},
              {"v2.users.{id}.alerting.interactionstats.alerts", typeof(InteractionStatAlertNotification)},
              {"v2.users.{id}.alerting.interactionstats.rules", typeof(InteractionStatRuleNotification)},
              {"v2.users.{id}.conversations", typeof(ConversationNotification)},
              {"v2.users.{id}.conversations.callbacks", typeof(CallbackConversationNotification)},
              {"v2.users.{id}.conversations.calls", typeof(CallConversationNotification)},
              {"v2.users.{id}.conversations.chats", typeof(ChatConversationNotification)},
              {"v2.users.{id}.conversations.cobrowseSessions", typeof(CobrowseConversationNotification)},
              {"v2.users.{id}.conversations.emails", typeof(EmailConversationNotification)},
              {"v2.users.{id}.conversations.screenshares", typeof(ScreenShareConversationNotification)},
              {"v2.users.{id}.conversations.socialexpressions", typeof(SocialConversationNotification)},
              {"v2.users.{id}.conversations.videos", typeof(VideoConversationNotification)},
              {"v2.users.{id}.conversationsummary", typeof(UserConversationSummaryNotification)},
              {"v2.users.{id}.fax.documents", typeof(FaxDataV2Notification)},
              {"v2.users.{id}.geolocation", typeof(GeolocationNotification)},
              {"v2.users.{id}.greetings", typeof(GreetingNotification)},
              {"v2.users.{id}.outbound.contactlists.{id}.export", typeof(ExportUriNotification)},
              {"v2.users.{id}.outbound.dnclists.{id}.export", typeof(ExportUriNotification)},
              {"v2.users.{id}.outofoffice", typeof(OutOfOfficeNotification)},
              {"v2.users.{id}.presence", typeof(UserPresenceNotification)},
              {"v2.users.{id}.routingStatus", typeof(UserRoutingStatusNotification)},
              {"v2.users.{id}.station", typeof(UserStationsNotification)},
              {"v2.users.{id}.userrecordings", typeof(RecordingDataV2Notification)},
              {"v2.users.{id}.voicemail.messages", typeof(VoicemailMessageNotification)},
              {"v2.users.{id}.workforcemanagement.adherence", typeof(UserScheduleAdherenceUpdateNotification)},
              {"v2.users.{id}.workforcemanagement.historicaladherencequery", typeof(WfmHistoricalAdherenceCalculationsCompleteNoticeNotification)},
              {"v2.users.{id}.workforcemanagement.timeoffrequests", typeof(TimeOffRequestUpdateNotification)},
            };
        }
    }
}