# BuAgentScheduleHistoryResponse

## ININ.PureCloudApi.Model.BuAgentScheduleHistoryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PriorPublishedSchedules** | [**List&lt;BuScheduleReference&gt;**](BuScheduleReference) | The list of previously published schedules | [optional] |
| **BasePublishedSchedule** | [**BuAgentScheduleHistoryChange**](BuAgentScheduleHistoryChange) | The originally published agent schedules | [optional] |
| **DroppedChanges** | [**List&lt;BuAgentScheduleHistoryDroppedChange&gt;**](BuAgentScheduleHistoryDroppedChange) | The changes dropped from the schedule history. This will happen if the schedule history is too large | [optional] |
| **Changes** | [**List&lt;BuAgentScheduleHistoryChange&gt;**](BuAgentScheduleHistoryChange) | The list of changes for the schedule history | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
