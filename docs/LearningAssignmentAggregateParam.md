# LearningAssignmentAggregateParam

## ININ.PureCloudApi.Model.LearningAssignmentAggregateParam

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Specifies the range of due dates to be used for filtering. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **Metrics** | **List&lt;string&gt;** | The list of metrics to be returned. If omitted, all metrics are returned. | [optional] |
| **GroupBy** | **List&lt;string&gt;** | Specifies if the aggregated data is combined into a single set of metrics (groupBy is empty or not specified), or contains an element per attendeeId (groupBy is \&quot;attendeeId\&quot;) | [optional] |
| **Filter** | [**LearningAssignmentAggregateQueryRequestFilter**](LearningAssignmentAggregateQueryRequestFilter) | The filter applied to the data.  This is ANDed with the interval parameter.  | |



_PureCloudPlatform.Client.V2 229.0.0_
