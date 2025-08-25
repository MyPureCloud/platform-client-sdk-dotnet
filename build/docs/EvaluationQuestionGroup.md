# EvaluationQuestionGroup

## ININ.PureCloudApi.Model.EvaluationQuestionGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **ContextId** | **string** | An identifier for this question group that stays the same across versions of the form. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **DefaultAnswersToHighest** | **bool?** |  | [optional] |
| **DefaultAnswersToNA** | **bool?** |  | [optional] |
| **NaEnabled** | **bool?** |  | [optional] |
| **Weight** | **float?** |  | [optional] |
| **ManualWeight** | **bool?** |  | [optional] |
| **Questions** | [**List&lt;EvaluationQuestion&gt;**](EvaluationQuestion) |  | [optional] |
| **VisibilityCondition** | [**VisibilityCondition**](VisibilityCondition) |  | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
