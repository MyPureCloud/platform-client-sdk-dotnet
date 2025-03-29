# WorkbinQueryRequest

## ININ.PureCloudApi.Model.WorkbinQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageSize** | **int?** | Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200. | [optional] |
| **Select** | **string** | Specify the value &#39;Count&#39; for this parameter in order to return only the record count. | [optional] |
| **Filters** | [**List&lt;WorkitemFilter&gt;**](WorkitemFilter) | List of filter objects to be used in the search. | |
| **Attributes** | **List&lt;string&gt;** | List of entity attributes to be retrieved in the result. | [optional] |
| **After** | **string** | The cursor that points to the end of the set of entities that has been returned. | [optional] |
| **Sort** | [**WorkbinQuerySort**](WorkbinQuerySort) | Sort | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
