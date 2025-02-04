# EvaluationQuestionScore

## ININ.PureCloudApi.Model.EvaluationQuestionScore

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QuestionId** | **string** |  | [optional] |
| **AnswerId** | **string** |  | [optional] |
| **Score** | **int?** | Unweighted score of the question | [optional] |
| **MarkedNA** | **bool?** | True when the evaluation is submitted with a question that does not have an answer. Only allowed when naEnabled is true or if set by the system | [optional] |
| **SystemMarkedNA** | **bool?** | If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false. | [optional] |
| **AssistedAnswerId** | **string** | AnswerId found with evaluation assistance conditions | [optional] |
| **FailedKillQuestion** | **bool?** | Applicable only on fatal questions. Indicates that the answer selected was not the highest score available for the question | [optional] |
| **Comments** | **string** | Comments from the evaluator specific to this question | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
