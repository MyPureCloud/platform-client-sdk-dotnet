# CreateWorkPlanBid

## ININ.PureCloudApi.Model.CreateWorkPlanBid

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the work plan bid | |
| **Forecast** | [**BuShortTermForecastWeekReference**](BuShortTermForecastWeekReference) | The selected forecast in this work plan bid | [optional] |
| **BidWindowStartDate** | **String** | The bid start date where agents start participate in work plan bidding in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **BidWindowEndDate** | **String** | The bid end date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **EffectiveDate** | **String** | The date when agents will be assigned to the new work plan in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **AgentRankingType** | **string** | The type of agent ranking selected for this bid | |
| **RankingTiebreakerType** | **string** | Ranking tiebreaker to be used | |
| **WorkPlanFieldsVisibleToAgents** | **List&lt;string&gt;** | The work plan fields visible to agents whenever work plan preferences are made | |



_PureCloudPlatform.Client.V2 238.0.0_
