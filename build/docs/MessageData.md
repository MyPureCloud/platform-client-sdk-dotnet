# MessageData

## ININ.PureCloudApi.Model.MessageData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ProviderMessageId** | **string** | The unique identifier of the message from provider | [optional] |
| **Timestamp** | **DateTime?** | The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **FromAddress** | **string** | The sender of the text message. | [optional] |
| **ToAddress** | **string** | The recipient of the text message. | [optional] |
| **Direction** | **string** | The direction of the message. | [optional] |
| **MessengerType** | **string** | Type of text messenger. | [optional] |
| **TextBody** | **string** | The body of the text message. (Deprecated - Instead use normalizedMessage.text) | |
| **Status** | **string** | The status of the message. | |
| **Media** | [**List&lt;MessageMedia&gt;**](MessageMedia) | The media details associated to a message. (Deprecated - Instead use normalizedMessage.content[index].attachment) | [optional] |
| **NormalizedMessage** | [**ConversationNormalizedMessage**](ConversationNormalizedMessage) | The message into normalized format | [optional] |
| **NormalizedReceipts** | [**List&lt;ConversationNormalizedMessage&gt;**](ConversationNormalizedMessage) | The delivery event associated with this message in normalized format, if the message direction was outbound | [optional] |
| **CreatedBy** | [**User**](User) | User who sent this message. | [optional] |
| **ConversationId** | **string** | The id of the conversation of this message. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
