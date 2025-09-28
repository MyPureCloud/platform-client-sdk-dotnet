# Event

## ININ.PureCloudApi.Model.Event

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | System-generated UUID for the event. | |
| **CorrelationId** | **string** | UUID corresponding to triggering action that caused this event (e.g. HTTP POST, SIP invite, another event). | |
| **CustomerId** | **string** | Primary identifier of the customer in the source of the events. | [optional] |
| **CustomerIdType** | **string** | Type of primary identifier (e.g. cookie, email, phone). | [optional] |
| **Session** | [**EventSession**](EventSession) | The session that the event belongs to. | |
| **EventType** | **string** | The name representing the type of event. | |
| **OutcomeAchievedEvent** | [**OutcomeAchievedEvent**](OutcomeAchievedEvent) | Event where a customer has achieved a specific outcome or goal. | [optional] |
| **SegmentAssignmentEvent** | [**SegmentAssignmentEvent**](SegmentAssignmentEvent) | Event that represents a segment being assigned. | [optional] |
| **WebActionEvent** | [**WebActionEvent**](WebActionEvent) | Event triggered by web actions. | [optional] |
| **WebEvent** | [**WebEvent**](WebEvent) | Event that tracks user interactions with content in a browser such as pageviews, downloads, mobile ad clicks, etc. | [optional] |
| **AppEvent** | [**AppEvent**](AppEvent) | Event that tracks user interactions with content in an application such as screen views, searches, etc. | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |



_PureCloudPlatform.Client.V2 243.0.0_
