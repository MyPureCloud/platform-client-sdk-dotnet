---
title: IntegrationEvent
---
## ININ.PureCloudApi.Model.IntegrationEvent

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Unique ID for this event | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CorrelationId** | **string** | Correlation ID for the event | [optional] |
| **Timestamp** | **DateTime?** | Time the event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Level** | **string** | Indicates the severity of the event. | [optional] |
| **EventCode** | **string** | A classification for the event. Suitable for programmatic searching, sorting, or filtering | [optional] |
| **Message** | [**MessageInfo**](MessageInfo.html) | Message indicating what happened | [optional] |
| **Entities** | [**List&lt;EventEntity&gt;**](EventEntity.html) | Collection of entities affected by or pertaining to the event (e.g. a list of Integrations or Bridge connectors) | [optional] |
| **ContextAttributes** | **Dictionary&lt;string, string&gt;** | Map of context attributes specific to this event. | [optional] |
| **DetailMessage** | [**MessageInfo**](MessageInfo.html) | Message with additional details about the event. (e.g. an exception cause.) | [optional] |
| **User** | [**User**](User.html) | User that took an action that resulted in the event. | [optional] |
{: class="table table-striped"}


