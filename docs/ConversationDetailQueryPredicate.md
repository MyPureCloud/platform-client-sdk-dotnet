# ConversationDetailQueryPredicate

## ININ.PureCloudApi.Model.ConversationDetailQueryPredicate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Optional type, can usually be inferred | [optional] |
| **Dimension** | **string** | Left hand side for dimension predicates | [optional] |
| **Metric** | **string** | Left hand side for metric predicates | [optional] |
| **Operator** | **string** | Optional operator, default is matches | [optional] |
| **Value** | **string** | Right hand side for dimension or metric predicates | [optional] |
| **Range** | [**NumericRange**](NumericRange) | Right hand side for dimension or metric predicates | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_
