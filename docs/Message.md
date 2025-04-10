# Message

## ININ.PureCloudApi.Model.Message

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **InitialState** | **string** | The initial connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment) | The time line of the participant&#39;s message, divided into activity segments. | [optional] |
| **Direction** | **string** | The direction of the message. | [optional] |
| **RecordingId** | **string** | A globally unique identifier for the recording associated with this message. | [optional] |
| **ErrorInfo** | [**ErrorBody**](ErrorBody) |  | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the message was placed on hold in the cloud clock if the message is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **StartAlertingTime** | **DateTime?** | The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Provider** | **string** | The source provider for the message. | [optional] |
| **Authenticated** | **bool?** | If true, the participant member is authenticated. | [optional] |
| **Type** | **string** | Indicates the type of message platform from which the message originated. | [optional] |
| **RecipientCountry** | **string** | Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format. | [optional] |
| **RecipientType** | **string** | The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **ToAddress** | [**Address**](Address) | Address and name data for a call endpoint. | [optional] |
| **FromAddress** | [**Address**](Address) | Address and name data for a call endpoint. | [optional] |
| **Messages** | [**List&lt;MessageDetails&gt;**](MessageDetails) | The messages sent on this communication channel. | [optional] |
| **JourneyContext** | [**JourneyContext**](JourneyContext) | A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context). | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**AfterCallWork**](AfterCallWork) | After-call work for the communication. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |
| **AgentAssistantId** | **string** | UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation. | [optional] |
| **ByoSmsIntegrationId** | **string** | The internal id representing the customer supplied sms integration message. | [optional] |
| **QueueMediaSettings** | [**ConversationQueueMediaSettings**](ConversationQueueMediaSettings) | Represents the queue settings for this media type. | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
