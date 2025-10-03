# BuAsyncAgentSchedulesSearchResponse

## ININ.PureCloudApi.Model.BuAsyncAgentSchedulesSearchResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of the operation | [optional] |
| **OperationId** | **string** | The ID for the operation | [optional] |
| **Result** | [**BuAgentSchedulesSearchResponse**](BuAgentSchedulesSearchResponse) | The result of the operation.  Null unless status &#x3D;&#x3D; Complete | [optional] |
| **Progress** | **int?** | Percent progress for the operation | [optional] |
| **DownloadUrl** | **string** | The URL from which to download the result if it is too large to pass directly | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
