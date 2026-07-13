# CreateScheduleBid

## ININ.PureCloudApi.Model.CreateScheduleBid

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the schedule bid | |
| **Forecast** | [**BuShortTermForecastWeekReference**](BuShortTermForecastWeekReference) | The selected forecast used for schedule set generation for this bid | [optional] |
| **BidWindowStartDate** | **String** | The bid start date where agents start participating in schedule bidding relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **BidWindowEndDate** | **String** | The bid end date relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **EffectiveDate** | **String** | The date when schedule sets would be effective for schedule generation relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **WeeksToSchedule** | **int?** | The number of weeks to generate schedule set through this bid | |
| **EndOverridesAndRotations** | **bool?** | If true, all existing overrides, work plan rotations will be ended one day before effective date of this bid | [optional] |
| **AgentRankingType** | **string** | The type of agent ranking selected for this bid | |
| **RankingTiebreakerType** | **string** | Ranking tiebreaker to be used | |



_PureCloudPlatform.Client.V2 268.0.0_
