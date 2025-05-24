# CallBasic

## ININ.PureCloudApi.Model.CallBasic

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **InitialState** | **string** | The initial connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Direction** | **string** | The direction of the call | [optional] |
| **Recording** | **bool?** | True if this call is being recorded. | [optional] |
| **RecordingState** | **string** | State of recording on this call. | [optional] |
| **RecordersState** | [**RecordersState**](RecordersState) | Contains the states of different recorders. | [optional] |
| **Muted** | **bool?** | True if this call is muted so that remote participants can&#39;t hear any audio from this end. | [optional] |
| **Confined** | **bool?** | True if this call is held and the person on this side hears hold music. | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **SecurePause** | **bool?** | True when the recording of this call is in secure pause status. | [optional] |
| **RecordingId** | **string** | A globally unique identifier for the recording associated with this call. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment) | The time line of the participant&#39;s call, divided into activity segments. | [optional] |
| **ErrorInfo** | [**ErrorInfo**](ErrorInfo) |  | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DocumentId** | **string** | If call is an outbound fax of a document from content management, then this is the id in content management. | [optional] |
| **StartAlertingTime** | **DateTime?** | The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DisconnectReasons** | [**List&lt;DisconnectReason&gt;**](DisconnectReason) | List of reasons that this call was disconnected. This will be set once the call disconnects. | [optional] |
| **FaxStatus** | [**FaxStatus**](FaxStatus) | Extra information on fax transmission. | [optional] |
| **Provider** | **string** | The source provider for the call. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **UuiData** | **string** | User to User Information (UUI) data managed by SIP session application. | [optional] |
| **Self** | [**Address**](Address) | Address and name data for a call endpoint. | [optional] |
| **Other** | [**Address**](Address) | Address and name data for a call endpoint. | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**AfterCallWork**](AfterCallWork) | After-call work for the communication. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |
| **AgentAssistantId** | **string** | UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation. | [optional] |
| **QueueMediaSettings** | [**ConversationQueueMediaSettings**](ConversationQueueMediaSettings) | Represents the queue settings for this media type. | [optional] |
| **Disposition** | [**Disposition**](Disposition) | Call resolution data for Dialer bulk make calls commands. | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
