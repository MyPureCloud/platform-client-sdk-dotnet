# EvaluationSearchAggregationBucket

## ININ.PureCloudApi.Model.EvaluationSearchAggregationBucket

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Key** | **string** | The key for this bucket | [optional] |
| **KeyAsString** | **string** | The key as a string representation | [optional] |
| **DocumentCount** | **long?** | Number of documents in this bucket | [optional] |
| **KeyValue** | **long?** | Numeric key value for date histograms | [optional] |
| **From** | **double?** | Lower bound for range buckets | [optional] |
| **To** | **double?** | Upper bound for range buckets | [optional] |
| **Value** | **double?** | Simple aggregation value | [optional] |
| **Count** | **long?** | Count of documents | [optional] |
| **Minimum** | **double?** | Minimum value in the aggregation | [optional] |
| **Maximum** | **double?** | Maximum value in the aggregation | [optional] |
| **Average** | **double?** | Average value in the aggregation | [optional] |
| **Sum** | **double?** | Sum of values in the aggregation | [optional] |
| **SubAggregations** | [**Dictionary&lt;string, EvaluationSearchAggregationResponse&gt;**](EvaluationSearchAggregationResponse) | Nested sub-aggregations | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
