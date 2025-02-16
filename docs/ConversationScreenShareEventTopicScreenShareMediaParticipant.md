# ConversationScreenShareEventTopicScreenShareMediaParticipant

## ININ.PureCloudApi.Model.ConversationScreenShareEventTopicScreenShareMediaParticipant

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
| **User** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference) |  | [optional] |
| **Queue** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference) |  | [optional] |
| **Team** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**ConversationScreenShareEventTopicErrorBody**](ConversationScreenShareEventTopicErrorBody) |  | [optional] |
| **Script** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **int?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference) |  | [optional] |
| **ExternalContactInitialDivisionId** | **string** |  | [optional] |
| **ExternalOrganization** | [**ConversationScreenShareEventTopicUriReference**](ConversationScreenShareEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**ConversationScreenShareEventTopicWrapup**](ConversationScreenShareEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**ConversationScreenShareEventTopicConversationRoutingData**](ConversationScreenShareEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**ConversationScreenShareEventTopicJourneyContext**](ConversationScreenShareEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**ConversationScreenShareEventTopicQueueMediaSettings**](ConversationScreenShareEventTopicQueueMediaSettings) |  | [optional] |
| **Context** | **string** |  | [optional] |
| **PeerCount** | **int?** |  | [optional] |
| **Sharing** | **bool?** |  | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
