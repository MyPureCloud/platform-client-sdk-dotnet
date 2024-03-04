---
title: EvaluationFormResponse
---
## ININ.PureCloudApi.Model.EvaluationFormResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The evaluation form name | |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Published** | **bool?** |  | [optional] |
| **ContextId** | **string** |  | [optional] |
| **QuestionGroups** | [**List&lt;EvaluationQuestionGroup&gt;**](EvaluationQuestionGroup.html) | A list of question groups | [optional] |
| **WeightMode** | **string** | Mode for evaluation form weight | [optional] |
| **PublishedVersions** | [**DomainEntityListingEvaluationForm**](DomainEntityListingEvaluationForm.html) | A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable). | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


