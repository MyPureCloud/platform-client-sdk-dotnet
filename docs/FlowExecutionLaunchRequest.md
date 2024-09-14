# FlowExecutionLaunchRequest

## ININ.PureCloudApi.Model.FlowExecutionLaunchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FlowId** | **string** | ID of the flow to launch. | |
| **FlowVersion** | **string** | The version of the flow to launch. Omit this value (or supply null/empty) to use the latest published version. | [optional] |
| **InputData** | **Dictionary&lt;string, Object&gt;** | Input values to the flow. Valid values are defined by a flow&#39;s input JSON schema. | [optional] |
| **Name** | **string** | A displayable name to assign to the new flow execution | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
