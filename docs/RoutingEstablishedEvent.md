# RoutingEstablishedEvent

## ININ.PureCloudApi.Model.RoutingEstablishedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication | |
| **PhoneNumber** | **string** | Identifies the phone number used to reach this queue if it is different from the information that would be accessed by queueId. | [optional] |
| **QueueId** | **string** | The id (V4 UUID) of the queue that is routing this conversation. | |
| **Ani** | **string** | The automatic number identification if it is available for this conversation. | [optional] |
| **Dnis** | **string** | The dialed number identification if it is available for this conversation. | [optional] |
| **SkillIds** | **List&lt;string&gt;** | The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation. | [optional] |
| **LanguageId** | **string** | The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation. | [optional] |
| **InitialConfiguration** | [**InitialConfiguration**](InitialConfiguration) | Metadata about this communication. | |
| **SourceConfiguration** | [**SourceConfiguration**](SourceConfiguration) | Metadata about the source of this communication&#39;s interaction. | |



_PureCloudPlatform.Client.V2 220.0.0_
