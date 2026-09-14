# ContactSearchRequest

## ININ.PureCloudApi.Model.ContactSearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageNumber** | **int?** | Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] |
| **PageSize** | **int?** | Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] |
| **DivisionIds** | **List&lt;string&gt;** | Which divisions to search, up to 50 | [optional] |
| **Expand** | **List&lt;string&gt;** | Which fields, if any, to expand | [optional] |
| **Operation** | [**ContactSearchOperation**](ContactSearchOperation) | Search operation to execute, currently supports {@code simpleSearch} only. | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
