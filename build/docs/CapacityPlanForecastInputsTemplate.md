# CapacityPlanForecastInputsTemplate

## ININ.PureCloudApi.Model.CapacityPlanForecastInputsTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ReferenceBusinessUnitDate** | **String** | The reference date for interval-based data relative to the business unit time zone for the forecast inputs. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Granularity** | **string** | Granularity of the intervals | |
| **Months** | [**List&lt;YearMonth&gt;**](YearMonth) | The list of months covered by this capacity plan, formatted as yyyy-MM, populated for monthly granularity | [optional] |
| **PlanningGroupsForecastData** | [**List&lt;ForecastInputPlanningGroupData&gt;**](ForecastInputPlanningGroupData) | The forecast data for the planning groups | |
| **CapacityPlanForecastSummary** | [**CapacityPlanForecastMetrics**](CapacityPlanForecastMetrics) | The summary of forecast inputs for this capacity plan, for the selected granularity | |



_PureCloudPlatform.Client.V2 268.0.0_
