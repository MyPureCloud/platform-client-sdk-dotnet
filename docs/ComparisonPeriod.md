# ComparisonPeriod

## ININ.PureCloudApi.Model.ComparisonPeriod

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Kpi** | **string** | Key Performance Indicator optimised during the comparison period. | [optional] |
| **DateStarted** | **DateTime?** | Start date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateEnded** | **DateTime?** | End date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **PercentageBenefit** | **double?** | The percentage benefit on this queue for the duration of the comparison period | [optional] |
| **KpiResults** | [**List&lt;KpiResult&gt;**](KpiResult) | KPI results for each metric | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
