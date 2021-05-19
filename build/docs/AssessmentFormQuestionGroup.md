---
title: AssessmentFormQuestionGroup
---
## ININ.PureCloudApi.Model.AssessmentFormQuestionGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the question group, | [optional] |
| **Name** | **string** | The question group name | |
| **Type** | **string** | The question group type | |
| **DefaultAnswersToHighest** | **bool?** |  | [optional] |
| **DefaultAnswersToNA** | **bool?** |  | [optional] |
| **NaEnabled** | **bool?** |  | [optional] |
| **Weight** | **float?** |  | [optional] |
| **ManualWeight** | **bool?** |  | [optional] |
| **Questions** | [**List&lt;AssessmentFormQuestion&gt;**](AssessmentFormQuestion.html) | The list of questions for this question group | |
| **VisibilityCondition** | [**VisibilityCondition**](VisibilityCondition.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


