# ScimV2SchemaDefinition

## ININ.PureCloudApi.Model.ScimV2SchemaDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;. | [optional] |
| **Name** | **string** | The name of the schema. | [optional] |
| **Description** | **string** | The description of the schema. | [optional] |
| **Attributes** | [**List&lt;ScimV2SchemaAttribute&gt;**](ScimV2SchemaAttribute) | The list of service provider attributes. | [optional] |
| **Meta** | [**ScimMetadata**](ScimMetadata) | The metadata of the SCIM resource. Only \&quot;location\&quot; and \&quot;resourceType\&quot; are set for \&quot;Schema\&quot; resources. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
