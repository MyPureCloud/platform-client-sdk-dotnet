# ReportingTurn

## ININ.PureCloudApi.Model.ReportingTurn

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UserInput** | **string** | The chosen user input associated with this reporting turn. | [optional] |
| **BotPrompts** | **List&lt;string&gt;** | The bot prompts associated with this reporting turn. | [optional] |
| **SessionId** | **string** | The bot session ID that this reporting turn is grouped under. | [optional] |
| **Conversation** | [**AddressableEntityRef**](AddressableEntityRef) | The conversation details, across potentially multiple Bot Flow sessions. | [optional] |
| **AskAction** | [**ReportingTurnAction**](ReportingTurnAction) | The bot flow &#39;ask&#39; action associated with this reporting turn (e.g. AskForIntent). | [optional] |
| **Intent** | [**ReportingTurnIntent**](ReportingTurnIntent) | The intent and associated slots detected during this reporting turn. | [optional] |
| **Knowledge** | [**ReportingTurnKnowledge**](ReportingTurnKnowledge) | The knowledge data captured during this reporting turn. | [optional] |
| **KnowledgeBaseEvents** | [**ReportingTurnKnowledgeEvents**](ReportingTurnKnowledgeEvents) | The knowledge data captured during this reporting turn. | [optional] |
| **BotFlowInvocationEvents** | [**List&lt;ReportingTurnBotFlowInvocationEvent&gt;**](ReportingTurnBotFlowInvocationEvent) | The details related to the invoking and invoked flows of the bot flow session. | [optional] |
| **DateInputStarted** | **DateTime?** | Timestamp indicating the datetime when the input came from the user. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCreated** | **DateTime?** | Timestamp indicating when the original turn was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateCompleted** | **DateTime?** | Timestamp indicating when the original turn was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AskActionResult** | **string** | Result of the bot flow &#39;ask&#39; action. | [optional] |
| **SessionEndDetails** | [**SessionEndDetails**](SessionEndDetails) | The details related to end of bot flow session. | [optional] |
| **ToolCalls** | [**List&lt;ReportingTurnToolCall&gt;**](ReportingTurnToolCall) | Metadata of tool calls carried out in the reporting turn. | [optional] |
| **GuardrailEvents** | [**List&lt;ReportingTurnGuardrailEvent&gt;**](ReportingTurnGuardrailEvent) | Metadata of any Guardrail events that occurred in the reporting turn. | [optional] |
| **ExecutionFrameId** | **string** | The executionFrameId of the ask action within the reportingTurn. | [optional] |



_PureCloudPlatform.Client.V2 277.0.0_
