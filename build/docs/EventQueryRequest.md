# EventQueryRequest

## ININ.PureCloudApi.Model.EventQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **EventDefinitionIds** | **List&lt;string&gt;** | Filter events by a list of event definition ids | [optional] |
| **SearchTerm** | **string** | Only return events that contain the search term | [optional] |
| **SortOrder** | **string** | Order of results. Default order is DESC. | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
