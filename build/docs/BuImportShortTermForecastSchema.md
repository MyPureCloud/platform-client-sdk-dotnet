# BuImportShortTermForecastSchema

## ININ.PureCloudApi.Model.BuImportShortTermForecastSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Description** | **string** | The description for the forecast | |
| **WeekCount** | **int?** | The number of weeks covered by the forecast | |
| **PlanningGroups** | [**List&lt;ForecastPlanningGroupData&gt;**](ForecastPlanningGroupData) | The short term planning group data | |
| **LongTermPlanningGroups** | [**List&lt;LongTermForecastPlanningGroupData&gt;**](LongTermForecastPlanningGroupData) | The long term planning group data | [optional] |
| **CanUseForScheduling** | **bool?** | Whether this forecast can be used for scheduling | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
