---
title: ReschedulingOptionsResponse
---
## ININ.PureCloudApi.Model.ReschedulingOptionsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start date of the range to reschedule in ISO-8601 format | |
| **EndDate** | **DateTime?** | The end date of the range to reschedule in ISO-8601 format | |
| **AgentIds** | **List&lt;string&gt;** | The IDs of the agents to reschedule.  Null or empty means all agents on the schedule | [optional] |
| **ActivityCodeIds** | **List&lt;string&gt;** | The IDs of the activity codes to reschedule. Null or empty means all activity codes will be considered | [optional] |
| **DoNotChangeWeeklyPaidTime** | **bool?** | Whether to prevent changes to weekly paid time | |
| **DoNotChangeDailyPaidTime** | **bool?** | Whether to prevent changes to daily paid time | |
| **DoNotChangeShiftStartTimes** | **bool?** | Whether to prevent changes to shift start times | |
| **DoNotChangeManuallyEditedShifts** | **bool?** | Whether to prevent changes to manually edited shifts | |
| **ExistingScheduleId** | **string** | The schedule ID of the schedule to which the results will be applied | [optional] |
| **ExistingScheduleVersion** | **int?** | The version of the schedule at the time the rescheduling was initiated | [optional] |
{: class="table table-striped"}


