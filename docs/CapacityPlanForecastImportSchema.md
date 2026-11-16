# CapacityPlanForecastImportSchema

## ININ.PureCloudApi.Model.CapacityPlanForecastImportSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Granularity** | **string** | The granularity at which forecast values are provided for each planning group | |
| **BusinessUnitStartDate** | **String** | The first day of the forecast relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **PlanningGroups** | [**List&lt;CapacityPlanForecastPlanningGroup&gt;**](CapacityPlanForecastPlanningGroup) | The forecast data for the planning groups included in this forecast | |



_PureCloudPlatform.Client.V2 277.0.0_
