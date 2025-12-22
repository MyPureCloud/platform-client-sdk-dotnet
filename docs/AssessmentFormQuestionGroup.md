# AssessmentFormQuestionGroup

## ININ.PureCloudApi.Model.AssessmentFormQuestionGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the question group, | [optional] |
| **Name** | **string** | The question group name | |
| **Type** | **string** | The question group type | |
| **ContextId** | **string** | An identifier for this question group that stays the same across versions of the form. | [optional] |
| **DefaultAnswersToHighest** | **bool?** |  | [optional] |
| **DefaultAnswersToNA** | **bool?** |  | [optional] |
| **NaEnabled** | **bool?** |  | [optional] |
| **Weight** | **float?** |  | [optional] |
| **ManualWeight** | **bool?** |  | [optional] |
| **Questions** | [**List&lt;AssessmentFormQuestion&gt;**](AssessmentFormQuestion) | The list of questions for this question group | |
| **VisibilityCondition** | [**VisibilityCondition**](VisibilityCondition) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
