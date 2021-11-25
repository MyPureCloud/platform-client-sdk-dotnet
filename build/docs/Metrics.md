---
title: Metrics
---
## ININ.PureCloudApi.Model.Metrics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Order** | **int?** | The order of metric within a performance profile | [optional] |
| **MetricDefinitionName** | **string** | The name of associated metric definition | [optional] |
| **MetricDefinitionId** | **string** | The id of associated metric definition | [optional] |
| **ExternalMetricDefinitionId** | **string** | The id of associated external metric definition | [optional] |
| **UnitType** | **string** | Corresponding unit type for this metric | [optional] |
| **Enabled** | **bool?** | A flag for whether this metric is enabled for a performance profile | [optional] |
| **TemplateName** | **string** | The name of associated objective template | [optional] |
| **MaxPoints** | **int?** | Achievable maximum points for this metric | [optional] |
| **PerformanceProfileId** | **string** | Performance profile id of this metric | [optional] |
| **LinkedMetric** | [**AddressableEntityRef**](AddressableEntityRef.html) | The linked metric entity reference | [optional] |
| **DateCreated** | **DateTime?** | The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateUnlinked** | **String** | The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **SourcePerformanceProfile** | [**PerformanceProfile**](PerformanceProfile.html) | The source performance profile when this metric is linked | [optional] |
| **UnitDefinition** | **string** | Unit definition of linked external metric | [optional] |
| **Precision** | **int?** | Precision of linked external metric | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


