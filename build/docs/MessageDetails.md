---
title: MessageDetails
---
## ININ.PureCloudApi.Model.MessageDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MessageId** | **string** | UUID identifying the message media. | [optional] |
| **MessageURI** | **string** | A URI for this message entity. | [optional] |
| **MessageStatus** | **string** | Indicates the delivery status of the message. | [optional] |
| **MessageSegmentCount** | **int?** | The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits. | [optional] |
| **MessageTime** | **DateTime?** | The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Media** | [**List&lt;MessageMedia&gt;**](MessageMedia.html) | The media (images, files, etc) associated with this message, if any | [optional] |
| **Stickers** | [**List&lt;MessageSticker&gt;**](MessageSticker.html) | One or more stickers associated with this message, if any | [optional] |
{: class="table table-striped"}


