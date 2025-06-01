# ScimConfigResourceTypesListResponse

## ININ.PureCloudApi.Model.ScimConfigResourceTypesListResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
| **TotalResults** | **long?** | The total number of results. | [optional] |
| **StartIndex** | **long?** | The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results. | [optional] |
| **ItemsPerPage** | **long?** | The number of resources returned per page. | [optional] |
| **Resources** | [**List&lt;ScimConfigResourceType&gt;**](ScimConfigResourceType) | The list of requested resources. | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
