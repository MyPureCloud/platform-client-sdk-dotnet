# V2FlowExecutionDataFlowidTopicFlowExecutionHistory

## ININ.PureCloudApi.Model.V2FlowExecutionDataFlowidTopicFlowExecutionHistory

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ExecutionId** | **string** | The execution identifier which represents this unique instance of the flow that ran. | [optional] |
| **ConversationId** | **string** | The Genesys Cloud conversation identifier associated with this flow instance execution data. | [optional] |
| **DivisionId** | **string** | The division identifier for the division associated with the flow for this flow instance. | [optional] |
| **EndDateTime** | **DateTime?** | The end date time for this flow instance execution data. | [optional] |
| **Endpoint** | **string** | The public endpoint a user can use to retrieve the full historical log from the service. | [optional] |
| **Errors** | [**List&lt;V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo&gt;**](V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo) | If the flow invoked error handling, an array of errors. | [optional] |
| **Execution** | [**List&lt;V2FlowExecutionDataFlowidTopicFlowExecutionItem&gt;**](V2FlowExecutionDataFlowidTopicFlowExecutionItem) | An array of execution items that describe what happened when an Architect flow action container ran such as a flow, task, state or bot. | [optional] |
| **FlowExitReason** | **string** | Provides information about why a flow ended. | [optional] |
| **FlowId** | **string** | The flow identifier for this flow instance execution data.  This is the identifier of the flow configuration that users load up in Architect. | [optional] |
| **FlowIsDebug** | **bool?** | Whether the flow that ran for this flow instance execution data was in debug mode. | [optional] |
| **ExecutionItemsTruncated** | **bool?** | If true, the execution items in this event have been truncated to be deliverable. | [optional] |
| **FlowType** | **string** | The flow type of the Architect flow that was run. | [optional] |
| **FlowVersion** | **string** | The version of the flow for this flow instance execution data. Typically this is a numeric value like 1.0 represented as a string but can also be &#39;debug&#39; | [optional] |
| **MessageType** | **string** | If applicable, the type of message platform from which the message originated. | [optional] |
| **InvokingContext** | [**V2FlowExecutionDataFlowidTopicInvokingContextInfo**](V2FlowExecutionDataFlowidTopicInvokingContextInfo) |  | [optional] |
| **StartDateTime** | **DateTime?** | The start date time for this flow instance execution data. | [optional] |
| **Warnings** | [**List&lt;V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo&gt;**](V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo) | If the flow encountered a warning during execution, this is an array of the warnings. | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
