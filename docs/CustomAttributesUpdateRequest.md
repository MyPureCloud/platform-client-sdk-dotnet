# CustomAttributesUpdateRequest

## ININ.PureCloudApi.Model.CustomAttributesUpdateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Unique identifier for the Custom Attributes record. IDs are created by users. | |
| **Divisions** | **List&lt;string&gt;** | The list of division ids. Use [] if divisions aren&#39;t used (Unassigned Division). Omitting or setting to [] clears existing values on update. | [optional] |
| **SchemaId** | **string** | The id of the schema that dictates which attributes can be included. Required for create, cannot be updated. | [optional] |
| **Version** | **int?** | The latest version of the Custom Attributes record. Optional for concurrency check on update. | [optional] |
| **CustomAttributes** | **Dictionary&lt;string, Object&gt;** | The map of attribute values. | |



_PureCloudPlatform.Client.V2 257.0.0_
