---
title: ForecastPlanningGroupData
---
## ININ.PureCloudApi.Model.ForecastPlanningGroupData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PlanningGroupId** | **string** | The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration | [optional] |
| **OfferedPerInterval** | **List&lt;double?&gt;** | Forecast offered counts per interval for this week of the forecast | [optional] |
| **AverageHandleTimeSecondsPerInterval** | **List&lt;double?&gt;** | Forecast average handle time per interval in seconds | [optional] |
{: class="table table-striped"}


