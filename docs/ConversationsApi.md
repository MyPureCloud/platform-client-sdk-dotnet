# ConversationsApi

## PureCloudPlatform.Client.V2.Api.ConversationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAnalyticsConversationsAggregatesJob**](#DeleteAnalyticsConversationsAggregatesJob) | **Delete** /api/v2/analytics/conversations/aggregates/jobs/{jobId} | Delete/cancel an async request for conversation aggregates |
| [**DeleteAnalyticsConversationsDetailsJob**](#DeleteAnalyticsConversationsDetailsJob) | **Delete** /api/v2/analytics/conversations/details/jobs/{jobId} | Delete/cancel an async details job |
| [**DeleteConversation**](#DeleteConversation) | **Delete** /api/v2/conversations/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**DeleteConversationParticipantCode**](#DeleteConversationParticipantCode) | **Delete** /api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode} | Delete a code used to add a communication to this participant |
| [**DeleteConversationParticipantFlaggedreason**](#DeleteConversationParticipantFlaggedreason) | **Delete** /api/v2/conversations/{conversationId}/participants/{participantId}/flaggedreason | Remove flagged reason from conversation participant. |
| [**DeleteConversationsCallParticipantConsult**](#DeleteConversationsCallParticipantConsult) | **Delete** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Cancel the transfer |
| [**DeleteConversationsEmailMessagesDraftAttachment**](#DeleteConversationsEmailMessagesDraftAttachment) | **Delete** /api/v2/conversations/emails/{conversationId}/messages/draft/attachments/{attachmentId} | Delete attachment from draft |
| [**DeleteConversationsMessagesCachedmediaCachedMediaItemId**](#DeleteConversationsMessagesCachedmediaCachedMediaItemId) | **Delete** /api/v2/conversations/messages/cachedmedia/{cachedMediaItemId} | Remove a cached media item asychronously |
| [**DeleteConversationsMessagingIntegrationsAppleIntegrationId**](#DeleteConversationsMessagingIntegrationsAppleIntegrationId) | **Delete** /api/v2/conversations/messaging/integrations/apple/{integrationId} | Delete an Apple messaging integration |
| [**DeleteConversationsMessagingIntegrationsFacebookIntegrationId**](#DeleteConversationsMessagingIntegrationsFacebookIntegrationId) | **Delete** /api/v2/conversations/messaging/integrations/facebook/{integrationId} | Delete a Facebook messaging integration |
| [**DeleteConversationsMessagingIntegrationsInstagramIntegrationId**](#DeleteConversationsMessagingIntegrationsInstagramIntegrationId) | **Delete** /api/v2/conversations/messaging/integrations/instagram/{integrationId} | Delete Instagram messaging integration |
| [**DeleteConversationsMessagingIntegrationsOpenIntegrationId**](#DeleteConversationsMessagingIntegrationsOpenIntegrationId) | **Delete** /api/v2/conversations/messaging/integrations/open/{integrationId} | Delete an Open messaging integration |
| [**DeleteConversationsMessagingIntegrationsTwitterIntegrationId**](#DeleteConversationsMessagingIntegrationsTwitterIntegrationId) | **Delete** /api/v2/conversations/messaging/integrations/twitter/{integrationId} | Delete Twitter messaging integration |
| [**DeleteConversationsMessagingIntegrationsWhatsappIntegrationId**](#DeleteConversationsMessagingIntegrationsWhatsappIntegrationId) | **Delete** /api/v2/conversations/messaging/integrations/whatsapp/{integrationId} | Delete a WhatsApp messaging integration |
| [**DeleteConversationsMessagingSetting**](#DeleteConversationsMessagingSetting) | **Delete** /api/v2/conversations/messaging/settings/{messageSettingId} | Delete a messaging setting |
| [**DeleteConversationsMessagingSettingsDefault**](#DeleteConversationsMessagingSettingsDefault) | **Delete** /api/v2/conversations/messaging/settings/default | Delete the organization&#39;s default setting, a global default will be applied to integrations without settings |
| [**DeleteConversationsMessagingSupportedcontentSupportedContentId**](#DeleteConversationsMessagingSupportedcontentSupportedContentId) | **Delete** /api/v2/conversations/messaging/supportedcontent/{supportedContentId} | Delete a supported content profile |
| [**GetAnalyticsConversationDetails**](#GetAnalyticsConversationDetails) | **Get** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetAnalyticsConversationsAggregatesJob**](#GetAnalyticsConversationsAggregatesJob) | **Get** /api/v2/analytics/conversations/aggregates/jobs/{jobId} | Get status for async query for conversation aggregates |
| [**GetAnalyticsConversationsAggregatesJobResults**](#GetAnalyticsConversationsAggregatesJobResults) | **Get** /api/v2/analytics/conversations/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsConversationsDetails**](#GetAnalyticsConversationsDetails) | **Get** /api/v2/analytics/conversations/details | Gets multiple conversations by id |
| [**GetAnalyticsConversationsDetailsJob**](#GetAnalyticsConversationsDetailsJob) | **Get** /api/v2/analytics/conversations/details/jobs/{jobId} | Get status for async query for conversation details |
| [**GetAnalyticsConversationsDetailsJobResults**](#GetAnalyticsConversationsDetailsJobResults) | **Get** /api/v2/analytics/conversations/details/jobs/{jobId}/results | Fetch a page of results for an async details job |
| [**GetAnalyticsConversationsDetailsJobsAvailability**](#GetAnalyticsConversationsDetailsJobsAvailability) | **Get** /api/v2/analytics/conversations/details/jobs/availability | Lookup the datalake availability date and time |
| [**GetConversation**](#GetConversation) | **Get** /api/v2/conversations/{conversationId} | Get conversation |
| [**GetConversationCommunicationInternalmessage**](#GetConversationCommunicationInternalmessage) | **Get** /api/v2/conversations/{conversationId}/communications/{communicationId}/internalmessages/{messageId} | Get message |
| [**GetConversationCommunicationInternalmessages**](#GetConversationCommunicationInternalmessages) | **Get** /api/v2/conversations/{conversationId}/communications/{communicationId}/internalmessages | Get messages for communication |
| [**GetConversationParticipantSecureivrsession**](#GetConversationParticipantSecureivrsession) | **Get** /api/v2/conversations/{conversationId}/participants/{participantId}/secureivrsessions/{secureSessionId} | Fetch info on a secure session |
| [**GetConversationParticipantSecureivrsessions**](#GetConversationParticipantSecureivrsessions) | **Get** /api/v2/conversations/{conversationId}/participants/{participantId}/secureivrsessions | Get a list of secure sessions for this participant. |
| [**GetConversationParticipantWrapup**](#GetConversationParticipantWrapup) | **Get** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationParticipantWrapupcodes**](#GetConversationParticipantWrapupcodes) | **Get** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationSecureattributes**](#GetConversationSecureattributes) | **Get** /api/v2/conversations/{conversationId}/secureattributes | Get the secure attributes on a conversation. |
| [**GetConversationSuggestion**](#GetConversationSuggestion) | **Get** /api/v2/conversations/{conversationId}/suggestions/{suggestionId} | Get Suggestion. |
| [**GetConversationSuggestions**](#GetConversationSuggestions) | **Get** /api/v2/conversations/{conversationId}/suggestions | Get all suggestions for a conversation. |
| [**GetConversationSummaries**](#GetConversationSummaries) | **Get** /api/v2/conversations/{conversationId}/summaries | Get the summaries of the conversation. |
| [**GetConversations**](#GetConversations) | **Get** /api/v2/conversations | Get active conversations for the logged in user |
| [**GetConversationsCall**](#GetConversationsCall) | **Get** /api/v2/conversations/calls/{conversationId} | Get call conversation |
| [**GetConversationsCallParticipantCommunicationWrapup**](#GetConversationsCallParticipantCommunicationWrapup) | **Get** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsCallParticipantWrapup**](#GetConversationsCallParticipantWrapup) | **Get** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCallParticipantWrapupcodes**](#GetConversationsCallParticipantWrapupcodes) | **Get** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCallback**](#GetConversationsCallback) | **Get** /api/v2/conversations/callbacks/{conversationId} | Get callback conversation |
| [**GetConversationsCallbackParticipantCommunicationWrapup**](#GetConversationsCallbackParticipantCommunicationWrapup) | **Get** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsCallbackParticipantWrapup**](#GetConversationsCallbackParticipantWrapup) | **Get** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCallbackParticipantWrapupcodes**](#GetConversationsCallbackParticipantWrapupcodes) | **Get** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCallbacks**](#GetConversationsCallbacks) | **Get** /api/v2/conversations/callbacks | Get active callback conversations for the logged in user |
| [**GetConversationsCalls**](#GetConversationsCalls) | **Get** /api/v2/conversations/calls | Get active call conversations for the logged in user |
| [**GetConversationsCallsHistory**](#GetConversationsCallsHistory) | **Get** /api/v2/conversations/calls/history | Get call history |
| [**GetConversationsCallsMaximumconferenceparties**](#GetConversationsCallsMaximumconferenceparties) | **Get** /api/v2/conversations/calls/maximumconferenceparties | Get the maximum number of participants that this user can have on a conference |
| [**GetConversationsChat**](#GetConversationsChat) | **Get** /api/v2/conversations/chats/{conversationId} | Get chat conversation |
| [**GetConversationsChatMessage**](#GetConversationsChatMessage) | **Get** /api/v2/conversations/chats/{conversationId}/messages/{messageId} | Get a web chat conversation message |
| [**GetConversationsChatMessages**](#GetConversationsChatMessages) | **Get** /api/v2/conversations/chats/{conversationId}/messages | Get the messages of a chat conversation. |
| [**GetConversationsChatParticipantCommunicationWrapup**](#GetConversationsChatParticipantCommunicationWrapup) | **Get** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsChatParticipantWrapup**](#GetConversationsChatParticipantWrapup) | **Get** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsChatParticipantWrapupcodes**](#GetConversationsChatParticipantWrapupcodes) | **Get** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsChats**](#GetConversationsChats) | **Get** /api/v2/conversations/chats | Get active chat conversations for the logged in user |
| [**GetConversationsCobrowsesession**](#GetConversationsCobrowsesession) | **Get** /api/v2/conversations/cobrowsesessions/{conversationId} | Get cobrowse conversation |
| [**GetConversationsCobrowsesessionParticipantCommunicationWrapup**](#GetConversationsCobrowsesessionParticipantCommunicationWrapup) | **Get** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsCobrowsesessionParticipantWrapup**](#GetConversationsCobrowsesessionParticipantWrapup) | **Get** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCobrowsesessionParticipantWrapupcodes**](#GetConversationsCobrowsesessionParticipantWrapupcodes) | **Get** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCobrowsesessions**](#GetConversationsCobrowsesessions) | **Get** /api/v2/conversations/cobrowsesessions | Get active cobrowse conversations for the logged in user |
| [**GetConversationsEmail**](#GetConversationsEmail) | **Get** /api/v2/conversations/emails/{conversationId} | Get email conversation |
| [**GetConversationsEmailMessage**](#GetConversationsEmailMessage) | **Get** /api/v2/conversations/emails/{conversationId}/messages/{messageId} | Get conversation message |
| [**GetConversationsEmailMessages**](#GetConversationsEmailMessages) | **Get** /api/v2/conversations/emails/{conversationId}/messages | Get conversation messages |
| [**GetConversationsEmailMessagesDraft**](#GetConversationsEmailMessagesDraft) | **Get** /api/v2/conversations/emails/{conversationId}/messages/draft | Get conversation draft reply |
| [**GetConversationsEmailParticipantCommunicationWrapup**](#GetConversationsEmailParticipantCommunicationWrapup) | **Get** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsEmailParticipantWrapup**](#GetConversationsEmailParticipantWrapup) | **Get** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsEmailParticipantWrapupcodes**](#GetConversationsEmailParticipantWrapupcodes) | **Get** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsEmailSettings**](#GetConversationsEmailSettings) | **Get** /api/v2/conversations/emails/{conversationId}/settings | Get emails settings for a given conversation |
| [**GetConversationsEmails**](#GetConversationsEmails) | **Get** /api/v2/conversations/emails | Get active email conversations for the logged in user |
| [**GetConversationsInternalmessage**](#GetConversationsInternalmessage) | **Get** /api/v2/conversations/internalmessages/{conversationId} | Get internal message conversation |
| [**GetConversationsInternalmessages**](#GetConversationsInternalmessages) | **Get** /api/v2/conversations/internalmessages | Get active internal message conversations for the logged in user |
| [**GetConversationsKeyconfiguration**](#GetConversationsKeyconfiguration) | **Get** /api/v2/conversations/keyconfigurations/{keyconfigurationsId} | Get the encryption key configurations |
| [**GetConversationsKeyconfigurations**](#GetConversationsKeyconfigurations) | **Get** /api/v2/conversations/keyconfigurations | Get a list of key configurations data |
| [**GetConversationsMessage**](#GetConversationsMessage) | **Get** /api/v2/conversations/messages/{conversationId} | Get message conversation |
| [**GetConversationsMessageCommunicationMessagesMediaMediaId**](#GetConversationsMessageCommunicationMessagesMediaMediaId) | **Get** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages/media/{mediaId} | Get media |
| [**GetConversationsMessageDetails**](#GetConversationsMessageDetails) | **Get** /api/v2/conversations/messages/{messageId}/details | Get message |
| [**GetConversationsMessageMessage**](#GetConversationsMessageMessage) | **Get** /api/v2/conversations/messages/{conversationId}/messages/{messageId} | Get conversation message |
| [**GetConversationsMessageParticipantCommunicationWrapup**](#GetConversationsMessageParticipantCommunicationWrapup) | **Get** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsMessageParticipantWrapup**](#GetConversationsMessageParticipantWrapup) | **Get** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsMessageParticipantWrapupcodes**](#GetConversationsMessageParticipantWrapupcodes) | **Get** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsMessages**](#GetConversationsMessages) | **Get** /api/v2/conversations/messages | Get active message conversations for the logged in user |
| [**GetConversationsMessagesCachedmedia**](#GetConversationsMessagesCachedmedia) | **Get** /api/v2/conversations/messages/cachedmedia | Get a list of cached media items |
| [**GetConversationsMessagesCachedmediaCachedMediaItemId**](#GetConversationsMessagesCachedmediaCachedMediaItemId) | **Get** /api/v2/conversations/messages/cachedmedia/{cachedMediaItemId} | Get a cached media item |
| [**GetConversationsMessagingFacebookApp**](#GetConversationsMessagingFacebookApp) | **Get** /api/v2/conversations/messaging/facebook/app | Get Genesys Facebook App Id |
| [**GetConversationsMessagingFacebookPermissions**](#GetConversationsMessagingFacebookPermissions) | **Get** /api/v2/conversations/messaging/facebook/permissions | Get a list of Facebook Permissions |
| [**GetConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId**](#GetConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId) | **Get** /api/v2/conversations/messaging/identityresolution/integrations/apple/{integrationId} | Get Apple messaging integration identity resolution settings |
| [**GetConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId**](#GetConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId) | **Get** /api/v2/conversations/messaging/identityresolution/integrations/facebook/{integrationId} | Get Facebook messaging integration identity resolution settings |
| [**GetConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId**](#GetConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId) | **Get** /api/v2/conversations/messaging/identityresolution/integrations/instagram/{integrationId} | Get an Instagram integration identity resolution settings |
| [**GetConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId**](#GetConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId) | **Get** /api/v2/conversations/messaging/identityresolution/integrations/open/{integrationId} | Get an open messaging integration Identity Resolution settings |
| [**GetConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId**](#GetConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId) | **Get** /api/v2/conversations/messaging/identityresolution/integrations/twitter/{integrationId} | Get X (Formally Twitter) messaging integration identity resolution settings |
| [**GetConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId**](#GetConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId) | **Get** /api/v2/conversations/messaging/identityresolution/integrations/whatsapp/{integrationId} | Get a whatsApp integration Identity Resolution settings |
| [**GetConversationsMessagingIntegrationTwitterOauthSettings**](#GetConversationsMessagingIntegrationTwitterOauthSettings) | **Get** /api/v2/conversations/messaging/integrations/{integrationId}/twitter/oauth/settings | Get twitter oauth settings to patch an integration |
| [**GetConversationsMessagingIntegrations**](#GetConversationsMessagingIntegrations) | **Get** /api/v2/conversations/messaging/integrations | Get a list of Integrations |
| [**GetConversationsMessagingIntegrationsApple**](#GetConversationsMessagingIntegrationsApple) | **Get** /api/v2/conversations/messaging/integrations/apple | Get a list of Apple Integrations |
| [**GetConversationsMessagingIntegrationsAppleIntegrationId**](#GetConversationsMessagingIntegrationsAppleIntegrationId) | **Get** /api/v2/conversations/messaging/integrations/apple/{integrationId} | Get an Apple messaging integration |
| [**GetConversationsMessagingIntegrationsFacebook**](#GetConversationsMessagingIntegrationsFacebook) | **Get** /api/v2/conversations/messaging/integrations/facebook | Get a list of Facebook Integrations |
| [**GetConversationsMessagingIntegrationsFacebookIntegrationId**](#GetConversationsMessagingIntegrationsFacebookIntegrationId) | **Get** /api/v2/conversations/messaging/integrations/facebook/{integrationId} | Get a Facebook messaging integration |
| [**GetConversationsMessagingIntegrationsInstagram**](#GetConversationsMessagingIntegrationsInstagram) | **Get** /api/v2/conversations/messaging/integrations/instagram | Get a list of Instagram Integrations |
| [**GetConversationsMessagingIntegrationsInstagramIntegrationId**](#GetConversationsMessagingIntegrationsInstagramIntegrationId) | **Get** /api/v2/conversations/messaging/integrations/instagram/{integrationId} | Get Instagram messaging integration |
| [**GetConversationsMessagingIntegrationsOpen**](#GetConversationsMessagingIntegrationsOpen) | **Get** /api/v2/conversations/messaging/integrations/open | Get a list of Open messaging integrations |
| [**GetConversationsMessagingIntegrationsOpenIntegrationId**](#GetConversationsMessagingIntegrationsOpenIntegrationId) | **Get** /api/v2/conversations/messaging/integrations/open/{integrationId} | Get an Open messaging integration |
| [**GetConversationsMessagingIntegrationsTwitter**](#GetConversationsMessagingIntegrationsTwitter) | **Get** /api/v2/conversations/messaging/integrations/twitter | Get a list of Twitter Integrations |
| [**GetConversationsMessagingIntegrationsTwitterIntegrationId**](#GetConversationsMessagingIntegrationsTwitterIntegrationId) | **Get** /api/v2/conversations/messaging/integrations/twitter/{integrationId} | Get Twitter messaging integration |
| [**GetConversationsMessagingIntegrationsTwitterOauthSettings**](#GetConversationsMessagingIntegrationsTwitterOauthSettings) | **Get** /api/v2/conversations/messaging/integrations/twitter/oauth/settings | Get twitter oauth settings |
| [**GetConversationsMessagingIntegrationsWhatsapp**](#GetConversationsMessagingIntegrationsWhatsapp) | **Get** /api/v2/conversations/messaging/integrations/whatsapp | Get a list of WhatsApp Integrations |
| [**GetConversationsMessagingIntegrationsWhatsappIntegrationId**](#GetConversationsMessagingIntegrationsWhatsappIntegrationId) | **Get** /api/v2/conversations/messaging/integrations/whatsapp/{integrationId} | Get a WhatsApp messaging integration |
| [**GetConversationsMessagingOauthAppleCallback**](#GetConversationsMessagingOauthAppleCallback) | **Get** /api/v2/conversations/messaging/oauth/apple/callback | Call Authentication provider callback to validate state and code |
| [**GetConversationsMessagingSetting**](#GetConversationsMessagingSetting) | **Get** /api/v2/conversations/messaging/settings/{messageSettingId} | Get a messaging setting |
| [**GetConversationsMessagingSettings**](#GetConversationsMessagingSettings) | **Get** /api/v2/conversations/messaging/settings | Get a list of messaging settings |
| [**GetConversationsMessagingSettingsDefault**](#GetConversationsMessagingSettingsDefault) | **Get** /api/v2/conversations/messaging/settings/default | Get the organization&#39;s default settings that will be used as the default when creating an integration. |
| [**GetConversationsMessagingSupportedcontent**](#GetConversationsMessagingSupportedcontent) | **Get** /api/v2/conversations/messaging/supportedcontent | Get a list of Supported Content profiles |
| [**GetConversationsMessagingSupportedcontentDefault**](#GetConversationsMessagingSupportedcontentDefault) | **Get** /api/v2/conversations/messaging/supportedcontent/default | Get the organization&#39;s default supported content profile that will be used as the default when creating an integration. |
| [**GetConversationsMessagingSupportedcontentSupportedContentId**](#GetConversationsMessagingSupportedcontentSupportedContentId) | **Get** /api/v2/conversations/messaging/supportedcontent/{supportedContentId} | Get a supported content profile |
| [**GetConversationsMessagingThreadingtimeline**](#GetConversationsMessagingThreadingtimeline) | **Get** /api/v2/conversations/messaging/threadingtimeline | Get conversation threading window timeline for each messaging type |
| [**GetConversationsScreenshareParticipantCommunicationWrapup**](#GetConversationsScreenshareParticipantCommunicationWrapup) | **Get** /api/v2/conversations/screenshares/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsSettings**](#GetConversationsSettings) | **Get** /api/v2/conversations/settings | Get Settings |
| [**GetConversationsSocialParticipantCommunicationWrapup**](#GetConversationsSocialParticipantCommunicationWrapup) | **Get** /api/v2/conversations/socials/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsVideoDetails**](#GetConversationsVideoDetails) | **Get** /api/v2/conversations/videos/{conferenceId}/details | Get video conference details (e.g. the current number of active participants). |
| [**GetConversationsVideoParticipantCommunicationWrapup**](#GetConversationsVideoParticipantCommunicationWrapup) | **Get** /api/v2/conversations/videos/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsVideosMeeting**](#GetConversationsVideosMeeting) | **Get** /api/v2/conversations/videos/meetings/{meetingId} | Gets a record for a given meetingId |
| [**PatchConversationParticipant**](#PatchConversationParticipant) | **Patch** /api/v2/conversations/{conversationId}/participants/{participantId} | Update a participant. |
| [**PatchConversationParticipantAttributes**](#PatchConversationParticipantAttributes) | **Patch** /api/v2/conversations/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationRecordingstate**](#PatchConversationRecordingstate) | **Patch** /api/v2/conversations/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PatchConversationSecureattributes**](#PatchConversationSecureattributes) | **Patch** /api/v2/conversations/{conversationId}/secureattributes | Update the secure attributes on a conversation. |
| [**PatchConversationSummaryEngagements**](#PatchConversationSummaryEngagements) | **Patch** /api/v2/conversations/{conversationId}/summaries/{summaryId}/engagements | Update agent&#39;s engagement for the summary. |
| [**PatchConversationSummaryFeedback**](#PatchConversationSummaryFeedback) | **Patch** /api/v2/conversations/{conversationId}/summaries/{summaryId}/feedback | Update the feedback for the summary. |
| [**PatchConversationUtilizationlabel**](#PatchConversationUtilizationlabel) | **Patch** /api/v2/conversations/{conversationId}/utilizationlabel | Update the utilization label on a conversation. When there is no value provided, the system default label is applied |
| [**PatchConversationsAftercallworkConversationIdParticipantCommunication**](#PatchConversationsAftercallworkConversationIdParticipantCommunication) | **Patch** /api/v2/conversations/aftercallwork/{conversationId}/participants/{participantId}/communications/{communicationId} | Update after-call work for this conversation communication. |
| [**PatchConversationsCall**](#PatchConversationsCall) | **Patch** /api/v2/conversations/calls/{conversationId} | Update a conversation by setting its recording state, merging in other conversations to create a conference, or disconnecting all of the participants |
| [**PatchConversationsCallConference**](#PatchConversationsCallConference) | **Patch** /api/v2/conversations/calls/{conversationId}/conference | Update a conversation by merging in other conversations to create a conference |
| [**PatchConversationsCallParticipant**](#PatchConversationsCallParticipant) | **Patch** /api/v2/conversations/calls/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCallParticipantAttributes**](#PatchConversationsCallParticipantAttributes) | **Patch** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCallParticipantCommunication**](#PatchConversationsCallParticipantCommunication) | **Patch** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. This endpoint does not update wrapup. |
| [**PatchConversationsCallParticipantConsult**](#PatchConversationsCallParticipantConsult) | **Patch** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Change who can speak |
| [**PatchConversationsCallback**](#PatchConversationsCallback) | **Patch** /api/v2/conversations/callbacks/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsCallbackParticipant**](#PatchConversationsCallbackParticipant) | **Patch** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCallbackParticipantAttributes**](#PatchConversationsCallbackParticipantAttributes) | **Patch** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCallbackParticipantCommunication**](#PatchConversationsCallbackParticipantCommunication) | **Patch** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsCallbacks**](#PatchConversationsCallbacks) | **Patch** /api/v2/conversations/callbacks | Update a scheduled callback |
| [**PatchConversationsChat**](#PatchConversationsChat) | **Patch** /api/v2/conversations/chats/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsChatParticipant**](#PatchConversationsChatParticipant) | **Patch** /api/v2/conversations/chats/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsChatParticipantAttributes**](#PatchConversationsChatParticipantAttributes) | **Patch** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsChatParticipantCommunication**](#PatchConversationsChatParticipantCommunication) | **Patch** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. This endpoint does not update wrapup. |
| [**PatchConversationsCobrowsesession**](#PatchConversationsCobrowsesession) | **Patch** /api/v2/conversations/cobrowsesessions/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsCobrowsesessionParticipant**](#PatchConversationsCobrowsesessionParticipant) | **Patch** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCobrowsesessionParticipantAttributes**](#PatchConversationsCobrowsesessionParticipantAttributes) | **Patch** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCobrowsesessionParticipantCommunication**](#PatchConversationsCobrowsesessionParticipantCommunication) | **Patch** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsEmail**](#PatchConversationsEmail) | **Patch** /api/v2/conversations/emails/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsEmailMessagesDraft**](#PatchConversationsEmailMessagesDraft) | **Patch** /api/v2/conversations/emails/{conversationId}/messages/draft | Reset conversation draft to its initial state and/or auto-fill draft content |
| [**PatchConversationsEmailParticipant**](#PatchConversationsEmailParticipant) | **Patch** /api/v2/conversations/emails/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsEmailParticipantAttributes**](#PatchConversationsEmailParticipantAttributes) | **Patch** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsEmailParticipantCommunication**](#PatchConversationsEmailParticipantCommunication) | **Patch** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. This endpoint does not update wrapup. |
| [**PatchConversationsEmailParticipantParkingstate**](#PatchConversationsEmailParticipantParkingstate) | **Patch** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/parkingstate | Update conversation by setting its parking state |
| [**PatchConversationsMessage**](#PatchConversationsMessage) | **Patch** /api/v2/conversations/messages/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsMessageParticipant**](#PatchConversationsMessageParticipant) | **Patch** /api/v2/conversations/messages/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsMessageParticipantAttributes**](#PatchConversationsMessageParticipantAttributes) | **Patch** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsMessageParticipantCommunication**](#PatchConversationsMessageParticipantCommunication) | **Patch** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. This endpoint does not update wrapup. |
| [**PatchConversationsMessagingIntegrationsAppleIntegrationId**](#PatchConversationsMessagingIntegrationsAppleIntegrationId) | **Patch** /api/v2/conversations/messaging/integrations/apple/{integrationId} | Update an Apple messaging integration |
| [**PatchConversationsMessagingIntegrationsFacebookIntegrationId**](#PatchConversationsMessagingIntegrationsFacebookIntegrationId) | **Patch** /api/v2/conversations/messaging/integrations/facebook/{integrationId} | Update Facebook messaging integration |
| [**PatchConversationsMessagingIntegrationsInstagramIntegrationId**](#PatchConversationsMessagingIntegrationsInstagramIntegrationId) | **Patch** /api/v2/conversations/messaging/integrations/instagram/{integrationId} | Update Instagram messaging integration |
| [**PatchConversationsMessagingIntegrationsOpenIntegrationId**](#PatchConversationsMessagingIntegrationsOpenIntegrationId) | **Patch** /api/v2/conversations/messaging/integrations/open/{integrationId} | Update an Open messaging integration |
| [**PatchConversationsMessagingIntegrationsTwitterIntegrationId**](#PatchConversationsMessagingIntegrationsTwitterIntegrationId) | **Patch** /api/v2/conversations/messaging/integrations/twitter/{integrationId} | Update a Twitter messaging integration |
| [**PatchConversationsMessagingIntegrationsWhatsappEmbeddedsignupIntegrationId**](#PatchConversationsMessagingIntegrationsWhatsappEmbeddedsignupIntegrationId) | **Patch** /api/v2/conversations/messaging/integrations/whatsapp/embeddedsignup/{integrationId} | Activate a WhatsApp messaging integration created using the WhatsApp embedded signup flow |
| [**PatchConversationsMessagingIntegrationsWhatsappIntegrationId**](#PatchConversationsMessagingIntegrationsWhatsappIntegrationId) | **Patch** /api/v2/conversations/messaging/integrations/whatsapp/{integrationId} | Update a WhatsApp messaging integration |
| [**PatchConversationsMessagingSetting**](#PatchConversationsMessagingSetting) | **Patch** /api/v2/conversations/messaging/settings/{messageSettingId} | Update a messaging setting |
| [**PatchConversationsMessagingSupportedcontentSupportedContentId**](#PatchConversationsMessagingSupportedcontentSupportedContentId) | **Patch** /api/v2/conversations/messaging/supportedcontent/{supportedContentId} | Update a supported content profile |
| [**PatchConversationsSettings**](#PatchConversationsSettings) | **Patch** /api/v2/conversations/settings | Update Settings |
| [**PostAnalyticsConversationDetailsProperties**](#PostAnalyticsConversationDetailsProperties) | **Post** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostAnalyticsConversationsActivityQuery**](#PostAnalyticsConversationsActivityQuery) | **Post** /api/v2/analytics/conversations/activity/query | Query for conversation activity observations |
| [**PostAnalyticsConversationsAggregatesJobs**](#PostAnalyticsConversationsAggregatesJobs) | **Post** /api/v2/analytics/conversations/aggregates/jobs | Query for conversation aggregates asynchronously |
| [**PostAnalyticsConversationsAggregatesQuery**](#PostAnalyticsConversationsAggregatesQuery) | **Post** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostAnalyticsConversationsDetailsJobs**](#PostAnalyticsConversationsDetailsJobs) | **Post** /api/v2/analytics/conversations/details/jobs | Query for conversation details asynchronously |
| [**PostAnalyticsConversationsDetailsQuery**](#PostAnalyticsConversationsDetailsQuery) | **Post** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostConversationAssign**](#PostConversationAssign) | **Post** /api/v2/conversations/{conversationId}/assign | Attempts to manually assign a specified conversation to a specified user.  Ignores bullseye ring, PAR score, skills, and languages. |
| [**PostConversationBarge**](#PostConversationBarge) | **Post** /api/v2/conversations/{conversationId}/barge | Barge a conversation creating a barged in conference of connected participants. |
| [**PostConversationCobrowse**](#PostConversationCobrowse) | **Post** /api/v2/conversations/{conversationId}/cobrowse | Creates a cobrowse session. Requires \&quot;conversation:cobrowse:add\&quot; (for web messaging) or \&quot;conversation:cobrowsevoice:add\&quot; permission. |
| [**PostConversationCommunicationInternalmessages**](#PostConversationCommunicationInternalmessages) | **Post** /api/v2/conversations/{conversationId}/communications/{communicationId}/internalmessages | Send internal message |
| [**PostConversationDisconnect**](#PostConversationDisconnect) | **Post** /api/v2/conversations/{conversationId}/disconnect | Performs a full conversation teardown. Issues disconnect requests for any connected media. Applies a system wrap-up code to any participants that are pending wrap-up. This is not intended to be the normal way of ending interactions but is available in the event of problems with the application to allow a resynchronization of state across all components. It is recommended that users submit a support case if they are relying on this endpoint systematically as there is likely something that needs investigation. |
| [**PostConversationParticipantCallbacks**](#PostConversationParticipantCallbacks) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/callbacks | Create a new callback for the specified participant on the conversation. |
| [**PostConversationParticipantDigits**](#PostConversationParticipantDigits) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/digits | Sends DTMF to the participant |
| [**PostConversationParticipantInternalmessagesUsersCommunications**](#PostConversationParticipantInternalmessagesUsersCommunications) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/internalmessages/users/communications | Setup internal message communication with user |
| [**PostConversationParticipantReplace**](#PostConversationParticipantReplace) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationParticipantReplaceAgent**](#PostConversationParticipantReplaceAgent) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/replace/agent | Replace this participant with the specified agent |
| [**PostConversationParticipantReplaceContactExternal**](#PostConversationParticipantReplaceContactExternal) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/replace/contact/external | Replace this participant with the an external contact |
| [**PostConversationParticipantReplaceExternal**](#PostConversationParticipantReplaceExternal) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/replace/external | Replace this participant with the an external contact |
| [**PostConversationParticipantReplaceQueue**](#PostConversationParticipantReplaceQueue) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/replace/queue | Replace this participant with the specified queue |
| [**PostConversationParticipantSecureivrsessions**](#PostConversationParticipantSecureivrsessions) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/secureivrsessions | Create secure IVR session. Only a participant in the conversation can invoke a secure IVR. |
| [**PostConversationParticipantTransfer**](#PostConversationParticipantTransfer) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/transfer | Replace this participant by another one using the address of the destination. |
| [**PostConversationSuggestionEngagement**](#PostConversationSuggestionEngagement) | **Post** /api/v2/conversations/{conversationId}/suggestions/{suggestionId}/engagement | Save an engagement on the suggestion. |
| [**PostConversationSuggestionsFeedback**](#PostConversationSuggestionsFeedback) | **Post** /api/v2/conversations/{conversationId}/suggestions/feedback | Suggestion feedback. |
| [**PostConversationSummaryFeedback**](#PostConversationSummaryFeedback) | **Post** /api/v2/conversations/{conversationId}/summaries/{summaryId}/feedback | Submit feedback for the summary. |
| [**PostConversationsCall**](#PostConversationsCall) | **Post** /api/v2/conversations/calls/{conversationId} | Place a new call as part of a callback conversation. |
| [**PostConversationsCallParticipantBarge**](#PostConversationsCallParticipantBarge) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/barge | Barge a given participant&#39;s call creating a barged in conference of connected participants. |
| [**PostConversationsCallParticipantCoach**](#PostConversationsCallParticipantCoach) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/coach | Listen in on the conversation from the point of view of a given participant while speaking to just the given participant. |
| [**PostConversationsCallParticipantCommunicationWrapup**](#PostConversationsCallParticipantCommunicationWrapup) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsCallParticipantConsult**](#PostConversationsCallParticipantConsult) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Initiate and update consult transfer |
| [**PostConversationsCallParticipantConsultAgent**](#PostConversationsCallParticipantConsultAgent) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult/agent | Initiate a consult transfer to an agent |
| [**PostConversationsCallParticipantConsultContactExternal**](#PostConversationsCallParticipantConsultContactExternal) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult/contact/external | Initiate a consult transfer to an external contact |
| [**PostConversationsCallParticipantConsultExternal**](#PostConversationsCallParticipantConsultExternal) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult/external | Initiate a consult transfer to an external contact |
| [**PostConversationsCallParticipantConsultQueue**](#PostConversationsCallParticipantConsultQueue) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult/queue | Initiate a consult transfer to a queue |
| [**PostConversationsCallParticipantMonitor**](#PostConversationsCallParticipantMonitor) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**PostConversationsCallParticipantReplace**](#PostConversationsCallParticipantReplace) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsCallParticipantVoiceConsult**](#PostConversationsCallParticipantVoiceConsult) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/voice/consult | Initiate voice consult transfer |
| [**PostConversationsCallParticipants**](#PostConversationsCallParticipants) | **Post** /api/v2/conversations/calls/{conversationId}/participants | Add participants to a conversation |
| [**PostConversationsCallParticipantsUserUserId**](#PostConversationsCallParticipantsUserUserId) | **Post** /api/v2/conversations/calls/{conversationId}/participants/user/{userId} | Add participants to a conversation on behalf of a user |
| [**PostConversationsCallbackParticipantCommunicationWrapup**](#PostConversationsCallbackParticipantCommunicationWrapup) | **Post** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsCallbackParticipantReplace**](#PostConversationsCallbackParticipantReplace) | **Post** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsCallbacks**](#PostConversationsCallbacks) | **Post** /api/v2/conversations/callbacks | Create a Callback |
| [**PostConversationsCallbacksBulkDisconnect**](#PostConversationsCallbacksBulkDisconnect) | **Post** /api/v2/conversations/callbacks/bulk/disconnect | Disconnect multiple scheduled callbacks |
| [**PostConversationsCallbacksBulkUpdate**](#PostConversationsCallbacksBulkUpdate) | **Post** /api/v2/conversations/callbacks/bulk/update | Update multiple scheduled callbacks |
| [**PostConversationsCalls**](#PostConversationsCalls) | **Post** /api/v2/conversations/calls | Create a call conversation |
| [**PostConversationsCallsUserUserId**](#PostConversationsCallsUserUserId) | **Post** /api/v2/conversations/calls/user/{userId} | Create a call conversation on behalf of a user |
| [**PostConversationsChatCommunicationMessages**](#PostConversationsChatCommunicationMessages) | **Post** /api/v2/conversations/chats/{conversationId}/communications/{communicationId}/messages | Send a message on behalf of a communication in a chat conversation. |
| [**PostConversationsChatCommunicationTyping**](#PostConversationsChatCommunicationTyping) | **Post** /api/v2/conversations/chats/{conversationId}/communications/{communicationId}/typing | Send a typing-indicator on behalf of a communication in a chat conversation. |
| [**PostConversationsChatParticipantCommunicationWrapup**](#PostConversationsChatParticipantCommunicationWrapup) | **Post** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsChatParticipantReplace**](#PostConversationsChatParticipantReplace) | **Post** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsChats**](#PostConversationsChats) | **Post** /api/v2/conversations/chats | Create a web chat conversation |
| [**PostConversationsCobrowsesessionParticipantCommunicationWrapup**](#PostConversationsCobrowsesessionParticipantCommunicationWrapup) | **Post** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsCobrowsesessionParticipantReplace**](#PostConversationsCobrowsesessionParticipantReplace) | **Post** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsEmailInboundmessages**](#PostConversationsEmailInboundmessages) | **Post** /api/v2/conversations/emails/{conversationId}/inboundmessages | Send an email to an external conversation. An external conversation is one where the provider is not PureCloud based. This endpoint allows the sender of the external email to reply or send a new message to the existing conversation. The new message will be treated as part of the existing conversation and chained to it. |
| [**PostConversationsEmailMessages**](#PostConversationsEmailMessages) | **Post** /api/v2/conversations/emails/{conversationId}/messages | Send an email reply |
| [**PostConversationsEmailMessagesDraftAttachmentsCopy**](#PostConversationsEmailMessagesDraftAttachmentsCopy) | **Post** /api/v2/conversations/emails/{conversationId}/messages/draft/attachments/copy | Copy attachments from an email message to the current draft. |
| [**PostConversationsEmailParticipantCommunicationWrapup**](#PostConversationsEmailParticipantCommunicationWrapup) | **Post** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsEmailParticipantReplace**](#PostConversationsEmailParticipantReplace) | **Post** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsEmailReconnect**](#PostConversationsEmailReconnect) | **Post** /api/v2/conversations/emails/{conversationId}/reconnect | Reconnect the user to the most recently disconnected customer on a fully disconnected email conversation |
| [**PostConversationsEmails**](#PostConversationsEmails) | **Post** /api/v2/conversations/emails | Create an email conversation |
| [**PostConversationsEmailsAgentless**](#PostConversationsEmailsAgentless) | **Post** /api/v2/conversations/emails/agentless | Create an email conversation, per API |
| [**PostConversationsFaxes**](#PostConversationsFaxes) | **Post** /api/v2/conversations/faxes | Create Fax Conversation |
| [**PostConversationsKeyconfigurations**](#PostConversationsKeyconfigurations) | **Post** /api/v2/conversations/keyconfigurations | Setup configurations for encryption key creation |
| [**PostConversationsKeyconfigurationsValidate**](#PostConversationsKeyconfigurationsValidate) | **Post** /api/v2/conversations/keyconfigurations/validate | Validate encryption key configurations without saving it |
| [**PostConversationsMessageCommunicationMessages**](#PostConversationsMessageCommunicationMessages) | **Post** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages | Send message |
| [**PostConversationsMessageCommunicationMessagesMedia**](#PostConversationsMessageCommunicationMessagesMedia) | **Post** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages/media | Create media |
| [**PostConversationsMessageCommunicationMessagesMediaUploads**](#PostConversationsMessageCommunicationMessagesMediaUploads) | **Post** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages/media/uploads | Create a URL to upload a message media file |
| [**PostConversationsMessageCommunicationSocialmediaMessages**](#PostConversationsMessageCommunicationSocialmediaMessages) | **Post** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/socialmedia/messages | Send a social media message |
| [**PostConversationsMessageCommunicationTyping**](#PostConversationsMessageCommunicationTyping) | **Post** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/typing | Send message typing event |
| [**PostConversationsMessageInboundOpenEvent**](#PostConversationsMessageInboundOpenEvent) | **Post** /api/v2/conversations/messages/{integrationId}/inbound/open/event | Send an inbound Open Event Message |
| [**PostConversationsMessageInboundOpenMessage**](#PostConversationsMessageInboundOpenMessage) | **Post** /api/v2/conversations/messages/{integrationId}/inbound/open/message | Send inbound Open Message |
| [**PostConversationsMessageInboundOpenReceipt**](#PostConversationsMessageInboundOpenReceipt) | **Post** /api/v2/conversations/messages/{integrationId}/inbound/open/receipt | Send an inbound Open Receipt Message |
| [**PostConversationsMessageInboundOpenStructuredResponse**](#PostConversationsMessageInboundOpenStructuredResponse) | **Post** /api/v2/conversations/messages/{integrationId}/inbound/open/structured/response | Send inbound Open Response |
| [**PostConversationsMessageMessagesBulk**](#PostConversationsMessageMessagesBulk) | **Post** /api/v2/conversations/messages/{conversationId}/messages/bulk | Get messages in batch |
| [**PostConversationsMessageParticipantCommunicationWrapup**](#PostConversationsMessageParticipantCommunicationWrapup) | **Post** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsMessageParticipantMonitor**](#PostConversationsMessageParticipantMonitor) | **Post** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**PostConversationsMessageParticipantReplace**](#PostConversationsMessageParticipantReplace) | **Post** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsMessages**](#PostConversationsMessages) | **Post** /api/v2/conversations/messages | Create an outbound messaging conversation. |
| [**PostConversationsMessagesAgentless**](#PostConversationsMessagesAgentless) | **Post** /api/v2/conversations/messages/agentless | Send an agentless outbound message |
| [**PostConversationsMessagesInboundOpen**](#PostConversationsMessagesInboundOpen) | **Post** /api/v2/conversations/messages/inbound/open | Send an inbound Open Message |
| [**PostConversationsMessagingIntegrationsApple**](#PostConversationsMessagingIntegrationsApple) | **Post** /api/v2/conversations/messaging/integrations/apple | Create Apple Integration |
| [**PostConversationsMessagingIntegrationsFacebook**](#PostConversationsMessagingIntegrationsFacebook) | **Post** /api/v2/conversations/messaging/integrations/facebook | Create a Facebook Integration |
| [**PostConversationsMessagingIntegrationsInstagram**](#PostConversationsMessagingIntegrationsInstagram) | **Post** /api/v2/conversations/messaging/integrations/instagram | Create Instagram Integration |
| [**PostConversationsMessagingIntegrationsOpen**](#PostConversationsMessagingIntegrationsOpen) | **Post** /api/v2/conversations/messaging/integrations/open | Create an Open messaging integration |
| [**PostConversationsMessagingIntegrationsTwitter**](#PostConversationsMessagingIntegrationsTwitter) | **Post** /api/v2/conversations/messaging/integrations/twitter | Create Twitter Integration |
| [**PostConversationsMessagingIntegrationsWhatsapp**](#PostConversationsMessagingIntegrationsWhatsapp) | **Post** /api/v2/conversations/messaging/integrations/whatsapp | [This API is deprecated. Use POST /api/v2/conversations/messaging/integrations/whatsapp/embeddedsignup instead] Create a WhatsApp Integration |
| [**PostConversationsMessagingIntegrationsWhatsappEmbeddedsignup**](#PostConversationsMessagingIntegrationsWhatsappEmbeddedsignup) | **Post** /api/v2/conversations/messaging/integrations/whatsapp/embeddedsignup | Create a WhatsApp Integration using the WhatsApp embedded signup flow |
| [**PostConversationsMessagingSettings**](#PostConversationsMessagingSettings) | **Post** /api/v2/conversations/messaging/settings | Create a messaging setting |
| [**PostConversationsMessagingSupportedcontent**](#PostConversationsMessagingSupportedcontent) | **Post** /api/v2/conversations/messaging/supportedcontent | Create a Supported Content profile |
| [**PostConversationsParticipantsAttributesSearch**](#PostConversationsParticipantsAttributesSearch) | **Post** /api/v2/conversations/participants/attributes/search | Search conversations |
| [**PostConversationsScreenshareParticipantCommunicationWrapup**](#PostConversationsScreenshareParticipantCommunicationWrapup) | **Post** /api/v2/conversations/screenshares/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsSocialParticipantCommunicationWrapup**](#PostConversationsSocialParticipantCommunicationWrapup) | **Post** /api/v2/conversations/socials/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsVideoAgentconferenceCommunication**](#PostConversationsVideoAgentconferenceCommunication) | **Post** /api/v2/conversations/videos/{conversationId}/agentconference/communications/{communicationId} | Create an Agent-Type video conference and assign an agent to it |
| [**PostConversationsVideoParticipantCommunicationWrapup**](#PostConversationsVideoParticipantCommunicationWrapup) | **Post** /api/v2/conversations/videos/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsVideosMeetings**](#PostConversationsVideosMeetings) | **Post** /api/v2/conversations/videos/meetings | Generate a meetingId for a given conferenceId |
| [**PutConversationParticipantFlaggedreason**](#PutConversationParticipantFlaggedreason) | **Put** /api/v2/conversations/{conversationId}/participants/{participantId}/flaggedreason | Set flagged reason on conversation participant to indicate bad conversation quality. |
| [**PutConversationSecureattributes**](#PutConversationSecureattributes) | **Put** /api/v2/conversations/{conversationId}/secureattributes | Set the secure attributes on a conversation. |
| [**PutConversationTags**](#PutConversationTags) | **Put** /api/v2/conversations/{conversationId}/tags | Update the tags on a conversation. |
| [**PutConversationsCallParticipantCommunicationUuidata**](#PutConversationsCallParticipantCommunicationUuidata) | **Put** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId}/uuidata | Set uuiData to be sent on future commands. |
| [**PutConversationsCallRecordingstate**](#PutConversationsCallRecordingstate) | **Put** /api/v2/conversations/calls/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsCallbackRecordingstate**](#PutConversationsCallbackRecordingstate) | **Put** /api/v2/conversations/callbacks/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsChatRecordingstate**](#PutConversationsChatRecordingstate) | **Put** /api/v2/conversations/chats/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsCobrowsesessionRecordingstate**](#PutConversationsCobrowsesessionRecordingstate) | **Put** /api/v2/conversations/cobrowsesessions/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsEmailMessagesDraft**](#PutConversationsEmailMessagesDraft) | **Put** /api/v2/conversations/emails/{conversationId}/messages/draft | Update conversation draft reply |
| [**PutConversationsEmailRecordingstate**](#PutConversationsEmailRecordingstate) | **Put** /api/v2/conversations/emails/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsKeyconfiguration**](#PutConversationsKeyconfiguration) | **Put** /api/v2/conversations/keyconfigurations/{keyconfigurationsId} | Update the encryption key configurations |
| [**PutConversationsMessageRecordingstate**](#PutConversationsMessageRecordingstate) | **Put** /api/v2/conversations/messages/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId**](#PutConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId) | **Put** /api/v2/conversations/messaging/identityresolution/integrations/apple/{integrationId} | Create an identity resolution settings for a Apple messaging integration |
| [**PutConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId**](#PutConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId) | **Put** /api/v2/conversations/messaging/identityresolution/integrations/facebook/{integrationId} | Create an identity resolution settings for a Facebook messaging integration |
| [**PutConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId**](#PutConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId) | **Put** /api/v2/conversations/messaging/identityresolution/integrations/instagram/{integrationId} | Create identity resolution settings for an Instagram messaging integration |
| [**PutConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId**](#PutConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId) | **Put** /api/v2/conversations/messaging/identityresolution/integrations/open/{integrationId} | Update an open messaging integration Identity Resolution settings |
| [**PutConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId**](#PutConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId) | **Put** /api/v2/conversations/messaging/identityresolution/integrations/twitter/{integrationId} | Create an identity resolution settings for an X (Formally Twitter) messaging integration |
| [**PutConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId**](#PutConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId) | **Put** /api/v2/conversations/messaging/identityresolution/integrations/whatsapp/{integrationId} | Update a whatsApp integration Identity Resolution settings |
| [**PutConversationsMessagingSettingsDefault**](#PutConversationsMessagingSettingsDefault) | **Put** /api/v2/conversations/messaging/settings/default | Set the organization&#39;s default setting that may be applied to to integrations without settings |
| [**PutConversationsMessagingSupportedcontentDefault**](#PutConversationsMessagingSupportedcontentDefault) | **Put** /api/v2/conversations/messaging/supportedcontent/default | Set the organization&#39;s default supported content profile that may be assigned to an integration when it is created. |
| [**PutConversationsMessagingThreadingtimeline**](#PutConversationsMessagingThreadingtimeline) | **Put** /api/v2/conversations/messaging/threadingtimeline | Update conversation threading window timeline for each messaging type |
| [**PutConversationsScreenshareRecordingstate**](#PutConversationsScreenshareRecordingstate) | **Put** /api/v2/conversations/screenshares/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsSocialRecordingstate**](#PutConversationsSocialRecordingstate) | **Put** /api/v2/conversations/socials/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsVideoRecordingstate**](#PutConversationsVideoRecordingstate) | **Put** /api/v2/conversations/videos/{conversationId}/recordingstate | Update a conversation by setting its recording state |



## DeleteAnalyticsConversationsAggregatesJob

> void DeleteAnalyticsConversationsAggregatesJob (string jobId)


Delete/cancel an async request for conversation aggregates

DeleteAnalyticsConversationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAnalyticsConversationsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Delete/cancel an async request for conversation aggregates
                apiInstance.DeleteAnalyticsConversationsAggregatesJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteAnalyticsConversationsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |

### Return type

void (empty response body)


## DeleteAnalyticsConversationsDetailsJob

> void DeleteAnalyticsConversationsDetailsJob (string jobId)


Delete/cancel an async details job

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAnalyticsConversationsDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Delete/cancel an async details job
                apiInstance.DeleteAnalyticsConversationsDetailsJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteAnalyticsConversationsDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |

### Return type

void (empty response body)


## DeleteConversation

> void DeleteConversation (string conversationId)


Update a conversation by disconnecting all of the participants

Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            { 
                // Update a conversation by disconnecting all of the participants
                apiInstance.DeleteConversation(conversationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |

### Return type

void (empty response body)


## DeleteConversationParticipantCode

> void DeleteConversationParticipantCode (string conversationId, string participantId, string addCommunicationCode)


Delete a code used to add a communication to this participant

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationParticipantCodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var addCommunicationCode = addCommunicationCode_example;  // string | addCommunicationCode

            try
            { 
                // Delete a code used to add a communication to this participant
                apiInstance.DeleteConversationParticipantCode(conversationId, participantId, addCommunicationCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationParticipantCode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **addCommunicationCode** | **string**| addCommunicationCode |  |

### Return type

void (empty response body)


## DeleteConversationParticipantFlaggedreason

> void DeleteConversationParticipantFlaggedreason (string conversationId, string participantId)


Remove flagged reason from conversation participant.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationParticipantFlaggedreasonExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            { 
                // Remove flagged reason from conversation participant.
                apiInstance.DeleteConversationParticipantFlaggedreason(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationParticipantFlaggedreason: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |

### Return type

void (empty response body)


## DeleteConversationsCallParticipantConsult

> void DeleteConversationsCallParticipantConsult (string conversationId, string participantId)


Cancel the transfer

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsCallParticipantConsultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Cancel the transfer
                apiInstance.DeleteConversationsCallParticipantConsult(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsCallParticipantConsult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

void (empty response body)


## DeleteConversationsEmailMessagesDraftAttachment

> void DeleteConversationsEmailMessagesDraftAttachment (string conversationId, string attachmentId)


Delete attachment from draft

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsEmailMessagesDraftAttachmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var attachmentId = attachmentId_example;  // string | attachmentId

            try
            { 
                // Delete attachment from draft
                apiInstance.DeleteConversationsEmailMessagesDraftAttachment(conversationId, attachmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsEmailMessagesDraftAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **attachmentId** | **string**| attachmentId |  |

### Return type

void (empty response body)


## DeleteConversationsMessagesCachedmediaCachedMediaItemId

> void DeleteConversationsMessagesCachedmediaCachedMediaItemId (string cachedMediaItemId)


Remove a cached media item asychronously

Requires ANY permissions: 

* conversation:cachedMedia:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagesCachedmediaCachedMediaItemIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var cachedMediaItemId = cachedMediaItemId_example;  // string | cachedMediaItemId

            try
            { 
                // Remove a cached media item asychronously
                apiInstance.DeleteConversationsMessagesCachedmediaCachedMediaItemId(cachedMediaItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagesCachedmediaCachedMediaItemId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **cachedMediaItemId** | **string**| cachedMediaItemId |  |

### Return type

void (empty response body)


## DeleteConversationsMessagingIntegrationsAppleIntegrationId

> void DeleteConversationsMessagingIntegrationsAppleIntegrationId (string integrationId)


Delete an Apple messaging integration

Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsAppleIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete an Apple messaging integration
                apiInstance.DeleteConversationsMessagingIntegrationsAppleIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsAppleIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

void (empty response body)


## DeleteConversationsMessagingIntegrationsFacebookIntegrationId

> void DeleteConversationsMessagingIntegrationsFacebookIntegrationId (string integrationId)


Delete a Facebook messaging integration

Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsFacebookIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete a Facebook messaging integration
                apiInstance.DeleteConversationsMessagingIntegrationsFacebookIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsFacebookIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

void (empty response body)


## DeleteConversationsMessagingIntegrationsInstagramIntegrationId

> void DeleteConversationsMessagingIntegrationsInstagramIntegrationId (string integrationId)


Delete Instagram messaging integration

Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsInstagramIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete Instagram messaging integration
                apiInstance.DeleteConversationsMessagingIntegrationsInstagramIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsInstagramIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

void (empty response body)


## DeleteConversationsMessagingIntegrationsOpenIntegrationId

> void DeleteConversationsMessagingIntegrationsOpenIntegrationId (string integrationId)


Delete an Open messaging integration

See https://developer.genesys.cloud/api/digital/openmessaging/ for more information.

Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsOpenIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete an Open messaging integration
                apiInstance.DeleteConversationsMessagingIntegrationsOpenIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsOpenIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

void (empty response body)


## DeleteConversationsMessagingIntegrationsTwitterIntegrationId

> void DeleteConversationsMessagingIntegrationsTwitterIntegrationId (string integrationId)


Delete Twitter messaging integration

Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsTwitterIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete Twitter messaging integration
                apiInstance.DeleteConversationsMessagingIntegrationsTwitterIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsTwitterIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

void (empty response body)


## DeleteConversationsMessagingIntegrationsWhatsappIntegrationId

> [**WhatsAppIntegration**](WhatsAppIntegration) DeleteConversationsMessagingIntegrationsWhatsappIntegrationId (string integrationId)


Delete a WhatsApp messaging integration

Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsWhatsappIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete a WhatsApp messaging integration
                WhatsAppIntegration result = apiInstance.DeleteConversationsMessagingIntegrationsWhatsappIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsWhatsappIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration)


## DeleteConversationsMessagingSetting

> void DeleteConversationsMessagingSetting (string messageSettingId)


Delete a messaging setting

Requires ALL permissions: 

* messaging:setting:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var messageSettingId = messageSettingId_example;  // string | Message Setting ID

            try
            { 
                // Delete a messaging setting
                apiInstance.DeleteConversationsMessagingSetting(messageSettingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageSettingId** | **string**| Message Setting ID |  |

### Return type

void (empty response body)


## DeleteConversationsMessagingSettingsDefault

> void DeleteConversationsMessagingSettingsDefault ()


Delete the organization's default setting, a global default will be applied to integrations without settings

When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be assigned to it.

Requires ALL permissions: 

* messaging:setting:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingSettingsDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Delete the organization's default setting, a global default will be applied to integrations without settings
                apiInstance.DeleteConversationsMessagingSettingsDefault();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingSettingsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## DeleteConversationsMessagingSupportedcontentSupportedContentId

> void DeleteConversationsMessagingSupportedcontentSupportedContentId (string supportedContentId)


Delete a supported content profile

Requires ALL permissions: 

* messaging:supportedContent:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingSupportedcontentSupportedContentIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var supportedContentId = supportedContentId_example;  // string | Supported Content ID

            try
            { 
                // Delete a supported content profile
                apiInstance.DeleteConversationsMessagingSupportedcontentSupportedContentId(supportedContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingSupportedcontentSupportedContentId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **supportedContentId** | **string**| Supported Content ID |  |

### Return type

void (empty response body)


## GetAnalyticsConversationDetails

> [**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes) GetAnalyticsConversationDetails (string conversationId)


Get a conversation by id

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get a conversation by id
                AnalyticsConversationWithoutAttributes result = apiInstance.GetAnalyticsConversationDetails(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes)


## GetAnalyticsConversationsAggregatesJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsConversationsAggregatesJob (string jobId)


Get status for async query for conversation aggregates

GetAnalyticsConversationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsAggregatesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for conversation aggregates
                AsyncQueryStatus result = apiInstance.GetAnalyticsConversationsAggregatesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationsAggregatesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsConversationsAggregatesJobResults

> [**ConversationAsyncAggregateQueryResponse**](ConversationAsyncAggregateQueryResponse) GetAnalyticsConversationsAggregatesJobResults (string jobId, string cursor = null)


Fetch a page of results for an async aggregates query

GetAnalyticsConversationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsAggregatesJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Cursor token to retrieve next page (optional) 

            try
            { 
                // Fetch a page of results for an async aggregates query
                ConversationAsyncAggregateQueryResponse result = apiInstance.GetAnalyticsConversationsAggregatesJobResults(jobId, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationsAggregatesJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Cursor token to retrieve next page | [optional]  |

### Return type

[**ConversationAsyncAggregateQueryResponse**](ConversationAsyncAggregateQueryResponse)


## GetAnalyticsConversationsDetails

> [**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse) GetAnalyticsConversationsDetails (List<string> id = null)


Gets multiple conversations by id

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var id = new List<string>(); // List<string> | Comma-separated conversation ids (optional) 

            try
            { 
                // Gets multiple conversations by id
                AnalyticsConversationWithoutAttributesMultiGetResponse result = apiInstance.GetAnalyticsConversationsDetails(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationsDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| Comma-separated conversation ids | [optional]  |

### Return type

[**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse)


## GetAnalyticsConversationsDetailsJob

> [**AsyncQueryStatus**](AsyncQueryStatus) GetAnalyticsConversationsDetailsJob (string jobId)


Get status for async query for conversation details

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for conversation details
                AsyncQueryStatus result = apiInstance.GetAnalyticsConversationsDetailsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationsDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus)


## GetAnalyticsConversationsDetailsJobResults

> [**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse) GetAnalyticsConversationsDetailsJobResults (string jobId, string cursor = null, int? pageSize = null)


Fetch a page of results for an async details job

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 
            var pageSize = 56;  // int? | The desired maximum number of results (optional) 

            try
            { 
                // Fetch a page of results for an async details job
                AnalyticsConversationAsyncQueryResponse result = apiInstance.GetAnalyticsConversationsDetailsJobResults(jobId, cursor, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationsDetailsJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
| **pageSize** | **int?**| The desired maximum number of results | [optional]  |

### Return type

[**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse)


## GetAnalyticsConversationsDetailsJobsAvailability

> [**DataAvailabilityResponse**](DataAvailabilityResponse) GetAnalyticsConversationsDetailsJobsAvailability ()


Lookup the datalake availability date and time

Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsJobsAvailabilityExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Lookup the datalake availability date and time
                DataAvailabilityResponse result = apiInstance.GetAnalyticsConversationsDetailsJobsAvailability();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationsDetailsJobsAvailability: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**DataAvailabilityResponse**](DataAvailabilityResponse)


## GetConversation

> [**Conversation**](Conversation) GetConversation (string conversationId)


Get conversation

Requires ANY permissions: 

* conversation:communication:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            { 
                // Get conversation
                Conversation result = apiInstance.GetConversation(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |

### Return type

[**Conversation**](Conversation)


## GetConversationCommunicationInternalmessage

> [**InternalMessageData**](InternalMessageData) GetConversationCommunicationInternalmessage (string conversationId, string communicationId, string messageId)


Get message

GetConversationCommunicationInternalmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:internalMessaging:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationCommunicationInternalmessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Get message
                InternalMessageData result = apiInstance.GetConversationCommunicationInternalmessage(conversationId, communicationId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationCommunicationInternalmessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **messageId** | **string**| messageId |  |

### Return type

[**InternalMessageData**](InternalMessageData)


## GetConversationCommunicationInternalmessages

> [**InternalMessageDataEntityListing**](InternalMessageDataEntityListing) GetConversationCommunicationInternalmessages (string conversationId, string communicationId, int? pageSize = null, int? pageNumber = null)


Get messages for communication

GetConversationCommunicationInternalmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:internalMessaging:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationCommunicationInternalmessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var pageSize = 56;  // int? | Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 200. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get messages for communication
                InternalMessageDataEntityListing result = apiInstance.GetConversationCommunicationInternalmessages(conversationId, communicationId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationCommunicationInternalmessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **pageSize** | **int?**| Indicates maximum number of results in response. Default page size is 25 results. The maximum page size is 200. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**InternalMessageDataEntityListing**](InternalMessageDataEntityListing)


## GetConversationParticipantSecureivrsession

> [**SecureSession**](SecureSession) GetConversationParticipantSecureivrsession (string conversationId, string participantId, string secureSessionId)


Fetch info on a secure session

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantSecureivrsessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var secureSessionId = secureSessionId_example;  // string | secure IVR session ID

            try
            { 
                // Fetch info on a secure session
                SecureSession result = apiInstance.GetConversationParticipantSecureivrsession(conversationId, participantId, secureSessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantSecureivrsession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **secureSessionId** | **string**| secure IVR session ID |  |

### Return type

[**SecureSession**](SecureSession)


## GetConversationParticipantSecureivrsessions

> [**SecureSessionEntityListing**](SecureSessionEntityListing) GetConversationParticipantSecureivrsessions (string conversationId, string participantId)


Get a list of secure sessions for this participant.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantSecureivrsessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            { 
                // Get a list of secure sessions for this participant.
                SecureSessionEntityListing result = apiInstance.GetConversationParticipantSecureivrsessions(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantSecureivrsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |

### Return type

[**SecureSessionEntityListing**](SecureSessionEntityListing)


## GetConversationParticipantWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationParticipantWrapup (string conversationId, string participantId, bool? provisional = null)


Get the wrap-up for this conversation participant. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationParticipantWrapupcodes

> [**List&lt;WrapupCode&gt;**](WrapupCode) GetConversationParticipantWrapupcodes (string conversationId, string participantId)


Get list of wrapup codes for this conversation participant

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List<WrapupCode> result = apiInstance.GetConversationParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |

### Return type

[**List<WrapupCode>**](WrapupCode)


## GetConversationSecureattributes

> [**ConversationSecureAttributes**](ConversationSecureAttributes) GetConversationSecureattributes (string conversationId)


Get the secure attributes on a conversation.

Requires ANY permissions: 

* conversation:participant:attributesview

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationSecureattributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            { 
                // Get the secure attributes on a conversation.
                ConversationSecureAttributes result = apiInstance.GetConversationSecureattributes(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationSecureattributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |

### Return type

[**ConversationSecureAttributes**](ConversationSecureAttributes)


## GetConversationSuggestion

> [**Suggestion**](Suggestion) GetConversationSuggestion (string conversationId, string suggestionId)


Get Suggestion.

Requires ALL permissions: 

* conversation:suggestion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationSuggestionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var suggestionId = suggestionId_example;  // string | Suggestion ID

            try
            { 
                // Get Suggestion.
                Suggestion result = apiInstance.GetConversationSuggestion(conversationId, suggestionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationSuggestion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **suggestionId** | **string**| Suggestion ID |  |

### Return type

[**Suggestion**](Suggestion)


## GetConversationSuggestions

> [**SuggestionListing**](SuggestionListing) GetConversationSuggestions (string conversationId, string before = null, string after = null, string pageSize = null, string type = null, string state = null)


Get all suggestions for a conversation.

Requires ALL permissions: 

* conversation:suggestion:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationSuggestionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var type = type_example;  // string | Suggestion type to filter by. (optional) 
            var state = state_example;  // string | Suggestion state to filter Copilot suggestions. (optional) 

            try
            { 
                // Get all suggestions for a conversation.
                SuggestionListing result = apiInstance.GetConversationSuggestions(conversationId, before, after, pageSize, type, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationSuggestions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **type** | **string**| Suggestion type to filter by. | [optional] <br />**Values**: Faq, Article, KnowledgeArticle, KnowledgeSearch, CannedResponse, Script |
| **state** | **string**| Suggestion state to filter Copilot suggestions. | [optional] <br />**Values**: Suggested, Accepted, Dismissed, Failed, Rated |

### Return type

[**SuggestionListing**](SuggestionListing)


## GetConversationSummaries

> [**ConversationSummariesGetResponse**](ConversationSummariesGetResponse) GetConversationSummaries (string conversationId)


Get the summaries of the conversation.

Requires ALL permissions: 

* conversation:summary:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationSummariesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | Conversation ID

            try
            { 
                // Get the summaries of the conversation.
                ConversationSummariesGetResponse result = apiInstance.GetConversationSummaries(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationSummaries: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |

### Return type

[**ConversationSummariesGetResponse**](ConversationSummariesGetResponse)


## GetConversations

> [**ConversationEntityListing**](ConversationEntityListing) GetConversations (string communicationType = null)


Get active conversations for the logged in user

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var communicationType = communicationType_example;  // string | Call or Chat communication filtering (optional) 

            try
            { 
                // Get active conversations for the logged in user
                ConversationEntityListing result = apiInstance.GetConversations(communicationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **communicationType** | **string**| Call or Chat communication filtering | [optional]  |

### Return type

[**ConversationEntityListing**](ConversationEntityListing)


## GetConversationsCall

> [**CallConversation**](CallConversation) GetConversationsCall (string conversationId)


Get call conversation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get call conversation
                CallConversation result = apiInstance.GetConversationsCall(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCall: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**CallConversation**](CallConversation)


## GetConversationsCallParticipantCommunicationWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsCallParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)


Get the wrap-up for this conversation communication. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation communication. 
                AssignedWrapupCode result = apiInstance.GetConversationsCallParticipantCommunicationWrapup(conversationId, participantId, communicationId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsCallParticipantWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsCallParticipantWrapup (string conversationId, string participantId, bool? provisional = null)


Get the wrap-up for this conversation participant. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsCallParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsCallParticipantWrapupcodes

> [**List&lt;WrapupCode&gt;**](WrapupCode) GetConversationsCallParticipantWrapupcodes (string conversationId, string participantId)


Get list of wrapup codes for this conversation participant

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List<WrapupCode> result = apiInstance.GetConversationsCallParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

[**List<WrapupCode>**](WrapupCode)


## GetConversationsCallback

> [**CallbackConversation**](CallbackConversation) GetConversationsCallback (string conversationId)


Get callback conversation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get callback conversation
                CallbackConversation result = apiInstance.GetConversationsCallback(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**CallbackConversation**](CallbackConversation)


## GetConversationsCallbackParticipantCommunicationWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsCallbackParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)


Get the wrap-up for this conversation communication. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation communication. 
                AssignedWrapupCode result = apiInstance.GetConversationsCallbackParticipantCommunicationWrapup(conversationId, participantId, communicationId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbackParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsCallbackParticipantWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsCallbackParticipantWrapup (string conversationId, string participantId, bool? provisional = null)


Get the wrap-up for this conversation participant. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsCallbackParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbackParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsCallbackParticipantWrapupcodes

> [**List&lt;WrapupCode&gt;**](WrapupCode) GetConversationsCallbackParticipantWrapupcodes (string conversationId, string participantId)


Get list of wrapup codes for this conversation participant

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List<WrapupCode> result = apiInstance.GetConversationsCallbackParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbackParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

[**List<WrapupCode>**](WrapupCode)


## GetConversationsCallbacks

> [**CallbackConversationEntityListing**](CallbackConversationEntityListing) GetConversationsCallbacks ()


Get active callback conversations for the logged in user

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbacksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active callback conversations for the logged in user
                CallbackConversationEntityListing result = apiInstance.GetConversationsCallbacks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbacks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**CallbackConversationEntityListing**](CallbackConversationEntityListing)


## GetConversationsCalls

> [**CallConversationEntityListing**](CallConversationEntityListing) GetConversationsCalls ()


Get active call conversations for the logged in user

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active call conversations for the logged in user
                CallConversationEntityListing result = apiInstance.GetConversationsCalls();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCalls: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**CallConversationEntityListing**](CallConversationEntityListing)


## GetConversationsCallsHistory

> [**CallHistoryConversationEntityListing**](CallHistoryConversationEntityListing) GetConversationsCallsHistory (int? pageSize = null, int? pageNumber = null, string interval = null, List<string> expand = null)


Get call history

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallsHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size, maximum 50 (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var interval = interval_example;  // string | Interval string; format is ISO-8601. Separate start and end times with forward slash '/' (optional) 
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get call history
                CallHistoryConversationEntityListing result = apiInstance.GetConversationsCallsHistory(pageSize, pageNumber, interval, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallsHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size, maximum 50 | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **interval** | **string**| Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; | [optional]  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: externalorganization, externalcontact, user, queue, group |

### Return type

[**CallHistoryConversationEntityListing**](CallHistoryConversationEntityListing)


## GetConversationsCallsMaximumconferenceparties

> [**MaxParticipants**](MaxParticipants) GetConversationsCallsMaximumconferenceparties ()


Get the maximum number of participants that this user can have on a conference

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallsMaximumconferencepartiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get the maximum number of participants that this user can have on a conference
                MaxParticipants result = apiInstance.GetConversationsCallsMaximumconferenceparties();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallsMaximumconferenceparties: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**MaxParticipants**](MaxParticipants)


## GetConversationsChat

> [**ChatConversation**](ChatConversation) GetConversationsChat (string conversationId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get chat conversation

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get chat conversation
                ChatConversation result = apiInstance.GetConversationsChat(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChat: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**ChatConversation**](ChatConversation)


## GetConversationsChatMessage

> [**WebChatMessage**](WebChatMessage) GetConversationsChatMessage (string conversationId, string messageId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get a web chat conversation message

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/. The current user must be involved with the conversation to get its messages.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Get a web chat conversation message
                WebChatMessage result = apiInstance.GetConversationsChatMessage(conversationId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **messageId** | **string**| messageId |  |

### Return type

[**WebChatMessage**](WebChatMessage)


## GetConversationsChatMessages

> [**WebChatMessageEntityList**](WebChatMessageEntityList) GetConversationsChatMessages (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the messages of a chat conversation.

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/. The current user must be involved with the conversation to get its messages.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var after = after_example;  // string | If specified, get the messages chronologically after the id of this message (optional) 
            var before = before_example;  // string | If specified, get the messages chronologically before the id of this message (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            var maxResults = 56;  // int? | Limit the returned number of messages, up to a maximum of 100 (optional)  (default to 100)

            try
            { 
                // Get the messages of a chat conversation.
                WebChatMessageEntityList result = apiInstance.GetConversationsChatMessages(conversationId, after, before, sortOrder, maxResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **after** | **string**| If specified, get the messages chronologically after the id of this message | [optional]  |
| **before** | **string**| If specified, get the messages chronologically before the id of this message | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **maxResults** | **int?**| Limit the returned number of messages, up to a maximum of 100 | [optional] [default to 100] |

### Return type

[**WebChatMessageEntityList**](WebChatMessageEntityList)


## GetConversationsChatParticipantCommunicationWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsChatParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the wrap-up for this conversation communication. 

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation communication. 
                AssignedWrapupCode result = apiInstance.GetConversationsChatParticipantCommunicationWrapup(conversationId, participantId, communicationId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsChatParticipantWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsChatParticipantWrapup (string conversationId, string participantId, bool? provisional = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the wrap-up for this conversation participant. 

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsChatParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsChatParticipantWrapupcodes

> [**List&lt;WrapupCode&gt;**](WrapupCode) GetConversationsChatParticipantWrapupcodes (string conversationId, string participantId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get list of wrapup codes for this conversation participant

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List<WrapupCode> result = apiInstance.GetConversationsChatParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

[**List<WrapupCode>**](WrapupCode)


## GetConversationsChats

> [**ChatConversationEntityListing**](ChatConversationEntityListing) GetConversationsChats ()

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get active chat conversations for the logged in user

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active chat conversations for the logged in user
                ChatConversationEntityListing result = apiInstance.GetConversationsChats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChats: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ChatConversationEntityListing**](ChatConversationEntityListing)


## GetConversationsCobrowsesession

> [**CobrowseConversation**](CobrowseConversation) GetConversationsCobrowsesession (string conversationId)


Get cobrowse conversation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get cobrowse conversation
                CobrowseConversation result = apiInstance.GetConversationsCobrowsesession(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**CobrowseConversation**](CobrowseConversation)


## GetConversationsCobrowsesessionParticipantCommunicationWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsCobrowsesessionParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the wrap-up for this conversation communication. 

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation communication. 
                AssignedWrapupCode result = apiInstance.GetConversationsCobrowsesessionParticipantCommunicationWrapup(conversationId, participantId, communicationId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessionParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsCobrowsesessionParticipantWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsCobrowsesessionParticipantWrapup (string conversationId, string participantId, bool? provisional = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the wrap-up for this conversation participant. 

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsCobrowsesessionParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessionParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsCobrowsesessionParticipantWrapupcodes

> [**List&lt;WrapupCode&gt;**](WrapupCode) GetConversationsCobrowsesessionParticipantWrapupcodes (string conversationId, string participantId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get list of wrapup codes for this conversation participant

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List<WrapupCode> result = apiInstance.GetConversationsCobrowsesessionParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessionParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

[**List<WrapupCode>**](WrapupCode)


## GetConversationsCobrowsesessions

> [**CobrowseConversationEntityListing**](CobrowseConversationEntityListing) GetConversationsCobrowsesessions ()


Get active cobrowse conversations for the logged in user

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active cobrowse conversations for the logged in user
                CobrowseConversationEntityListing result = apiInstance.GetConversationsCobrowsesessions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**CobrowseConversationEntityListing**](CobrowseConversationEntityListing)


## GetConversationsEmail

> [**EmailConversation**](EmailConversation) GetConversationsEmail (string conversationId)


Get email conversation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get email conversation
                EmailConversation result = apiInstance.GetConversationsEmail(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**EmailConversation**](EmailConversation)


## GetConversationsEmailMessage

> [**EmailMessage**](EmailMessage) GetConversationsEmailMessage (string conversationId, string messageId)


Get conversation message

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Get conversation message
                EmailMessage result = apiInstance.GetConversationsEmailMessage(conversationId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **messageId** | **string**| messageId |  |

### Return type

[**EmailMessage**](EmailMessage)


## GetConversationsEmailMessages

> [**EmailMessagePreviewListing**](EmailMessagePreviewListing) GetConversationsEmailMessages (string conversationId)


Get conversation messages

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get conversation messages
                EmailMessagePreviewListing result = apiInstance.GetConversationsEmailMessages(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**EmailMessagePreviewListing**](EmailMessagePreviewListing)


## GetConversationsEmailMessagesDraft

> [**EmailMessage**](EmailMessage) GetConversationsEmailMessagesDraft (string conversationId)


Get conversation draft reply

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailMessagesDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get conversation draft reply
                EmailMessage result = apiInstance.GetConversationsEmailMessagesDraft(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailMessagesDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**EmailMessage**](EmailMessage)


## GetConversationsEmailParticipantCommunicationWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsEmailParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)


Get the wrap-up for this conversation communication. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation communication. 
                AssignedWrapupCode result = apiInstance.GetConversationsEmailParticipantCommunicationWrapup(conversationId, participantId, communicationId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsEmailParticipantWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsEmailParticipantWrapup (string conversationId, string participantId, bool? provisional = null)


Get the wrap-up for this conversation participant. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsEmailParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsEmailParticipantWrapupcodes

> [**List&lt;WrapupCode&gt;**](WrapupCode) GetConversationsEmailParticipantWrapupcodes (string conversationId, string participantId)


Get list of wrapup codes for this conversation participant

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List<WrapupCode> result = apiInstance.GetConversationsEmailParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

[**List<WrapupCode>**](WrapupCode)


## GetConversationsEmailSettings

> [**EmailsSettings**](EmailsSettings) GetConversationsEmailSettings (string conversationId)


Get emails settings for a given conversation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get emails settings for a given conversation
                EmailsSettings result = apiInstance.GetConversationsEmailSettings(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**EmailsSettings**](EmailsSettings)


## GetConversationsEmails

> [**EmailConversationEntityListing**](EmailConversationEntityListing) GetConversationsEmails ()


Get active email conversations for the logged in user

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active email conversations for the logged in user
                EmailConversationEntityListing result = apiInstance.GetConversationsEmails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EmailConversationEntityListing**](EmailConversationEntityListing)


## GetConversationsInternalmessage

> [**InternalMessageConversation**](InternalMessageConversation) GetConversationsInternalmessage (string conversationId)


Get internal message conversation

GetConversationsInternalmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:internalMessaging:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsInternalmessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get internal message conversation
                InternalMessageConversation result = apiInstance.GetConversationsInternalmessage(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsInternalmessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**InternalMessageConversation**](InternalMessageConversation)


## GetConversationsInternalmessages

> [**InternalMessageConversationEntityListing**](InternalMessageConversationEntityListing) GetConversationsInternalmessages ()


Get active internal message conversations for the logged in user

GetConversationsInternalmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:internalMessaging:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsInternalmessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active internal message conversations for the logged in user
                InternalMessageConversationEntityListing result = apiInstance.GetConversationsInternalmessages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsInternalmessages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**InternalMessageConversationEntityListing**](InternalMessageConversationEntityListing)


## GetConversationsKeyconfiguration

> [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration) GetConversationsKeyconfiguration (string keyconfigurationsId)


Get the encryption key configurations

Requires ANY permissions: 

* conversation:encryptionKey:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsKeyconfigurationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var keyconfigurationsId = keyconfigurationsId_example;  // string | Key Configurations Id

            try
            { 
                // Get the encryption key configurations
                ConversationEncryptionConfiguration result = apiInstance.GetConversationsKeyconfiguration(keyconfigurationsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsKeyconfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **keyconfigurationsId** | **string**| Key Configurations Id |  |

### Return type

[**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration)


## GetConversationsKeyconfigurations

> [**ConversationEncryptionConfigurationListing**](ConversationEncryptionConfigurationListing) GetConversationsKeyconfigurations ()


Get a list of key configurations data

Requires ANY permissions: 

* conversation:encryptionKey:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsKeyconfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get a list of key configurations data
                ConversationEncryptionConfigurationListing result = apiInstance.GetConversationsKeyconfigurations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsKeyconfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ConversationEncryptionConfigurationListing**](ConversationEncryptionConfigurationListing)


## GetConversationsMessage

> [**MessageConversation**](MessageConversation) GetConversationsMessage (string conversationId)


Get message conversation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get message conversation
                MessageConversation result = apiInstance.GetConversationsMessage(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

[**MessageConversation**](MessageConversation)


## GetConversationsMessageCommunicationMessagesMediaMediaId

> [**MessageMediaData**](MessageMediaData) GetConversationsMessageCommunicationMessagesMediaMediaId (string conversationId, string communicationId, string mediaId)


Get media

See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.

Requires ANY permissions: 

* conversation:message:view
* conversation:webmessaging:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageCommunicationMessagesMediaMediaIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var mediaId = mediaId_example;  // string | mediaId

            try
            { 
                // Get media
                MessageMediaData result = apiInstance.GetConversationsMessageCommunicationMessagesMediaMediaId(conversationId, communicationId, mediaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageCommunicationMessagesMediaMediaId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **mediaId** | **string**| mediaId |  |

### Return type

[**MessageMediaData**](MessageMediaData)


## GetConversationsMessageDetails

> [**MessageData**](MessageData) GetConversationsMessageDetails (string messageId, bool? useNormalizedMessage = null)


Get message

Requires ANY permissions: 

* conversation:message:view
* conversation:webmessaging:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var messageId = messageId_example;  // string | messageId
            var useNormalizedMessage = true;  // bool? | If true, response removes deprecated fields (textBody, media) (optional)  (default to false)

            try
            { 
                // Get message
                MessageData result = apiInstance.GetConversationsMessageDetails(messageId, useNormalizedMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| messageId |  |
| **useNormalizedMessage** | **bool?**| If true, response removes deprecated fields (textBody, media) | [optional] [default to false] |

### Return type

[**MessageData**](MessageData)


## GetConversationsMessageMessage

> [**MessageData**](MessageData) GetConversationsMessageMessage (string conversationId, string messageId, bool? useNormalizedMessage = null)


Get conversation message

Requires ANY permissions: 

* conversation:message:view
* conversation:webmessaging:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var messageId = messageId_example;  // string | messageId
            var useNormalizedMessage = true;  // bool? | If true, response removes deprecated fields (textBody, media) (optional)  (default to false)

            try
            { 
                // Get conversation message
                MessageData result = apiInstance.GetConversationsMessageMessage(conversationId, messageId, useNormalizedMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **messageId** | **string**| messageId |  |
| **useNormalizedMessage** | **bool?**| If true, response removes deprecated fields (textBody, media) | [optional] [default to false] |

### Return type

[**MessageData**](MessageData)


## GetConversationsMessageParticipantCommunicationWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsMessageParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)


Get the wrap-up for this conversation communication. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation communication. 
                AssignedWrapupCode result = apiInstance.GetConversationsMessageParticipantCommunicationWrapup(conversationId, participantId, communicationId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsMessageParticipantWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsMessageParticipantWrapup (string conversationId, string participantId, bool? provisional = null)


Get the wrap-up for this conversation participant. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsMessageParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsMessageParticipantWrapupcodes

> [**List&lt;WrapupCode&gt;**](WrapupCode) GetConversationsMessageParticipantWrapupcodes (string conversationId, string participantId)


Get list of wrapup codes for this conversation participant

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List<WrapupCode> result = apiInstance.GetConversationsMessageParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

[**List<WrapupCode>**](WrapupCode)


## GetConversationsMessages

> [**MessageConversationEntityListing**](MessageConversationEntityListing) GetConversationsMessages ()


Get active message conversations for the logged in user

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active message conversations for the logged in user
                MessageConversationEntityListing result = apiInstance.GetConversationsMessages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**MessageConversationEntityListing**](MessageConversationEntityListing)


## GetConversationsMessagesCachedmedia

> [**CachedMediaItemEntityListing**](CachedMediaItemEntityListing) GetConversationsMessagesCachedmedia (int? pageSize = null, int? pageNumber = null, string url = null)


Get a list of cached media items

Requires ANY permissions: 

* conversation:cachedMedia:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagesCachedmediaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var url = url_example;  // string | URL to search for (optional) 

            try
            { 
                // Get a list of cached media items
                CachedMediaItemEntityListing result = apiInstance.GetConversationsMessagesCachedmedia(pageSize, pageNumber, url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagesCachedmedia: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **url** | **string**| URL to search for | [optional]  |

### Return type

[**CachedMediaItemEntityListing**](CachedMediaItemEntityListing)


## GetConversationsMessagesCachedmediaCachedMediaItemId

> [**CachedMediaItem**](CachedMediaItem) GetConversationsMessagesCachedmediaCachedMediaItemId (string cachedMediaItemId)


Get a cached media item

Requires ANY permissions: 

* conversation:cachedMedia:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagesCachedmediaCachedMediaItemIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var cachedMediaItemId = cachedMediaItemId_example;  // string | cachedMediaItemId

            try
            { 
                // Get a cached media item
                CachedMediaItem result = apiInstance.GetConversationsMessagesCachedmediaCachedMediaItemId(cachedMediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagesCachedmediaCachedMediaItemId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **cachedMediaItemId** | **string**| cachedMediaItemId |  |

### Return type

[**CachedMediaItem**](CachedMediaItem)


## GetConversationsMessagingFacebookApp

> [**FacebookAppCredentials**](FacebookAppCredentials) GetConversationsMessagingFacebookApp ()


Get Genesys Facebook App Id

Requires ALL permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingFacebookAppExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get Genesys Facebook App Id
                FacebookAppCredentials result = apiInstance.GetConversationsMessagingFacebookApp();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingFacebookApp: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**FacebookAppCredentials**](FacebookAppCredentials)


## GetConversationsMessagingFacebookPermissions

> [**FacebookPermissionEntityListing**](FacebookPermissionEntityListing) GetConversationsMessagingFacebookPermissions ()


Get a list of Facebook Permissions

Requires ANY permissions: 

* messaging:integration:add
* messaging:integration:edit
* messaging:conversationInstagramIntegration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingFacebookPermissionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get a list of Facebook Permissions
                FacebookPermissionEntityListing result = apiInstance.GetConversationsMessagingFacebookPermissions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingFacebookPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**FacebookPermissionEntityListing**](FacebookPermissionEntityListing)


## GetConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) GetConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId (string integrationId)


Get Apple messaging integration identity resolution settings

Requires ALL permissions: 

* messaging:integration:view
* messaging:identityResolutionApple:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get Apple messaging integration identity resolution settings
                IdentityResolutionConfig result = apiInstance.GetConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## GetConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) GetConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId (string integrationId)


Get Facebook messaging integration identity resolution settings

Requires ALL permissions: 

* messaging:integration:view
* messaging:identityResolutionFacebook:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get Facebook messaging integration identity resolution settings
                IdentityResolutionConfig result = apiInstance.GetConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## GetConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) GetConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId (string integrationId)


Get an Instagram integration identity resolution settings

Requires ALL permissions: 

* messaging:integration:view
* messaging:identityResolutionInstagram:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get an Instagram integration identity resolution settings
                IdentityResolutionConfig result = apiInstance.GetConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## GetConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId

> [**OpenMessagingIdentityResolutionConfig**](OpenMessagingIdentityResolutionConfig) GetConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId (string integrationId)


Get an open messaging integration Identity Resolution settings

Requires ALL permissions: 

* messaging:integration:view
* messaging:identityResolutionOpen:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get an open messaging integration Identity Resolution settings
                OpenMessagingIdentityResolutionConfig result = apiInstance.GetConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

[**OpenMessagingIdentityResolutionConfig**](OpenMessagingIdentityResolutionConfig)


## GetConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) GetConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId (string integrationId)


Get X (Formally Twitter) messaging integration identity resolution settings

Requires ALL permissions: 

* messaging:integration:view
* messaging:identityResolutionX:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration Id

            try
            { 
                // Get X (Formally Twitter) messaging integration identity resolution settings
                IdentityResolutionConfig result = apiInstance.GetConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration Id |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## GetConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) GetConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId (string integrationId)


Get a whatsApp integration Identity Resolution settings

Requires ALL permissions: 

* messaging:integration:view
* messaging:identityResolutionWhatsApp:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get a whatsApp integration Identity Resolution settings
                IdentityResolutionConfig result = apiInstance.GetConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## GetConversationsMessagingIntegrationTwitterOauthSettings

> [**TwitterOAuthSettings**](TwitterOAuthSettings) GetConversationsMessagingIntegrationTwitterOauthSettings (string integrationId)


Get twitter oauth settings to patch an integration

Requires ALL permissions: 

* messaging:XIntegration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationTwitterOauthSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration Id of an existing integration that needs to be patched with new oauth settings

            try
            { 
                // Get twitter oauth settings to patch an integration
                TwitterOAuthSettings result = apiInstance.GetConversationsMessagingIntegrationTwitterOauthSettings(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationTwitterOauthSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration Id of an existing integration that needs to be patched with new oauth settings |  |

### Return type

[**TwitterOAuthSettings**](TwitterOAuthSettings)


## GetConversationsMessagingIntegrations

> [**MessagingIntegrationEntityListing**](MessagingIntegrationEntityListing) GetConversationsMessagingIntegrations (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string supportedContentId = null, string messagingSettingId = null)


Get a list of Integrations

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = new List<string>(); // List<string> | Expand instructions for the return value. (optional) 
            var supportedContentId = supportedContentId_example;  // string | Filter integrations returned based on the supported content ID (optional) 
            var messagingSettingId = messagingSettingId_example;  // string | Filter integrations returned based on the setting ID (optional) 

            try
            { 
                // Get a list of Integrations
                MessagingIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrations(pageSize, pageNumber, expand, supportedContentId, messagingSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | [**List<string>**](string)| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |

### Return type

[**MessagingIntegrationEntityListing**](MessagingIntegrationEntityListing)


## GetConversationsMessagingIntegrationsApple

> [**AppleIntegrationEntityListing**](AppleIntegrationEntityListing) GetConversationsMessagingIntegrationsApple (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)


Get a list of Apple Integrations

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsAppleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 
            var supportedContentId = supportedContentId_example;  // string | Filter integrations returned based on the supported content ID (optional) 
            var messagingSettingId = messagingSettingId_example;  // string | Filter integrations returned based on the setting ID (optional) 

            try
            { 
                // Get a list of Apple Integrations
                AppleIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsApple(pageSize, pageNumber, expand, supportedContentId, messagingSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsApple: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |

### Return type

[**AppleIntegrationEntityListing**](AppleIntegrationEntityListing)


## GetConversationsMessagingIntegrationsAppleIntegrationId

> [**AppleIntegration**](AppleIntegration) GetConversationsMessagingIntegrationsAppleIntegrationId (string integrationId, string expand = null)


Get an Apple messaging integration

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsAppleIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Get an Apple messaging integration
                AppleIntegration result = apiInstance.GetConversationsMessagingIntegrationsAppleIntegrationId(integrationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsAppleIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |

### Return type

[**AppleIntegration**](AppleIntegration)


## GetConversationsMessagingIntegrationsFacebook

> [**FacebookIntegrationEntityListing**](FacebookIntegrationEntityListing) GetConversationsMessagingIntegrationsFacebook (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)


Get a list of Facebook Integrations

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsFacebookExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 
            var supportedContentId = supportedContentId_example;  // string | Filter integrations returned based on the supported content ID (optional) 
            var messagingSettingId = messagingSettingId_example;  // string | Filter integrations returned based on the setting ID (optional) 

            try
            { 
                // Get a list of Facebook Integrations
                FacebookIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsFacebook(pageSize, pageNumber, expand, supportedContentId, messagingSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsFacebook: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |

### Return type

[**FacebookIntegrationEntityListing**](FacebookIntegrationEntityListing)


## GetConversationsMessagingIntegrationsFacebookIntegrationId

> [**FacebookIntegration**](FacebookIntegration) GetConversationsMessagingIntegrationsFacebookIntegrationId (string integrationId, string expand = null)


Get a Facebook messaging integration

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsFacebookIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Get a Facebook messaging integration
                FacebookIntegration result = apiInstance.GetConversationsMessagingIntegrationsFacebookIntegrationId(integrationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsFacebookIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |

### Return type

[**FacebookIntegration**](FacebookIntegration)


## GetConversationsMessagingIntegrationsInstagram

> [**InstagramIntegrationEntityListing**](InstagramIntegrationEntityListing) GetConversationsMessagingIntegrationsInstagram (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)


Get a list of Instagram Integrations

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsInstagramExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 
            var supportedContentId = supportedContentId_example;  // string | Filter integrations returned based on the supported content ID (optional) 
            var messagingSettingId = messagingSettingId_example;  // string | Filter integrations returned based on the setting ID (optional) 

            try
            { 
                // Get a list of Instagram Integrations
                InstagramIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsInstagram(pageSize, pageNumber, expand, supportedContentId, messagingSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsInstagram: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |

### Return type

[**InstagramIntegrationEntityListing**](InstagramIntegrationEntityListing)


## GetConversationsMessagingIntegrationsInstagramIntegrationId

> [**InstagramIntegration**](InstagramIntegration) GetConversationsMessagingIntegrationsInstagramIntegrationId (string integrationId, string expand = null)


Get Instagram messaging integration

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsInstagramIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Get Instagram messaging integration
                InstagramIntegration result = apiInstance.GetConversationsMessagingIntegrationsInstagramIntegrationId(integrationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsInstagramIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |

### Return type

[**InstagramIntegration**](InstagramIntegration)


## GetConversationsMessagingIntegrationsOpen

> [**OpenIntegrationEntityListing**](OpenIntegrationEntityListing) GetConversationsMessagingIntegrationsOpen (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)


Get a list of Open messaging integrations

See https://developer.genesys.cloud/api/digital/openmessaging/ for more information.

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsOpenExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 
            var supportedContentId = supportedContentId_example;  // string | Filter integrations returned based on the supported content ID (optional) 
            var messagingSettingId = messagingSettingId_example;  // string | Filter integrations returned based on the setting ID (optional) 

            try
            { 
                // Get a list of Open messaging integrations
                OpenIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsOpen(pageSize, pageNumber, expand, supportedContentId, messagingSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsOpen: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |

### Return type

[**OpenIntegrationEntityListing**](OpenIntegrationEntityListing)


## GetConversationsMessagingIntegrationsOpenIntegrationId

> [**OpenIntegration**](OpenIntegration) GetConversationsMessagingIntegrationsOpenIntegrationId (string integrationId, string expand = null)


Get an Open messaging integration

See https://developer.genesys.cloud/api/digital/openmessaging/ for more information.

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsOpenIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Get an Open messaging integration
                OpenIntegration result = apiInstance.GetConversationsMessagingIntegrationsOpenIntegrationId(integrationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsOpenIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |

### Return type

[**OpenIntegration**](OpenIntegration)


## GetConversationsMessagingIntegrationsTwitter

> [**TwitterIntegrationEntityListing**](TwitterIntegrationEntityListing) GetConversationsMessagingIntegrationsTwitter (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)


Get a list of Twitter Integrations

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsTwitterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 
            var supportedContentId = supportedContentId_example;  // string | Filter integrations returned based on the supported content ID (optional) 
            var messagingSettingId = messagingSettingId_example;  // string | Filter integrations returned based on the setting ID (optional) 

            try
            { 
                // Get a list of Twitter Integrations
                TwitterIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsTwitter(pageSize, pageNumber, expand, supportedContentId, messagingSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsTwitter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |

### Return type

[**TwitterIntegrationEntityListing**](TwitterIntegrationEntityListing)


## GetConversationsMessagingIntegrationsTwitterIntegrationId

> [**TwitterIntegration**](TwitterIntegration) GetConversationsMessagingIntegrationsTwitterIntegrationId (string integrationId, string expand = null)


Get Twitter messaging integration

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsTwitterIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Get Twitter messaging integration
                TwitterIntegration result = apiInstance.GetConversationsMessagingIntegrationsTwitterIntegrationId(integrationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsTwitterIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |

### Return type

[**TwitterIntegration**](TwitterIntegration)


## GetConversationsMessagingIntegrationsTwitterOauthSettings

> [**TwitterSignupOAuthSettings**](TwitterSignupOAuthSettings) GetConversationsMessagingIntegrationsTwitterOauthSettings ()


Get twitter oauth settings

Requires ALL permissions: 

* messaging:XIntegration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsTwitterOauthSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get twitter oauth settings
                TwitterSignupOAuthSettings result = apiInstance.GetConversationsMessagingIntegrationsTwitterOauthSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsTwitterOauthSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**TwitterSignupOAuthSettings**](TwitterSignupOAuthSettings)


## GetConversationsMessagingIntegrationsWhatsapp

> [**WhatsAppIntegrationEntityListing**](WhatsAppIntegrationEntityListing) GetConversationsMessagingIntegrationsWhatsapp (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)


Get a list of WhatsApp Integrations

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsWhatsappExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 
            var supportedContentId = supportedContentId_example;  // string | Filter integrations returned based on the supported content ID (optional) 
            var messagingSettingId = messagingSettingId_example;  // string | Filter integrations returned based on the setting ID (optional) 

            try
            { 
                // Get a list of WhatsApp Integrations
                WhatsAppIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsWhatsapp(pageSize, pageNumber, expand, supportedContentId, messagingSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsWhatsapp: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |

### Return type

[**WhatsAppIntegrationEntityListing**](WhatsAppIntegrationEntityListing)


## GetConversationsMessagingIntegrationsWhatsappIntegrationId

> [**WhatsAppIntegration**](WhatsAppIntegration) GetConversationsMessagingIntegrationsWhatsappIntegrationId (string integrationId, string expand = null)


Get a WhatsApp messaging integration

Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsWhatsappIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var expand = expand_example;  // string | Expand instructions for the return value. (optional) 

            try
            { 
                // Get a WhatsApp messaging integration
                WhatsAppIntegration result = apiInstance.GetConversationsMessagingIntegrationsWhatsappIntegrationId(integrationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsWhatsappIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting, identityresolution |

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration)


## GetConversationsMessagingOauthAppleCallback

> [**OAuthAppleAuthorizationResponse**](OAuthAppleAuthorizationResponse) GetConversationsMessagingOauthAppleCallback (string code, string state, string error = null)


Call Authentication provider callback to validate state and code

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingOauthAppleCallbackExample
    {
        public void main()
        { 

            var apiInstance = new ConversationsApi();
            var code = code_example;  // string | The authorization code to be sent to the authentication server during the token request.
            var state = state_example;  // string | The state/nonce value generated by Genesys Auth-Client Service.
            var error = error_example;  // string | Error parameter from OAuth provider (optional) 

            try
            { 
                // Call Authentication provider callback to validate state and code
                OAuthAppleAuthorizationResponse result = apiInstance.GetConversationsMessagingOauthAppleCallback(code, state, error);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingOauthAppleCallback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **code** | **string**| The authorization code to be sent to the authentication server during the token request. |  |
| **state** | **string**| The state/nonce value generated by Genesys Auth-Client Service. |  |
| **error** | **string**| Error parameter from OAuth provider | [optional]  |

### Return type

[**OAuthAppleAuthorizationResponse**](OAuthAppleAuthorizationResponse)


## GetConversationsMessagingSetting

> [**MessagingSetting**](MessagingSetting) GetConversationsMessagingSetting (string messageSettingId)


Get a messaging setting

Requires ALL permissions: 

* messaging:setting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var messageSettingId = messageSettingId_example;  // string | Message Setting ID

            try
            { 
                // Get a messaging setting
                MessagingSetting result = apiInstance.GetConversationsMessagingSetting(messageSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageSettingId** | **string**| Message Setting ID |  |

### Return type

[**MessagingSetting**](MessagingSetting)


## GetConversationsMessagingSettings

> [**MessagingConfigListing**](MessagingConfigListing) GetConversationsMessagingSettings (int? pageSize = null, int? pageNumber = null)


Get a list of messaging settings

Requires ALL permissions: 

* messaging:setting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of messaging settings
                MessagingConfigListing result = apiInstance.GetConversationsMessagingSettings(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**MessagingConfigListing**](MessagingConfigListing)


## GetConversationsMessagingSettingsDefault

> [**MessagingSetting**](MessagingSetting) GetConversationsMessagingSettingsDefault ()


Get the organization's default settings that will be used as the default when creating an integration.

When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be assigned to it.

Requires ALL permissions: 

* messaging:setting:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingSettingsDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get the organization's default settings that will be used as the default when creating an integration.
                MessagingSetting result = apiInstance.GetConversationsMessagingSettingsDefault();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingSettingsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**MessagingSetting**](MessagingSetting)


## GetConversationsMessagingSupportedcontent

> [**SupportedContentListing**](SupportedContentListing) GetConversationsMessagingSupportedcontent (int? pageSize = null, int? pageNumber = null)


Get a list of Supported Content profiles

Requires ALL permissions: 

* messaging:supportedContent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingSupportedcontentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Supported Content profiles
                SupportedContentListing result = apiInstance.GetConversationsMessagingSupportedcontent(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingSupportedcontent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**SupportedContentListing**](SupportedContentListing)


## GetConversationsMessagingSupportedcontentDefault

> [**SupportedContent**](SupportedContent) GetConversationsMessagingSupportedcontentDefault ()


Get the organization's default supported content profile that will be used as the default when creating an integration.

When an integration is created a supported content ID may be assigned to it. If the supported content ID is not supplied, the default supported content profile will be assigned to it.

Requires ALL permissions: 

* messaging:supportedContent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingSupportedcontentDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get the organization's default supported content profile that will be used as the default when creating an integration.
                SupportedContent result = apiInstance.GetConversationsMessagingSupportedcontentDefault();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingSupportedcontentDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**SupportedContent**](SupportedContent)


## GetConversationsMessagingSupportedcontentSupportedContentId

> [**SupportedContent**](SupportedContent) GetConversationsMessagingSupportedcontentSupportedContentId (string supportedContentId)


Get a supported content profile

Requires ALL permissions: 

* messaging:supportedContent:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingSupportedcontentSupportedContentIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var supportedContentId = supportedContentId_example;  // string | Supported Content ID

            try
            { 
                // Get a supported content profile
                SupportedContent result = apiInstance.GetConversationsMessagingSupportedcontentSupportedContentId(supportedContentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingSupportedcontentSupportedContentId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **supportedContentId** | **string**| Supported Content ID |  |

### Return type

[**SupportedContent**](SupportedContent)


## GetConversationsMessagingThreadingtimeline

> [**ConversationThreadingWindow**](ConversationThreadingWindow) GetConversationsMessagingThreadingtimeline ()


Get conversation threading window timeline for each messaging type

Conversation messaging threading timeline is a setting defined for each messenger type in your organization. This setting will dictate whether a new message is added to the most recent existing conversation, or creates a new Conversation. If the existing Conversation is still in a connected state the threading timeline setting will never play a role. After the conversation is disconnected, if an inbound message is received or an outbound message is sent after the setting for threading timeline expires, a new conversation is created.

Requires ALL permissions: 

* conversation:threadingTimeline:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingThreadingtimelineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get conversation threading window timeline for each messaging type
                ConversationThreadingWindow result = apiInstance.GetConversationsMessagingThreadingtimeline();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingThreadingtimeline: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ConversationThreadingWindow**](ConversationThreadingWindow)


## GetConversationsScreenshareParticipantCommunicationWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsScreenshareParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get the wrap-up for this conversation communication. 

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsScreenshareParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation communication. 
                AssignedWrapupCode result = apiInstance.GetConversationsScreenshareParticipantCommunicationWrapup(conversationId, participantId, communicationId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsScreenshareParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsSettings

> [**Settings**](Settings) GetConversationsSettings ()


Get Settings

Requires ANY permissions: 

* conversation:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get Settings
                Settings result = apiInstance.GetConversationsSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**Settings**](Settings)


## GetConversationsSocialParticipantCommunicationWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsSocialParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)


Get the wrap-up for this conversation communication. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsSocialParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation communication. 
                AssignedWrapupCode result = apiInstance.GetConversationsSocialParticipantCommunicationWrapup(conversationId, participantId, communicationId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsSocialParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsVideoDetails

> [**VideoConferenceDetails**](VideoConferenceDetails) GetConversationsVideoDetails (string conferenceId)


Get video conference details (e.g. the current number of active participants).

GetConversationsVideoDetails is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* video:video:access

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsVideoDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conferenceId = conferenceId_example;  // string | conferenceId

            try
            { 
                // Get video conference details (e.g. the current number of active participants).
                VideoConferenceDetails result = apiInstance.GetConversationsVideoDetails(conferenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsVideoDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conferenceId** | **string**| conferenceId |  |

### Return type

[**VideoConferenceDetails**](VideoConferenceDetails)


## GetConversationsVideoParticipantCommunicationWrapup

> [**AssignedWrapupCode**](AssignedWrapupCode) GetConversationsVideoParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)


Get the wrap-up for this conversation communication. 

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsVideoParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var provisional = true;  // bool? | Indicates whether or not to fetch provisional wrap-up code. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation communication. 
                AssignedWrapupCode result = apiInstance.GetConversationsVideoParticipantCommunicationWrapup(conversationId, participantId, communicationId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsVideoParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **provisional** | **bool?**| Indicates whether or not to fetch provisional wrap-up code. | [optional] [default to false] |

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode)


## GetConversationsVideosMeeting

> [**MeetingIdRecord**](MeetingIdRecord) GetConversationsVideosMeeting (string meetingId)


Gets a record for a given meetingId

GetConversationsVideosMeeting is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* video:video:access

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsVideosMeetingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var meetingId = meetingId_example;  // string | meetingId

            try
            { 
                // Gets a record for a given meetingId
                MeetingIdRecord result = apiInstance.GetConversationsVideosMeeting(meetingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsVideosMeeting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **meetingId** | **string**| meetingId |  |

### Return type

[**MeetingIdRecord**](MeetingIdRecord)


## PatchConversationParticipant

> void PatchConversationParticipant (string conversationId, string participantId, MediaParticipantRequest body)


Update a participant.

Update conversation participant.

Requires ANY permissions: 

* conversation:participant:wrapup
* conversation:call:record
* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            { 
                // Update a participant.
                apiInstance.PatchConversationParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Update request |  |

### Return type

void (empty response body)


## PatchConversationParticipantAttributes

> void PatchConversationParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)


Update the attributes on a conversation participant.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            { 
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes)| Participant attributes |  |

### Return type

void (empty response body)


## PatchConversationRecordingstate

> void PatchConversationRecordingstate (string conversationId, SetRecordingState body)


Update a conversation by setting its recording state

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                apiInstance.PatchConversationRecordingstate(conversationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

void (empty response body)


## PatchConversationSecureattributes

> **string** PatchConversationSecureattributes (string conversationId, ConversationSecureAttributes body)


Update the secure attributes on a conversation.

Requires ANY permissions: 

* conversation:participant:attributesedit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationSecureattributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new ConversationSecureAttributes(); // ConversationSecureAttributes | Conversation Secure Attributes

            try
            { 
                // Update the secure attributes on a conversation.
                string result = apiInstance.PatchConversationSecureattributes(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationSecureattributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**ConversationSecureAttributes**](ConversationSecureAttributes)| Conversation Secure Attributes |  |

### Return type

**string**


## PatchConversationSummaryEngagements

> void PatchConversationSummaryEngagements (string conversationId, string summaryId, EngagementRequest body = null)


Update agent's engagement for the summary.

Requires ALL permissions: 

* conversation:summaryEngagement:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationSummaryEngagementsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var summaryId = summaryId_example;  // string | Summary ID
            var body = new EngagementRequest(); // EngagementRequest |  (optional) 

            try
            { 
                // Update agent's engagement for the summary.
                apiInstance.PatchConversationSummaryEngagements(conversationId, summaryId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationSummaryEngagements: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **summaryId** | **string**| Summary ID |  |
| **body** | [**EngagementRequest**](EngagementRequest)|  | [optional]  |

### Return type

void (empty response body)


## PatchConversationSummaryFeedback

> void PatchConversationSummaryFeedback (string conversationId, string summaryId, FeedbackUpdateRequest body = null)


Update the feedback for the summary.

Requires ALL permissions: 

* conversation:summaryFeedback:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationSummaryFeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var summaryId = summaryId_example;  // string | Summary ID
            var body = new FeedbackUpdateRequest(); // FeedbackUpdateRequest |  (optional) 

            try
            { 
                // Update the feedback for the summary.
                apiInstance.PatchConversationSummaryFeedback(conversationId, summaryId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationSummaryFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **summaryId** | **string**| Summary ID |  |
| **body** | [**FeedbackUpdateRequest**](FeedbackUpdateRequest)|  | [optional]  |

### Return type

void (empty response body)


## PatchConversationUtilizationlabel

> **string** PatchConversationUtilizationlabel (string conversationId, ConversationUtilizationLabelUpdate body)


Update the utilization label on a conversation. When there is no value provided, the system default label is applied

Requires ANY permissions: 

* conversation:utilizationLabel:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationUtilizationlabelExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new ConversationUtilizationLabelUpdate(); // ConversationUtilizationLabelUpdate | Conversation Utilization Label

            try
            { 
                // Update the utilization label on a conversation. When there is no value provided, the system default label is applied
                string result = apiInstance.PatchConversationUtilizationlabel(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationUtilizationlabel: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**ConversationUtilizationLabelUpdate**](ConversationUtilizationLabelUpdate)| Conversation Utilization Label |  |

### Return type

**string**


## PatchConversationsAftercallworkConversationIdParticipantCommunication

> [**AfterCallWorkUpdate**](AfterCallWorkUpdate) PatchConversationsAftercallworkConversationIdParticipantCommunication (string conversationId, string participantId, string communicationId, AfterCallWorkUpdate body)


Update after-call work for this conversation communication.

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsAftercallworkConversationIdParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new AfterCallWorkUpdate(); // AfterCallWorkUpdate | AfterCallWorkUpdate

            try
            { 
                // Update after-call work for this conversation communication.
                AfterCallWorkUpdate result = apiInstance.PatchConversationsAftercallworkConversationIdParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsAftercallworkConversationIdParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**AfterCallWorkUpdate**](AfterCallWorkUpdate)| AfterCallWorkUpdate |  |

### Return type

[**AfterCallWorkUpdate**](AfterCallWorkUpdate)


## PatchConversationsCall

> [**Conversation**](Conversation) PatchConversationsCall (string conversationId, Conversation body)


Update a conversation by setting its recording state, merging in other conversations to create a conference, or disconnecting all of the participants

Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by setting its recording state, merging in other conversations to create a conference, or disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsCall(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCall: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation)| Conversation |  |

### Return type

[**Conversation**](Conversation)


## PatchConversationsCallConference

> void PatchConversationsCallConference (string conversationId, UpdateConferenceRequest body)


Update a conversation by merging in other conversations to create a conference

Requires ANY permissions: 

* conversation:conference:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallConferenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new UpdateConferenceRequest(); // UpdateConferenceRequest | UpdateConferenceRequest

            try
            { 
                // Update a conversation by merging in other conversations to create a conference
                apiInstance.PatchConversationsCallConference(conversationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallConference: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**UpdateConferenceRequest**](UpdateConferenceRequest)| UpdateConferenceRequest |  |

### Return type

void (empty response body)


## PatchConversationsCallParticipant

> void PatchConversationsCallParticipant (string conversationId, string participantId, MediaParticipantRequest body)


Update conversation participant

Requires ANY permissions: 

* conversation:participant:wrapup
* conversation:call:record
* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant request

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsCallParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Participant request |  |

### Return type

void (empty response body)


## PatchConversationsCallParticipantAttributes

> [**ParticipantAttributes**](ParticipantAttributes) PatchConversationsCallParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)


Update the attributes on a conversation participant.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            { 
                // Update the attributes on a conversation participant.
                ParticipantAttributes result = apiInstance.PatchConversationsCallParticipantAttributes(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes)| Participant attributes |  |

### Return type

[**ParticipantAttributes**](ParticipantAttributes)


## PatchConversationsCallParticipantCommunication

> **Object** PatchConversationsCallParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)


Update conversation participant's communication by disconnecting it. This endpoint does not update wrapup.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it. This endpoint does not update wrapup.
                Object result = apiInstance.PatchConversationsCallParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Participant |  |

### Return type

**Object**


## PatchConversationsCallParticipantConsult

> [**ConsultTransferResponse**](ConsultTransferResponse) PatchConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransferUpdate body)


Change who can speak

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantConsultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransferUpdate(); // ConsultTransferUpdate | new speak to

            try
            { 
                // Change who can speak
                ConsultTransferResponse result = apiInstance.PatchConversationsCallParticipantConsult(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipantConsult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransferUpdate**](ConsultTransferUpdate)| new speak to |  |

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse)


## PatchConversationsCallback

> [**Conversation**](Conversation) PatchConversationsCallback (string conversationId, Conversation body)


Update a conversation by disconnecting all of the participants

Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsCallback(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation)| Conversation |  |

### Return type

[**Conversation**](Conversation)


## PatchConversationsCallbackParticipant

> void PatchConversationsCallbackParticipant (string conversationId, string participantId, MediaParticipantRequest body)


Update conversation participant

Requires ANY permissions: 

* conversation:participant:wrapup
* conversation:call:record
* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsCallbackParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbackParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Participant |  |

### Return type

void (empty response body)


## PatchConversationsCallbackParticipantAttributes

> [**ParticipantAttributes**](ParticipantAttributes) PatchConversationsCallbackParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)


Update the attributes on a conversation participant.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Attributes

            try
            { 
                // Update the attributes on a conversation participant.
                ParticipantAttributes result = apiInstance.PatchConversationsCallbackParticipantAttributes(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbackParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes)| Attributes |  |

### Return type

[**ParticipantAttributes**](ParticipantAttributes)


## PatchConversationsCallbackParticipantCommunication

> **Object** PatchConversationsCallbackParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)


Update conversation participant's communication by disconnecting it.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it.
                Object result = apiInstance.PatchConversationsCallbackParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbackParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Participant |  |

### Return type

**Object**


## PatchConversationsCallbacks

> [**PatchCallbackResponse**](PatchCallbackResponse) PatchConversationsCallbacks (PatchCallbackRequest body)


Update a scheduled callback

Requires ANY permissions: 

* conversation:callback:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbacksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new PatchCallbackRequest(); // PatchCallbackRequest | PatchCallbackRequest

            try
            { 
                // Update a scheduled callback
                PatchCallbackResponse result = apiInstance.PatchConversationsCallbacks(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbacks: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PatchCallbackRequest**](PatchCallbackRequest)| PatchCallbackRequest |  |

### Return type

[**PatchCallbackResponse**](PatchCallbackResponse)


## PatchConversationsChat

> [**Conversation**](Conversation) PatchConversationsChat (string conversationId, Conversation body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update a conversation by disconnecting all of the participants

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsChat(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChat: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation)| Conversation |  |

### Return type

[**Conversation**](Conversation)


## PatchConversationsChatParticipant

> void PatchConversationsChatParticipant (string conversationId, string participantId, MediaParticipantRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update conversation participant

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires ANY permissions: 

* conversation:participant:wrapup
* conversation:call:record
* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsChatParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChatParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Update request |  |

### Return type

void (empty response body)


## PatchConversationsChatParticipantAttributes

> [**ParticipantAttributes**](ParticipantAttributes) PatchConversationsChatParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update the attributes on a conversation participant.

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            { 
                // Update the attributes on a conversation participant.
                ParticipantAttributes result = apiInstance.PatchConversationsChatParticipantAttributes(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChatParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes)| Participant attributes |  |

### Return type

[**ParticipantAttributes**](ParticipantAttributes)


## PatchConversationsChatParticipantCommunication

> **Object** PatchConversationsChatParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update conversation participant's communication by disconnecting it. This endpoint does not update wrapup.

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it. This endpoint does not update wrapup.
                Object result = apiInstance.PatchConversationsChatParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChatParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Participant |  |

### Return type

**Object**


## PatchConversationsCobrowsesession

> [**Conversation**](Conversation) PatchConversationsCobrowsesession (string conversationId, Conversation body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update a conversation by disconnecting all of the participants

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsCobrowsesession(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation)| Conversation |  |

### Return type

[**Conversation**](Conversation)


## PatchConversationsCobrowsesessionParticipant

> void PatchConversationsCobrowsesessionParticipant (string conversationId, string participantId, MediaParticipantRequest body = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update conversation participant

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires ANY permissions: 

* conversation:participant:wrapup
* conversation:call:record
* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsCobrowsesessionParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesessionParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)|  | [optional]  |

### Return type

void (empty response body)


## PatchConversationsCobrowsesessionParticipantAttributes

> [**ParticipantAttributes**](ParticipantAttributes) PatchConversationsCobrowsesessionParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update the attributes on a conversation participant.

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            { 
                // Update the attributes on a conversation participant.
                ParticipantAttributes result = apiInstance.PatchConversationsCobrowsesessionParticipantAttributes(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesessionParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes)|  | [optional]  |

### Return type

[**ParticipantAttributes**](ParticipantAttributes)


## PatchConversationsCobrowsesessionParticipantCommunication

> **Object** PatchConversationsCobrowsesessionParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update conversation participant's communication by disconnecting it.

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it.
                Object result = apiInstance.PatchConversationsCobrowsesessionParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesessionParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Participant |  |

### Return type

**Object**


## PatchConversationsEmail

> [**Conversation**](Conversation) PatchConversationsEmail (string conversationId, Conversation body)


Update a conversation by disconnecting all of the participants

Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsEmail(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation)| Conversation |  |

### Return type

[**Conversation**](Conversation)


## PatchConversationsEmailMessagesDraft

> [**EmailMessage**](EmailMessage) PatchConversationsEmailMessagesDraft (string conversationId, bool? autoFill = null, bool? discard = null, DraftManipulationRequest body = null)


Reset conversation draft to its initial state and/or auto-fill draft content

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailMessagesDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var autoFill = true;  // bool? | autoFill (optional) 
            var discard = true;  // bool? | discard (optional) 
            var body = new DraftManipulationRequest(); // DraftManipulationRequest | Draft Manipulation Request (optional) 

            try
            { 
                // Reset conversation draft to its initial state and/or auto-fill draft content
                EmailMessage result = apiInstance.PatchConversationsEmailMessagesDraft(conversationId, autoFill, discard, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailMessagesDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **autoFill** | **bool?**| autoFill | [optional]  |
| **discard** | **bool?**| discard | [optional]  |
| **body** | [**DraftManipulationRequest**](DraftManipulationRequest)| Draft Manipulation Request | [optional]  |

### Return type

[**EmailMessage**](EmailMessage)


## PatchConversationsEmailParticipant

> void PatchConversationsEmailParticipant (string conversationId, string participantId, MediaParticipantRequest body)


Update conversation participant

Requires ANY permissions: 

* conversation:participant:wrapup
* conversation:call:record
* conversation:communication:disconnect
* conversation:email:park

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsEmailParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Update request |  |

### Return type

void (empty response body)


## PatchConversationsEmailParticipantAttributes

> [**ParticipantAttributes**](ParticipantAttributes) PatchConversationsEmailParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)


Update the attributes on a conversation participant.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            { 
                // Update the attributes on a conversation participant.
                ParticipantAttributes result = apiInstance.PatchConversationsEmailParticipantAttributes(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes)| Participant attributes |  |

### Return type

[**ParticipantAttributes**](ParticipantAttributes)


## PatchConversationsEmailParticipantCommunication

> **Object** PatchConversationsEmailParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)


Update conversation participant's communication by disconnecting it. This endpoint does not update wrapup.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it. This endpoint does not update wrapup.
                Object result = apiInstance.PatchConversationsEmailParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Participant |  |

### Return type

**Object**


## PatchConversationsEmailParticipantParkingstate

> void PatchConversationsEmailParticipantParkingstate (string conversationId, string participantId, ParkingStateRequest body)


Update conversation by setting its parking state

Requires ANY permissions: 

* conversation:email:park

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantParkingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParkingStateRequest(); // ParkingStateRequest | Parking update request

            try
            { 
                // Update conversation by setting its parking state
                apiInstance.PatchConversationsEmailParticipantParkingstate(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipantParkingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParkingStateRequest**](ParkingStateRequest)| Parking update request |  |

### Return type

void (empty response body)


## PatchConversationsMessage

> [**Conversation**](Conversation) PatchConversationsMessage (string conversationId, Conversation body)


Update a conversation by disconnecting all of the participants

Requires ANY permissions: 

* conversation:communication:disconnect
* conversation:message:park

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsMessage(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation)| Conversation |  |

### Return type

[**Conversation**](Conversation)


## PatchConversationsMessageParticipant

> void PatchConversationsMessageParticipant (string conversationId, string participantId, MediaParticipantRequest body = null)


Update conversation participant

Requires ANY permissions: 

* conversation:participant:wrapup
* conversation:call:record
* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessageParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsMessageParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessageParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)|  | [optional]  |

### Return type

void (empty response body)


## PatchConversationsMessageParticipantAttributes

> [**ParticipantAttributes**](ParticipantAttributes) PatchConversationsMessageParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body = null)


Update the attributes on a conversation participant.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessageParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            { 
                // Update the attributes on a conversation participant.
                ParticipantAttributes result = apiInstance.PatchConversationsMessageParticipantAttributes(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessageParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes)|  | [optional]  |

### Return type

[**ParticipantAttributes**](ParticipantAttributes)


## PatchConversationsMessageParticipantCommunication

> **Object** PatchConversationsMessageParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)


Update conversation participant's communication by disconnecting it. This endpoint does not update wrapup.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessageParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it. This endpoint does not update wrapup.
                Object result = apiInstance.PatchConversationsMessageParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessageParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest)| Participant |  |

### Return type

**Object**


## PatchConversationsMessagingIntegrationsAppleIntegrationId

> [**AppleIntegration**](AppleIntegration) PatchConversationsMessagingIntegrationsAppleIntegrationId (string integrationId, AppleIntegrationUpdateRequest body)


Update an Apple messaging integration

Requires ALL permissions: 

* messaging:appleIntegration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingIntegrationsAppleIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new AppleIntegrationUpdateRequest(); // AppleIntegrationUpdateRequest | AppleIntegrationUpdateRequest

            try
            { 
                // Update an Apple messaging integration
                AppleIntegration result = apiInstance.PatchConversationsMessagingIntegrationsAppleIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingIntegrationsAppleIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**AppleIntegrationUpdateRequest**](AppleIntegrationUpdateRequest)| AppleIntegrationUpdateRequest |  |

### Return type

[**AppleIntegration**](AppleIntegration)


## PatchConversationsMessagingIntegrationsFacebookIntegrationId

> [**FacebookIntegration**](FacebookIntegration) PatchConversationsMessagingIntegrationsFacebookIntegrationId (string integrationId, FacebookIntegrationUpdateRequest body)


Update Facebook messaging integration

Requires ALL permissions: 

* messaging:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingIntegrationsFacebookIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new FacebookIntegrationUpdateRequest(); // FacebookIntegrationUpdateRequest | FacebookIntegrationUpdateRequest

            try
            { 
                // Update Facebook messaging integration
                FacebookIntegration result = apiInstance.PatchConversationsMessagingIntegrationsFacebookIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingIntegrationsFacebookIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**FacebookIntegrationUpdateRequest**](FacebookIntegrationUpdateRequest)| FacebookIntegrationUpdateRequest |  |

### Return type

[**FacebookIntegration**](FacebookIntegration)


## PatchConversationsMessagingIntegrationsInstagramIntegrationId

> [**InstagramIntegration**](InstagramIntegration) PatchConversationsMessagingIntegrationsInstagramIntegrationId (string integrationId, InstagramIntegrationUpdateRequest body)


Update Instagram messaging integration

Requires ALL permissions: 

* messaging:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingIntegrationsInstagramIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new InstagramIntegrationUpdateRequest(); // InstagramIntegrationUpdateRequest | InstagramIntegrationUpdateRequest

            try
            { 
                // Update Instagram messaging integration
                InstagramIntegration result = apiInstance.PatchConversationsMessagingIntegrationsInstagramIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingIntegrationsInstagramIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**InstagramIntegrationUpdateRequest**](InstagramIntegrationUpdateRequest)| InstagramIntegrationUpdateRequest |  |

### Return type

[**InstagramIntegration**](InstagramIntegration)


## PatchConversationsMessagingIntegrationsOpenIntegrationId

> [**OpenIntegration**](OpenIntegration) PatchConversationsMessagingIntegrationsOpenIntegrationId (string integrationId, OpenIntegrationUpdateRequest body)


Update an Open messaging integration

See https://developer.genesys.cloud/api/digital/openmessaging/ for more information.

Requires ALL permissions: 

* messaging:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingIntegrationsOpenIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new OpenIntegrationUpdateRequest(); // OpenIntegrationUpdateRequest | OpenIntegrationUpdateRequest

            try
            { 
                // Update an Open messaging integration
                OpenIntegration result = apiInstance.PatchConversationsMessagingIntegrationsOpenIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingIntegrationsOpenIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**OpenIntegrationUpdateRequest**](OpenIntegrationUpdateRequest)| OpenIntegrationUpdateRequest |  |

### Return type

[**OpenIntegration**](OpenIntegration)


## PatchConversationsMessagingIntegrationsTwitterIntegrationId

> [**TwitterIntegration**](TwitterIntegration) PatchConversationsMessagingIntegrationsTwitterIntegrationId (string integrationId, TwitterIntegrationUpdateRequest body)


Update a Twitter messaging integration

Requires ALL permissions: 

* messaging:XIntegration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingIntegrationsTwitterIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new TwitterIntegrationUpdateRequest(); // TwitterIntegrationUpdateRequest | TwitterIntegrationUpdateRequest

            try
            { 
                // Update a Twitter messaging integration
                TwitterIntegration result = apiInstance.PatchConversationsMessagingIntegrationsTwitterIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingIntegrationsTwitterIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**TwitterIntegrationUpdateRequest**](TwitterIntegrationUpdateRequest)| TwitterIntegrationUpdateRequest |  |

### Return type

[**TwitterIntegration**](TwitterIntegration)


## PatchConversationsMessagingIntegrationsWhatsappEmbeddedsignupIntegrationId

> [**WhatsAppIntegration**](WhatsAppIntegration) PatchConversationsMessagingIntegrationsWhatsappEmbeddedsignupIntegrationId (string integrationId, WhatsAppEmbeddedSignupIntegrationActivationRequest body)


Activate a WhatsApp messaging integration created using the WhatsApp embedded signup flow

Please specify the phone number to associate with this WhatsApp integration from the list of available phone numbers returned to you in the GET call on the integration with a createStatus of Completed. You can then run a GET on the integration to check if its status has been updated to Active.

Requires ALL permissions: 

* messaging:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingIntegrationsWhatsappEmbeddedsignupIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new WhatsAppEmbeddedSignupIntegrationActivationRequest(); // WhatsAppEmbeddedSignupIntegrationActivationRequest | WhatsAppEmbeddedSignupIntegrationActivationRequest

            try
            { 
                // Activate a WhatsApp messaging integration created using the WhatsApp embedded signup flow
                WhatsAppIntegration result = apiInstance.PatchConversationsMessagingIntegrationsWhatsappEmbeddedsignupIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingIntegrationsWhatsappEmbeddedsignupIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**WhatsAppEmbeddedSignupIntegrationActivationRequest**](WhatsAppEmbeddedSignupIntegrationActivationRequest)| WhatsAppEmbeddedSignupIntegrationActivationRequest |  |

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration)


## PatchConversationsMessagingIntegrationsWhatsappIntegrationId

> [**WhatsAppIntegration**](WhatsAppIntegration) PatchConversationsMessagingIntegrationsWhatsappIntegrationId (string integrationId, WhatsAppIntegrationUpdateRequest body)


Update a WhatsApp messaging integration

Requires ALL permissions: 

* messaging:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingIntegrationsWhatsappIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new WhatsAppIntegrationUpdateRequest(); // WhatsAppIntegrationUpdateRequest | WhatsAppIntegrationUpdateRequest

            try
            { 
                // Update a WhatsApp messaging integration
                WhatsAppIntegration result = apiInstance.PatchConversationsMessagingIntegrationsWhatsappIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingIntegrationsWhatsappIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**WhatsAppIntegrationUpdateRequest**](WhatsAppIntegrationUpdateRequest)| WhatsAppIntegrationUpdateRequest |  |

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration)


## PatchConversationsMessagingSetting

> [**MessagingSetting**](MessagingSetting) PatchConversationsMessagingSetting (string messageSettingId, MessagingSettingPatchRequest body)


Update a messaging setting

Requires ALL permissions: 

* messaging:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var messageSettingId = messageSettingId_example;  // string | Message Setting ID
            var body = new MessagingSettingPatchRequest(); // MessagingSettingPatchRequest | MessagingSetting

            try
            { 
                // Update a messaging setting
                MessagingSetting result = apiInstance.PatchConversationsMessagingSetting(messageSettingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageSettingId** | **string**| Message Setting ID |  |
| **body** | [**MessagingSettingPatchRequest**](MessagingSettingPatchRequest)| MessagingSetting |  |

### Return type

[**MessagingSetting**](MessagingSetting)


## PatchConversationsMessagingSupportedcontentSupportedContentId

> [**SupportedContent**](SupportedContent) PatchConversationsMessagingSupportedcontentSupportedContentId (string supportedContentId, SupportedContent body)


Update a supported content profile

Requires ALL permissions: 

* messaging:supportedContent:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingSupportedcontentSupportedContentIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var supportedContentId = supportedContentId_example;  // string | Supported Content ID
            var body = new SupportedContent(); // SupportedContent | SupportedContent

            try
            { 
                // Update a supported content profile
                SupportedContent result = apiInstance.PatchConversationsMessagingSupportedcontentSupportedContentId(supportedContentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingSupportedcontentSupportedContentId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **supportedContentId** | **string**| Supported Content ID |  |
| **body** | [**SupportedContent**](SupportedContent)| SupportedContent |  |

### Return type

[**SupportedContent**](SupportedContent)


## PatchConversationsSettings

> void PatchConversationsSettings (Settings body)


Update Settings

Requires ANY permissions: 

* conversation:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new Settings(); // Settings | Settings

            try
            { 
                // Update Settings
                apiInstance.PatchConversationsSettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Settings**](Settings)| Settings |  |

### Return type

void (empty response body)


## PostAnalyticsConversationDetailsProperties

> [**PropertyIndexRequest**](PropertyIndexRequest) PostAnalyticsConversationDetailsProperties (string conversationId, PropertyIndexRequest body)


Index conversation properties

Requires ANY permissions: 

* analytics:conversationProperties:index

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationDetailsPropertiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new PropertyIndexRequest(); // PropertyIndexRequest | request

            try
            { 
                // Index conversation properties
                PropertyIndexRequest result = apiInstance.PostAnalyticsConversationDetailsProperties(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationDetailsProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest)| request |  |

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest)


## PostAnalyticsConversationsActivityQuery

> [**ConversationActivityResponse**](ConversationActivityResponse) PostAnalyticsConversationsActivityQuery (ConversationActivityQuery body, int? pageSize = null, int? pageNumber = null)


Query for conversation activity observations

Requires ANY permissions: 

* analytics:queueObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsActivityQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new ConversationActivityQuery(); // ConversationActivityQuery | query
            var pageSize = 56;  // int? | The desired page size (optional) 
            var pageNumber = 56;  // int? | The desired page number (optional) 

            try
            { 
                // Query for conversation activity observations
                ConversationActivityResponse result = apiInstance.PostAnalyticsConversationsActivityQuery(body, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsActivityQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationActivityQuery**](ConversationActivityQuery)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |

### Return type

[**ConversationActivityResponse**](ConversationActivityResponse)


## PostAnalyticsConversationsAggregatesJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsConversationsAggregatesJobs (ConversationAsyncAggregationQuery body)


Query for conversation aggregates asynchronously

PostAnalyticsConversationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsAggregatesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new ConversationAsyncAggregationQuery(); // ConversationAsyncAggregationQuery | query

            try
            { 
                // Query for conversation aggregates asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsConversationsAggregatesJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsAggregatesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationAsyncAggregationQuery**](ConversationAsyncAggregationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsConversationsAggregatesQuery

> [**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse) PostAnalyticsConversationsAggregatesQuery (ConversationAggregationQuery body)


Query for conversation aggregates

Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new ConversationAggregationQuery(); // ConversationAggregationQuery | query

            try
            { 
                // Query for conversation aggregates
                ConversationAggregateQueryResponse result = apiInstance.PostAnalyticsConversationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationAggregationQuery**](ConversationAggregationQuery)| query |  |

### Return type

[**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse)


## PostAnalyticsConversationsDetailsJobs

> [**AsyncQueryResponse**](AsyncQueryResponse) PostAnalyticsConversationsDetailsJobs (AsyncConversationQuery body)


Query for conversation details asynchronously

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsDetailsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new AsyncConversationQuery(); // AsyncConversationQuery | query

            try
            { 
                // Query for conversation details asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsConversationsDetailsJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsDetailsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AsyncConversationQuery**](AsyncConversationQuery)| query |  |

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse)


## PostAnalyticsConversationsDetailsQuery

> [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse) PostAnalyticsConversationsDetailsQuery (ConversationQuery body)


Query for conversation details

Requires ANY permissions: 

* analytics:conversationDetail:view
* analytics:agentConversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsDetailsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new ConversationQuery(); // ConversationQuery | query

            try
            { 
                // Query for conversation details
                AnalyticsConversationQueryResponse result = apiInstance.PostAnalyticsConversationsDetailsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsDetailsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationQuery**](ConversationQuery)| query |  |

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse)


## PostConversationAssign

> **string** PostConversationAssign (string conversationId, ConversationUser body)


Attempts to manually assign a specified conversation to a specified user.  Ignores bullseye ring, PAR score, skills, and languages.

Requires ANY permissions: 

* conversation:call:pull
* conversation:call:assign
* conversation:callback:pull
* conversation:callback:assign
* conversation:webchat:pull
* conversation:webchat:assign
* conversation:email:pull
* conversation:email:assign
* conversation:message:pull
* conversation:message:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationAssignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new ConversationUser(); // ConversationUser | Targeted user

            try
            { 
                // Attempts to manually assign a specified conversation to a specified user.  Ignores bullseye ring, PAR score, skills, and languages.
                string result = apiInstance.PostConversationAssign(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationAssign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**ConversationUser**](ConversationUser)| Targeted user |  |

### Return type

**string**


## PostConversationBarge

> void PostConversationBarge (string conversationId)


Barge a conversation creating a barged in conference of connected participants.

Requires ANY permissions: 

* conversation:call:barge

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationBargeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            { 
                // Barge a conversation creating a barged in conference of connected participants.
                apiInstance.PostConversationBarge(conversationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationBarge: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |

### Return type

void (empty response body)


## PostConversationCobrowse

> [**CobrowseWebMessagingSession**](CobrowseWebMessagingSession) PostConversationCobrowse (string conversationId)


Creates a cobrowse session. Requires \"conversation:cobrowse:add\" (for web messaging) or \"conversation:cobrowsevoice:add\" permission.

Requires ANY permissions: 

* conversation:cobrowse:add
* conversation:cobrowseVoice:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationCobrowseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | Conversation ID

            try
            { 
                // Creates a cobrowse session. Requires \"conversation:cobrowse:add\" (for web messaging) or \"conversation:cobrowsevoice:add\" permission.
                CobrowseWebMessagingSession result = apiInstance.PostConversationCobrowse(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationCobrowse: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |

### Return type

[**CobrowseWebMessagingSession**](CobrowseWebMessagingSession)


## PostConversationCommunicationInternalmessages

> [**InternalMessageData**](InternalMessageData) PostConversationCommunicationInternalmessages (string conversationId, string communicationId, InternalMessageRequest body)


Send internal message

Send a new internal message for an existing communication.

PostConversationCommunicationInternalmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:internalMessaging:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationCommunicationInternalmessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new InternalMessageRequest(); // InternalMessageRequest | Message

            try
            { 
                // Send internal message
                InternalMessageData result = apiInstance.PostConversationCommunicationInternalmessages(conversationId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationCommunicationInternalmessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**InternalMessageRequest**](InternalMessageRequest)| Message |  |

### Return type

[**InternalMessageData**](InternalMessageData)


## PostConversationDisconnect

> **string** PostConversationDisconnect (string conversationId)


Performs a full conversation teardown. Issues disconnect requests for any connected media. Applies a system wrap-up code to any participants that are pending wrap-up. This is not intended to be the normal way of ending interactions but is available in the event of problems with the application to allow a resynchronization of state across all components. It is recommended that users submit a support case if they are relying on this endpoint systematically as there is likely something that needs investigation.

Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationDisconnectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            { 
                // Performs a full conversation teardown. Issues disconnect requests for any connected media. Applies a system wrap-up code to any participants that are pending wrap-up. This is not intended to be the normal way of ending interactions but is available in the event of problems with the application to allow a resynchronization of state across all components. It is recommended that users submit a support case if they are relying on this endpoint systematically as there is likely something that needs investigation.
                string result = apiInstance.PostConversationDisconnect(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationDisconnect: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |

### Return type

**string**


## PostConversationParticipantCallbacks

> void PostConversationParticipantCallbacks (string conversationId, string participantId, CreateCallbackOnConversationCommand body = null)


Create a new callback for the specified participant on the conversation.

Requires ALL permissions: 

* conversation:callback:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantCallbacksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new CreateCallbackOnConversationCommand(); // CreateCallbackOnConversationCommand |  (optional) 

            try
            { 
                // Create a new callback for the specified participant on the conversation.
                apiInstance.PostConversationParticipantCallbacks(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantCallbacks: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**CreateCallbackOnConversationCommand**](CreateCallbackOnConversationCommand)|  | [optional]  |

### Return type

void (empty response body)


## PostConversationParticipantDigits

> void PostConversationParticipantDigits (string conversationId, string participantId, Digits body = null)


Sends DTMF to the participant

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantDigitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new Digits(); // Digits | Digits (optional) 

            try
            { 
                // Sends DTMF to the participant
                apiInstance.PostConversationParticipantDigits(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantDigits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**Digits**](Digits)| Digits | [optional]  |

### Return type

void (empty response body)


## PostConversationParticipantInternalmessagesUsersCommunications

> [**MessagingConferResponse**](MessagingConferResponse) PostConversationParticipantInternalmessagesUsersCommunications (string conversationId, string participantId, MessagingConferWithUserRequest body)


Setup internal message communication with user

The target user of the digital consultation must have the `conversation:internalMessaging:accept` permission.

PostConversationParticipantInternalmessagesUsersCommunications is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:internalMessaging:setupWithUser

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantInternalmessagesUsersCommunicationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new MessagingConferWithUserRequest(); // MessagingConferWithUserRequest | Confer request

            try
            { 
                // Setup internal message communication with user
                MessagingConferResponse result = apiInstance.PostConversationParticipantInternalmessagesUsersCommunications(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantInternalmessagesUsersCommunications: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**MessagingConferWithUserRequest**](MessagingConferWithUserRequest)| Confer request |  |

### Return type

[**MessagingConferResponse**](MessagingConferResponse)


## PostConversationParticipantReplace

> void PostConversationParticipantReplace (string conversationId, string participantId, TransferRequest body)


Replace this participant with the specified user and/or address

Requires ANY permissions: 

* conversation:communication:blindTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**TransferRequest**](TransferRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationParticipantReplaceAgent

> void PostConversationParticipantReplaceAgent (string conversationId, string participantId, TransferToAgentRequest body)


Replace this participant with the specified agent

Requires ANY permissions: 

* conversation:communication:blindTransfer
* conversation:communication:blindTransferAgent

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantReplaceAgentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferToAgentRequest(); // TransferToAgentRequest | Transfer request

            try
            { 
                // Replace this participant with the specified agent
                apiInstance.PostConversationParticipantReplaceAgent(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantReplaceAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**TransferToAgentRequest**](TransferToAgentRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationParticipantReplaceContactExternal

> void PostConversationParticipantReplaceContactExternal (string conversationId, string participantId, TransferToExternalContactRequest body)


Replace this participant with the an external contact

PostConversationParticipantReplaceContactExternal is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:communication:blindTransfer
* conversation:communication:blindTransferExternalContact

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantReplaceContactExternalExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferToExternalContactRequest(); // TransferToExternalContactRequest | Transfer request

            try
            { 
                // Replace this participant with the an external contact
                apiInstance.PostConversationParticipantReplaceContactExternal(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantReplaceContactExternal: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**TransferToExternalContactRequest**](TransferToExternalContactRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationParticipantReplaceExternal

> void PostConversationParticipantReplaceExternal (string conversationId, string participantId, TransferToExternalRequest body)


Replace this participant with the an external contact

Requires ANY permissions: 

* conversation:communication:blindTransfer
* conversation:communication:blindTransferExternal

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantReplaceExternalExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferToExternalRequest(); // TransferToExternalRequest | Transfer request

            try
            { 
                // Replace this participant with the an external contact
                apiInstance.PostConversationParticipantReplaceExternal(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantReplaceExternal: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**TransferToExternalRequest**](TransferToExternalRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationParticipantReplaceQueue

> void PostConversationParticipantReplaceQueue (string conversationId, string participantId, TransferToQueueRequest body)


Replace this participant with the specified queue

Requires ANY permissions: 

* conversation:communication:blindTransfer
* conversation:communication:blindTransferQueue

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantReplaceQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferToQueueRequest(); // TransferToQueueRequest | Transfer request

            try
            { 
                // Replace this participant with the specified queue
                apiInstance.PostConversationParticipantReplaceQueue(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantReplaceQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**TransferToQueueRequest**](TransferToQueueRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationParticipantSecureivrsessions

> [**SecureSession**](SecureSession) PostConversationParticipantSecureivrsessions (string conversationId, string participantId, CreateSecureSession body = null)


Create secure IVR session. Only a participant in the conversation can invoke a secure IVR.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantSecureivrsessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new CreateSecureSession(); // CreateSecureSession |  (optional) 

            try
            { 
                // Create secure IVR session. Only a participant in the conversation can invoke a secure IVR.
                SecureSession result = apiInstance.PostConversationParticipantSecureivrsessions(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantSecureivrsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**CreateSecureSession**](CreateSecureSession)|  | [optional]  |

### Return type

[**SecureSession**](SecureSession)


## PostConversationParticipantTransfer

> void PostConversationParticipantTransfer (string conversationId, string participantId, TransferToAddressRequest body)


Replace this participant by another one using the address of the destination.

PostConversationParticipantTransfer is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:communication:blindTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantTransferExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferToAddressRequest(); // TransferToAddressRequest | Transfer request

            try
            { 
                // Replace this participant by another one using the address of the destination.
                apiInstance.PostConversationParticipantTransfer(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantTransfer: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**TransferToAddressRequest**](TransferToAddressRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationSuggestionEngagement

> [**SuggestionEngagement**](SuggestionEngagement) PostConversationSuggestionEngagement (string conversationId, string suggestionId, SuggestionEngagement body)


Save an engagement on the suggestion.

Requires ALL permissions: 

* conversation:suggestionEngagement:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationSuggestionEngagementExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var suggestionId = suggestionId_example;  // string | Suggestion ID
            var body = new SuggestionEngagement(); // SuggestionEngagement | 

            try
            { 
                // Save an engagement on the suggestion.
                SuggestionEngagement result = apiInstance.PostConversationSuggestionEngagement(conversationId, suggestionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationSuggestionEngagement: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **suggestionId** | **string**| Suggestion ID |  |
| **body** | [**SuggestionEngagement**](SuggestionEngagement)|  |  |

### Return type

[**SuggestionEngagement**](SuggestionEngagement)


## PostConversationSuggestionsFeedback

> void PostConversationSuggestionsFeedback (string conversationId, Feedback body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Suggestion feedback.

Google Agent Assist offering within Genesys will no longer be supported

Requires ANY permissions: 

* conversation:suggestionFeedback:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationSuggestionsFeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var body = new Feedback(); // Feedback | SuggestionFeedback

            try
            { 
                // Suggestion feedback.
                apiInstance.PostConversationSuggestionsFeedback(conversationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationSuggestionsFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **body** | [**Feedback**](Feedback)| SuggestionFeedback |  |

### Return type

void (empty response body)


## PostConversationSummaryFeedback

> void PostConversationSummaryFeedback (string conversationId, string summaryId, FeedbackAddRequest body = null)


Submit feedback for the summary.

Requires ALL permissions: 

* conversation:summaryFeedback:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationSummaryFeedbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var summaryId = summaryId_example;  // string | Summary ID
            var body = new FeedbackAddRequest(); // FeedbackAddRequest |  (optional) 

            try
            { 
                // Submit feedback for the summary.
                apiInstance.PostConversationSummaryFeedback(conversationId, summaryId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationSummaryFeedback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **summaryId** | **string**| Summary ID |  |
| **body** | [**FeedbackAddRequest**](FeedbackAddRequest)|  | [optional]  |

### Return type

void (empty response body)


## PostConversationsCall

> [**Conversation**](Conversation) PostConversationsCall (string conversationId, CallCommand body)


Place a new call as part of a callback conversation.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new CallCommand(); // CallCommand | Conversation

            try
            { 
                // Place a new call as part of a callback conversation.
                Conversation result = apiInstance.PostConversationsCall(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCall: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**CallCommand**](CallCommand)| Conversation |  |

### Return type

[**Conversation**](Conversation)


## PostConversationsCallParticipantBarge

> void PostConversationsCallParticipantBarge (string conversationId, string participantId)


Barge a given participant's call creating a barged in conference of connected participants.

Requires ANY permissions: 

* conversation:call:barge

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantBargeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Barge a given participant's call creating a barged in conference of connected participants.
                apiInstance.PostConversationsCallParticipantBarge(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantBarge: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

void (empty response body)


## PostConversationsCallParticipantCoach

> void PostConversationsCallParticipantCoach (string conversationId, string participantId)


Listen in on the conversation from the point of view of a given participant while speaking to just the given participant.

Requires ANY permissions: 

* conversation:call:coach

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantCoachExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Listen in on the conversation from the point of view of a given participant while speaking to just the given participant.
                apiInstance.PostConversationsCallParticipantCoach(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantCoach: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

void (empty response body)


## PostConversationsCallParticipantCommunicationWrapup

> void PostConversationsCallParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)


Apply wrap-up for this conversation communication

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new WrapupInput(); // WrapupInput | Wrap-up (optional) 

            try
            { 
                // Apply wrap-up for this conversation communication
                apiInstance.PostConversationsCallParticipantCommunicationWrapup(conversationId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**WrapupInput**](WrapupInput)| Wrap-up | [optional]  |

### Return type

void (empty response body)


## PostConversationsCallParticipantConsult

> [**ConsultTransferResponse**](ConsultTransferResponse) PostConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransfer body)


Initiate and update consult transfer

Requires ANY permissions: 

* conversation:communication:consultTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantConsultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransfer(); // ConsultTransfer | Destination address & initial speak to

            try
            { 
                // Initiate and update consult transfer
                ConsultTransferResponse result = apiInstance.PostConversationsCallParticipantConsult(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantConsult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransfer**](ConsultTransfer)| Destination address &amp; initial speak to |  |

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse)


## PostConversationsCallParticipantConsultAgent

> [**ConsultTransferResponse**](ConsultTransferResponse) PostConversationsCallParticipantConsultAgent (string conversationId, string participantId, ConsultTransferToAgent body)


Initiate a consult transfer to an agent

Requires ANY permissions: 

* conversation:communication:consultTransfer
* conversation:communication:consultTransferAgent

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantConsultAgentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransferToAgent(); // ConsultTransferToAgent | Destination agent & initial speak to

            try
            { 
                // Initiate a consult transfer to an agent
                ConsultTransferResponse result = apiInstance.PostConversationsCallParticipantConsultAgent(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantConsultAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransferToAgent**](ConsultTransferToAgent)| Destination agent &amp; initial speak to |  |

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse)


## PostConversationsCallParticipantConsultContactExternal

> [**ConsultTransferResponse**](ConsultTransferResponse) PostConversationsCallParticipantConsultContactExternal (string conversationId, string participantId, ConsultTransferToExternalContact body)


Initiate a consult transfer to an external contact

PostConversationsCallParticipantConsultContactExternal is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:communication:consultTransfer
* conversation:communication:consultTransferExternalContact

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantConsultContactExternalExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransferToExternalContact(); // ConsultTransferToExternalContact | Destination address & initial speak to

            try
            { 
                // Initiate a consult transfer to an external contact
                ConsultTransferResponse result = apiInstance.PostConversationsCallParticipantConsultContactExternal(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantConsultContactExternal: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransferToExternalContact**](ConsultTransferToExternalContact)| Destination address &amp; initial speak to |  |

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse)


## PostConversationsCallParticipantConsultExternal

> [**ConsultTransferResponse**](ConsultTransferResponse) PostConversationsCallParticipantConsultExternal (string conversationId, string participantId, ConsultTransferToExternal body)


Initiate a consult transfer to an external contact

Requires ANY permissions: 

* conversation:communication:consultTransfer
* conversation:communication:consultTransferExternal

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantConsultExternalExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransferToExternal(); // ConsultTransferToExternal | Destination address & initial speak to

            try
            { 
                // Initiate a consult transfer to an external contact
                ConsultTransferResponse result = apiInstance.PostConversationsCallParticipantConsultExternal(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantConsultExternal: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransferToExternal**](ConsultTransferToExternal)| Destination address &amp; initial speak to |  |

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse)


## PostConversationsCallParticipantConsultQueue

> [**ConsultTransferResponse**](ConsultTransferResponse) PostConversationsCallParticipantConsultQueue (string conversationId, string participantId, ConsultTransferToQueue body)


Initiate a consult transfer to a queue

Requires ANY permissions: 

* conversation:communication:consultTransfer
* conversation:communication:consultTransferQueue

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantConsultQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransferToQueue(); // ConsultTransferToQueue | Destination queue & initial speak to

            try
            { 
                // Initiate a consult transfer to a queue
                ConsultTransferResponse result = apiInstance.PostConversationsCallParticipantConsultQueue(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantConsultQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransferToQueue**](ConsultTransferToQueue)| Destination queue &amp; initial speak to |  |

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse)


## PostConversationsCallParticipantMonitor

> void PostConversationsCallParticipantMonitor (string conversationId, string participantId)


Listen in on the conversation from the point of view of a given participant.

Requires ANY permissions: 

* conversation:call:monitor

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantMonitorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Listen in on the conversation from the point of view of a given participant.
                apiInstance.PostConversationsCallParticipantMonitor(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantMonitor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

void (empty response body)


## PostConversationsCallParticipantReplace

> void PostConversationsCallParticipantReplace (string conversationId, string participantId, TransferRequest body)


Replace this participant with the specified user and/or address

Requires ANY permissions: 

* conversation:communication:blindTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsCallParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationsCallParticipantVoiceConsult

> [**ConsultTransferResponse**](ConsultTransferResponse) PostConversationsCallParticipantVoiceConsult (string conversationId, string participantId, ConsultTransferToAddress body)


Initiate voice consult transfer

PostConversationsCallParticipantVoiceConsult is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:communication:consultTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantVoiceConsultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransferToAddress(); // ConsultTransferToAddress | Destination address & initial speak to

            try
            { 
                // Initiate voice consult transfer
                ConsultTransferResponse result = apiInstance.PostConversationsCallParticipantVoiceConsult(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantVoiceConsult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransferToAddress**](ConsultTransferToAddress)| Destination address &amp; initial speak to |  |

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse)


## PostConversationsCallParticipants

> [**Conversation**](Conversation) PostConversationsCallParticipants (string conversationId, Conversation body)


Add participants to a conversation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Add participants to a conversation
                Conversation result = apiInstance.PostConversationsCallParticipants(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipants: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation)| Conversation |  |

### Return type

[**Conversation**](Conversation)


## PostConversationsCallParticipantsUserUserId

> [**Conversation**](Conversation) PostConversationsCallParticipantsUserUserId (string conversationId, string userId, Conversation body)


Add participants to a conversation on behalf of a user

Requires ANY permissions: 

* conversation:agentlessCall:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantsUserUserIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var userId = userId_example;  // string | userId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Add participants to a conversation on behalf of a user
                Conversation result = apiInstance.PostConversationsCallParticipantsUserUserId(conversationId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantsUserUserId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **userId** | **string**| userId |  |
| **body** | [**Conversation**](Conversation)| Conversation |  |

### Return type

[**Conversation**](Conversation)


## PostConversationsCallbackParticipantCommunicationWrapup

> void PostConversationsCallbackParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)


Apply wrap-up for this conversation communication

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallbackParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new WrapupInput(); // WrapupInput | Wrap-up (optional) 

            try
            { 
                // Apply wrap-up for this conversation communication
                apiInstance.PostConversationsCallbackParticipantCommunicationWrapup(conversationId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallbackParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**WrapupInput**](WrapupInput)| Wrap-up | [optional]  |

### Return type

void (empty response body)


## PostConversationsCallbackParticipantReplace

> void PostConversationsCallbackParticipantReplace (string conversationId, string participantId, TransferRequest body)


Replace this participant with the specified user and/or address

Requires ANY permissions: 

* conversation:communication:blindTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallbackParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsCallbackParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallbackParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationsCallbacks

> [**CreateCallbackResponse**](CreateCallbackResponse) PostConversationsCallbacks (CreateCallbackCommand body)


Create a Callback

Requires ALL permissions: 

* conversation:callback:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallbacksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new CreateCallbackCommand(); // CreateCallbackCommand | Callback

            try
            { 
                // Create a Callback
                CreateCallbackResponse result = apiInstance.PostConversationsCallbacks(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallbacks: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateCallbackCommand**](CreateCallbackCommand)| Callback |  |

### Return type

[**CreateCallbackResponse**](CreateCallbackResponse)


## PostConversationsCallbacksBulkDisconnect

> void PostConversationsCallbacksBulkDisconnect (BulkCallbackDisconnectRequest body)


Disconnect multiple scheduled callbacks

Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallbacksBulkDisconnectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new BulkCallbackDisconnectRequest(); // BulkCallbackDisconnectRequest | BulkCallbackDisconnectRequest

            try
            { 
                // Disconnect multiple scheduled callbacks
                apiInstance.PostConversationsCallbacksBulkDisconnect(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallbacksBulkDisconnect: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkCallbackDisconnectRequest**](BulkCallbackDisconnectRequest)| BulkCallbackDisconnectRequest |  |

### Return type

void (empty response body)


## PostConversationsCallbacksBulkUpdate

> [**BulkCallbackPatchResponse**](BulkCallbackPatchResponse) PostConversationsCallbacksBulkUpdate (BulkCallbackPatchRequest body)


Update multiple scheduled callbacks

Requires ANY permissions: 

* conversation:callback:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallbacksBulkUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new BulkCallbackPatchRequest(); // BulkCallbackPatchRequest | BulkCallbackPatchRequest

            try
            { 
                // Update multiple scheduled callbacks
                BulkCallbackPatchResponse result = apiInstance.PostConversationsCallbacksBulkUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallbacksBulkUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkCallbackPatchRequest**](BulkCallbackPatchRequest)| BulkCallbackPatchRequest |  |

### Return type

[**BulkCallbackPatchResponse**](BulkCallbackPatchResponse)


## PostConversationsCalls

> [**CreateCallResponse**](CreateCallResponse) PostConversationsCalls (CreateCallRequest body)


Create a call conversation

Requires ANY permissions: 

* conversation:conference:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new CreateCallRequest(); // CreateCallRequest | Call request

            try
            { 
                // Create a call conversation
                CreateCallResponse result = apiInstance.PostConversationsCalls(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCalls: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateCallRequest**](CreateCallRequest)| Call request |  |

### Return type

[**CreateCallResponse**](CreateCallResponse)


## PostConversationsCallsUserUserId

> [**CreateCallResponse**](CreateCallResponse) PostConversationsCallsUserUserId (string userId, CreateCallRequest body)


Create a call conversation on behalf of a user

Requires ANY permissions: 

* conversation:agentlessCall:add
* conversation:call:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallsUserUserIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var userId = userId_example;  // string | userId
            var body = new CreateCallRequest(); // CreateCallRequest | Call request

            try
            { 
                // Create a call conversation on behalf of a user
                CreateCallResponse result = apiInstance.PostConversationsCallsUserUserId(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallsUserUserId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| userId |  |
| **body** | [**CreateCallRequest**](CreateCallRequest)| Call request |  |

### Return type

[**CreateCallResponse**](CreateCallResponse)


## PostConversationsChatCommunicationMessages

> [**WebChatMessage**](WebChatMessage) PostConversationsChatCommunicationMessages (string conversationId, string communicationId, CreateWebChatMessageRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Send a message on behalf of a communication in a chat conversation.

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatCommunicationMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new CreateWebChatMessageRequest(); // CreateWebChatMessageRequest | Message

            try
            { 
                // Send a message on behalf of a communication in a chat conversation.
                WebChatMessage result = apiInstance.PostConversationsChatCommunicationMessages(conversationId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChatCommunicationMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**CreateWebChatMessageRequest**](CreateWebChatMessageRequest)| Message |  |

### Return type

[**WebChatMessage**](WebChatMessage)


## PostConversationsChatCommunicationTyping

> [**WebChatTyping**](WebChatTyping) PostConversationsChatCommunicationTyping (string conversationId, string communicationId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Send a typing-indicator on behalf of a communication in a chat conversation.

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatCommunicationTypingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId

            try
            { 
                // Send a typing-indicator on behalf of a communication in a chat conversation.
                WebChatTyping result = apiInstance.PostConversationsChatCommunicationTyping(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChatCommunicationTyping: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |

### Return type

[**WebChatTyping**](WebChatTyping)


## PostConversationsChatParticipantCommunicationWrapup

> void PostConversationsChatParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Apply wrap-up for this conversation communication

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new WrapupInput(); // WrapupInput | Wrap-up (optional) 

            try
            { 
                // Apply wrap-up for this conversation communication
                apiInstance.PostConversationsChatParticipantCommunicationWrapup(conversationId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChatParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**WrapupInput**](WrapupInput)| Wrap-up | [optional]  |

### Return type

void (empty response body)


## PostConversationsChatParticipantReplace

> void PostConversationsChatParticipantReplace (string conversationId, string participantId, TransferRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Replace this participant with the specified user and/or address

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires ANY permissions: 

* conversation:communication:blindTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsChatParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChatParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationsChats

> [**ChatConversation**](ChatConversation) PostConversationsChats (CreateWebChatRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Create a web chat conversation

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires ALL permissions: 

* conversation:webchat:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new CreateWebChatRequest(); // CreateWebChatRequest | Create web chat request

            try
            { 
                // Create a web chat conversation
                ChatConversation result = apiInstance.PostConversationsChats(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChats: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateWebChatRequest**](CreateWebChatRequest)| Create web chat request |  |

### Return type

[**ChatConversation**](ChatConversation)


## PostConversationsCobrowsesessionParticipantCommunicationWrapup

> void PostConversationsCobrowsesessionParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Apply wrap-up for this conversation communication

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCobrowsesessionParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new WrapupInput(); // WrapupInput | Wrap-up (optional) 

            try
            { 
                // Apply wrap-up for this conversation communication
                apiInstance.PostConversationsCobrowsesessionParticipantCommunicationWrapup(conversationId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCobrowsesessionParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**WrapupInput**](WrapupInput)| Wrap-up | [optional]  |

### Return type

void (empty response body)


## PostConversationsCobrowsesessionParticipantReplace

> void PostConversationsCobrowsesessionParticipantReplace (string conversationId, string participantId, TransferRequest body = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Replace this participant with the specified user and/or address

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires ANY permissions: 

* conversation:communication:blindTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCobrowsesessionParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest |  (optional) 

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsCobrowsesessionParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCobrowsesessionParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest)|  | [optional]  |

### Return type

void (empty response body)


## PostConversationsEmailInboundmessages

> [**EmailConversation**](EmailConversation) PostConversationsEmailInboundmessages (string conversationId, InboundMessageRequest body)


Send an email to an external conversation. An external conversation is one where the provider is not PureCloud based. This endpoint allows the sender of the external email to reply or send a new message to the existing conversation. The new message will be treated as part of the existing conversation and chained to it.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailInboundmessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new InboundMessageRequest(); // InboundMessageRequest | Send external email reply

            try
            { 
                // Send an email to an external conversation. An external conversation is one where the provider is not PureCloud based. This endpoint allows the sender of the external email to reply or send a new message to the existing conversation. The new message will be treated as part of the existing conversation and chained to it.
                EmailConversation result = apiInstance.PostConversationsEmailInboundmessages(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailInboundmessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**InboundMessageRequest**](InboundMessageRequest)| Send external email reply |  |

### Return type

[**EmailConversation**](EmailConversation)


## PostConversationsEmailMessages

> [**EmailMessageReply**](EmailMessageReply) PostConversationsEmailMessages (string conversationId, EmailMessage body)


Send an email reply

Requires ANY permissions: 

* conversation:email:send

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new EmailMessage(); // EmailMessage | Reply

            try
            { 
                // Send an email reply
                EmailMessageReply result = apiInstance.PostConversationsEmailMessages(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**EmailMessage**](EmailMessage)| Reply |  |

### Return type

[**EmailMessageReply**](EmailMessageReply)


## PostConversationsEmailMessagesDraftAttachmentsCopy

> [**EmailMessage**](EmailMessage) PostConversationsEmailMessagesDraftAttachmentsCopy (string conversationId, CopyAttachmentsRequest body)


Copy attachments from an email message to the current draft.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailMessagesDraftAttachmentsCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new CopyAttachmentsRequest(); // CopyAttachmentsRequest | Copy Attachment Request

            try
            { 
                // Copy attachments from an email message to the current draft.
                EmailMessage result = apiInstance.PostConversationsEmailMessagesDraftAttachmentsCopy(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailMessagesDraftAttachmentsCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**CopyAttachmentsRequest**](CopyAttachmentsRequest)| Copy Attachment Request |  |

### Return type

[**EmailMessage**](EmailMessage)


## PostConversationsEmailParticipantCommunicationWrapup

> void PostConversationsEmailParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)


Apply wrap-up for this conversation communication

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new WrapupInput(); // WrapupInput | Wrap-up (optional) 

            try
            { 
                // Apply wrap-up for this conversation communication
                apiInstance.PostConversationsEmailParticipantCommunicationWrapup(conversationId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**WrapupInput**](WrapupInput)| Wrap-up | [optional]  |

### Return type

void (empty response body)


## PostConversationsEmailParticipantReplace

> void PostConversationsEmailParticipantReplace (string conversationId, string participantId, TransferRequest body)


Replace this participant with the specified user and/or address

Requires ANY permissions: 

* conversation:communication:blindTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsEmailParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationsEmailReconnect

> void PostConversationsEmailReconnect (string conversationId)


Reconnect the user to the most recently disconnected customer on a fully disconnected email conversation

This request is not valid when using the Client Credentials OAuth grant.

Requires ANY permissions: 

* conversation:communication:reconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailReconnectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Reconnect the user to the most recently disconnected customer on a fully disconnected email conversation
                apiInstance.PostConversationsEmailReconnect(conversationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailReconnect: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |

### Return type

void (empty response body)


## PostConversationsEmails

> [**EmailConversation**](EmailConversation) PostConversationsEmails (CreateEmailRequest body)


Create an email conversation

If the direction of the request is INBOUND, this will create an external conversation with a third party provider. If the direction of the the request is OUTBOUND, this will create a conversation to send outbound emails on behalf of a queue.

Requires ANY permissions: 

* conversation:email:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new CreateEmailRequest(); // CreateEmailRequest | Create email request

            try
            { 
                // Create an email conversation
                EmailConversation result = apiInstance.PostConversationsEmails(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateEmailRequest**](CreateEmailRequest)| Create email request |  |

### Return type

[**EmailConversation**](EmailConversation)


## PostConversationsEmailsAgentless

> [**AgentlessEmailSendResponseDto**](AgentlessEmailSendResponseDto) PostConversationsEmailsAgentless (AgentlessEmailSendRequestDto body)


Create an email conversation, per API

Requires ANY permissions: 

* conversation:email:create
* conversation:agentlessEmail:send

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailsAgentlessExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new AgentlessEmailSendRequestDto(); // AgentlessEmailSendRequestDto | Create agentless email request

            try
            { 
                // Create an email conversation, per API
                AgentlessEmailSendResponseDto result = apiInstance.PostConversationsEmailsAgentless(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailsAgentless: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AgentlessEmailSendRequestDto**](AgentlessEmailSendRequestDto)| Create agentless email request |  |

### Return type

[**AgentlessEmailSendResponseDto**](AgentlessEmailSendResponseDto)


## PostConversationsFaxes

> [**FaxSendResponse**](FaxSendResponse) PostConversationsFaxes (FaxSendRequest body)


Create Fax Conversation

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsFaxesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new FaxSendRequest(); // FaxSendRequest | Fax

            try
            { 
                // Create Fax Conversation
                FaxSendResponse result = apiInstance.PostConversationsFaxes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsFaxes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FaxSendRequest**](FaxSendRequest)| Fax |  |

### Return type

[**FaxSendResponse**](FaxSendResponse)


## PostConversationsKeyconfigurations

> [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration) PostConversationsKeyconfigurations (ConversationEncryptionConfiguration body)


Setup configurations for encryption key creation

Requires ANY permissions: 

* conversation:encryptionKey:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsKeyconfigurationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new ConversationEncryptionConfiguration(); // ConversationEncryptionConfiguration | Encryption Configuration

            try
            { 
                // Setup configurations for encryption key creation
                ConversationEncryptionConfiguration result = apiInstance.PostConversationsKeyconfigurations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsKeyconfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration)| Encryption Configuration |  |

### Return type

[**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration)


## PostConversationsKeyconfigurationsValidate

> [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration) PostConversationsKeyconfigurationsValidate (ConversationEncryptionConfiguration body)


Validate encryption key configurations without saving it

Requires ANY permissions: 

* conversation:encryptionKey:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsKeyconfigurationsValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new ConversationEncryptionConfiguration(); // ConversationEncryptionConfiguration | Encryption Configuration

            try
            { 
                // Validate encryption key configurations without saving it
                ConversationEncryptionConfiguration result = apiInstance.PostConversationsKeyconfigurationsValidate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsKeyconfigurationsValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration)| Encryption Configuration |  |

### Return type

[**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration)


## PostConversationsMessageCommunicationMessages

> [**MessageData**](MessageData) PostConversationsMessageCommunicationMessages (string conversationId, string communicationId, AdditionalMessage body, bool? useNormalizedMessage = null)


Send message

Send message on existing conversation/communication. Only one message body field can be accepted, per request. Example: 1 textBody, 1 mediaId, or 1 messageTemplate.

Requires ANY permissions: 

* conversation:message:create
* conversation:webmessaging:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageCommunicationMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new AdditionalMessage(); // AdditionalMessage | Message
            var useNormalizedMessage = true;  // bool? | If true, response removes deprecated fields (textBody, media) (optional)  (default to false)

            try
            { 
                // Send message
                MessageData result = apiInstance.PostConversationsMessageCommunicationMessages(conversationId, communicationId, body, useNormalizedMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageCommunicationMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**AdditionalMessage**](AdditionalMessage)| Message |  |
| **useNormalizedMessage** | **bool?**| If true, response removes deprecated fields (textBody, media) | [optional] [default to false] |

### Return type

[**MessageData**](MessageData)


## PostConversationsMessageCommunicationMessagesMedia

> [**MessageMediaData**](MessageMediaData) PostConversationsMessageCommunicationMessagesMedia (string conversationId, string communicationId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Create media

See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.

Requires ANY permissions: 

* conversation:message:create
* conversation:webmessaging:create
* conversation:socialmedia:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageCommunicationMessagesMediaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId

            try
            { 
                // Create media
                MessageMediaData result = apiInstance.PostConversationsMessageCommunicationMessagesMedia(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageCommunicationMessagesMedia: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |

### Return type

[**MessageMediaData**](MessageMediaData)


## PostConversationsMessageCommunicationMessagesMediaUploads

> [**MessageMediaUploadData**](MessageMediaUploadData) PostConversationsMessageCommunicationMessagesMediaUploads (string conversationId, string communicationId, UploadMediaRequest body)


Create a URL to upload a message media file

See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.

Requires ANY permissions: 

* conversation:message:create
* conversation:webmessaging:create
* conversation:socialmedia:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageCommunicationMessagesMediaUploadsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new UploadMediaRequest(); // UploadMediaRequest | request

            try
            { 
                // Create a URL to upload a message media file
                MessageMediaUploadData result = apiInstance.PostConversationsMessageCommunicationMessagesMediaUploads(conversationId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageCommunicationMessagesMediaUploads: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**UploadMediaRequest**](UploadMediaRequest)| request |  |

### Return type

[**MessageMediaUploadData**](MessageMediaUploadData)


## PostConversationsMessageCommunicationSocialmediaMessages

> [**SocialMediaMessageData**](SocialMediaMessageData) PostConversationsMessageCommunicationSocialmediaMessages (string conversationId, string communicationId, AdditionalSocialMediaMessage body)


Send a social media message

Send a social media message on existing conversation/communication.

Requires ANY permissions: 

* conversation:socialmedia:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageCommunicationSocialmediaMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new AdditionalSocialMediaMessage(); // AdditionalSocialMediaMessage | Message

            try
            { 
                // Send a social media message
                SocialMediaMessageData result = apiInstance.PostConversationsMessageCommunicationSocialmediaMessages(conversationId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageCommunicationSocialmediaMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**AdditionalSocialMediaMessage**](AdditionalSocialMediaMessage)| Message |  |

### Return type

[**SocialMediaMessageData**](SocialMediaMessageData)


## PostConversationsMessageCommunicationTyping

> void PostConversationsMessageCommunicationTyping (string conversationId, string communicationId, MessageTypingEventRequest body)


Send message typing event

Send message typing event for existing conversation/communication.

Requires ANY permissions: 

* conversation:message:create
* conversation:webmessaging:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageCommunicationTypingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MessageTypingEventRequest(); // MessageTypingEventRequest | MessageTypingEvent

            try
            { 
                // Send message typing event
                apiInstance.PostConversationsMessageCommunicationTyping(conversationId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageCommunicationTyping: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MessageTypingEventRequest**](MessageTypingEventRequest)| MessageTypingEvent |  |

### Return type

void (empty response body)


## PostConversationsMessageInboundOpenEvent

> [**OpenEventNormalizedMessage**](OpenEventNormalizedMessage) PostConversationsMessageInboundOpenEvent (string integrationId, OpenInboundNormalizedEvent body)


Send an inbound Open Event Message

Send an inbound event message to an Open Messaging integration. In order to call this endpoint you will need OAuth token generated using OAuth client credentials authorized with at least messaging scope. This will either generate a new Conversation, or be a part of an existing conversation. See https://developer.genesys.cloud/api/digital/openmessaging/ for example usage.

Requires ALL permissions: 

* conversation:message:receive

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageInboundOpenEventExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | integrationId
            var body = new OpenInboundNormalizedEvent(); // OpenInboundNormalizedEvent | NormalizedMessage

            try
            { 
                // Send an inbound Open Event Message
                OpenEventNormalizedMessage result = apiInstance.PostConversationsMessageInboundOpenEvent(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageInboundOpenEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| integrationId |  |
| **body** | [**OpenInboundNormalizedEvent**](OpenInboundNormalizedEvent)| NormalizedMessage |  |

### Return type

[**OpenEventNormalizedMessage**](OpenEventNormalizedMessage)


## PostConversationsMessageInboundOpenMessage

> [**OpenMessageNormalizedMessage**](OpenMessageNormalizedMessage) PostConversationsMessageInboundOpenMessage (string integrationId, OpenInboundNormalizedMessage body, bool? prefetchConversationId = null)


Send inbound Open Message

Send an inbound message to an Open Messaging integration. In order to call this endpoint you will need OAuth token generated using OAuth client credentials authorized with at least messaging scope. This will either generate a new Conversation, or be a part of an existing conversation. See https://developer.genesys.cloud/api/digital/openmessaging/ for example usage.

Requires ALL permissions: 

* conversation:message:receive

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageInboundOpenMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | integrationId
            var body = new OpenInboundNormalizedMessage(); // OpenInboundNormalizedMessage | NormalizedMessage
            var prefetchConversationId = true;  // bool? | Indicates whether or not to prefetch conversationId (optional)  (default to false)

            try
            { 
                // Send inbound Open Message
                OpenMessageNormalizedMessage result = apiInstance.PostConversationsMessageInboundOpenMessage(integrationId, body, prefetchConversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageInboundOpenMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| integrationId |  |
| **body** | [**OpenInboundNormalizedMessage**](OpenInboundNormalizedMessage)| NormalizedMessage |  |
| **prefetchConversationId** | **bool?**| Indicates whether or not to prefetch conversationId | [optional] [default to false] |

### Return type

[**OpenMessageNormalizedMessage**](OpenMessageNormalizedMessage)


## PostConversationsMessageInboundOpenReceipt

> [**OpenReceiptNormalizedMessage**](OpenReceiptNormalizedMessage) PostConversationsMessageInboundOpenReceipt (string integrationId, OpenInboundNormalizedReceipt body)


Send an inbound Open Receipt Message

Send an inbound open Receipt to an Open Messaging integration. In order to call this endpoint you will need OAuth token generated using OAuth client credentials authorized with at least messaging scope. This will either generate a new Conversation, or be a part of an existing conversation. See https://developer.genesys.cloud/api/digital/openmessaging/ for example usage.

Requires ALL permissions: 

* conversation:message:receive

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageInboundOpenReceiptExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | integrationId
            var body = new OpenInboundNormalizedReceipt(); // OpenInboundNormalizedReceipt | NormalizedMessage

            try
            { 
                // Send an inbound Open Receipt Message
                OpenReceiptNormalizedMessage result = apiInstance.PostConversationsMessageInboundOpenReceipt(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageInboundOpenReceipt: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| integrationId |  |
| **body** | [**OpenInboundNormalizedReceipt**](OpenInboundNormalizedReceipt)| NormalizedMessage |  |

### Return type

[**OpenReceiptNormalizedMessage**](OpenReceiptNormalizedMessage)


## PostConversationsMessageInboundOpenStructuredResponse

> [**OpenStructuredResponseNormalizedMessage**](OpenStructuredResponseNormalizedMessage) PostConversationsMessageInboundOpenStructuredResponse (string integrationId, OpenInboundStructuredResponseMessage body)


Send inbound Open Response

Send an inbound response for a structured message to an Open Messaging integration. In order to call this endpoint you will need OAuth token generated using OAuth client credentials authorized with at least messaging scope. This will be a part of an existing conversation. See https://developer.genesys.cloud/api/digital/openmessaging/ for example usage.

Requires ALL permissions: 

* conversation:message:receive

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageInboundOpenStructuredResponseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | integrationId
            var body = new OpenInboundStructuredResponseMessage(); // OpenInboundStructuredResponseMessage | OpenInboundStructuredResponseMessage

            try
            { 
                // Send inbound Open Response
                OpenStructuredResponseNormalizedMessage result = apiInstance.PostConversationsMessageInboundOpenStructuredResponse(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageInboundOpenStructuredResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| integrationId |  |
| **body** | [**OpenInboundStructuredResponseMessage**](OpenInboundStructuredResponseMessage)| OpenInboundStructuredResponseMessage |  |

### Return type

[**OpenStructuredResponseNormalizedMessage**](OpenStructuredResponseNormalizedMessage)


## PostConversationsMessageMessagesBulk

> [**TextMessageListing**](TextMessageListing) PostConversationsMessageMessagesBulk (string conversationId, bool? useNormalizedMessage = null, List<string> body = null)


Get messages in batch

The path parameter [conversationId] should contain the conversationId of the conversation being filtered. The body should contain the messageId(s) of messages being requested. For example: [\"a3069a33b-bbb1-4703-9d68-061d9e9db96e\", \"55bc6be3-078c-4a49-a4e6-1e05776ed7e8\"]

Requires ANY permissions: 

* conversation:message:view
* conversation:webmessaging:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageMessagesBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | 
            var useNormalizedMessage = true;  // bool? | If true, response removes deprecated fields (textBody, media) (optional)  (default to false)
            var body = new List<string>(); // List<string> | messageIds (optional) 

            try
            { 
                // Get messages in batch
                TextMessageListing result = apiInstance.PostConversationsMessageMessagesBulk(conversationId, useNormalizedMessage, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageMessagesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **useNormalizedMessage** | **bool?**| If true, response removes deprecated fields (textBody, media) | [optional] [default to false] |
| **body** | [**List<string>**](string)| messageIds | [optional]  |

### Return type

[**TextMessageListing**](TextMessageListing)


## PostConversationsMessageParticipantCommunicationWrapup

> void PostConversationsMessageParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)


Apply wrap-up for this conversation communication

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new WrapupInput(); // WrapupInput | Wrap-up (optional) 

            try
            { 
                // Apply wrap-up for this conversation communication
                apiInstance.PostConversationsMessageParticipantCommunicationWrapup(conversationId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**WrapupInput**](WrapupInput)| Wrap-up | [optional]  |

### Return type

void (empty response body)


## PostConversationsMessageParticipantMonitor

> void PostConversationsMessageParticipantMonitor (string conversationId, string participantId)


Listen in on the conversation from the point of view of a given participant.

Requires ANY permissions: 

* conversation:message:monitor

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageParticipantMonitorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Listen in on the conversation from the point of view of a given participant.
                apiInstance.PostConversationsMessageParticipantMonitor(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageParticipantMonitor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |

### Return type

void (empty response body)


## PostConversationsMessageParticipantReplace

> void PostConversationsMessageParticipantReplace (string conversationId, string participantId, TransferRequest body)


Replace this participant with the specified user and/or address

Requires ANY permissions: 

* conversation:communication:blindTransfer

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsMessageParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest)| Transfer request |  |

### Return type

void (empty response body)


## PostConversationsMessages

> [**CreateOutboundMessagingConversationResponse**](CreateOutboundMessagingConversationResponse) PostConversationsMessages (CreateOutboundMessagingConversationRequest body)


Create an outbound messaging conversation.

If there is an existing conversation between the remote address and the address associated with the queue specified in createOutboundRequest then the result of this request depends on the state of that conversation and the useExistingConversation field of createOutboundRequest. If the existing conversation is in alerting or connected state, then the request will fail. If the existing conversation is disconnected but still within the conversation window then the request will fail unless useExistingConversation is set to true.

Requires ALL permissions: 

* conversation:message:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new CreateOutboundMessagingConversationRequest(); // CreateOutboundMessagingConversationRequest | Create outbound messaging conversation

            try
            { 
                // Create an outbound messaging conversation.
                CreateOutboundMessagingConversationResponse result = apiInstance.PostConversationsMessages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateOutboundMessagingConversationRequest**](CreateOutboundMessagingConversationRequest)| Create outbound messaging conversation |  |

### Return type

[**CreateOutboundMessagingConversationResponse**](CreateOutboundMessagingConversationResponse)


## PostConversationsMessagesAgentless

> [**SendAgentlessOutboundMessageResponse**](SendAgentlessOutboundMessageResponse) PostConversationsMessagesAgentless (SendAgentlessOutboundMessageRequest body, bool? useNormalizedMessage = null)


Send an agentless outbound message

Send an agentless (api participant) outbound message using a client credential grant. In order to call this endpoint you will need OAuth token generated using OAuth client credentials authorized with at least messaging scope. If there is already a connected conversation between the 'fromAddress' and 'toAddress' specified, the 'useExistingActiveConversation' param can be used to barge in to the ongoing conversation.

Requires ALL permissions: 

* conversation:message:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagesAgentlessExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new SendAgentlessOutboundMessageRequest(); // SendAgentlessOutboundMessageRequest | Create agentless outbound messaging request
            var useNormalizedMessage = true;  // bool? | If true, response removes deprecated fields (textBody, messagingTemplate) (optional)  (default to false)

            try
            { 
                // Send an agentless outbound message
                SendAgentlessOutboundMessageResponse result = apiInstance.PostConversationsMessagesAgentless(body, useNormalizedMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagesAgentless: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SendAgentlessOutboundMessageRequest**](SendAgentlessOutboundMessageRequest)| Create agentless outbound messaging request |  |
| **useNormalizedMessage** | **bool?**| If true, response removes deprecated fields (textBody, messagingTemplate) | [optional] [default to false] |

### Return type

[**SendAgentlessOutboundMessageResponse**](SendAgentlessOutboundMessageResponse)


## PostConversationsMessagesInboundOpen

> [**OpenNormalizedMessage**](OpenNormalizedMessage) PostConversationsMessagesInboundOpen (OpenNormalizedMessage body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Send an inbound Open Message

[This API is deprecated. Instead, use 1. POST /api/v2/conversations/messages/{integrationId}/inbound/open/event, if you want to send an inbound Open Event Message 2. POST /api/v2/conversations/messages/{integrationId}/inbound/open/message, if you want to send an inbound Open Message 3. POST /api/v2/conversations/messages/{integrationId}/inbound/open/receipt, to send an inbound Open Receipt Message]  In order to call this endpoint you will need OAuth token generated using OAuth client credentials authorized with at least messaging scope. This will either generate a new Conversation, or be a part of an existing conversation. See https://developer.genesys.cloud/api/digital/openmessaging/ for example usage.

Requires ALL permissions: 

* conversation:message:receive

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagesInboundOpenExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new OpenNormalizedMessage(); // OpenNormalizedMessage | NormalizedMessage

            try
            { 
                // Send an inbound Open Message
                OpenNormalizedMessage result = apiInstance.PostConversationsMessagesInboundOpen(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagesInboundOpen: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OpenNormalizedMessage**](OpenNormalizedMessage)| NormalizedMessage |  |

### Return type

[**OpenNormalizedMessage**](OpenNormalizedMessage)


## PostConversationsMessagingIntegrationsApple

> [**AppleIntegration**](AppleIntegration) PostConversationsMessagingIntegrationsApple (AppleIntegrationRequest body)


Create Apple Integration

Requires ALL permissions: 

* messaging:appleIntegration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsAppleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new AppleIntegrationRequest(); // AppleIntegrationRequest | AppleIntegrationRequest

            try
            { 
                // Create Apple Integration
                AppleIntegration result = apiInstance.PostConversationsMessagingIntegrationsApple(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsApple: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AppleIntegrationRequest**](AppleIntegrationRequest)| AppleIntegrationRequest |  |

### Return type

[**AppleIntegration**](AppleIntegration)


## PostConversationsMessagingIntegrationsFacebook

> [**FacebookIntegration**](FacebookIntegration) PostConversationsMessagingIntegrationsFacebook (FacebookIntegrationRequest body)


Create a Facebook Integration

Requires ALL permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsFacebookExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new FacebookIntegrationRequest(); // FacebookIntegrationRequest | FacebookIntegrationRequest

            try
            { 
                // Create a Facebook Integration
                FacebookIntegration result = apiInstance.PostConversationsMessagingIntegrationsFacebook(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsFacebook: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FacebookIntegrationRequest**](FacebookIntegrationRequest)| FacebookIntegrationRequest |  |

### Return type

[**FacebookIntegration**](FacebookIntegration)


## PostConversationsMessagingIntegrationsInstagram

> [**InstagramIntegration**](InstagramIntegration) PostConversationsMessagingIntegrationsInstagram (InstagramIntegrationRequest body)


Create Instagram Integration

Requires ALL permissions: 

* messaging:conversationInstagramIntegration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsInstagramExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new InstagramIntegrationRequest(); // InstagramIntegrationRequest | InstagramIntegrationRequest

            try
            { 
                // Create Instagram Integration
                InstagramIntegration result = apiInstance.PostConversationsMessagingIntegrationsInstagram(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsInstagram: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**InstagramIntegrationRequest**](InstagramIntegrationRequest)| InstagramIntegrationRequest |  |

### Return type

[**InstagramIntegration**](InstagramIntegration)


## PostConversationsMessagingIntegrationsOpen

> [**OpenIntegration**](OpenIntegration) PostConversationsMessagingIntegrationsOpen (OpenIntegrationRequest body)


Create an Open messaging integration

See https://developer.genesys.cloud/api/digital/openmessaging/ for more information.

Requires ALL permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsOpenExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new OpenIntegrationRequest(); // OpenIntegrationRequest | OpenIntegrationRequest

            try
            { 
                // Create an Open messaging integration
                OpenIntegration result = apiInstance.PostConversationsMessagingIntegrationsOpen(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsOpen: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OpenIntegrationRequest**](OpenIntegrationRequest)| OpenIntegrationRequest |  |

### Return type

[**OpenIntegration**](OpenIntegration)


## PostConversationsMessagingIntegrationsTwitter

> [**TwitterIntegration**](TwitterIntegration) PostConversationsMessagingIntegrationsTwitter (TwitterIntegrationRequest body)


Create Twitter Integration

Requires ALL permissions: 

* messaging:XIntegration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsTwitterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new TwitterIntegrationRequest(); // TwitterIntegrationRequest | TwitterIntegrationRequest

            try
            { 
                // Create Twitter Integration
                TwitterIntegration result = apiInstance.PostConversationsMessagingIntegrationsTwitter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsTwitter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TwitterIntegrationRequest**](TwitterIntegrationRequest)| TwitterIntegrationRequest |  |

### Return type

[**TwitterIntegration**](TwitterIntegration)


## PostConversationsMessagingIntegrationsWhatsapp

> [**WhatsAppIntegration**](WhatsAppIntegration) PostConversationsMessagingIntegrationsWhatsapp (WhatsAppIntegrationRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

[This API is deprecated. Use POST /api/v2/conversations/messaging/integrations/whatsapp/embeddedsignup instead] Create a WhatsApp Integration

[This API is deprecated. Use POST /api/v2/conversations/messaging/integrations/whatsapp/embeddedsignup instead] You must be approved by WhatsApp to use this feature. Your approved e164-formatted phone number and valid WhatsApp certificate for your number are required. Your WhatsApp certificate must have valid base64 encoding. Please paste carefully and do not add any leading or trailing spaces. Do not alter any characters. An integration must be activated within 7 days of certificate generation. If you cannot complete the addition and activation of the number within 7 days, please obtain a new certificate before creating the integration. Integrations created with an invalid number or certificate may immediately incur additional integration fees. Please carefully enter your number and certificate as described.

Requires ALL permissions: 

* messaging:whatsappIntegration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsWhatsappExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new WhatsAppIntegrationRequest(); // WhatsAppIntegrationRequest | WhatsAppIntegrationRequest

            try
            { 
                // [This API is deprecated. Use POST /api/v2/conversations/messaging/integrations/whatsapp/embeddedsignup instead] Create a WhatsApp Integration
                WhatsAppIntegration result = apiInstance.PostConversationsMessagingIntegrationsWhatsapp(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsWhatsapp: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WhatsAppIntegrationRequest**](WhatsAppIntegrationRequest)| WhatsAppIntegrationRequest |  |

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration)


## PostConversationsMessagingIntegrationsWhatsappEmbeddedsignup

> [**WhatsAppIntegration**](WhatsAppIntegration) PostConversationsMessagingIntegrationsWhatsappEmbeddedsignup (WhatsAppEmbeddedSignupIntegrationRequest body)


Create a WhatsApp Integration using the WhatsApp embedded signup flow

Use the access token returned from the embedded signup flow to obtain a list of available phone numbers that can be associated with the created integration. The returned WhatsApp integration will initially have a createStatus of Initiated until the list of available phone numbers can be obtained from the provider. Please run a GET on the created integration until it returns a createStatus of Completed, and the list of available phone numbers obtained from the provider. You can then specify one of the available phone numbers in the PATCH call on the integration to activate it.

Requires ALL permissions: 

* messaging:whatsappIntegration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsWhatsappEmbeddedsignupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new WhatsAppEmbeddedSignupIntegrationRequest(); // WhatsAppEmbeddedSignupIntegrationRequest | WhatsAppEmbeddedSignupIntegrationRequest

            try
            { 
                // Create a WhatsApp Integration using the WhatsApp embedded signup flow
                WhatsAppIntegration result = apiInstance.PostConversationsMessagingIntegrationsWhatsappEmbeddedsignup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsWhatsappEmbeddedsignup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WhatsAppEmbeddedSignupIntegrationRequest**](WhatsAppEmbeddedSignupIntegrationRequest)| WhatsAppEmbeddedSignupIntegrationRequest |  |

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration)


## PostConversationsMessagingSettings

> [**MessagingSetting**](MessagingSetting) PostConversationsMessagingSettings (MessagingSettingRequest body)


Create a messaging setting

Requires ALL permissions: 

* messaging:setting:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new MessagingSettingRequest(); // MessagingSettingRequest | MessagingSetting

            try
            { 
                // Create a messaging setting
                MessagingSetting result = apiInstance.PostConversationsMessagingSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MessagingSettingRequest**](MessagingSettingRequest)| MessagingSetting |  |

### Return type

[**MessagingSetting**](MessagingSetting)


## PostConversationsMessagingSupportedcontent

> [**SupportedContent**](SupportedContent) PostConversationsMessagingSupportedcontent (SupportedContent body)


Create a Supported Content profile

Requires ANY permissions: 

* messaging:supportedContent:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingSupportedcontentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new SupportedContent(); // SupportedContent | SupportedContent

            try
            { 
                // Create a Supported Content profile
                SupportedContent result = apiInstance.PostConversationsMessagingSupportedcontent(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingSupportedcontent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SupportedContent**](SupportedContent)| SupportedContent |  |

### Return type

[**SupportedContent**](SupportedContent)


## PostConversationsParticipantsAttributesSearch

> [**JsonCursorSearchResponse**](JsonCursorSearchResponse) PostConversationsParticipantsAttributesSearch (ConversationParticipantSearchRequest body)


Search conversations

Requires ANY permissions: 

* conversation:participant:attributesview

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsParticipantsAttributesSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new ConversationParticipantSearchRequest(); // ConversationParticipantSearchRequest | Search request options

            try
            { 
                // Search conversations
                JsonCursorSearchResponse result = apiInstance.PostConversationsParticipantsAttributesSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsParticipantsAttributesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationParticipantSearchRequest**](ConversationParticipantSearchRequest)| Search request options |  |

### Return type

[**JsonCursorSearchResponse**](JsonCursorSearchResponse)


## PostConversationsScreenshareParticipantCommunicationWrapup

> void PostConversationsScreenshareParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Apply wrap-up for this conversation communication

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsScreenshareParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new WrapupInput(); // WrapupInput | Wrap-up (optional) 

            try
            { 
                // Apply wrap-up for this conversation communication
                apiInstance.PostConversationsScreenshareParticipantCommunicationWrapup(conversationId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsScreenshareParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**WrapupInput**](WrapupInput)| Wrap-up | [optional]  |

### Return type

void (empty response body)


## PostConversationsSocialParticipantCommunicationWrapup

> void PostConversationsSocialParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)


Apply wrap-up for this conversation communication

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsSocialParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new WrapupInput(); // WrapupInput | Wrap-up (optional) 

            try
            { 
                // Apply wrap-up for this conversation communication
                apiInstance.PostConversationsSocialParticipantCommunicationWrapup(conversationId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsSocialParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**WrapupInput**](WrapupInput)| Wrap-up | [optional]  |

### Return type

void (empty response body)


## PostConversationsVideoAgentconferenceCommunication

> [**VideoConferenceDetails**](VideoConferenceDetails) PostConversationsVideoAgentconferenceCommunication (string conversationId, string communicationId)


Create an Agent-Type video conference and assign an agent to it

PostConversationsVideoAgentconferenceCommunication is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* conversation:video:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsVideoAgentconferenceCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId

            try
            { 
                // Create an Agent-Type video conference and assign an agent to it
                VideoConferenceDetails result = apiInstance.PostConversationsVideoAgentconferenceCommunication(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsVideoAgentconferenceCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |

### Return type

[**VideoConferenceDetails**](VideoConferenceDetails)


## PostConversationsVideoParticipantCommunicationWrapup

> void PostConversationsVideoParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)


Apply wrap-up for this conversation communication

Requires ANY permissions: 

* conversation:participant:wrapup

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsVideoParticipantCommunicationWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new WrapupInput(); // WrapupInput | Wrap-up (optional) 

            try
            { 
                // Apply wrap-up for this conversation communication
                apiInstance.PostConversationsVideoParticipantCommunicationWrapup(conversationId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsVideoParticipantCommunicationWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**WrapupInput**](WrapupInput)| Wrap-up | [optional]  |

### Return type

void (empty response body)


## PostConversationsVideosMeetings

> [**MeetingIdRecord**](MeetingIdRecord) PostConversationsVideosMeetings (GenerateMeetingIdRequest body)


Generate a meetingId for a given conferenceId

PostConversationsVideosMeetings is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* video:video:access

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsVideosMeetingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new GenerateMeetingIdRequest(); // GenerateMeetingIdRequest | MeetingIdRequest

            try
            { 
                // Generate a meetingId for a given conferenceId
                MeetingIdRecord result = apiInstance.PostConversationsVideosMeetings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsVideosMeetings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GenerateMeetingIdRequest**](GenerateMeetingIdRequest)| MeetingIdRequest |  |

### Return type

[**MeetingIdRecord**](MeetingIdRecord)


## PutConversationParticipantFlaggedreason

> void PutConversationParticipantFlaggedreason (string conversationId, string participantId)


Set flagged reason on conversation participant to indicate bad conversation quality.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationParticipantFlaggedreasonExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            { 
                // Set flagged reason on conversation participant to indicate bad conversation quality.
                apiInstance.PutConversationParticipantFlaggedreason(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationParticipantFlaggedreason: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |

### Return type

void (empty response body)


## PutConversationSecureattributes

> **string** PutConversationSecureattributes (string conversationId, ConversationSecureAttributes body)


Set the secure attributes on a conversation.

Requires ANY permissions: 

* conversation:participant:attributesedit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationSecureattributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new ConversationSecureAttributes(); // ConversationSecureAttributes | Conversation Secure Attributes

            try
            { 
                // Set the secure attributes on a conversation.
                string result = apiInstance.PutConversationSecureattributes(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationSecureattributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**ConversationSecureAttributes**](ConversationSecureAttributes)| Conversation Secure Attributes |  |

### Return type

**string**


## PutConversationTags

> **string** PutConversationTags (string conversationId, ConversationTagsUpdate body)


Update the tags on a conversation.

Requires ANY permissions: 

* conversation:externalTag:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationTagsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new ConversationTagsUpdate(); // ConversationTagsUpdate | Conversation Tags

            try
            { 
                // Update the tags on a conversation.
                string result = apiInstance.PutConversationTags(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationTags: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**ConversationTagsUpdate**](ConversationTagsUpdate)| Conversation Tags |  |

### Return type

**string**


## PutConversationsCallParticipantCommunicationUuidata

> **Object** PutConversationsCallParticipantCommunicationUuidata (string conversationId, string participantId, string communicationId, SetUuiDataRequest body)


Set uuiData to be sent on future commands.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsCallParticipantCommunicationUuidataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new SetUuiDataRequest(); // SetUuiDataRequest | UUIData Request

            try
            { 
                // Set uuiData to be sent on future commands.
                Object result = apiInstance.PutConversationsCallParticipantCommunicationUuidata(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsCallParticipantCommunicationUuidata: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**SetUuiDataRequest**](SetUuiDataRequest)| UUIData Request |  |

### Return type

**Object**


## PutConversationsCallRecordingstate

> **string** PutConversationsCallRecordingstate (string conversationId, SetRecordingState body)


Update a conversation by setting its recording state

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsCallRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                string result = apiInstance.PutConversationsCallRecordingstate(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsCallRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

**string**


## PutConversationsCallbackRecordingstate

> **string** PutConversationsCallbackRecordingstate (string conversationId, SetRecordingState body)


Update a conversation by setting its recording state

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsCallbackRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                string result = apiInstance.PutConversationsCallbackRecordingstate(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsCallbackRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

**string**


## PutConversationsChatRecordingstate

> **string** PutConversationsChatRecordingstate (string conversationId, SetRecordingState body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update a conversation by setting its recording state

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-removal-of-acd-web-chat-version-2/.

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsChatRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                string result = apiInstance.PutConversationsChatRecordingstate(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsChatRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

**string**


## PutConversationsCobrowsesessionRecordingstate

> **string** PutConversationsCobrowsesessionRecordingstate (string conversationId, SetRecordingState body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update a conversation by setting its recording state

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsCobrowsesessionRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                string result = apiInstance.PutConversationsCobrowsesessionRecordingstate(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsCobrowsesessionRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

**string**


## PutConversationsEmailMessagesDraft

> [**EmailMessage**](EmailMessage) PutConversationsEmailMessagesDraft (string conversationId, EmailMessage body)


Update conversation draft reply

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsEmailMessagesDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new EmailMessage(); // EmailMessage | Draft

            try
            { 
                // Update conversation draft reply
                EmailMessage result = apiInstance.PutConversationsEmailMessagesDraft(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsEmailMessagesDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**EmailMessage**](EmailMessage)| Draft |  |

### Return type

[**EmailMessage**](EmailMessage)


## PutConversationsEmailRecordingstate

> **string** PutConversationsEmailRecordingstate (string conversationId, SetRecordingState body)


Update a conversation by setting its recording state

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsEmailRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                string result = apiInstance.PutConversationsEmailRecordingstate(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsEmailRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

**string**


## PutConversationsKeyconfiguration

> [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration) PutConversationsKeyconfiguration (string keyconfigurationsId, ConversationEncryptionConfiguration body)


Update the encryption key configurations

Requires ANY permissions: 

* conversation:encryptionKey:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsKeyconfigurationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var keyconfigurationsId = keyconfigurationsId_example;  // string | Key Configurations Id
            var body = new ConversationEncryptionConfiguration(); // ConversationEncryptionConfiguration | Encryption key configuration metadata

            try
            { 
                // Update the encryption key configurations
                ConversationEncryptionConfiguration result = apiInstance.PutConversationsKeyconfiguration(keyconfigurationsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsKeyconfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **keyconfigurationsId** | **string**| Key Configurations Id |  |
| **body** | [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration)| Encryption key configuration metadata |  |

### Return type

[**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration)


## PutConversationsMessageRecordingstate

> **string** PutConversationsMessageRecordingstate (string conversationId, SetRecordingState body)


Update a conversation by setting its recording state

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessageRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                string result = apiInstance.PutConversationsMessageRecordingstate(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessageRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

**string**


## PutConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) PutConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId (string integrationId, IdentityResolutionConfig body)


Create an identity resolution settings for a Apple messaging integration

Requires ALL permissions: 

* messaging:integration:edit
* messaging:identityResolutionApple:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new IdentityResolutionConfig(); // IdentityResolutionConfig | IdentityResolutionConfig

            try
            { 
                // Create an identity resolution settings for a Apple messaging integration
                IdentityResolutionConfig result = apiInstance.PutConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingIdentityresolutionIntegrationsAppleIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**IdentityResolutionConfig**](IdentityResolutionConfig)| IdentityResolutionConfig |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## PutConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) PutConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId (string integrationId, IdentityResolutionConfig body)


Create an identity resolution settings for a Facebook messaging integration

Requires ALL permissions: 

* messaging:integration:edit
* messaging:identityResolutionFacebook:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new IdentityResolutionConfig(); // IdentityResolutionConfig | IdentityResolutionConfig

            try
            { 
                // Create an identity resolution settings for a Facebook messaging integration
                IdentityResolutionConfig result = apiInstance.PutConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingIdentityresolutionIntegrationsFacebookIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**IdentityResolutionConfig**](IdentityResolutionConfig)| IdentityResolutionConfig |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## PutConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) PutConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId (string integrationId, IdentityResolutionConfig body)


Create identity resolution settings for an Instagram messaging integration

Requires ALL permissions: 

* messaging:integration:edit
* messaging:identityResolutionInstagram:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new IdentityResolutionConfig(); // IdentityResolutionConfig | IdentityResolutionConfig

            try
            { 
                // Create identity resolution settings for an Instagram messaging integration
                IdentityResolutionConfig result = apiInstance.PutConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingIdentityresolutionIntegrationsInstagramIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**IdentityResolutionConfig**](IdentityResolutionConfig)| IdentityResolutionConfig |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## PutConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId

> [**OpenMessagingIdentityResolutionConfig**](OpenMessagingIdentityResolutionConfig) PutConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId (string integrationId, OpenMessagingIdentityResolutionConfig body)


Update an open messaging integration Identity Resolution settings

Requires ALL permissions: 

* messaging:integration:edit
* messaging:identityResolutionOpen:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new OpenMessagingIdentityResolutionConfig(); // OpenMessagingIdentityResolutionConfig | 

            try
            { 
                // Update an open messaging integration Identity Resolution settings
                OpenMessagingIdentityResolutionConfig result = apiInstance.PutConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingIdentityresolutionIntegrationsOpenIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**OpenMessagingIdentityResolutionConfig**](OpenMessagingIdentityResolutionConfig)|  |  |

### Return type

[**OpenMessagingIdentityResolutionConfig**](OpenMessagingIdentityResolutionConfig)


## PutConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) PutConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId (string integrationId, IdentityResolutionConfig body)


Create an identity resolution settings for an X (Formally Twitter) messaging integration

Requires ALL permissions: 

* messaging:XIntegration:edit
* messaging:identityResolutionX:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration Id
            var body = new IdentityResolutionConfig(); // IdentityResolutionConfig | IdentityResolutionConfig

            try
            { 
                // Create an identity resolution settings for an X (Formally Twitter) messaging integration
                IdentityResolutionConfig result = apiInstance.PutConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingIdentityresolutionIntegrationsTwitterIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration Id |  |
| **body** | [**IdentityResolutionConfig**](IdentityResolutionConfig)| IdentityResolutionConfig |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## PutConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId

> [**IdentityResolutionConfig**](IdentityResolutionConfig) PutConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId (string integrationId, IdentityResolutionConfig body)


Update a whatsApp integration Identity Resolution settings

Requires ALL permissions: 

* messaging:integration:edit
* messaging:identityResolutionWhatsApp:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new IdentityResolutionConfig(); // IdentityResolutionConfig | 

            try
            { 
                // Update a whatsApp integration Identity Resolution settings
                IdentityResolutionConfig result = apiInstance.PutConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingIdentityresolutionIntegrationsWhatsappIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**IdentityResolutionConfig**](IdentityResolutionConfig)|  |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## PutConversationsMessagingSettingsDefault

> [**MessagingSetting**](MessagingSetting) PutConversationsMessagingSettingsDefault (MessagingSettingDefaultRequest body)


Set the organization's default setting that may be applied to to integrations without settings

When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be assigned to it.

Requires ALL permissions: 

* messaging:setting:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingSettingsDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new MessagingSettingDefaultRequest(); // MessagingSettingDefaultRequest | MessagingSetting

            try
            { 
                // Set the organization's default setting that may be applied to to integrations without settings
                MessagingSetting result = apiInstance.PutConversationsMessagingSettingsDefault(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingSettingsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MessagingSettingDefaultRequest**](MessagingSettingDefaultRequest)| MessagingSetting |  |

### Return type

[**MessagingSetting**](MessagingSetting)


## PutConversationsMessagingSupportedcontentDefault

> [**SupportedContent**](SupportedContent) PutConversationsMessagingSupportedcontentDefault (SupportedContentReference body)


Set the organization's default supported content profile that may be assigned to an integration when it is created.

When an integration is created a supported content ID may be assigned to it. If the supported content ID is not supplied, the default supported content profile will be assigned to it.

Requires ALL permissions: 

* messaging:supportedContent:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingSupportedcontentDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new SupportedContentReference(); // SupportedContentReference | SupportedContent

            try
            { 
                // Set the organization's default supported content profile that may be assigned to an integration when it is created.
                SupportedContent result = apiInstance.PutConversationsMessagingSupportedcontentDefault(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingSupportedcontentDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SupportedContentReference**](SupportedContentReference)| SupportedContent |  |

### Return type

[**SupportedContent**](SupportedContent)


## PutConversationsMessagingThreadingtimeline

> [**ConversationThreadingWindow**](ConversationThreadingWindow) PutConversationsMessagingThreadingtimeline (ConversationThreadingWindow body)


Update conversation threading window timeline for each messaging type

PUT Conversation messaging threading timeline is intended to set the conversation threading settings for ALL messengerTypes. If you omit a messengerType in the request body then the setting for that messengerType will use the platform default value. The PUT replaces the existing setting(s) that were previously set for each messengerType.

Requires ALL permissions: 

* conversation:threadingTimeline:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingThreadingtimelineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new ConversationThreadingWindow(); // ConversationThreadingWindow | ConversationThreadingWindowRequest

            try
            { 
                // Update conversation threading window timeline for each messaging type
                ConversationThreadingWindow result = apiInstance.PutConversationsMessagingThreadingtimeline(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingThreadingtimeline: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationThreadingWindow**](ConversationThreadingWindow)| ConversationThreadingWindowRequest |  |

### Return type

[**ConversationThreadingWindow**](ConversationThreadingWindow)


## PutConversationsScreenshareRecordingstate

> **string** PutConversationsScreenshareRecordingstate (string conversationId, SetRecordingState body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update a conversation by setting its recording state

This endpoint is deprecated. Please see the article https://help.genesys.cloud/articles/deprecation-legacy-co-browse-and-screenshare/

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsScreenshareRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                string result = apiInstance.PutConversationsScreenshareRecordingstate(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsScreenshareRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

**string**


## PutConversationsSocialRecordingstate

> **string** PutConversationsSocialRecordingstate (string conversationId, SetRecordingState body)


Update a conversation by setting its recording state

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsSocialRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                string result = apiInstance.PutConversationsSocialRecordingstate(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsSocialRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

**string**


## PutConversationsVideoRecordingstate

> **string** PutConversationsVideoRecordingstate (string conversationId, SetRecordingState body)


Update a conversation by setting its recording state

Requires ANY permissions: 

* conversation:recording:pauseOthers

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsVideoRecordingstateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new SetRecordingState(); // SetRecordingState | SetRecordingState

            try
            { 
                // Update a conversation by setting its recording state
                string result = apiInstance.PutConversationsVideoRecordingstate(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsVideoRecordingstate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**SetRecordingState**](SetRecordingState)| SetRecordingState |  |

### Return type

**string**


_PureCloudPlatform.Client.V2 245.0.0_
