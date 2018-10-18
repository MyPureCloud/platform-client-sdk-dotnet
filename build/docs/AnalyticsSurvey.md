---
title: AnalyticsSurvey
---
## ININ.PureCloudApi.Model.AnalyticsSurvey

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SurveyId** | **string** | Unique identifier for the survey | [optional] |
| **SurveyFormId** | **string** | Unique identifier for the survey form | [optional] |
| **SurveyFormContextId** | **string** | Unique identifier for the survey form, regardless of version | [optional] |
| **EventTime** | **DateTime?** | Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **UserId** | **string** | A unique identifier of the PureCloud user | [optional] |
| **QueueId** | **string** | Unique identifier for the queue the conversation was on | [optional] |
| **Status** | **string** | Survey status | [optional] |
| **GetoSurveyTotalScore** | **long?** | Creation date of survey | [optional] |
| **SurveyPromoterScore** | **int?** | NPS score of the survey | [optional] |
| **GetsurveyCompletedDate** | **DateTime?** | Completion date/time of the survey. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **MediaTypes** | **List&lt;string&gt;** | Media types associated with the conversation | [optional] |
| **LanguageIds** | **List&lt;string&gt;** | Language IDs associated with the conversation | [optional] |
| **SkillIds** | **List&lt;string&gt;** | Skill IDs associated with the conversation | [optional] |
{: class="table table-striped"}


