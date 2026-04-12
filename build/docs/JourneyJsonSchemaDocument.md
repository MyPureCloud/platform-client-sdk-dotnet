# JourneyJsonSchemaDocument

## ININ.PureCloudApi.Model.JourneyJsonSchemaDocument

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Schema** | **string** | The JSON Schema specification link. The only value currently supported is \&quot;http://json-schema.org/draft-04/schema#\&quot;. | |
| **Title** | **string** | The title of the schema. Must be unique across all enabled External Event schemas. | |
| **Description** | **string** | The schema description. | [optional] |
| **Required** | **List&lt;string&gt;** | The list of required schema properties. All fields are optional unless listed. Optional fields can&#39;t be changed to required after the schema is saved. | [optional] |
| **Properties** | **Dictionary&lt;string, Object&gt;** | The map of schema properties and their limits. | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
