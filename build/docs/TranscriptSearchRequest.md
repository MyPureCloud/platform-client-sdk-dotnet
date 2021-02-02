---
title: TranscriptSearchRequest
---
## ININ.PureCloudApi.Model.TranscriptSearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SortOrder** | **string** | The sort order for results | [optional] |
| **SortBy** | **string** | The field in the resource that you want to sort the results by | [optional] |
| **PageSize** | **int?** | The number of results per page | [optional] |
| **PageNumber** | **int?** | The page of resources you want to retrieve | [optional] |
| **Sort** | [**List&lt;SearchSort&gt;**](SearchSort.html) | Multi-value sort order, list of multiple sort values | [optional] |
| **ReturnFields** | **List&lt;string&gt;** |  | [optional] |
| **Types** | **List&lt;string&gt;** | Resource domain type to search | |
| **Query** | [**List&lt;TranscriptSearchCriteria&gt;**](TranscriptSearchCriteria.html) | The search criteria | [optional] |
{: class="table table-striped"}


