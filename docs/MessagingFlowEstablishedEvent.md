# MessagingFlowEstablishedEvent

## ININ.PureCloudApi.Model.MessagingFlowEstablishedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication. | |
| **InitialConfiguration** | [**MessagingInitialConfiguration**](MessagingInitialConfiguration) | Metadata about this communication. | |
| **SourceConfiguration** | [**SourceConfiguration**](SourceConfiguration) | Metadata about the source of this communication&#39;s interaction. | |



_PureCloudPlatform.Client.V2 227.0.0_
