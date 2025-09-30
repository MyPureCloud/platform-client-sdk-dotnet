# UserDetailsQuery

## ININ.PureCloudApi.Model.UserDetailsQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **UserFilters** | [**List&lt;UserDetailQueryFilter&gt;**](UserDetailQueryFilter) | Filters that target the users to retrieve data for | [optional] |
| **PresenceFilters** | [**List&lt;PresenceDetailQueryFilter&gt;**](PresenceDetailQueryFilter) | Filters that target system and organization presence-level data | [optional] |
| **RoutingStatusFilters** | [**List&lt;RoutingStatusDetailQueryFilter&gt;**](RoutingStatusDetailQueryFilter) | Filters that target agent routing status-level data | [optional] |
| **Order** | **string** | Sort the result set in ascending/descending order. Default is ascending | [optional] |
| **PresenceAggregations** | [**List&lt;AnalyticsQueryAggregation&gt;**](AnalyticsQueryAggregation) | Include faceted search and aggregate roll-ups of presence data in your search results. This does not function as a filter, but rather, summary data about the presence results matching your filters | [optional] |
| **RoutingStatusAggregations** | [**List&lt;AnalyticsQueryAggregation&gt;**](AnalyticsQueryAggregation) | Include faceted search and aggregate roll-ups of agent routing status data in your search results. This does not function as a filter, but rather, summary data about the agent routing status results matching your filters | [optional] |
| **Paging** | [**PagingSpec**](PagingSpec) | Page size and number to control iterating through large result sets. Default page size is 25 | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
