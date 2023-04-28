---
title: UserInsightsTrend
---
## ININ.PureCloudApi.Model.UserInsightsTrend

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef.html) | The performance profile | [optional] |
| **Division** | [**DivisionReference**](DivisionReference.html) | The division | [optional] |
| **Granularity** | **string** | Granularity | [optional] |
| **ComparativePeriod** | [**WorkdayPeriod**](WorkdayPeriod.html) | The comparative period work day date range | [optional] |
| **PrimaryPeriod** | [**WorkdayPeriod**](WorkdayPeriod.html) | The primary period work day date range | [optional] |
| **Entities** | [**List&lt;InsightsTrendMetricItem&gt;**](InsightsTrendMetricItem.html) | The list of insights trend for each metric | [optional] |
| **Total** | [**InsightsTrendTotalItem**](InsightsTrendTotalItem.html) | The insights trend in total | [optional] |
| **User** | [**UserReference**](UserReference.html) | The query user | [optional] |
{: class="table table-striped"}


