---
title: UserEstablishedEvent
---
## ININ.PureCloudApi.Model.UserEstablishedEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EventId** | **string** | A unique (V4 UUID) eventId for this event | |
| **EventDateTime** | **DateTime?** | A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **ConversationId** | **string** | A unique Id (V4 UUID) identifying this conversation | |
| **CommunicationId** | **string** | A unique Id (V4 UUID) identifying this communication | |
| **PhoneNumber** | **string** | Identifies the phone number used to reach this user if it is different from the information that would be accessed by userId. | [optional] |
| **UserId** | **string** | The userId (V4 UUID) for the user this communication belongs to. | |
| **StationId** | **string** | A Station ID (V4 UUID) that identifies the station being used if the user is using a station and the stationId is known. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates whether or not this user will be required to complete after call work. | [optional] |
| **QueueId** | **string** | The id (V4 UUID) of the queue that the user is calling on behalf of. Applies to outbound calls only. | [optional] |
| **InitialConfiguration** | [**InitialConfiguration**](InitialConfiguration.html) | Metadata about this communication. | |
| **SourceConfiguration** | [**SourceConfiguration**](SourceConfiguration.html) | Metadata about the source of this communication&#39;s interaction. | |
{: class="table table-striped"}


