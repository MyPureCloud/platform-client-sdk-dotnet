# BuAgentScheduleHistoryDroppedChange

## ININ.PureCloudApi.Model.BuAgentScheduleHistoryDroppedChange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metadata** | [**BuAgentScheduleHistoryChangeMetadata**](BuAgentScheduleHistoryChangeMetadata) | The metadata of the change, including who and when the change was made | [optional] |
| **ShiftIds** | **List&lt;string&gt;** | The IDs of deleted shifts | [optional] |
| **FullDayTimeOffMarkerDates** | **List&lt;String&gt;** | The dates of any deleted full day time off markers | [optional] |
| **Deletes** | [**BuAgentScheduleHistoryDeletedChange**](BuAgentScheduleHistoryDeletedChange) | The deleted shifts, full day time off markers, or the entire agent schedule | [optional] |



_PureCloudPlatform.Client.V2 229.0.0_
