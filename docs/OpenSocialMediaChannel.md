# OpenSocialMediaChannel

## ININ.PureCloudApi.Model.OpenSocialMediaChannel

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The topic ID. | [optional] |
| **Platform** | **string** | The provider type. | [optional] |
| **Type** | **string** | Specifies if this message is part of a private or public conversation. | [optional] |
| **MessageId** | **string** | Unique provider ID of the message such as a Facebook message ID. | |
| **To** | [**OpenSocialMediaRecipient**](OpenSocialMediaRecipient) | Information about the recipient the message is sent to. | [optional] |
| **From** | [**OpenSocialMediaRecipient**](OpenSocialMediaRecipient) | Information about the recipient the message is received from. | |
| **Time** | **DateTime?** | Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Metadata** | **Object** | Information about the channel. | [optional] |
| **PublicMetadata** | [**OpenSocialMediaPublicMetadata**](OpenSocialMediaPublicMetadata) | Meta data of this public post. For example, used to define where in the thread the post exists. | |



_PureCloudPlatform.Client.V2 250.0.0_
