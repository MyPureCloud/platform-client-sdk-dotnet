# PhoneTransferEvent

## ININ.PureCloudApi.Model.PhoneTransferEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **TransferType** | **string** | Indicates the desired type of transfer. | |
| **CommandId** | **string** | The id (V4 UUID) used by the external platform to refer to the transfer in subsequent Transfer events. | |
| **InitiatingCommunicationId** | **string** | The id (V4 UUID) of the communication representing the participant that is initiating the transfer. | |
| **TargetCommunicationId** | **string** | The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the &#x60;initiatingCommunicationId&#x60;. | |
| **ObjectCommunicationId** | **string** | The id (V4 UUID) of the communication that is being transferred. | |
| **DestinationPhoneNumber** | **string** | The desired destination phone number that the object communication should be transferred to. | |



_PureCloudPlatform.Client.V2 239.0.0_
