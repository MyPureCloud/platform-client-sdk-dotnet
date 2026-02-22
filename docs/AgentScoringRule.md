# AgentScoringRule

## ININ.PureCloudApi.Model.AgentScoringRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ProgramId** | **string** | The program ID that this rule belongs to. When provided in request body, this value is ignored in favor of the path parameter. | [optional] |
| **SamplingType** | **string** | Sampling type setting. Valid values: All, Percentage | |
| **SamplingPercentage** | **double?** | Percentage of interactions to evaluate (0.01-100.00). Required when samplingType is Percentage, null when All. | [optional] |
| **SubmissionType** | **string** | Submission type for evaluations. Valid values: Automated, Manual | |
| **EvaluationFormContextId** | **string** | The evaluation form contextID to use for scoring. | |
| **Enabled** | **bool?** | Whether the rule is enabled. | |
| **Published** | **bool?** | Whether the rule is published. | [optional] |
| **Evaluator** | [**AddressableEntityRef**](AddressableEntityRef) | The evaluator for evaluations created by this rule. | [optional] |
| **DateCreated** | **DateTime?** | Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the rule was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
