# AgentChecklistResponse

## ININ.PureCloudApi.Model.AgentChecklistResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | ID of the checklist. | |
| **Name** | **string** | Name of the checklist. | |
| **ChecklistItems** | [**List&lt;ChecklistItem&gt;**](ChecklistItem) | List of individual Checklist Items. | |
| **ActivationTriggers** | [**List&lt;ActivationTrigger&gt;**](ActivationTrigger) | List of triggers that activated this checklist. | [optional] |
| **Status** | **string** | The evaluation status of the checklist. | |
| **ExitReason** | **string** | Exit reason provided at the time of finalizing the checklist. | [optional] |
| **Language** | **string** | Language associated with the checklist. | |
| **AgentId** | **string** | Agent ID. | [optional] |
| **ParticipantId** | **string** | Participant ID. | [optional] |
| **QueueId** | **string** | Queue ID. | [optional] |
| **AssistantId** | **string** | Assistant ID. | [optional] |
| **MediaType** | **string** | Media type. | [optional] |
| **Direction** | **string** | Direction of the conversation. | [optional] |
| **EvaluationStartDate** | **DateTime?** | Date when the checklist evaluation began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EvaluationLastModifiedDate** | **DateTime?** | Date when the checklist was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EvaluationFinalizedDate** | **DateTime?** | Date when the checklist was finalized. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **EvaluationFinalizedWithAcwDate** | **DateTime?** | Date when the checklist was finalized with ACW. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
