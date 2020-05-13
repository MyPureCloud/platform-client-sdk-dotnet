---
title: BuPlanningGroupHeadcountForecast
---
## ININ.PureCloudApi.Model.BuPlanningGroupHeadcountForecast

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PlanningGroup** | [**PlanningGroupReference**](PlanningGroupReference.html) | The planning group to which this portion of the headcount forecast applies | [optional] |
| **RequiredPerInterval** | **List&lt;double?&gt;** | Required headcount per interval, referenced against the reference start date | [optional] |
| **RequiredWithoutShrinkagePerInterval** | **List&lt;double?&gt;** | Required headcount per interval without accounting for shrinkage, referenced against the reference start date | [optional] |
{: class="table table-striped"}


