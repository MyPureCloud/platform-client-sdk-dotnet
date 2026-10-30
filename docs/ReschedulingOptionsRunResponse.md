# ReschedulingOptionsRunResponse

## ININ.PureCloudApi.Model.ReschedulingOptionsRunResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ExistingSchedule** | [**BuScheduleReference**](BuScheduleReference) | The existing schedule to which this reschedule run applies | [optional] |
| **StartDate** | **DateTime?** | The start date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndDate** | **DateTime?** | The end date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ManagementUnits** | [**List&lt;ReschedulingManagementUnitResponse&gt;**](ReschedulingManagementUnitResponse) | Per-management unit rescheduling options | [optional] |
| **AgentCount** | **int?** | The number of agents to be considered in the reschedule | [optional] |
| **ActivityCodeIds** | **List&lt;string&gt;** | The IDs of the activity codes being considered for reschedule | [optional] |
| **DoNotChangeWeeklyPaidTime** | **bool?** | Whether weekly paid time is allowed to be changed | |
| **DoNotChangeDailyPaidTime** | **bool?** | Whether daily paid time is allowed to be changed | |
| **DoNotChangeShiftStartTimes** | **bool?** | Whether shift start times are allowed to be changed | |
| **DoNotChangeManuallyEditedShifts** | **bool?** | Whether manually edited shifts are allowed to be changed | |
| **ActivitySmoothingType** | **string** | The activity smoothing type used for this reschedule run | |
| **InduceScheduleVariability** | **bool?** | Whether schedule variability was induced for this reschedule run | |
| **UseUnavailableTimesSnapshot** | **bool?** | Whether original unavailable times from schedule generation were used instead of the latest saved unavailable times | |



_PureCloudPlatform.Client.V2 276.0.0_
