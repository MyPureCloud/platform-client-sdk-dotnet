# UpdateWorkPlanBid

## ININ.PureCloudApi.Model.UpdateWorkPlanBid

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the work plan bid | [optional] |
| **Forecast** | [**BuShortTermForecastWeekReference**](BuShortTermForecastWeekReference) | The selected forecast in this work plan bid | [optional] |
| **BidWindowStartDate** | **String** | The bid start date where agents start participate in work plan bidding in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **BidWindowEndDate** | **String** | The bid end date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **EffectiveDate** | **String** | The date when agents will be assigned to the new work plan in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **AgentRankingType** | **string** | The type of agent ranking selected for this bid | [optional] |
| **RankingTiebreakerType** | **string** | Ranking tiebreaker | [optional] |
| **WorkPlanFieldsVisibleToAgents** | [**ListWrapperAgentWorkPlanField**](ListWrapperAgentWorkPlanField) | The work plan fields visible to agents whenever work plan preferences are made | [optional] |
| **Status** | **string** | The state of the bid | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
