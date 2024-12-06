# EmailRoutingEstablishedEvent

## ININ.PureCloudApi.Model.EmailRoutingEstablishedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication. | |
| **QueueId** | **string** | The id of the queue that is routing this conversation. | |
| **SkillIds** | **List&lt;string&gt;** | The unique identifiers for the skills that should be used to determine the destination for the conversation. | [optional] |
| **LanguageId** | **string** | The unique identifier for the language that should be used to determine the destination for the conversation. | [optional] |
| **Label** | **string** | An optional label that categorizes the conversation. Max-utilization settings can be configured at a per-label level. | [optional] |
| **InitialConfiguration** | [**EmailInitialConfiguration**](EmailInitialConfiguration) | Metadata about this communication. | |
| **SourceConfiguration** | [**SourceConfiguration**](SourceConfiguration) | Metadata about the source of this communication&#39;s interaction. | |



_PureCloudPlatform.Client.V2 222.0.0_
