---
title: MessageConversationNotificationMessageMediaParticipant
---
## ININ.PureCloudApi.Model.MessageConversationNotificationMessageMediaParticipant

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
| **Queue** | [**MessageConversationNotificationUriReference**](MessageConversationNotificationUriReference.html) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**MessageConversationNotificationErrorInfo**](MessageConversationNotificationErrorInfo.html) |  | [optional] |
| **Script** | [**MessageConversationNotificationUriReference**](MessageConversationNotificationUriReference.html) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**MessageConversationNotificationUriReference**](MessageConversationNotificationUriReference.html) |  | [optional] |
| **ExternalOrganization** | [**MessageConversationNotificationUriReference**](MessageConversationNotificationUriReference.html) |  | [optional] |
| **Wrapup** | [**ConversationNotificationWrapup**](ConversationNotificationWrapup.html) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **Messages** | [**List&lt;MessageConversationNotificationMessages&gt;**](MessageConversationNotificationMessages.html) |  | [optional] |
| **Type** | **string** |  | [optional] |
| **RecipientCountry** | **string** |  | [optional] |
| **RecipientType** | **string** |  | [optional] |
{: class="table table-striped"}


