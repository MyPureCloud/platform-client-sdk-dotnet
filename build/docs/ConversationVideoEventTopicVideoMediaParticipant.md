# ConversationVideoEventTopicVideoMediaParticipant

## ININ.PureCloudApi.Model.ConversationVideoEventTopicVideoMediaParticipant

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
| **User** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference) |  | [optional] |
| **Queue** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference) |  | [optional] |
| **Team** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**ConversationVideoEventTopicErrorBody**](ConversationVideoEventTopicErrorBody) |  | [optional] |
| **Script** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **int?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference) |  | [optional] |
| **ExternalContactInitialDivisionId** | **string** |  | [optional] |
| **ExternalOrganization** | [**ConversationVideoEventTopicUriReference**](ConversationVideoEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**ConversationVideoEventTopicWrapup**](ConversationVideoEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**ConversationVideoEventTopicConversationRoutingData**](ConversationVideoEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**ConversationVideoEventTopicJourneyContext**](ConversationVideoEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**ConversationVideoEventTopicQueueMediaSettings**](ConversationVideoEventTopicQueueMediaSettings) |  | [optional] |
| **AudioMuted** | **bool?** |  | [optional] |
| **VideoMuted** | **bool?** |  | [optional] |
| **SharingScreen** | **bool?** |  | [optional] |
| **PeerCount** | **int?** |  | [optional] |
| **Context** | **string** |  | [optional] |
| **Msids** | **List&lt;string&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 229.0.0_
