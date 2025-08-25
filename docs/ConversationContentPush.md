# ConversationContentPush

## ININ.PureCloudApi.Model.ConversationContentPush

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DeviceType** | **string** | The device type used to send the push notification | |
| **DeviceTokenId** | **string** | Unique Id of the device token | |
| **DeviceToken** | **string** | device token from the notification provider | |
| **FailedMessages** | [**List&lt;ConversationPushFailedMessageReferences&gt;**](ConversationPushFailedMessageReferences) | MessageIds failed to be sent which trigger the push event | |
| **NotificationMessage** | [**ConversationPushNotificationMessageLabel**](ConversationPushNotificationMessageLabel) | Title and body localized according to deployment | |
| **PushProviderIntegration** | [**ConversationPushProviderIntegration**](ConversationPushProviderIntegration) | Push provider integrations details configured on the deployment | |
| **Expiration** | **long?** | The time to live of the pushed message | |



_PureCloudPlatform.Client.V2 240.0.0_
