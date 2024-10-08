# QueueConversationSocialExpressionEventTopicAddress

## ININ.PureCloudApi.Model.QueueConversationSocialExpressionEventTopicAddress

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | This will be nameRaw if present, or a locality lookup of the address field otherwise. | [optional] |
| **NameRaw** | **string** | The name as close to the bits on the wire as possible. | [optional] |
| **AddressNormalized** | **string** | The normalized address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table. | [optional] |
| **AddressRaw** | **string** | The address as close to the bits on the wire as possible. | [optional] |
| **AddressDisplayable** | **string** | The displayable address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table. | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
