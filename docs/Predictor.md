# Predictor

## ININ.PureCloudApi.Model.Predictor

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Queues** | [**List&lt;AddressableEntityRef&gt;**](AddressableEntityRef) | The queue IDs associated with the predictor. | |
| **Kpi** | **string** | The KPI that the predictor attempts to maximize/minimize. | |
| **RoutingTimeoutSeconds** | **int?** | Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds. | [optional] |
| **Schedule** | [**PredictorSchedule**](PredictorSchedule) | The predictor schedule that determines when the predictor is used for routing interactions. | [optional] |
| **State** | **string** | The predictor state. | [optional] |
| **DateCreated** | **DateTime?** | DateTime indicating when the predictor was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | DateTime indicating when the predictor was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **WorkloadBalancingConfig** | [**PredictorWorkloadBalancing**](PredictorWorkloadBalancing) | The predictor balancing configuration to enable workload balancing. | [optional] |
| **ErrorCode** | **string** | Predictor error code - optional details on why the predictor went into error state. | [optional] |
| **Models** | [**List&lt;PredictorModelBrief&gt;**](PredictorModelBrief) | Predictor&#39;s models | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
