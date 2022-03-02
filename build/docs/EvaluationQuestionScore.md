---
title: EvaluationQuestionScore
---
## ININ.PureCloudApi.Model.EvaluationQuestionScore

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QuestionId** | **string** |  | [optional] |
| **AnswerId** | **string** |  | [optional] |
| **Score** | **int?** | Unweighted score of the question | [optional] |
| **MarkedNA** | **bool?** |  | [optional] |
| **AssistedAnswerId** | **string** | AnswerId found with evaluation assistance conditions | [optional] |
| **FailedKillQuestion** | **bool?** | Applicable only on fatal questions. Indicates that the answer selected was not the highest score available for the question | [optional] |
| **Comments** | **string** | Comments from the evaluator specific to this question | [optional] |
{: class="table table-striped"}


