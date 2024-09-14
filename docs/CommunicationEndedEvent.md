# CommunicationEndedEvent

## ININ.PureCloudApi.Model.CommunicationEndedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication | |
| **DisconnectType** | **string** | Indicates how this communication was ended. | |
| **DestinationConversationId** | **string** | The id (V4 UUID) of the conversation that the communication is being moved to when conversations are merged. | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
