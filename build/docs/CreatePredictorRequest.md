# CreatePredictorRequest

## ININ.PureCloudApi.Model.CreatePredictorRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QueueIds** | **List&lt;string&gt;** | The queue IDs associated with the predictor. | |
| **Kpi** | **string** | The KPI that the predictor attempts to maximize/minimize. | |
| **RoutingTimeoutSeconds** | **int?** | Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds. | [optional] |
| **Schedule** | [**PredictorSchedule**](PredictorSchedule) | The predictor schedule that determines when the predictor is used for routing interactions. | [optional] |
| **WorkloadBalancingConfig** | [**PredictorWorkloadBalancing**](PredictorWorkloadBalancing) | The predictor balancing configuration to enable workload balancing | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
