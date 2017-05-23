---
title: CallbackConversationNotificationParticipants
---
## ININ.PureCloudApi.Model.CallbackConversationNotificationParticipants

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
| **User** | [**DependencyTrackingBuildNotificationNotificationUser**](DependencyTrackingBuildNotificationNotificationUser.html) |  | [optional] |
| **Queue** | [**CallbackConversationNotificationUriReference**](CallbackConversationNotificationUriReference.html) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**CallbackConversationNotificationErrorInfo**](CallbackConversationNotificationErrorInfo.html) |  | [optional] |
| **Script** | [**CallbackConversationNotificationUriReference**](CallbackConversationNotificationUriReference.html) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**CallbackConversationNotificationUriReference**](CallbackConversationNotificationUriReference.html) |  | [optional] |
| **ExternalOrganization** | [**CallbackConversationNotificationUriReference**](CallbackConversationNotificationUriReference.html) |  | [optional] |
| **Wrapup** | [**ConversationNotificationWrapup**](ConversationNotificationWrapup.html) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **OutboundPreview** | [**ConversationNotificationDialerPreview**](ConversationNotificationDialerPreview.html) |  | [optional] |
| **Voicemail** | [**DocumentDataV2NotificationWorkspace**](DocumentDataV2NotificationWorkspace.html) |  | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** |  | [optional] |
| **CallbackUserName** | **string** |  | [optional] |
| **SkipEnabled** | **bool?** |  | [optional] |
| **TimeoutSeconds** | **int?** |  | [optional] |
| **CallbackScheduledTime** | **DateTime?** |  | [optional] |
| **AutomatedCallbackConfigId** | **string** |  | [optional] |
{: class="table table-striped"}


