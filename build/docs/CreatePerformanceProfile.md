# CreatePerformanceProfile

## ININ.PureCloudApi.Model.CreatePerformanceProfile

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | A name for this performance profile | |
| **Division** | [**WritableDivision**](WritableDivision) | The associated division for this Performance Profile | |
| **Description** | **string** | A description about this performance profile | |
| **MetricOrders** | **List&lt;string&gt;** | Order of the associated metrics. The list should contain valid ids for metrics | [optional] |
| **DateCreated** | **DateTime?** | Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ReportingIntervals** | [**List&lt;ReportingInterval&gt;**](ReportingInterval) | The reporting interval periods for this performance profile | |
| **Active** | **bool?** | The flag for active profiles | |
| **MemberCount** | **int?** | The number of members in this performance profile | [optional] |
| **MaxLeaderboardRankSize** | **int?** | The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.1.0_
