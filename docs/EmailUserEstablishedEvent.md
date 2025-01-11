# EmailUserEstablishedEvent

## ININ.PureCloudApi.Model.EmailUserEstablishedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication. | |
| **UserId** | **string** | A unique Id (V4 UUID) identifying the user this communication belongs to. | |
| **QueueId** | **string** | A unique Id (V4 UUID) identifying the queue that the user is emailing on behalf of. Applies to outbound emails only. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates whether or not this user will be required to complete after call work. | [optional] |
| **InitialConfiguration** | [**EmailInitialConfiguration**](EmailInitialConfiguration) | Metadata about this communication. | |
| **SourceConfiguration** | [**SourceConfiguration**](SourceConfiguration) | Metadata about the source of this communication&#39;s interaction. | |



_PureCloudPlatform.Client.V2 224.1.0_
