# ForecastPlanningGroupData

## ININ.PureCloudApi.Model.ForecastPlanningGroupData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PlanningGroupId** | **string** | The ID of the planning group to which this data applies. Note this is a snapshot of the planning group at the time of forecast creation and may not correspond to the current configuration | |
| **OfferedPerInterval** | **List&lt;double?&gt;** | Forecast offered counts per 15 minute interval for this week of the forecast | |
| **AverageHandleTimeSecondsPerInterval** | **List&lt;double?&gt;** | Forecast average handle time per 15 minute interval in seconds | |



_PureCloudPlatform.Client.V2 214.0.0_
