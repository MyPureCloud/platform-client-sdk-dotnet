---
title: ScimV2Group
---
## ININ.PureCloudApi.Model.ScimV2Group

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;Mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;Returned\&quot; is set to \&quot;always\&quot;. | [optional] |
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
| **DisplayName** | **string** | The display name of the group. | [optional] |
| **Members** | [**List&lt;ScimV2MemberReference&gt;**](ScimV2MemberReference.html) | The list of members in the group. | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata.html) | Resource SCIM meta | [optional] |
{: class="table table-striped"}


