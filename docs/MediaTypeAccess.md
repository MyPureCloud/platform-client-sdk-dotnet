# MediaTypeAccess

## ININ.PureCloudApi.Model.MediaTypeAccess

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Inbound** | [**List&lt;MediaType&gt;**](MediaType) | List of media types allowed for inbound messages from customers. If inbound messages from a customer contain media that is not in this list, the media will be dropped from the outbound message. | [optional] |
| **Outbound** | [**List&lt;MediaType&gt;**](MediaType) | List of media types allowed for outbound messages to customers. If an outbound message is sent that contains media that is not in this list, the message will not be sent. | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
