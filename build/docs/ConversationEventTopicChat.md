# ConversationEventTopicChat

## ININ.PureCloudApi.Model.ConversationEventTopicChat

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** |  | [optional] |
| **InitialState** | **string** |  | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Provider** | **string** | The source provider of the chat. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **RoomId** | **string** | The room id for the chat. | [optional] |
| **AvatarImageUrl** | **string** | The avatar for the chat (if available). | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. | [optional] |
| **JourneyContext** | [**ConversationEventTopicJourneyContext**](ConversationEventTopicJourneyContext) |  | [optional] |
| **Wrapup** | [**ConversationEventTopicWrapup**](ConversationEventTopicWrapup) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**ConversationEventTopicAfterCallWork**](ConversationEventTopicAfterCallWork) | A communication&#39;s after-call work data. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |
| **QueueMediaSettings** | [**ConversationEventTopicQueueMediaSettings**](ConversationEventTopicQueueMediaSettings) | Represents the queue setting for this media. | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
