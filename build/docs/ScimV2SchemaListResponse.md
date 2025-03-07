# ScimV2SchemaListResponse

## ININ.PureCloudApi.Model.ScimV2SchemaListResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
| **TotalResults** | **long?** | The total number of results. | [optional] |
| **StartIndex** | **long?** | The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results. | [optional] |
| **ItemsPerPage** | **long?** | The number of resources returned per page. | [optional] |
| **Resources** | [**List&lt;ScimV2SchemaDefinition&gt;**](ScimV2SchemaDefinition) | The list of requested resources. | [optional] |



_PureCloudPlatform.Client.V2 228.0.0_
