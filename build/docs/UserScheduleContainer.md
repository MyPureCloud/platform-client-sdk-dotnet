---
title: UserScheduleContainer
---
## ININ.PureCloudApi.Model.UserScheduleContainer

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ManagementUnitTimeZone** | **string** | The reference time zone used for the management unit | [optional] |
| **PublishedSchedules** | [**List&lt;WeekScheduleReference&gt;**](WeekScheduleReference.html) | References to all published week schedules overlapping the start/end date query parameters | [optional] |
| **UserSchedules** | [**Dictionary&lt;string, UserSchedule&gt;**](UserSchedule.html) | Map of user id to user schedule | [optional] |
{: class="table table-striped"}


