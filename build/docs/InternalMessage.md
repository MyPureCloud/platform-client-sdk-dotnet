# InternalMessage

## ININ.PureCloudApi.Model.InternalMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **InitialState** | **string** | The initial connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment) | The time line of the participant&#39;s internal message, divided into activity segments. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Provider** | **string** | The source provider for the message. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **TargetUserId** | **string** | The user ID for the participant on receiving side of the internal message conversation. | [optional] |
| **SourceUserId** | **string** | The user ID for the participant on sending side of the internal message conversation. | [optional] |
| **ToAddress** | [**Address**](Address) | Address for the participant on receiving side of the internal message communication. | [optional] |
| **FromAddress** | [**Address**](Address) | Address for the participant on the sending side of the internal message communication. | [optional] |
| **Messages** | [**List&lt;InternalMessageDetails&gt;**](InternalMessageDetails) | The messages sent on this communication channel. | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
