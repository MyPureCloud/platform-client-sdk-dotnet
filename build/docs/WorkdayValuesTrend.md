# WorkdayValuesTrend

## ININ.PureCloudApi.Model.WorkdayValuesTrend

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateStartWorkday** | **String** | The start workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | The end workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateReferenceWorkday** | **String** | The reference workday used to determine the metric definition. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Division** | [**Division**](Division) | The targeted division for the query | [optional] |
| **User** | [**UserReference**](UserReference) | The targeted user for the query | [optional] |
| **Timezone** | **string** | The time zone used for aggregating metric values | [optional] |
| **Results** | [**List&lt;WorkdayValuesMetricItem&gt;**](WorkdayValuesMetricItem) | The metric value trends | [optional] |
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef) | The targeted performance profile for the average points | [optional] |
| **Metric** | [**AddressableEntityRef**](AddressableEntityRef) | The targeted metric for the average points | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
