# OrganizationPublicApiUsageQueryRequest

## ININ.PureCloudApi.Model.OrganizationPublicApiUsageQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Interval** | **string** | Specify the interval to query on. Start and end are inclusive. Start date cannot be more than a year ago. End date cannot be more than 90 days after the start. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss | |
| **Granularity** | **string** | Specify the granularity to aggregate the data to. | [optional] |
| **SortBy** | [**List&lt;UsageQuerySortBy&gt;**](UsageQuerySortBy) | Specify how to sort the returned data. | [optional] |
| **Metrics** | **List&lt;string&gt;** | Specify which metrics you want returned (all will be returned by default). | [optional] |
| **TemplateUris** | **List&lt;string&gt;** | Specify if you only want a subset of templateUris represented in the query. | [optional] |
| **HttpMethods** | **List&lt;string&gt;** | Specify if you only want a subset of httpMethods represented in the query. | [optional] |
| **Platforms** | **List&lt;string&gt;** | Specify if you only want a subset of platforms represented in the query. | [optional] |
| **GroupBy** | **List&lt;string&gt;** | Specify how to aggregate the data (by default the data is not aggregated). | [optional] |
| **UserIds** | **List&lt;string&gt;** | Specify if you only want a subset of userIds represented in the query. | [optional] |
| **OauthClientIds** | **List&lt;string&gt;** | Specify if you only want a subset of oauthClientIds represented in the query. | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
