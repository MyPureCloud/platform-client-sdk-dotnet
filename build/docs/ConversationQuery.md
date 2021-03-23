---
title: ConversationQuery
---
## ININ.PureCloudApi.Model.ConversationQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ConversationFilters** | [**List&lt;ConversationDetailQueryFilter&gt;**](ConversationDetailQueryFilter.html) | Filters that target conversation-level data | [optional] |
| **SegmentFilters** | [**List&lt;SegmentDetailQueryFilter&gt;**](SegmentDetailQueryFilter.html) | Filters that target individual segments within a conversation | [optional] |
| **EvaluationFilters** | [**List&lt;EvaluationDetailQueryFilter&gt;**](EvaluationDetailQueryFilter.html) | Filters that target evaluations | [optional] |
| **SurveyFilters** | [**List&lt;SurveyDetailQueryFilter&gt;**](SurveyDetailQueryFilter.html) | Filters that target surveys | [optional] |
| **ResolutionFilters** | [**List&lt;ResolutionDetailQueryFilter&gt;**](ResolutionDetailQueryFilter.html) | Filters that target resolutions | [optional] |
| **Order** | **string** | Sort the result set in ascending/descending order. Default is ascending | [optional] |
| **OrderBy** | **string** | Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart | [optional] |
| **Interval** | **string** | Specifies the date and time range of data being queried. Results will only include conversations that started on a day touched by the interval. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **Aggregations** | [**List&lt;AnalyticsQueryAggregation&gt;**](AnalyticsQueryAggregation.html) | Include faceted search and aggregate roll-ups describing your search results. This does not function as a filter, but rather, summary data about the data matching your filters | [optional] |
| **Paging** | [**PagingSpec**](PagingSpec.html) | Page size and number to control iterating through large result sets. Default page size is 25 | [optional] |
{: class="table table-striped"}


