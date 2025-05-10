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
| **DoNotChangeWeeklyPaidTime** | **bool?** | Whether weekly paid time is allowed to be changed | [optional] |
| **DoNotChangeDailyPaidTime** | **bool?** | Whether daily paid time is allowed to be changed | [optional] |
| **DoNotChangeShiftStartTimes** | **bool?** | Whether shift start times are allowed to be changed | [optional] |
| **DoNotChangeManuallyEditedShifts** | **bool?** | Whether manually edited shifts are allowed to be changed | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
