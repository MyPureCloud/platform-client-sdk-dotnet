---
title: MessageData
---
## ININ.PureCloudApi.Model.MessageData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ProviderMessageId** | **string** | The unique identifier of the message from provider | [optional] |
| **Timestamp** | **DateTime?** | The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **FromAddress** | **string** | The sender of the text message. | [optional] |
| **ToAddress** | **string** | The recipient of the text message. | [optional] |
| **Direction** | **string** | The direction of the message. | [optional] |
| **MessengerType** | **string** | Type of text messenger. | [optional] |
| **TextBody** | **string** | The body of the text message. | |
| **Status** | **string** | The status of the message. | |
| **Media** | [**List&lt;MessageMedia&gt;**](MessageMedia.html) | The media details associated to a message. | [optional] |
| **Stickers** | [**List&lt;MessageSticker&gt;**](MessageSticker.html) | The sticker details associated to a message. | [optional] |
| **CreatedBy** | [**User**](User.html) | User who sent this message. | [optional] |
| **ConversationId** | **string** | The id of the conversation of this message. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


