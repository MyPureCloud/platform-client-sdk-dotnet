# ConversationCustomAttributesSearchRequest

## ININ.PureCloudApi.Model.ConversationCustomAttributesSearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Expand** | **List&lt;string&gt;** | Expand your search with bulk lookups | [optional] |
| **QueryReservedFields** | [**List&lt;ConversationCustomAttributesSearchCriteria&gt;**](ConversationCustomAttributesSearchCriteria) | The search criteria for reserved fields | [optional] |
| **QueryCustomAttributes** | [**List&lt;ConversationCustomAttributesSearchCriteria&gt;**](ConversationCustomAttributesSearchCriteria) | The search criteria for custom attributes | [optional] |
| **PageSize** | **int?** | The number of results per page | [optional] |
| **PageNumber** | **int?** | The page of resources you want to retrieve | [optional] |
| **Sort** | [**List&lt;SearchSort&gt;**](SearchSort) | Multi-value sort order, list of multiple sort values | [optional] |
| **SortBy** | **string** | The field in the resource that you want to sort the results by | [optional] |
| **SortOrder** | **string** | The sort order for results | [optional] |



_PureCloudPlatform.Client.V2 276.0.0_
