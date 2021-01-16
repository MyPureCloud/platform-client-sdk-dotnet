---
title: BuAgentScheduleHistoryResponse
---
## ININ.PureCloudApi.Model.BuAgentScheduleHistoryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PriorPublishedSchedules** | [**List&lt;BuScheduleReference&gt;**](BuScheduleReference.html) | The list of previously published schedules | [optional] |
| **BasePublishedSchedule** | [**BuAgentScheduleHistoryChange**](BuAgentScheduleHistoryChange.html) | The originally published agent schedules | [optional] |
| **DroppedChanges** | [**List&lt;BuAgentScheduleHistoryDroppedChange&gt;**](BuAgentScheduleHistoryDroppedChange.html) | The changes dropped from the schedule history. This will happen if the schedule history is too large | [optional] |
| **Changes** | [**List&lt;BuAgentScheduleHistoryChange&gt;**](BuAgentScheduleHistoryChange.html) | The list of changes for the schedule history | [optional] |
{: class="table table-striped"}


