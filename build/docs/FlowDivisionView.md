---
title: FlowDivisionView
---
## ININ.PureCloudApi.Model.FlowDivisionView

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The flow identifier | [optional] |
| **Name** | **string** | The flow name | |
| **Division** | [**WritableDivision**](WritableDivision.html) | The division to which this entity belongs. | [optional] |
| **Type** | **string** |  | [optional] |
| **Description** | **string** | the flow description | [optional] |
| **InputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument.html) | json schema describing the inputs for the flow | [optional] |
| **OutputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument.html) | json schema describing the outputs for the flow | [optional] |
| **SupportedLanguages** | [**List&lt;SupportedLanguage&gt;**](SupportedLanguage.html) | List of supported languages for the published version of the flow. | [optional] |
| **PublishedVersion** | [**FlowVersion**](FlowVersion.html) | published version information if there is a published version | [optional] |
| **DebugVersion** | [**FlowVersion**](FlowVersion.html) | debug version information if there is a debug version | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


