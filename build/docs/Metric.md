---
title: Metric
---
## ININ.PureCloudApi.Model.Metric

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of this metric | |
| **MetricDefinitionId** | **string** | The id of associated metric definition | [optional] |
| **ExternalMetricDefinitionId** | **string** | The id of associated external metric definition | [optional] |
| **Objective** | [**Objective**](Objective.html) | Associated objective for this metric | [optional] |
| **PerformanceProfileId** | **string** | Performance profile id of this metric | [optional] |
| **LinkedMetric** | [**AddressableEntityRef**](AddressableEntityRef.html) | The linked metric entity reference | [optional] |
| **DateCreated** | **DateTime?** | The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateUnlinked** | **String** | The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **SourcePerformanceProfile** | [**PerformanceProfile**](PerformanceProfile.html) | The source performance profile when this metric is linked | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


