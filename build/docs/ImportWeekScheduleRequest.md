---
title: ImportWeekScheduleRequest
---
## ININ.PureCloudApi.Model.ImportWeekScheduleRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Description** | **string** | Description for the schedule | |
| **UserSchedules** | [**Dictionary&lt;string, UserSchedule&gt;**](UserSchedule.html) | User schedules | [optional] |
| **Published** | **bool?** | Whether the schedule is published | [optional] |
| **ShortTermForecastId** | **string** | Short term forecast that should be associated with this schedule | [optional] |
| **PartialUploadIds** | **List&lt;string&gt;** | IDs of partial uploads of user schedules to import week schedule. It is applicable only for large schedules where activity count in schedule is greater than 17500 | [optional] |
{: class="table table-striped"}


