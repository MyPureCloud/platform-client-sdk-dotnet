# AgentWorkPlan

## ININ.PureCloudApi.Model.AgentWorkPlan

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ConstrainWeeklyPaidTime** | **bool?** | Whether the weekly paid time constraint is enabled for this work plan | |
| **FlexibleWeeklyPaidTime** | **bool?** | Whether the weekly paid time constraint is flexible for this work plan | |
| **WeeklyExactPaidMinutes** | **int?** | Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false | |
| **WeeklyMinimumPaidMinutes** | **int?** | Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true | |
| **WeeklyMaximumPaidMinutes** | **int?** | Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true | |
| **OptionalDays** | [**SetWrapperDayOfWeek**](SetWrapperDayOfWeek) | Optional days to schedule for this work plan | [optional] |
| **Shifts** | [**List&lt;AgentWorkPlanShift&gt;**](AgentWorkPlanShift) | Shifts in this work plan | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.0.0_
