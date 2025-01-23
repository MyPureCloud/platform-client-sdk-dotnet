# Video

## ININ.PureCloudApi.Model.Video

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **InitialState** | **string** | The initial connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Context** | **string** | The room id context (xmpp jid) for the conference session. | [optional] |
| **AudioMuted** | **bool?** | Indicates whether this participant has muted their outgoing audio. | [optional] |
| **VideoMuted** | **bool?** | Indicates whether this participant has muted/paused their outgoing video. | [optional] |
| **SharingScreen** | **bool?** | Indicates whether this participant is sharing their screen to the session. | [optional] |
| **PeerCount** | **int?** | The number of peer participants from the perspective of the participant in the conference. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartAlertingTime** | **DateTime?** | The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Provider** | **string** | The source provider for the video. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **Msids** | **List&lt;string&gt;** | List of media stream ids | [optional] |
| **Self** | [**Address**](Address) | Address and name data for a call endpoint. | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**AfterCallWork**](AfterCallWork) | After-call work for the communication. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
