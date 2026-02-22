# ConversationJsonSchemaDocument

## ININ.PureCloudApi.Model.ConversationJsonSchemaDocument

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schema** | **string** | The JSON Schema specification link. The only value currently supported is \&quot;http://json-schema.org/draft-04/schema#\&quot;. | [optional] |
| **Title** | **string** | The title of the schema. Must be unique across all enabled Custom Attributes Schemas. | [optional] |
| **Description** | **string** | The schema description. | [optional] |
| **Required** | **List&lt;string&gt;** | The list of required schema properties. All fields are optional unless listed. New fields added after initial schema creation must be optional before being able to update to required. | [optional] |
| **Properties** | **Dictionary&lt;string, Object&gt;** | The map of schema properties and their limits. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
