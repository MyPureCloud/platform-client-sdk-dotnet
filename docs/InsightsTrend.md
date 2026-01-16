# InsightsTrend

## ININ.PureCloudApi.Model.InsightsTrend

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef) | The performance profile | [optional] |
| **Division** | [**DivisionReference**](DivisionReference) | The division | [optional] |
| **Granularity** | **string** | Granularity | [optional] |
| **ComparativePeriod** | [**WorkdayPeriod**](WorkdayPeriod) | The comparative period work day date range | [optional] |
| **PrimaryPeriod** | [**WorkdayPeriod**](WorkdayPeriod) | The primary period work day date range | [optional] |
| **Entities** | [**List&lt;InsightsTrendMetricItem&gt;**](InsightsTrendMetricItem) | The list of insights trend for each metric | [optional] |
| **Total** | [**InsightsTrendTotalItem**](InsightsTrendTotalItem) | The insights trend in total | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
