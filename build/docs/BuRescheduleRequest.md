# BuRescheduleRequest

## ININ.PureCloudApi.Model.BuRescheduleRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **StartDate** | **DateTime?** | The start of the range to reschedule.  Defaults to the beginning of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndDate** | **DateTime?** | The end of the range to reschedule.  Defaults the the end of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AgentIds** | **List&lt;string&gt;** | The IDs of the agents to consider for rescheduling.  Omit to consider all agents in the specified management units.Agents not in the specified management units will be ignored | [optional] |
| **ActivityCodeIds** | **List&lt;string&gt;** | The IDs of the activity codes to consider for rescheduling.  Omit to consider all activity codes | [optional] |
| **ManagementUnitIds** | **List&lt;string&gt;** | The IDs of the management units to reschedule | |
| **DoNotChangeWeeklyPaidTime** | **bool?** | Instructs the scheduler whether it is allowed to change weekly paid time | |
| **DoNotChangeDailyPaidTime** | **bool?** | Instructs the scheduler whether it is allowed to change daily paid time | |
| **DoNotChangeShiftStartTimes** | **bool?** | Instructs the scheduler whether it is allowed to change shift start times | |
| **DoNotChangeManuallyEditedShifts** | **bool?** | Instructs the scheduler whether it is allowed to change manually edited shifts | |
| **ActivitySmoothingType** | **string** | Overrides the default BU level activity smoothing type for this reschedule run | [optional] |
| **InduceScheduleVariability** | **bool?** | Overrides the default BU level induce schedule variability setting for this reschedule run | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
