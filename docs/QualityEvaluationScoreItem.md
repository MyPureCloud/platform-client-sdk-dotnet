# QualityEvaluationScoreItem

## ININ.PureCloudApi.Model.QualityEvaluationScoreItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EvaluationId** | **string** | The id of evaluation | [optional] |
| **ConversationId** | **string** | The id of conversation | [optional] |
| **ConversationDate** | **DateTime?** | The date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConversationEndDate** | **DateTime?** | The end date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **FormName** | **string** | The name of form | [optional] |
| **Points** | **int?** | Gamification points earned for this metric | [optional] |
| **EvaluationScore** | **double?** | The quality score of evaluation as a percentage | [optional] |
| **MaxPoints** | **int?** | The maximum Gamification points a user may earn for this metric | [optional] |
| **MediaTypes** | **List&lt;string&gt;** | A list of media types for the metric | [optional] |



_PureCloudPlatform.Client.V2 236.0.0_
