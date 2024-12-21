# BuAgentScheduleHistoryChange

## ININ.PureCloudApi.Model.BuAgentScheduleHistoryChange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metadata** | [**BuAgentScheduleHistoryChangeMetadata**](BuAgentScheduleHistoryChangeMetadata) | The metadata of the change, including who and when the change was made | [optional] |
| **Shifts** | [**List&lt;BuAgentScheduleShift&gt;**](BuAgentScheduleShift) | The list of changed shifts | [optional] |
| **FullDayTimeOffMarkers** | [**List&lt;BuFullDayTimeOffMarker&gt;**](BuFullDayTimeOffMarker) | The list of changed full day time off markers | [optional] |
| **Deletes** | [**BuAgentScheduleHistoryDeletedChange**](BuAgentScheduleHistoryDeletedChange) | The deleted shifts, full day time off markers, or the entire agent schedule | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
