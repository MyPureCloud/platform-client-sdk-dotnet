---
title: InsightsAgents
---
## ININ.PureCloudApi.Model.InsightsAgents

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef.html) | The performance profile | [optional] |
| **Division** | [**DivisionReference**](DivisionReference.html) | The division | [optional] |
| **Granularity** | **string** | Granularity | [optional] |
| **DateStartWorkday** | **String** | Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Entities** | [**List&lt;InsightsAgentItem&gt;**](InsightsAgentItem.html) | The list of insights agents | [optional] |
{: class="table table-striped"}


