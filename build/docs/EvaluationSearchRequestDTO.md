# EvaluationSearchRequestDTO

## ININ.PureCloudApi.Model.EvaluationSearchRequestDTO

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | [**List&lt;EvaluationSearchCriteriaDTO&gt;**](EvaluationSearchCriteriaDTO) |  | |
| **Aggregations** | [**List&lt;EvaluationSearchAggregationDTO&gt;**](EvaluationSearchAggregationDTO) | Aggregations to compute on the search results | [optional] |
| **PageSize** | **int?** | The number of results per page. For aggregation requests, must be omitted or 0. | [optional] |
| **PageNumber** | **int?** | The page of resources you want to retrieve | |
| **SortOrder** | **string** | The sort order for results. Include with sortBy. | [optional] |
| **SortBy** | **string** | The field in the resource that you want to sort the results by. Include with sortOrder. | [optional] |
| **SystemSubmitted** | **bool?** | Filter for automated evaluations submitted by virtual supervisor. Defaults to false. | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
