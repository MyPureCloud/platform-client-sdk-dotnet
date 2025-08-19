# BuForecastResult

## ININ.PureCloudApi.Model.BuForecastResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ReferenceStartDate** | **DateTime?** | The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **PlanningGroups** | [**List&lt;ForecastPlanningGroupData&gt;**](ForecastPlanningGroupData) | The forecast data broken up by planning group | [optional] |
| **WeekNumber** | **int?** | The week number represented by this response | [optional] |
| **WeekCount** | **int?** | The number of weeks in this forecast | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
