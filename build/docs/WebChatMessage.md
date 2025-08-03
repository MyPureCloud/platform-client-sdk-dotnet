# WebChatMessage

## ININ.PureCloudApi.Model.WebChatMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Conversation** | [**WebChatConversation**](WebChatConversation) | The identifier of the conversation | |
| **Sender** | [**WebChatMemberInfo**](WebChatMemberInfo) | The member who sent the message | |
| **Body** | **string** | The message body. | |
| **BodyType** | **string** | The purpose of the message within the conversation, such as a standard text entry versus a greeting. | |
| **Timestamp** | **DateTime?** | The timestamp of the message, in ISO-8601 format | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
