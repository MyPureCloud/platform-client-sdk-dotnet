# EvaluationSearchAggregationResponse

## ININ.PureCloudApi.Model.EvaluationSearchAggregationResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Value** | **double?** | Simple aggregation value (for SUM, COUNT, AVERAGE, etc.) | [optional] |
| **Count** | **long?** | Count of documents | [optional] |
| **Minimum** | **double?** | Minimum value | [optional] |
| **Maximum** | **double?** | Maximum value | [optional] |
| **Average** | **double?** | Average value | [optional] |
| **Sum** | **double?** | Total Sum | [optional] |
| **DocumentCountErrorUpperBound** | **long?** | Upper bound estimate of the error in document count for this aggregation | [optional] |
| **SumOtherDocumentCount** | **long?** | Total document count for buckets not included in the response due to size limits | [optional] |
| **Buckets** | [**List&lt;EvaluationSearchAggregationBucket&gt;**](EvaluationSearchAggregationBucket) | List of aggregation buckets | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
