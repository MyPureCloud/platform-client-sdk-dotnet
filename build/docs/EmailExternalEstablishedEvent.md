# EmailExternalEstablishedEvent

## ININ.PureCloudApi.Model.EmailExternalEstablishedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication. | |
| **DisplayName** | **string** | A name for the participant if it is available for this conversation. | [optional] |
| **IncludeMessage** | **bool?** | Indicates that established communication has an initial email. If true, the initial messagesSent value will be initialized to 1. | [optional] |
| **InitialConfiguration** | [**EmailInitialConfiguration**](EmailInitialConfiguration) | Metadata about this communication. | |
| **SourceConfiguration** | [**SourceConfiguration**](SourceConfiguration) | Metadata about the source of this communication&#39;s interaction. | |



_PureCloudPlatform.Client.V2 244.0.0_
