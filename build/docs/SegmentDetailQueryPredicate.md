# SegmentDetailQueryPredicate

## ININ.PureCloudApi.Model.SegmentDetailQueryPredicate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Optional type, can usually be inferred | [optional] |
| **Dimension** | **string** | Left hand side for dimension predicates | [optional] |
| **PropertyType** | **string** | Left hand side for property predicates | [optional] |
| **Property** | **string** | Left hand side for property predicates | [optional] |
| **Metric** | **string** | Left hand side for metric predicates | [optional] |
| **Operator** | **string** | Optional operator, default is matches | [optional] |
| **Value** | **string** | Right hand side for dimension, metric, or property predicates | [optional] |
| **Range** | [**NumericRange**](NumericRange) | Right hand side for dimension, metric, or property predicates | [optional] |



_PureCloudPlatform.Client.V2 244.0.0_
