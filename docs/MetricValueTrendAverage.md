# MetricValueTrendAverage

## ININ.PureCloudApi.Model.MetricValueTrendAverage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateStartWorkday** | **String** | The targeted start workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | The targeted end workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateReferenceWorkday** | **String** | The targeted reference workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Division** | [**Division**](Division) | The targeted division for the metrics | [optional] |
| **User** | [**UserReference**](UserReference) | The targeted user for the metrics | [optional] |
| **Timezone** | **string** | The time zone used for aggregating metric values | [optional] |
| **Result** | [**WorkdayValuesMetricItem**](WorkdayValuesMetricItem) | The metric value trend and average | [optional] |
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef) | The targeted performance profile for the average points | [optional] |
| **Metric** | [**AddressableEntityRef**](AddressableEntityRef) | The targeted performance profile for the average points | [optional] |



_PureCloudPlatform.Client.V2 214.0.0_
