---
title: Event
---
## ININ.PureCloudApi.Model.Event

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | System-generated UUID for the event. | |
| **CorrelationId** | **string** | UUID corresponding to triggering action that caused this event (e.g. HTTP POST, SIP invite, another event). | |
| **CustomerId** | **string** | Primary identifier of the customer in the source of the events. | [optional] |
| **CustomerIdType** | **string** | Type of primary identifier (e.g. cookie, email, phone). | [optional] |
| **Session** | [**EventSession**](EventSession.html) | The session that the event belongs to. | |
| **EventType** | **string** | The name representing the type of event. | |
| **GenericActionEvent** | [**GenericActionEvent**](GenericActionEvent.html) | Event triggered by generic actions. | [optional] |
| **OutcomeAchievedEvent** | [**OutcomeAchievedEvent**](OutcomeAchievedEvent.html) | Event where a customer has achieved a specific outcome or goal. | [optional] |
| **SegmentAssignmentEvent** | [**SegmentAssignmentEvent**](SegmentAssignmentEvent.html) | Event that represents a segment being assigned. | [optional] |
| **WebActionEvent** | [**WebActionEvent**](WebActionEvent.html) | Event triggered by web actions. | [optional] |
| **WebEvent** | [**WebEvent**](WebEvent.html) | Event that tracks user interactions with content in a browser such as pageviews, downloads, mobile ad clicks, etc. | [optional] |
| **AppEvent** | [**AppEvent**](AppEvent.html) | Event that tracks user interactions with content in an application such as screen views, searches, etc. | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
{: class="table table-striped"}


