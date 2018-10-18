---
title: AnalyticsEvaluation
---
## ININ.PureCloudApi.Model.AnalyticsEvaluation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EvaluationId** | **string** | Unique identifier for the evaluation | [optional] |
| **EvaluatorId** | **string** | A unique identifier of the PureCloud user who evaluated the interaction | [optional] |
| **UserId** | **string** | Unique identifier for the user being evaluated | [optional] |
| **EventTime** | **DateTime?** | Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **QueueId** | **string** | Unique identifier for the queue the conversation was on | [optional] |
| **FormId** | **string** | Unique identifier for the form used to evaluate the conversation/agent | [optional] |
| **ContextId** | **string** | A unique identifier for an evaluation form, regardless of version | [optional] |
| **FormName** | **string** | Name of the evaluation form | [optional] |
| **GetoTotalScore** | **long?** | The total evaluation for interactions | [optional] |
| **GetoTotalCriticalScore** | **long?** | The score for critical evaluation questions | [optional] |
{: class="table table-striped"}


