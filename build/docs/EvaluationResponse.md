# EvaluationResponse

## ININ.PureCloudApi.Model.EvaluationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Conversation** | [**ConversationReference**](ConversationReference) |  | [optional] |
| **EvaluationForm** | [**EvaluationFormResponse**](EvaluationFormResponse) | Evaluation form used for evaluation. | [optional] |
| **Evaluator** | [**User**](User) |  | [optional] |
| **Agent** | [**User**](User) |  | [optional] |
| **Status** | **string** |  | [optional] |
| **Answers** | [**EvaluationScoringSet**](EvaluationScoringSet) |  | [optional] |
| **AgentHasRead** | **bool?** |  | [optional] |
| **Assignee** | [**User**](User) |  | [optional] |
| **AssigneeApplicable** | **bool?** | Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable. | [optional] |
| **ReleaseDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AssignedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ChangedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **RevisionCreatedDate** | **DateTime?** | Date of when evaluation revision is created. Null if there is no revision. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Queue** | [**Queue**](Queue) |  | [optional] |
| **MediaType** | **List&lt;string&gt;** | List of different communication types used in conversation. | [optional] |
| **Rescore** | **bool?** | Is only true when evaluation is re-scored. | [optional] |
| **ConversationDate** | **DateTime?** | Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConversationEndDate** | **DateTime?** | End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **NeverRelease** | **bool?** | Signifies if the evaluation is never to be released. This cannot be set true if release date is also set. | [optional] |
| **Assigned** | **bool?** | Set to false to unassign the evaluation. This cannot be set to false when assignee is also set. | [optional] |
| **DateAssigneeChanged** | **DateTime?** | Date when the assignee was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ResourceId** | **string** | Only used for email evaluations. Will be null for all other evaluations. | [optional] |
| **ResourceType** | **string** | The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources. | [optional] |
| **Redacted** | **bool?** | Is only true when the user making the request does not have sufficient permissions to see evaluation | [optional] |
| **IsScoringIndex** | **bool?** |  | [optional] |
| **AuthorizedActions** | **List&lt;string&gt;** | List of user authorized actions on evaluation. Possible values: assign, edit, editScore, editAgentSignoff, delete, release, viewAudit | [optional] |
| **HasAssistanceFailed** | **bool?** | Is true when evaluation assistance didn&#39;t execute successfully | [optional] |
| **EvaluationSource** | [**EvaluationSource**](EvaluationSource) | The source that created the evaluation. | [optional] |
| **AiScoring** | [**AiScoring**](AiScoring) | AI scoring details for the evaluation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Calibration** | [**AddressableEntityRef**](AddressableEntityRef) |  | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
