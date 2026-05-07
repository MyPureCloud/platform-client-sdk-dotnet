# ConversationContentNotificationResponse

## ININ.PureCloudApi.Model.ConversationContentNotificationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OriginatingMessageId** | **string** | Reference to the ID of the original outbound notification message this response is for (e.g. the Apple requestIdentifier). | |
| **ReferenceId** | **string** | The business context reference associated with the notification (e.g. order ID, case ID). May be empty if the provider does not return it. | [optional] |
| **NotificationStatus** | **string** | The status of the notification response. | |
| **NotificationText** | **string** | The localized display text of the user&#39;s response (e.g. \&quot;Yes\&quot;). | [optional] |



_PureCloudPlatform.Client.V2 263.0.0_
