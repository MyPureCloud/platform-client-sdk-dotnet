# TelephonySearchRequest

## ININ.PureCloudApi.Model.TelephonySearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SortOrder** | **string** | The sort order for results | [optional] |
| **SortBy** | **string** | The field in the resource that you want to sort the results by | [optional] |
| **PageSize** | **int?** | The number of results per page | [optional] |
| **PageNumber** | **int?** | The page of resources you want to retrieve | [optional] |
| **Sort** | [**List&lt;SearchSort&gt;**](SearchSort) | Multi-value sort order, list of multiple sort values | [optional] |
| **Expand** | **List&lt;string&gt;** |  | [optional] |
| **Query** | [**List&lt;TelephonySearchCriteria&gt;**](TelephonySearchCriteria) |  | [optional] |



_PureCloudPlatform.Client.V2 271.0.0_
