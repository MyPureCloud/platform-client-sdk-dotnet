# InsightsDetails

## ININ.PureCloudApi.Model.InsightsDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef) | The performance profile | [optional] |
| **Division** | [**DivisionReference**](DivisionReference) | The division | [optional] |
| **Granularity** | **string** | Granularity | [optional] |
| **ComparativePeriod** | [**WorkdayPeriod**](WorkdayPeriod) | The comparative period work day date range | [optional] |
| **PrimaryPeriod** | [**WorkdayPeriod**](WorkdayPeriod) | The primary period work day date range | [optional] |
| **User** | [**UserReference**](UserReference) | The query user | [optional] |
| **MetricData** | [**List&lt;InsightsDetailsMetricItem&gt;**](InsightsDetailsMetricItem) | The list of insights data for each metric of the user | [optional] |
| **OverallData** | [**InsightsDetailsOverallItem**](InsightsDetailsOverallItem) | Overall insights data of the user | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
