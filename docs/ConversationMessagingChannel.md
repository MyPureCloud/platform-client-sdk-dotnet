# ConversationMessagingChannel

## ININ.PureCloudApi.Model.ConversationMessagingChannel

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The integration ID. | [optional] |
| **Platform** | **string** | The provider type. | [optional] |
| **Type** | **string** | Specifies if this message is part of a private or public conversation. | [optional] |
| **MessageId** | **string** | Unique provider ID of the message such as a Facebook message ID. | [optional] |
| **To** | [**ConversationMessagingToRecipient**](ConversationMessagingToRecipient) | Information about the recipient the message is sent to. | [optional] |
| **From** | [**ConversationMessagingFromRecipient**](ConversationMessagingFromRecipient) | Information about the recipient the message is received from. | [optional] |
| **Time** | **DateTime?** | Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Time the message was edited. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateDeleted** | **DateTime?** | Time the message was deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **PublicMetadata** | [**ConversationPublicMetadata**](ConversationPublicMetadata) | Information about a public message. | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
