# CommonRulePredicate

## ININ.PureCloudApi.Model.CommonRulePredicate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MetricType** | **string** | The type of metric being evaluated. | |
| **MetricValueType** | **string** | The type of metric value being evaluated. | |
| **ComparisonOperator** | **string** | The comparison operator being performed on the metric. | |
| **Value** | **double?** | The value the metric will be compared to. | |
| **Status** | **string** | The status of the entity corresponding to the metric. | [optional] |
| **Topic** | **string** | The operational console topic corresponding to the metric. | [optional] |
| **Entity** | [**CommonRulePredicateEntity**](CommonRulePredicateEntity) | The entity whose metric is being represented. | |
| **MediaType** | **string** | The media type of the conversation the metric describes. | [optional] |
| **Metric** | **string** | The metric being evaluated. | |



_PureCloudPlatform.Client.V2 252.0.0_
