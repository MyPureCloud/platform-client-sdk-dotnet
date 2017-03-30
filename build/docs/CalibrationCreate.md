---
title: CalibrationCreate
---
## ININ.PureCloudApi.Model.CalibrationCreate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Calibrator** | [**User**](User.html) |  | [optional] |
| **Agent** | [**User**](User.html) |  | [optional] |
| **Conversation** | [**Conversation**](Conversation.html) | The conversation to use for the calibration. | |
| **EvaluationForm** | [**EvaluationForm**](EvaluationForm.html) |  | [optional] |
| **ContextId** | **string** |  | [optional] |
| **AverageScore** | **int?** |  | [optional] |
| **HighScore** | **int?** |  | [optional] |
| **LowScore** | **int?** |  | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Evaluations** | [**List&lt;Evaluation&gt;**](Evaluation.html) |  | [optional] |
| **Evaluators** | [**List&lt;User&gt;**](User.html) |  | [optional] |
| **ScoringIndex** | [**Evaluation**](Evaluation.html) |  | [optional] |
| **ExpertEvaluator** | [**User**](User.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


