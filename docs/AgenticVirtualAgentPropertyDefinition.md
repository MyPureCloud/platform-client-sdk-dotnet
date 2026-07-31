# AgenticVirtualAgentPropertyDefinition

## ININ.PureCloudApi.Model.AgenticVirtualAgentPropertyDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Property name. | |
| **Type** | **string** | Property type name. The valid type depends on the containing type and related fields. | |
| **Required** | **bool?** | Whether this property must be supplied. | [optional] |
| **Description** | **string** | Additional context that helps the virtual agent understand what this property means. | [optional] |
| **Items** | **string** | Type of items in this array property. Applies when type is array. | [optional] |
| **Mapping** | **List&lt;Object&gt;** | Path used to extract this output data property from a tool output. Only valid for output data properties. The path starts with a tool output type name, may contain only string property names or integer array indexes, and must resolve to a primitive value. | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
