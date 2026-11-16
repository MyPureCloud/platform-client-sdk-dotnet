# AgenticVirtualAgentToolInput

## ININ.PureCloudApi.Model.AgenticVirtualAgentToolInput

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TargetName** | **string** | The unique name that identifies this input parameter within the tool | |
| **Type** | **string** | Input type name. The valid referenced type depends on the input source. | |
| **Source** | **string** | Source of the input value. | |
| **Required** | **bool?** | Whether this input must be supplied. | [optional] |
| **FallbackToUser** | **bool?** | Whether the virtual agent should ask the user for this input value when it is not available from the configured source. | [optional] |
| **DependencyOnly** | **bool?** | Whether this input is used for gating/preconditions only and is not sent with the underlying tool at runtime. | [optional] |
| **Mapping** | **List&lt;Object&gt;** | Path used to extract this input from a previous tool output. Only valid when source is &#39;ToolOutput&#39;. The path starts with a tool output type name, may contain only string property names or integer array indexes, and must resolve to a primitive value. | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
