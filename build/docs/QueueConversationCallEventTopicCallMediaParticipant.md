# QueueConversationCallEventTopicCallMediaParticipant

## ININ.PureCloudApi.Model.QueueConversationCallEventTopicCallMediaParticipant

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
| **User** | [**QueueConversationCallEventTopicUriReference**](QueueConversationCallEventTopicUriReference) |  | [optional] |
| **Queue** | [**QueueConversationCallEventTopicUriReference**](QueueConversationCallEventTopicUriReference) |  | [optional] |
| **Team** | [**QueueConversationCallEventTopicUriReference**](QueueConversationCallEventTopicUriReference) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**QueueConversationCallEventTopicErrorBody**](QueueConversationCallEventTopicErrorBody) |  | [optional] |
| **Script** | [**QueueConversationCallEventTopicUriReference**](QueueConversationCallEventTopicUriReference) |  | [optional] |
| **WrapupTimeoutMs** | **long?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **long?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**QueueConversationCallEventTopicUriReference**](QueueConversationCallEventTopicUriReference) |  | [optional] |
| **ExternalContactInitialDivisionId** | **string** |  | [optional] |
| **ExternalOrganization** | [**QueueConversationCallEventTopicUriReference**](QueueConversationCallEventTopicUriReference) |  | [optional] |
| **Wrapup** | [**QueueConversationCallEventTopicWrapup**](QueueConversationCallEventTopicWrapup) |  | [optional] |
| **ConversationRoutingData** | [**QueueConversationCallEventTopicConversationRoutingData**](QueueConversationCallEventTopicConversationRoutingData) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**QueueConversationCallEventTopicJourneyContext**](QueueConversationCallEventTopicJourneyContext) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **ParkTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**QueueConversationCallEventTopicQueueMediaSettings**](QueueConversationCallEventTopicQueueMediaSettings) |  | [optional] |
| **Muted** | **bool?** |  | [optional] |
| **Confined** | **bool?** |  | [optional] |
| **Recording** | **bool?** |  | [optional] |
| **RecordingState** | **string** |  | [optional] |
| **SecurePause** | **bool?** |  | [optional] |
| **Group** | [**QueueConversationCallEventTopicUriReference**](QueueConversationCallEventTopicUriReference) |  | [optional] |
| **Ani** | **string** |  | [optional] |
| **Dnis** | **string** |  | [optional] |
| **DocumentId** | **string** |  | [optional] |
| **MonitoredParticipantId** | **string** |  | [optional] |
| **CoachedParticipantId** | **string** |  | [optional] |
| **BargedParticipantId** | **string** |  | [optional] |
| **BargedTime** | **DateTime?** |  | [optional] |
| **ConsultParticipantId** | **string** |  | [optional] |
| **FaxStatus** | [**QueueConversationCallEventTopicFaxStatus**](QueueConversationCallEventTopicFaxStatus) |  | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
