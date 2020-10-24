---
title: EvaluationForm
---
## ININ.PureCloudApi.Model.EvaluationForm

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The evaluation form name | |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Published** | **bool?** |  | [optional] |
| **ContextId** | **string** |  | [optional] |
| **QuestionGroups** | [**List&lt;EvaluationQuestionGroup&gt;**](EvaluationQuestionGroup.html) | A list of question groups | |
| **PublishedVersions** | [**DomainEntityListingEvaluationForm**](DomainEntityListingEvaluationForm.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


