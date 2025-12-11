# ConsultTransferEvent

## ININ.PureCloudApi.Model.ConsultTransferEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **InitiatingCommunicationId** | **string** | The id (V4 UUID) of the communication representing the participant that is initiating the transfer. | |
| **DestinationCommunicationId** | **string** | The id (V4 UUID) of the communication that is being transferred to. | |
| **ObjectCommunicationId** | **string** | The id (V4 UUID) of the communication that is being transferred. | |



_PureCloudPlatform.Client.V2 251.0.0_
