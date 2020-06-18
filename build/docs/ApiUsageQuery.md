---
title: ApiUsageQuery
---
## ININ.PureCloudApi.Model.ApiUsageQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **Granularity** | **string** | Date granularity of the results | [optional] |
| **GroupBy** | **List&lt;string&gt;** | Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group. | [optional] |
| **Metrics** | **List&lt;string&gt;** | Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *). | [optional] |
{: class="table table-striped"}


