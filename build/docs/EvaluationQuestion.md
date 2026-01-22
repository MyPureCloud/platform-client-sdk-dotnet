# EvaluationQuestion

## ININ.PureCloudApi.Model.EvaluationQuestion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **ContextId** | **string** | An identifier for this question that stays the same across versions of the form. | [optional] |
| **Text** | **string** |  | [optional] |
| **HelpText** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **NaEnabled** | **bool?** |  | [optional] |
| **CommentsRequired** | **bool?** |  | [optional] |
| **VisibilityCondition** | [**VisibilityCondition**](VisibilityCondition) |  | [optional] |
| **AnswerOptions** | [**List&lt;AnswerOption&gt;**](AnswerOption) | Options from which to choose an answer for this question. Only used by Multiple Choice type questions. | [optional] |
| **MultipleSelectOptionQuestions** | [**List&lt;EvaluationQuestion&gt;**](EvaluationQuestion) | Only used by Multiple Select type questions. A list of multiple choice questions representing selectable options. | [optional] |
| **DefaultAnswer** | [**DefaultAnswer**](DefaultAnswer) | The default selected answer for the question | [optional] |
| **IsKill** | **bool?** |  | [optional] |
| **IsCritical** | **bool?** |  | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
