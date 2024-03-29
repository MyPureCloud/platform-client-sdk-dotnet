---
title: OpenMessageNormalizedMessage
---
## ININ.PureCloudApi.Model.OpenMessageNormalizedMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Unique ID of the message generated by Messaging Platform. | [optional] |
| **Channel** | [**OpenMessagingChannel**](OpenMessagingChannel.html) | Channel-specific information that describes the message and the message channel/provider. | |
| **Type** | **string** | Message type. | |
| **Text** | **string** | Message text. | [optional] |
| **Content** | [**List&lt;OpenMessageContent&gt;**](OpenMessageContent.html) | List of content elements. | [optional] |
| **Metadata** | **Dictionary&lt;string, string&gt;** | Additional metadata about this message. | [optional] |
{: class="table table-striped"}


