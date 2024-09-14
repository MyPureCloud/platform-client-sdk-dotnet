# QueueConversationMessageEventTopicMessageMediaParticipant

## ININ.PureCloudApi.Model.QueueConversationMessageEventTopicMessageMediaParticipant

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
| **User** | [**QueueConversationMessageEventTopicUriReference**](QueueConversationMessageEventTopicUriReference) |  | [optional] |
| **Queue** | [**QueueConversationMessageEventTopicUriReference**](QueueConversationMessageEventTopicUriReference) |  | [optional] |
| **Team** | [**QueueConversationMessageEventTopicUriReference**](QueueConversationMessageEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**QueueConversationMessageEventTopicErrorBody**](QueueConversationMessageEventTopicErrorBody) |  | [optional] |
| **Script** | [**QueueConversationMessageEventTopicUriReference**](QueueConversationMessageEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **int?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**QueueConversationMessageEventTopicUriReference**](QueueConversationMessageEventTopicUriReference) |  | [optional] |
| **ExternalOrganization** | [**QueueConversationMessageEventTopicUriReference**](QueueConversationMessageEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**QueueConversationMessageEventTopicWrapup**](QueueConversationMessageEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**QueueConversationMessageEventTopicConversationRoutingData**](QueueConversationMessageEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**QueueConversationMessageEventTopicJourneyContext**](QueueConversationMessageEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**QueueConversationMessageEventTopicQueueMediaSettings**](QueueConversationMessageEventTopicQueueMediaSettings) |  | [optional] |
| **Messages** | [**List&lt;QueueConversationMessageEventTopicMessageDetails&gt;**](QueueConversationMessageEventTopicMessageDetails) |  | [optional] |
| **Type** | **string** |  | [optional] |
| **RecipientCountry** | **string** |  | [optional] |
| **RecipientType** | **string** |  | [optional] |
| **ByoSmsIntegrationId** | **string** |  | [optional] |
| **MonitoredParticipantId** | **string** |  | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
