---
title: CreateWorkPlan
---
## ININ.PureCloudApi.Model.CreateWorkPlan

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Name of this work plan | |
| **Enabled** | **bool?** | Whether the work plan is enabled for scheduling | [optional] |
| **ConstrainWeeklyPaidTime** | **bool?** | Whether the weekly paid time constraint is enabled for this work plan | [optional] |
| **FlexibleWeeklyPaidTime** | **bool?** | Whether the weekly paid time constraint is flexible for this work plan | [optional] |
| **WeeklyExactPaidMinutes** | **int?** | Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == false | [optional] |
| **WeeklyMinimumPaidMinutes** | **int?** | Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true | [optional] |
| **WeeklyMaximumPaidMinutes** | **int?** | Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true | [optional] |
| **ConstrainPaidTimeGranularity** | **bool?** | Whether paid time granularity should be constrained for this workplan | [optional] |
| **PaidTimeGranularityMinutes** | **int?** | Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity == true | [optional] |
| **ConstrainMinimumTimeBetweenShifts** | **bool?** | Whether the minimum time between shifts constraint is enabled for this work plan | [optional] |
| **MinimumTimeBetweenShiftsMinutes** | **int?** | Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts == true | [optional] |
| **MaximumDays** | **int?** | Maximum number days in a week allowed to be scheduled for this work plan | [optional] |
| **OptionalDays** | [**SetWrapperDayOfWeek**](SetWrapperDayOfWeek.html) | Optional days to schedule for this work plan | [optional] |
| **ShiftStartVariances** | [**ListWrapperShiftStartVariance**](ListWrapperShiftStartVariance.html) | Variance in minutes among start times of shifts in this work plan | [optional] |
| **Shifts** | [**List&lt;CreateWorkPlanShift&gt;**](CreateWorkPlanShift.html) | Shifts in this work plan | [optional] |
| **Agents** | [**List&lt;UserReference&gt;**](UserReference.html) | Agents in this work plan | [optional] |
{: class="table table-striped"}


