---
title: LearningModulePreviewUpdateResponseAssignment
---
## ININ.PureCloudApi.Model.LearningModulePreviewUpdateResponseAssignment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The Learning Assignment state | [optional] |
| **PercentageScore** | **float?** | The user&#39;s percentage score for this assignment | [optional] |
| **CompletionPercentage** | **float?** | The overall completion percentage of assignment | [optional] |
| **AssessmentPercentageScore** | **float?** | The user&#39;s percentage score for this assignment&#39;s assessment | [optional] |
| **AssessmentCompletionPercentage** | **float?** | The assessment completion percentage of assignment | [optional] |
| **IsPassed** | **bool?** | True if the assessment was passed | [optional] |
| **CurrentStep** | [**LearningModulePreviewUpdateResponseCurrentStep**](LearningModulePreviewUpdateResponseCurrentStep.html) | The next assignment step | [optional] |
| **Steps** | [**List&lt;LearningModulePreviewUpdateStep&gt;**](LearningModulePreviewUpdateStep.html) | List of assignment steps | [optional] |
{: class="table table-striped"}

