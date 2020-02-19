---
title: ScimV2SchemaListResponse
---
## ININ.PureCloudApi.Model.ScimV2SchemaListResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TotalResults** | **long?** | The total number of results. | [optional] |
| **StartIndex** | **long?** | The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results. | [optional] |
| **ItemsPerPage** | **long?** | The number of resources returned per page. | [optional] |
| **Resources** | [**List&lt;ScimV2SchemaDefinition&gt;**](ScimV2SchemaDefinition.html) | Resources | [optional] |
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
{: class="table table-striped"}


