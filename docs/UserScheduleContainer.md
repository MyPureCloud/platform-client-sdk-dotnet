# UserScheduleContainer

## ININ.PureCloudApi.Model.UserScheduleContainer

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnitTimeZone** | **string** | The reference time zone used for the management unit | [optional] |
| **PublishedSchedules** | [**List&lt;WeekScheduleReference&gt;**](WeekScheduleReference) | References to all published week schedules overlapping the start/end date query parameters | [optional] |
| **UserSchedules** | [**Dictionary&lt;string, UserSchedule&gt;**](UserSchedule) | Map of user id to user schedule | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
