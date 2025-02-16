# EvaluationCreateBody

## ININ.PureCloudApi.Model.EvaluationCreateBody

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **EvaluationForm** | [**EvaluationCreateEvalForm**](EvaluationCreateEvalForm) | Evaluation form used for evaluation (must be included for a successful request) | [optional] |
| **Evaluator** | [**EvaluationCreateUser**](EvaluationCreateUser) | User ID of the evaluator (must be included for a successful request) | [optional] |
| **Agent** | [**EvaluationCreateUser**](EvaluationCreateUser) | User ID of the agent (must be included for a successful request) | [optional] |
| **AgentHasRead** | **bool?** |  | [optional] |
| **Answers** | [**EvaluationScoringSet**](EvaluationScoringSet) |  | [optional] |
| **Calibration** | [**EvaluationCreateCalibration**](EvaluationCreateCalibration) |  | [optional] |
| **EvaluationContextId** | **string** |  | [optional] |
| **Conversation** | [**EvaluationCreateConversation**](EvaluationCreateConversation) |  | [optional] |
| **ResourceType** | **string** |  | [optional] |
| **EvaluationSource** | [**EvaluationSource**](EvaluationSource) |  | [optional] |
| **Rescore** | **bool?** |  | [optional] |
| **Queue** | [**EvaluationCreateQueue**](EvaluationCreateQueue) |  | [optional] |
| **ReleaseDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** |  | [optional] |
| **NeverRelease** | **bool?** |  | [optional] |
| **DateAssigneeChanged** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Assignee** | [**EvaluationCreateUser**](EvaluationCreateUser) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 227.0.0_
