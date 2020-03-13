---
title: BuAgentSchedulesSearchResponse
---
## ININ.PureCloudApi.Model.BuAgentSchedulesSearchResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AgentSchedules** | [**List&lt;BuAgentScheduleSearchResponse&gt;**](BuAgentScheduleSearchResponse.html) | The requested agent schedules | [optional] |
| **BusinessUnitTimeZone** | **string** | The time zone configured for the business unit to which this schedule applies | [optional] |
| **PublishedSchedules** | [**List&lt;BuAgentSchedulePublishedScheduleReference&gt;**](BuAgentSchedulePublishedScheduleReference.html) | References to all published week schedules overlapping the start/end date query parameters | [optional] |
{: class="table table-striped"}


