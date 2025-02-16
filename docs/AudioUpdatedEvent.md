# AudioUpdatedEvent

## ININ.PureCloudApi.Model.AudioUpdatedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication | |
| **AudioState** | [**AudioState**](AudioState) | The updated audioState for the target communication. | |



_PureCloudPlatform.Client.V2 227.0.0_
