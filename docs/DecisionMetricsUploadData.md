# DecisionMetricsUploadData

## ININ.PureCloudApi.Model.DecisionMetricsUploadData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserId** | **string** | The ID of the user associated with this decision metrics data | |
| **PerformanceRank** | [**ValueWrapperInteger**](ValueWrapperInteger) | The performance ranking value of the user for decision metrics. The value ranges from 0 to 9999, with the highest value indicating the best performer | [optional] |
| **TieBreakerValue** | [**ValueWrapperInteger**](ValueWrapperInteger) | A numeric tie-breaker value used to resolve ties in performance rankings. Values are sorted in ascending order, with lower values taking precedence | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
