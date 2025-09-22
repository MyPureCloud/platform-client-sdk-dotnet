# ConversationCobrowseEventTopicCobrowseMediaParticipant

## ININ.PureCloudApi.Model.ConversationCobrowseEventTopicCobrowseMediaParticipant

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
| **User** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference) |  | [optional] |
| **Queue** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference) |  | [optional] |
| **Team** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**ConversationCobrowseEventTopicErrorBody**](ConversationCobrowseEventTopicErrorBody) |  | [optional] |
| **Script** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **long?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **long?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference) |  | [optional] |
| **ExternalContactInitialDivisionId** | **string** |  | [optional] |
| **ExternalOrganization** | [**ConversationCobrowseEventTopicUriReference**](ConversationCobrowseEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**ConversationCobrowseEventTopicWrapup**](ConversationCobrowseEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**ConversationCobrowseEventTopicConversationRoutingData**](ConversationCobrowseEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**ConversationCobrowseEventTopicJourneyContext**](ConversationCobrowseEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**ConversationCobrowseEventTopicQueueMediaSettings**](ConversationCobrowseEventTopicQueueMediaSettings) |  | [optional] |
| **CobrowseSessionId** | **string** |  | [optional] |
| **CobrowseRole** | **string** |  | [optional] |
| **ViewerUrl** | **string** |  | [optional] |
| **ProviderEventTime** | **DateTime?** |  | [optional] |
| **Controlling** | **List&lt;string&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
