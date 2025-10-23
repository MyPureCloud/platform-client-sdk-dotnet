# ConversationCallbackEventTopicCallbackMediaParticipant

## ININ.PureCloudApi.Model.ConversationCallbackEventTopicCallbackMediaParticipant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Name** | **string** |  | [optional] |
| **Address** | **string** |  | [optional] |
| **StartTime** | **DateTime?** |  | [optional] |
| **ConnectedTime** | **DateTime?** |  | [optional] |
| **EndTime** | **DateTime?** |  | [optional] |
| **StartHoldTime** | **DateTime?** |  | [optional] |
| **Purpose** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **InitialState** | **string** |  | [optional] |
| **Direction** | **string** |  | [optional] |
| **DisconnectType** | **string** |  | [optional] |
| **Held** | **bool?** |  | [optional] |
| **WrapupRequired** | **bool?** |  | [optional] |
| **WrapupPrompt** | **string** |  | [optional] |
| **User** | [**ConversationCallbackEventTopicUriReference**](ConversationCallbackEventTopicUriReference) |  | [optional] |
| **Queue** | [**ConversationCallbackEventTopicUriReference**](ConversationCallbackEventTopicUriReference) |  | [optional] |
| **Team** | [**ConversationCallbackEventTopicUriReference**](ConversationCallbackEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**ConversationCallbackEventTopicErrorBody**](ConversationCallbackEventTopicErrorBody) |  | [optional] |
| **Script** | [**ConversationCallbackEventTopicUriReference**](ConversationCallbackEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **long?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **long?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**ConversationCallbackEventTopicUriReference**](ConversationCallbackEventTopicUriReference) |  | [optional] |
| **ExternalContactInitialDivisionId** | **string** |  | [optional] |
| **ExternalOrganization** | [**ConversationCallbackEventTopicUriReference**](ConversationCallbackEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**ConversationCallbackEventTopicWrapup**](ConversationCallbackEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**ConversationCallbackEventTopicConversationRoutingData**](ConversationCallbackEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**ConversationCallbackEventTopicJourneyContext**](ConversationCallbackEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**ConversationCallbackEventTopicQueueMediaSettings**](ConversationCallbackEventTopicQueueMediaSettings) |  | [optional] |
| **OutboundPreview** | [**ConversationCallbackEventTopicDialerPreview**](ConversationCallbackEventTopicDialerPreview) |  | [optional] |
| **Voicemail** | [**ConversationCallbackEventTopicVoicemail**](ConversationCallbackEventTopicVoicemail) |  | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** |  | [optional] |
| **CallbackUserName** | **string** |  | [optional] |
| **SkipEnabled** | **bool?** |  | [optional] |
| **ExternalCampaign** | **bool?** |  | [optional] |
| **TimeoutSeconds** | **long?** |  | [optional] |
| **CallbackScheduledTime** | **DateTime?** |  | [optional] |
| **AutomatedCallbackConfigId** | **string** |  | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
