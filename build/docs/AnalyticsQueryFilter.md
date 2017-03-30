---
title: AnalyticsQueryFilter
---
## ININ.PureCloudApi.Model.AnalyticsQueryFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Boolean operation to apply to the provided predicates and clauses | |
| **Clauses** | [**List&lt;AnalyticsQueryClause&gt;**](AnalyticsQueryClause.html) | Boolean &#39;and/or&#39; logic with up to two-levels of nesting | [optional] |
| **Predicates** | [**List&lt;AnalyticsQueryPredicate&gt;**](AnalyticsQueryPredicate.html) | Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric. | [optional] |
{: class="table table-striped"}


