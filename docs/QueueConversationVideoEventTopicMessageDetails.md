# QueueConversationVideoEventTopicMessageDetails

## ININ.PureCloudApi.Model.QueueConversationVideoEventTopicMessageDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MessageId** | **string** | UUID identifying the message media. | [optional] |
| **MessageTime** | **DateTime?** | The time when the message was sent or received. | [optional] |
| **MessageStatus** | **string** | Indicates the delivery status of the message. | [optional] |
| **MessageSegmentCount** | **int?** | The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits. | [optional] |
| **Media** | [**List&lt;QueueConversationVideoEventTopicMessageMedia&gt;**](QueueConversationVideoEventTopicMessageMedia) | The media (images, files, etc) associated with this message, if any | [optional] |
| **ErrorInfo** | [**QueueConversationVideoEventTopicErrorDetails**](QueueConversationVideoEventTopicErrorDetails) | Detailed information about an error response. | [optional] |
| **Stickers** | [**List&lt;QueueConversationVideoEventTopicMessageSticker&gt;**](QueueConversationVideoEventTopicMessageSticker) | A list of stickers included in the message | [optional] |
| **MessageMetadata** | [**QueueConversationVideoEventTopicMessageMetadata**](QueueConversationVideoEventTopicMessageMetadata) |  | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
