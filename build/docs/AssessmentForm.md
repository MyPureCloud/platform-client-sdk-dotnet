---
title: AssessmentForm
---
## ININ.PureCloudApi.Model.AssessmentForm

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **DateModified** | **DateTime?** | Last modified date of the assessment form. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ContextId** | **string** | The unique Id for all versions of this assessment form | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Published** | **bool?** | If true, assessment form is published | [optional] |
| **PassPercent** | **int?** | The pass percent for the assessment form | |
| **QuestionGroups** | [**List&lt;AssessmentFormQuestionGroup&gt;**](AssessmentFormQuestionGroup.html) | A list of question groups | |
{: class="table table-striped"}


