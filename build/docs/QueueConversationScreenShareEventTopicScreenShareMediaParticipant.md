# QueueConversationScreenShareEventTopicScreenShareMediaParticipant

## ININ.PureCloudApi.Model.QueueConversationScreenShareEventTopicScreenShareMediaParticipant

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
| **User** | [**QueueConversationScreenShareEventTopicUriReference**](QueueConversationScreenShareEventTopicUriReference) |  | [optional] |
| **Queue** | [**QueueConversationScreenShareEventTopicUriReference**](QueueConversationScreenShareEventTopicUriReference) |  | [optional] |
| **Team** | [**QueueConversationScreenShareEventTopicUriReference**](QueueConversationScreenShareEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**QueueConversationScreenShareEventTopicErrorBody**](QueueConversationScreenShareEventTopicErrorBody) |  | [optional] |
| **Script** | [**QueueConversationScreenShareEventTopicUriReference**](QueueConversationScreenShareEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **long?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **long?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**QueueConversationScreenShareEventTopicUriReference**](QueueConversationScreenShareEventTopicUriReference) |  | [optional] |
| **ExternalContactInitialDivisionId** | **string** |  | [optional] |
| **ExternalOrganization** | [**QueueConversationScreenShareEventTopicUriReference**](QueueConversationScreenShareEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**QueueConversationScreenShareEventTopicWrapup**](QueueConversationScreenShareEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**QueueConversationScreenShareEventTopicConversationRoutingData**](QueueConversationScreenShareEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**QueueConversationScreenShareEventTopicJourneyContext**](QueueConversationScreenShareEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**QueueConversationScreenShareEventTopicQueueMediaSettings**](QueueConversationScreenShareEventTopicQueueMediaSettings) |  | [optional] |
| **Context** | **string** |  | [optional] |
| **PeerCount** | **long?** |  | [optional] |
| **Sharing** | **bool?** |  | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
