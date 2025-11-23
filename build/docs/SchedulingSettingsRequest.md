# SchedulingSettingsRequest

## ININ.PureCloudApi.Model.SchedulingSettingsRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MaxOccupancyPercentForDeferredWork** | **int?** | Max occupancy percent for deferred work | [optional] |
| **DefaultShrinkagePercent** | **double?** | Default shrinkage percent for scheduling | [optional] |
| **ShrinkageOverrides** | [**ShrinkageOverrides**](ShrinkageOverrides) | Shrinkage overrides for scheduling | [optional] |
| **PlanningPeriod** | [**ValueWrapperPlanningPeriodSettings**](ValueWrapperPlanningPeriodSettings) | Planning period settings for scheduling. Only one of planningPeriod or monthlyPlanningPeriod may be defined | [optional] |
| **MonthlyPlanningPeriod** | [**ValueWrapperMonthlyPlanningPeriodSettings**](ValueWrapperMonthlyPlanningPeriodSettings) | Monthly planning period setting for scheduling. Only one of planningPeriod or monthlyPlanningPeriod may be defined | [optional] |
| **StartDayOfWeekend** | **string** | Start day of weekend for scheduling | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
