# ScheduleBid

## ININ.PureCloudApi.Model.ScheduleBid

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the schedule bid | |
| **Name** | **string** | The name of the schedule bid | |
| **BidWindowStartDate** | **String** | The bid start date when agents can start participating in schedule bidding relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **BidWindowEndDate** | **String** | The bid end date relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **EffectiveDate** | **String** | The date when schedule sets would be effective for schedule generation relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | |
| **Status** | **string** | The state of the bid | |
| **BidType** | **string** | The type of the bid | |
| **Forecast** | [**BuShortTermForecastWeekReference**](BuShortTermForecastWeekReference) | The selected forecast used for schedule set generation for this bid | [optional] |
| **WeeksToSchedule** | **int?** | The number of weeks to generate schedule sets through this bid | |
| **EndOverridesAndRotations** | **bool?** | If true, all existing overrides, work plan rotations will be ended one day before effective date of this bid | |
| **AgentRankingType** | **string** | The type of agent ranking selected for this bid | |
| **RankingTiebreakerType** | **string** | Ranking tiebreaker | |
| **PublishedDate** | **DateTime?** | The date the schedule bid is published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndDate** | **String** | The end date until which schedule sets can be used for schedule generation. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Metadata** | [**WorkPlanBidMetadata**](WorkPlanBidMetadata) | The metadata of this bid | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
