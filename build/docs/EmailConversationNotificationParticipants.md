---
title: EmailConversationNotificationParticipants
---
## ININ.PureCloudApi.Model.EmailConversationNotificationParticipants

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
| **Queue** | [**EmailConversationNotificationUriReference**](EmailConversationNotificationUriReference.html) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**EmailConversationNotificationErrorInfo**](EmailConversationNotificationErrorInfo.html) |  | [optional] |
| **Script** | [**EmailConversationNotificationUriReference**](EmailConversationNotificationUriReference.html) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**EmailConversationNotificationUriReference**](EmailConversationNotificationUriReference.html) |  | [optional] |
| **ExternalOrganization** | [**EmailConversationNotificationUriReference**](EmailConversationNotificationUriReference.html) |  | [optional] |
| **Wrapup** | [**ConversationNotificationWrapup**](ConversationNotificationWrapup.html) |  | [optional] |
| **Subject** | **string** |  | [optional] |
| **MessagesSent** | **int?** |  | [optional] |
{: class="table table-striped"}


