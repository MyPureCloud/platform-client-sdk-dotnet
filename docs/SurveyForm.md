# SurveyForm

## ININ.PureCloudApi.Model.SurveyForm

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The survey form name | |
| **ModifiedDate** | **DateTime?** | Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Published** | **bool?** | Is this form published | [optional] |
| **Disabled** | **bool?** | Is this form disabled | [optional] |
| **ContextId** | **string** | Unique Id for all versions of this form | |
| **Language** | **string** | Language for survey viewer localization. Currently localized languages: da, de, en-US, es, fi, fr, it, ja, ko, nl, no, pl, pt-BR, sv, th, tr, zh-CH, zh-TW | |
| **Header** | **string** | Markdown text for the top of the form. | [optional] |
| **Footer** | **string** | Markdown text for the bottom of the form. | [optional] |
| **QuestionGroups** | [**List&lt;SurveyQuestionGroup&gt;**](SurveyQuestionGroup) | A list of question groups | [optional] |
| **PublishedVersions** | [**DomainEntityListingSurveyForm**](DomainEntityListingSurveyForm) | List of published version of this form | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
