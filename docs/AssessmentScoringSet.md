# AssessmentScoringSet

## ININ.PureCloudApi.Model.AssessmentScoringSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TotalScore** | **float?** | The total score of the answers | [optional] |
| **TotalCriticalScore** | **float?** | The total score for the critical questions | [optional] |
| **TotalNonCriticalScore** | **float?** | The total score for the non-critical questions | [optional] |
| **QuestionGroupScores** | [**List&lt;AssessmentQuestionGroupScore&gt;**](AssessmentQuestionGroupScore) | The individual scores for each question group | |
| **FailureReasons** | **List&lt;string&gt;** | If the assessment was not passed, the reasons for failure. | [optional] |
| **Comments** | **string** | Comments provided for these answers. | [optional] |
| **AgentComments** | **string** | Comments provided by agent. | [optional] |
| **IsPassed** | **bool?** | True if the assessment was passed | [optional] |



_PureCloudPlatform.Client.V2 229.0.0_
