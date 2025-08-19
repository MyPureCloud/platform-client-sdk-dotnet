# InsightsAgents

## ININ.PureCloudApi.Model.InsightsAgents

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef) | The performance profile | [optional] |
| **Division** | [**DivisionReference**](DivisionReference) | The division | [optional] |
| **Granularity** | **string** | Granularity | [optional] |
| **DateStartWorkday** | **String** | Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Entities** | [**List&lt;InsightsAgentItem&gt;**](InsightsAgentItem) | The list of insights agents | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
