# EmailRoutingTransferEvent

## ININ.PureCloudApi.Model.EmailRoutingTransferEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **TransferType** | **string** | Indicates the desired type of transfer. | |
| **CommandId** | **string** | The id (V4 UUID) used by the external platform to refer to the transfer in subsequent *Transfer events. | |
| **InitiatingCommunicationId** | **string** | Indicates the desired type of transfer. | |
| **TargetCommunicationId** | **string** | The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the &#x60;initiatingCommunicationId&#x60;. | |
| **ObjectCommunicationId** | **string** | The id (V4 UUID) of the communication that is being transferred. | |
| **DestinationQueueId** | **string** | The id (V4 UUID) of the desired destination queue that the object communication should be transferred to. | |
| **LanguageId** | **string** | The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation. | [optional] |
| **SkillIds** | **List&lt;string&gt;** | The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation. | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
