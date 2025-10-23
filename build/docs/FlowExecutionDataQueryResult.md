# FlowExecutionDataQueryResult

## ININ.PureCloudApi.Model.FlowExecutionDataQueryResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **StartDateTime** | **DateTime?** | The start time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EndDateTime** | **DateTime?** | The end time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **FlowId** | **string** | The id of the flow that was executed. | [optional] |
| **FlowVersion** | **string** | The version of the flow that was executed. | [optional] |
| **ConversationId** | **string** | The id of the conversation that executed this flow. | [optional] |
| **WorkitemId** | **string** | The id of the workitem that executed this flow. | [optional] |
| **FlowType** | **string** | The type of flow. | [optional] |
| **FlowErrorReason** | **string** | If the flow errored out this is the reason. | [optional] |
| **FlowWarningReason** | **string** | If the flow had a warning, this is the reason. | [optional] |
| **FlowName** | **string** | The name of the flow. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 246.0.0_
