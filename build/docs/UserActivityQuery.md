---
title: UserActivityQuery
---
## ININ.PureCloudApi.Model.UserActivityQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metrics** | [**List&lt;UserActivityQueryMetric&gt;**](UserActivityQueryMetric.html) | List of requested metrics | |
| **GroupBy** | **List&lt;string&gt;** | Dimension(s) to group by | |
| **Filter** | [**UserActivityQueryFilter**](UserActivityQueryFilter.html) | Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters | [optional] |
| **Order** | **string** | Sort the result set in ascending/descending order. Default is ascending | [optional] |
{: class="table table-striped"}


