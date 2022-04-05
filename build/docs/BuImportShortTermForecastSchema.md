---
title: BuImportShortTermForecastSchema
---
## ININ.PureCloudApi.Model.BuImportShortTermForecastSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Description** | **string** | The description for the forecast | |
| **WeekCount** | **int?** | The number of weeks covered by the forecast | |
| **PlanningGroups** | [**List&lt;ForecastPlanningGroupData&gt;**](ForecastPlanningGroupData.html) | The short term planning group data | |
| **LongTermPlanningGroups** | [**List&lt;LongTermForecastPlanningGroupData&gt;**](LongTermForecastPlanningGroupData.html) | The long term planning group data | [optional] |
| **CanUseForScheduling** | **bool?** | Whether this forecast can be used for scheduling | [optional] |
{: class="table table-striped"}


