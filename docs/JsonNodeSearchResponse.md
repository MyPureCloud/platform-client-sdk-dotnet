# JsonNodeSearchResponse

## ININ.PureCloudApi.Model.JsonNodeSearchResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Total** | **long?** | The total number of results found | |
| **PageCount** | **int?** | The total number of pages | |
| **PageSize** | **int?** | The current page size | |
| **PageNumber** | **int?** | The current page number | |
| **PreviousPage** | **string** | Q64 value for the previous page of results | [optional] |
| **CurrentPage** | **string** | Q64 value for the current page of results | [optional] |
| **NextPage** | **string** | Q64 value for the next page of results | [optional] |
| **Types** | **List&lt;string&gt;** | Resource types the search was performed against | |
| **Results** | **Object** | Search results | |
| **Aggregations** | **Object** |  | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
