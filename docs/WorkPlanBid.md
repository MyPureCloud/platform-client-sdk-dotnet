# WorkPlanBid

## ININ.PureCloudApi.Model.WorkPlanBid

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the work plan bid | |
| **Name** | **string** | The name of the work plan bid | |
| **Forecast** | [**BuShortTermForecastWeekReference**](BuShortTermForecastWeekReference) | The selected forecast in this work plan bid | [optional] |
| **BidWindowStartDate** | **String** | The bid start date where agents start participate in work plan bidding. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **BidWindowEndDate** | **String** | The bid end date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **EffectiveDate** | **String** | The date when agents will be assigned to the new work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Status** | **string** | The state of the bid | |
| **AgentRankingType** | **string** | The type of agent ranking selected for this bid | |
| **RankingTiebreakerType** | **string** | Ranking tiebreaker | |
| **PublishedDate** | **DateTime?** | The date the work plan bid published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **WorkPlanFieldsVisibleToAgents** | **List&lt;string&gt;** | The work plan fields visible to agents whenever work plan preferences are made | |
| **Metadata** | [**WorkPlanBidMetadata**](WorkPlanBidMetadata) | The meta data of this bid | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
