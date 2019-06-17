---
title: ScimV2PatchOperation
---
## ININ.PureCloudApi.Model.ScimV2PatchOperation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Op** | **string** | Patch operation | |
| **Path** | **string** | Attribute path describing the target of the operation.  Required for &#39;remove&#39; operation. | [optional] |
| **Value** | [**JsonNode**](JsonNode.html) | Value to set in the specified path | [optional] |
{: class="table table-striped"}


