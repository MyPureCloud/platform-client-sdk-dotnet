# Email

## ININ.PureCloudApi.Model.Email

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **InitialState** | **string** | The initial connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **Subject** | **string** | The subject for the initial email that started this conversation. | [optional] |
| **MessagesSent** | **int?** | The number of email messages sent by this participant. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment) | The time line of the participant&#39;s email, divided into activity segments. | [optional] |
| **Direction** | **string** | The direction of the email | [optional] |
| **RecordingId** | **string** | A globally unique identifier for the recording associated with this call. | [optional] |
| **ErrorInfo** | [**ErrorBody**](ErrorBody) |  | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the email was placed on hold in the cloud clock if the email is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **StartAlertingTime** | **DateTime?** | The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AutoGenerated** | **bool?** | Indicates that the email was auto-generated like an Out of Office reply. | [optional] |
| **Provider** | **string** | The source provider for the email. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **MessageId** | **string** | A globally unique identifier for the stored content of this communication. | [optional] |
| **DraftAttachments** | [**List&lt;Attachment&gt;**](Attachment) | A list of uploaded attachments on the email draft. | [optional] |
| **Spam** | **bool?** | Indicates if the inbound email was marked as spam. | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**AfterCallWork**](AfterCallWork) | After-call work for the communication. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |
| **QueueMediaSettings** | [**ConversationQueueMediaSettings**](ConversationQueueMediaSettings) | Represents the queue settings for this media type. | [optional] |
| **ParkTime** | **DateTime?** | Represents the time when an email was put into parked state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_