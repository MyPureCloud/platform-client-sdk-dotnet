---
title: ScimConfigResourceType
---
## ININ.PureCloudApi.Model.ScimConfigResourceType

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;Mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;Returned\&quot; is set to \&quot;always\&quot;. | [optional] |
| **Schemas** | **List&lt;string&gt;** | The list of supported schemas. | [optional] |
| **Name** | **string** | The name of the resource type. | [optional] |
| **Description** | **string** | The description of the resource type. | [optional] |
| **Schema** | **string** | The URI of the primary or base schema for the resource type. | [optional] |
| **SchemaExtensions** | [**List&lt;ScimConfigResourceTypeSchemaExtension&gt;**](ScimConfigResourceTypeSchemaExtension.html) | The list of schema extensions for the resource type. | [optional] |
| **Endpoint** | **string** | The HTTP-addressable endpoint of the resource type. Appears after the base URL. | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata.html) | Resource SCIM meta | [optional] |
{: class="table table-striped"}


