# Calibration

## ININ.PureCloudApi.Model.Calibration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Calibrator** | [**User**](User) |  | [optional] |
| **Agent** | [**User**](User) |  | [optional] |
| **Conversation** | [**ConversationReference**](ConversationReference) |  | [optional] |
| **EvaluationForm** | [**EvaluationForm**](EvaluationForm) |  | [optional] |
| **ContextId** | **string** |  | [optional] |
| **AverageScore** | **int?** |  | [optional] |
| **HighScore** | **int?** |  | [optional] |
| **LowScore** | **int?** |  | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Evaluations** | [**List&lt;Evaluation&gt;**](Evaluation) |  | [optional] |
| **Evaluators** | [**List&lt;User&gt;**](User) |  | [optional] |
| **ScoringIndex** | [**Evaluation**](Evaluation) |  | [optional] |
| **ExpertEvaluator** | [**User**](User) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
