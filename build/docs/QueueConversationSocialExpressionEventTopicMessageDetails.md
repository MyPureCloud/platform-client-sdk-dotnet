---
title: QueueConversationSocialExpressionEventTopicMessageDetails
---
## ININ.PureCloudApi.Model.QueueConversationSocialExpressionEventTopicMessageDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MessageId** | **string** | UUID identifying the message media. | [optional] |
| **MessageTime** | **DateTime?** | The time when the message was sent or received. | [optional] |
| **MessageStatus** | **string** | Indicates the delivery status of the message. | [optional] |
| **MessageSegmentCount** | **int?** | The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits. | [optional] |
| **Media** | [**List&lt;QueueConversationSocialExpressionEventTopicMessageMedia&gt;**](QueueConversationSocialExpressionEventTopicMessageMedia.html) | The media (images, files, etc) associated with this message, if any | [optional] |
| **ErrorInfo** | [**QueueConversationSocialExpressionEventTopicErrorDetails**](QueueConversationSocialExpressionEventTopicErrorDetails.html) | Detailed information about an error response. | [optional] |
| **Stickers** | [**List&lt;QueueConversationSocialExpressionEventTopicMessageSticker&gt;**](QueueConversationSocialExpressionEventTopicMessageSticker.html) | A list of stickers included in the message | [optional] |
| **MessageMetadata** | [**QueueConversationSocialExpressionEventTopicMessageMetadata**](QueueConversationSocialExpressionEventTopicMessageMetadata.html) |  | [optional] |
{: class="table table-striped"}


