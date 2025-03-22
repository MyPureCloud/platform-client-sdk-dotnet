# OverallBestPointsItem

## ININ.PureCloudApi.Model.OverallBestPointsItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **GranularityType** | **string** | Best points aggregation interval granularity | [optional] |
| **Users** | [**List&lt;UserReference&gt;**](UserReference) | List of associated users with the equal points. | [optional] |
| **Count** | **int?** | The count of the user IDs in the list | [optional] |
| **Points** | **int?** | Gamification points | [optional] |
| **DateStartWorkday** | **String** | Start workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | End workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |



_PureCloudPlatform.Client.V2 229.0.0_
