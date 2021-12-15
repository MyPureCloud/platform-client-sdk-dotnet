---
title: ComparisonPeriod
---
## ININ.PureCloudApi.Model.ComparisonPeriod

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Kpi** | **string** | Key Performance Indicator optimised during the comparison period. | [optional] |
| **DateStarted** | **DateTime?** | Start date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateEnded** | **DateTime?** | End date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **KpiTotalOn** | **long?** | Absolute metric (in which the KPI is based) total for the interactions handled by predictive routing (GPR was on) | [optional] |
| **KpiTotalOff** | **long?** | Absolute metric (in which the KPI is based) total for the interactions not routed by predictive routing (GPR was off) | [optional] |
| **InteractionCountOn** | **long?** | Total interactions handled by predictive routing (GPR was on) | [optional] |
| **InteractionCountOff** | **long?** | Total interactions not routed by predictive routing (GPR was off) | [optional] |
| **KpiResults** | [**List&lt;KpiResult&gt;**](KpiResult.html) | KPI results for each metric | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


