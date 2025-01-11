# EvaluationQuestionGroupScore

## ININ.PureCloudApi.Model.EvaluationQuestionGroupScore

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QuestionGroupId** | **string** |  | [optional] |
| **TotalScore** | **float?** | Score of all questions in the group | [optional] |
| **MaxTotalScore** | **float?** | Maximum possible score of all questions in the group | [optional] |
| **MarkedNA** | **bool?** | True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system | [optional] |
| **SystemMarkedNA** | **bool?** | If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false. | [optional] |
| **TotalCriticalScore** | **float?** | Score of only the critical questions in the group | [optional] |
| **MaxTotalCriticalScore** | **float?** | Maximum possible score of only the critical questions in the group | [optional] |
| **TotalNonCriticalScore** | **float?** | Score of only the non critical questions in the group | [optional] |
| **MaxTotalNonCriticalScore** | **float?** | Maximum possible score of only the non critical questions in the group | [optional] |
| **TotalScoreUnweighted** | **float?** | Unweighted score of all questions in the group | [optional] |
| **MaxTotalScoreUnweighted** | **float?** | Maximum possible unweighted score of all questions in the group | [optional] |
| **TotalCriticalScoreUnweighted** | **float?** | Unweighted score of only the critical questions in the group | [optional] |
| **MaxTotalCriticalScoreUnweighted** | **float?** | Maximum possible unweighted score of only the critical questions in the group | [optional] |
| **TotalNonCriticalScoreUnweighted** | **float?** | Unweighted score of only the non critical questions in the group | [optional] |
| **MaxTotalNonCriticalScoreUnweighted** | **float?** | Maximum possible unweighted score of only the non critical questions in the group | [optional] |
| **QuestionScores** | [**List&lt;EvaluationQuestionScore&gt;**](EvaluationQuestionScore) |  | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
