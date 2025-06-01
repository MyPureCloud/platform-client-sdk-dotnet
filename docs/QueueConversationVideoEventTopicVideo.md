# QueueConversationVideoEventTopicVideo

## ININ.PureCloudApi.Model.QueueConversationVideoEventTopicVideo

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** |  | [optional] |
| **InitialState** | **string** |  | [optional] |
| **Self** | [**QueueConversationVideoEventTopicAddress**](QueueConversationVideoEventTopicAddress) | Address and name data for a call endpoint. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Context** | **string** | The room id context (xmpp jid) for the conference session. | [optional] |
| **AudioMuted** | **bool?** | Indicates whether this participant has muted their outgoing audio. | [optional] |
| **VideoMuted** | **bool?** | Indicates whether this participant has muted/paused their outgoing video. | [optional] |
| **SharingScreen** | **bool?** | Indicates whether this participant is sharing their screen to the session. | [optional] |
| **PeerCount** | **long?** | The number of peer participants from the perspective of the participant in the conference. | [optional] |
| **Provider** | **string** | The media provider controlling the video. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. | [optional] |
| **Msids** | **List&lt;string&gt;** | List of media stream ids | [optional] |
| **Wrapup** | [**QueueConversationVideoEventTopicWrapup**](QueueConversationVideoEventTopicWrapup) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**QueueConversationVideoEventTopicAfterCallWork**](QueueConversationVideoEventTopicAfterCallWork) | A communication&#39;s after-call work data. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |
| **QueueMediaSettings** | [**QueueConversationVideoEventTopicQueueMediaSettings**](QueueConversationVideoEventTopicQueueMediaSettings) | Represents the queue setting for this media. | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
