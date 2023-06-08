---
title: TeamActivityQuery
---
## ININ.PureCloudApi.Model.TeamActivityQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metrics** | [**List&lt;TeamActivityQueryMetric&gt;**](TeamActivityQueryMetric.html) | List of requested metrics | |
| **GroupBy** | **List&lt;string&gt;** | Dimension(s) to group by | |
| **Filter** | [**TeamActivityQueryFilter**](TeamActivityQueryFilter.html) | Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters | [optional] |
| **Order** | **string** | Sort the result set in ascending/descending order. Default is ascending | [optional] |
{: class="table table-striped"}


