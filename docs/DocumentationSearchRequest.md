# DocumentationSearchRequest

## ININ.PureCloudApi.Model.DocumentationSearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SortOrder** | **string** | The sort order for results | [optional] |
| **SortBy** | **string** | The field in the resource that you want to sort the results by | [optional] |
| **PageSize** | **int?** | The number of results per page | [optional] |
| **PageNumber** | **int?** | The page of resources you want to retrieve | [optional] |
| **Sort** | [**List&lt;SearchSort&gt;**](SearchSort) | Multi-value sort order, list of multiple sort values | [optional] |
| **Query** | [**List&lt;DocumentationSearchCriteria&gt;**](DocumentationSearchCriteria) |  | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
