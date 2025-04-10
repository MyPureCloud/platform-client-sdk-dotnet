# UserActivityQuery

## ININ.PureCloudApi.Model.UserActivityQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metrics** | [**List&lt;UserActivityQueryMetric&gt;**](UserActivityQueryMetric) | List of requested metrics | |
| **GroupBy** | **List&lt;string&gt;** | Dimension(s) to group by | |
| **Filter** | [**UserActivityQueryFilter**](UserActivityQueryFilter) | Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters | [optional] |
| **Order** | **string** | Sort the result set in ascending/descending order. Default is ascending | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
