---
title: ScimGroupListResponse
---
## ININ.PureCloudApi.Model.ScimGroupListResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TotalResults** | **long?** | The total number of results. | [optional] |
| **StartIndex** | **long?** | The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results. | [optional] |
| **ItemsPerPage** | **long?** | The number of resources returned per page. | [optional] |
| **Resources** | [**List&lt;ScimV2Group&gt;**](ScimV2Group.html) | The list of requested resources. If \&quot;count\&quot; is 0, then the list will be empty. | [optional] |
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
{: class="table table-striped"}


