# DocumentationV2SearchRequest

## ININ.PureCloudApi.Model.DocumentationV2SearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SortOrder** | **string** | The sort order for results | [optional] |
| **SortBy** | **string** | The field in the resource that you want to sort the results by | [optional] |
| **PageSize** | **int?** | The number of results per page | [optional] |
| **PageNumber** | **int?** | The page of resources you want to retrieve | [optional] |
| **Sort** | [**List&lt;SearchSort&gt;**](SearchSort) | Multi-value sort order, list of multiple sort values | [optional] |
| **Types** | **List&lt;string&gt;** | Resource domain type to search | |
| **Query** | [**List&lt;DocumentationV2SearchCriteria&gt;**](DocumentationV2SearchCriteria) | The search criteria | [optional] |
| **Aggregations** | [**List&lt;DocumentationV2SearchAggregation&gt;**](DocumentationV2SearchAggregation) | Aggregation criteria | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
