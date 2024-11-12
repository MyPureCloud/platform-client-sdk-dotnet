# BuPlanningGroupHeadcountForecast

## ININ.PureCloudApi.Model.BuPlanningGroupHeadcountForecast

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PlanningGroup** | [**PlanningGroupReference**](PlanningGroupReference) | The planning group to which this portion of the headcount forecast applies | [optional] |
| **RequiredPerInterval** | **List&lt;double?&gt;** | Required headcount per interval, referenced against the reference start date | [optional] |
| **RequiredWithoutShrinkagePerInterval** | **List&lt;double?&gt;** | Required headcount per interval without accounting for shrinkage, referenced against the reference start date | [optional] |



_PureCloudPlatform.Client.V2 221.0.0_
