# AgenticVirtualAgentTypeDefinition

## ININ.PureCloudApi.Model.AgenticVirtualAgentTypeDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Type name. | |
| **Description** | **string** | Additional context that helps the virtual agent understand what this type is used for. | [optional] |
| **Direction** | **string** | Intended direction of use for this type. | [optional] |
| **Type** | **string** | Type value. The applicable fields depend on this value and related fields. | [optional] |
| **UserUtteranceSubstring** | **bool?** | Whether values of this string type must be copied as a contiguous substring from recent user messages. | [optional] |
| **Undisclosed** | **bool?** | Whether values of this string type are hidden from the virtual agent and represented as opaque identifiers. Only valid when type is string. | [optional] |
| **Properties** | [**List&lt;AgenticVirtualAgentPropertyDefinition&gt;**](AgenticVirtualAgentPropertyDefinition) | Properties of this object type. Applies when type is object. | [optional] |
| **Items** | **string** | Type of items in this array type. Applies when type is array. | [optional] |
| **StatusCodes** | **List&lt;int?&gt;** | HTTP 4xx or 5xx status codes this error type can handle. Applies when type is DataActionHttpError. | [optional] |
| **DefaultInstruction** | **string** | Default instruction for how the virtual agent should handle this error type when a tool references it without its own error instruction. Applies when type is DataActionHttpError. | [optional] |
| **Enum** | **List&lt;string&gt;** | Allowed enum values. Applies to enum types. | [optional] |



_PureCloudPlatform.Client.V2 269.0.0_
