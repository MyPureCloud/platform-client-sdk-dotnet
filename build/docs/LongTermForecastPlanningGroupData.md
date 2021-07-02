---
title: LongTermForecastPlanningGroupData
---
## ININ.PureCloudApi.Model.LongTermForecastPlanningGroupData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PlanningGroupId** | **string** | The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration | [optional] |
| **OfferedPerDay** | **List&lt;double?&gt;** | Forecast offered counts per day for this planning group | [optional] |
| **AverageHandleTimeSecondsPerDay** | **List&lt;double?&gt;** | Forecast average handle time per day in seconds | [optional] |
{: class="table table-striped"}


