---
title: ConversationActivityQuery
---
## ININ.PureCloudApi.Model.ConversationActivityQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metrics** | [**List&lt;ConversationActivityQueryMetric&gt;**](ConversationActivityQueryMetric.html) | List of requested metrics | |
| **GroupBy** | **List&lt;string&gt;** | Dimension(s) to group by | |
| **Filter** | [**ConversationActivityQueryFilter**](ConversationActivityQueryFilter.html) | Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters | [optional] |
| **Order** | **string** | Sort the result set in ascending/descending order. Default is ascending | [optional] |
{: class="table table-striped"}


