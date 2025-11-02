# AsyncConversationQuery

## ININ.PureCloudApi.Model.AsyncConversationQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ConversationFilters** | [**List&lt;ConversationDetailQueryFilter&gt;**](ConversationDetailQueryFilter) | Filters that target conversation-level data | [optional] |
| **SegmentFilters** | [**List&lt;SegmentDetailQueryFilter&gt;**](SegmentDetailQueryFilter) | Filters that target individual segments within a conversation | [optional] |
| **EvaluationFilters** | [**List&lt;EvaluationDetailQueryFilter&gt;**](EvaluationDetailQueryFilter) | Filters that target evaluations | [optional] |
| **SurveyFilters** | [**List&lt;SurveyDetailQueryFilter&gt;**](SurveyDetailQueryFilter) | Filters that target surveys | [optional] |
| **ResolutionFilters** | [**List&lt;ResolutionDetailQueryFilter&gt;**](ResolutionDetailQueryFilter) | Filters that target resolutions | [optional] |
| **Order** | **string** | Sort the result set in ascending/descending order. Default is ascending | [optional] |
| **OrderBy** | **string** | Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart | [optional] |
| **Interval** | **string** | Specifies the date and time range of data being queried. Results will include all conversations that had activity during the interval. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **Limit** | **int?** | Specify number of results to be returned | [optional] |
| **StartOfDayIntervalMatching** | **bool?** | Add a filter to only include conversations that started after the beginning of the interval start date (UTC) | [optional] |



_PureCloudPlatform.Client.V2 247.0.0_
