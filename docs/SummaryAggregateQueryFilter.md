# SummaryAggregateQueryFilter

## ININ.PureCloudApi.Model.SummaryAggregateQueryFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Boolean operation to apply to the provided predicates and clauses | |
| **Clauses** | [**List&lt;SummaryAggregateQueryClause&gt;**](SummaryAggregateQueryClause) | Boolean &#39;and/or&#39; logic with up to two-levels of nesting | [optional] |
| **Predicates** | [**List&lt;SummaryAggregateQueryPredicate&gt;**](SummaryAggregateQueryPredicate) | Like a three-word sentence: (attribute-name) (operator) (target-value). | [optional] |



_PureCloudPlatform.Client.V2 224.1.0_