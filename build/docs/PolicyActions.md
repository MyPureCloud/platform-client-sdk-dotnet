# PolicyActions

## ININ.PureCloudApi.Model.PolicyActions

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RetainRecording** | **bool?** | true to retain the recording associated with the conversation. Default &#x3D; true | [optional] |
| **DeleteRecording** | **bool?** | true to delete the recording associated with the conversation. If retainRecording &#x3D; true, this will be ignored. Default &#x3D; false | [optional] |
| **AlwaysDelete** | **bool?** | true to delete the recording associated with the conversation regardless of the values of retainRecording or deleteRecording. Default &#x3D; false | [optional] |
| **AssignEvaluations** | [**List&lt;EvaluationAssignment&gt;**](EvaluationAssignment) |  | [optional] |
| **AssignMeteredEvaluations** | [**List&lt;MeteredEvaluationAssignment&gt;**](MeteredEvaluationAssignment) |  | [optional] |
| **AssignMeteredAssignmentByAgent** | [**List&lt;MeteredAssignmentByAgent&gt;**](MeteredAssignmentByAgent) |  | [optional] |
| **AssignCalibrations** | [**List&lt;CalibrationAssignment&gt;**](CalibrationAssignment) |  | [optional] |
| **AssignSurveys** | [**List&lt;SurveyAssignment&gt;**](SurveyAssignment) |  | [optional] |
| **RetentionDuration** | [**RetentionDuration**](RetentionDuration) |  | [optional] |
| **InitiateScreenRecording** | [**InitiateScreenRecording**](InitiateScreenRecording) |  | [optional] |
| **MediaTranscriptions** | [**List&lt;MediaTranscription&gt;**](MediaTranscription) |  | [optional] |
| **IntegrationExport** | [**IntegrationExport**](IntegrationExport) | Policy action for exporting recordings using an integration to 3rd party s3. | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
