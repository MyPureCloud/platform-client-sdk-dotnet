# ConversationEventTopicCall

## ININ.PureCloudApi.Model.ConversationEventTopicCall

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **State** | **string** |  | [optional] |
| **InitialState** | **string** |  | [optional] |
| **Recording** | **bool?** | True if this call is being recorded. | [optional] |
| **RecordingState** | **string** | State of recording on this call. | [optional] |
| **Muted** | **bool?** | True if this call is muted so that remote participants can&#39;t hear any audio from this end. | [optional] |
| **Confined** | **bool?** | True if this call is held and the person on this side hears hold music. | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **SecurePause** | **bool?** | True when the recording of this call is in secure pause status. | [optional] |
| **ErrorInfo** | [**ConversationEventTopicErrorDetails**](ConversationEventTopicErrorDetails) |  | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. | [optional] |
| **Direction** | **string** | Whether a call is inbound or outbound. | [optional] |
| **DocumentId** | **string** | If call is a fax of a document in content management, the id of the document in content management. | [optional] |
| **Self** | [**ConversationEventTopicAddress**](ConversationEventTopicAddress) |  | [optional] |
| **Other** | [**ConversationEventTopicAddress**](ConversationEventTopicAddress) | Address and name data for a call endpoint. | [optional] |
| **Provider** | **string** | The source provider of the call. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. | [optional] |
| **DisconnectReasons** | [**List&lt;ConversationEventTopicDisconnectReason&gt;**](ConversationEventTopicDisconnectReason) | List of reasons that this call was disconnected. This will be set once the call disconnects. | [optional] |
| **FaxStatus** | [**ConversationEventTopicFaxStatus**](ConversationEventTopicFaxStatus) |  | [optional] |
| **UuiData** | **string** | User to User Information (UUI) data managed by SIP session application. | [optional] |
| **BargedTime** | **DateTime?** | The timestamp when this participant was connected to the barge conference in the provider clock. | [optional] |
| **Wrapup** | [**ConversationEventTopicWrapup**](ConversationEventTopicWrapup) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**ConversationEventTopicAfterCallWork**](ConversationEventTopicAfterCallWork) |  | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |
| **AgentAssistantId** | **string** | UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation. | [optional] |
| **QueueMediaSettings** | [**ConversationEventTopicQueueMediaSettings**](ConversationEventTopicQueueMediaSettings) |  | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
