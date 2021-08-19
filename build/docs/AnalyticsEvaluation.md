---
title: AnalyticsEvaluation
---
## ININ.PureCloudApi.Model.AnalyticsEvaluation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CalibrationId** | **string** | The calibration ID used for the purpose of training evaluators | [optional] |
| **ContextId** | **string** | A unique identifier for an evaluation form, regardless of version | [optional] |
| **Deleted** | **bool?** | Whether the evaluation has been deleted | [optional] |
| **EvaluationId** | **string** | Unique identifier for the evaluation | [optional] |
| **EvaluatorId** | **string** | A unique identifier of the user who evaluated the interaction | [optional] |
| **EventTime** | **DateTime?** | Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **FormId** | **string** | ID of the evaluation form used | [optional] |
| **FormName** | **string** | Name of the evaluation form used | [optional] |
| **QueueId** | **string** | The ID of the associated queue | [optional] |
| **Released** | **bool?** | Whether the evaluation has been released | [optional] |
| **Rescored** | **bool?** | Whether the evaluation has been rescored at least once | [optional] |
| **UserId** | **string** | ID of the agent the evaluation was performed against | [optional] |
| **OTotalCriticalScore** | **long?** |  | [optional] |
| **OTotalScore** | **long?** |  | [optional] |
{: class="table table-striped"}


