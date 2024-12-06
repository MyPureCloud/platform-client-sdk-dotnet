# FlowRuntimeExecution

## ININ.PureCloudApi.Model.FlowRuntimeExecution

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The flow execution ID | [optional] |
| **Name** | **string** | The flow execution name. | [optional] |
| **FlowVersion** | [**FlowVersion**](FlowVersion) | The Version of the flow definition of the flow execution. | |
| **DateLaunched** | **DateTime?** | The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **Status** | **string** | The flow&#39;s running status, which indicates whether the flow is running normally or completed, etc. | |
| **DateCompleted** | **DateTime?** | The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CompletionReason** | **string** | The completion reason set at the flow completion time, if applicable. | [optional] |
| **FlowErrorInfo** | [**ErrorBody**](ErrorBody) | Additional information if the flow is in error | [optional] |
| **OutputData** | **Dictionary&lt;string, Object&gt;** | List of the flow&#39;s output variables, if any. Output variables are only supplied for Completed flows. | [optional] |
| **Conversation** | [**DomainEntityRef**](DomainEntityRef) | The conversation to which this Flow execution is related | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
