---
title: ConversationCallEventTopicCallMediaParticipant
---
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
| **User** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference.html) |  | [optional] |
| **Queue** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference.html) |  | [optional] |
| **Team** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference.html) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**ConversationCallEventTopicErrorBody**](ConversationCallEventTopicErrorBody.html) |  | [optional] |
| **Script** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference.html) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **int?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference.html) |  | [optional] |
| **ExternalOrganization** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference.html) |  | [optional] |
| **Wrapup** | [**ConversationCallEventTopicWrapup**](ConversationCallEventTopicWrapup.html) |  | [optional] |
| **ConversationRoutingData** | [**ConversationCallEventTopicConversationRoutingData**](ConversationCallEventTopicConversationRoutingData.html) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**ConversationCallEventTopicJourneyContext**](ConversationCallEventTopicJourneyContext.html) |  | [optional] |
| **StartAcwTime** | **DateTime?** |  | [optional] |
| **EndAcwTime** | **DateTime?** |  | [optional] |
| **ResumeTime** | **DateTime?** |  | [optional] |
| **MediaRoles** | **List&lt;string&gt;** |  | [optional] |
| **QueueMediaSettings** | [**ConversationCallEventTopicQueueMediaSettings**](ConversationCallEventTopicQueueMediaSettings.html) |  | [optional] |
| **Muted** | **bool?** |  | [optional] |
| **Confined** | **bool?** |  | [optional] |
| **Recording** | **bool?** |  | [optional] |
| **RecordingState** | **string** |  | [optional] |
| **SecurePause** | **bool?** |  | [optional] |
| **Group** | [**ConversationCallEventTopicUriReference**](ConversationCallEventTopicUriReference.html) |  | [optional] |
| **Ani** | **string** |  | [optional] |
| **Dnis** | **string** |  | [optional] |
| **DocumentId** | **string** |  | [optional] |
| **MonitoredParticipantId** | **string** |  | [optional] |
| **CoachedParticipantId** | **string** |  | [optional] |
| **BargedParticipantId** | **string** |  | [optional] |
| **BargedTime** | **DateTime?** |  | [optional] |
| **ConsultParticipantId** | **string** |  | [optional] |
| **FaxStatus** | [**ConversationCallEventTopicFaxStatus**](ConversationCallEventTopicFaxStatus.html) |  | [optional] |
{: class="table table-striped"}


