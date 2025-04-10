# BuAgentSchedulesSearchResponse

## ININ.PureCloudApi.Model.BuAgentSchedulesSearchResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AgentSchedules** | [**List&lt;BuAgentScheduleSearchResponse&gt;**](BuAgentScheduleSearchResponse) | The requested agent schedules | [optional] |
| **BusinessUnitTimeZone** | **string** | The time zone configured for the business unit to which this schedule applies | [optional] |
| **PublishedSchedules** | [**List&lt;BuAgentSchedulePublishedScheduleReference&gt;**](BuAgentSchedulePublishedScheduleReference) | References to all published week schedules overlapping the start/end date query parameters | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
