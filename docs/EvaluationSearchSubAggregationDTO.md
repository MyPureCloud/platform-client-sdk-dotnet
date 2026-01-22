# EvaluationSearchSubAggregationDTO

## ININ.PureCloudApi.Model.EvaluationSearchSubAggregationDTO

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the aggregation | |
| **Field** | **string** | The field to aggregate on.ALLOWED FIELDS BY AGGREGATION TYPE:TERM/COUNT: evaluationStatus, aiScoringFailureType, questionAiAnswerFailureType,TERM: formId, formIdReleased, contextId, questionGroupId, questionId, questionAnswerId, released, questionGroupMarkedNA, questionMarkedNA, questionAiScored, questionEaScored,SUM/AVERAGE/STATS/RANGE: totalScore, totalCriticalScore, questionGroupScorePercentage,criticalQuestionGroupScorePercentage, questionScore,SUM: disputeCount, rescoreCount, eaSuggestionCount, eaAcceptedSuggestionCount,aiSuggestionCount, aiAcceptedSuggestionCount,DATE_HISTOGRAM: conversationDate, createdDate, submittedDate, releaseDate | |
| **Type** | **string** | The Type of Aggregation to Perform | |
| **Size** | **int?** | The size limit for term aggregations, 100 size limit for all fields | [optional] |
| **CalendarInterval** | **string** | The calendar interval for date histogram aggregations | [optional] |
| **Format** | **string** | The format for date histogram aggregations | [optional] |
| **Ranges** | [**List&lt;QueryApiSearchAggregationRange&gt;**](QueryApiSearchAggregationRange) | The ranges for range aggregations | [optional] |
| **SubAggregations** | [**List&lt;EvaluationSearchSubAggregationDTO&gt;**](EvaluationSearchSubAggregationDTO) | Sub-aggregations to be computed within this aggregation | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
