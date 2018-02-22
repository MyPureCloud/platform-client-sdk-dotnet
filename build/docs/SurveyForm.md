---
title: SurveyForm
---
## ININ.PureCloudApi.Model.SurveyForm

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The survey form name | |
| **ModifiedDate** | **DateTime?** | Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Published** | **bool?** | Is this form published | [optional] |
| **Disabled** | **bool?** | Is this form disabled | [optional] |
| **ContextId** | **string** | Unique Id for all versions of this form | |
| **Header** | **string** | Id of the header image appearing at the top of the form. | [optional] |
| **Footer** | **string** | Markdown text for the bottom of the form. | [optional] |
| **QuestionGroups** | [**List&lt;QuestionGroup&gt;**](QuestionGroup.html) | A list of question groups | |
| **PublishedVersions** | [**DomainEntityListingSurveyForm**](DomainEntityListingSurveyForm.html) | List of published version of this form | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


