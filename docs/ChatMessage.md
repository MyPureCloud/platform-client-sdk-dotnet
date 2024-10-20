# ChatMessage

## ININ.PureCloudApi.Model.ChatMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Body** | **string** | The message body | [optional] |
| **Id** | **string** |  | [optional] |
| **To** | **string** | The message recipient | [optional] |
| **From** | **string** | The message sender | [optional] |
| **Utc** | **string** |  | [optional] |
| **Chat** | **string** | The interaction id (if available) | [optional] |
| **Message** | **string** | The message id | [optional] |
| **Type** | **string** |  | [optional] |
| **BodyType** | **string** | Type of the message body (v2 chats only) | [optional] |
| **SenderCommunicationId** | **string** | Communication of sender (v2 chats only) | [optional] |
| **ParticipantPurpose** | **string** | Participant purpose of sender (v2 chats only) | [optional] |
| **User** | [**ChatMessageUser**](ChatMessageUser) | The user information for the sender (if available) | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
