# ClientPublicApiUsageResultsResponse

## ININ.PureCloudApi.Model.ClientPublicApiUsageResultsResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** |  | [optional] |
| **QueryStatus** | **string** | The status of the query. | |
| **ErrorBody** | [**ErrorBody**](ErrorBody) | The reason for the failure. This will only be present if the query is in a FAILURE state but may not be included even if the state is FAILURE | [optional] |
| **NextUri** | **string** | The uri to get the next set of results. Will only be included if there is another page to retrieve. | [optional] |
| **Entities** | [**List&lt;ClientPublicApiUsage&gt;**](ClientPublicApiUsage) | The results of the query. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
