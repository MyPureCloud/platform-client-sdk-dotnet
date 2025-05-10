# AnalyticsFlow

## ININ.PureCloudApi.Model.AnalyticsFlow

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EndingLanguage** | **string** | Flow ending language, e.g. en-us | [optional] |
| **EntryReason** | **string** | The particular entry reason for this flow, e.g. an address, userId, or flowId | [optional] |
| **EntryType** | **string** | The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct | [optional] |
| **ExitReason** | **string** | The exit reason for this flow, e.g. DISCONNECT | [optional] |
| **FlowId** | **string** | The unique identifier of this flow | [optional] |
| **FlowName** | **string** | The name of this flow at the time of flow execution | [optional] |
| **FlowType** | **string** | The type of this flow | [optional] |
| **FlowVersion** | **string** | The version of this flow | [optional] |
| **IssuedCallback** | **bool?** | Flag indicating whether the flow issued a callback | [optional] |
| **RecognitionFailureReason** | **string** | The recognition failure reason causing to exit/disconnect | [optional] |
| **StartingLanguage** | **string** | Flow starting language, e.g. en-us | [optional] |
| **TransferTargetAddress** | **string** | The address of a flow transfer target, e.g. a phone number, an email address, or a queueId | [optional] |
| **TransferTargetName** | **string** | The name of a flow transfer target | [optional] |
| **TransferType** | **string** | The type of transfer for flows that ended with a transfer | [optional] |
| **Outcomes** | [**List&lt;AnalyticsFlowOutcome&gt;**](AnalyticsFlowOutcome) | Flow outcomes | [optional] |



_PureCloudPlatform.Client.V2 233.0.0_
