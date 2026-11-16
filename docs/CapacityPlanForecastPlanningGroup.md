# CapacityPlanForecastPlanningGroup

## ININ.PureCloudApi.Model.CapacityPlanForecastPlanningGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PlanningGroupId** | **string** | The ID of the planning group to which the forecast applies | |
| **Actual** | [**CapacityPlanForecastActualValues**](CapacityPlanForecastActualValues) | Absolute forecast values for offered counts and average handle time for this planning group. Exactly one of actual or distribution must be provided | [optional] |
| **Distribution** | [**CapacityPlanForecastDistributionValues**](CapacityPlanForecastDistributionValues) | Hourly forecast distribution values for offered volume and average handle time for this planning group. Exactly one of actual or distribution must be provided | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
