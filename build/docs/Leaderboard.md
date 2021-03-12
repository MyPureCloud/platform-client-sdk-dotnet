---
title: Leaderboard
---
## ININ.PureCloudApi.Model.Leaderboard

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Division** | [**Division**](Division.html) | The targeted division for this leaderboard | [optional] |
| **Metric** | [**Metric**](Metric.html) | The metric id if the leaderboard is about a specific metric | [optional] |
| **DateStartWorkday** | **String** | Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Leaders** | [**List&lt;LeaderboardItem&gt;**](LeaderboardItem.html) | The list of leaders generated. | [optional] |
{: class="table table-striped"}


