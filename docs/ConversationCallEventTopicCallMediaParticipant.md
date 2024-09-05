# ConversationCallEventTopicCallMediaParticipant

## ININ.PureCloudApi.Model.ConversationCallEventTopicCallMediaParticipant

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
| **User** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference) |  | [optional] |
| **Queue** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference) |  | [optional] |
| **Team** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**ConversationCallEventTopicErrorBody**](ConversationCallEventTopicErrorBody) |  | [optional] |
| **Script** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **int?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference) |  | [optional] |
| **ExternalOrganization** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**ConversationCallEventTopicWrapup**](ConversationCallEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**ConversationCallEventTopicConversationRoutingData**](ConversationCallEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**ConversationCallEventTopicJourneyContext**](ConversationCallEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**ConversationCallEventTopicQueueMediaSettings**](ConversationCallEventTopicQueueMediaSettings) |  | [optional] |
| **Muted** | **bool?** |  | [optional] |
| **Confined** | **bool?** |  | [optional] |
| **Recording** | **bool?** |  | [optional] |
| **RecordingState** | **string** |  | [optional] |
| **SecurePause** | **bool?** |  | [optional] |
| **Group** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference) |  | [optional] |
| **Ani** | **string** |  | [optional] |
| **Dnis** | **string** |  | [optional] |
| **DocumentId** | **string** |  | [optional] |
| **MonitoredParticipantId** | **string** |  | [optional] |
| **CoachedParticipantId** | **string** |  | [optional] |
| **BargedParticipantId** | **string** |  | [optional] |
| **BargedTime** | **DateTime?** |  | [optional] |
| **ConsultParticipantId** | **string** |  | [optional] |
| **FaxStatus** | [**ConversationCallEventTopicFaxStatus**](ConversationCallEventTopicFaxStatus) |  | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
