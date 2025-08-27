# ConversationMessageEventTopicMessageMediaParticipant

## ININ.PureCloudApi.Model.ConversationMessageEventTopicMessageMediaParticipant

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
| **User** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference) |  | [optional] |
| **Queue** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference) |  | [optional] |
| **Team** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**ConversationMessageEventTopicErrorBody**](ConversationMessageEventTopicErrorBody) |  | [optional] |
| **Script** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **long?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **long?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference) |  | [optional] |
| **ExternalContactInitialDivisionId** | **string** |  | [optional] |
| **ExternalOrganization** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**ConversationMessageEventTopicWrapup**](ConversationMessageEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**ConversationMessageEventTopicConversationRoutingData**](ConversationMessageEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**ConversationMessageEventTopicJourneyContext**](ConversationMessageEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**ConversationMessageEventTopicQueueMediaSettings**](ConversationMessageEventTopicQueueMediaSettings) |  | [optional] |
| **Messages** | [**List&lt;ConversationMessageEventTopicMessageDetails&gt;**](ConversationMessageEventTopicMessageDetails) |  | [optional] |
| **Type** | **string** |  | [optional] |
| **RecipientCountry** | **string** |  | [optional] |
| **RecipientType** | **string** |  | [optional] |
| **ByoSmsIntegrationId** | **string** |  | [optional] |
| **MonitoredParticipantId** | **string** |  | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
