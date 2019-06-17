---
title: PolicyActions
---
## ININ.PureCloudApi.Model.PolicyActions

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RetainRecording** | **bool?** | true to retain the recording associated with the conversation. Default = true | [optional] |
| **DeleteRecording** | **bool?** | true to delete the recording associated with the conversation. If retainRecording = true, this will be ignored. Default = false | [optional] |
| **AlwaysDelete** | **bool?** | true to delete the recording associated with the conversation regardless of the values of retainRecording or deleteRecording. Default = false | [optional] |
| **AssignEvaluations** | [**List&lt;EvaluationAssignment&gt;**](EvaluationAssignment.html) |  | [optional] |
| **AssignMeteredEvaluations** | [**List&lt;MeteredEvaluationAssignment&gt;**](MeteredEvaluationAssignment.html) |  | [optional] |
| **AssignMeteredAssignmentByAgent** | [**List&lt;MeteredAssignmentByAgent&gt;**](MeteredAssignmentByAgent.html) |  | [optional] |
| **AssignCalibrations** | [**List&lt;CalibrationAssignment&gt;**](CalibrationAssignment.html) |  | [optional] |
| **AssignSurveys** | [**List&lt;SurveyAssignment&gt;**](SurveyAssignment.html) |  | [optional] |
| **RetentionDuration** | [**RetentionDuration**](RetentionDuration.html) |  | [optional] |
| **InitiateScreenRecording** | [**InitiateScreenRecording**](InitiateScreenRecording.html) |  | [optional] |
| **MediaTranscriptions** | [**List&lt;MediaTranscription&gt;**](MediaTranscription.html) |  | [optional] |
{: class="table table-striped"}


