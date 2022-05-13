---
title: CrossPlatformPolicyActions
---
## ININ.PureCloudApi.Model.CrossPlatformPolicyActions

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RetainRecording** | **bool?** | true to retain the recording associated with the conversation. Default &#x3D; true | [optional] |
| **DeleteRecording** | **bool?** | true to delete the recording associated with the conversation. If retainRecording &#x3D; true, this will be ignored. Default &#x3D; false | [optional] |
| **AlwaysDelete** | **bool?** | true to delete the recording associated with the conversation regardless of the values of retainRecording or deleteRecording. Default &#x3D; false | [optional] |
| **AssignEvaluations** | [**List&lt;EvaluationAssignment&gt;**](EvaluationAssignment.html) |  | [optional] |
| **AssignMeteredEvaluations** | [**List&lt;MeteredEvaluationAssignment&gt;**](MeteredEvaluationAssignment.html) |  | [optional] |
| **AssignMeteredAssignmentByAgent** | [**List&lt;MeteredAssignmentByAgent&gt;**](MeteredAssignmentByAgent.html) |  | [optional] |
| **AssignCalibrations** | [**List&lt;CalibrationAssignment&gt;**](CalibrationAssignment.html) |  | [optional] |
| **RetentionDuration** | [**RetentionDuration**](RetentionDuration.html) |  | [optional] |
| **MediaTranscriptions** | [**List&lt;MediaTranscription&gt;**](MediaTranscription.html) |  | [optional] |
| **IntegrationExport** | [**IntegrationExport**](IntegrationExport.html) | Policy action for exporting recordings using an integration to 3rd party s3. | [optional] |
{: class="table table-striped"}


