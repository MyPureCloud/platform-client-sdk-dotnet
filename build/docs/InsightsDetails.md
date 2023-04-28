---
title: InsightsDetails
---
## ININ.PureCloudApi.Model.InsightsDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef.html) | The performance profile | [optional] |
| **Division** | [**DivisionReference**](DivisionReference.html) | The division | [optional] |
| **Granularity** | **string** | Granularity | [optional] |
| **ComparativePeriod** | [**WorkdayPeriod**](WorkdayPeriod.html) | The comparative period work day date range | [optional] |
| **PrimaryPeriod** | [**WorkdayPeriod**](WorkdayPeriod.html) | The primary period work day date range | [optional] |
| **User** | [**UserReference**](UserReference.html) | The query user | [optional] |
| **MetricData** | [**List&lt;InsightsDetailsMetricItem&gt;**](InsightsDetailsMetricItem.html) | The list of insights data for each metric of the user | [optional] |
| **OverallData** | [**InsightsDetailsOverallItem**](InsightsDetailsOverallItem.html) | Overall insights data of the user | [optional] |
{: class="table table-striped"}


