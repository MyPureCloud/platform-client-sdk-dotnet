# CoachingSlot

## ININ.PureCloudApi.Model.CoachingSlot

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateStart** | **DateTime?** | Start date and time of scheduled coaching appointment slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LengthInMinutes** | **int?** | Length of coaching appointment slot in minutes | [optional] |
| **StaffingDifference** | **double?** | Difference between scheduled and forecast headcount for this slot after scheduling the coaching appointment | [optional] |
| **DifferenceRating** | **string** | Rating based on the staffing difference for scheduled slot | [optional] |
| **WfmSchedule** | [**WfmScheduleReference**](WfmScheduleReference) | Workforce Management schedule information associated with the slot | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
