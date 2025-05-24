# TranscriptConversationDetailSearchRequest

## ININ.PureCloudApi.Model.TranscriptConversationDetailSearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SortOrder** | **string** | The sort order for results | [optional] |
| **SortBy** | **string** | The field in the resource that you want to sort the results by | [optional] |
| **PageSize** | **int?** | The number of results per page | [optional] |
| **PageNumber** | **int?** | The page of resources you want to retrieve | [optional] |
| **Sort** | [**List&lt;SearchSort&gt;**](SearchSort) | Multi-value sort order, list of multiple sort values | [optional] |
| **Types** | **List&lt;string&gt;** | Resource domain type to search | |
| **Query** | [**List&lt;TranscriptConversationDetailSearchCriteria&gt;**](TranscriptConversationDetailSearchCriteria) | The search criteria | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
