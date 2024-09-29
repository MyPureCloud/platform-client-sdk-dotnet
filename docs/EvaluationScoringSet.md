# EvaluationScoringSet

## ININ.PureCloudApi.Model.EvaluationScoringSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TotalScore** | **float?** | Score of all questions | [optional] |
| **TotalCriticalScore** | **float?** | Score of only the critical questions | [optional] |
| **TotalNonCriticalScore** | **float?** | Score of only the non-critical questions | [optional] |
| **QuestionGroupScores** | [**List&lt;EvaluationQuestionGroupScore&gt;**](EvaluationQuestionGroupScore) |  | [optional] |
| **AnyFailedKillQuestions** | **bool?** | Indicates that at least one fatal question was answered without having the highest score available for the question | [optional] |
| **Comments** | **string** | Overall comments from the evaluator | [optional] |
| **PrivateComments** | **string** | Overall private comments from the evaluator | [optional] |
| **AgentComments** | **string** | Comments from the agent while reviewing evaluation results | [optional] |
| **TranscriptTopics** | [**List&lt;TranscriptTopic&gt;**](TranscriptTopic) | List of topics found within the conversation&#39;s transcripts | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
