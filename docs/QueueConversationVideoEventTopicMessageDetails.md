# QueueConversationVideoEventTopicMessageDetails

## ININ.PureCloudApi.Model.QueueConversationVideoEventTopicMessageDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MessageId** | **string** | UUID identifying the message media. | [optional] |
| **MessageTime** | **DateTime?** | The time when the message was sent or received. | [optional] |
| **MessageStatus** | **string** | Indicates the delivery status of the message. | [optional] |
| **MessageSegmentCount** | **long?** | The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits. | [optional] |
| **Media** | [**List&lt;QueueConversationVideoEventTopicMessageMedia&gt;**](QueueConversationVideoEventTopicMessageMedia) | The media (images, files, etc) associated with this message, if any | [optional] |
| **ErrorInfo** | [**QueueConversationVideoEventTopicErrorDetails**](QueueConversationVideoEventTopicErrorDetails) | Detailed information about an error response. | [optional] |
| **Stickers** | [**List&lt;QueueConversationVideoEventTopicMessageSticker&gt;**](QueueConversationVideoEventTopicMessageSticker) | A list of stickers included in the message | [optional] |
| **MessageMetadata** | [**QueueConversationVideoEventTopicMessageMetadata**](QueueConversationVideoEventTopicMessageMetadata) |  | [optional] |
| **SocialVisibility** | **string** | For social media messages, the visibility of the message in the originating social platform | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
