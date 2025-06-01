# AssessmentQuestionGroupScore

## ININ.PureCloudApi.Model.AssessmentQuestionGroupScore

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QuestionGroupId** | **string** | The ID of the question group | |
| **TotalScore** | **float?** | The total score for the questions | [optional] |
| **MaxTotalScore** | **float?** | The maximum total score for the questions | [optional] |
| **MarkedNA** | **bool?** | True if this question group is marked NA | [optional] |
| **SystemMarkedNA** | **bool?** | If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false. | [optional] |
| **TotalCriticalScore** | **float?** | The total score for the critical questions | [optional] |
| **MaxTotalCriticalScore** | **float?** | The maximum total score for the critical questions | [optional] |
| **TotalNonCriticalScore** | **float?** | The total score for the non-critical questions | [optional] |
| **MaxTotalNonCriticalScore** | **float?** | The maximum total score for the non-critical questions | [optional] |
| **TotalScoreUnweighted** | **float?** | The unweighted total score for this question group | [optional] |
| **MaxTotalScoreUnweighted** | **float?** | The maximum unweighted total score for this question group | [optional] |
| **TotalCriticalScoreUnweighted** | **float?** | The unweighted total score for the critical questions | [optional] |
| **MaxTotalCriticalScoreUnweighted** | **float?** | The maximum unweighted total score for the critical questions | [optional] |
| **TotalNonCriticalScoreUnweighted** | **float?** | The total unweighted score for the non-critical questions | [optional] |
| **MaxTotalNonCriticalScoreUnweighted** | **float?** | The maximum unweighted total score for the non-critical questions | [optional] |
| **QuestionScores** | [**List&lt;AssessmentQuestionScore&gt;**](AssessmentQuestionScore) | The individual question scores | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
