# Leaderboard

## ININ.PureCloudApi.Model.Leaderboard

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Division** | [**Division**](Division) | The targeted division for this leaderboard | [optional] |
| **Metric** | [**AddressableEntityRef**](AddressableEntityRef) | The metric id if the leaderboard is about a specific metric | [optional] |
| **DateStartWorkday** | **String** | Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Leaders** | [**List&lt;LeaderboardItem&gt;**](LeaderboardItem) | The list of leaders generated. | [optional] |
| **UserRank** | [**LeaderboardItem**](LeaderboardItem) | The requesting user&#39;s rank | [optional] |
| **PerformanceProfile** | [**AddressableEntityRef**](AddressableEntityRef) | The targeted performance profile for the average points | [optional] |



_PureCloudPlatform.Client.V2 232.0.0_
