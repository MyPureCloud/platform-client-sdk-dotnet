# QueueConversationVideoEventTopicInternalMessage

## ININ.PureCloudApi.Model.QueueConversationVideoEventTopicInternalMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **State** | **string** |  | [optional] |
| **InitialState** | **string** |  | [optional] |
| **Provider** | **string** | The source provider of the message. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. | [optional] |
| **TargetUserId** | **string** | The user ID for the participant on receiving side of the internal message conversation. | [optional] |
| **SourceUserId** | **string** | The user ID for the participant on sending side of the internal message conversation. | [optional] |
| **ToAddress** | [**QueueConversationVideoEventTopicAddress**](QueueConversationVideoEventTopicAddress) | Address and name data for a call endpoint. | [optional] |
| **FromAddress** | [**QueueConversationVideoEventTopicAddress**](QueueConversationVideoEventTopicAddress) | Address and name data for a call endpoint. | [optional] |
| **Messages** | [**List&lt;QueueConversationVideoEventTopicInternalMessageDetails&gt;**](QueueConversationVideoEventTopicInternalMessageDetails) | The messages sent on this communication channel. | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
