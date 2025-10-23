# SchedulingSettingsResponse

## ININ.PureCloudApi.Model.SchedulingSettingsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MaxOccupancyPercentForDeferredWork** | **int?** | Max occupancy percent for deferred work | [optional] |
| **DefaultShrinkagePercent** | **double?** | Default shrinkage percent for scheduling | [optional] |
| **ShrinkageOverrides** | [**ShrinkageOverrides**](ShrinkageOverrides) | Shrinkage overrides for scheduling | [optional] |
| **PlanningPeriod** | [**PlanningPeriodSettings**](PlanningPeriodSettings) | Planning period settings for scheduling. Only one of planningPeriod or monthlyPlanningPeriod will be defined if applicable, but both can be null | [optional] |
| **MonthlyPlanningPeriod** | [**MonthlyPlanningPeriodSettings**](MonthlyPlanningPeriodSettings) | Monthly planning period settings for scheduling. Only one of planningPeriod or monthlyPlanningPeriod will be defined if applicable, but both can be null | [optional] |
| **StartDayOfWeekend** | **string** | Start day of weekend for scheduling | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
