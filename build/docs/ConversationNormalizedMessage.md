---
title: ConversationNormalizedMessage
---
## ININ.PureCloudApi.Model.ConversationNormalizedMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Unique ID of the message. Message receipts will have the same ID as the message they reference. | [optional] |
| **Channel** | [**ConversationMessagingChannel**](ConversationMessagingChannel.html) | Channel-specific information that describes the message and the message channel/provider. | [optional] |
| **Type** | **string** | Message type. | |
| **Text** | **string** | Message text. | [optional] |
| **Content** | [**List&lt;ConversationMessageContent&gt;**](ConversationMessageContent.html) | List of content elements | [optional] |
| **Status** | **string** | Message receipt status, only used with type Receipt. | [optional] |
| **Reasons** | [**List&lt;ConversationReason&gt;**](ConversationReason.html) | List of reasons for a message receipt that indicates the message has failed. Only used with Failed status. | [optional] |
| **OriginatingEntity** | **string** | Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies. | [optional] |
| **IsFinalReceipt** | **bool?** | Indicates if this is the last message receipt for this message, or if another message receipt can be expected. | [optional] |
| **Direction** | **string** | The direction of the message. | [optional] |
| **Metadata** | **Dictionary&lt;string, string&gt;** | Additional metadata about this message. | [optional] |
{: class="table table-striped"}


