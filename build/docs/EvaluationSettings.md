# EvaluationSettings

## ININ.PureCloudApi.Model.EvaluationSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **RevisionsEnabled** | **bool?** | Whether revisions are allowed for evaluations. When enabled, rescoring creates a new version of the evaluation and retracts the existing evaluation version. Does not apply for calibration evaluations. | [optional] |
| **DisputesEnabled** | **bool?** | Whether disputes are allowed for evaluations. Does not apply for calibration evaluations. | [optional] |
| **DisputesAllowedPerEvaluation** | **int?** | The maximum number of disputes allowed for an evaluation. | [optional] |
| **DisputesAssignees** | [**List&lt;EvaluationSettingsAssignee&gt;**](EvaluationSettingsAssignee) | A list of assignees responsible for handling each dispute. This list size needs to be equal to disputesAllowedPerEvaluation. | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
