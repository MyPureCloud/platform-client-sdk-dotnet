# SurveyQuestionGroupScore

## ININ.PureCloudApi.Model.SurveyQuestionGroupScore

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QuestionGroupId** | **string** |  | [optional] |
| **TotalScore** | **float?** | Score of all questions in the group | [optional] |
| **MaxTotalScore** | **float?** | Maximum possible score of all questions in the group | [optional] |
| **MarkedNA** | **bool?** | True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system | [optional] |
| **SystemMarkedNA** | **bool?** | If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false. | [optional] |
| **QuestionScores** | [**List&lt;SurveyQuestionScore&gt;**](SurveyQuestionScore) |  | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
