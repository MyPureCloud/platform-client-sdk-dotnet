# ConversationChecklistTopicAgentChecklistRuntimeEventBody

## ININ.PureCloudApi.Model.ConversationChecklistTopicAgentChecklistRuntimeEventBody

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EvaluationStartDate** | **DateTime?** |  | [optional] |
| **EvaluationLastModifiedDate** | **DateTime?** |  | [optional] |
| **EvaluationFinalizedDate** | **DateTime?** |  | [optional] |
| **EvaluationFinalizedWithAcwDate** | **DateTime?** |  | [optional] |
| **ConversationId** | **Guid?** |  | [optional] |
| **CommunicationId** | **Guid?** |  | [optional] |
| **AgentChecklistId** | **Guid?** |  | [optional] |
| **Name** | **string** |  | [optional] |
| **Language** | **string** |  | [optional] |
| **AgentId** | **string** |  | [optional] |
| **ParticipantId** | **string** |  | [optional] |
| **QueueId** | **Guid?** |  | [optional] |
| **AssistantId** | **Guid?** |  | [optional] |
| **MediaType** | **string** |  | [optional] |
| **Direction** | **string** |  | [optional] |
| **Status** | **string** |  | [optional] |
| **ExitReason** | **string** |  | [optional] |
| **ActivationTriggers** | [**List&lt;ConversationChecklistTopicAgentChecklistActivationTrigger&gt;**](ConversationChecklistTopicAgentChecklistActivationTrigger) |  | [optional] |
| **ConversationContext** | [**List&lt;ConversationChecklistTopicConversationContextTurnInfo&gt;**](ConversationChecklistTopicConversationContextTurnInfo) |  | [optional] |
| **AgentChecklistItems** | [**List&lt;ConversationChecklistTopicAgentChecklistItemState&gt;**](ConversationChecklistTopicAgentChecklistItemState) |  | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
