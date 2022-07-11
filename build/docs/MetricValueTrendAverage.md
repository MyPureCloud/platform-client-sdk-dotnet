---
title: MetricValueTrendAverage
---
## ININ.PureCloudApi.Model.MetricValueTrendAverage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateStartWorkday** | **String** | The targeted start workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | The targeted end workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateReferenceWorkday** | **String** | The targeted reference workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Division** | [**Division**](Division.html) | The targeted division for the metrics | [optional] |
| **User** | [**UserReference**](UserReference.html) | The targeted user for the metrics | [optional] |
| **Timezone** | **string** | The time zone used for aggregating metric values | [optional] |
| **Result** | [**WorkdayValuesMetricItem**](WorkdayValuesMetricItem.html) | The metric value trend and average | [optional] |
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef.html) | The targeted performance profile for the average points | [optional] |
| **Metric** | [**AddressableEntityRef**](AddressableEntityRef.html) | The targeted performance profile for the average points | [optional] |
{: class="table table-striped"}


