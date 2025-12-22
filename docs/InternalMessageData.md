# InternalMessageData

## ININ.PureCloudApi.Model.InternalMessageData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Conversation** | [**AddressableEntityRef**](AddressableEntityRef) | The conversation of this message. | [optional] |
| **CommunicationId** | **string** | The id of the communication of this message. | [optional] |
| **Timestamp** | **DateTime?** | The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Sender** | [**UserReference**](UserReference) | The sender of the text message. | [optional] |
| **Recipient** | [**UserReference**](UserReference) | The recipient of the text message. | [optional] |
| **NormalizedMessage** | [**ConversationNormalizedMessage**](ConversationNormalizedMessage) | The message into normalized format | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
