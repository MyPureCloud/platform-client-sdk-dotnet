# QueueConversationEventTopicMessage

## ININ.PureCloudApi.Model.QueueConversationEventTopicMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **State** | **string** |  | [optional] |
| **InitialState** | **string** |  | [optional] |
| **Direction** | **string** | Whether a message is inbound or outbound. | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **ErrorInfo** | [**QueueConversationEventTopicErrorDetails**](QueueConversationEventTopicErrorDetails) | Detailed information about an error response. | [optional] |
| **Provider** | **string** | The source provider of the email. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the email was placed on hold in the cloud clock if the email is currently on hold. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. | [optional] |
| **ToAddress** | [**QueueConversationEventTopicAddress**](QueueConversationEventTopicAddress) | Address and name data for a call endpoint. | [optional] |
| **FromAddress** | [**QueueConversationEventTopicAddress**](QueueConversationEventTopicAddress) | Address and name data for a call endpoint. | [optional] |
| **Messages** | [**List&lt;QueueConversationEventTopicMessageDetails&gt;**](QueueConversationEventTopicMessageDetails) | The messages sent on this communication channel. | [optional] |
| **MessagesTranscriptUri** | **string** | the messages transcript file uri. | [optional] |
| **Type** | **string** | Indicates the type of message platform from which the message originated. | [optional] |
| **RecipientCountry** | **string** | Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format. | [optional] |
| **RecipientType** | **string** | The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type. | [optional] |
| **JourneyContext** | [**QueueConversationEventTopicJourneyContext**](QueueConversationEventTopicJourneyContext) | A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context). | [optional] |
| **Wrapup** | [**QueueConversationEventTopicWrapup**](QueueConversationEventTopicWrapup) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**QueueConversationEventTopicAfterCallWork**](QueueConversationEventTopicAfterCallWork) | A communication&#39;s after-call work data. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |
| **AgentAssistantId** | **string** | UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation. | [optional] |
| **EngagementSource** | **string** | Provide more visibility into what integrations customers are creating with Open Messaging. String values are defined in the Constants.java named ENGAGEMENT_SOURCE_* | [optional] |
| **ByoSmsIntegrationId** | **string** |  | [optional] |
| **QueueMediaSettings** | [**QueueConversationEventTopicQueueMediaSettings**](QueueConversationEventTopicQueueMediaSettings) | Represents the queue setting for this media. | [optional] |
| **ResumeTime** | **DateTime?** | The time when a parked message should resume. | [optional] |
| **ParkTime** | **DateTime?** | The time when an  parked message was parked. | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
