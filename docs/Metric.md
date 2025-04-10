# Metric

## ININ.PureCloudApi.Model.Metric

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of this metric | |
| **MetricDefinitionId** | **string** | The id of associated metric definition | [optional] |
| **ExternalMetricDefinitionId** | **string** | The id of associated external metric definition | [optional] |
| **Objective** | [**Objective**](Objective) | Associated objective for this metric | [optional] |
| **PerformanceProfileId** | **string** | Performance profile id of this metric | [optional] |
| **LinkedMetric** | [**AddressableEntityRef**](AddressableEntityRef) | The linked metric entity reference | [optional] |
| **DateCreated** | **DateTime?** | The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateUnlinked** | **String** | The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Precision** | **int?** | The precision of the metric, must be between 0 and 5 | [optional] |
| **TimeDisplayUnit** | **string** | The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values | [optional] |
| **SourcePerformanceProfile** | [**PerformanceProfile**](PerformanceProfile) | The source performance profile when this metric is linked | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
