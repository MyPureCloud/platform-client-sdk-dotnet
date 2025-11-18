# RoutingActivityQuery

## ININ.PureCloudApi.Model.RoutingActivityQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metrics** | [**List&lt;RoutingActivityQueryMetric&gt;**](RoutingActivityQueryMetric) | List of requested metrics | |
| **GroupBy** | **List&lt;string&gt;** | Dimension(s) to group by | |
| **Filter** | [**RoutingActivityQueryFilter**](RoutingActivityQueryFilter) | Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters | [optional] |
| **Order** | **string** | Sort the result set in ascending/descending order. Default is ascending | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
