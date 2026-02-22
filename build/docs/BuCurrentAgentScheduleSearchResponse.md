# BuCurrentAgentScheduleSearchResponse

## ININ.PureCloudApi.Model.BuCurrentAgentScheduleSearchResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AgentSchedules** | [**List&lt;BuAgentScheduleSearchResponse&gt;**](BuAgentScheduleSearchResponse) | The requested agent schedules | [optional] |
| **BusinessUnitTimeZone** | **string** | The time zone configured for the business unit to which this schedule applies | [optional] |
| **PublishedSchedules** | [**List&lt;BuAgentSchedulePublishedScheduleReference&gt;**](BuAgentSchedulePublishedScheduleReference) | References to all published week schedules overlapping the start/end date query parameters | [optional] |
| **StartDate** | **DateTime?** | The start date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndDate** | **DateTime?** | The end date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Updates** | [**List&lt;BuAgentScheduleUpdate&gt;**](BuAgentScheduleUpdate) | The list of updates for the schedule. Only used in notifications | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
