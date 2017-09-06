---
title: CallConversationNotificationParticipants
---
## ININ.PureCloudApi.Model.CallConversationNotificationParticipants

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
| **Direction** | **string** |  | [optional] |
| **DisconnectType** | **string** |  | [optional] |
| **Held** | **bool?** |  | [optional] |
| **WrapupRequired** | **bool?** |  | [optional] |
| **WrapupPrompt** | **string** |  | [optional] |
| **User** | [**DocumentDataV2NotificationCreatedBy**](DocumentDataV2NotificationCreatedBy.html) |  | [optional] |
| **Queue** | [**CallConversationNotificationUriReference**](CallConversationNotificationUriReference.html) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**CallConversationNotificationErrorInfo**](CallConversationNotificationErrorInfo.html) |  | [optional] |
| **Script** | [**CallConversationNotificationUriReference**](CallConversationNotificationUriReference.html) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**CallConversationNotificationUriReference**](CallConversationNotificationUriReference.html) |  | [optional] |
| **ExternalOrganization** | [**CallConversationNotificationUriReference**](CallConversationNotificationUriReference.html) |  | [optional] |
| **Wrapup** | [**ConversationNotificationWrapup**](ConversationNotificationWrapup.html) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **Muted** | **bool?** |  | [optional] |
| **Confined** | **bool?** |  | [optional] |
| **Recording** | **bool?** |  | [optional] |
| **RecordingState** | **string** |  | [optional] |
| **Group** | [**CallConversationNotificationUriReference**](CallConversationNotificationUriReference.html) |  | [optional] |
| **Ani** | **string** |  | [optional] |
| **Dnis** | **string** |  | [optional] |
| **DocumentId** | **string** |  | [optional] |
| **MonitoredParticipantId** | **string** |  | [optional] |
| **ConsultParticipantId** | **string** |  | [optional] |
| **FaxStatus** | [**CallConversationNotificationFaxStatus**](CallConversationNotificationFaxStatus.html) |  | [optional] |
{: class="table table-striped"}


