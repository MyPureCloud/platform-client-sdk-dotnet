# PerformanceProfile

## ININ.PureCloudApi.Model.PerformanceProfile

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | A name for this performance profile | |
| **Division** | [**Division**](Division) | The division for this performance profile associate to | [optional] |
| **Description** | **string** | A description about this performance profile | |
| **MetricOrders** | **List&lt;string&gt;** | Order of the associated metrics. The list should contain valid ids for metrics | |
| **DateCreated** | **DateTime?** | Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ReportingIntervals** | [**List&lt;ReportingInterval&gt;**](ReportingInterval) | The reporting interval periods for this performance profile | [optional] |
| **Active** | **bool?** | The flag for active profiles | [optional] |
| **MemberCount** | **int?** | The number of members in this performance profile | [optional] |
| **MaxLeaderboardRankSize** | **int?** | The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
