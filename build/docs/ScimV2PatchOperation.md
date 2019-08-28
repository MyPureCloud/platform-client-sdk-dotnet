---
title: ScimV2PatchOperation
---
## ININ.PureCloudApi.Model.ScimV2PatchOperation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Op** | **string** | The patch operation to perform. | |
| **Path** | **string** | The attribute path that describes the target of the operation. Required for a &#39;remove&#39; operation. | [optional] |
| **Value** | [**JsonNode**](JsonNode.html) | The value to set in the path. | [optional] |
{: class="table table-striped"}


