# CreateWorkPlan

## ININ.PureCloudApi.Model.CreateWorkPlan

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Name of this work plan | |
| **Enabled** | **bool?** | Whether the work plan is enabled for scheduling | [optional] |
| **ConstrainWeeklyPaidTime** | **bool?** | Whether the weekly paid time constraint is enabled for this work plan | [optional] |
| **FlexibleWeeklyPaidTime** | **bool?** | Whether the weekly paid time constraint is flexible for this work plan | [optional] |
| **WeeklyExactPaidMinutes** | **int?** | Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false | [optional] |
| **WeeklyMinimumPaidMinutes** | **int?** | Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true | [optional] |
| **WeeklyMaximumPaidMinutes** | **int?** | Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true | [optional] |
| **ConstrainPaidTimeGranularity** | **bool?** | Whether paid time granularity should be constrained for this workplan | [optional] |
| **PaidTimeGranularityMinutes** | **int?** | Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity &#x3D;&#x3D; true | [optional] |
| **ConstrainMinimumTimeBetweenShifts** | **bool?** | Whether the minimum time between shifts constraint is enabled for this work plan | [optional] |
| **MinimumTimeBetweenShiftsMinutes** | **int?** | Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts &#x3D;&#x3D; true | [optional] |
| **MaximumDays** | **int?** | Maximum number days in a week allowed to be scheduled for this work plan | [optional] |
| **MinimumConsecutiveNonWorkingMinutesPerWeek** | **int?** | Minimum amount of consecutive non working minutes per week that agents who are assigned this work plan are allowed to have off | [optional] |
| **ConstrainMaximumConsecutiveWorkingWeekends** | **bool?** | Whether to constrain the maximum consecutive working weekends | [optional] |
| **MaximumConsecutiveWorkingWeekends** | **int?** | The maximum number of consecutive weekends that agents who are assigned to this work plan are allowed to work | [optional] |
| **MinimumWorkingDaysPerWeek** | **int?** | The minimum number of days that agents assigned to a work plan must work per week | [optional] |
| **ConstrainMaximumConsecutiveWorkingDays** | **bool?** | Whether to constrain the maximum consecutive working days | [optional] |
| **MaximumConsecutiveWorkingDays** | **int?** | The maximum number of consecutive days that agents assigned to this work plan are allowed to work. Used if constrainMaximumConsecutiveWorkingDays &#x3D;&#x3D; true | [optional] |
| **MinimumShiftStartDistanceMinutes** | **int?** | The time period in minutes for the duration between the start times of two consecutive working days | [optional] |
| **MinimumDaysOffPerPlanningPeriod** | **int?** | Minimum days off in the planning period | [optional] |
| **MaximumDaysOffPerPlanningPeriod** | **int?** | Maximum days off in the planning period | [optional] |
| **MinimumPaidMinutesPerPlanningPeriod** | **int?** | Minimum paid minutes in the planning period | [optional] |
| **MaximumPaidMinutesPerPlanningPeriod** | **int?** | Maximum paid minutes in the planning period | [optional] |
| **OptionalDays** | [**SetWrapperDayOfWeek**](SetWrapperDayOfWeek) | Optional days to schedule for this work plan | [optional] |
| **ShiftStartVarianceType** | **string** | This constraint ensures that an agent starts each workday within a user-defined time threshold | [optional] |
| **ShiftStartVariances** | [**ListWrapperShiftStartVariance**](ListWrapperShiftStartVariance) | Variance in minutes among start times of shifts in this work plan | [optional] |
| **Shifts** | [**List&lt;CreateWorkPlanShift&gt;**](CreateWorkPlanShift) | Shifts in this work plan | [optional] |
| **Agents** | [**List&lt;UserReference&gt;**](UserReference) | Agents in this work plan | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
