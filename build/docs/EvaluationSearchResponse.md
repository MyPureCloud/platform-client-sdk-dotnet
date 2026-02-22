# EvaluationSearchResponse

## ININ.PureCloudApi.Model.EvaluationSearchResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageSize** | **int?** | Number of records according to the page size | [optional] |
| **PageNumber** | **int?** | Current page number for the returned records | [optional] |
| **Results** | [**List&lt;EvaluationResponse&gt;**](EvaluationResponse) | Results associated to the search response | [optional] |
| **Aggregations** | [**Dictionary&lt;string, EvaluationSearchAggregationResponse&gt;**](EvaluationSearchAggregationResponse) | Aggregation results | [optional] |



_PureCloudPlatform.Client.V2 257.0.0_
