---
title: ConversationChat
---
## ININ.PureCloudApi.Model.ConversationChat

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **RoomId** | **string** | The room id for the chat. | [optional] |
| **RecordingId** | **string** | A globally unique identifier for the recording associated with this chat. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment.html) | The time line of the participant&#39;s chat, divided into activity segments. | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **Direction** | **string** | The direction of the chat | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Provider** | **string** | The source provider for the email. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
{: class="table table-striped"}


