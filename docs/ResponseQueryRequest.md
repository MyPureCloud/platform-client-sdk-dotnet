# ResponseQueryRequest

## ININ.PureCloudApi.Model.ResponseQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **QueryPhrase** | **string** | Query phrase to search response text and name. If not set will match all. | [optional] |
| **PageSize** | **int?** | The maximum number of hits to return. Default: 25, Maximum: 500. | [optional] |
| **PageNumber** | **int?** | Page Number | [optional] |
| **Filters** | [**List&lt;ResponseFilter&gt;**](ResponseFilter) | Filter the query results. | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
