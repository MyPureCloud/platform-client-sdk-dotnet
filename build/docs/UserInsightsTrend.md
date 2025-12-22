# UserInsightsTrend

## ININ.PureCloudApi.Model.UserInsightsTrend

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef) | The performance profile | [optional] |
| **Division** | [**DivisionReference**](DivisionReference) | The division | [optional] |
| **Granularity** | **string** | Granularity | [optional] |
| **ComparativePeriod** | [**WorkdayPeriod**](WorkdayPeriod) | The comparative period work day date range | [optional] |
| **PrimaryPeriod** | [**WorkdayPeriod**](WorkdayPeriod) | The primary period work day date range | [optional] |
| **User** | [**UserReference**](UserReference) | The query user | [optional] |
| **Entities** | [**List&lt;UserInsightsTrendMetricItem&gt;**](UserInsightsTrendMetricItem) | The list of insights trend for each metric | [optional] |
| **Total** | [**UserInsightsTrendTotalItem**](UserInsightsTrendTotalItem) | The insights trend in total | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
