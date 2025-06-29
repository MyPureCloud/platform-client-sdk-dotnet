# V2FlowExecutionDataFlowidTopicFlowExecutionItem

## ININ.PureCloudApi.Model.V2FlowExecutionDataFlowidTopicFlowExecutionItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ObjectType** | **string** | The type of executionItem that was executed. | [optional] |
| **ObjectId** | **string** | If applicable, the actionId, menuId or taskId for the executionItem. | [optional] |
| **OutputPathId** | **string** | If applicable, the identifier of the OutputPath that was taken. | [optional] |
| **ExecutionId** | **string** | If applicable, the executionId for the executionItem. | [optional] |
| **StartDateTime** | **DateTime?** | This is the starting time of the executionItem. | [optional] |
| **Error** | [**V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo**](V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo) | Event generated when a Flow&#39;s Execution History is received and logged. | [optional] |
| **Warning** | [**V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo**](V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo) | Event generated when a Flow&#39;s Execution History is received and logged. | [optional] |
| **LanguageTag** | **string** | If applicable, the language tag associated set by the execution. | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
