# OpenMessagingChannel

## ININ.PureCloudApi.Model.OpenMessagingChannel

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The Messaging Platform integration ID. | [optional] |
| **Platform** | **string** | The provider type. | [optional] |
| **Type** | **string** | Specifies if this message is part of a private or public conversation. | [optional] |
| **MessageId** | **string** | Unique provider ID of the message such as a Facebook message ID. | [optional] |
| **To** | [**OpenMessagingToRecipient**](OpenMessagingToRecipient) | Information about the recipient the message is sent to. | |
| **From** | [**OpenMessagingFromRecipient**](OpenMessagingFromRecipient) | Information about the recipient the message is received from. | |
| **Time** | **DateTime?** | Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Metadata** | **Object** | Information about the channel. | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
