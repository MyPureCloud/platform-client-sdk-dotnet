---
title: ScimV2Group
---
## ININ.PureCloudApi.Model.ScimV2Group

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the SCIM resource. Set by the service provider. caseExact is set to true. Mutability is set to readOnly. Returned is set to always. | [optional] |
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
| **DisplayName** | **string** | The display name for the group. | [optional] |
| **Members** | [**List&lt;ScimV2MemberReference&gt;**](ScimV2MemberReference.html) | A list of members in a SCIM group. | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata.html) | Resource SCIM meta | [optional] |
{: class="table table-striped"}


