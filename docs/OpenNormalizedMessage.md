# OpenNormalizedMessage

## ININ.PureCloudApi.Model.OpenNormalizedMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Unique ID of the message. This ID is generated by Messaging Platform. Message receipts will have the same ID as the message they reference, as such should only be set when sending a message receipt. | [optional] |
| **Channel** | [**OpenMessagingChannel**](OpenMessagingChannel) | Channel-specific information that describes the message and the message channel/provider. | |
| **Type** | **string** | Message type. | |
| **Text** | **string** | Message text. | [optional] |
| **Content** | [**List&lt;OpenMessageContent&gt;**](OpenMessageContent) | List of content elements. | [optional] |
| **Status** | **string** | Message receipt status, only used with type Receipt. | [optional] |
| **Reasons** | [**List&lt;ConversationReason&gt;**](ConversationReason) | List of reasons for a message receipt that indicates the message has failed. Only used with Failed status. | [optional] |
| **IsFinalReceipt** | **bool?** | Indicates if this is the last message receipt for this message, or if another message receipt can be expected. | [optional] |
| **Direction** | **string** | The direction of the message. | [optional] |
| **Metadata** | **Dictionary&lt;string, string&gt;** | Additional metadata about this message. | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_