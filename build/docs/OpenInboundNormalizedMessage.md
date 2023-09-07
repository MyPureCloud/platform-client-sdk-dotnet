---
title: OpenInboundNormalizedMessage
---
## ININ.PureCloudApi.Model.OpenInboundNormalizedMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Channel** | [**OpenInboundMessageMessagingChannel**](OpenInboundMessageMessagingChannel.html) | Channel-specific information that describes the message and the message channel/provider. | |
| **Text** | **string** | Message text. | [optional] |
| **Content** | [**List&lt;OpenInboundMessageContent&gt;**](OpenInboundMessageContent.html) | List of content elements. | [optional] |
| **Metadata** | **Dictionary&lt;string, string&gt;** | Additional metadata about this message to capture non-channel specific data. | [optional] |
{: class="table table-striped"}


