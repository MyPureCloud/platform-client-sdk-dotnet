---
title: SearchRequest
---
## ININ.PureCloudApi.Model.SearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SortOrder** | **string** | The sort order for results | [optional] |
| **SortBy** | **string** | The field in the resource that you want to sort the results by | [optional] |
| **PageSize** | **int?** | The number of results per page | [optional] |
| **PageNumber** | **int?** | The page of resources you want to retrieve | [optional] |
| **ReturnFields** | **List&lt;string&gt;** | A List of strings.  Possible values are any field in the resource you are searching on.  The other option is to use ALL_FIELDS, when this is provided all fields in the resource will be returned in the search results. | [optional] |
| **Expand** | **List&lt;string&gt;** | Provides more details about a specified resource | [optional] |
| **Types** | **List&lt;string&gt;** | Resource domain type to search | |
| **Query** | [**List&lt;SearchCriteria&gt;**](SearchCriteria.html) | The search criteria | [optional] |
| **Aggregations** | [**List&lt;SearchAggregation&gt;**](SearchAggregation.html) | Aggregation criteria | [optional] |
{: class="table table-striped"}


