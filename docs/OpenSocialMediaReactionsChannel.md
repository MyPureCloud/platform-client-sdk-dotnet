# OpenSocialMediaReactionsChannel

## ININ.PureCloudApi.Model.OpenSocialMediaReactionsChannel

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The topic ID. | [optional] |
| **Platform** | **string** | The provider type. | [optional] |
| **Type** | **string** | Specifies if this message is part of a private or public conversation. | [optional] |
| **MessageId** | **string** | Unique provider ID of the message such as a Open message ID. | |
| **To** | [**OpenSocialMediaRecipient**](OpenSocialMediaRecipient) | Information about the recipient the message is sent to. | [optional] |
| **Time** | **DateTime?** | Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 246.0.0_
