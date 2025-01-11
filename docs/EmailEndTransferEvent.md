# EmailEndTransferEvent

## ININ.PureCloudApi.Model.EmailEndTransferEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommandId** | **string** | The id (V4 UUID) used to identify the transfer already started by the external platform. | |
| **FinalState** | **string** | Indicates whether the transfer completed successfully, was cancelled, or failed for some reason. | |
| **ObjectCommunicationId** | **string** | The id (V4 UUID) of the communication that was being transferred. | |



_PureCloudPlatform.Client.V2 224.1.0_
