# FlowDivisionView

## ININ.PureCloudApi.Model.FlowDivisionView

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The flow identifier | [optional] |
| **Name** | **string** | The flow name | |
| **Division** | [**WritableDivision**](WritableDivision) | The division to which this entity belongs. | [optional] |
| **Type** | **string** |  | [optional] |
| **Description** | **string** | the flow description | [optional] |
| **InputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) | json schema describing the inputs for the flow | [optional] |
| **OutputSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) | json schema describing the outputs for the flow | [optional] |
| **SupportedLanguages** | [**List&lt;SupportedLanguage&gt;**](SupportedLanguage) | List of supported languages for the published version of the flow. | [optional] |
| **PublishedVersion** | [**FlowVersion**](FlowVersion) | published version information if there is a published version | [optional] |
| **DebugVersion** | [**FlowVersion**](FlowVersion) | debug version information if there is a debug version | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
