# CreateMetric

## ININ.PureCloudApi.Model.CreateMetric

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MetricDefinitionId** | **string** | The id of associated metric definition | [optional] |
| **ExternalMetricDefinitionId** | **string** | The id of associated external metric definition | [optional] |
| **Objective** | [**CreateObjective**](CreateObjective) | Associated objective for this metric | [optional] |
| **PerformanceProfileId** | **string** | Performance profile id of this metric | [optional] |
| **Name** | **string** | The name of this metric | |
| **Precision** | **int?** | The precision of the metric, must be between 0 and 5 | [optional] |
| **TimeDisplayUnit** | **string** | The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values | [optional] |



_PureCloudPlatform.Client.V2 218.0.0_
