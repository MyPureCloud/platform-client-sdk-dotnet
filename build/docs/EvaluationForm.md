# EvaluationForm

## ININ.PureCloudApi.Model.EvaluationForm

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The evaluation form name | |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Published** | **bool?** |  | [optional] |
| **ContextId** | **string** |  | [optional] |
| **QuestionGroups** | [**List&lt;EvaluationQuestionGroup&gt;**](EvaluationQuestionGroup) | A list of question groups | |
| **PublishedVersions** | [**DomainEntityListingEvaluationForm**](DomainEntityListingEvaluationForm) | A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable). | [optional] |
| **EvaluationSettings** | [**EvaluationSettings**](EvaluationSettings) | Settings for evaluations associated with this form | [optional] |
| **LatestVersionFormName** | **string** | The name of the form&#39;s most recently published version | [optional] |
| **AiScoring** | [**AiScoringSettings**](AiScoringSettings) | AI scoring settings for the evaluation form. | [optional] |
| **Dialect** | **string** | The language dialect for this evaluation form. Supported dialects: ar, cs, da, de, en-US, es, fi, fr, fr-CA, he, hi, it, ja, ko, nl, no, pl, pt-BR, pt-PT, ru, sv, th, tr, uk, zh-CN, zh-TW | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
