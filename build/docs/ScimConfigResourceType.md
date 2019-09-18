---
title: ScimConfigResourceType
---
## ININ.PureCloudApi.Model.ScimConfigResourceType

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the SCIM resource. Set by the service provider. caseExact is set to true. Mutability is set to readOnly. Returned is set to always. | [optional] |
| **Schemas** | **List&lt;string&gt;** | schemas supported | [optional] |
| **Name** | **string** | Resource name. | [optional] |
| **Description** | **string** | Resource description. | [optional] |
| **Schema** | **string** | The resource type&#39;s primary/base schema URI. | [optional] |
| **SchemaExtensions** | [**List&lt;ScimConfigResourceTypeSchemaExtension&gt;**](ScimConfigResourceTypeSchemaExtension.html) | Resource extension schemas | [optional] |
| **Endpoint** | **string** | Resource HTTP endpoint. | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata.html) | Resource SCIM meta | [optional] |
{: class="table table-striped"}


