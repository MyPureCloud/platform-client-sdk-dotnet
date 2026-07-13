# WorkdayMetric

## ININ.PureCloudApi.Model.WorkdayMetric

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metric** | [**Metric**](Metric) | Gamification metric | [optional] |
| **Objective** | [**Objective**](Objective) | Current objective for this metric | [optional] |
| **Points** | **int?** | Gamification points earned for this metric | [optional] |
| **MaxPoints** | **int?** | The maximum Gamification points a user may earn for this metric | [optional] |
| **Value** | **double?** | Value of this metric | [optional] |
| **PunctualityEvents** | [**List&lt;PunctualityEvent&gt;**](PunctualityEvent) | List of schedule activity events for punctuality metrics | [optional] |
| **BusinessUnitId** | **string** | The id of the business unit associated with this metric, only returned for metrics with punctuality events | [optional] |
| **EvaluationDetails** | [**List&lt;QualityEvaluationScoreItem&gt;**](QualityEvaluationScoreItem) | List of evaluations for quality evaluation score metrics | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
