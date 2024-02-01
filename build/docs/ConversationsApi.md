---
title: ConversationsApi
---
## PureCloudPlatform.Client.V2.Api.ConversationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAnalyticsConversationsDetailsJob**](ConversationsApi.html#deleteanalyticsconversationsdetailsjob) | **Delete** /api/v2/analytics/conversations/details/jobs/{jobId} | Delete/cancel an async details job |
| [**DeleteConversationParticipantCode**](ConversationsApi.html#deleteconversationparticipantcode) | **Delete** /api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode} | Delete a code used to add a communication to this participant |
| [**DeleteConversationParticipantFlaggedreason**](ConversationsApi.html#deleteconversationparticipantflaggedreason) | **Delete** /api/v2/conversations/{conversationId}/participants/{participantId}/flaggedreason | Remove flagged reason from conversation participant. |
| [**DeleteConversationsCallParticipantConsult**](ConversationsApi.html#deleteconversationscallparticipantconsult) | **Delete** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Cancel the transfer |
| [**DeleteConversationsEmailMessagesDraftAttachment**](ConversationsApi.html#deleteconversationsemailmessagesdraftattachment) | **Delete** /api/v2/conversations/emails/{conversationId}/messages/draft/attachments/{attachmentId} | Delete attachment from draft |
| [**DeleteConversationsMessagesCachedmediaCachedMediaItemId**](ConversationsApi.html#deleteconversationsmessagescachedmediacachedmediaitemid) | **Delete** /api/v2/conversations/messages/cachedmedia/{cachedMediaItemId} | Remove a cached media item asychronously |
| [**DeleteConversationsMessagingIntegrationsFacebookIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationsfacebookintegrationid) | **Delete** /api/v2/conversations/messaging/integrations/facebook/{integrationId} | Delete a Facebook messaging integration |
| [**DeleteConversationsMessagingIntegrationsInstagramIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationsinstagramintegrationid) | **Delete** /api/v2/conversations/messaging/integrations/instagram/{integrationId} | Delete Instagram messaging integration |
| [**DeleteConversationsMessagingIntegrationsLineIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationslineintegrationid) | **Delete** /api/v2/conversations/messaging/integrations/line/{integrationId} | Delete a LINE messenger integration |
| [**DeleteConversationsMessagingIntegrationsOpenIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationsopenintegrationid) | **Delete** /api/v2/conversations/messaging/integrations/open/{integrationId} | Delete an Open messaging integration |
| [**DeleteConversationsMessagingIntegrationsTwitterIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationstwitterintegrationid) | **Delete** /api/v2/conversations/messaging/integrations/twitter/{integrationId} | Delete a Twitter messaging integration |
| [**DeleteConversationsMessagingIntegrationsWhatsappIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationswhatsappintegrationid) | **Delete** /api/v2/conversations/messaging/integrations/whatsapp/{integrationId} | Delete a WhatsApp messaging integration |
| [**DeleteConversationsMessagingSetting**](ConversationsApi.html#deleteconversationsmessagingsetting) | **Delete** /api/v2/conversations/messaging/settings/{messageSettingId} | Delete a messaging setting |
| [**DeleteConversationsMessagingSettingsDefault**](ConversationsApi.html#deleteconversationsmessagingsettingsdefault) | **Delete** /api/v2/conversations/messaging/settings/default | Delete the organization&#39;s default setting, a global default will be applied to integrations without settings |
| [**DeleteConversationsMessagingSupportedcontentSupportedContentId**](ConversationsApi.html#deleteconversationsmessagingsupportedcontentsupportedcontentid) | **Delete** /api/v2/conversations/messaging/supportedcontent/{supportedContentId} | Delete a supported content profile |
| [**GetAnalyticsConversationDetails**](ConversationsApi.html#getanalyticsconversationdetails) | **Get** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetAnalyticsConversationsAggregatesJob**](ConversationsApi.html#getanalyticsconversationsaggregatesjob) | **Get** /api/v2/analytics/conversations/aggregates/jobs/{jobId} | Get status for async query for conversation aggregates |
| [**GetAnalyticsConversationsAggregatesJobResults**](ConversationsApi.html#getanalyticsconversationsaggregatesjobresults) | **Get** /api/v2/analytics/conversations/aggregates/jobs/{jobId}/results | Fetch a page of results for an async aggregates query |
| [**GetAnalyticsConversationsDetails**](ConversationsApi.html#getanalyticsconversationsdetails) | **Get** /api/v2/analytics/conversations/details | Gets multiple conversations by id |
| [**GetAnalyticsConversationsDetailsJob**](ConversationsApi.html#getanalyticsconversationsdetailsjob) | **Get** /api/v2/analytics/conversations/details/jobs/{jobId} | Get status for async query for conversation details |
| [**GetAnalyticsConversationsDetailsJobResults**](ConversationsApi.html#getanalyticsconversationsdetailsjobresults) | **Get** /api/v2/analytics/conversations/details/jobs/{jobId}/results | Fetch a page of results for an async details job |
| [**GetAnalyticsConversationsDetailsJobsAvailability**](ConversationsApi.html#getanalyticsconversationsdetailsjobsavailability) | **Get** /api/v2/analytics/conversations/details/jobs/availability | Lookup the datalake availability date and time |
| [**GetConversation**](ConversationsApi.html#getconversation) | **Get** /api/v2/conversations/{conversationId} | Get conversation |
| [**GetConversationParticipantSecureivrsession**](ConversationsApi.html#getconversationparticipantsecureivrsession) | **Get** /api/v2/conversations/{conversationId}/participants/{participantId}/secureivrsessions/{secureSessionId} | Fetch info on a secure session |
| [**GetConversationParticipantSecureivrsessions**](ConversationsApi.html#getconversationparticipantsecureivrsessions) | **Get** /api/v2/conversations/{conversationId}/participants/{participantId}/secureivrsessions | Get a list of secure sessions for this participant. |
| [**GetConversationParticipantWrapup**](ConversationsApi.html#getconversationparticipantwrapup) | **Get** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationParticipantWrapupcodes**](ConversationsApi.html#getconversationparticipantwrapupcodes) | **Get** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationSecureattributes**](ConversationsApi.html#getconversationsecureattributes) | **Get** /api/v2/conversations/{conversationId}/secureattributes | Get the secure attributes on a conversation. |
| [**GetConversations**](ConversationsApi.html#getconversations) | **Get** /api/v2/conversations | Get active conversations for the logged in user |
| [**GetConversationsCall**](ConversationsApi.html#getconversationscall) | **Get** /api/v2/conversations/calls/{conversationId} | Get call conversation |
| [**GetConversationsCallParticipantCommunicationWrapup**](ConversationsApi.html#getconversationscallparticipantcommunicationwrapup) | **Get** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsCallParticipantWrapup**](ConversationsApi.html#getconversationscallparticipantwrapup) | **Get** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCallParticipantWrapupcodes**](ConversationsApi.html#getconversationscallparticipantwrapupcodes) | **Get** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCallback**](ConversationsApi.html#getconversationscallback) | **Get** /api/v2/conversations/callbacks/{conversationId} | Get callback conversation |
| [**GetConversationsCallbackParticipantCommunicationWrapup**](ConversationsApi.html#getconversationscallbackparticipantcommunicationwrapup) | **Get** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsCallbackParticipantWrapup**](ConversationsApi.html#getconversationscallbackparticipantwrapup) | **Get** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCallbackParticipantWrapupcodes**](ConversationsApi.html#getconversationscallbackparticipantwrapupcodes) | **Get** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCallbacks**](ConversationsApi.html#getconversationscallbacks) | **Get** /api/v2/conversations/callbacks | Get active callback conversations for the logged in user |
| [**GetConversationsCalls**](ConversationsApi.html#getconversationscalls) | **Get** /api/v2/conversations/calls | Get active call conversations for the logged in user |
| [**GetConversationsCallsHistory**](ConversationsApi.html#getconversationscallshistory) | **Get** /api/v2/conversations/calls/history | Get call history |
| [**GetConversationsCallsMaximumconferenceparties**](ConversationsApi.html#getconversationscallsmaximumconferenceparties) | **Get** /api/v2/conversations/calls/maximumconferenceparties | Get the maximum number of participants that this user can have on a conference |
| [**GetConversationsChat**](ConversationsApi.html#getconversationschat) | **Get** /api/v2/conversations/chats/{conversationId} | Get chat conversation |
| [**GetConversationsChatMessage**](ConversationsApi.html#getconversationschatmessage) | **Get** /api/v2/conversations/chats/{conversationId}/messages/{messageId} | Get a web chat conversation message |
| [**GetConversationsChatMessages**](ConversationsApi.html#getconversationschatmessages) | **Get** /api/v2/conversations/chats/{conversationId}/messages | Get the messages of a chat conversation. |
| [**GetConversationsChatParticipantCommunicationWrapup**](ConversationsApi.html#getconversationschatparticipantcommunicationwrapup) | **Get** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsChatParticipantWrapup**](ConversationsApi.html#getconversationschatparticipantwrapup) | **Get** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsChatParticipantWrapupcodes**](ConversationsApi.html#getconversationschatparticipantwrapupcodes) | **Get** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsChats**](ConversationsApi.html#getconversationschats) | **Get** /api/v2/conversations/chats | Get active chat conversations for the logged in user |
| [**GetConversationsCobrowsesession**](ConversationsApi.html#getconversationscobrowsesession) | **Get** /api/v2/conversations/cobrowsesessions/{conversationId} | Get cobrowse conversation |
| [**GetConversationsCobrowsesessionParticipantCommunicationWrapup**](ConversationsApi.html#getconversationscobrowsesessionparticipantcommunicationwrapup) | **Get** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsCobrowsesessionParticipantWrapup**](ConversationsApi.html#getconversationscobrowsesessionparticipantwrapup) | **Get** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCobrowsesessionParticipantWrapupcodes**](ConversationsApi.html#getconversationscobrowsesessionparticipantwrapupcodes) | **Get** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCobrowsesessions**](ConversationsApi.html#getconversationscobrowsesessions) | **Get** /api/v2/conversations/cobrowsesessions | Get active cobrowse conversations for the logged in user |
| [**GetConversationsEmail**](ConversationsApi.html#getconversationsemail) | **Get** /api/v2/conversations/emails/{conversationId} | Get email conversation |
| [**GetConversationsEmailMessage**](ConversationsApi.html#getconversationsemailmessage) | **Get** /api/v2/conversations/emails/{conversationId}/messages/{messageId} | Get conversation message |
| [**GetConversationsEmailMessages**](ConversationsApi.html#getconversationsemailmessages) | **Get** /api/v2/conversations/emails/{conversationId}/messages | Get conversation messages |
| [**GetConversationsEmailMessagesDraft**](ConversationsApi.html#getconversationsemailmessagesdraft) | **Get** /api/v2/conversations/emails/{conversationId}/messages/draft | Get conversation draft reply |
| [**GetConversationsEmailParticipantCommunicationWrapup**](ConversationsApi.html#getconversationsemailparticipantcommunicationwrapup) | **Get** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsEmailParticipantWrapup**](ConversationsApi.html#getconversationsemailparticipantwrapup) | **Get** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsEmailParticipantWrapupcodes**](ConversationsApi.html#getconversationsemailparticipantwrapupcodes) | **Get** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsEmailSettings**](ConversationsApi.html#getconversationsemailsettings) | **Get** /api/v2/conversations/emails/{conversationId}/settings | Get emails settings for a given conversation |
| [**GetConversationsEmails**](ConversationsApi.html#getconversationsemails) | **Get** /api/v2/conversations/emails | Get active email conversations for the logged in user |
| [**GetConversationsKeyconfiguration**](ConversationsApi.html#getconversationskeyconfiguration) | **Get** /api/v2/conversations/keyconfigurations/{keyconfigurationsId} | Get the encryption key configurations |
| [**GetConversationsKeyconfigurations**](ConversationsApi.html#getconversationskeyconfigurations) | **Get** /api/v2/conversations/keyconfigurations | Get a list of key configurations data |
| [**GetConversationsMessage**](ConversationsApi.html#getconversationsmessage) | **Get** /api/v2/conversations/messages/{conversationId} | Get message conversation |
| [**GetConversationsMessageCommunicationMessagesMediaMediaId**](ConversationsApi.html#getconversationsmessagecommunicationmessagesmediamediaid) | **Get** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages/media/{mediaId} | Get media |
| [**GetConversationsMessageDetails**](ConversationsApi.html#getconversationsmessagedetails) | **Get** /api/v2/conversations/messages/{messageId}/details | Get message |
| [**GetConversationsMessageMessage**](ConversationsApi.html#getconversationsmessagemessage) | **Get** /api/v2/conversations/messages/{conversationId}/messages/{messageId} | Get conversation message |
| [**GetConversationsMessageParticipantCommunicationWrapup**](ConversationsApi.html#getconversationsmessageparticipantcommunicationwrapup) | **Get** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsMessageParticipantWrapup**](ConversationsApi.html#getconversationsmessageparticipantwrapup) | **Get** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsMessageParticipantWrapupcodes**](ConversationsApi.html#getconversationsmessageparticipantwrapupcodes) | **Get** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsMessages**](ConversationsApi.html#getconversationsmessages) | **Get** /api/v2/conversations/messages | Get active message conversations for the logged in user |
| [**GetConversationsMessagesCachedmedia**](ConversationsApi.html#getconversationsmessagescachedmedia) | **Get** /api/v2/conversations/messages/cachedmedia | Get a list of cached media items |
| [**GetConversationsMessagesCachedmediaCachedMediaItemId**](ConversationsApi.html#getconversationsmessagescachedmediacachedmediaitemid) | **Get** /api/v2/conversations/messages/cachedmedia/{cachedMediaItemId} | Get a cached media item |
| [**GetConversationsMessagingFacebookApp**](ConversationsApi.html#getconversationsmessagingfacebookapp) | **Get** /api/v2/conversations/messaging/facebook/app | Get Genesys Facebook App Id |
| [**GetConversationsMessagingIntegrations**](ConversationsApi.html#getconversationsmessagingintegrations) | **Get** /api/v2/conversations/messaging/integrations | Get a list of Integrations |
| [**GetConversationsMessagingIntegrationsFacebook**](ConversationsApi.html#getconversationsmessagingintegrationsfacebook) | **Get** /api/v2/conversations/messaging/integrations/facebook | Get a list of Facebook Integrations |
| [**GetConversationsMessagingIntegrationsFacebookIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationsfacebookintegrationid) | **Get** /api/v2/conversations/messaging/integrations/facebook/{integrationId} | Get a Facebook messaging integration |
| [**GetConversationsMessagingIntegrationsInstagram**](ConversationsApi.html#getconversationsmessagingintegrationsinstagram) | **Get** /api/v2/conversations/messaging/integrations/instagram | Get a list of Instagram Integrations |
| [**GetConversationsMessagingIntegrationsInstagramIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationsinstagramintegrationid) | **Get** /api/v2/conversations/messaging/integrations/instagram/{integrationId} | Get Instagram messaging integration |
| [**GetConversationsMessagingIntegrationsLine**](ConversationsApi.html#getconversationsmessagingintegrationsline) | **Get** /api/v2/conversations/messaging/integrations/line | Get a list of LINE messenger Integrations |
| [**GetConversationsMessagingIntegrationsLineIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationslineintegrationid) | **Get** /api/v2/conversations/messaging/integrations/line/{integrationId} | Get a LINE messenger integration |
| [**GetConversationsMessagingIntegrationsOpen**](ConversationsApi.html#getconversationsmessagingintegrationsopen) | **Get** /api/v2/conversations/messaging/integrations/open | Get a list of Open messaging integrations |
| [**GetConversationsMessagingIntegrationsOpenIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationsopenintegrationid) | **Get** /api/v2/conversations/messaging/integrations/open/{integrationId} | Get an Open messaging integration |
| [**GetConversationsMessagingIntegrationsTwitter**](ConversationsApi.html#getconversationsmessagingintegrationstwitter) | **Get** /api/v2/conversations/messaging/integrations/twitter | Get a list of Twitter Integrations |
| [**GetConversationsMessagingIntegrationsTwitterIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationstwitterintegrationid) | **Get** /api/v2/conversations/messaging/integrations/twitter/{integrationId} | Get a Twitter messaging integration |
| [**GetConversationsMessagingIntegrationsWhatsapp**](ConversationsApi.html#getconversationsmessagingintegrationswhatsapp) | **Get** /api/v2/conversations/messaging/integrations/whatsapp | Get a list of WhatsApp Integrations |
| [**GetConversationsMessagingIntegrationsWhatsappIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationswhatsappintegrationid) | **Get** /api/v2/conversations/messaging/integrations/whatsapp/{integrationId} | Get a WhatsApp messaging integration |
| [**GetConversationsMessagingSetting**](ConversationsApi.html#getconversationsmessagingsetting) | **Get** /api/v2/conversations/messaging/settings/{messageSettingId} | Get a messaging setting |
| [**GetConversationsMessagingSettings**](ConversationsApi.html#getconversationsmessagingsettings) | **Get** /api/v2/conversations/messaging/settings | Get a list of messaging settings |
| [**GetConversationsMessagingSettingsDefault**](ConversationsApi.html#getconversationsmessagingsettingsdefault) | **Get** /api/v2/conversations/messaging/settings/default | Get the organization&#39;s default settings that will be used as the default when creating an integration. |
| [**GetConversationsMessagingSticker**](ConversationsApi.html#getconversationsmessagingsticker) | **Get** /api/v2/conversations/messaging/stickers/{messengerType} | Get a list of Messaging Stickers |
| [**GetConversationsMessagingSupportedcontent**](ConversationsApi.html#getconversationsmessagingsupportedcontent) | **Get** /api/v2/conversations/messaging/supportedcontent | Get a list of Supported Content profiles |
| [**GetConversationsMessagingSupportedcontentDefault**](ConversationsApi.html#getconversationsmessagingsupportedcontentdefault) | **Get** /api/v2/conversations/messaging/supportedcontent/default | Get the organization&#39;s default supported content profile that will be used as the default when creating an integration. |
| [**GetConversationsMessagingSupportedcontentSupportedContentId**](ConversationsApi.html#getconversationsmessagingsupportedcontentsupportedcontentid) | **Get** /api/v2/conversations/messaging/supportedcontent/{supportedContentId} | Get a supported content profile |
| [**GetConversationsMessagingThreadingtimeline**](ConversationsApi.html#getconversationsmessagingthreadingtimeline) | **Get** /api/v2/conversations/messaging/threadingtimeline | Get conversation threading window timeline for each messaging type |
| [**GetConversationsScreenshareParticipantCommunicationWrapup**](ConversationsApi.html#getconversationsscreenshareparticipantcommunicationwrapup) | **Get** /api/v2/conversations/screenshares/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsSettings**](ConversationsApi.html#getconversationssettings) | **Get** /api/v2/conversations/settings | Get Settings |
| [**GetConversationsSocialParticipantCommunicationWrapup**](ConversationsApi.html#getconversationssocialparticipantcommunicationwrapup) | **Get** /api/v2/conversations/socials/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsVideoDetails**](ConversationsApi.html#getconversationsvideodetails) | **Get** /api/v2/conversations/videos/{conferenceId}/details | Get video conference details (e.g. the current number of active participants). |
| [**GetConversationsVideoParticipantCommunicationWrapup**](ConversationsApi.html#getconversationsvideoparticipantcommunicationwrapup) | **Get** /api/v2/conversations/videos/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Get the wrap-up for this conversation communication.  |
| [**GetConversationsVideosMeeting**](ConversationsApi.html#getconversationsvideosmeeting) | **Get** /api/v2/conversations/videos/meetings/{meetingId} | Gets a record for a given meetingId |
| [**PatchConversationParticipant**](ConversationsApi.html#patchconversationparticipant) | **Patch** /api/v2/conversations/{conversationId}/participants/{participantId} | Update a participant. |
| [**PatchConversationParticipantAttributes**](ConversationsApi.html#patchconversationparticipantattributes) | **Patch** /api/v2/conversations/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationSecureattributes**](ConversationsApi.html#patchconversationsecureattributes) | **Patch** /api/v2/conversations/{conversationId}/secureattributes | Update the secure attributes on a conversation. |
| [**PatchConversationsAftercallworkConversationIdParticipantCommunication**](ConversationsApi.html#patchconversationsaftercallworkconversationidparticipantcommunication) | **Patch** /api/v2/conversations/aftercallwork/{conversationId}/participants/{participantId}/communications/{communicationId} | Update after-call work for this conversation communication. |
| [**PatchConversationsCall**](ConversationsApi.html#patchconversationscall) | **Patch** /api/v2/conversations/calls/{conversationId} | Update a conversation by setting its recording state, merging in other conversations to create a conference, or disconnecting all of the participants |
| [**PatchConversationsCallParticipant**](ConversationsApi.html#patchconversationscallparticipant) | **Patch** /api/v2/conversations/calls/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCallParticipantAttributes**](ConversationsApi.html#patchconversationscallparticipantattributes) | **Patch** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCallParticipantCommunication**](ConversationsApi.html#patchconversationscallparticipantcommunication) | **Patch** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsCallParticipantConsult**](ConversationsApi.html#patchconversationscallparticipantconsult) | **Patch** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Change who can speak |
| [**PatchConversationsCallback**](ConversationsApi.html#patchconversationscallback) | **Patch** /api/v2/conversations/callbacks/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsCallbackParticipant**](ConversationsApi.html#patchconversationscallbackparticipant) | **Patch** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCallbackParticipantAttributes**](ConversationsApi.html#patchconversationscallbackparticipantattributes) | **Patch** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCallbackParticipantCommunication**](ConversationsApi.html#patchconversationscallbackparticipantcommunication) | **Patch** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsCallbacks**](ConversationsApi.html#patchconversationscallbacks) | **Patch** /api/v2/conversations/callbacks | Update a scheduled callback |
| [**PatchConversationsChat**](ConversationsApi.html#patchconversationschat) | **Patch** /api/v2/conversations/chats/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsChatParticipant**](ConversationsApi.html#patchconversationschatparticipant) | **Patch** /api/v2/conversations/chats/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsChatParticipantAttributes**](ConversationsApi.html#patchconversationschatparticipantattributes) | **Patch** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsChatParticipantCommunication**](ConversationsApi.html#patchconversationschatparticipantcommunication) | **Patch** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsCobrowsesession**](ConversationsApi.html#patchconversationscobrowsesession) | **Patch** /api/v2/conversations/cobrowsesessions/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsCobrowsesessionParticipant**](ConversationsApi.html#patchconversationscobrowsesessionparticipant) | **Patch** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCobrowsesessionParticipantAttributes**](ConversationsApi.html#patchconversationscobrowsesessionparticipantattributes) | **Patch** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCobrowsesessionParticipantCommunication**](ConversationsApi.html#patchconversationscobrowsesessionparticipantcommunication) | **Patch** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsEmail**](ConversationsApi.html#patchconversationsemail) | **Patch** /api/v2/conversations/emails/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsEmailMessagesDraft**](ConversationsApi.html#patchconversationsemailmessagesdraft) | **Patch** /api/v2/conversations/emails/{conversationId}/messages/draft | Reset conversation draft to its initial state and/or auto-fill draft content |
| [**PatchConversationsEmailParticipant**](ConversationsApi.html#patchconversationsemailparticipant) | **Patch** /api/v2/conversations/emails/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsEmailParticipantAttributes**](ConversationsApi.html#patchconversationsemailparticipantattributes) | **Patch** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsEmailParticipantCommunication**](ConversationsApi.html#patchconversationsemailparticipantcommunication) | **Patch** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsMessage**](ConversationsApi.html#patchconversationsmessage) | **Patch** /api/v2/conversations/messages/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsMessageParticipant**](ConversationsApi.html#patchconversationsmessageparticipant) | **Patch** /api/v2/conversations/messages/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsMessageParticipantAttributes**](ConversationsApi.html#patchconversationsmessageparticipantattributes) | **Patch** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsMessageParticipantCommunication**](ConversationsApi.html#patchconversationsmessageparticipantcommunication) | **Patch** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsMessagingIntegrationsFacebookIntegrationId**](ConversationsApi.html#patchconversationsmessagingintegrationsfacebookintegrationid) | **Patch** /api/v2/conversations/messaging/integrations/facebook/{integrationId} | Update Facebook messaging integration |
| [**PatchConversationsMessagingIntegrationsInstagramIntegrationId**](ConversationsApi.html#patchconversationsmessagingintegrationsinstagramintegrationid) | **Patch** /api/v2/conversations/messaging/integrations/instagram/{integrationId} | Update Instagram messaging integration |
| [**PatchConversationsMessagingIntegrationsOpenIntegrationId**](ConversationsApi.html#patchconversationsmessagingintegrationsopenintegrationid) | **Patch** /api/v2/conversations/messaging/integrations/open/{integrationId} | Update an Open messaging integration |
| [**PatchConversationsMessagingIntegrationsTwitterIntegrationId**](ConversationsApi.html#patchconversationsmessagingintegrationstwitterintegrationid) | **Patch** /api/v2/conversations/messaging/integrations/twitter/{integrationId} | Update Twitter messaging integration |
| [**PatchConversationsMessagingIntegrationsWhatsappEmbeddedsignupIntegrationId**](ConversationsApi.html#patchconversationsmessagingintegrationswhatsappembeddedsignupintegrationid) | **Patch** /api/v2/conversations/messaging/integrations/whatsapp/embeddedsignup/{integrationId} | Activate a WhatsApp messaging integration created using the WhatsApp embedded signup flow |
| [**PatchConversationsMessagingIntegrationsWhatsappIntegrationId**](ConversationsApi.html#patchconversationsmessagingintegrationswhatsappintegrationid) | **Patch** /api/v2/conversations/messaging/integrations/whatsapp/{integrationId} | Update or activate a WhatsApp messaging integration |
| [**PatchConversationsMessagingSetting**](ConversationsApi.html#patchconversationsmessagingsetting) | **Patch** /api/v2/conversations/messaging/settings/{messageSettingId} | Update a messaging setting |
| [**PatchConversationsMessagingSupportedcontentSupportedContentId**](ConversationsApi.html#patchconversationsmessagingsupportedcontentsupportedcontentid) | **Patch** /api/v2/conversations/messaging/supportedcontent/{supportedContentId} | Update a supported content profile |
| [**PatchConversationsSettings**](ConversationsApi.html#patchconversationssettings) | **Patch** /api/v2/conversations/settings | Update Settings |
| [**PostAnalyticsConversationDetailsProperties**](ConversationsApi.html#postanalyticsconversationdetailsproperties) | **Post** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostAnalyticsConversationsActivityQuery**](ConversationsApi.html#postanalyticsconversationsactivityquery) | **Post** /api/v2/analytics/conversations/activity/query | Query for conversation activity observations |
| [**PostAnalyticsConversationsAggregatesJobs**](ConversationsApi.html#postanalyticsconversationsaggregatesjobs) | **Post** /api/v2/analytics/conversations/aggregates/jobs | Query for conversation aggregates asynchronously |
| [**PostAnalyticsConversationsAggregatesQuery**](ConversationsApi.html#postanalyticsconversationsaggregatesquery) | **Post** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostAnalyticsConversationsDetailsJobs**](ConversationsApi.html#postanalyticsconversationsdetailsjobs) | **Post** /api/v2/analytics/conversations/details/jobs | Query for conversation details asynchronously |
| [**PostAnalyticsConversationsDetailsQuery**](ConversationsApi.html#postanalyticsconversationsdetailsquery) | **Post** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostConversationAssign**](ConversationsApi.html#postconversationassign) | **Post** /api/v2/conversations/{conversationId}/assign | Attempts to manually assign a specified conversation to a specified user.  Ignores bullseye ring, PAR score, skills, and languages. |
| [**PostConversationBarge**](ConversationsApi.html#postconversationbarge) | **Post** /api/v2/conversations/{conversationId}/barge | Barge a conversation creating a barged in conference of connected participants. |
| [**PostConversationCobrowse**](ConversationsApi.html#postconversationcobrowse) | **Post** /api/v2/conversations/{conversationId}/cobrowse | Creates a cobrowse session. Requires \&quot;conversation:cobrowse:add\&quot; (for web messaging) or \&quot;conversation:cobrowsevoice:add\&quot; permission. |
| [**PostConversationDisconnect**](ConversationsApi.html#postconversationdisconnect) | **Post** /api/v2/conversations/{conversationId}/disconnect | Performs a full conversation teardown. Issues disconnect requests for any connected media. Applies a system wrap-up code to any participants that are pending wrap-up. This is not intended to be the normal way of ending interactions but is available in the event of problems with the application to allow a resynchronization of state across all components. It is recommended that users submit a support case if they are relying on this endpoint systematically as there is likely something that needs investigation. |
| [**PostConversationParticipantCallbacks**](ConversationsApi.html#postconversationparticipantcallbacks) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/callbacks | Create a new callback for the specified participant on the conversation. |
| [**PostConversationParticipantDigits**](ConversationsApi.html#postconversationparticipantdigits) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/digits | Sends DTMF to the participant |
| [**PostConversationParticipantReplace**](ConversationsApi.html#postconversationparticipantreplace) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationParticipantReplaceAgent**](ConversationsApi.html#postconversationparticipantreplaceagent) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/replace/agent | Replace this participant with the specified agent |
| [**PostConversationParticipantReplaceExternal**](ConversationsApi.html#postconversationparticipantreplaceexternal) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/replace/external | Replace this participant with the an external contact |
| [**PostConversationParticipantReplaceQueue**](ConversationsApi.html#postconversationparticipantreplacequeue) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/replace/queue | Replace this participant with the specified queue |
| [**PostConversationParticipantSecureivrsessions**](ConversationsApi.html#postconversationparticipantsecureivrsessions) | **Post** /api/v2/conversations/{conversationId}/participants/{participantId}/secureivrsessions | Create secure IVR session. Only a participant in the conversation can invoke a secure IVR. |
| [**PostConversationSummaryFeedback**](ConversationsApi.html#postconversationsummaryfeedback) | **Post** /api/v2/conversations/{conversationId}/summaries/{summaryId}/feedback | Submit feedback for the summary. |
| [**PostConversationsCall**](ConversationsApi.html#postconversationscall) | **Post** /api/v2/conversations/calls/{conversationId} | Place a new call as part of a callback conversation. |
| [**PostConversationsCallParticipantBarge**](ConversationsApi.html#postconversationscallparticipantbarge) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/barge | Barge a given participant&#39;s call creating a barged in conference of connected participants. |
| [**PostConversationsCallParticipantCoach**](ConversationsApi.html#postconversationscallparticipantcoach) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/coach | Listen in on the conversation from the point of view of a given participant while speaking to just the given participant. |
| [**PostConversationsCallParticipantCommunicationWrapup**](ConversationsApi.html#postconversationscallparticipantcommunicationwrapup) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsCallParticipantConsult**](ConversationsApi.html#postconversationscallparticipantconsult) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Initiate and update consult transfer |
| [**PostConversationsCallParticipantConsultAgent**](ConversationsApi.html#postconversationscallparticipantconsultagent) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult/agent | Initiate a consult transfer to an agent |
| [**PostConversationsCallParticipantConsultExternal**](ConversationsApi.html#postconversationscallparticipantconsultexternal) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult/external | Initiate a consult transfer to an external contact |
| [**PostConversationsCallParticipantConsultQueue**](ConversationsApi.html#postconversationscallparticipantconsultqueue) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult/queue | Initiate a consult transfer to a queue |
| [**PostConversationsCallParticipantMonitor**](ConversationsApi.html#postconversationscallparticipantmonitor) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**PostConversationsCallParticipantReplace**](ConversationsApi.html#postconversationscallparticipantreplace) | **Post** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsCallParticipants**](ConversationsApi.html#postconversationscallparticipants) | **Post** /api/v2/conversations/calls/{conversationId}/participants | Add participants to a conversation |
| [**PostConversationsCallbackParticipantCommunicationWrapup**](ConversationsApi.html#postconversationscallbackparticipantcommunicationwrapup) | **Post** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsCallbackParticipantReplace**](ConversationsApi.html#postconversationscallbackparticipantreplace) | **Post** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsCallbacks**](ConversationsApi.html#postconversationscallbacks) | **Post** /api/v2/conversations/callbacks | Create a Callback |
| [**PostConversationsCallbacksBulkDisconnect**](ConversationsApi.html#postconversationscallbacksbulkdisconnect) | **Post** /api/v2/conversations/callbacks/bulk/disconnect | Disconnect multiple scheduled callbacks |
| [**PostConversationsCallbacksBulkUpdate**](ConversationsApi.html#postconversationscallbacksbulkupdate) | **Post** /api/v2/conversations/callbacks/bulk/update | Update multiple scheduled callbacks |
| [**PostConversationsCalls**](ConversationsApi.html#postconversationscalls) | **Post** /api/v2/conversations/calls | Create a call conversation |
| [**PostConversationsChatCommunicationMessages**](ConversationsApi.html#postconversationschatcommunicationmessages) | **Post** /api/v2/conversations/chats/{conversationId}/communications/{communicationId}/messages | Send a message on behalf of a communication in a chat conversation. |
| [**PostConversationsChatCommunicationTyping**](ConversationsApi.html#postconversationschatcommunicationtyping) | **Post** /api/v2/conversations/chats/{conversationId}/communications/{communicationId}/typing | Send a typing-indicator on behalf of a communication in a chat conversation. |
| [**PostConversationsChatParticipantCommunicationWrapup**](ConversationsApi.html#postconversationschatparticipantcommunicationwrapup) | **Post** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsChatParticipantReplace**](ConversationsApi.html#postconversationschatparticipantreplace) | **Post** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsChats**](ConversationsApi.html#postconversationschats) | **Post** /api/v2/conversations/chats | Create a web chat conversation |
| [**PostConversationsCobrowsesessionParticipantCommunicationWrapup**](ConversationsApi.html#postconversationscobrowsesessionparticipantcommunicationwrapup) | **Post** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsCobrowsesessionParticipantReplace**](ConversationsApi.html#postconversationscobrowsesessionparticipantreplace) | **Post** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsEmailInboundmessages**](ConversationsApi.html#postconversationsemailinboundmessages) | **Post** /api/v2/conversations/emails/{conversationId}/inboundmessages | Send an email to an external conversation. An external conversation is one where the provider is not PureCloud based. This endpoint allows the sender of the external email to reply or send a new message to the existing conversation. The new message will be treated as part of the existing conversation and chained to it. |
| [**PostConversationsEmailMessages**](ConversationsApi.html#postconversationsemailmessages) | **Post** /api/v2/conversations/emails/{conversationId}/messages | Send an email reply |
| [**PostConversationsEmailMessagesDraftAttachmentsCopy**](ConversationsApi.html#postconversationsemailmessagesdraftattachmentscopy) | **Post** /api/v2/conversations/emails/{conversationId}/messages/draft/attachments/copy | Copy attachments from an email message to the current draft. |
| [**PostConversationsEmailParticipantCommunicationWrapup**](ConversationsApi.html#postconversationsemailparticipantcommunicationwrapup) | **Post** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsEmailParticipantReplace**](ConversationsApi.html#postconversationsemailparticipantreplace) | **Post** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsEmails**](ConversationsApi.html#postconversationsemails) | **Post** /api/v2/conversations/emails | Create an email conversation |
| [**PostConversationsEmailsAgentless**](ConversationsApi.html#postconversationsemailsagentless) | **Post** /api/v2/conversations/emails/agentless | Create an email conversation, per API |
| [**PostConversationsFaxes**](ConversationsApi.html#postconversationsfaxes) | **Post** /api/v2/conversations/faxes | Create Fax Conversation |
| [**PostConversationsKeyconfigurations**](ConversationsApi.html#postconversationskeyconfigurations) | **Post** /api/v2/conversations/keyconfigurations | Setup configurations for encryption key creation |
| [**PostConversationsKeyconfigurationsValidate**](ConversationsApi.html#postconversationskeyconfigurationsvalidate) | **Post** /api/v2/conversations/keyconfigurations/validate | Validate encryption key configurations without saving it |
| [**PostConversationsMessageCommunicationMessages**](ConversationsApi.html#postconversationsmessagecommunicationmessages) | **Post** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages | Send message |
| [**PostConversationsMessageCommunicationMessagesMedia**](ConversationsApi.html#postconversationsmessagecommunicationmessagesmedia) | **Post** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages/media | Create media |
| [**PostConversationsMessageCommunicationTyping**](ConversationsApi.html#postconversationsmessagecommunicationtyping) | **Post** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/typing | Send message typing event |
| [**PostConversationsMessageInboundOpenEvent**](ConversationsApi.html#postconversationsmessageinboundopenevent) | **Post** /api/v2/conversations/messages/{integrationId}/inbound/open/event | Send an inbound Open Event Message |
| [**PostConversationsMessageInboundOpenMessage**](ConversationsApi.html#postconversationsmessageinboundopenmessage) | **Post** /api/v2/conversations/messages/{integrationId}/inbound/open/message | Send inbound Open Message |
| [**PostConversationsMessageInboundOpenReceipt**](ConversationsApi.html#postconversationsmessageinboundopenreceipt) | **Post** /api/v2/conversations/messages/{integrationId}/inbound/open/receipt | Send an inbound Open Receipt Message |
| [**PostConversationsMessageMessagesBulk**](ConversationsApi.html#postconversationsmessagemessagesbulk) | **Post** /api/v2/conversations/messages/{conversationId}/messages/bulk | Get messages in batch |
| [**PostConversationsMessageParticipantCommunicationWrapup**](ConversationsApi.html#postconversationsmessageparticipantcommunicationwrapup) | **Post** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsMessageParticipantMonitor**](ConversationsApi.html#postconversationsmessageparticipantmonitor) | **Post** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**PostConversationsMessageParticipantReplace**](ConversationsApi.html#postconversationsmessageparticipantreplace) | **Post** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsMessages**](ConversationsApi.html#postconversationsmessages) | **Post** /api/v2/conversations/messages | Create an outbound messaging conversation. |
| [**PostConversationsMessagesAgentless**](ConversationsApi.html#postconversationsmessagesagentless) | **Post** /api/v2/conversations/messages/agentless | Send an agentless outbound message |
| [**PostConversationsMessagesInboundOpen**](ConversationsApi.html#postconversationsmessagesinboundopen) | **Post** /api/v2/conversations/messages/inbound/open | Send an inbound Open Message |
| [**PostConversationsMessagingIntegrationsFacebook**](ConversationsApi.html#postconversationsmessagingintegrationsfacebook) | **Post** /api/v2/conversations/messaging/integrations/facebook | Create a Facebook Integration |
| [**PostConversationsMessagingIntegrationsInstagram**](ConversationsApi.html#postconversationsmessagingintegrationsinstagram) | **Post** /api/v2/conversations/messaging/integrations/instagram | Create Instagram Integration |
| [**PostConversationsMessagingIntegrationsLine**](ConversationsApi.html#postconversationsmessagingintegrationsline) | **Post** /api/v2/conversations/messaging/integrations/line | Create a LINE messenger Integration (Deprecated) |
| [**PostConversationsMessagingIntegrationsOpen**](ConversationsApi.html#postconversationsmessagingintegrationsopen) | **Post** /api/v2/conversations/messaging/integrations/open | Create an Open messaging integration |
| [**PostConversationsMessagingIntegrationsTwitter**](ConversationsApi.html#postconversationsmessagingintegrationstwitter) | **Post** /api/v2/conversations/messaging/integrations/twitter | Create a Twitter Integration |
| [**PostConversationsMessagingIntegrationsWhatsapp**](ConversationsApi.html#postconversationsmessagingintegrationswhatsapp) | **Post** /api/v2/conversations/messaging/integrations/whatsapp | [This API is deprecated. Use POST /api/v2/conversations/messaging/integrations/whatsapp/embeddedsignup instead] Create a WhatsApp Integration |
| [**PostConversationsMessagingIntegrationsWhatsappEmbeddedsignup**](ConversationsApi.html#postconversationsmessagingintegrationswhatsappembeddedsignup) | **Post** /api/v2/conversations/messaging/integrations/whatsapp/embeddedsignup | Create a WhatsApp Integration using the WhatsApp embedded signup flow |
| [**PostConversationsMessagingSettings**](ConversationsApi.html#postconversationsmessagingsettings) | **Post** /api/v2/conversations/messaging/settings | Create a messaging setting |
| [**PostConversationsMessagingSupportedcontent**](ConversationsApi.html#postconversationsmessagingsupportedcontent) | **Post** /api/v2/conversations/messaging/supportedcontent | Create a Supported Content profile |
| [**PostConversationsParticipantsAttributesSearch**](ConversationsApi.html#postconversationsparticipantsattributessearch) | **Post** /api/v2/conversations/participants/attributes/search | Search conversations |
| [**PostConversationsScreenshareParticipantCommunicationWrapup**](ConversationsApi.html#postconversationsscreenshareparticipantcommunicationwrapup) | **Post** /api/v2/conversations/screenshares/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsSocialParticipantCommunicationWrapup**](ConversationsApi.html#postconversationssocialparticipantcommunicationwrapup) | **Post** /api/v2/conversations/socials/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsVideoParticipantCommunicationWrapup**](ConversationsApi.html#postconversationsvideoparticipantcommunicationwrapup) | **Post** /api/v2/conversations/videos/{conversationId}/participants/{participantId}/communications/{communicationId}/wrapup | Apply wrap-up for this conversation communication |
| [**PostConversationsVideosMeetings**](ConversationsApi.html#postconversationsvideosmeetings) | **Post** /api/v2/conversations/videos/meetings | Generate a meetingId for a given conferenceId |
| [**PutConversationParticipantFlaggedreason**](ConversationsApi.html#putconversationparticipantflaggedreason) | **Put** /api/v2/conversations/{conversationId}/participants/{participantId}/flaggedreason | Set flagged reason on conversation participant to indicate bad conversation quality. |
| [**PutConversationSecureattributes**](ConversationsApi.html#putconversationsecureattributes) | **Put** /api/v2/conversations/{conversationId}/secureattributes | Set the secure attributes on a conversation. |
| [**PutConversationTags**](ConversationsApi.html#putconversationtags) | **Put** /api/v2/conversations/{conversationId}/tags | Update the tags on a conversation. |
| [**PutConversationsCallParticipantCommunicationUuidata**](ConversationsApi.html#putconversationscallparticipantcommunicationuuidata) | **Put** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId}/uuidata | Set uuiData to be sent on future commands. |
| [**PutConversationsCallRecordingstate**](ConversationsApi.html#putconversationscallrecordingstate) | **Put** /api/v2/conversations/calls/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsCallbackRecordingstate**](ConversationsApi.html#putconversationscallbackrecordingstate) | **Put** /api/v2/conversations/callbacks/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsChatRecordingstate**](ConversationsApi.html#putconversationschatrecordingstate) | **Put** /api/v2/conversations/chats/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsCobrowsesessionRecordingstate**](ConversationsApi.html#putconversationscobrowsesessionrecordingstate) | **Put** /api/v2/conversations/cobrowsesessions/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsEmailMessagesDraft**](ConversationsApi.html#putconversationsemailmessagesdraft) | **Put** /api/v2/conversations/emails/{conversationId}/messages/draft | Update conversation draft reply |
| [**PutConversationsEmailRecordingstate**](ConversationsApi.html#putconversationsemailrecordingstate) | **Put** /api/v2/conversations/emails/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsKeyconfiguration**](ConversationsApi.html#putconversationskeyconfiguration) | **Put** /api/v2/conversations/keyconfigurations/{keyconfigurationsId} | Update the encryption key configurations |
| [**PutConversationsMessageRecordingstate**](ConversationsApi.html#putconversationsmessagerecordingstate) | **Put** /api/v2/conversations/messages/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsMessagingIntegrationsLineIntegrationId**](ConversationsApi.html#putconversationsmessagingintegrationslineintegrationid) | **Put** /api/v2/conversations/messaging/integrations/line/{integrationId} | Update a LINE messenger integration |
| [**PutConversationsMessagingSettingsDefault**](ConversationsApi.html#putconversationsmessagingsettingsdefault) | **Put** /api/v2/conversations/messaging/settings/default | Set the organization&#39;s default setting that may be applied to to integrations without settings |
| [**PutConversationsMessagingSupportedcontentDefault**](ConversationsApi.html#putconversationsmessagingsupportedcontentdefault) | **Put** /api/v2/conversations/messaging/supportedcontent/default | Set the organization&#39;s default supported content profile that may be assigned to an integration when it is created. |
| [**PutConversationsMessagingThreadingtimeline**](ConversationsApi.html#putconversationsmessagingthreadingtimeline) | **Put** /api/v2/conversations/messaging/threadingtimeline | Update conversation threading window timeline for each messaging type |
| [**PutConversationsScreenshareRecordingstate**](ConversationsApi.html#putconversationsscreensharerecordingstate) | **Put** /api/v2/conversations/screenshares/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsSocialRecordingstate**](ConversationsApi.html#putconversationssocialrecordingstate) | **Put** /api/v2/conversations/socials/{conversationId}/recordingstate | Update a conversation by setting its recording state |
| [**PutConversationsVideoRecordingstate**](ConversationsApi.html#putconversationsvideorecordingstate) | **Put** /api/v2/conversations/videos/{conversationId}/recordingstate | Update a conversation by setting its recording state |
{: class="table table-striped"}

<a name="deleteanalyticsconversationsdetailsjob"></a>

## void DeleteAnalyticsConversationsDetailsJob (string jobId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationparticipantcode"></a>

## void DeleteConversationParticipantCode (string conversationId, string participantId, string addCommunicationCode)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationparticipantflaggedreason"></a>

## void DeleteConversationParticipantFlaggedreason (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationscallparticipantconsult"></a>

## void DeleteConversationsCallParticipantConsult (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsemailmessagesdraftattachment"></a>

## void DeleteConversationsEmailMessagesDraftAttachment (string conversationId, string attachmentId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagescachedmediacachedmediaitemid"></a>

## void DeleteConversationsMessagesCachedmediaCachedMediaItemId (string cachedMediaItemId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationsfacebookintegrationid"></a>

## void DeleteConversationsMessagingIntegrationsFacebookIntegrationId (string integrationId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationsinstagramintegrationid"></a>

## void DeleteConversationsMessagingIntegrationsInstagramIntegrationId (string integrationId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationslineintegrationid"></a>

## void DeleteConversationsMessagingIntegrationsLineIntegrationId (string integrationId)



Delete a LINE messenger integration

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
    public class DeleteConversationsMessagingIntegrationsLineIntegrationIdExample
    {
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
                // Delete a LINE messenger integration
                apiInstance.DeleteConversationsMessagingIntegrationsLineIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsLineIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationsopenintegrationid"></a>

## void DeleteConversationsMessagingIntegrationsOpenIntegrationId (string integrationId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationstwitterintegrationid"></a>

## void DeleteConversationsMessagingIntegrationsTwitterIntegrationId (string integrationId)



Delete a Twitter messaging integration

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
                // Delete a Twitter messaging integration
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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationswhatsappintegrationid"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) DeleteConversationsMessagingIntegrationsWhatsappIntegrationId (string integrationId)



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
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="deleteconversationsmessagingsetting"></a>

## void DeleteConversationsMessagingSetting (string messageSettingId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingsettingsdefault"></a>

## void DeleteConversationsMessagingSettingsDefault ()



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

<a name="deleteconversationsmessagingsupportedcontentsupportedcontentid"></a>

## void DeleteConversationsMessagingSupportedcontentSupportedContentId (string supportedContentId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getanalyticsconversationdetails"></a>

## [**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes.html) GetAnalyticsConversationDetails (string conversationId)



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
{: class="table table-striped"}

### Return type

[**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes.html)

<a name="getanalyticsconversationsaggregatesjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsConversationsAggregatesJob (string jobId)



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
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsconversationsaggregatesjobresults"></a>

## [**ConversationAsyncAggregateQueryResponse**](ConversationAsyncAggregateQueryResponse.html) GetAnalyticsConversationsAggregatesJobResults (string jobId, string cursor = null)



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
{: class="table table-striped"}

### Return type

[**ConversationAsyncAggregateQueryResponse**](ConversationAsyncAggregateQueryResponse.html)

<a name="getanalyticsconversationsdetails"></a>

## [**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html) GetAnalyticsConversationsDetails (List<string> id = null)



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
| **id** | [**List<string>**](string.html)| Comma-separated conversation ids | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html)

<a name="getanalyticsconversationsdetailsjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsConversationsDetailsJob (string jobId)



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
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsconversationsdetailsjobresults"></a>

## [**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse.html) GetAnalyticsConversationsDetailsJobResults (string jobId, string cursor = null, int? pageSize = null)



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
{: class="table table-striped"}

### Return type

[**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse.html)

<a name="getanalyticsconversationsdetailsjobsavailability"></a>

## [**DataAvailabilityResponse**](DataAvailabilityResponse.html) GetAnalyticsConversationsDetailsJobsAvailability ()



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

[**DataAvailabilityResponse**](DataAvailabilityResponse.html)

<a name="getconversation"></a>

## [**Conversation**](Conversation.html) GetConversation (string conversationId)



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
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="getconversationparticipantsecureivrsession"></a>

## [**SecureSession**](SecureSession.html) GetConversationParticipantSecureivrsession (string conversationId, string participantId, string secureSessionId)



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
{: class="table table-striped"}

### Return type

[**SecureSession**](SecureSession.html)

<a name="getconversationparticipantsecureivrsessions"></a>

## [**SecureSessionEntityListing**](SecureSessionEntityListing.html) GetConversationParticipantSecureivrsessions (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

[**SecureSessionEntityListing**](SecureSessionEntityListing.html)

<a name="getconversationparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



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
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationParticipantWrapupcodes (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationsecureattributes"></a>

## [**ConversationSecureAttributes**](ConversationSecureAttributes.html) GetConversationSecureattributes (string conversationId)



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
{: class="table table-striped"}

### Return type

[**ConversationSecureAttributes**](ConversationSecureAttributes.html)

<a name="getconversations"></a>

## [**ConversationEntityListing**](ConversationEntityListing.html) GetConversations (string communicationType = null)



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
{: class="table table-striped"}

### Return type

[**ConversationEntityListing**](ConversationEntityListing.html)

<a name="getconversationscall"></a>

## [**CallConversation**](CallConversation.html) GetConversationsCall (string conversationId)



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
{: class="table table-striped"}

### Return type

[**CallConversation**](CallConversation.html)

<a name="getconversationscallparticipantcommunicationwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsCallParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationscallparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsCallParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationscallparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsCallParticipantWrapupcodes (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationscallback"></a>

## [**CallbackConversation**](CallbackConversation.html) GetConversationsCallback (string conversationId)



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
{: class="table table-striped"}

### Return type

[**CallbackConversation**](CallbackConversation.html)

<a name="getconversationscallbackparticipantcommunicationwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsCallbackParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationscallbackparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsCallbackParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationscallbackparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsCallbackParticipantWrapupcodes (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationscallbacks"></a>

## [**CallbackConversationEntityListing**](CallbackConversationEntityListing.html) GetConversationsCallbacks ()



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

[**CallbackConversationEntityListing**](CallbackConversationEntityListing.html)

<a name="getconversationscalls"></a>

## [**CallConversationEntityListing**](CallConversationEntityListing.html) GetConversationsCalls ()



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

[**CallConversationEntityListing**](CallConversationEntityListing.html)

<a name="getconversationscallshistory"></a>

## [**CallHistoryConversationEntityListing**](CallHistoryConversationEntityListing.html) GetConversationsCallsHistory (int? pageSize = null, int? pageNumber = null, string interval = null, List<string> expand = null)



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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: externalorganization, externalcontact, user, queue, group |
{: class="table table-striped"}

### Return type

[**CallHistoryConversationEntityListing**](CallHistoryConversationEntityListing.html)

<a name="getconversationscallsmaximumconferenceparties"></a>

## [**MaxParticipants**](MaxParticipants.html) GetConversationsCallsMaximumconferenceparties ()



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

[**MaxParticipants**](MaxParticipants.html)

<a name="getconversationschat"></a>

## [**ChatConversation**](ChatConversation.html) GetConversationsChat (string conversationId)



Get chat conversation

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
{: class="table table-striped"}

### Return type

[**ChatConversation**](ChatConversation.html)

<a name="getconversationschatmessage"></a>

## [**WebChatMessage**](WebChatMessage.html) GetConversationsChatMessage (string conversationId, string messageId)



Get a web chat conversation message

The current user must be involved with the conversation to get its messages.

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
{: class="table table-striped"}

### Return type

[**WebChatMessage**](WebChatMessage.html)

<a name="getconversationschatmessages"></a>

## [**WebChatMessageEntityList**](WebChatMessageEntityList.html) GetConversationsChatMessages (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null)



Get the messages of a chat conversation.

The current user must be involved with the conversation to get its messages.

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
{: class="table table-striped"}

### Return type

[**WebChatMessageEntityList**](WebChatMessageEntityList.html)

<a name="getconversationschatparticipantcommunicationwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsChatParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationschatparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsChatParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationschatparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsChatParticipantWrapupcodes (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationschats"></a>

## [**ChatConversationEntityListing**](ChatConversationEntityListing.html) GetConversationsChats ()



Get active chat conversations for the logged in user

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

[**ChatConversationEntityListing**](ChatConversationEntityListing.html)

<a name="getconversationscobrowsesession"></a>

## [**CobrowseConversation**](CobrowseConversation.html) GetConversationsCobrowsesession (string conversationId)



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
{: class="table table-striped"}

### Return type

[**CobrowseConversation**](CobrowseConversation.html)

<a name="getconversationscobrowsesessionparticipantcommunicationwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsCobrowsesessionParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationscobrowsesessionparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsCobrowsesessionParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationscobrowsesessionparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsCobrowsesessionParticipantWrapupcodes (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationscobrowsesessions"></a>

## [**CobrowseConversationEntityListing**](CobrowseConversationEntityListing.html) GetConversationsCobrowsesessions ()



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

[**CobrowseConversationEntityListing**](CobrowseConversationEntityListing.html)

<a name="getconversationsemail"></a>

## [**EmailConversation**](EmailConversation.html) GetConversationsEmail (string conversationId)



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
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="getconversationsemailmessage"></a>

## [**EmailMessage**](EmailMessage.html) GetConversationsEmailMessage (string conversationId, string messageId)



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
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getconversationsemailmessages"></a>

## [**EmailMessagePreviewListing**](EmailMessagePreviewListing.html) GetConversationsEmailMessages (string conversationId)



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
{: class="table table-striped"}

### Return type

[**EmailMessagePreviewListing**](EmailMessagePreviewListing.html)

<a name="getconversationsemailmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) GetConversationsEmailMessagesDraft (string conversationId)



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
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getconversationsemailparticipantcommunicationwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsEmailParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationsemailparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsEmailParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationsemailparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsEmailParticipantWrapupcodes (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationsemailsettings"></a>

## [**EmailsSettings**](EmailsSettings.html) GetConversationsEmailSettings (string conversationId)



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
{: class="table table-striped"}

### Return type

[**EmailsSettings**](EmailsSettings.html)

<a name="getconversationsemails"></a>

## [**EmailConversationEntityListing**](EmailConversationEntityListing.html) GetConversationsEmails ()



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

[**EmailConversationEntityListing**](EmailConversationEntityListing.html)

<a name="getconversationskeyconfiguration"></a>

## [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html) GetConversationsKeyconfiguration (string keyconfigurationsId)



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
{: class="table table-striped"}

### Return type

[**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html)

<a name="getconversationskeyconfigurations"></a>

## [**ConversationEncryptionConfigurationListing**](ConversationEncryptionConfigurationListing.html) GetConversationsKeyconfigurations ()



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

[**ConversationEncryptionConfigurationListing**](ConversationEncryptionConfigurationListing.html)

<a name="getconversationsmessage"></a>

## [**MessageConversation**](MessageConversation.html) GetConversationsMessage (string conversationId)



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
{: class="table table-striped"}

### Return type

[**MessageConversation**](MessageConversation.html)

<a name="getconversationsmessagecommunicationmessagesmediamediaid"></a>

## [**MessageMediaData**](MessageMediaData.html) GetConversationsMessageCommunicationMessagesMediaMediaId (string conversationId, string communicationId, string mediaId)



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
{: class="table table-striped"}

### Return type

[**MessageMediaData**](MessageMediaData.html)

<a name="getconversationsmessagedetails"></a>

## [**MessageData**](MessageData.html) GetConversationsMessageDetails (string messageId, bool? useNormalizedMessage = null)



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
            var useNormalizedMessage = true;  // bool? | If true, response removes deprecated fields (textBody, media, stickers) (optional)  (default to false)

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
| **useNormalizedMessage** | **bool?**| If true, response removes deprecated fields (textBody, media, stickers) | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**MessageData**](MessageData.html)

<a name="getconversationsmessagemessage"></a>

## [**MessageData**](MessageData.html) GetConversationsMessageMessage (string conversationId, string messageId, bool? useNormalizedMessage = null)



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
            var useNormalizedMessage = true;  // bool? | If true, response removes deprecated fields (textBody, media, stickers) (optional)  (default to false)

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
| **useNormalizedMessage** | **bool?**| If true, response removes deprecated fields (textBody, media, stickers) | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**MessageData**](MessageData.html)

<a name="getconversationsmessageparticipantcommunicationwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsMessageParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationsmessageparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsMessageParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationsmessageparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsMessageParticipantWrapupcodes (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationsmessages"></a>

## [**MessageConversationEntityListing**](MessageConversationEntityListing.html) GetConversationsMessages ()



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

[**MessageConversationEntityListing**](MessageConversationEntityListing.html)

<a name="getconversationsmessagescachedmedia"></a>

## [**CachedMediaItemEntityListing**](CachedMediaItemEntityListing.html) GetConversationsMessagesCachedmedia (int? pageSize = null, int? pageNumber = null, string url = null)



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
{: class="table table-striped"}

### Return type

[**CachedMediaItemEntityListing**](CachedMediaItemEntityListing.html)

<a name="getconversationsmessagescachedmediacachedmediaitemid"></a>

## [**CachedMediaItem**](CachedMediaItem.html) GetConversationsMessagesCachedmediaCachedMediaItemId (string cachedMediaItemId)



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
{: class="table table-striped"}

### Return type

[**CachedMediaItem**](CachedMediaItem.html)

<a name="getconversationsmessagingfacebookapp"></a>

## [**FacebookAppCredentials**](FacebookAppCredentials.html) GetConversationsMessagingFacebookApp ()



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

[**FacebookAppCredentials**](FacebookAppCredentials.html)

<a name="getconversationsmessagingintegrations"></a>

## [**MessagingIntegrationEntityListing**](MessagingIntegrationEntityListing.html) GetConversationsMessagingIntegrations (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string supportedContentId = null, string messagingSettingId = null)



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
| **expand** | [**List<string>**](string.html)| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |
{: class="table table-striped"}

### Return type

[**MessagingIntegrationEntityListing**](MessagingIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationsfacebook"></a>

## [**FacebookIntegrationEntityListing**](FacebookIntegrationEntityListing.html) GetConversationsMessagingIntegrationsFacebook (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)



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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |
{: class="table table-striped"}

### Return type

[**FacebookIntegrationEntityListing**](FacebookIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationsfacebookintegrationid"></a>

## [**FacebookIntegration**](FacebookIntegration.html) GetConversationsMessagingIntegrationsFacebookIntegrationId (string integrationId, string expand = null)



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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
{: class="table table-striped"}

### Return type

[**FacebookIntegration**](FacebookIntegration.html)

<a name="getconversationsmessagingintegrationsinstagram"></a>

## [**InstagramIntegrationEntityListing**](InstagramIntegrationEntityListing.html) GetConversationsMessagingIntegrationsInstagram (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)



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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |
{: class="table table-striped"}

### Return type

[**InstagramIntegrationEntityListing**](InstagramIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationsinstagramintegrationid"></a>

## [**InstagramIntegration**](InstagramIntegration.html) GetConversationsMessagingIntegrationsInstagramIntegrationId (string integrationId, string expand = null)



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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
{: class="table table-striped"}

### Return type

[**InstagramIntegration**](InstagramIntegration.html)

<a name="getconversationsmessagingintegrationsline"></a>

## [**LineIntegrationEntityListing**](LineIntegrationEntityListing.html) GetConversationsMessagingIntegrationsLine (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)



Get a list of LINE messenger Integrations

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
    public class GetConversationsMessagingIntegrationsLineExample
    {
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
                // Get a list of LINE messenger Integrations
                LineIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsLine(pageSize, pageNumber, expand, supportedContentId, messagingSettingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsLine: " + e.Message );
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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |
{: class="table table-striped"}

### Return type

[**LineIntegrationEntityListing**](LineIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationslineintegrationid"></a>

## [**LineIntegration**](LineIntegration.html) GetConversationsMessagingIntegrationsLineIntegrationId (string integrationId, string expand = null)



Get a LINE messenger integration

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
    public class GetConversationsMessagingIntegrationsLineIntegrationIdExample
    {
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
                // Get a LINE messenger integration
                LineIntegration result = apiInstance.GetConversationsMessagingIntegrationsLineIntegrationId(integrationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsLineIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
{: class="table table-striped"}

### Return type

[**LineIntegration**](LineIntegration.html)

<a name="getconversationsmessagingintegrationsopen"></a>

## [**OpenIntegrationEntityListing**](OpenIntegrationEntityListing.html) GetConversationsMessagingIntegrationsOpen (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)



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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |
{: class="table table-striped"}

### Return type

[**OpenIntegrationEntityListing**](OpenIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationsopenintegrationid"></a>

## [**OpenIntegration**](OpenIntegration.html) GetConversationsMessagingIntegrationsOpenIntegrationId (string integrationId, string expand = null)



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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
{: class="table table-striped"}

### Return type

[**OpenIntegration**](OpenIntegration.html)

<a name="getconversationsmessagingintegrationstwitter"></a>

## [**TwitterIntegrationEntityListing**](TwitterIntegrationEntityListing.html) GetConversationsMessagingIntegrationsTwitter (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)



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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |
{: class="table table-striped"}

### Return type

[**TwitterIntegrationEntityListing**](TwitterIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationstwitterintegrationid"></a>

## [**TwitterIntegration**](TwitterIntegration.html) GetConversationsMessagingIntegrationsTwitterIntegrationId (string integrationId, string expand = null)



Get a Twitter messaging integration

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
                // Get a Twitter messaging integration
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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
{: class="table table-striped"}

### Return type

[**TwitterIntegration**](TwitterIntegration.html)

<a name="getconversationsmessagingintegrationswhatsapp"></a>

## [**WhatsAppIntegrationEntityListing**](WhatsAppIntegrationEntityListing.html) GetConversationsMessagingIntegrationsWhatsapp (int? pageSize = null, int? pageNumber = null, string expand = null, string supportedContentId = null, string messagingSettingId = null)



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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
| **supportedContentId** | **string**| Filter integrations returned based on the supported content ID | [optional]  |
| **messagingSettingId** | **string**| Filter integrations returned based on the setting ID | [optional]  |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegrationEntityListing**](WhatsAppIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationswhatsappintegrationid"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) GetConversationsMessagingIntegrationsWhatsappIntegrationId (string integrationId, string expand = null)



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
| **expand** | **string**| Expand instructions for the return value. | [optional] <br />**Values**: supportedContent, messagingSetting |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="getconversationsmessagingsetting"></a>

## [**MessagingSetting**](MessagingSetting.html) GetConversationsMessagingSetting (string messageSettingId)



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
{: class="table table-striped"}

### Return type

[**MessagingSetting**](MessagingSetting.html)

<a name="getconversationsmessagingsettings"></a>

## [**MessagingConfigListing**](MessagingConfigListing.html) GetConversationsMessagingSettings (int? pageSize = null, int? pageNumber = null)



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
{: class="table table-striped"}

### Return type

[**MessagingConfigListing**](MessagingConfigListing.html)

<a name="getconversationsmessagingsettingsdefault"></a>

## [**MessagingSetting**](MessagingSetting.html) GetConversationsMessagingSettingsDefault ()



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

[**MessagingSetting**](MessagingSetting.html)

<a name="getconversationsmessagingsticker"></a>

## [**MessagingStickerEntityListing**](MessagingStickerEntityListing.html) GetConversationsMessagingSticker (string messengerType, int? pageSize = null, int? pageNumber = null)



Get a list of Messaging Stickers

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
    public class GetConversationsMessagingStickerExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var messengerType = messengerType_example;  // string | Messenger Type
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Messaging Stickers
                MessagingStickerEntityListing result = apiInstance.GetConversationsMessagingSticker(messengerType, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingSticker: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messengerType** | **string**| Messenger Type | <br />**Values**: line |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**MessagingStickerEntityListing**](MessagingStickerEntityListing.html)

<a name="getconversationsmessagingsupportedcontent"></a>

## [**SupportedContentListing**](SupportedContentListing.html) GetConversationsMessagingSupportedcontent (int? pageSize = null, int? pageNumber = null)



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
{: class="table table-striped"}

### Return type

[**SupportedContentListing**](SupportedContentListing.html)

<a name="getconversationsmessagingsupportedcontentdefault"></a>

## [**SupportedContent**](SupportedContent.html) GetConversationsMessagingSupportedcontentDefault ()



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

[**SupportedContent**](SupportedContent.html)

<a name="getconversationsmessagingsupportedcontentsupportedcontentid"></a>

## [**SupportedContent**](SupportedContent.html) GetConversationsMessagingSupportedcontentSupportedContentId (string supportedContentId)



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
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent.html)

<a name="getconversationsmessagingthreadingtimeline"></a>

## [**ConversationThreadingWindow**](ConversationThreadingWindow.html) GetConversationsMessagingThreadingtimeline ()



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

[**ConversationThreadingWindow**](ConversationThreadingWindow.html)

<a name="getconversationsscreenshareparticipantcommunicationwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsScreenshareParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationssettings"></a>

## [**Settings**](Settings.html) GetConversationsSettings ()



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

[**Settings**](Settings.html)

<a name="getconversationssocialparticipantcommunicationwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsSocialParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationsvideodetails"></a>

## [**VideoConferenceDetails**](VideoConferenceDetails.html) GetConversationsVideoDetails (string conferenceId)



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
{: class="table table-striped"}

### Return type

[**VideoConferenceDetails**](VideoConferenceDetails.html)

<a name="getconversationsvideoparticipantcommunicationwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsVideoParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, bool? provisional = null)



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
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

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
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationsvideosmeeting"></a>

## [**MeetingIdRecord**](MeetingIdRecord.html) GetConversationsVideosMeeting (string meetingId)



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
{: class="table table-striped"}

### Return type

[**MeetingIdRecord**](MeetingIdRecord.html)

<a name="patchconversationparticipant"></a>

## void PatchConversationParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update a participant.

Update conversation participant.

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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationparticipantattributes"></a>

## void PatchConversationParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationsecureattributes"></a>

## **string** PatchConversationSecureattributes (string conversationId, ConversationSecureAttributes body)



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
| **body** | [**ConversationSecureAttributes**](ConversationSecureAttributes.html)| Conversation Secure Attributes |  |
{: class="table table-striped"}

### Return type

**string**

<a name="patchconversationsaftercallworkconversationidparticipantcommunication"></a>

## [**AfterCallWorkUpdate**](AfterCallWorkUpdate.html) PatchConversationsAftercallworkConversationIdParticipantCommunication (string conversationId, string participantId, string communicationId, AfterCallWorkUpdate body)



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
| **body** | [**AfterCallWorkUpdate**](AfterCallWorkUpdate.html)| AfterCallWorkUpdate |  |
{: class="table table-striped"}

### Return type

[**AfterCallWorkUpdate**](AfterCallWorkUpdate.html)

<a name="patchconversationscall"></a>

## [**Conversation**](Conversation.html) PatchConversationsCall (string conversationId, Conversation body)



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
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationscallparticipant"></a>

## void PatchConversationsCallParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update conversation participant

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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallparticipantattributes"></a>

## [**ParticipantAttributes**](ParticipantAttributes.html) PatchConversationsCallParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

[**ParticipantAttributes**](ParticipantAttributes.html)

<a name="patchconversationscallparticipantcommunication"></a>

## **Object** PatchConversationsCallParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



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
                // Update conversation participant's communication by disconnecting it.
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="patchconversationscallparticipantconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PatchConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransferUpdate body)



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
| **body** | [**ConsultTransferUpdate**](ConsultTransferUpdate.html)| new speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="patchconversationscallback"></a>

## [**Conversation**](Conversation.html) PatchConversationsCallback (string conversationId, Conversation body)



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
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationscallbackparticipant"></a>

## void PatchConversationsCallbackParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update conversation participant

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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallbackparticipantattributes"></a>

## [**ParticipantAttributes**](ParticipantAttributes.html) PatchConversationsCallbackParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Attributes |  |
{: class="table table-striped"}

### Return type

[**ParticipantAttributes**](ParticipantAttributes.html)

<a name="patchconversationscallbackparticipantcommunication"></a>

## **Object** PatchConversationsCallbackParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="patchconversationscallbacks"></a>

## [**PatchCallbackResponse**](PatchCallbackResponse.html) PatchConversationsCallbacks (PatchCallbackRequest body)



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
| **body** | [**PatchCallbackRequest**](PatchCallbackRequest.html)| PatchCallbackRequest |  |
{: class="table table-striped"}

### Return type

[**PatchCallbackResponse**](PatchCallbackResponse.html)

<a name="patchconversationschat"></a>

## [**Conversation**](Conversation.html) PatchConversationsChat (string conversationId, Conversation body)



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
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationschatparticipant"></a>

## void PatchConversationsChatParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update conversation participant

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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationschatparticipantattributes"></a>

## [**ParticipantAttributes**](ParticipantAttributes.html) PatchConversationsChatParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

[**ParticipantAttributes**](ParticipantAttributes.html)

<a name="patchconversationschatparticipantcommunication"></a>

## **Object** PatchConversationsChatParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



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
                // Update conversation participant's communication by disconnecting it.
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="patchconversationscobrowsesession"></a>

## [**Conversation**](Conversation.html) PatchConversationsCobrowsesession (string conversationId, Conversation body)



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
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationscobrowsesessionparticipant"></a>

## void PatchConversationsCobrowsesessionParticipant (string conversationId, string participantId, MediaParticipantRequest body = null)



Update conversation participant

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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscobrowsesessionparticipantattributes"></a>

## [**ParticipantAttributes**](ParticipantAttributes.html) PatchConversationsCobrowsesessionParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body = null)



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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ParticipantAttributes**](ParticipantAttributes.html)

<a name="patchconversationscobrowsesessionparticipantcommunication"></a>

## **Object** PatchConversationsCobrowsesessionParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="patchconversationsemail"></a>

## [**Conversation**](Conversation.html) PatchConversationsEmail (string conversationId, Conversation body)



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
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationsemailmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) PatchConversationsEmailMessagesDraft (string conversationId, bool? autoFill = null, bool? discard = null, DraftManipulationRequest body = null)



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
| **body** | [**DraftManipulationRequest**](DraftManipulationRequest.html)| Draft Manipulation Request | [optional]  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="patchconversationsemailparticipant"></a>

## void PatchConversationsEmailParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update conversation participant

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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationsemailparticipantattributes"></a>

## [**ParticipantAttributes**](ParticipantAttributes.html) PatchConversationsEmailParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

[**ParticipantAttributes**](ParticipantAttributes.html)

<a name="patchconversationsemailparticipantcommunication"></a>

## **Object** PatchConversationsEmailParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



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
                // Update conversation participant's communication by disconnecting it.
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="patchconversationsmessage"></a>

## [**Conversation**](Conversation.html) PatchConversationsMessage (string conversationId, Conversation body)



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
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationsmessageparticipant"></a>

## void PatchConversationsMessageParticipant (string conversationId, string participantId, MediaParticipantRequest body = null)



Update conversation participant

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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationsmessageparticipantattributes"></a>

## [**ParticipantAttributes**](ParticipantAttributes.html) PatchConversationsMessageParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body = null)



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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ParticipantAttributes**](ParticipantAttributes.html)

<a name="patchconversationsmessageparticipantcommunication"></a>

## **Object** PatchConversationsMessageParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



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
                // Update conversation participant's communication by disconnecting it.
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="patchconversationsmessagingintegrationsfacebookintegrationid"></a>

## [**FacebookIntegration**](FacebookIntegration.html) PatchConversationsMessagingIntegrationsFacebookIntegrationId (string integrationId, FacebookIntegrationUpdateRequest body)



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
| **body** | [**FacebookIntegrationUpdateRequest**](FacebookIntegrationUpdateRequest.html)| FacebookIntegrationUpdateRequest |  |
{: class="table table-striped"}

### Return type

[**FacebookIntegration**](FacebookIntegration.html)

<a name="patchconversationsmessagingintegrationsinstagramintegrationid"></a>

## [**InstagramIntegration**](InstagramIntegration.html) PatchConversationsMessagingIntegrationsInstagramIntegrationId (string integrationId, InstagramIntegrationUpdateRequest body)



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
| **body** | [**InstagramIntegrationUpdateRequest**](InstagramIntegrationUpdateRequest.html)| InstagramIntegrationUpdateRequest |  |
{: class="table table-striped"}

### Return type

[**InstagramIntegration**](InstagramIntegration.html)

<a name="patchconversationsmessagingintegrationsopenintegrationid"></a>

## [**OpenIntegration**](OpenIntegration.html) PatchConversationsMessagingIntegrationsOpenIntegrationId (string integrationId, OpenIntegrationUpdateRequest body)



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
| **body** | [**OpenIntegrationUpdateRequest**](OpenIntegrationUpdateRequest.html)| OpenIntegrationUpdateRequest |  |
{: class="table table-striped"}

### Return type

[**OpenIntegration**](OpenIntegration.html)

<a name="patchconversationsmessagingintegrationstwitterintegrationid"></a>

## [**TwitterIntegration**](TwitterIntegration.html) PatchConversationsMessagingIntegrationsTwitterIntegrationId (string integrationId, TwitterIntegrationRequest body)



Update Twitter messaging integration

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
            var body = new TwitterIntegrationRequest(); // TwitterIntegrationRequest | TwitterIntegrationRequest

            try
            { 
                // Update Twitter messaging integration
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
| **body** | [**TwitterIntegrationRequest**](TwitterIntegrationRequest.html)| TwitterIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**TwitterIntegration**](TwitterIntegration.html)

<a name="patchconversationsmessagingintegrationswhatsappembeddedsignupintegrationid"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) PatchConversationsMessagingIntegrationsWhatsappEmbeddedsignupIntegrationId (string integrationId, WhatsAppEmbeddedSignupIntegrationActivationRequest body)



Activate a WhatsApp messaging integration created using the WhatsApp embedded signup flow

Please specify the phone number to associate with this WhatsApp integration from the list of available phone numbers returned to you in the POST call to create the integration. You can then run a GET on the integration to check if its status has been updated to Active

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
| **body** | [**WhatsAppEmbeddedSignupIntegrationActivationRequest**](WhatsAppEmbeddedSignupIntegrationActivationRequest.html)| WhatsAppEmbeddedSignupIntegrationActivationRequest |  |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="patchconversationsmessagingintegrationswhatsappintegrationid"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) PatchConversationsMessagingIntegrationsWhatsappIntegrationId (string integrationId, WhatsAppIntegrationUpdateRequest body)



Update or activate a WhatsApp messaging integration

The following steps are required in order to fully activate a WhatsApp Integration: Initially, you will need to get an activation code by sending: an action set to Activate, and an authenticationMethod choosing from Sms or Voice. Finally, once you have been informed of an activation code on selected authenticationMethod, you will need to confirm the code by sending: an action set to Confirm, and the confirmationCode you have received from Whatsapp.

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
                // Update or activate a WhatsApp messaging integration
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
| **body** | [**WhatsAppIntegrationUpdateRequest**](WhatsAppIntegrationUpdateRequest.html)| WhatsAppIntegrationUpdateRequest |  |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="patchconversationsmessagingsetting"></a>

## [**MessagingSetting**](MessagingSetting.html) PatchConversationsMessagingSetting (string messageSettingId, MessagingSettingPatchRequest body)



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
| **body** | [**MessagingSettingPatchRequest**](MessagingSettingPatchRequest.html)| MessagingSetting |  |
{: class="table table-striped"}

### Return type

[**MessagingSetting**](MessagingSetting.html)

<a name="patchconversationsmessagingsupportedcontentsupportedcontentid"></a>

## [**SupportedContent**](SupportedContent.html) PatchConversationsMessagingSupportedcontentSupportedContentId (string supportedContentId, SupportedContent body)



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
| **body** | [**SupportedContent**](SupportedContent.html)| SupportedContent |  |
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent.html)

<a name="patchconversationssettings"></a>

## void PatchConversationsSettings (Settings body)



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
| **body** | [**Settings**](Settings.html)| Settings |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postanalyticsconversationdetailsproperties"></a>

## [**PropertyIndexRequest**](PropertyIndexRequest.html) PostAnalyticsConversationDetailsProperties (string conversationId, PropertyIndexRequest body)



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
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest.html)| request |  |
{: class="table table-striped"}

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest.html)

<a name="postanalyticsconversationsactivityquery"></a>

## [**ConversationActivityResponse**](ConversationActivityResponse.html) PostAnalyticsConversationsActivityQuery (ConversationActivityQuery body, int? pageSize = null, int? pageNumber = null)



Query for conversation activity observations

PostAnalyticsConversationsActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**ConversationActivityQuery**](ConversationActivityQuery.html)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationActivityResponse**](ConversationActivityResponse.html)

<a name="postanalyticsconversationsaggregatesjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsConversationsAggregatesJobs (ConversationAsyncAggregationQuery body)



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
| **body** | [**ConversationAsyncAggregationQuery**](ConversationAsyncAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsconversationsaggregatesquery"></a>

## [**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse.html) PostAnalyticsConversationsAggregatesQuery (ConversationAggregationQuery body)



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
| **body** | [**ConversationAggregationQuery**](ConversationAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse.html)

<a name="postanalyticsconversationsdetailsjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsConversationsDetailsJobs (AsyncConversationQuery body)



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
| **body** | [**AsyncConversationQuery**](AsyncConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsconversationsdetailsquery"></a>

## [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html) PostAnalyticsConversationsDetailsQuery (ConversationQuery body)



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
| **body** | [**ConversationQuery**](ConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html)

<a name="postconversationassign"></a>

## **string** PostConversationAssign (string conversationId, ConversationUser body)



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
| **body** | [**ConversationUser**](ConversationUser.html)| Targeted user |  |
{: class="table table-striped"}

### Return type

**string**

<a name="postconversationbarge"></a>

## void PostConversationBarge (string conversationId)



Barge a conversation creating a barged in conference of connected participants.

PostConversationBarge is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationcobrowse"></a>

## [**CobrowseWebMessagingSession**](CobrowseWebMessagingSession.html) PostConversationCobrowse (string conversationId)



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
{: class="table table-striped"}

### Return type

[**CobrowseWebMessagingSession**](CobrowseWebMessagingSession.html)

<a name="postconversationdisconnect"></a>

## **string** PostConversationDisconnect (string conversationId)



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
{: class="table table-striped"}

### Return type

**string**

<a name="postconversationparticipantcallbacks"></a>

## void PostConversationParticipantCallbacks (string conversationId, string participantId, CreateCallbackOnConversationCommand body = null)



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
| **body** | [**CreateCallbackOnConversationCommand**](CreateCallbackOnConversationCommand.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantdigits"></a>

## void PostConversationParticipantDigits (string conversationId, string participantId, Digits body = null)



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
| **body** | [**Digits**](Digits.html)| Digits | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantreplace"></a>

## void PostConversationParticipantReplace (string conversationId, string participantId, TransferRequest body)



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
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantreplaceagent"></a>

## void PostConversationParticipantReplaceAgent (string conversationId, string participantId, TransferToAgentRequest body)



Replace this participant with the specified agent

PostConversationParticipantReplaceAgent is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**TransferToAgentRequest**](TransferToAgentRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantreplaceexternal"></a>

## void PostConversationParticipantReplaceExternal (string conversationId, string participantId, TransferToExternalRequest body)



Replace this participant with the an external contact

PostConversationParticipantReplaceExternal is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**TransferToExternalRequest**](TransferToExternalRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantreplacequeue"></a>

## void PostConversationParticipantReplaceQueue (string conversationId, string participantId, TransferToQueueRequest body)



Replace this participant with the specified queue

PostConversationParticipantReplaceQueue is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**TransferToQueueRequest**](TransferToQueueRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantsecureivrsessions"></a>

## [**SecureSession**](SecureSession.html) PostConversationParticipantSecureivrsessions (string conversationId, string participantId, CreateSecureSession body = null)



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
| **body** | [**CreateSecureSession**](CreateSecureSession.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**SecureSession**](SecureSession.html)

<a name="postconversationsummaryfeedback"></a>

## void PostConversationSummaryFeedback (string conversationId, string summaryId, FeedbackAddRequest body = null)



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
| **body** | [**FeedbackAddRequest**](FeedbackAddRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscall"></a>

## [**Conversation**](Conversation.html) PostConversationsCall (string conversationId, CallCommand body)



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
| **body** | [**CallCommand**](CallCommand.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postconversationscallparticipantbarge"></a>

## void PostConversationsCallParticipantBarge (string conversationId, string participantId)



Barge a given participant's call creating a barged in conference of connected participants.

PostConversationsCallParticipantBarge is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallparticipantcoach"></a>

## void PostConversationsCallParticipantCoach (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallparticipantcommunicationwrapup"></a>

## void PostConversationsCallParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)



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
| **body** | [**WrapupInput**](WrapupInput.html)| Wrap-up | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallparticipantconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PostConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransfer body)



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
| **body** | [**ConsultTransfer**](ConsultTransfer.html)| Destination address &amp; initial speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="postconversationscallparticipantconsultagent"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PostConversationsCallParticipantConsultAgent (string conversationId, string participantId, ConsultTransferToAgent body)



Initiate a consult transfer to an agent

PostConversationsCallParticipantConsultAgent is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**ConsultTransferToAgent**](ConsultTransferToAgent.html)| Destination agent &amp; initial speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="postconversationscallparticipantconsultexternal"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PostConversationsCallParticipantConsultExternal (string conversationId, string participantId, ConsultTransferToExternal body)



Initiate a consult transfer to an external contact

PostConversationsCallParticipantConsultExternal is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**ConsultTransferToExternal**](ConsultTransferToExternal.html)| Destination address &amp; initial speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="postconversationscallparticipantconsultqueue"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PostConversationsCallParticipantConsultQueue (string conversationId, string participantId, ConsultTransferToQueue body)



Initiate a consult transfer to a queue

PostConversationsCallParticipantConsultQueue is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
| **body** | [**ConsultTransferToQueue**](ConsultTransferToQueue.html)| Destination queue &amp; initial speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="postconversationscallparticipantmonitor"></a>

## void PostConversationsCallParticipantMonitor (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallparticipantreplace"></a>

## void PostConversationsCallParticipantReplace (string conversationId, string participantId, TransferRequest body)



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
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallparticipants"></a>

## [**Conversation**](Conversation.html) PostConversationsCallParticipants (string conversationId, Conversation body)



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
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postconversationscallbackparticipantcommunicationwrapup"></a>

## void PostConversationsCallbackParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)



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
| **body** | [**WrapupInput**](WrapupInput.html)| Wrap-up | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallbackparticipantreplace"></a>

## void PostConversationsCallbackParticipantReplace (string conversationId, string participantId, TransferRequest body)



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
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallbacks"></a>

## [**CreateCallbackResponse**](CreateCallbackResponse.html) PostConversationsCallbacks (CreateCallbackCommand body)



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
| **body** | [**CreateCallbackCommand**](CreateCallbackCommand.html)| Callback |  |
{: class="table table-striped"}

### Return type

[**CreateCallbackResponse**](CreateCallbackResponse.html)

<a name="postconversationscallbacksbulkdisconnect"></a>

## void PostConversationsCallbacksBulkDisconnect (BulkCallbackDisconnectRequest body)



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
| **body** | [**BulkCallbackDisconnectRequest**](BulkCallbackDisconnectRequest.html)| BulkCallbackDisconnectRequest |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallbacksbulkupdate"></a>

## [**BulkCallbackPatchResponse**](BulkCallbackPatchResponse.html) PostConversationsCallbacksBulkUpdate (BulkCallbackPatchRequest body)



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
| **body** | [**BulkCallbackPatchRequest**](BulkCallbackPatchRequest.html)| BulkCallbackPatchRequest |  |
{: class="table table-striped"}

### Return type

[**BulkCallbackPatchResponse**](BulkCallbackPatchResponse.html)

<a name="postconversationscalls"></a>

## [**CreateCallResponse**](CreateCallResponse.html) PostConversationsCalls (CreateCallRequest body)



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
| **body** | [**CreateCallRequest**](CreateCallRequest.html)| Call request |  |
{: class="table table-striped"}

### Return type

[**CreateCallResponse**](CreateCallResponse.html)

<a name="postconversationschatcommunicationmessages"></a>

## [**WebChatMessage**](WebChatMessage.html) PostConversationsChatCommunicationMessages (string conversationId, string communicationId, CreateWebChatMessageRequest body)



Send a message on behalf of a communication in a chat conversation.

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
| **body** | [**CreateWebChatMessageRequest**](CreateWebChatMessageRequest.html)| Message |  |
{: class="table table-striped"}

### Return type

[**WebChatMessage**](WebChatMessage.html)

<a name="postconversationschatcommunicationtyping"></a>

## [**WebChatTyping**](WebChatTyping.html) PostConversationsChatCommunicationTyping (string conversationId, string communicationId)



Send a typing-indicator on behalf of a communication in a chat conversation.

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
{: class="table table-striped"}

### Return type

[**WebChatTyping**](WebChatTyping.html)

<a name="postconversationschatparticipantcommunicationwrapup"></a>

## void PostConversationsChatParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)



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
| **body** | [**WrapupInput**](WrapupInput.html)| Wrap-up | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationschatparticipantreplace"></a>

## void PostConversationsChatParticipantReplace (string conversationId, string participantId, TransferRequest body)



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
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationschats"></a>

## [**ChatConversation**](ChatConversation.html) PostConversationsChats (CreateWebChatRequest body)



Create a web chat conversation

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
| **body** | [**CreateWebChatRequest**](CreateWebChatRequest.html)| Create web chat request |  |
{: class="table table-striped"}

### Return type

[**ChatConversation**](ChatConversation.html)

<a name="postconversationscobrowsesessionparticipantcommunicationwrapup"></a>

## void PostConversationsCobrowsesessionParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)



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
| **body** | [**WrapupInput**](WrapupInput.html)| Wrap-up | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscobrowsesessionparticipantreplace"></a>

## void PostConversationsCobrowsesessionParticipantReplace (string conversationId, string participantId, TransferRequest body = null)



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
| **body** | [**TransferRequest**](TransferRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsemailinboundmessages"></a>

## [**EmailConversation**](EmailConversation.html) PostConversationsEmailInboundmessages (string conversationId, InboundMessageRequest body)



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
| **body** | [**InboundMessageRequest**](InboundMessageRequest.html)| Send external email reply |  |
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="postconversationsemailmessages"></a>

## [**EmailMessageReply**](EmailMessageReply.html) PostConversationsEmailMessages (string conversationId, EmailMessage body)



Send an email reply

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
| **body** | [**EmailMessage**](EmailMessage.html)| Reply |  |
{: class="table table-striped"}

### Return type

[**EmailMessageReply**](EmailMessageReply.html)

<a name="postconversationsemailmessagesdraftattachmentscopy"></a>

## [**EmailMessage**](EmailMessage.html) PostConversationsEmailMessagesDraftAttachmentsCopy (string conversationId, CopyAttachmentsRequest body)



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
| **body** | [**CopyAttachmentsRequest**](CopyAttachmentsRequest.html)| Copy Attachment Request |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="postconversationsemailparticipantcommunicationwrapup"></a>

## void PostConversationsEmailParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)



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
| **body** | [**WrapupInput**](WrapupInput.html)| Wrap-up | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsemailparticipantreplace"></a>

## void PostConversationsEmailParticipantReplace (string conversationId, string participantId, TransferRequest body)



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
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsemails"></a>

## [**EmailConversation**](EmailConversation.html) PostConversationsEmails (CreateEmailRequest body)



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
| **body** | [**CreateEmailRequest**](CreateEmailRequest.html)| Create email request |  |
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="postconversationsemailsagentless"></a>

## [**AgentlessEmailSendResponseDto**](AgentlessEmailSendResponseDto.html) PostConversationsEmailsAgentless (AgentlessEmailSendRequestDto body)



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
| **body** | [**AgentlessEmailSendRequestDto**](AgentlessEmailSendRequestDto.html)| Create agentless email request |  |
{: class="table table-striped"}

### Return type

[**AgentlessEmailSendResponseDto**](AgentlessEmailSendResponseDto.html)

<a name="postconversationsfaxes"></a>

## [**FaxSendResponse**](FaxSendResponse.html) PostConversationsFaxes (FaxSendRequest body)



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
| **body** | [**FaxSendRequest**](FaxSendRequest.html)| Fax |  |
{: class="table table-striped"}

### Return type

[**FaxSendResponse**](FaxSendResponse.html)

<a name="postconversationskeyconfigurations"></a>

## [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html) PostConversationsKeyconfigurations (ConversationEncryptionConfiguration body)



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
| **body** | [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html)| Encryption Configuration |  |
{: class="table table-striped"}

### Return type

[**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html)

<a name="postconversationskeyconfigurationsvalidate"></a>

## [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html) PostConversationsKeyconfigurationsValidate (ConversationEncryptionConfiguration body)



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
| **body** | [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html)| Encryption Configuration |  |
{: class="table table-striped"}

### Return type

[**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html)

<a name="postconversationsmessagecommunicationmessages"></a>

## [**MessageData**](MessageData.html) PostConversationsMessageCommunicationMessages (string conversationId, string communicationId, AdditionalMessage body, bool? useNormalizedMessage = null)



Send message

Send message on existing conversation/communication. Only one message body field can be accepted, per request. Example: 1 textBody, 1 mediaId, 1 stickerId, or 1 messageTemplate.

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
            var useNormalizedMessage = true;  // bool? | If true, response removes deprecated fields (textBody, media, stickers) (optional)  (default to false)

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
| **body** | [**AdditionalMessage**](AdditionalMessage.html)| Message |  |
| **useNormalizedMessage** | **bool?**| If true, response removes deprecated fields (textBody, media, stickers) | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**MessageData**](MessageData.html)

<a name="postconversationsmessagecommunicationmessagesmedia"></a>

## [**MessageMediaData**](MessageMediaData.html) PostConversationsMessageCommunicationMessagesMedia (string conversationId, string communicationId)



Create media

See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.

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
{: class="table table-striped"}

### Return type

[**MessageMediaData**](MessageMediaData.html)

<a name="postconversationsmessagecommunicationtyping"></a>

## void PostConversationsMessageCommunicationTyping (string conversationId, string communicationId, MessageTypingEventRequest body)



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
| **body** | [**MessageTypingEventRequest**](MessageTypingEventRequest.html)| MessageTypingEvent |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsmessageinboundopenevent"></a>

## [**OpenEventNormalizedMessage**](OpenEventNormalizedMessage.html) PostConversationsMessageInboundOpenEvent (string integrationId, OpenInboundNormalizedEvent body)



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
| **body** | [**OpenInboundNormalizedEvent**](OpenInboundNormalizedEvent.html)| NormalizedMessage |  |
{: class="table table-striped"}

### Return type

[**OpenEventNormalizedMessage**](OpenEventNormalizedMessage.html)

<a name="postconversationsmessageinboundopenmessage"></a>

## [**OpenMessageNormalizedMessage**](OpenMessageNormalizedMessage.html) PostConversationsMessageInboundOpenMessage (string integrationId, OpenInboundNormalizedMessage body)



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

            try
            { 
                // Send inbound Open Message
                OpenMessageNormalizedMessage result = apiInstance.PostConversationsMessageInboundOpenMessage(integrationId, body);
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
| **body** | [**OpenInboundNormalizedMessage**](OpenInboundNormalizedMessage.html)| NormalizedMessage |  |
{: class="table table-striped"}

### Return type

[**OpenMessageNormalizedMessage**](OpenMessageNormalizedMessage.html)

<a name="postconversationsmessageinboundopenreceipt"></a>

## [**OpenReceiptNormalizedMessage**](OpenReceiptNormalizedMessage.html) PostConversationsMessageInboundOpenReceipt (string integrationId, OpenInboundNormalizedReceipt body)



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
| **body** | [**OpenInboundNormalizedReceipt**](OpenInboundNormalizedReceipt.html)| NormalizedMessage |  |
{: class="table table-striped"}

### Return type

[**OpenReceiptNormalizedMessage**](OpenReceiptNormalizedMessage.html)

<a name="postconversationsmessagemessagesbulk"></a>

## [**TextMessageListing**](TextMessageListing.html) PostConversationsMessageMessagesBulk (string conversationId, bool? useNormalizedMessage = null, List<string> body = null)



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
            var useNormalizedMessage = true;  // bool? | If true, response removes deprecated fields (textBody, media, stickers) (optional)  (default to false)
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
| **useNormalizedMessage** | **bool?**| If true, response removes deprecated fields (textBody, media, stickers) | [optional] [default to false] |
| **body** | [**List<string>**](string.html)| messageIds | [optional]  |
{: class="table table-striped"}

### Return type

[**TextMessageListing**](TextMessageListing.html)

<a name="postconversationsmessageparticipantcommunicationwrapup"></a>

## void PostConversationsMessageParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)



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
| **body** | [**WrapupInput**](WrapupInput.html)| Wrap-up | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsmessageparticipantmonitor"></a>

## void PostConversationsMessageParticipantMonitor (string conversationId, string participantId)



Listen in on the conversation from the point of view of a given participant.

PostConversationsMessageParticipantMonitor is a preview method and is subject to both breaking and non-breaking changes at any time without notice

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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsmessageparticipantreplace"></a>

## void PostConversationsMessageParticipantReplace (string conversationId, string participantId, TransferRequest body)



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
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsmessages"></a>

## [**MessageConversation**](MessageConversation.html) PostConversationsMessages (CreateOutboundMessagingConversationRequest body)



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
                MessageConversation result = apiInstance.PostConversationsMessages(body);
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
| **body** | [**CreateOutboundMessagingConversationRequest**](CreateOutboundMessagingConversationRequest.html)| Create outbound messaging conversation |  |
{: class="table table-striped"}

### Return type

[**MessageConversation**](MessageConversation.html)

<a name="postconversationsmessagesagentless"></a>

## [**SendAgentlessOutboundMessageResponse**](SendAgentlessOutboundMessageResponse.html) PostConversationsMessagesAgentless (SendAgentlessOutboundMessageRequest body)



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

            try
            { 
                // Send an agentless outbound message
                SendAgentlessOutboundMessageResponse result = apiInstance.PostConversationsMessagesAgentless(body);
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
| **body** | [**SendAgentlessOutboundMessageRequest**](SendAgentlessOutboundMessageRequest.html)| Create agentless outbound messaging request |  |
{: class="table table-striped"}

### Return type

[**SendAgentlessOutboundMessageResponse**](SendAgentlessOutboundMessageResponse.html)

<a name="postconversationsmessagesinboundopen"></a>

## [**OpenNormalizedMessage**](OpenNormalizedMessage.html) PostConversationsMessagesInboundOpen (OpenNormalizedMessage body)



Send an inbound Open Message

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
| **body** | [**OpenNormalizedMessage**](OpenNormalizedMessage.html)| NormalizedMessage |  |
{: class="table table-striped"}

### Return type

[**OpenNormalizedMessage**](OpenNormalizedMessage.html)

<a name="postconversationsmessagingintegrationsfacebook"></a>

## [**FacebookIntegration**](FacebookIntegration.html) PostConversationsMessagingIntegrationsFacebook (FacebookIntegrationRequest body)



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
| **body** | [**FacebookIntegrationRequest**](FacebookIntegrationRequest.html)| FacebookIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**FacebookIntegration**](FacebookIntegration.html)

<a name="postconversationsmessagingintegrationsinstagram"></a>

## [**InstagramIntegration**](InstagramIntegration.html) PostConversationsMessagingIntegrationsInstagram (InstagramIntegrationRequest body)



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
| **body** | [**InstagramIntegrationRequest**](InstagramIntegrationRequest.html)| InstagramIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**InstagramIntegration**](InstagramIntegration.html)

<a name="postconversationsmessagingintegrationsline"></a>

## [**LineIntegration**](LineIntegration.html) PostConversationsMessagingIntegrationsLine (LineIntegrationRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create a LINE messenger Integration (Deprecated)

This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-native-line-third-party-messaging-channel/

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
    public class PostConversationsMessagingIntegrationsLineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ConversationsApi();
            var body = new LineIntegrationRequest(); // LineIntegrationRequest | LineIntegrationRequest

            try
            { 
                // Create a LINE messenger Integration (Deprecated)
                LineIntegration result = apiInstance.PostConversationsMessagingIntegrationsLine(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsLine: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LineIntegrationRequest**](LineIntegrationRequest.html)| LineIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**LineIntegration**](LineIntegration.html)

<a name="postconversationsmessagingintegrationsopen"></a>

## [**OpenIntegration**](OpenIntegration.html) PostConversationsMessagingIntegrationsOpen (OpenIntegrationRequest body)



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
| **body** | [**OpenIntegrationRequest**](OpenIntegrationRequest.html)| OpenIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**OpenIntegration**](OpenIntegration.html)

<a name="postconversationsmessagingintegrationstwitter"></a>

## [**TwitterIntegration**](TwitterIntegration.html) PostConversationsMessagingIntegrationsTwitter (TwitterIntegrationRequest body)



Create a Twitter Integration

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
                // Create a Twitter Integration
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
| **body** | [**TwitterIntegrationRequest**](TwitterIntegrationRequest.html)| TwitterIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**TwitterIntegration**](TwitterIntegration.html)

<a name="postconversationsmessagingintegrationswhatsapp"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) PostConversationsMessagingIntegrationsWhatsapp (WhatsAppIntegrationRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

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
| **body** | [**WhatsAppIntegrationRequest**](WhatsAppIntegrationRequest.html)| WhatsAppIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="postconversationsmessagingintegrationswhatsappembeddedsignup"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) PostConversationsMessagingIntegrationsWhatsappEmbeddedsignup (WhatsAppEmbeddedSignupIntegrationRequest body)



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
| **body** | [**WhatsAppEmbeddedSignupIntegrationRequest**](WhatsAppEmbeddedSignupIntegrationRequest.html)| WhatsAppEmbeddedSignupIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="postconversationsmessagingsettings"></a>

## [**MessagingSetting**](MessagingSetting.html) PostConversationsMessagingSettings (MessagingSettingRequest body)



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
| **body** | [**MessagingSettingRequest**](MessagingSettingRequest.html)| MessagingSetting |  |
{: class="table table-striped"}

### Return type

[**MessagingSetting**](MessagingSetting.html)

<a name="postconversationsmessagingsupportedcontent"></a>

## [**SupportedContent**](SupportedContent.html) PostConversationsMessagingSupportedcontent (SupportedContent body)



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
| **body** | [**SupportedContent**](SupportedContent.html)| SupportedContent |  |
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent.html)

<a name="postconversationsparticipantsattributessearch"></a>

## [**JsonCursorSearchResponse**](JsonCursorSearchResponse.html) PostConversationsParticipantsAttributesSearch (ConversationParticipantSearchRequest body)



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
| **body** | [**ConversationParticipantSearchRequest**](ConversationParticipantSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**JsonCursorSearchResponse**](JsonCursorSearchResponse.html)

<a name="postconversationsscreenshareparticipantcommunicationwrapup"></a>

## void PostConversationsScreenshareParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)



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
| **body** | [**WrapupInput**](WrapupInput.html)| Wrap-up | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationssocialparticipantcommunicationwrapup"></a>

## void PostConversationsSocialParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)



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
| **body** | [**WrapupInput**](WrapupInput.html)| Wrap-up | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsvideoparticipantcommunicationwrapup"></a>

## void PostConversationsVideoParticipantCommunicationWrapup (string conversationId, string participantId, string communicationId, WrapupInput body = null)



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
| **body** | [**WrapupInput**](WrapupInput.html)| Wrap-up | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsvideosmeetings"></a>

## [**MeetingIdRecord**](MeetingIdRecord.html) PostConversationsVideosMeetings (GenerateMeetingIdRequest body)



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
| **body** | [**GenerateMeetingIdRequest**](GenerateMeetingIdRequest.html)| MeetingIdRequest |  |
{: class="table table-striped"}

### Return type

[**MeetingIdRecord**](MeetingIdRecord.html)

<a name="putconversationparticipantflaggedreason"></a>

## void PutConversationParticipantFlaggedreason (string conversationId, string participantId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putconversationsecureattributes"></a>

## **string** PutConversationSecureattributes (string conversationId, ConversationSecureAttributes body)



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
| **body** | [**ConversationSecureAttributes**](ConversationSecureAttributes.html)| Conversation Secure Attributes |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationtags"></a>

## **string** PutConversationTags (string conversationId, ConversationTagsUpdate body)



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
| **body** | [**ConversationTagsUpdate**](ConversationTagsUpdate.html)| Conversation Tags |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationscallparticipantcommunicationuuidata"></a>

## **Object** PutConversationsCallParticipantCommunicationUuidata (string conversationId, string participantId, string communicationId, SetUuiDataRequest body)



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
| **body** | [**SetUuiDataRequest**](SetUuiDataRequest.html)| UUIData Request |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="putconversationscallrecordingstate"></a>

## **string** PutConversationsCallRecordingstate (string conversationId, SetRecordingState body)



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
| **body** | [**SetRecordingState**](SetRecordingState.html)| SetRecordingState |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationscallbackrecordingstate"></a>

## **string** PutConversationsCallbackRecordingstate (string conversationId, SetRecordingState body)



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
| **body** | [**SetRecordingState**](SetRecordingState.html)| SetRecordingState |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationschatrecordingstate"></a>

## **string** PutConversationsChatRecordingstate (string conversationId, SetRecordingState body)



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
| **body** | [**SetRecordingState**](SetRecordingState.html)| SetRecordingState |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationscobrowsesessionrecordingstate"></a>

## **string** PutConversationsCobrowsesessionRecordingstate (string conversationId, SetRecordingState body)



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
| **body** | [**SetRecordingState**](SetRecordingState.html)| SetRecordingState |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationsemailmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) PutConversationsEmailMessagesDraft (string conversationId, EmailMessage body)



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
| **body** | [**EmailMessage**](EmailMessage.html)| Draft |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="putconversationsemailrecordingstate"></a>

## **string** PutConversationsEmailRecordingstate (string conversationId, SetRecordingState body)



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
| **body** | [**SetRecordingState**](SetRecordingState.html)| SetRecordingState |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationskeyconfiguration"></a>

## [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html) PutConversationsKeyconfiguration (string keyconfigurationsId, ConversationEncryptionConfiguration body)



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
| **body** | [**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html)| Encryption key configuration metadata |  |
{: class="table table-striped"}

### Return type

[**ConversationEncryptionConfiguration**](ConversationEncryptionConfiguration.html)

<a name="putconversationsmessagerecordingstate"></a>

## **string** PutConversationsMessageRecordingstate (string conversationId, SetRecordingState body)



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
| **body** | [**SetRecordingState**](SetRecordingState.html)| SetRecordingState |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationsmessagingintegrationslineintegrationid"></a>

## [**LineIntegration**](LineIntegration.html) PutConversationsMessagingIntegrationsLineIntegrationId (string integrationId, LineIntegrationRequest body)



Update a LINE messenger integration

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
    public class PutConversationsMessagingIntegrationsLineIntegrationIdExample
    {
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
            var body = new LineIntegrationRequest(); // LineIntegrationRequest | LineIntegrationRequest

            try
            { 
                // Update a LINE messenger integration
                LineIntegration result = apiInstance.PutConversationsMessagingIntegrationsLineIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingIntegrationsLineIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**LineIntegrationRequest**](LineIntegrationRequest.html)| LineIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**LineIntegration**](LineIntegration.html)

<a name="putconversationsmessagingsettingsdefault"></a>

## [**MessagingSetting**](MessagingSetting.html) PutConversationsMessagingSettingsDefault (MessagingSettingDefaultRequest body)



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
| **body** | [**MessagingSettingDefaultRequest**](MessagingSettingDefaultRequest.html)| MessagingSetting |  |
{: class="table table-striped"}

### Return type

[**MessagingSetting**](MessagingSetting.html)

<a name="putconversationsmessagingsupportedcontentdefault"></a>

## [**SupportedContent**](SupportedContent.html) PutConversationsMessagingSupportedcontentDefault (SupportedContentReference body)



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
| **body** | [**SupportedContentReference**](SupportedContentReference.html)| SupportedContent |  |
{: class="table table-striped"}

### Return type

[**SupportedContent**](SupportedContent.html)

<a name="putconversationsmessagingthreadingtimeline"></a>

## [**ConversationThreadingWindow**](ConversationThreadingWindow.html) PutConversationsMessagingThreadingtimeline (ConversationThreadingWindow body)



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
| **body** | [**ConversationThreadingWindow**](ConversationThreadingWindow.html)| ConversationThreadingWindowRequest |  |
{: class="table table-striped"}

### Return type

[**ConversationThreadingWindow**](ConversationThreadingWindow.html)

<a name="putconversationsscreensharerecordingstate"></a>

## **string** PutConversationsScreenshareRecordingstate (string conversationId, SetRecordingState body)



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
| **body** | [**SetRecordingState**](SetRecordingState.html)| SetRecordingState |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationssocialrecordingstate"></a>

## **string** PutConversationsSocialRecordingstate (string conversationId, SetRecordingState body)



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
| **body** | [**SetRecordingState**](SetRecordingState.html)| SetRecordingState |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putconversationsvideorecordingstate"></a>

## **string** PutConversationsVideoRecordingstate (string conversationId, SetRecordingState body)



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
| **body** | [**SetRecordingState**](SetRecordingState.html)| SetRecordingState |  |
{: class="table table-striped"}

### Return type

**string**

