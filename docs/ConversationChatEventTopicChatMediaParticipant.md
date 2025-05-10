# ConversationChatEventTopicChatMediaParticipant

## ININ.PureCloudApi.Model.ConversationChatEventTopicChatMediaParticipant

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
| **User** | [**ConversationChatEventTopicUriReference**](ConversationChatEventTopicUriReference) |  | [optional] |
| **Queue** | [**ConversationChatEventTopicUriReference**](ConversationChatEventTopicUriReference) |  | [optional] |
| **Team** | [**ConversationChatEventTopicUriReference**](ConversationChatEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**ConversationChatEventTopicErrorBody**](ConversationChatEventTopicErrorBody) |  | [optional] |
| **Script** | [**ConversationChatEventTopicUriReference**](ConversationChatEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **long?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **long?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**ConversationChatEventTopicUriReference**](ConversationChatEventTopicUriReference) |  | [optional] |
| **ExternalContactInitialDivisionId** | **string** |  | [optional] |
| **ExternalOrganization** | [**ConversationChatEventTopicUriReference**](ConversationChatEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**ConversationChatEventTopicWrapup**](ConversationChatEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**ConversationChatEventTopicConversationRoutingData**](ConversationChatEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**ConversationChatEventTopicJourneyContext**](ConversationChatEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**ConversationChatEventTopicQueueMediaSettings**](ConversationChatEventTopicQueueMediaSettings) |  | [optional] |
| **RoomId** | **string** |  | [optional] |
| **AvatarImageUrl** | **string** |  | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
