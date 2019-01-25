---
title: AnalyticsFlow
---
## ININ.PureCloudApi.Model.AnalyticsFlow

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FlowId** | **string** | The unique identifier of this flow | [optional] |
| **FlowName** | **string** | The name of this flow | [optional] |
| **FlowVersion** | **string** | The version of this flow | [optional] |
| **FlowType** | **string** | The type of this flow | [optional] |
| **ExitReason** | **string** | The exit reason for this flow, e.g. DISCONNECT | [optional] |
| **EntryReason** | **string** | The particular entry reason for this flow, e.g. an address, userId, or flowId | [optional] |
| **EntryType** | **string** | The entry type for this flow | [optional] |
| **TransferType** | **string** | The type of transfer for flows that ended with a transfer | [optional] |
| **TransferTargetName** | **string** | The name of a transfer target | [optional] |
| **TransferTargetAddress** | **string** | The address of a transfer target | [optional] |
| **IssuedCallback** | **bool?** | Flag indicating whether the flow issued a callback | [optional] |
| **StartingLanguage** | **string** | Flow starting language, e.g. en-us | [optional] |
| **EndingLanguage** | **string** | Flow ending language, e.g. en-us | [optional] |
| **Outcomes** | [**List&lt;AnalyticsFlowOutcome&gt;**](AnalyticsFlowOutcome.html) | Flow outcomes | [optional] |
{: class="table table-striped"}


