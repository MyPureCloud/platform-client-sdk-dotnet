---
title: BuAgentScheduleHistoryChange
---
## ININ.PureCloudApi.Model.BuAgentScheduleHistoryChange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metadata** | [**BuAgentScheduleHistoryChangeMetadata**](BuAgentScheduleHistoryChangeMetadata.html) | The metadata of the change, including who and when the change was made | [optional] |
| **Shifts** | [**List&lt;BuAgentScheduleShift&gt;**](BuAgentScheduleShift.html) | The list of changed shifts | [optional] |
| **FullDayTimeOffMarkers** | [**List&lt;BuFullDayTimeOffMarker&gt;**](BuFullDayTimeOffMarker.html) | The list of changed full day time off markers | [optional] |
| **Deletes** | [**BuAgentScheduleHistoryDeletedChange**](BuAgentScheduleHistoryDeletedChange.html) | The deleted shifts, full day time off markers, or the entire agent schedule | [optional] |
{: class="table table-striped"}


