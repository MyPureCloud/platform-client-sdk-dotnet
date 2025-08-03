# AsyncUserDetailsQuery

## ININ.PureCloudApi.Model.AsyncUserDetailsQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **UserFilters** | [**List&lt;UserDetailQueryFilter&gt;**](UserDetailQueryFilter) | Filters that target the users to retrieve data for | [optional] |
| **PresenceFilters** | [**List&lt;PresenceDetailQueryFilter&gt;**](PresenceDetailQueryFilter) | Filters that target system and organization presence-level data | [optional] |
| **RoutingStatusFilters** | [**List&lt;RoutingStatusDetailQueryFilter&gt;**](RoutingStatusDetailQueryFilter) | Filters that target agent routing status-level data | [optional] |
| **Order** | **string** | Sort the result set in ascending/descending order. Default is ascending | [optional] |
| **Limit** | **int?** | Specify number of results to be returned | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
